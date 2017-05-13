using Projekt_MSI.Model;

namespace Projekt_MSI.Operators
{
    internal interface ISelectionOperator
    {
        Individual[] GenerateParentPopulation(Individual[] currentPopulation);
    }
}