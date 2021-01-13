using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;

namespace Piano
{
    class Program
    {
        static void Main(string[] args)
        {
            {



                string title = @"
██████╗░░█████╗░██╗░░██╗██╗████████╗  ██████╗░░█████╗░  ██████╗░██╗░█████╗░███╗░░██╗░█████╗░
██╔══██╗██╔══██╗██║░██╔╝██║╚══██╔══╝  ██╔══██╗██╔══██╗  ██╔══██╗██║██╔══██╗████╗░██║██╔══██╗
██████╔╝███████║█████═╝░██║░░░██║░░░  ██████╔╝██║░░╚═╝  ██████╔╝██║███████║██╔██╗██║██║░░██║
██╔══██╗██╔══██║██╔═██╗░██║░░░██║░░░  ██╔═══╝░██║░░██╗  ██╔═══╝░██║██╔══██║██║╚████║██║░░██║
██║░░██║██║░░██║██║░╚██╗██║░░░██║░░░  ██║░░░░░╚█████╔╝  ██║░░░░░██║██║░░██║██║░╚███║╚█████╔╝
╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░╚═╝░░░  ╚═╝░░░░░░╚════╝░  ╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░
                           ____________________________________
                          |\                                    \
                          | \                                    \
                          |  \____________________________________\
                          |  |       __---_ _---__                |
                          |  |      |======|=====|                |
                          |  |      |======|=====|                |
                          |  |  ____|__---_|_---_|______________  |
                          |  | |                                | |
                          |   \ \                                \ \
                          |  \ ||\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\| |     
                          |  |\  ,--------------------------------  |
                          |  ||| |                               || |
                           \ ||| |           -  -                || |
                            \'|| |-----------\\-\\---------------|| |
                             \||_|                             \|_|_|
                                                                 ";

                Console.WriteLine(title);
                Console.WriteLine("                       ===============PIANO BY RAKIT PC===============");
                Console.WriteLine(" ");
                Console.WriteLine("1. PLAY PIANO ");
                Console.WriteLine("2. PLAY MUSIC ");
                Console.WriteLine("3. QUIT       ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("Silahkan input = ");
                int menu = Convert.ToInt32(Console.ReadLine());

                while (menu != 3)
                {
                    Console.Clear();
                    if (menu == 1)
                    {
                        piano();
                    }
                    else if (menu == 2)
                    {
                        music();
                    }
                    Console.Clear();

                    Console.WriteLine(title);
                    Console.WriteLine("1. PLAY PIANO ");
                    Console.WriteLine("2. PLAY MUSIC ");
                    Console.WriteLine("3. QUIT       ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.Write("Silahkan input = ");
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                exit();
            }
        }
        static void piano()
        {
            int p = 1000;
            int o = 1; //banyak oktaf
            tutshitam(o);
            tutsbawahhitam(o);
            tutspalingbawah(o, p);

            bool key = true;
            while (key == true)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A://c
                        Console.Clear();
                        tutshitam(o);
                        tutsbawahhitam(o);
                        tekana(o, p);
                        //SoundPlayer dobawah = new SoundPlayer(@"D:\project saa jonathan'\suara\Do Bawah.wav");
                        //dobawah.Play();
                        var dobawah = new System.Windows.Media.MediaPlayer();
                        dobawah.Open(new System.Uri(@"D:\project saa jonathan'\suara\Do Bawah.wav"));
                        dobawah.Play();
                    case ConsoleKey.S://d
                        Console.Clear();
                        tutshitam(o);
                        tutsbawahhitam(o);
                        tekans(o, p);
                        //SoundPlayer re = new SoundPlayer(@"D:\project saa jonathan'\suara\Re Bawah.wav");
                        //re.Play();
                        var re = new System.Windows.Media.MediaPlayer();
                        re.Open(new System.Uri(@"D:\project saa jonathan'\suara\Re Bawah.wav"));
                        re.Play();
                    case ConsoleKey.D://e
                        Console.Clear();
                        tutshitam(o);
                        tutsbawahhitam(o);
                        tekand(o, p);
                        //SoundPlayer mi = new SoundPlayer(@"D:\project saa jonathan'\suara\Mi Bawah.wav");
                        //mi.Play();
                        var mi = new System.Windows.Media.MediaPlayer();
                        mi.Open(new System.Uri(@"D:\project saa jonathan'\suara\Mi Bawah.wav"));
                        mi.Play();
                    case ConsoleKey.F://f
                        Console.Clear();
                        tutshitam(o);
                        tutsbawahhitam(o);
                        tekanf(o, p);
                        SoundPlayer fa = new SoundPlayer(@"D:\project saa jonathan'\suara\Fa Bawah.wav");
                        fa.Play();
                    case ConsoleKey.G://g
                        Console.Clear();
                        tutshitam(o);
                        tutsbawahhitam(o);
                        tekang(o, p);
                        SoundPlayer sol = new SoundPlayer(@"D:\project saa jonathan'\suara\Sol Bawah.wav");
                        sol.Play();
                    case ConsoleKey.H://a
                        Console.Clear();
                        tutshitam(o);
                        tutsbawahhitam(o);
                        tekanh(o, p);
                        SoundPlayer la = new SoundPlayer(@"D:\project saa jonathan'\suara\La Bawah.wav");
                        la.Play();
                    case ConsoleKey.J://b
                        Console.Clear();
                        tutshitam(o);
                        tutsbawahhitam(o);
                        tekanj(o, p);
                        SoundPlayer si = new SoundPlayer(@"D:\project saa jonathan'\suara\Si Bawah.wav");
                        si.Play();
                    case ConsoleKey.K://c'
                        Console.Clear();
                        tutshitam(o);
                        tutsbawahhitam(o);
                        tekank(o, p);
                        SoundPlayer doatas = new SoundPlayer(@"D:\project saa jonathan'\suara\Do Octave 2.wav");
                        doatas.Play();
                    case ConsoleKey.W://c#
                        Console.Clear();
                        tekanw(o);
                        tutsbawahhitam(o);
                        tutspalingbawah(o, p);
                        SoundPlayer atas1 = new SoundPlayer(@"D:\project saa jonathan'\suara\1.wav");
                        atas1.Play();
                    case ConsoleKey.E://d#
                        Console.Clear();
                        tekane(o);
                        tutsbawahhitam(o);
                        tutspalingbawah(o, p);
                        SoundPlayer atas2 = new SoundPlayer(@"D:\project saa jonathan'\suara\2.wav");
                        atas2.Play();
                    case ConsoleKey.T://f#
                        Console.Clear();
                        tekant(o);
                        tutsbawahhitam(o);
                        tutspalingbawah(o, p);
                        SoundPlayer atas3 = new SoundPlayer(@"D:\project saa jonathan'\suara\3.wav");
                        atas3.Play();
                    case ConsoleKey.Y://a#
                        Console.Clear();
                        tekany(o);
                        tutsbawahhitam(o);
                        tutspalingbawah(o, p);
                        SoundPlayer atas4 = new SoundPlayer(@"D:\project saa jonathan'\suara\4.wav");
                        atas4.Play();
                    case ConsoleKey.U://b#
                        Console.Clear();
                        tekanu(o);
                        tutsbawahhitam(o);
                        tutspalingbawah(o, p);
                        SoundPlayer atas5 = new SoundPlayer(@"D:\project saa jonathan'\suara\5.wav");
                        atas5.Play();
                    case ConsoleKey.Escape:
                        key = false;
                }
                /*Console.Clear();
                tutshitam(o);
                tutsbawahhitam(o);
                tutspalingbawah(o, p);*/
            }
        }
        static void tutshitam(int a1)
        {
            Console.Write(" ");// spasi awal
            for (int i = 0; i < (7 * a1); i++)//baris pertama
            {
                Console.Write("____");
            }
            Console.Write("___");
            Console.WriteLine();
            char hitam = 'C';
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
                                if (i == 2)
                                {
                                    if (j == 3 || j == 7 || j == 15 || j == 19 || j == 23)
                                    {
                                        Console.Write(hitam);
                                        hitam++;
                                        if (hitam == 'E')
                                        {
                                            hitam = 'F';
                                        }
                                        else if (hitam == 'H')
                                        {
                                            hitam = 'A';
                                        }
                                        else if (hitam == 'B')
                                        {
                                            hitam = 'C';
                                        }
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                else if (i == 3)
                                {
                                    if (j == 3 || j == 7 || j == 15 || j == 19 || j == 23)
                                    {
                                        Console.Write("#");
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                    }
                }
                Console.Write("  |");
                Console.WriteLine();
            }
            Console.Write("|");
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
                            Console.Write(" " + no + " |");
                        }
                        else
                        {
                            Console.Write(" " + " " + " |");
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
        static void tekanw(int a1)
        {
            Console.Write(" ");// spasi awal
            for (int i = 0; i < (7 * a1); i++)//baris pertama
            {
                Console.Write("____");
            }
            Console.Write("___");
            Console.WriteLine();
            char hitam = 'C';
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
                                if (i == 2)
                                {
                                    if (j == 7 || j == 15 || j == 19 || j == 23)
                                    {
                                        Console.Write(hitam);
                                        hitam++;
                                        if (hitam == 'E')
                                        {
                                            hitam = 'F';
                                        }
                                        else if (hitam == 'H')
                                        {
                                            hitam = 'A';
                                        }
                                        else if (hitam == 'B')
                                        {
                                            hitam = 'C';
                                        }
                                    }
                                    else if (j == 3)
                                    {
                                        Console.Write("/");
                                        hitam++;
                                        if (hitam == 'E')
                                        {
                                            hitam = 'F';
                                        }
                                        else if (hitam == 'H')
                                        {
                                            hitam = 'A';
                                        }
                                        else if (hitam == 'B')
                                        {
                                            hitam = 'C';
                                        }
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                else if (i == 3)
                                {
                                    if (j == 7 || j == 15 || j == 19 || j == 23)
                                    {
                                        Console.Write("#");
                                    }
                                    else if (j == 3)
                                    {
                                        Console.Write("/");
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                    }
                }
                Console.Write("  |");
                Console.WriteLine();
            }
            Console.Write("|");
        }
        static void tekane(int a1)
        {
            Console.Write(" ");// spasi awal
            for (int i = 0; i < (7 * a1); i++)//baris pertama
            {
                Console.Write("____");
            }
            Console.Write("___");
            Console.WriteLine();
            char hitam = 'C';
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
                                if (i == 2)
                                {
                                    if (j == 3 || j == 15 || j == 19 || j == 23)
                                    {
                                        Console.Write(hitam);
                                        hitam++;
                                        if (hitam == 'E')
                                        {
                                            hitam = 'F';
                                        }
                                        else if (hitam == 'H')
                                        {
                                            hitam = 'A';
                                        }
                                        else if (hitam == 'B')
                                        {
                                            hitam = 'C';
                                        }
                                    }
                                    else if (j == 7)
                                    {
                                        Console.Write("/");
                                        hitam++;
                                        if (hitam == 'E')
                                        {
                                            hitam = 'F';
                                        }
                                        else if (hitam == 'H')
                                        {
                                            hitam = 'A';
                                        }
                                        else if (hitam == 'B')
                                        {
                                            hitam = 'C';
                                        }
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                else if (i == 3)
                                {
                                    if (j == 3 || j == 15 || j == 19 || j == 23)
                                    {
                                        Console.Write("#");
                                    }
                                    else if (j == 7)
                                    {
                                        Console.Write("/");
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                    }
                }
                Console.Write("  |");
                Console.WriteLine();
            }
            Console.Write("|");
        }
        static void tekant(int a1)
        {
            Console.Write(" ");// spasi awal
            for (int i = 0; i < (7 * a1); i++)//baris pertama
            {
                Console.Write("____");
            }
            Console.Write("___");
            Console.WriteLine();
            char hitam = 'C';
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
                                if (i == 2)
                                {
                                    if (j == 3 || j == 7 || j == 19 || j == 23)
                                    {
                                        Console.Write(hitam);
                                        hitam++;
                                        if (hitam == 'E')
                                        {
                                            hitam = 'F';
                                        }
                                        else if (hitam == 'H')
                                        {
                                            hitam = 'A';
                                        }
                                        else if (hitam == 'B')
                                        {
                                            hitam = 'C';
                                        }
                                    }
                                    else if (j == 15)
                                    {
                                        Console.Write("/");
                                        hitam++;
                                        if (hitam == 'E')
                                        {
                                            hitam = 'F';
                                        }
                                        else if (hitam == 'H')
                                        {
                                            hitam = 'A';
                                        }
                                        else if (hitam == 'B')
                                        {
                                            hitam = 'C';
                                        }
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                else if (i == 3)
                                {
                                    if (j == 3 || j == 7 || j == 19 || j == 23)
                                    {
                                        Console.Write("#");
                                    }
                                    else if (j == 15)
                                    {
                                        Console.Write("/");
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                    }
                }
                Console.Write("  |");
                Console.WriteLine();
            }
            Console.Write("|");
        }
        static void tekany(int a1)
        {
            Console.Write(" ");// spasi awal
            for (int i = 0; i < (7 * a1); i++)//baris pertama
            {
                Console.Write("____");
            }
            Console.Write("___");
            Console.WriteLine();
            char hitam = 'C';
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
                                if (i == 2)
                                {
                                    if (j == 3 || j == 7 || j == 15 || j == 23)
                                    {
                                        Console.Write(hitam);
                                        hitam++;
                                        if (hitam == 'E')
                                        {
                                            hitam = 'F';
                                        }
                                        else if (hitam == 'H')
                                        {
                                            hitam = 'A';
                                        }
                                        else if (hitam == 'B')
                                        {
                                            hitam = 'C';
                                        }
                                    }
                                    else if (j == 19)
                                    {
                                        Console.Write("/");
                                        hitam++;
                                        if (hitam == 'E')
                                        {
                                            hitam = 'F';
                                        }
                                        else if (hitam == 'H')
                                        {
                                            hitam = 'A';
                                        }
                                        else if (hitam == 'B')
                                        {
                                            hitam = 'C';
                                        }
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                else if (i == 3)
                                {
                                    if (j == 3 || j == 7 || j == 15 || j == 23)
                                    {
                                        Console.Write("#");
                                    }
                                    else if (j == 19)
                                    {
                                        Console.Write("/");
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                    }
                }
                Console.Write("  |");
                Console.WriteLine();
            }
            Console.Write("|");
        }
        static void tekanu(int a1)
        {
            Console.Write(" ");// spasi awal
            for (int i = 0; i < (7 * a1); i++)//baris pertama
            {
                Console.Write("____");
            }
            Console.Write("___");
            Console.WriteLine();
            char hitam = 'C';
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
                                if (i == 2)
                                {
                                    if (j == 3 || j == 7 || j == 15 || j == 19)
                                    {
                                        Console.Write(hitam);
                                        hitam++;
                                        if (hitam == 'E')
                                        {
                                            hitam = 'F';
                                        }
                                        else if (hitam == 'H')
                                        {
                                            hitam = 'A';
                                        }
                                        else if (hitam == 'B')
                                        {
                                            hitam = 'C';
                                        }
                                    }
                                    else if (j == 23)
                                    {
                                        Console.Write("/");
                                        hitam++;
                                        if (hitam == 'E')
                                        {
                                            hitam = 'F';
                                        }
                                        else if (hitam == 'H')
                                        {
                                            hitam = 'A';
                                        }
                                        else if (hitam == 'B')
                                        {
                                            hitam = 'C';
                                        }
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                else if (i == 3)
                                {
                                    if (j == 3 || j == 7 || j == 15 || j == 19)
                                    {
                                        Console.Write("#");
                                    }
                                    else if (j == 23)
                                    {
                                        Console.Write("/");
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                    }
                }
                Console.Write("  |");
                Console.WriteLine();
            }
            Console.Write("|");
        }
        static void tekana(int o, int y)
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
                            Console.Write(" " + no + " |");
                        }
                        else if (j == 0)
                        {
                            Console.Write("///|");
                        }
                        else
                        {
                            Console.Write(" " + " " + " |");
                        }
                        no++;
                        if (no == 'H')
                        {
                            no = 'A';
                        }
                    }
                    else if (j == 0)
                    {
                        Console.Write("///|");
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
        static void tekans(int o, int y)
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
                            Console.Write(" " + no + " |");
                        }
                        else if (j == 1)
                        {
                            Console.Write("///|");
                        }
                        else
                        {
                            Console.Write(" " + " " + " |");
                        }
                        no++;
                        if (no == 'H')
                        {
                            no = 'A';
                        }
                    }
                    else if (j == 1)
                    {
                        Console.Write("///|");
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
        static void tekand(int o, int y)
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
                            Console.Write(" " + no + " |");
                        }
                        else if (j == 2)
                        {
                            Console.Write("///|");
                        }
                        else
                        {
                            Console.Write(" " + " " + " |");
                        }
                        no++;
                        if (no == 'H')
                        {
                            no = 'A';
                        }
                    }
                    else if (j == 2)
                    {
                        Console.Write("///|");
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
        static void tekanf(int o, int y)
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
                            Console.Write(" " + no + " |");
                        }
                        else if (j == 3)
                        {
                            Console.Write("///|");
                        }
                        else
                        {
                            Console.Write(" " + " " + " |");
                        }
                        no++;
                        if (no == 'H')
                        {
                            no = 'A';
                        }
                    }
                    else if (j == 3)
                    {
                        Console.Write("///|");
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
        static void tekang(int o, int y)
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
                            Console.Write(" " + no + " |");
                        }
                        else if (j == 4)
                        {
                            Console.Write("///|");
                        }
                        else
                        {
                            Console.Write(" " + " " + " |");
                        }
                        no++;
                        if (no == 'H')
                        {
                            no = 'A';
                        }
                    }
                    else if (j == 4)
                    {
                        Console.Write("///|");
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
        static void tekanh(int o, int y)
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
                            Console.Write(" " + no + " |");
                        }
                        else if (j == 5)
                        {
                            Console.Write("///|");
                        }
                        else
                        {
                            Console.Write(" " + " " + " |");
                        }
                        no++;
                        if (no == 'H')
                        {
                            no = 'A';
                        }
                    }
                    else if (j == 5)
                    {
                        Console.Write("///|");
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
        static void tekanj(int o, int y)
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
                            Console.Write(" " + no + " |");
                        }
                        else if (j == 6)
                        {
                            Console.Write("///|");
                        }
                        else
                        {
                            Console.Write(" " + " " + " |");
                        }
                        no++;
                        if (no == 'H')
                        {
                            no = 'A';
                        }
                    }
                    else if (j == 6)
                    {
                        Console.Write("///|");
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
                else if (i == (7 * o) - 1)
                {
                    Console.Write("///|");
                }
                else
                {
                    Console.Write("___");
                }
            }
            Console.Write("|");
        }
        static void tekank(int o, int y)
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
                            Console.Write(" " + no + " |");
                        }
                        else if (j == 7)
                        {
                            Console.Write("///|");
                        }
                        else
                        {
                            Console.Write(" " + " " + " |");
                        }
                        no++;
                        if (no == 'H')
                        {
                            no = 'A';
                        }
                    }
                    else if (j == 7)
                    {
                        Console.Write("///|");
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
        static void music()
        {
            Console.Clear();
            Console.WriteLine("SILAHKAN PILIH");
            Console.WriteLine("1. HAPPY BIRTDAY ");
            Console.WriteLine("2. SUPER MARIO ");
            Console.WriteLine("3. TETRIS      ");
            Console.WriteLine(" ");
            Console.Write("SILAHKAN INPUT =  ");
            int music = Convert.ToInt32(Console.ReadLine());

            if (music == 1)
            {

                string hbd = @"
   ___________________§§§§§§
_____________§§§§__§§__§§_§§§§§§
_____§§__§§_§§__§§_§§§§§§_§§__§§_§§____§§
_____§§__§§_§§§§§§_§§_____§§§§§§__§§__§§
_____§§§§§§_§§__§§_§§_____§§_______§§§§
_____§§__§§_§§__§§________§§________§§
_____§§__§§_________________________§§
_______§§§§§§___§§__§§§§§__§§§§§§_§§__§§
_______§§___§§__§§__§§__§§___§§___§§__§§
_______§§§§§§___§§__§§§§§____§§___§§§§§§
_______§§___§§__§§__§§_§§____§§___§§__§§
_______§§§§§§___§§__§§__§§___§§___§§__§§
__________§§§§§§§__________§§____§§
___________§§___§§___§§§§§__§§__§§
___________§§___§§__§§___§§__§§§§
___________§§___§§__§§§§§§§___§§
__________§§§§§§§___§§___§§___§§
____________________§§___§§
________________¶¶
_______________¶¶¶¶_______________¶¶
______________¶¶S¶¶______¶¶_____¶¶¶¶
_____________¶¶SS¶_____¶¶¶¶____¶¶SS¶
_____________¶¶S¶¶____¶¶SS¶___¶¶SS¶¶
______________¶¶______¶SS¶_____¶SS¶
_____________¶¶¶¶¶_____¶¶_______¶¶
_____________¶__¶¶____¶¶¶¶¶____¶¶¶¶¶
_____________¶__¶¶____¶__¶¶____¶__¶¶
_____________¶__¶_____¶__¶¶____¶__¶¶
_____________¶__¶_____¶__¶¶____¶__¶
_____________¶__¶_____¶__¶_____¶__¶
___________¶¶¶__¶¶¶¶¶¶¶__¶¶¶¶¶¶¶__¶
________¶¶¶¶¶¶__¶11111¶__¶11111¶__¶¶¶¶
______¶¶¶1111¶__¶11111¶__¶11111¶__¶11¶¶¶¶
_____¶¶111$11¶¶¶¶11111¶__¶11111¶¶¶¶11$11¶¶¶
____¶¶111$$$$11111$111¶¶¶¶11$1111111$$$$11¶¶
____¶¶¶¶111$11111$$$$111111$$$$1111111$11¶¶¶
____¶__¶¶¶¶¶¶¶¶1111$111111111$1111111¶¶¶¶¶_¶
___¶¶______¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶____¶¶¶
_¶¶¶¶_____§§________________________§§__¶¶11¶¶
¶¶11¶¶__§§_§§___§§_____§§____§§___§§_§§_¶¶111¶
¶111¶¶¶___§§___§§_§§__§§_§§_§§_§§___§§_¶¶¶111¶
¶1111¶¶¶¶________§§_____§§____§§_____¶¶¶¶111¶¶
¶¶¶¶111¶¶¶¶¶¶¶¶¶¶¶________¶¶¶¶¶¶¶¶¶¶¶¶¶¶11¶¶¶¶
__¶¶¶¶¶11111111¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶11111111¶¶¶
____¶¶¶11111111111111111111111111111111111¶¶
_____¶¶¶¶111¶¶¶¶11111111¶¶11111111¶¶¶¶1111¶¶
______¶¶¶¶¶¶¶¶¶¶¶111¶¶¶¶¶¶¶1111¶¶¶_¶¶¶¶¶¶¶
_______________¶¶¶¶¶¶¶¶___¶¶¶¶¶¶¶¶
                                       ";
                Console.Clear();
                Console.WriteLine(hbd);
                SoundPlayer happybd = new SoundPlayer(@"D:\project saa jonathan'\suara\Happy Birthday to You - piano instrumental with lyrics.wav");
                happybd.Play();
                Console.ReadKey();
            }
            if (music == 2)
            {
                string mario = @"
              ███████  ███████
          ████▓▓▓▓▓▓████░░░░░██
        ██▓▓▓▓▓▓▓▓▓▓▓▓██░░░░░░██
       ██▓▓▓▓▓▓████████████░░░░██
     ██▓▓▓▓▓▓████████████████░██
    ██▓▓████░░░░░░░░░░░░██████
  ████████░░░░░░██░░██░░██▓▓▓▓██              ███╗░░░███╗░█████╗░██████╗░██╗░█████╗░
 ██░░████░░░░░░██░░██░░██▓▓▓▓██               ████╗░████║██╔══██╗██╔══██╗██║██╔══██╗
██░░░░██████░░░░░░░░░░░░░░██▓▓██              ██╔████╔██║███████║██████╔╝██║██║░░██║
██░░░░░░██░░░░██░░░░░░░░░░██▓▓██              ██║╚██╔╝██║██╔══██║██╔══██╗██║██║░░██║
  ██░░░░░░░░░███████░░░░██████                ██║░╚═╝░██║██║░░██║██║░░██║██║╚█████╔╝
    ████░░░░░░░███████████▓▓██                ╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░╚════╝░
     ██████░░░░░░░░░░██▓▓▓▓██
   ██▓▓▓▓██████████████▓▓██
 ██▓▓▓▓▓▓▓▓████░░░░░░████
████▓▓▓▓▓▓▓▓██░░░░░░░░░░██
████▓▓▓▓▓▓▓▓██░░░░░░░░░░██                   
██████▓▓▓▓▓▓▓▓██░░░░░░████████
 ██████▓▓▓▓▓▓████████████████
    █████████████████████▓▓▓▓██
  ██▓▓▓▓████████████████▓▓▓▓▓▓██
████▓▓██████████████████▓▓▓▓▓▓██
██▓▓▓▓██████████████████▓▓▓▓▓▓██
██▓▓▓▓██████████     ██▓▓▓▓████
██▓▓▓▓████              ██████ 
  ████
                                                     ";
                Console.Clear();
                Console.WriteLine(mario);
                SoundPlayer mariobros = new SoundPlayer(@"D:\project saa jonathan'\suara\Super Mario Theme - EASY Piano Tutorial by PlutaX.wav");
                mariobros.Play();
                Console.ReadKey();
            }

            if (music == 3)
            {

                string tetris = @"
             ███████████████████████████████████████████████████████████████████████████████████████████
             █░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░░░███░░░░░░░░░░█░░░░░░░░░░░░░░█
             █░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀▄▀░░███░░▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█
             █░░░░░░▄▀░░░░░░█░░▄▀░░░░░░░░░░█░░░░░░▄▀░░░░░░█░░▄▀░░░░░░░░▄▀░░███░░░░▄▀░░░░█░░▄▀░░░░░░░░░░█
             █████░░▄▀░░█████░░▄▀░░█████████████░░▄▀░░█████░░▄▀░░████░░▄▀░░█████░░▄▀░░███░░▄▀░░█████████
             █████░░▄▀░░█████░░▄▀░░░░░░░░░░█████░░▄▀░░█████░░▄▀░░░░░░░░▄▀░░█████░░▄▀░░███░░▄▀░░░░░░░░░░█
             █████░░▄▀░░█████░░▄▀▄▀▄▀▄▀▄▀░░█████░░▄▀░░█████░░▄▀▄▀▄▀▄▀▄▀▄▀░░█████░░▄▀░░███░░▄▀▄▀▄▀▄▀▄▀░░█
             █████░░▄▀░░█████░░▄▀░░░░░░░░░░█████░░▄▀░░█████░░▄▀░░░░░░▄▀░░░░█████░░▄▀░░███░░░░░░░░░░▄▀░░█
             █████░░▄▀░░█████░░▄▀░░█████████████░░▄▀░░█████░░▄▀░░██░░▄▀░░███████░░▄▀░░███████████░░▄▀░░█
             █████░░▄▀░░█████░░▄▀░░░░░░░░░░█████░░▄▀░░█████░░▄▀░░██░░▄▀░░░░░░█░░░░▄▀░░░░█░░░░░░░░░░▄▀░░█
             █████░░▄▀░░█████░░▄▀▄▀▄▀▄▀▄▀░░█████░░▄▀░░█████░░▄▀░░██░░▄▀▄▀▄▀░░█░░▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█
             █████░░░░░░█████░░░░░░░░░░░░░░█████░░░░░░█████░░░░░░██░░░░░░░░░░█░░░░░░░░░░█░░░░░░░░░░░░░░█ 
             ███████████████████████████████████████████████████████████████████████████████████████████
                
                                  
                                                         ";

                Console.Clear();
                Console.WriteLine(tetris);
                SoundPlayer ter = new SoundPlayer(@"D:\project saa jonathan'\suara\Tetris Theme - Korobeiniki [Piano Tutorial] (Synthesia).wav");
                ter.Play();
                Console.ReadKey();
            }


        }

        static void exit()
        {
            Console.Clear();
            string thanks = @"
────────────────────▄▄▄▄
────────────────▄▄█▀▀──▀▀█▄
─────────────▄█▀▀─────────▀▀█▄
────────────▄█▀──▄▄▄▄▄▄──────▀█
────────────█───█▌────▀▀█▄─────█
────────────█──▄█────────▀▀▀█──█
────────────█──█──▀▀▀──▀▀▀▄─▐──█
────────────█──▌────────────▐──█
────────────█──▌─▄▀▀▄───────▐──█
───────────█▀▌█──▄▄▄───▄▀▀▄─▐──█
───────────▌─▀───█▄█▌─▄▄▄────█─█
───────────▌──────▀▀──█▄█▌────█
───────────█───────────▀▀─────▐
────────────█──────▌──────────█
────────────██────█──────────█
─────────────█──▄──█▄█─▄────█
─────────────█──▌─▄▄▄▄▄─█──█
─────────────█─────▄▄──▄▀─█
─────────────█▄──────────█
─────────────█▀█▄▄──▄▄▄▄▄█▄▄▄▄▄
───────────▄██▄──▀▀▀█─────────█
──────────██▄─█▄────█─────────█
───▄▄▄▄███──█▄─█▄───█─────────██▄▄▄
▄█▀▀────█────█──█▄──█▓▓▓▓▓▓▓▓▓█───▀▀▄
█──────█─────█───████▓▓▓▓▓▓▓▓▓█────▀█
█──────█─────█───█████▓▓▓▓▓▓▓█──────█
█─────█──────█───███▀▀▀▀█▓▓▓█───────█
█────█───────█───█───▄▄▄▄████───────█
█────█───────█──▄▀───────────█──▄───█
█────█───────█─▄▀─────█████▀▀▀─▄█───█
█────█───────█▄▀────────█─█────█────█
█────█───────█▀───────███─█────█────█
█─────█────▄█▀──────────█─█────█────█
█─────█──▄██▀────────▄▀██─█▄───█────█
█────▄███▀─█───────▄█─▄█───█▄──█────█
█─▄██▀──█──█─────▄███─█─────█──█────█
██▀────▄█───█▄▄▄█████─▀▀▀▀█▀▀──█────█
█──────█────▄▀──█████─────█────▀█───█
───────█──▄█▀───█████─────█─────█───█
──────▄███▀─────▀███▀─────█─────█───█
─────────────────────────────────────
 ▀█▀ █░█ ▄▀█ █▄░█ █▄▀   █▄█ █▀█ █░█
 ░█░ █▀█ █▀█ █░▀█ █░█   ░█░ █▄█ █▄█
                                    ";

            Console.WriteLine(thanks);

            Console.ReadKey();
        }
    }
}

