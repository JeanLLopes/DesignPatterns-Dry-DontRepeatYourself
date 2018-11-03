using Library;
using Xunit;
namespace LibraryTest
{
    public class EmployeeProcessorTest
    {
        [Theory]
        [InlineData("Jean", "Lopes", "JeanLope")]
        [InlineData("Tim", "Lopes", "TimXLope")]
        [InlineData("Tim", "Co", "TimXCoXX")]
        public void GenerateEmploeeId_ShouldCalculate(string firstName, string secondName, string expectedStart)
        {
            //Arrange
            EmployeeProcessor employeeProcessor = new EmployeeProcessor();
            //Act
            string actualStart = employeeProcessor.GenerateEmployeeID(firstName, secondName).Substring(0, expectedStart.Length);

            //Assert
            Assert.Equal(expectedStart, actualStart);
        }
    }
}
