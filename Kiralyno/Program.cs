using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kiralyno
{
    class Tabla
    {
        private char[,] T = new char[8,8]; 
        private char UresCella;
        private int UresOszlopokSzama;
        private int UresSorokSzama;

        public void Elhelyez()
        {
            //1. véletlen helyiérték létrehozása:
            //      - Random osztály érték készlete: [0,7]
            //       - véletlen sor és oszlop kell  
            //        - elhelyezzük a "K"-t csak akkor, 
            //                 HA üres ---> "#"

            Random vel = new Random();
            int sor = vel.Next(0, 8);
            int oszlop = vel.Next(0, 8);

            if (T[sor,oszlop] == '#')
            {
                T[sor, oszlop] = 'K';
            }

            T[sor, oszlop] = 'K';
        }
        public void FajlbaIr()
        {

        }
        public void Megjelenit()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{T[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public Tabla(char ch)
        {
            T = new char[8, 8];
            UresCella = ch;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    T[i, j] = UresCella;
                }
            }
        }

        public int UresOszlop()
        {
            return 0;
        }

        public int UresSor()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Királynők feladat");
            Tabla t = new Tabla('#');
            Console.WriteLine("Üres tábla:");

            t.Megjelenit();
            t.Elhelyez();
            Console.WriteLine();
            t.Megjelenit();

            Console.ReadKey();

        }
    }
}
