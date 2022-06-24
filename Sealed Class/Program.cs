using System;

namespace Sealed_Class
{
    sealed class test 
    {
    public void show()
        {
            Console.WriteLine("Seald class :");
        }
        public test()
        {
            Console.WriteLine("Constructor Sealed Class :");
        }
         static test()
        {
            Console.WriteLine("Constructor static  Sealed Class :");
        }
       
        public static void S()
        {
            Console.WriteLine("Static method :");
        }
       

    }

    class Program
    {
        static void Main(string[] args)
        {
            test obj = new test();
            obj.show();
            test.S();

        }
    }
}
