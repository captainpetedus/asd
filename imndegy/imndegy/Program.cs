using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace imndegy
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
        }
    }
    class feladat
    {
        List<adatok> adatoklista= new List<adatok>();
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

            }
        }
        void f2()
        {
            Console.WriteLine("2. feladat: A versenyt {0} versenyző fejezte be",adatoklista.Count);
        }
        void f3()
        {
            int db=0;
            foreach (var item in adatoklista)
            {
                if(item.kategoria== "elit junior")
                {
                    db++;
            }
                }
            Console.WriteLine("3. feladat: Versenyzők száma az elit junior kategoriában: {0}fő",db);
        }
        void f4()
        {
            double ossz = 0;
            foreach (var item in adatoklista)
            {
                ossz += 2024 - item.szuldatum;
            }
            Console.WriteLine("4. feladat: Átlagéletkor: {0:0:0} év", ossz/adatoklista.Count);
        }
        void f5()
        {
            Console.Write("5. feladat: Kérek egy kategoriát: ");
            string bekert = Console.ReadLine();
            Console.Write("Rajtszám(ok): ");
            for (int i = 0; i < adatoklista.Count; i++)
            {
                if (adatoklista[i].kategoria==bekert)
                {
                    rajtszamok += adatoklista[i].rajtszam
                }
            }
        }
    }
    class adatok
    {
        public bool ferfi = true;
        public string neve, kategoria,idoeredmeny,uszas,depo1,kerekpar,depo2,futas;
        public int szuldatum, rajtszam;
        public adatok(string sor)
        {
            string[] vag = sor.Split(' ');
            neve = vag[0];
            szuldatum = Convert.ToInt32(vag[1]);
            rajtszam = Convert.ToInt32(vag[2]);
            ferfi = vag[3] == "f";
            kategoria = vag[4];
            uszas = vag[5];
            depo1 = vag[6];
            kerekpar = vag[7];
            depo2 = vag[8];
            futas = vag[9];
        }
    }
}
