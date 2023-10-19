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
        private int vibor12;
        private int vibor2;
        private int vibor22;
        private int nach;
        private int[] otv = new int[9];
        private int[,] otv2 = new int[4, 4];
        private int osh2;
        private int x;
        private int y;
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
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        do
                        {
                            osh = 0;
                            pole = rnd.Next(1, 9);
                            nombers[i, j] = pole;
                            otv2[i, j] = pole;
                            otv[pole] = otv[pole] + 1;
                            for (int c = 0; c < 9; c++)
                            {
                                if (otv[c] > 2)
                                {
                                    otv[c] -= 1;
                                    osh++;
                                }
                            }
                        } while (osh == 1);
                    }
                }
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("-----------------");
                Console.WriteLine($"| {nombers[0, 0]} | {nombers[0, 1]} | {nombers[0, 2]} | {nombers[0, 3]} |");
                Console.WriteLine("-----------------");
                Console.WriteLine($"| {nombers[1, 0]} | {nombers[1, 1]} | {nombers[1, 2]} | {nombers[1, 3]} |");
                Console.WriteLine("-----------------");
                Console.WriteLine($"| {nombers[2, 0]} | {nombers[2, 1]} | {nombers[2, 2]} | {nombers[2, 3]} |");
                Console.WriteLine("-----------------");
                Console.WriteLine($"| {nombers[3, 0]} | {nombers[3, 1]} | {nombers[3, 2]} | {nombers[3, 3]} |");
                Console.WriteLine("-----------------");
                Console.WriteLine("Введите любое число, чтобы начать игру.");
                nach = Convert.ToInt32(Console.ReadLine());
                while (game < 8)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("-----------------");
                    Console.WriteLine($"|   |   |   |   |");
                    Console.WriteLine("-----------------");
                    Console.WriteLine($"|   |   |   |   |");
                    Console.WriteLine("-----------------");
                    Console.WriteLine($"|   |   |   |   |");
                    Console.WriteLine("-----------------");
                    Console.WriteLine($"|   |   |   |   |");
                    Console.WriteLine("-----------------");
                    do
                    {
                        game1();
                        if (vibor12 < 17)
                        {
                            game2();
                            Console.SetCursorPosition(0, 13);
                            Console.WriteLine("     ");
                            Console.SetCursorPosition(0, 15);
                            Console.WriteLine("      ");
                            Console.SetCursorPosition(0, 19);
                            Console.WriteLine("      ");
                            Console.SetCursorPosition(0, 21);
                            Console.WriteLine("      ");
                            if (vibor1 == vibor2 && vibor12 == vibor22)
                            { Console.WriteLine("Вы не можете открывать одну и ту же клетку."); }
                            else
                            {
                                if (nombers[vibor1, vibor12] == otv2[vibor2, vibor22])
                                {
                                    x = 2;
                                    y = 3;
                                    for (int i = 0; i < 4; i++)
                                    {
                                        for (int j = 0; j < 4; j++)
                                        {
                                            if (nombers[i, j] == nombers[vibor1, vibor12] || nombers[i, j] == otv2[vibor2, vibor22])
                                            {
                                                Console.SetCursorPosition(x, y); 
                                                Console.WriteLine(nombers[i, j]);
                                            }
                                            x += 4;
                                        }
                                        x = 2;
                                        y += 2;
                                    }
                                    Console.SetCursorPosition(0, 22);
                                    game++;
                                    Console.WriteLine("Было найдено пар:" + game);
                                }
                                else if (nombers[vibor1, vibor12] != otv2[vibor2, vibor22])
                                {
                                    game = 0;
                                    Console.SetCursorPosition(0, 2);
                                    Console.WriteLine("-----------------");
                                    Console.WriteLine($"|   |   |   |   |");
                                    Console.WriteLine("-----------------");
                                    Console.WriteLine($"|   |   |   |   |");
                                    Console.WriteLine("-----------------");
                                    Console.WriteLine($"|   |   |   |   |");
                                    Console.WriteLine("-----------------");
                                    Console.WriteLine($"|   |   |   |   |");
                                    Console.WriteLine("-----------------");
                                    Console.SetCursorPosition(0, 22);
                                    Console.WriteLine("Вы допустили ошибку. Теперь найдено пар: " + game);
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
                Console.WriteLine("Введите строка от 0 до 3, в которой вы хотите открыть ячейку.");
                vibor1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите колонка от 0 до 3, в которой вы хотите открыть ячейку. Если хотите начать заново, то введите 17");
                vibor12 = Convert.ToInt32(Console.ReadLine());
                if (vibor1 > 3 || vibor12 > 3 || vibor1 < 0 || vibor12 < 0)
                {
                    osh++;
                }
            } while (osh == 1);
            return vibor1;
        }
        private int game2()
        {
            do { 
            Console.SetCursorPosition(0, 17);
            Console.WriteLine("Напишите, какую вторую клетку вы хотите открыть.");
            Console.WriteLine("Введите строка от 0 до 3, в которой вы хотите открыть ячейку.");
            vibor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите колонка от 0 до 3, в которой вы хотите открыть ячейку.");
            vibor22 = Convert.ToInt32(Console.ReadLine());
                if (vibor2 > 3 || vibor22 > 3 || vibor2 < 0 || vibor22 < 0)
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