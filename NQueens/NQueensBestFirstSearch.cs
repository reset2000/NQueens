using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NQueens {
    class NQueensBestFirstSearch {
        internal class WeighedState { 
            public int heuristicValue;
            public List<int> state;

            public WeighedState(int heuristicValue, List<int> state) {
                this.heuristicValue = heuristicValue;
                this.state = state;
            }
        }

        internal class WeighedStateComparer : IComparer<WeighedState> {
            public int Compare( WeighedState x, WeighedState y ) {
                return x.heuristicValue.CompareTo(y.heuristicValue);
            }
        }

        int n;
        string heuristic;
        List<WeighedState> stateList;
        WeighedStateComparer wsComparer;

        private int createdStates;
        private int searchedStates;
        private double duration;

        private int[] rowsWeights;

        public int CreatedStates { get => createdStates; }
        public int SearchedStates { get => searchedStates; }
        public double Duration { get => duration; }
        public int N { get => n; }
        public string Heuristic { get => heuristic; }

        public NQueensBestFirstSearch(int n, string heuristic) {
            if(n < 0) {
                throw new Exception("Błędna ilość hetmanów (licza musi być nieujemna).");
            }
            
            this.n = n;
            this.heuristic = heuristic;

            Initialize();
        }

        void Initialize() {
            int startingStateHeuristicValue = -1;
            List<int> startingStateList = new List<int>();

            WeighedState startingState = new WeighedState(startingStateHeuristicValue, startingStateList);
            wsComparer = new WeighedStateComparer();

            stateList = new List<WeighedState>();

            WeighRows();

            createdStates = 0;
            searchedStates = 0;
            duration = 0;

            stateList.Add(startingState);
            createdStates++;
        }

        private void WeighRows() {
            rowsWeights = new int[n];

            for(int i = 0; i < rowsWeights.Length; i++) {
                int rowNumber = i + 1;

                if (rowNumber < ( n / 2 ) ) {
                    rowsWeights[i] = n - rowNumber + 1;
                } else {
                    rowsWeights[i] = rowNumber;
                }
            }
        }

        public List<int> Run() {
            WeighedState resultState = null;
            WeighedState currentState = null;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stateList.Count != 0) {
                stateList.Sort(wsComparer);
                currentState = stateList[0];
                stateList.RemoveAt(0);
                searchedStates++;

                if ( CheckAndGenerate(ref currentState.state) ) {
                    resultState = currentState;
                    break;
                }
            }

            stopwatch.Stop();
            duration = stopwatch.Elapsed.TotalMilliseconds;

            return resultState.state;
        }

        public List<int> RunCutBranches() {
            WeighedState resultState = null;
            WeighedState currentState = null;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stateList.Count != 0) {
                stateList.Sort(wsComparer);
                currentState = stateList[0];
                stateList.RemoveAt(0);
                searchedStates++;

                if (CheckAndGenerateCutBranches(ref currentState.state)) {
                    resultState = currentState;
                    break;
                }
            }

            stopwatch.Stop();
            duration = stopwatch.Elapsed.TotalMilliseconds;

            return resultState.state;
        }

        bool CheckAndGenerate(ref List<int> currentState) {
            if (currentState.Count == N) {
                for(int i = 0; i < currentState.Count; i++) {
                    for(int j = i + 1; j < currentState.Count; j++) {
                        if ( (currentState[i] == currentState[j] ) || ( Math.Abs(currentState[i] - currentState[j]) == Math.Abs(i - j) ) ) {
                            GenerateChildStates(ref currentState);
                            return false;
                        }
                    }
                }

                return true;
            }

            GenerateChildStates(ref currentState);
            return false;
        }

        bool CheckAndGenerateCutBranches(ref List<int> currentState) {
            for (int i = 0; i < currentState.Count; i++) {
                for (int j = i + 1; j < currentState.Count; j++) {
                    if (( currentState[i] == currentState[j] ) || ( Math.Abs(currentState[i] - currentState[j]) == Math.Abs(i - j) )) {
                        return false;
                    }
                }
            }

            if (currentState.Count == N) {
                return true;
            }

            GenerateChildStates(ref currentState);
            return false;
        }

        void GenerateChildStates(ref List<int> currentState) {
            if (currentState.Count != N) {
                for (int row = 0; row < N; row++) {
                    List<int> newStateList = new List<int>(currentState);
                    newStateList.Add(row);

                    int heuristicValue = -1;
                    switch(heuristic) {
                        case "H1":
                            heuristicValue = H1(newStateList);
                            break;
                        case "H2":
                            heuristicValue = H2(newStateList);
                            break;
                        case "H3":
                            heuristicValue = H3(newStateList);
                            break;
                        //case "H4":
                        //    heuristicValue = H4(newStateList);
                        //    break;
                        default:
                            heuristicValue = H1(newStateList);
                            break;
                    }

                    stateList.Add( new WeighedState(heuristicValue, newStateList) );
                    createdStates++;
                }
            }

            if (currentState != null) {
                currentState = null;
            }
        }

        private int H1(List<int> state) {
            int heuristicValue = (n - state.Count);

            int weightSum = 0;
            for(int i = 0; i < state.Count; i++) {
                weightSum += rowsWeights[i];
            }

            heuristicValue *= weightSum;

            return heuristicValue;
        }

        private int H2(List<int> state) {
            bool[,] chessboard = new bool[n, n];

            for (int v = 0; v < state.Count; v++) {
                for (int r = 0; r < n; r++) {
                    chessboard[r, v] = true;
                }

                for (int c = 0; c < n; c++) {
                    chessboard[state[v], c] = true;
                }
            }

            for (int r = 0; r < n; r++) {
                for (int c = 0; c < n; c++) {
                    if(!chessboard[r, c]) {
                        for (int vi = 0; vi < state.Count; vi++) {
                            if ( Math.Abs( c - vi ) == Math.Abs( r - state[vi] ) ) {
                                chessboard[r, c] = true;
                                break;
                            }
                        }
                    }
                }
            }

            int heuristicValue = 0;
            for (int r = 0; r < n; r++) {
                for (int c = 0; c < n; c++) {
                    if (chessboard[r, c]) {
                        heuristicValue++;
                    }
                }
            }

            return heuristicValue;
        }

        private int H3(List<int> state) {
            int heuristicValue = 0;
            int currentValue = 0;
            int maxValue = 0;

            for (int i = 0; i < state.Count; i++) {
                for (int j = i + 1; j < state.Count; j++) {
                    if (state[i] != state[j]) {
                        currentValue++;
                    }

                    maxValue++;
                }
            }

            heuristicValue = maxValue - currentValue;

            return heuristicValue;
        }

        //private int H4(List<int> state) {
        //    return 0;
        //}
    }
}
