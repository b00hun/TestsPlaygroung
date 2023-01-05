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
        [InlineData(10.0)]
        [InlineData(15.2)]
        [InlineData(18.0)]
        public void DetermineBmi_ForBmiUnder18_5_ReturnsUnderweight(double bmi)
        {
            // arrange

            BmiDeterminator bmiDeterminator = new BmiDeterminator();
            

            // act

            BmiClassification result = bmiDeterminator.DetermineBmi(bmi);

            // assert
            Assert.Equal(BmiClassification.Underweight,result);
        }


        
    }
}
