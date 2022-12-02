using System;

namespace _2022_12_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input_elf = "";
            string input_mine = "";
            string[] strings = new string[1000];
            int contador = 0;

            foreach (string line in System.IO.File.ReadLines(@"..\..\..\..\input\input2-test.txt"))
            {
                if(line != "" && contador == 0)
                {
                    input_elf = line;
                    contador++;
                }
                if (line != "" && contador == 1)
                {
                    input_mine = line;
                    contador--;
                }
            }
            Console.WriteLine(input_mine);
            Console.WriteLine(input_elf);
        }
    }
}
