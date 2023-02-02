using System;
namespace test51
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in 5 stycken namn");
            string[] namn = new string[5];

            namn[0] = Console.ReadLine();
            namn[1] = Console.ReadLine();
            namn[2] = Console.ReadLine();
            namn[3] = Console.ReadLine();
            namn[4] = Console.ReadLine();
        }

    }
}
