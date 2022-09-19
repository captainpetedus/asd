﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            feladat f = new feladat();
        }
    }
    class feladat
    {
        List<adatok> eredmenyek = new List<adatok>();
        public feladat()
        {
            f1();
            f2();
            f3();
            f4();
            f5();
        }
        void f1()
        {
            string[] sorok = File.ReadAllLines("Eredmenyek.txt");
            for (int i = 0; i < sorok.Length; i++)
            {
                eredmenyek.Add(new adatok(sorok[i]));
            }

        }
        void f2()
        {
            Console.WriteLine("2.feladat: A versenyt {0} versenyző fejezte be.", eredmenyek.Count);
        }
        void f3()
        {
            int db = 0;
            foreach (var item in eredmenyek)
            {
                if (item.kategoria == "elit junior")
                {
                    db++;
                }

            }
            Console.WriteLine("3.feladat: Versenyzők száma az \"elit junior\" kategóriában: {0} fő", db);
        }
        void f4()
        {
            double ossz = 0;
            foreach (var item in eredmenyek)
            {
                ossz += 2014 - item.szuldat;
            }
            Console.WriteLine("4.feladat: Átlagéletkor: {0:0.0} év.", ossz / eredmenyek.Count);
        }
        void f5()
        {
            Console.Write("5.feladat: Kérek egy kategóriát: ");
            string bekert = Console.ReadLine();
            Console.Write("Rajtszám(ok): ");
            string rajtszamok = "";
            for (int i = 0; i < eredmenyek.Count; i++)
            {
                if (eredmenyek[i].kategoria == bekert)
                {
                    rajtszamok += eredmenyek[i].rajtSzam + " ";
                }
            }
            if (rajtszamok=="")
            {
                Console.WriteLine("nincs ilyen kategoria");
            }
            else
            {
                Console.WriteLine(rajtszamok);
            }
        }
        void f6()
        {
            int index = 0;
            for (int i = 0; i < eredmenyek.Count; i++)
            {
                if (!eredmenyek[i].ferfi)
                {
                    if (eredmenyek[index].osszido() > eredmenyek[i].osszido())
                    {
                        index = i;
                    }
                }
            }
            Console.WriteLine("6. feladat:  A legjobb idot {0} erte el",index);
        }
        void f7()
        {
            s
        }

    }


    class adatok
    {
        public string nev;
        public int szuldat;
        public int rajtSzam;
        public bool ferfi;
        public string kategoria;
        public string uszas, depo1;
        public string kerekpar, depo2;
        public string futas;
        public adatok(string sor)
        {
            string[] vag = sor.Split(';');
            nev = vag[0];
            szuldat = Convert.ToInt32(vag[1]);
            rajtSzam = Convert.ToInt32(vag[2]);
            ferfi = vag[3] == "f";
            kategoria = vag[4];
            uszas = vag[5];
            depo1 = vag[6];
            kerekpar = vag[7];
            depo2 = vag[8];
            futas = vag[9];


        }
        int mp(string ido)
        {
            string[] vag = ido.Split(':');
            return Convert.ToInt32(vag[0]) * 60 * 60 + Convert.ToInt32(vag[1]) * 60 + Convert.ToInt32(vag[2]);
        }
        public int osszido()
        {
            return mp(uszas) + mp(depo1)+mp(kerekpar) + mp(depo2)+ mp(futas);
        }
    }
}
