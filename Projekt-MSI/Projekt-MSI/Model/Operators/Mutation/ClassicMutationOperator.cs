using System.Linq;
using Projekt_MSI.Helpers;
using Projekt_MSI.Model;

namespace Projekt_MSI.Operators
{
    public class ClassicMutationOperator : IMutationOperator
    {
        public void Mutation(Individual individual, double mutationProbability)
        {
            var random = RandomProvider.Current;

            var randomNumbers = individual
                .Chromosome.Genes
                .Select(x => random.NextDouble())
                .ToArray();

            individual.ReplaceGenes(individual
                .Chromosome.Genes
                .Zip(randomNumbers, (gene, prob) => prob <= mutationProbability ? !gene : gene)
                .ToArray());
        }
    }
}