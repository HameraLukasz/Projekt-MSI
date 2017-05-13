using Projekt_MSI.Model;

namespace GA.Abstracts
{
    internal interface ISelectionOperator
    {
        Individual[] GenerateParentPopulation(Individual[] currentPopulation);
    }
}