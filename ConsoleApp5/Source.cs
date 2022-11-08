using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class Game
{
    private char[,] field = new char[,] { { 'o', 'o', 'o' }, { 'o', 'o', 'o' }, { 'o', 'o', 'o' } };
    public void field_draw()
    {
        Console.WriteLine();

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(field[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public bool check_win()
    {
        if (field[0, 0] == 'X' &&
            field[0, 1] == 'X' &&
            field[0, 2] == 'X')
        {
            Console.WriteLine("Победил крестик!");
            return true;
        }

        else if (field[1, 0] == 'X' &&
            field[1, 1] == 'X' &&
            field[1, 2] == 'X')
        {
            Console.WriteLine("Победил крестик!");
            return true;
        }

        else if (field[2, 0] == 'X' &&
            field[2, 1] == 'X' &&
            field[2, 2] == 'X')
        {
            Console.WriteLine("Победил крестик!");
            return true;
        }

        else if (field[0, 0] == 'X' &&
            field[1, 1] == 'X' &&
            field[2, 2] == 'X')
        {
            Console.WriteLine("Победил крестик!");
            return true;
        }

        else if (field[0, 2] == 'X' &&
            field[1, 1] == 'X' &&
            field[2, 0] == 'X')
        {
            Console.WriteLine("Победил крестик!");
            return true;
        }

        else if (field[0, 0] == 'X' &&
            field[1, 0] == 'X' &&
            field[2, 0] == 'X')
        {
            Console.WriteLine("Победил крестик!");
            return true;
        }

        else if (field[0, 1] == 'X' &&
            field[1, 1] == 'X' &&
            field[2, 1] == 'X')
        {
            Console.WriteLine("Победил крестик!");
            return true;
        }

        else if (field[0, 2] == 'X' &&
            field[1, 2] == 'X' &&
            field[2, 2] == 'X')
        {
            Console.WriteLine("Победил крестик!");
            return true;
        }

        else if (field[0, 0] == 'O' &&
            field[0, 1] == 'O' &&
            field[0, 2] == 'O')
        {
            Console.WriteLine("Победил нолик!");
            return true;
        }

        else if (field[1, 0] == 'O' &&
            field[1, 1] == 'O' &&
            field[1, 2] == 'O')
        {
            Console.WriteLine("Победил нолик!");
            return true;
        }

        else if (field[2, 0] == 'O' &&
            field[2, 1] == 'O' &&
            field[2, 2] == 'O')
        {
            Console.WriteLine("Победил нолик!");
            return true;
        }

        else if (field[0, 0] == 'O' &&
            field[1, 1] == 'O' &&
            field[2, 2] == 'O')
        {
            Console.WriteLine("Победил нолик!");
            return true;
        }

        else if (field[0, 2] == 'O' &&
            field[1, 1] == 'O' &&
            field[2, 0] == 'O')
        {
            Console.WriteLine("Победил нолик!");
            return true;
        }

        else if (field[0, 0] == 'O' &&
            field[1, 0] == 'O' &&
            field[2, 0] == 'O')
        {
            Console.WriteLine("Победил нолик!");
            return true;
        }

        else if (field[0, 1] == 'O' &&
            field[1, 1] == 'O' &&
            field[2, 1] == 'O')
        {
            Console.WriteLine("Победил нолик!");
            return true;
        }

        else if (field[0, 2] == 'O' &&
            field[1, 2] == 'O' &&
            field[2, 2] == 'O')
        {
            Console.WriteLine("Победил нолик!");
            return true;
        }

        else return false;
    }

    public void play()
    {
        int pos;

        field_draw();

        for (int i = 0; i < field.Length; i++)
        {
            if (i % 2 == 0)
            {
                while (true)
                {
                    Console.WriteLine("Ходит крестик\n");
                    Console.Write("Введите точку (1-9): ");

                    pos = Convert.ToInt32(Console.ReadLine());

                    if (pos > 0 && pos <= 3)
                    {
                        if (field[0, pos - 1] != 'o')
                        {
                            Console.WriteLine("Эта ячейка уже занята!\n");
                            field_draw();
                            continue;
                        }
                        else
                        {
                            field[0, pos - 1] = 'X';
                            field_draw();
                            break;
                        }
                    }

                    if (pos > 3 && pos <= 6)
                    {
                        if (field[1, pos - 4] != 'o')
                        {
                            Console.WriteLine("Эта ячейка уже занята!\n");
                            field_draw();
                            continue;
                        }
                        else
                        {
                            field[1, pos - 4] = 'X';
                            field_draw();
                            break;
                        }
                    }

                    if (pos > 6 && pos <= 9)
                    {
                        if (field[2, pos - 7] != 'o')
                        {
                            Console.WriteLine("Эта ячейка уже занята!\n");
                            field_draw();
                            continue;
                        }
                        else
                        {
                            field[2, pos - 7] = 'X';
                            field_draw();
                            break;
                        }
                    }
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Ходит нолик\n");
                    Console.Write("Введите точку (1-9): ");

                    pos = Convert.ToInt32(Console.ReadLine());

                    if (pos > 0 && pos <= 3)
                    {
                        if (field[0, pos - 1] != 'o')
                        {
                            Console.WriteLine("Эта ячейка уже занята!\n");
                            field_draw();
                            continue;
                        }
                        else
                        {
                            field[0, pos - 1] = 'O';
                            field_draw();
                            break;
                        }
                    }

                    if (pos > 3 && pos <= 6)
                    {
                        if (field[1, pos - 4] != 'o')
                        {
                            Console.WriteLine("Эта ячейка уже занята!\n");
                            field_draw();
                            continue;
                        }
                        else
                        {
                            field[1, pos - 4] = 'O';
                            field_draw();
                            break;
                        }
                    }

                    if (pos > 6 && pos <= 9)
                    {
                        if (field[2, pos - 7] != 'o')
                        {
                            Console.WriteLine("Эта ячейка уже занята!\n");
                            field_draw();
                            continue;
                        }
                        else
                        {
                            field[2, pos - 7] = 'O';
                            field_draw();
                            break;
                        }
                    }
                }
            }

            if (check_win()) break;
            if (i >= 8)
            {
                if (!check_win())
                {
                    Console.WriteLine("Ничья");
                    break;
                }
            }
            else continue;
        }
    }
    public void play_computer()
    {
        int pos;

        Random rand = new Random();

        field_draw();

        for (int i = 0; i < field.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Ходит крестик\n");
                while (true)
                {
                    Console.Write("Введите точку (1-9): ");

                    pos = Convert.ToInt32(Console.ReadLine());

                    if (pos > 0 && pos <= 3)
                    {
                        if (field[0, pos - 1] != 'o')
                        {
                            Console.WriteLine("Эта ячейка уже занята!\n");
                            field_draw();
                            continue;
                        }
                        else
                        {
                            field[0, pos - 1] = 'X';
                            field_draw();
                            break;
                        }
                    }

                    if (pos > 3 && pos <= 6)
                    {
                        if (field[1, pos - 4] != 'o')
                        {
                            Console.WriteLine("Эта ячейка уже занята!\n");
                            field_draw();
                            continue;
                        }
                        else
                        {
                            field[1, pos - 4] = 'X';
                            field_draw();
                            break;
                        }
                    }

                    if (pos > 6 && pos <= 9)
                    {
                        if (field[2, pos - 7] != 'o')
                        {
                            Console.WriteLine("Эта ячейка уже занята!\n");
                            field_draw();
                            continue;
                        }
                        else
                        {
                            field[2, pos - 7] = 'X';
                            field_draw();
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Ходит компьютер (нолик)");
                while (true)
                {
                    Thread.Sleep(250);

                    pos = rand.Next(1, 9);

                    if (pos > 0 && pos <= 3)
                    {
                        if (field[0, pos - 1] != 'o')
                        {
                            continue;
                        }
                        else
                        {
                            field[0, pos - 1] = 'O';
                            field_draw();
                            break;
                        }
                    }

                    if (pos > 3 && pos <= 6)
                    {
                        if (field[1, pos - 4] != 'o')
                        {
                            continue;
                        }
                        else
                        {
                            field[1, pos - 4] = 'O';
                            field_draw();
                            break;
                        }
                    }

                    if (pos > 6 && pos <= 9)
                    {
                        if (field[2, pos - 7] != 'o')
                        {
                            continue;
                        }
                        else
                        {
                            field[2, pos - 7] = 'O';
                            field_draw();
                            break;
                        }
                    }
                }
                if (check_win()) break;
                if (i >= 8)
                {
                    if (!check_win())
                    {
                        Console.WriteLine("Ничья");
                        break;
                    }
                }
                else continue;
            }
        }
    }

    public void settings()
    {
        short set;

        Console.Clear();
        Console.WriteLine("Настройки цвета");
        Console.WriteLine("1) Красный");
        Console.WriteLine("2) Желтый");
        Console.WriteLine("3) Зеленый");
        Console.WriteLine("4) Синий");
        Console.WriteLine("5) Розовый\n");

        Console.Write("> ");
        set = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine();

        switch (set)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Установлен красный цвет\n!");
                Thread.Sleep(1000);
                Console.Clear();
                text();
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Установлен желтый цвет!\n");
                Thread.Sleep(1000);
                Console.Clear();
                text();
                break;
            case 3:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Установлен зеленый цвет!\n");
                Thread.Sleep(1000);
                Console.Clear();
                text();
                break;
            case 4:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Установлен синий цвет!\n");
                Thread.Sleep(1000);
                Console.Clear();
                text();
                break;
            case 5:
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Установлен розовый цвет!\n");
                Thread.Sleep(1000);
                Console.Clear();
                text();
                break;
            default:
                Console.WriteLine("Тут нет такой цифры!!");
                break;
        }
    }

    public void text()
    {
        short pos;

        Console.Title = "Tic-Tac-Toe";
        Console.WriteLine(" Крестики - нолики\n");
        Console.WriteLine(" Меню");
        Console.WriteLine(" --------------------------------");
        Console.WriteLine(" 1) Игра с игроком");
        Console.WriteLine(" 2) Игра с ботом");
        Console.WriteLine(" 3) Настройки");
        Console.WriteLine(" --------------------------------\n");

        Console.Write("> ");
        pos = Convert.ToInt16(Console.ReadLine());

        switch (pos)
        {
            case 1:
                play();
                break;
            case 2:
                play_computer();
                break;
            case 3:
                Console.Clear();
                settings();
                break;
            default:
                Console.WriteLine(" Технические шоколадки... \n Цифру правильную выбери!!! (1/2)");
                break;
        }
    }
}
