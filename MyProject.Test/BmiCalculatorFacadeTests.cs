using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyProject.Test
{
    public class BmiCalculatorFacadeTests
    {
        private const string OVERWEIGHT_SUMMARY = "You are a bit overweight";


        [Fact]
        public void GetResult_ForValidInput_ReturnsCorrectResult()
        {
            //arrange

            BmiCalculatorFacade bmiCalculatorFacade = new(UnitSystem.Metric);
            double weight = 90;
            double height = 190;

            //act
           BmiResult result = bmiCalculatorFacade.GetResult(weight, height);


            //assert
            Assert.Equal(24.93, result.Bmi);
            Assert.Equal(BmiClassification.Overweight, result.BmiClassification);
            Assert.Equal(OVERWEIGHT_SUMMARY, result.Summary);

        }

    }
}
