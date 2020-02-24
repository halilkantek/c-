using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _2112
{
     public class ögrenci
    { 
        public void menü()

        {
        Console.WriteLine(" ****menü****");
        Console.WriteLine("1-ögrenci ekleme ");
            Console.WriteLine( "2-ders ekleme ");
        Console.WriteLine("3- tüm verileri listele");
        Console.WriteLine("4-uygulamadan cikis");
        }
       
        public string ogrno;
        public string ad;
        public string soyad;
        public int derssay;
        public ders[] ogrders = new ders[7];
     
     
    }
    
    
}
