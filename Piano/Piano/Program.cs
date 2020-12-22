using System;
using System.Media;

namespace Piano
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input Berapa Oktaf : ");
            int p = 1000;
            int o = 1; //banyak oktaf
            Console.Write(" ");// spasi awal
            for(int i = 0; i < (7 * o); i++)//baris pertama
            {
                Console.Write("____");
            }
            Console.Write("___");
            Console.WriteLine();
            tutshitam(o);
            Console.Write("|");
            tutsbawahhitam(o);
            tutspalingbawah(o, p);
            while (true)
            {
                p = 1000;
                string x = Console.ReadLine();
                if(x == "a")//c
                {
                    Console.Beep(262, 500);//(frek, durasi)
                    p = 0;
                }
                else if (x == "w")//c#
                {
                    Console.Beep(277, 500);
                }
                else if(x == "s")//d
                {
                    Console.Beep(294, 500);
                    p = 1;
                }
                else if (x == "e")//d#
                {
                    Console.Beep(311, 500);
                }
                else if (x == "d")//e
                {
                    Console.Beep(330, 500);
                    p = 2;
                }
                else if (x == "f")//f
                {
                    Console.Beep(349, 500);
                    p = 3;
                }
                else if (x == "t")//f#
                {
                    Console.Beep(370, 500);
                }
                else if (x == "g")//g
                {
                    Console.Beep(392, 500);
                    p = 4;
                }
                else if (x == "y")//g#
                {
                    Console.Beep(415, 500);
                }
                else if (x == "h")//a
                {
                    Console.Beep(440, 500);
                    p = 5;
                }
                else if (x == "u")//a#
                {
                    Console.Beep(466, 500);
                }
                else if (x == "j")//b
                {
                    Console.Beep(494, 500);
                    p = 6;
                }
                else if (x == "k")//C'
                {
                    Console.Beep(523, 500);
                    p = 7;
                }
                Console.Clear();
                Console.Write(" ");// spasi awal
                for (int i = 0; i < (7 * o); i++)//baris pertama
                {
                    Console.Write("____");
                }
                Console.Write("___");
                Console.WriteLine();
                tutshitam(o);
                Console.Write("|");
                tutsbawahhitam(o);
                tutspalingbawah(o, p);
            }
        }

        static void tutshitam(int a1)
        {
            for (int i = 0; i < 4; i++) //Tuts Hitam
            {
                Console.Write("|");
                for (int k = 0; k < a1; k++)
                {
                    for (int j = 0; j < (15 * 2); j++)
                    {
                        if (j != 0 && j % 2 == 0 && j != 10 && j != 12 && j != 26 || j == 11 || j == 27)
                        {
                            if (j != 28)
                            {
                                Console.Write("|");
                            }
                        }
                        else //if (j == 0 || j == 1 || j == 3 || j == 5 || j == 7 || j == 9 || j == 10 || j == 12 || j == 13 || j == 15 || j == 17 || j == 19)
                        {
                            if (k > 0 && j == 0)
                            {
                                Console.Write("");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                }
                Console.Write("  |");
                Console.WriteLine();
            }
        }

        static void tutsbawahhitam(int a1)
        {
            for (int k = 0; k < a1; k++)
            {
                for (int j = 0; j < (15 * 2); j++)
                {
                    if (j != 0 && j % 2 == 0 && j != 10 && j != 12 && j != 26 || j == 11 || j == 27)
                    {
                        if (j != 28)
                        {
                            Console.Write("|");
                        }
                    }
                    else //if (j == 0 || j == 1 || j == 3 || j == 5 || j == 7 || j == 9 || j == 10 || j == 12 || j == 13 || j == 15 || j == 17 || j == 19)*/*/*/
                    {
                        if (k > 0 && j == 0)
                        {
                            Console.Write("");
                        }
                        else if (j % 2 == 0 || j == 1 || j == 5 || j == 9 || j == 13 || j == 17 || j == 21 || j == 25 || j == 27 || j == 29)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("_");
                        }
                    }
                }
            }
            Console.Write("  |");
            Console.WriteLine();
        }

        static void tutspalingbawah(int o, int y)
        {
            char no = 'C';
            for (int i = 0; i < 4; i++)
            {
                Console.Write("|");
                for (int j = 0; j < (7 * o) + 1; j++)
                {
                    if (i == 3)// tampilan note
                    {
                        if (y == j)
                        {
                            Console.Write(" " + " " + " |");
                        }
                        else
                        {
                            Console.Write(" " + no + " |");
                        }
                        no++;
                        if (no == 'H')
                        {
                            no = 'A';
                        }
                    }
                    else
                    {
                        Console.Write("   |");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("|");
            for (int i = 0; i < (7 * o) + 1; i++)
            {
                if (i != (7 * o))
                {
                    Console.Write("___|");
                }
                else
                {
                    Console.Write("___");
                }
            }
            Console.Write("|");
        }

    }
}
