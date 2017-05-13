using System.Linq;
using Projekt_MSI.Helpers;
using Projekt_MSI.Model;

namespace Projekt_MSI.Operators
{
    internal class OnePointCrossover : ICrossOperator
    {
        public void Crossover(Individual parent1, Individual parent2)
        {
            var random = RandomProvider.Current;

            var crossPoint = random.Next(1, parent1.Chromosome.Genes.Count() - 1);

            var parent1Genome = parent1.Chromosome.Genes
                .SkipWhile((x, i) => i < crossPoint)
                .ToArray();

            var parent2Genome = parent2.Chromosome.Genes
                .SkipWhile((x, i) => i < crossPoint)
                .ToArray();

            parent1.InsertGenes(crossPoint, parent2Genome);
            parent2.InsertGenes(crossPoint, parent1Genome);
        }
    }
}