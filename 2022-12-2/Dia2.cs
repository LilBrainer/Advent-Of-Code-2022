using System;

namespace _2022_12_2
{
    internal class Dia2
    {
        static void Main()
        {
            int resposta;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("     DIA 2");
                Console.ResetColor();
                Console.WriteLine("Quina part vols?\n\n 0- Sortir \n 1- Part 1 \n 2- Part 2");
                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1)
                {
                    Part1();
                }
                if (resposta == 2)
                {
                    Part2();
                }

            } while (resposta != 0);

        }

        static void Part1()
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
                    switch (input_elf)
                    {
                        case "A":
                            switch(input_mine)
                            {
                                case "Y":
                                    pts_mine += 6;
                                    break;
                                case "X":
                                    pts_mine += 3;
                                    break;
                            }
                            break;
                        case "B":
                            switch (input_mine)
                            {
                                case "Z":
                                    pts_mine += 6;
                                    break;
                                case "Y":
                                    pts_mine += 3;
                                    break;
                            }
                            break;
                        case "C":
                            switch (input_mine)
                            {
                                case "X":
                                    pts_mine += 6;
                                    break;
                                case "Z":
                                    pts_mine += 3;
                                    break;
                            }
                            break;
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

        static void Part2()
        {
            Console.Clear();

            string input_elf = "";
            string input_mine = "";
            int pts_mine = 0;
            int contador = 0;
            string[] strings;

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
                    switch(input_mine)
                    {
                        case "X":
                            switch (input_elf) 
                            {
                                case "A":
                                    input_mine = "Z";
                                    break;
                                case "B":
                                    input_mine = "X";
                                    break;
                                case "C":
                                    input_mine = "Y";
                                    break;
                            }
                            break;
                        case "Y":
                            switch (input_elf) 
                            {
                                case "A":
                                    input_mine = "X";
                                    break;
                                case "B":
                                    input_mine = "Y";
                                    break;
                                case "C":
                                    input_mine = "Z";
                                    break;
                            }
                            break;
                        case "Z":
                            switch (input_elf)
                            {
                                case "A":
                                    input_mine = "Y";
                                    break;
                                case "B":
                                    input_mine = "Z";
                                    break;
                                case "C":
                                    input_mine = "X";
                                    break;
                            }
                            break;
                    }

                    if (input_mine == "X") pts_mine++;
                    if (input_mine == "Y") pts_mine += 2;
                    if (input_mine == "Z") pts_mine += 3;
                }
                if (strings[i] != "")
                {
                    contador++;
                }

                if (strings[i] != "" && contador == 2)
                {
                    switch (input_elf)
                    {
                        case "A":
                            switch (input_mine)
                            {
                                case "Y":
                                    pts_mine += 6;
                                    break;
                                case "X":
                                    pts_mine += 3;
                                    break;
                            }
                            break;
                        case "B":
                            switch (input_mine)
                            {
                                case "Z":
                                    pts_mine += 6;
                                    break;
                                case "Y":
                                    pts_mine += 3;
                                    break;
                            }
                            break;
                        case "C":
                            switch (input_mine)
                            {
                                case "X":
                                    pts_mine += 6;
                                    break;
                                case "Z":
                                    pts_mine += 3;
                                    break;
                            }
                            break;
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
    }
}
