using Projekt_MSI.Model;

namespace GA.Abstracts
{
    public interface IMutationOperator
    {
        void Mutation(Individual individual, double mutationProbability);
    }
}