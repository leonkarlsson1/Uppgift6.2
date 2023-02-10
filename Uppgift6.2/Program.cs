using System;
namespace uppgift_6_2

{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De två talen var 20 och 50, det största talet av dessa två står här under: ");

            Console.WriteLine(Störst(20, 50));
        }
        static int Störst(int tal1, int tal2)

        {

            if (tal1 > tal2)

            {
                return tal1;
            }
            else
            {
                return tal2;

            }

        }
    }
}