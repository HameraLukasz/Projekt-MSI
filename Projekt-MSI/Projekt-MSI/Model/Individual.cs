using System;
using System.Linq;

namespace Projekt_MSI.Model
{
    public class Individual
    {
        public Individual(int chromosomeSize)
        {
            Chromosome = new Chromosome(chromosomeSize);
        }

        public Individual()
        {
        }

        public Chromosome Chromosome { get; set; }
        public double Fitness { get; set; }


        public void InsertGenes(int insertIndex, bool[] genes)
        {
            Chromosome.Genes = Chromosome.Genes
                .Select((x, i) => i < insertIndex ? x : genes[i - insertIndex])
                .ToArray();
        }

        public void ReplaceGenes(bool[] genes)
        {
            InsertGenes(0, genes);
        }

        public Individual Clone()
        {
            return new Individual
            {
                Chromosome = Chromosome.Clone()
            };
        }

        public void UpdateFitness(Func<double, double> fitness)
        {
            Fitness = fitness(Chromosome.GetDecodedValue());
        }
    }
}