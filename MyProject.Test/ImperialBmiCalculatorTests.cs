using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyProject.Test
{
    public class ImperialBmiCalculatorTests
    {
        [Theory]
        [InlineData(180,75,22.5)]
        [InlineData(185, 81, 19.82)]
        [InlineData(200, 70, 28.69)]
        [InlineData(215, 82, 22.48)]


        public void CalculateBmi_ForGivenWeightAndHeight_ReturnsCorrectBmi(double weight,double height, double bmiResult)
        {
            //arrange
            ImperialBmiCalculator calculator = new();

            //act
            double result = calculator.CalculateBmi(weight, height);

            //assert
            Assert.Equal(bmiResult, result);
        }


        [Theory]
        [InlineData(0, 190)]
        [InlineData(-5, 190)]
        [InlineData(-11, 190)]
        [InlineData(90, 0)]
        [InlineData(90, -16)]
        [InlineData(0, -180)]
        [InlineData(0, 0)]
        public void CalculateBmi_ForInvalidArguments_ThrowsArgumentException(double weight, double height)
        {
            //arrange
            ImperialBmiCalculator calculator = new();

            //act

            Action action = () => calculator.CalculateBmi(weight, height);

            //assert

            Assert.Throws<ArgumentException>(action);

        }
    }
}
