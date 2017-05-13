using System;
using System.Collections.Generic;

namespace Projekt_MSI.Model
{
    internal class GeneticAlgorithm
    {
        public Func<double, double, double> FitnessFunction { get; set; }
        public IEnumerable<Individual> Individuals { get; set; }
    }
}