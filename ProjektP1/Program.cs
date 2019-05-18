using System;
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
            GraczLudzki gL = new GraczLudzki();
            GraczKomputerowy gK = new GraczKomputerowy();
            string imieGraczaA = "Użytkownik";
            string imieGraczaB = "Komputer";
            char znakGraczaA = 'x';
            char znakGraczaB = 'o';

            char[,] plansza = new char[3, 3]
            {
                {'1', '2', '3'},
                {'4', '5', '6'},
                {'7', '8', '9'}
            };

            bool gameOver = false;
            bool ruchGraczaA = true;
            while (!gameOver)
            {
                Console.Clear();
                RysujPlansze(plansza);
                if (ruchGraczaA)
                {
                    Console.WriteLine("Ruch wykonuje: " + gL.Imie);
                    gameOver = gL.WykonajRuch(plansza);
                    ruchGraczaA = false;
                }
                else
                {
                    Console.WriteLine("Ruch wykonuje: " + gK.Imie);
                    gameOver = gK.WykonajRuch(plansza);
                    ruchGraczaA = true;
                }
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
        interface IRuch
        {
            bool WykonajRuch(char[,] plansza);
        }
        abstract class Gracz
        {
            public string Imie { get; set; }
            public char Znak { get; set; }
        }
        class GraczLudzki : Gracz, IRuch
        {
            public bool WykonajRuch(char[,] plansza)
            {
                return false; //popraw
            }
        }
        class GraczKomputerowy : Gracz, IRuch
        {
            public bool WykonajRuch(char[,] plansza)
            {
                return false; //popraw
            }
        }
    }
}