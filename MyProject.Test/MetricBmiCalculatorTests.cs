using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyProject.Test
{
    public class MetricBmiCalculatorTests
    {
        [Theory]
        [InlineData(100,170,34.6)]
        [InlineData(57,170,19.72)]
        [InlineData(70,170,24.22)]
        [InlineData(90,190,24.93)]
        public void CalculateBmi_ForGivenWeightAndHeight_ReturnsCorrectBmi(double weight, double height, double bmiResult)
        {

            //arrange

            MetricBmiCalculator calculator = new();

            //act

            double result = calculator.CalculateBmi(weight, height);

            //assert

            Assert.Equal(bmiResult, result);
        }

        [Theory]
        [InlineData(0,190)]
        [InlineData(-5, 190)]
        [InlineData(-11, 190)]
        [InlineData(90, 0)]
        [InlineData(90, -16)]
        [InlineData(0, -180)]
        [InlineData(0,0)]
        public void CalculateBmi_ForInvalidArguments_ThrowsArgumentException(double weight,double height)
        {
            //arrange
            MetricBmiCalculator calculator = new();

            //act
            
            Action action = () => calculator.CalculateBmi(weight,height);

            //assert
            
            Assert.Throws<ArgumentException>(action);

        }
    }
}
