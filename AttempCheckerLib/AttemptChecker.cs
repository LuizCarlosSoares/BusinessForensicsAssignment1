using System;
using System.Linq;

namespace AttempCheckerLib
{
    public class AttemptChecker
    {

        private const string SUCCESS_MATCHED = "Bingo!";

        private const string OUT_OF_BOUNDS_NUMBER = "The Number is out of Bounds!";

        private const string VALUE_NOT_FOUND = "The selected Number isn't in the stored value list";
        private const string MAX_ATTEMPTS_REACHED = "the max number of attempts was reached, please restart and try again";
        private int[] hiddenNumbers = {14,22,55};
        private int attempts = 1;
        private bool success;

        private int minValueAllowed = 0;
        private int maxValueAllowed = 100;

        private int maxAttempts = 3;
        public string CheckNumber(int number){

           if(!isInBounds(number)){
               return OUT_OF_BOUNDS_NUMBER;
           }

           if(hiddenNumbers.ToList().Where(n=> n == number).Count() == 0) {               
               
                maxAttempts--;
                return  maxAttempts == 0 ? MAX_ATTEMPTS_REACHED : $"{VALUE_NOT_FOUND} only {maxAttempts} attempt(s) remaining"  ;

           }
           success=true;
           return SUCCESS_MATCHED;

        }

        private string getRemaingAttempts()
        {
          return (maxAttempts - (attempts)).ToString();
        }

        private bool isInBounds(int number)
        {
            return number >= minValueAllowed && number <=maxValueAllowed;
        }

        public bool MaxAttemptsReached()
        {
            return maxAttempts == 0;
        }

        public int GetAttempts(){
            return maxAttempts;
        }

        public bool IsSuccess() {
           return success;
        }
    }
}
