﻿using System;
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

        }
        public void FajlbaIr()
        {

        }
        public void Megjelenit()
        {


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

            Console.ReadKey();

        }
    }
}
