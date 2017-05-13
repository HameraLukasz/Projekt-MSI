using Projekt_MSI.Model;

namespace Projekt_MSI.Operators
{
    public interface IMutationOperator
    {
        void Mutation(Individual individual, double mutationProbability);
    }
}