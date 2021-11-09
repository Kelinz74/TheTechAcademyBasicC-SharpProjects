using System;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //an object for data type Number with a number assigned to amount.
            Number amount1 = new Number(){ amount = 466 };            

            Console.WriteLine(amount1.amount);
            Console.ReadLine();

        }

    }

}
