﻿using System;

namespace DECLARATIONS__EXERCISES_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int poczatek = (int)DniTygodnia.Piatek;
            Console.WriteLine(DniTygodnia.Poniedzialek);
        }
        enum DniTygodnia
        {
            Poniedzialek = 1,
            Wtorek,
            Sroda,
            Czwartek,
            Piatek,
            Sobota,
            Niedziela
        }
    }
}
