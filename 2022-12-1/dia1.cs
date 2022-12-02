﻿using System;

namespace _2022_12_1
{
    class dia1
    {
        static void Main(string[] args)
        {
            dia1 pr = new dia1();
            int resposta;

            do
            {
                Console.Clear();
                Console.WriteLine("Quina part vols?\n\n 0- Sortir \n 1- Part 1 \n 2- Part 2");
                resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 1)
                {
                    parte1();
                }
                if (resposta == 2)
                {
                    parte2();
                }

            } while (resposta != 0);

            Console.ReadLine();
        }

        static void parte1()
        {
            Console.Clear();


            int maxelf = 0;
            int elf = 0;

            foreach (string line in System.IO.File.ReadLines(@"..\..\..\..\input\input.txt"))
            {
                if (line == "")
                {
                    if (elf > maxelf)
                    {
                        maxelf = elf;
                    }
                    elf = 0;
                }
                else
                {
                    elf += Convert.ToInt32(line);
                }
            }
            Console.WriteLine(maxelf);

            Console.ReadLine();
        }

        static void parte2()
        {
            Console.Clear();

            int maxelf1 = 0;
            int maxelf2 = 0;
            int maxelf3 = 0;
            int elf = 0;

            foreach (string line in System.IO.File.ReadLines(@"..\..\..\..\input\input.txt"))
            {
                if (line == "")
                {
                    if (elf > maxelf3)
                    {
                        if (elf > maxelf2)
                        {
                            if (elf > maxelf1)
                            {
                                maxelf3 = maxelf2;
                                maxelf2 = maxelf1;
                                maxelf1 = elf;
                            }
                            else
                            {
                                maxelf3 = maxelf2;
                                maxelf2 = elf;
                            }
                        }
                        else
                        {
                            maxelf3 = elf;
                        }
                    }
                    elf = 0;
                }
                else
                {
                    elf += Convert.ToInt32(line);
                }
            }
            Console.WriteLine(maxelf1 + maxelf2 + maxelf3);



            Console.ReadLine();
        }
    }
}
