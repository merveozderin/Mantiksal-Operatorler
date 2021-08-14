using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mantıksal operatorler

            bool isSuccess = true ;
            bool isCompleted = false ;

            if (isSuccess && isCompleted)
            Console.WriteLine("Perfect") ;

            if (isSuccess || isCompleted)
            Console.WriteLine("Great") ;

            if (isSuccess && ! isCompleted)
            Console.WriteLine("Good") ;
        }
    }
}
