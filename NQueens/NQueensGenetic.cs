using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueens {
    class NQueensGenetic {
        const int BEST_EVALUATE_VALUE = 0;
        int bestIdx = 0;

        int n;
        int populationCnt;
        int generations;
        decimal crossoverFactor;
        decimal mutationFactor;

        List<List<int>> population;
        Random random;

        public int generationsCnt;

        public NQueensGenetic( int n, int populationCnt, int generations, decimal crossoverFactor, decimal mutationFactor ) {
            this.n = n;
            this.populationCnt = populationCnt;
            this.generations = generations;
            this.crossoverFactor = crossoverFactor;
            this.mutationFactor = mutationFactor;

            population = new List<List<int>>();
            random = new Random();
        }

        public List<int> EvolutionAlgorithm() {
            string pythonFile = null;
            pythonFile += "import numpy as np\nimport matplotlib.pyplot as plt\n\n";

            SetStartingPopulation();
            bestIdx = EvaluateState();

            string averages = null;
            string bests = null;

            averages += "avg = [";
            bests += "best = [";

            decimal averageValue = 0;
            decimal bestValue = 0;
            for (generationsCnt = 0; ( generationsCnt < generations ) && ( population[bestIdx][n] > BEST_EVALUATE_VALUE ); generationsCnt++) {
                averageValue = 0;
                bestValue = 0;

                SelectNewPopulation();
                CrossoverPopulation();
                MutatePopulation();
                bestIdx = EvaluateState();

                averageValue = EvaluateAverage();
                bestValue = population[bestIdx][n];

                averages += averageValue.ToString(System.Globalization.CultureInfo.InvariantCulture) + ", ";
                bests += bestValue.ToString(System.Globalization.CultureInfo.InvariantCulture) + ", ";
            }

            averages += "]\n";
            bests += "]\n";

            pythonFile +=
                averages +
                bests;

            pythonFile +=
                "\nplt.subplot(2, 2, 1)\n" +
                "plt.plot(np.arange(0, len(best)), best)\n" +
                "plt.xlabel('Generations');\n" +
                "plt.ylabel('Value');\n" +
                "plt.legend(['Best'])\n\n" +
                "plt.subplot(2, 2, 2)\n" +
                "plt.plot(np.arange(0, len(avg)), avg)\n" +
                "plt.xlabel('Generations');\n" +
                "plt.ylabel('Value');\n" +
                "plt.legend(['Average'])\n\n" +
                "plt.subplot(2, 2, (3, 4))\n" +
                "plt.plot(np.arange(0, len(avg)), best)\n" +
                "plt.plot(np.arange(0, len(avg)), avg)\n" +
                "plt.xlabel('Generations');\n" +
                "plt.ylabel('Value');\n" +
                "plt.legend(['Best', 'Average'])\n\n" +
                "plt.show()\n";

            File.WriteAllTextAsync("diagrams.py", pythonFile);

            return population[bestIdx];
        }

        void SetStartingPopulation() {
            List<int> allRowPositions;

            while (population.Count() < populationCnt) {
                allRowPositions = Enumerable.Range(0, n).ToList();

                List<int> populationMember = new List<int>();
                for (int j = 0; j < n; j++) {
                    int randomIdx = random.Next(0, allRowPositions.Count());

                    populationMember.Add(allRowPositions[randomIdx]);
                    allRowPositions.RemoveAt(randomIdx);
                }

                if (!population.Contains(populationMember)) {
                    populationMember.Add(-1);
                    population.Add(populationMember);
                }
            }

            return;
        }

        int EvaluateState() {
            bestIdx = 0;
            for (int pop = 0; pop < populationCnt; pop++) {

                int memberValue = 0;
                for (int i = 0; i < population[pop].Count; i++) {
                    for (int j = i + 1; j < population[pop].Count; j++) {
                        if (Math.Abs(population[pop][i] - population[pop][j]) == Math.Abs(i - j)) {
                            memberValue++;
                        }
                    }
                }
                population[pop][n] = memberValue;

                if (population[pop][n] < population[bestIdx][n]) {
                    bestIdx = pop;
                }
            }

            return bestIdx;
        }

        void SelectNewPopulation() {
            List<List<int>> newPopulation = new List<List<int>>();

            while (newPopulation.Count < populationCnt) {
                int firstRandomIdx = random.Next(0, populationCnt);
                int secondRandomIdx = random.Next(0, populationCnt);

                if (firstRandomIdx == secondRandomIdx) {
                    continue;
                }

                if (population[firstRandomIdx][n] < population[secondRandomIdx][n]) {
                    newPopulation.Add(population[firstRandomIdx]);
                } else {
                    newPopulation.Add(population[secondRandomIdx]);
                }
            }

            population = newPopulation;
        }

        void CrossoverPopulation() {
            for (int i = 0; i < populationCnt - 2; i += 2) {
                decimal crossoverChance = Convert.ToDecimal(random.NextDouble());

                if (crossoverChance.CompareTo(crossoverFactor) != 1) {
                    Crossover(i, i + 1);
                }
            }
        }

        void Crossover( int firstIdx, int secondIdx ) {
            List<int> firstMember = new List<int>(population[firstIdx]);
            List<int> secondMember = new List<int>(population[secondIdx]);

            int crossStartIdx = random.Next(0, n); ;
            int crossEndIdx = random.Next(crossStartIdx, n); ;

            Cross(firstMember, population[secondIdx], crossStartIdx, crossEndIdx);
            Cross(secondMember, population[firstIdx], crossStartIdx, crossEndIdx);

            population[firstIdx] = firstMember;
            population[secondIdx] = secondMember;

            return;
        }

        void Cross( List<int> oldMember, List<int> memberToCrossWith, int startIdx, int endIdx ) {
            Stack<int> unusedElements = new Stack<int>();
            for (int i = startIdx; i <= endIdx; i++) {
                int repeatedIdx = oldMember.IndexOf(memberToCrossWith[i]);

                if (repeatedIdx == -1) {
                    unusedElements.Push(memberToCrossWith[i]);
                    oldMember[i] = memberToCrossWith[i];
                    continue;
                }

                oldMember[repeatedIdx] = oldMember[i];
                oldMember[i] = memberToCrossWith[i];

                while (true) {
                    int occurencesCnt = 0;
                    for (int j = 0; j < oldMember.Count - 1; j++) {
                        if (oldMember[j] == memberToCrossWith[i]) {
                            occurencesCnt++;
                        }
                    }

                    if (occurencesCnt == 1) {
                        break;
                    } else {
                        oldMember[i] = unusedElements.Pop();
                        continue;
                    }
                }
            }
        }

        void MutatePopulation() {
            for (int pop = 0; pop < populationCnt; pop++) {
                decimal mutationChance = Convert.ToDecimal(random.NextDouble());

                if (mutationChance.CompareTo(mutationFactor) != 1) {
                    while (true) {
                        int firstRandomIdx = random.Next(0, n);
                        int secondRandomIdx = random.Next(0, n);

                        if (firstRandomIdx == secondRandomIdx) {
                            continue;
                        }

                        int tmp = population[pop][firstRandomIdx];
                        population[pop][firstRandomIdx] = population[pop][secondRandomIdx];
                        population[pop][secondRandomIdx] = tmp;

                        break;
                    }
                }
            }
        }

        decimal EvaluateAverage() {
            decimal sum = 0;
            foreach (List<int> member in population) {
                sum += member[n];
            }

            return sum / population.Count();
        }
    }
}
