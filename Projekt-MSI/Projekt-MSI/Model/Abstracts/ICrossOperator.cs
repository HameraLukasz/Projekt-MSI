using Projekt_MSI.Model;

namespace GA.Abstracts
{
    internal interface ICrossOperator
    {
        void Crossover(Individual parent1, Individual parent2);
    }
}