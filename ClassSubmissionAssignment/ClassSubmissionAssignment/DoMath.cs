using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{   
    //public class DoMath
    public class DoMath
    {
        //public void method with an in parameter.  the inputed value passed to the variable num1 will be used in a division calculation within the method
        public void division(int num1)
        {
            int doneMath = num1 / 2;
            Console.WriteLine(num1 + " / 2 = " + doneMath);
            Console.ReadLine();
        }

        //public voide method utilizing the out parameter modifier sending the value within the method from the variable number to the call from the main() saving the value the variable int number
        public void moreMath(out int number)
        {
            number = 55;
        }

        //public voide method with a string value as the parameter with the value coming from the method call from the main() doMath.division("hard");  passing hard into the concatinated 
        //statement from the WriteLine method
        public void division(string divide)
        {
            Console.WriteLine("To divide something isn't so " + divide + " with a samurai sword.");            
        }
        
    }
}
