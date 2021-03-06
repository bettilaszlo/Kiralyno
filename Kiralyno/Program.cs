﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kiralyno
{
    class Tabla
    {
        private char[,] T = new char[8, 8];
        private char UresCella;
        private int UresOszlopokSzama;
        private int UresSorokSzama;

        public void Elhelyez(int N)
        {
            //1. véletlen helyiérték létrehozása:
            //      - Random osztály érték készlete: [0,7]
            //       - véletlen sor és oszlop kell  
            //        - elhelyezzük a "K"-t csak akkor, 
            //                 HA üres ---> "#"

            Random vel = new Random();

            for (int i = 0; i < N; i++)
            {
                int sor = vel.Next(0, 8);
                int oszlop = vel.Next(0, 8);

                while (T[sor, oszlop] == 'K')
                {
                    sor = vel.Next(0, 8);
                    oszlop = vel.Next(0, 8);
                }
                T[sor, oszlop] = 'K';
            }
        }
        public void FajlbaIr(StreamWriter fajl)
        {
            //fajl.WriteLine("Ez egy szöveg.");
            for (int i = 0; i < 8; i++)
            {
                string sor = "";
                for (int j = 0; j < 8; j++)
                {
                    sor += T[i, j];
                }
                fajl.WriteLine(sor);
            }
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

        public bool UresOszlop(int oszlop)
        {
            int x = 0;

            while (x < 8 && T[x, oszlop] != 'K')
            {
                x++;
            }

            if (x < 8)
            {
                return false;

            }
            else
            {
                return true;
            }


        }

        public bool UresSor(int sor)
        {
            int x = 0;

            while (x < 8 && T[sor, x] != 'K')
            {
                x++;
            }

            if (x < 8)
            {
                return false;

            }
            else
            {
                return true;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Királynők feladat");
            Tabla t = new Tabla('#');


            Tabla[] tablak = new Tabla[64];
            


            Console.WriteLine("Üres tábla:");


            t.Megjelenit();
            t.Elhelyez(8);
            Console.WriteLine();
            t.Megjelenit();


            Console.Write("Oszlop:");
            int ures_oszlop = int.Parse(Console.ReadLine());

            if (t.UresOszlop(ures_oszlop))
            {
                Console.WriteLine("Ez az oszlop üres");
            }
            else
            {
                Console.WriteLine("Ez az oszlop nem üres");
            }

            Console.Write("Sor:");
            int ures_sor = int.Parse(Console.ReadLine());

            if (t.UresSor(ures_sor))
            {
                Console.WriteLine("Ez a sor üres");
            }
            else
            {
                Console.WriteLine("Ez a sor nem üres");
            }

            Console.WriteLine("Az üres oszlopok és sorok száma:");
            int uresSor = 0;
            int uresOszlop = 0;

            for (int i = 0; i < 8; i++)
            {
                if (t.UresOszlop(i))
                {
                    uresOszlop++;  
                }
                if (t.UresSor(i))
                {
                    uresSor++;  
                }
            }

            Console.WriteLine("Oszlopok: {0}", uresOszlop);
            Console.WriteLine("Sorok: {0}", uresSor);

            StreamWriter ki = new StreamWriter("adatok.txt");
            for (int i = 0; i < 64; i++)
            {
                tablak[i] = new Tabla('*');
            }

            for (int i= 0; i < 64; i++)
            {
                tablak[i].Elhelyez(i + 1);
                tablak[i].FajlbaIr(ki);
                ki.WriteLine();
            }

            t.FajlbaIr(ki);
            ki.Close();

            Console.ReadKey();

        }
    }
}
