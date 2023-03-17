using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double Hesapla( double ilkSayi,double ikinciSayi,string islem)
        {
            double sonuc = 0;

            switch (islem)
            {
                case "+":
                    sonuc = ilkSayi + ikinciSayi;
                    break;
                case "-":
                    sonuc = ilkSayi - ikinciSayi;
                    break;
                case "*":
                    sonuc = ilkSayi * ikinciSayi;
                    break;
                case "/":
                    sonuc = ilkSayi / ikinciSayi;
                    break;
            }
            return sonuc;
        }

        public class menuIslemleri {
            double sayi1, sayi2;
            string secilenİslem;
            bool menuDrumu = true;

            public void menuYazilariniYaz()
            {
                Console.Clear();
                Console.WriteLine("Zilanın Hesap Makinesına Hos Geldiniz");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Lütfen işlem yapmak istediğiniz sayıları giriniz");
                Console.WriteLine("1. Sayı");
                sayi1=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("2. Sayı");
                sayi2 =Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Seçilen Sayılar : "+ sayi1+ " ve " +sayi2);
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin ");
                Console.WriteLine("1- Toplama");
                Console.WriteLine("2- Çıkarma");
                Console.WriteLine("3- Çarpma");
                Console.WriteLine("4- Bölme");
                Console.WriteLine("5- Çıkış");
            }
            public void islemleriGerceklestir() { 
            
               while(this.menuDrumu)
                {
                    menuYazilariniYaz();

                    this.secilenİslem = Console.ReadLine();

                    switch (this.secilenİslem)
                    {
                        case "1":
                            Console.Clear ();
                            Console.WriteLine("Sonuc: " + Hesapla(sayi1, sayi2, "+")); 
                            break;
                        case "2":
                            Console.Clear ();
                            Console.WriteLine("Sonuc: " + Hesapla(sayi1, sayi2, "-"));
                            break;
                        case "3":
                            Console.Clear ();
                            Console.WriteLine("Sonuc: " + Hesapla(sayi1, sayi2, "*"));
                            break;
                        case "4":
                            Console.Clear ();
                            Console.WriteLine("Sonuc: " + Hesapla(sayi1, sayi2, "/"));
                            break;
                        case "5":
                            Environment.Exit (0);
                            break;
                        default : Console.WriteLine("Yanlış işlem seçtiniz");
                            break;
                    }
                    Console.WriteLine("Tekrar işlem Yapmak İçin Bir Tuşa Basınız :)");
                    Console.ReadKey();

                }
            }
        }

        static void Main(string[] args)
        {
            menuIslemleri MenuIslemleri = new menuIslemleri();
            MenuIslemleri.islemleriGerceklestir();

        }

    }
}