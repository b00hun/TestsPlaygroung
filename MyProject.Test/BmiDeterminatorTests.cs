using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyProject.Test
{
    public class BmiDeterminatorTests
    {
        [Theory]
        [InlineData(10.0,BmiClassification.Underweight)]
        [InlineData(15.2, BmiClassification.Underweight)]
        [InlineData(18.0, BmiClassification.Underweight)]
        [InlineData(21.0, BmiClassification.Normal)]
        [InlineData(24.0, BmiClassification.Normal)]
        [InlineData(24.8, BmiClassification.Normal)]
        [InlineData(28.8, BmiClassification.Overweight)]
        [InlineData(25.0, BmiClassification.Overweight)]
        [InlineData(32.8, BmiClassification.Obesity)]
        [InlineData(34.8, BmiClassification.Obesity)]
        [InlineData(39.2, BmiClassification.ExtremeObesity)]
        [InlineData(40.2, BmiClassification.ExtremeObesity)]
        
        public void DetermineBmi_ForGivenBmi_ReturnsCorrectClassification(double bmi, BmiClassification classification)
        {
            // arrange

            BmiDeterminator bmiDeterminator = new BmiDeterminator();
            

            // act

            BmiClassification result = bmiDeterminator.DetermineBmi(bmi);

            // assert
            Assert.Equal(classification,result);
        }


        
    }
}
