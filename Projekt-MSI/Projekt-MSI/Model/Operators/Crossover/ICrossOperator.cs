using Projekt_MSI.Model;

namespace Projekt_MSI.Operators
{
    internal interface ICrossOperator
    {
        void Crossover(Individual parent1, Individual parent2);
    }
}