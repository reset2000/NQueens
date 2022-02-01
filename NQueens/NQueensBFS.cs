using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NQueens {
    class NQueensBFS {
        int n;
        Queue<List<int>> stateQueue;

        private int createdStates;
        private int searchedStates;
        private double duration;

        public int CreatedStates { get => createdStates; }
        public int SearchedStates { get => searchedStates; }
        public double Duration { get => duration; }
        public int N { get => n; }

        public NQueensBFS( int n ) {
            if (n < 0) {
                throw new Exception("Błędna ilość hetmanów (licza musi być nieujemna).");
            }

            this.n = n;

            Initialize();
        }

        void Initialize() {
            stateQueue = new Queue<List<int>>();
            List<int> startingState = new List<int>();

            createdStates = 0;
            searchedStates = 0;
            duration = 0;

            stateQueue.Enqueue(startingState);
            createdStates++;
        }

        public List<int> Run() {
            List<int> resultState = null;
            List<int> currentState = null;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stateQueue.Count != 0) {
                currentState = stateQueue.Dequeue();
                searchedStates++;

                if (CheckAndGenerate(ref currentState)) {
                    resultState = currentState;
                    break;
                }
            }

            stopwatch.Stop();
            duration = stopwatch.Elapsed.TotalMilliseconds;

            return resultState;
        }
        public List<int> RunCutBranches() {
            List<int> resultState = null;
            List<int> currentState = null;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stateQueue.Count != 0) {
                currentState = stateQueue.Dequeue();
                searchedStates++;

                if (CheckAndGenerateCutBranches(ref currentState)) {
                    resultState = currentState;
                    break;
                }
            }

            stopwatch.Stop();
            duration = stopwatch.Elapsed.TotalMilliseconds;

            return resultState;
        }

        bool CheckAndGenerate( ref List<int> currentState ) {
            if (currentState.Count == N) {
                for (int i = 0; i < currentState.Count; i++) {
                    for (int j = i + 1; j < currentState.Count; j++) {
                        if (( currentState[i] == currentState[j] ) || ( Math.Abs(currentState[i] - currentState[j]) == Math.Abs(i - j) )) {
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

        bool CheckAndGenerateCutBranches( ref List<int> currentState ) {
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

        void GenerateChildStates( ref List<int> currentState ) {
            if (currentState.Count != N) {
                for (int row = 0; row < N; row++) {
                    List<int> newState = new List<int>(currentState);

                    newState.Add(row);
                    stateQueue.Enqueue(newState);
                    createdStates++;
                }
            }

            if (currentState != null) {
                currentState = null;
            }
        }
    }
}
