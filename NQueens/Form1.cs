using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NQueens {
    public partial class nQueens : Form {
        List<NQueensBFS> testsBFS;
        List<NQueensDFS> testsDFS;
        List<NQueensBestFirstSearch> testsBestFirstSearch;

        public nQueens() {
            InitializeComponent();

            testsBFS = new List<NQueensBFS>();
            testsDFS = new List<NQueensDFS>();
            testsBestFirstSearch = new List<NQueensBestFirstSearch>();

            cbHeuristic.Text = "H1";

            nudPop.Value = 6;
            nudGen.Value = 5000;
            nudCrossover.Value = 0.5M;
            nudMutation.Value = 0.1M;
        }

        private void Form1_Load( object sender, EventArgs e ) {
            nudNValue.Value = 0;
        }

        private void btnNormalBFS_Click( object sender, EventArgs e ) {
            testsBFS.Clear();
            rtbResultBFS.Clear();
            txbDurationBFS.Clear();
            txbSearchedStatesBFS.Clear();
            txbCreatedStatesBFS.Clear();

            if (cbTestMulti.Checked) {
                rtbResultBFS.Text += "Test dla n od 4 do ";
                rtbResultBFS.Text += nudNValue.Value.ToString();
                rtbResultBFS.Text += ":\n\n";

                for (int i = 4; i <= nudNValue.Value; i++) {
                    NQueensBFS nQ = new NQueensBFS(i);

                    nQ.Run();
                    testsBFS.Add(nQ);
                    rtbResultBFS.Text += "Test dla n = ";
                    rtbResultBFS.Text += i.ToString();
                    rtbResultBFS.Text += "\n";
                }

                StringBuilder sb = new StringBuilder();
                foreach (NQueensBFS el in testsBFS) {
                    sb.Append(el.N);
                    sb.Append(";");
                    sb.Append(el.Duration);
                    sb.Append(";");
                    sb.Append(el.SearchedStates);
                    sb.Append(";");
                    sb.Append(el.CreatedStates);
                    sb.Append(";");
                    sb.Append("\n");
                }

                SaveToFile(sb, "data_BFS_slow.csv");

                rtbResultBFS.Text += "\nTest zakończony sukcesem!";
                rtbResultBFS.Text += "\nWygenerowano plik dane.csv.";
            } else {
                NQueensBFS nQ = new NQueensBFS(Convert.ToInt32(nudNValue.Value));

                rtbResultBFS.Clear();
                List<int> finalState = nQ.Run();

                if (finalState != null) {
                    foreach (var el in finalState.Select(( value, idx ) => new { value, idx })) {
                        rtbResultBFS.Text += "Hetman ";
                        rtbResultBFS.Text += el.idx;
                        rtbResultBFS.Text += ": wiersz - ";
                        rtbResultBFS.Text += el.value;
                        rtbResultBFS.Text += ", kolumna - ";
                        rtbResultBFS.Text += el.idx;
                        rtbResultBFS.Text += "\n";
                    }
                } else {
                    rtbResultBFS.Text += "Brak rozwiązania";
                }

                txbDurationBFS.Text = nQ.Duration.ToString();
                txbDurationBFS.Text += " ms";
                txbSearchedStatesBFS.Text = nQ.SearchedStates.ToString();
                txbCreatedStatesBFS.Text = nQ.CreatedStates.ToString();
            }
        }

        private void btnCutBranchesBFS_Click( object sender, EventArgs e ) {
            testsBFS.Clear();
            rtbResultBFS.Clear();
            txbDurationBFS.Clear();
            txbSearchedStatesBFS.Clear();
            txbCreatedStatesBFS.Clear();

            if (cbTestMulti.Checked) {
                rtbResultBFS.Text += "Test dla n od 4 do ";
                rtbResultBFS.Text += nudNValue.Value.ToString();
                rtbResultBFS.Text += ":\n\n";

                for (int i = 4; i <= nudNValue.Value; i++) {
                    NQueensBFS nQ = new NQueensBFS(i);

                    nQ.RunCutBranches();
                    testsBFS.Add(nQ);
                    rtbResultBFS.Text += "Test dla n = ";
                    rtbResultBFS.Text += i.ToString();
                    rtbResultBFS.Text += "\n";
                }

                StringBuilder sb = new StringBuilder();
                foreach (NQueensBFS el in testsBFS) {
                    sb.Append(el.N);
                    sb.Append(";");
                    sb.Append(el.Duration);
                    sb.Append(";");
                    sb.Append(el.SearchedStates);
                    sb.Append(";");
                    sb.Append(el.CreatedStates);
                    sb.Append(";");
                    sb.Append("\n");
                }

                SaveToFile(sb, "data_BFS_fast.csv");

                rtbResultBFS.Text += "\nTest zakończony sukcesem!";
                rtbResultBFS.Text += "\nWygenerowano plik dane.csv.";
            } else {
                NQueensBFS nQ = new NQueensBFS(Convert.ToInt32(nudNValue.Value));

                rtbResultBFS.Clear();
                List<int> finalState = nQ.RunCutBranches();

                if (finalState != null) {
                    foreach (var el in finalState.Select(( value, idx ) => new { value, idx })) {
                        rtbResultBFS.Text += "Hetman ";
                        rtbResultBFS.Text += el.idx;
                        rtbResultBFS.Text += ": wiersz - ";
                        rtbResultBFS.Text += el.value;
                        rtbResultBFS.Text += ", kolumna - ";
                        rtbResultBFS.Text += el.idx;
                        rtbResultBFS.Text += "\n";
                    }
                } else {
                    rtbResultBFS.Text += "Brak rozwiązania";
                }

                txbDurationBFS.Text = nQ.Duration.ToString();
                txbDurationBFS.Text += " ms";
                txbSearchedStatesBFS.Text = nQ.SearchedStates.ToString();
                txbCreatedStatesBFS.Text = nQ.CreatedStates.ToString();
            }
        }

        private void btnNormalDFS_Click( object sender, EventArgs e ) {
            testsDFS.Clear();
            rtbResultDFS.Clear();
            txbDurationDFS.Clear();
            txbSearchedStatesDFS.Clear();
            txbCreatedStatesDFS.Clear();

            if (cbTestMulti.Checked) {
                rtbResultDFS.Text += "Test dla n od 4 do ";
                rtbResultDFS.Text += nudNValue.Value.ToString();
                rtbResultDFS.Text += ":\n\n";

                for (int i = 4; i <= nudNValue.Value; i++) {
                    NQueensDFS nQ = new NQueensDFS(i);

                    nQ.Run();
                    testsDFS.Add(nQ);
                    rtbResultDFS.Text += "Test dla n = ";
                    rtbResultDFS.Text += i.ToString();
                    rtbResultDFS.Text += "\n";
                }

                StringBuilder sb = new StringBuilder();
                foreach (NQueensDFS el in testsDFS) {
                    sb.Append(el.N);
                    sb.Append(";");
                    sb.Append(el.Duration);
                    sb.Append(";");
                    sb.Append(el.SearchedStates);
                    sb.Append(";");
                    sb.Append(el.CreatedStates);
                    sb.Append(";");
                    sb.Append("\n");
                }

                SaveToFile(sb, "data_DFS_slow.csv");

                rtbResultDFS.Text += "\nTest zakończony sukcesem!";
                rtbResultDFS.Text += "\nWygenerowano plik dane.csv.";
            } else {
                NQueensDFS nQ = new NQueensDFS(Convert.ToInt32(nudNValue.Value));

                rtbResultDFS.Clear();
                List<int> finalState = nQ.Run();

                if (finalState != null) {
                    foreach (var el in finalState.Select(( value, idx ) => new { value, idx })) {
                        rtbResultDFS.Text += "Hetman ";
                        rtbResultDFS.Text += el.idx;
                        rtbResultDFS.Text += ": wiersz - ";
                        rtbResultDFS.Text += el.value;
                        rtbResultDFS.Text += ", kolumna - ";
                        rtbResultDFS.Text += el.idx;
                        rtbResultDFS.Text += "\n";
                    }
                } else {
                    rtbResultDFS.Text += "Brak rozwiązania";
                }

                txbDurationDFS.Text = nQ.Duration.ToString();
                txbDurationDFS.Text += " ms";
                txbSearchedStatesDFS.Text = nQ.SearchedStates.ToString();
                txbCreatedStatesDFS.Text = nQ.CreatedStates.ToString();
            }
        }

        private void btnCutBranchesDFS_Click( object sender, EventArgs e ) {
            testsDFS.Clear();
            rtbResultDFS.Clear();
            txbDurationDFS.Clear();
            txbSearchedStatesDFS.Clear();
            txbCreatedStatesDFS.Clear();

            if (cbTestMulti.Checked) {
                rtbResultDFS.Text += "Test dla n od 4 do ";
                rtbResultDFS.Text += nudNValue.Value.ToString();
                rtbResultDFS.Text += ":\n\n";

                for (int i = 4; i <= nudNValue.Value; i++) {
                    NQueensDFS nQ = new NQueensDFS(i);

                    nQ.RunCutBranches();
                    testsDFS.Add(nQ);
                    rtbResultDFS.Text += "Test dla n = ";
                    rtbResultDFS.Text += i.ToString();
                    rtbResultDFS.Text += "\n";
                }

                StringBuilder sb = new StringBuilder();
                foreach (NQueensDFS el in testsDFS) {
                    sb.Append(el.N);
                    sb.Append(";");
                    sb.Append(el.Duration);
                    sb.Append(";");
                    sb.Append(el.SearchedStates);
                    sb.Append(";");
                    sb.Append(el.CreatedStates);
                    sb.Append(";");
                    sb.Append("\n");
                }

                SaveToFile(sb, "data_DFS_fast.csv");

                rtbResultDFS.Text += "\nTest zakończony sukcesem!";
                rtbResultDFS.Text += "\nWygenerowano plik dane.csv.";
            } else {
                NQueensDFS nQ = new NQueensDFS(Convert.ToInt32(nudNValue.Value));

                rtbResultDFS.Clear();
                List<int> finalState = nQ.RunCutBranches();

                if (finalState != null) {
                    foreach (var el in finalState.Select(( value, idx ) => new { value, idx })) {
                        rtbResultDFS.Text += "Hetman ";
                        rtbResultDFS.Text += el.idx;
                        rtbResultDFS.Text += ": wiersz - ";
                        rtbResultDFS.Text += el.value;
                        rtbResultDFS.Text += ", kolumna - ";
                        rtbResultDFS.Text += el.idx;
                        rtbResultDFS.Text += "\n";
                    }
                } else {
                    rtbResultDFS.Text += "Brak rozwiązania";
                }

                txbDurationDFS.Text = nQ.Duration.ToString();
                txbDurationDFS.Text += " ms";
                txbSearchedStatesDFS.Text = nQ.SearchedStates.ToString();
                txbCreatedStatesDFS.Text = nQ.CreatedStates.ToString();
            }
        }

        private void btnNormalBestFirstSearch_Click( object sender, EventArgs e ) {
            testsBestFirstSearch.Clear();
            rtbResultBestFirstSearch.Clear();
            txbDurationBestFirstSearch.Clear();
            txbSearchedStatesBestFirstSearch.Clear();
            txbCreatedStatesBestFirstSearch.Clear();

            if (cbTestMulti.Checked) {
                rtbResultBestFirstSearch.Text += "Test dla n od 4 do ";
                rtbResultBestFirstSearch.Text += nudNValue.Value.ToString();
                rtbResultBestFirstSearch.Text += ":\n\n";

                for (int i = 4; i <= nudNValue.Value; i++) {
                    NQueensBestFirstSearch nQ = new NQueensBestFirstSearch(i, cbHeuristic.Text);

                    nQ.Run();
                    testsBestFirstSearch.Add(nQ);
                    rtbResultBestFirstSearch.Text += "Test dla n = ";
                    rtbResultBestFirstSearch.Text += i.ToString();
                    rtbResultBestFirstSearch.Text += "\n";
                }

                StringBuilder sb = new StringBuilder();
                foreach (NQueensBestFirstSearch el in testsBestFirstSearch) {
                    sb.Append(el.N);
                    sb.Append(";");
                    sb.Append(el.Duration);
                    sb.Append(";");
                    sb.Append(el.SearchedStates);
                    sb.Append(";");
                    sb.Append(el.CreatedStates);
                    sb.Append(";");
                    sb.Append("\n");
                }

                SaveToFile(sb, "data_BestFirstSearch_" + cbHeuristic.Text + "_slow.csv");

                rtbResultBestFirstSearch.Text += "\nTest zakończony sukcesem!";
                rtbResultBestFirstSearch.Text += "\nWygenerowano plik dane.csv.";
            } else {
                NQueensBestFirstSearch nQ = new NQueensBestFirstSearch(Convert.ToInt32(nudNValue.Value), cbHeuristic.Text);

                rtbResultBestFirstSearch.Clear();
                List<int> finalState = nQ.Run();

                if (finalState != null) {
                    foreach (var el in finalState.Select(( value, idx ) => new { value, idx })) {
                        rtbResultBestFirstSearch.Text += "Hetman ";
                        rtbResultBestFirstSearch.Text += el.idx;
                        rtbResultBestFirstSearch.Text += ": wiersz - ";
                        rtbResultBestFirstSearch.Text += el.value;
                        rtbResultBestFirstSearch.Text += ", kolumna - ";
                        rtbResultBestFirstSearch.Text += el.idx;
                        rtbResultBestFirstSearch.Text += "\n";
                    }
                } else {
                    rtbResultBestFirstSearch.Text += "Brak rozwiązania";
                }

                txbDurationBestFirstSearch.Text = nQ.Duration.ToString();
                txbDurationBestFirstSearch.Text += " ms";
                txbSearchedStatesBestFirstSearch.Text = nQ.SearchedStates.ToString();
                txbCreatedStatesBestFirstSearch.Text = nQ.CreatedStates.ToString();
            }
        }

        private void btnCutBranchesBestFirstSearch_Click( object sender, EventArgs e ) {
            testsBestFirstSearch.Clear();
            rtbResultBestFirstSearch.Clear();
            txbDurationBestFirstSearch.Clear();
            txbSearchedStatesBestFirstSearch.Clear();
            txbCreatedStatesBestFirstSearch.Clear();

            if (cbTestMulti.Checked) {
                rtbResultBestFirstSearch.Text += "Test dla n od 4 do ";
                rtbResultBestFirstSearch.Text += nudNValue.Value.ToString();
                rtbResultBestFirstSearch.Text += ":\n\n";

                for (int i = 4; i <= nudNValue.Value; i++) {
                    NQueensBestFirstSearch nQ = new NQueensBestFirstSearch(i, cbHeuristic.Text);

                    nQ.RunCutBranches();
                    testsBestFirstSearch.Add(nQ);
                    rtbResultBestFirstSearch.Text += "Test dla n = ";
                    rtbResultBestFirstSearch.Text += i.ToString();
                    rtbResultBestFirstSearch.Text += "\n";
                }

                StringBuilder sb = new StringBuilder();
                foreach (NQueensBestFirstSearch el in testsBestFirstSearch) {
                    sb.Append(el.N);
                    sb.Append(";");
                    sb.Append(el.Duration);
                    sb.Append(";");
                    sb.Append(el.SearchedStates);
                    sb.Append(";");
                    sb.Append(el.CreatedStates);
                    sb.Append(";");
                    sb.Append("\n");
                }

                SaveToFile(sb, "data_BestFirstSearch_" + cbHeuristic.Text + "_fast.csv");

                rtbResultBestFirstSearch.Text += "\nTest zakończony sukcesem!";
                rtbResultBestFirstSearch.Text += "\nWygenerowano plik dane.csv.";
            } else {
                NQueensBestFirstSearch nQ = new NQueensBestFirstSearch(Convert.ToInt32(nudNValue.Value), cbHeuristic.Text);

                rtbResultBestFirstSearch.Clear();
                List<int> finalState = nQ.RunCutBranches();

                if (finalState != null) {
                    foreach (var el in finalState.Select(( value, idx ) => new { value, idx })) {
                        rtbResultBestFirstSearch.Text += "Hetman ";
                        rtbResultBestFirstSearch.Text += el.idx;
                        rtbResultBestFirstSearch.Text += ": wiersz - ";
                        rtbResultBestFirstSearch.Text += el.value;
                        rtbResultBestFirstSearch.Text += ", kolumna - ";
                        rtbResultBestFirstSearch.Text += el.idx;
                        rtbResultBestFirstSearch.Text += "\n";
                    }
                } else {
                    rtbResultBestFirstSearch.Text += "Brak rozwiązania";
                }

                txbDurationBestFirstSearch.Text = nQ.Duration.ToString();
                txbDurationBestFirstSearch.Text += " ms";
                txbSearchedStatesBestFirstSearch.Text = nQ.SearchedStates.ToString();
                txbCreatedStatesBestFirstSearch.Text = nQ.CreatedStates.ToString();
            }
        }

        private void SaveToFile( StringBuilder sb, string fileName ) {
            System.IO.File.WriteAllText(fileName, sb.ToString());
        }

        private void btnGen_Click( object sender, EventArgs e ) {
            NQueensGenetic nQ = new NQueensGenetic(
                Convert.ToInt32(nudNValue.Value),
                Convert.ToInt32(nudPop.Value),
                Convert.ToInt32(nudGen.Value),
                Convert.ToDecimal(nudCrossover.Value),
                Convert.ToDecimal(nudMutation.Value)
            );

            List<int> best = nQ.EvolutionAlgorithm();
            int generationsCnt = nQ.generationsCnt;

            txbBest.Text = " ";
            for (int i = 0; i < best.Count() - 1; i++) {
                txbBest.Text += Convert.ToString( best[i] );
                txbBest.Text += " ";
            }

            txbBestValue.Text = Convert.ToString( best[best.Count() - 1] );
            txbGen.Text = Convert.ToString( generationsCnt );

            return;
        }
    }
}