using System;
using System.Linq;
using Projekt_MSI.Helpers;

namespace Projekt_MSI.Model
{
    public class Chromosome
    {
        public Chromosome(int chromosomeSize)
        {
            var random = RandomProvider.Current;

            Genes = Enumerable
                .Range(0, chromosomeSize)
                .Select(x => random.NextBool())
                .ToArray();
        }

        public Chromosome()
        {
        }

        public bool[] Genes { get; set; }


        public bool this[int index]
        {
            get
            {
                if (index < Genes.Length)
                    return Genes[index];
                throw new IndexOutOfRangeException("Bit z genu poza zakresem");
            }
            set => Genes[index] = value;
        }

        public double GetDecodedValue()
        {
            return Genes
                .Reverse()
                .Select((x, i) => x ? Math.Pow(2, i) : 0)
                .Sum();
        }

        public Chromosome Clone()
        {
            return new Chromosome
            {
                Genes = Genes.Select(x => x).ToArray()
            };
        }
    }
}