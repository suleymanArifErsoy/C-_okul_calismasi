using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapıslaProgramlamaKalıtımUygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            İnsan insan1 = new İnsan() { Ad = "berkay", Soyad = "yılmaz", Yas = 41 };
            İnsan ogrenci1 = new Ogrenci() { Ad = "Mehmet", Soyad = "ersoy",Yas=19,ogrNo=781 };
            İnsan prof1 = new Profesor() { Ad = "Halil", Soyad = "yazıcı", Yas = 61, Orcid = 12 };
            İnsan docent1 = new Docent() { Ad = "Merve",Soyad="polat",Yas=41,Orcid=42 };
            İnsan arastırmaGrvl1 = new ArastırmaGorevlisis() { Ad="tugba",Soyad="yozgat",Yas=34,Orcid=16};
            İnsan yardımcıdocent1 = new YardımcıDocent() { Orcid=41};
            yardımcıdocent1.Ad = "yusuf";
            yardımcıdocent1.Soyad = "sahin";
            yardımcıdocent1.Yas = 38;
            İnsan ogrenci2 = new Ogrenci() {ogrNo=765};
            ogrenci2.Ad = "Zeynep";
            ogrenci2.Soyad = "ersoy";
            ogrenci2.Yas = 18;
            İnsan ogrenci3 = new Ogrenci() { ogrNo = 785 };
            ogrenci3.Ad = "tarık";
            ogrenci3.Soyad = "asfw";
            ogrenci3.Yas = 18;
            İnsan ogrenci4 = new Ogrenci() { ogrNo = 654 };
            ogrenci4.Ad = "Kazım";
            ogrenci4.Soyad = "esssd";
            ogrenci4.Yas = 18;

            Console.WriteLine(ogrenci1.isimYazdır());
            Console.WriteLine(yardımcıdocent1.isimYazdır());

            Console.WriteLine(docent1.isimYazdır());;
            Console.WriteLine(arastırmaGrvl1.isimYazdır());
            Console.WriteLine(insan1.isimYazdır()) ;
            Console.ReadKey();
            
        }
    }
}
