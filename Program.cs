using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ogrenci
    {

        public string ogrenciAdi = "";
        int vize;
        int final;
        public bool gectiMi
        {
            get
            {
                return ortalama > 49 ? true : false;
            }
        }
        public double ortalama
        {
            get
            {
                //Random rnd = new Random();
                //return rnd.NextDouble()*100;
                return vize * 0.4 + final * 0.6;
            }
        }

        public int sVize
        {
            set
            {
                if (value < 101 && value > 1)
                {
                    vize = value;
                }

            }
            get
            {
                return vize;
            }
        }
        public int sFinal
        {
            set
            {
                if (value < 101 && value > 1)
                {
                    final = value;
                }

            }
            get
            {
                return final;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<ogrenci> ogrList = new List<ogrenci>();

            Random rnd = new Random();

            for (int i = 0; i < 1000; i++)
            {
                ogrenci x = new ogrenci();
                x.sVize = rnd.Next(0, 100);
                x.sFinal = rnd.Next(0, 100);

                ogrList.Add(x);
            }

            List<ogrenci> yeniListe = ogrList.Where(s => s.sVize > 50).ToList();



            Console.ReadKey();

        }
    }

}

