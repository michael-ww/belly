namespace Belly.Algorithm.Test
{
    public class GiniCoefficientTest
    {
        [Fact]
        public void Caculate_ValidInput_ReturnGiniCoefficient()
        {
            // Given
            int population = 100, round = 1000000;

            // When
            GiniCoefficient giniCoefficient = new GiniCoefficient();
            double answer = giniCoefficient.Experiment(population, round);

            // Then
            Console.WriteLine($"Population:{population},Round:{round},Gini:{answer}");
        }
    }
}