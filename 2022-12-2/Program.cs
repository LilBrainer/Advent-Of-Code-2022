using System;

namespace _2022_12_2
{
    internal class Program
    {
        static void Main()
        {
            
        }

        public void Part1()
        {
            Console.Clear();

            string input_elf = "";
            string input_mine = "";
            int pts_mine = 0;
            string[] strings;
            int contador = 0;

            strings = System.IO.File.ReadAllText(@"..\..\..\..\input\input2.txt").Split(' ', '\n', '\r');

            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] != "" && contador == 0)
                {
                    input_elf = strings[i];
                }
                if (strings[i] != "" && contador == 1)
                {
                    input_mine = strings[i];
                    if (strings[i] == "X") pts_mine++;
                    if (strings[i] == "Y") pts_mine += 2;
                    if (strings[i] == "Z") pts_mine += 3;
                }
                if (strings[i] != "")
                {
                    contador++;
                }

                if (strings[i] != "" && contador == 2)
                {
                    if (input_elf == "A")
                    {
                        if (input_mine == "Y")
                        {
                            pts_mine += 6;
                        }
                        if (input_mine == "X")
                        {
                            pts_mine += 3;
                        }
                    }
                    if (input_elf == "B")
                    {
                        if (input_mine == "Z")
                        {
                            pts_mine += 6;
                        }
                        if (input_mine == "Y")
                        {
                            pts_mine += 3;
                        }
                    }
                    if (input_elf == "C")
                    {
                        if (input_mine == "X")
                        {
                            pts_mine += 6;
                        }
                        if (input_mine == "Z")
                        {
                            pts_mine += 3;
                        }
                    }
                }

                if (contador == 2)
                {
                    contador = 0;
                }
            }

            Console.WriteLine(pts_mine);
            Console.ReadLine();
        }

        public void Part2()
        {
            Console.Clear();


        }
    }
}
