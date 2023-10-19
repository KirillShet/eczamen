using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        private int game;
        private int pole;
        private int vibor1;
        private int vibor2;
        private int[] otv = new int[17];
        private int osh2;
        private int one;
        private int dwa;
        private int tri;
        private int chet;
        private int osh;
        private int[,] nombers = new int[4, 4];
        public void pole1()
        {
            Random rnd = new Random();
            do
            {
                osh2 = 0;
                game = 0;
                one = 0;
                dwa = 0;
                tri = 0;
                chet = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        do
                        {
                            osh = 0;
                            pole = rnd.Next(1, 5);
                            nombers[i, j] = pole;
                            if (pole == 1) { one++; }
                            if (pole == 2) { dwa++; }
                            if (pole == 3) { tri++; }
                            if (pole == 4) { chet++; }
                            if (one > 2 || dwa > 2 || tri > 2 || chet > 2)
                            {
                                osh++;
                                if (one >= 2)
                                { one = 2; }
                                if (dwa >= 2)
                                { dwa = 2; }
                                if (tri >= 2)
                                { tri = 2; }
                                if (chet >= 2)
                                { chet = 2; }
                            }
                        } while (osh == 1);
                    }
                }
                for (int i = 2; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        do
                        {
                            osh = 0;
                            pole = rnd.Next(5, 9);
                            nombers[i, j] = pole;
                            if (pole == 5)
                            {
                                one++;
                            }
                            if (pole == 6) { dwa++; }
                            if (pole == 7) { tri++; }
                            if (pole == 8) { chet++; }
                            if (one > 4 || dwa > 4 || tri > 4 || chet > 4)
                            {
                                osh++;
                                if (one >= 4)
                                { one = 4; }
                                if (dwa >= 4)
                                { dwa = 4; }
                                if (tri >= 4)
                                { tri = 4; }
                                if (chet >= 4)
                                { chet = 4; }
                            }
                        } while (osh == 1);
                    }
                }
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("------------------");
                Console.WriteLine($"|{nombers[0, 0]}  |{nombers[0, 1]}  | {nombers[0, 2]} | {nombers[0, 3]} |");
                Console.WriteLine("------------------");
                Console.WriteLine($"|{nombers[1, 0]}  | {nombers[1, 1]} | {nombers[1, 2]} | {nombers[1, 3]} |");
                Console.WriteLine("------------------");
                Console.WriteLine($"| {nombers[2, 0]} |{nombers[2, 1]}  | {nombers[2, 2]} |{nombers[2, 3]}  |");
                Console.WriteLine("------------------");
                Console.WriteLine($"|{nombers[3, 0]}  |{nombers[3, 1]}  | {nombers[3, 2]} | {nombers[3, 3]} |");
                Console.WriteLine("------------------");
                game1();
                while (game < 8)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("------------------");
                    Console.WriteLine($"|   |   |   |   |");
                    Console.WriteLine("------------------");
                    Console.WriteLine($"|   |   |   |   |");
                    Console.WriteLine("------------------");
                    Console.WriteLine($"|   |   |   |   |");
                    Console.WriteLine("------------------");
                    Console.WriteLine($"|   |   |   |   |");
                    Console.WriteLine("------------------");
                    do
                    {
                        game1();
                        if (vibor1 < 17)
                        {
                            game2();
                            Console.SetCursorPosition(0, 13);
                            Console.WriteLine("     ");
                            Console.SetCursorPosition(0, 16);
                            Console.WriteLine("      ");
                            if (vibor1 == vibor2)
                            { Console.WriteLine("Вы не можете открывать одну и ту же клетку."); }
                            else
                            {
                                if (vibor1 == 1 || vibor2 == 1)
                                { Console.SetCursorPosition(2, 3); Console.WriteLine($"{nombers[0, 0]}"); otv[1] = nombers[0, 0]; }
                                if (vibor1 == 2 || vibor2 == 2)
                                { Console.SetCursorPosition(6, 3); Console.WriteLine(nombers[0, 1]); otv[2] = nombers[0, 1]; }
                                if (vibor1 == 3 || vibor2 == 3)
                                { Console.SetCursorPosition(9, 3); Console.WriteLine(nombers[0, 2]); otv[3] = nombers[0, 2]; }
                                if (vibor1 == 4 || vibor2 == 4)
                                { Console.SetCursorPosition(14, 3); Console.WriteLine(nombers[0, 3]); otv[4] = nombers[0, 3]; }
                                if (vibor1 == 5 || vibor2 == 5)
                                { Console.SetCursorPosition(2, 5); Console.WriteLine($"{nombers[1, 0]}"); otv[5] = nombers[1, 0]; }
                                if (vibor1 == 6 || vibor2 == 6)
                                { Console.SetCursorPosition(6, 5); Console.WriteLine(nombers[1, 1]); otv[6] = nombers[1, 1]; }
                                if (vibor1 == 7 || vibor2 == 7)
                                { Console.SetCursorPosition(9, 5); Console.WriteLine(nombers[1, 2]); otv[7] = nombers[1, 2]; }
                                if (vibor1 == 8 || vibor2 == 8)
                                { Console.SetCursorPosition(14, 5); Console.WriteLine(nombers[1, 3]); otv[8] = nombers[1, 3]; }
                                if (vibor1 == 9 || vibor2 == 9)
                                { Console.SetCursorPosition(2, 7); Console.WriteLine($"{nombers[2, 0]}"); otv[9] = nombers[2, 0]; }
                                if (vibor1 == 10 || vibor2 == 10)
                                { Console.SetCursorPosition(6, 7); Console.WriteLine(nombers[2, 1]); otv[10] = nombers[2, 1]; }
                                if (vibor1 == 11 || vibor2 == 11)
                                { Console.SetCursorPosition(9, 7); Console.WriteLine(nombers[2, 2]); otv[11] = nombers[2, 2]; }
                                if (vibor1 == 12 || vibor2 == 12)
                                { Console.SetCursorPosition(14, 7); Console.WriteLine(nombers[2, 3]); otv[12] = nombers[2, 3]; }
                                if (vibor1 == 13 || vibor2 == 13)
                                { Console.SetCursorPosition(2, 9); Console.WriteLine($"{nombers[3, 0]}"); otv[13] = nombers[3, 0]; }
                                if (vibor1 == 14 || vibor2 == 14)
                                { Console.SetCursorPosition(6, 9); Console.WriteLine(nombers[3, 1]); otv[14] = nombers[3, 1]; }
                                if (vibor1 == 15 || vibor2 == 15)
                                { Console.SetCursorPosition(9, 9); Console.WriteLine(nombers[3, 2]); otv[15] = nombers[3, 2]; }
                                if (vibor1 == 16 || vibor2 == 16)
                                { Console.SetCursorPosition(14, 9); Console.WriteLine(nombers[3, 3]); otv[16] = nombers[3, 3]; }
                                if (otv[vibor1] == otv[vibor2])
                                {
                                    Console.SetCursorPosition(0, 17);
                                    game++;
                                    Console.WriteLine("Было найдено пар:" + game);
                                }
                                else if (otv[vibor1] != otv[vibor2])
                                {
                                    game = 0;
                                    Console.SetCursorPosition(0, 2);
                                    Console.WriteLine("------------------");
                                    Console.WriteLine($"|   |   |   |   |");
                                    Console.WriteLine("------------------");
                                    Console.WriteLine($"|   |   |   |   |");
                                    Console.WriteLine("------------------");
                                    Console.WriteLine($"|   |   |   |   |");
                                    Console.WriteLine("------------------");
                                    Console.WriteLine($"|   |   |   |   |");
                                    Console.WriteLine("------------------");
                                    Console.SetCursorPosition(0, 17);
                                    Console.WriteLine(game);
                                }
                            }
                        }
                        else if (vibor1 == 17)
                        {
                            osh2++;
                            game = 10;
                        }
                    } while (game < 8);
                }
            } while (osh2 == 1);
            pobeda();
        }

        private int game1()
        {
            do
            {
                osh = 0;
                Console.SetCursorPosition(0, 11);
                Console.WriteLine("Напишите, какую клетку вы хотите открыть.");
                Console.WriteLine("Клетки же считаются от 1 до 16 с лева на право. Если хотите начать заново, то введите 17");
                vibor1 = Convert.ToInt32(Console.ReadLine());
                if (vibor1 > 17)
                {
                    osh++;
                }
            } while (osh == 1);
            return vibor1;
        }
        private int game2()
        {
            do { 
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("Напишите, какую вторую клетку вы хотите открыть.");
            Console.WriteLine("Клетки же считаются от 1 до 16 с лева на право.");
            vibor2 = Convert.ToInt32(Console.ReadLine());
            if (vibor1 > 16)
            {
                osh++;
            }
        } while (osh == 1);
            return vibor2;
        }
        private int pobeda()
        {
            Console.WriteLine("Поздравляю! Вы нашли все пары на игровом поле!");
            return game;
        }
    }
}