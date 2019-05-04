﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string imieGraczaA = "";
            string imieGraczaB = "";
            char znakGraczaA = 'x';
            char znakGraczaB = 'o';
            char[,] plansza = new char[3, 3]
            {
                {'1', '2', '3'},
                {'4', '5', '6'},
                {'7', '8', '9'}
            };

            Console.Write("Wpisz imię gracza A: ");
            imieGraczaA = Console.ReadLine();
            Console.Write("Wpisz imię gracza B: ");
            imieGraczaB = Console.ReadLine();

            bool gameOver = false;
            while (!gameOver)
            {
                Console.Clear();
                RysujPlansze(plansza);
                Console.ReadKey();
            }
        }

        static void RysujPlansze(char[,] plansza)
        {
            int height = plansza.GetLength(0);
            int width = plansza.GetLength(1);

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                Console.Write(plansza[i, j]);
                Console.WriteLine();
            }
        }
    }
}