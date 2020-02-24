using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2112
{
    class Program
    {
        static void Main(string[] args)
        {
            //ögrenci h1 = new ögrenci();
            ögrenci[] ogrdizi = new ögrenci[10];
             
           
           
            string menü;
            int ogrsay = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1- ogrenci ekleme:");
            Console.WriteLine("2- ogr noya göre ders ekleme:");
            Console.WriteLine("3- tüm verileri listele");
            Console.WriteLine("4-uygulmadan cik: ");
        hk:
            ogrdizi[ogrsay] = new ögrenci();
            Console.Write("isleminiz:");
            menü = Console.ReadLine();
 //           h1.ad = "halil";
 //           h1.soyad = "kantek";
 //           h1.ogrno = "364";
 //           h1.alinandersler[0] = new ders();
 //           h1.alinandersler[0].dersadi = "proglama";
 //           h1.alinandersler[0].derskod = "1515";
 //           h1.alinandersler[0].derssaati = "3";
 //           Console.WriteLine(h1.ad + "   " + h1.soyad + "    " + h1.ogrno + "    ");
 //           Console.WriteLine(h1.alinandersler[0].dersadi + " " + h1.alinandersler[0].derskod + " " +
 //h1.alinandersler[0].derssaati);

 //           Console.ReadLine();
 //       }



       switch (menü)

       {
           case "1":

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("ad giriniz:");
                    ogrdizi[ogrsay].ad=(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("soyad gir:");
                    ogrdizi[ogrsay].soyad = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("ogr no gir");
                    ogrdizi[ogrsay].ogrno = Console.ReadLine();
                        ogrsay++;
          
                  break;
      case "2":

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ders eklemek istedğiniz ögrenci no");
                    string no = Console.ReadLine();
                    int say = 0;
                    foreach (var item in ogrdizi)
                    {
                        if (item.ogrno == no)
                            break;
                            say++;
                    }
                    int ogrders_sayasi = ogrdizi[say].derssay;
                    ogrdizi[say].ogrders[ogrdizi[say].derssay] = new ders();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ders adi gir:");
                    ogrdizi[say].ogrders[ogrdizi[say].derssay].dersadi = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ders kodu gir:");
                    ogrdizi[say].ogrders[ogrdizi[say].derssay].derskod = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ders saati:");
                    ogrdizi[say].ogrders[ogrdizi[say].derssay].derssaati = Console.ReadLine();
                    ogrdizi[say].derssay++;

                    break;
                case "3":
                    for (int i = 0; i < ogrsay; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("ogrenci adı= " + ogrdizi[i].ad + "\nogrenci soyadı= " + ogrdizi[i].soyad+ "\nogrenci no= " + ogrdizi[i].ogrno );
                        Console.WriteLine("-------------------------------------------------------------");

                        int a = ogrdizi[i].derssay;
                        for (int g = 0; g < a; g++)
                        {
                            Console.WriteLine("\ndersin adı= " + ogrdizi[i].ogrders[g].dersadi + "\ndersin kodu= " + ogrdizi[i].ogrders[g].derskod + "\nderssaati=" + ogrdizi[i].ogrders[g].derssaati  );
                            Console.WriteLine("********************************************");
                        }
                    }

                    
                    

                            
            
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                    
          }
          goto hk;
          Console.ReadLine();

     }
    }
}
