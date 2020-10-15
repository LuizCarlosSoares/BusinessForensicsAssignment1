using System;
using Xunit;

namespace AttemptCheckerTest
{
    public class UnitTest1
    {
        


        [Fact]
        public void WhenIEnterANumberThatIsntInPreDefinedRangeShouldHaveAMessageInforming()
        {
            var expected = "The Number is out of Bounds!";
            var enteredNumber = 1000;
            var attemptchecker = new AttempCheckerLib.AttemptChecker();
            var actual =  attemptchecker.CheckNumber(enteredNumber);
            
            Assert.Equal(actual,expected);             

        }

        [Fact]
        public void WhenIEnterANumberThatIsntInSelectedNumbersShouldHaveAMessageInforming()
        {
            var expected = "The selected Number isn't in the stored value list";
            var enteredNumber = 5;
            var attemptchecker = new AttempCheckerLib.AttemptChecker();
            var actual =  attemptchecker.CheckNumber(enteredNumber);
            
            Assert.True(actual.Contains(expected));             

        }

        [Fact]
        public void WhenIEnterANumberThatIsntInSelectedNumbersShouldHaveTheNumberOfAttempst()
        {
            var expected = 2;
            var enteredNumber = 5;
            var attemptchecker = new AttempCheckerLib.AttemptChecker();
            attemptchecker.CheckNumber(enteredNumber);
            var actual =  attemptchecker.GetAttempts();            
            Assert.Equal(actual,expected);             

        }

        [Fact]
        public void WhenIEnterANumberThatIsntInSelectedNumbersAndTheLimitAttemptsIsReachedShouldHaveAMessageInforming()
        {
            var expected = "the max number of attempts was reached, please restart and try again";
            var enteredNumberFirstAttempt = 5;
            var enteredNumberSecondAttempt = 33;
            var enteredNumberThirdAttempt = 50 ;
                    
            var attemptchecker = new AttempCheckerLib.AttemptChecker();
            attemptchecker.CheckNumber(enteredNumberFirstAttempt);
            attemptchecker.CheckNumber(enteredNumberSecondAttempt);
            var actual = attemptchecker.CheckNumber(enteredNumberThirdAttempt);           

            Assert.Equal(actual,expected);             

        }

        [Fact]
        public void WhenIEnterANumberAndIsAMatchIShouldBeInformed()
        {
            var expected = "Bingo!";
            var enteredNumber = 14;
            var attemptchecker = new AttempCheckerLib.AttemptChecker();
            var actual = attemptchecker.CheckNumber(enteredNumber);                       
            Assert.Equal(actual,expected);             

        }



    }
}
