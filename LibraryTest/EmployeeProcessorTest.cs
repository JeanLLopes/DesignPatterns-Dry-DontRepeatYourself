using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace LibraryTest
{
    public class EmployeeProcessorTest
    {
        [Theory]
        [InlineData("Jean", "Lopes", "JeanLope")]
        public void GenerateEmploeeId_ShouldCalculate(string firstName, string secondName, string expectedStart)
        {
            //Arrange
            EmployeeProcessor employeeProcessor = new EmployeeProcessor();
            //Act
            string actualStart = employeeProcessor.GenerateEmployeeID(firstName, secondName).Substring(0, 8);

            //Assert
            Assert.Equal(expectedStart, actualStart);
        }
    }
}
