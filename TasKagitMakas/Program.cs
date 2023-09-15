using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    internal class Program
    {
        static void Main(string[] args)
        {
        baslangic:
            Console.WriteLine("Taş Kağıt Makas Oyunu ");
            Console.WriteLine(" ");
            int modSec = 0;


            Console.WriteLine("Oyun Modu Seçiniz");
            Console.WriteLine(" ");
            Console.WriteLine("Bilgisayara Karşı Oynamak İçin 1 Tuşuna Basın");
            Console.WriteLine(" ");
            Console.WriteLine("İki Kişi Oynamak İçin 2 Tuşuna Basın");
            Console.WriteLine(" ");
            modSec = Convert.ToInt32(Console.ReadLine());

            if (modSec == 1 || modSec == 2)
            {



                if (modSec == 1)
                {


                    int kullaniciSayi = 0;
                    int bilgisayarSayi = 0;


                    while (kullaniciSayi < 10 && bilgisayarSayi < 10)
                    {
                        Random rastgele = new Random();

                        Console.WriteLine("Bilgisayar Güncel Skor : " + bilgisayarSayi + " Kullanıcı Güncel Skor : " + kullaniciSayi);
                        Console.WriteLine(" ");
                        Console.WriteLine("1-TAŞ / 2-KAĞIT / 3-MAKAS");
                        Console.WriteLine(" ");
                        Console.WriteLine("Lütfen Seçim Yapın !");
                        Console.WriteLine(" ");
                        int kullaniciSecim = 0;
                        int bilgisayarSecim = 0;

                        kullaniciSecim = Convert.ToInt32(Console.ReadLine());

                        bilgisayarSecim = rastgele.Next(1, 4);
                        if (kullaniciSecim == 1 || kullaniciSecim == 2 || kullaniciSecim == 3)
                        {
                            if (kullaniciSecim == 1)
                            {
                                if (bilgisayarSecim == 1)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Bilgisayar Seçimi : TAŞ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("SKOR BERABERE");
                                    Console.WriteLine(" ");
                                }

                                else if (bilgisayarSecim == 2)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Bilgisayar Seçimi : KAĞIT");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("BİLGİSAYAR KAZANDI");
                                    Console.WriteLine(" ");
                                    bilgisayarSayi = bilgisayarSayi + 1;
                                }
                                else if (bilgisayarSecim == 3)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Bilgisayar Seçimi : MAKAS");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("SİZ KAZANDINIZ");
                                    Console.WriteLine(" ");
                                    kullaniciSayi = kullaniciSayi + 1;
                                }
                            }
                            else if (kullaniciSecim == 2)
                            {
                                if (bilgisayarSecim == 1)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Bilgisayar Seçimi : TAŞ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("SİZ KAZANDINIZ");
                                    Console.WriteLine(" ");
                                    kullaniciSayi = kullaniciSayi + 1;
                                }

                                else if (bilgisayarSecim == 2)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Bilgisayar Seçimi : KAĞIT");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("SKOR BERABERE");
                                    Console.WriteLine(" ");

                                }
                                else if (bilgisayarSecim == 3)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Bilgisayar Seçimi : MAKAS");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("BİLGİSAYAR KAZANDI");
                                    Console.WriteLine(" ");
                                    bilgisayarSayi = bilgisayarSayi + 1;

                                }

                            }
                            else if (kullaniciSecim == 3)
                            {
                                if (bilgisayarSecim == 1)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Bilgisayar Seçimi : TAŞ");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("BİLGİSAYAR KAZANDI");
                                    Console.WriteLine(" ");
                                    bilgisayarSayi = bilgisayarSayi + 1;
                                }

                                else if (bilgisayarSecim == 2)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Bilgisayar Seçimi : KAĞIT");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("SİZ KAZANDINIZ");
                                    Console.WriteLine(" ");
                                    kullaniciSayi = kullaniciSayi + 1;
                                }
                                else if (bilgisayarSecim == 3)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("DURUM BERABERE");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("SİZ KAZANDINIZ");
                                    Console.WriteLine(" ");

                                }



                            }


                        }
                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama");
                        }
                    }
                    Console.WriteLine("BİLGİSAYAR SKOR : " + bilgisayarSayi + " KULLANICI SKOR : " + kullaniciSayi);
                    Console.WriteLine(" ");
                    if (kullaniciSayi > 9)
                    {
                        Console.WriteLine("KAZANAN KULLANCI !");
                    }
                    else
                    {
                        Console.WriteLine("KAZANAN BİLGİSAYAR !");
                    }
                }
                else
                {

                    int kullaniciBirSayi = 0;
                    int kullaniciIkiSayi = 0;


                    while (kullaniciBirSayi < 3 && kullaniciIkiSayi < 3)
                    {
                        
                        int kullaniciBirSecim = 0;
                        string kullaniciIkiSecim = "";

                        Console.WriteLine("1.Oyuncu Güncel Skor : " + kullaniciBirSayi + " 2.Oyuncu Güncel Skor : " + kullaniciIkiSayi);
                        Console.WriteLine(" ");
                        Console.WriteLine("1-TAŞ / 2-KAĞIT / 3-MAKAS");
                        Console.WriteLine(" ");
                        kullaniciBirSecim = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Q-TAŞ / W-KAĞIT / E-MAKAS");
                        Console.WriteLine(" ");
                        kullaniciIkiSecim = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Lütfen Seçim Yapın !");
                        Console.WriteLine(" ");



                        if (kullaniciBirSecim == 1 || kullaniciBirSecim == 2 || kullaniciBirSecim == 3)
                        {
                            if (kullaniciBirSecim == 1)
                            {
                                if (kullaniciIkiSecim == "Q")
                                {
                                    
                                    Console.WriteLine(" ");
                                    Console.WriteLine("SKOR BERABERE");
                                    Console.WriteLine(" ");
                                }

                                else if (kullaniciIkiSecim == "W")
                                {
                                    
                                    Console.WriteLine(" ");
                                    Console.WriteLine("BİLGİSAYAR KAZANDI");
                                    Console.WriteLine(" ");
                                    kullaniciIkiSayi = kullaniciIkiSayi + 1;
                                }
                                else if (kullaniciIkiSecim == "E")
                                {
                                    
                                    Console.WriteLine(" ");
                                    Console.WriteLine("SİZ KAZANDINIZ");
                                    Console.WriteLine(" ");
                                    kullaniciBirSayi = kullaniciBirSayi + 1;
                                }
                            }
                            else if (kullaniciBirSecim == 2)
                            {
                                if (kullaniciIkiSecim == "Q")
                                {
                                    
                                    Console.WriteLine(" ");
                                    Console.WriteLine("SİZ KAZANDINIZ");
                                    Console.WriteLine(" ");
                                    kullaniciBirSayi = kullaniciBirSayi + 1;
                                }

                                else if (kullaniciIkiSecim == "W")
                                {
                                    
                                    Console.WriteLine(" ");
                                    Console.WriteLine("SKOR BERABERE");
                                    Console.WriteLine(" ");

                                }
                                else if (kullaniciIkiSecim == "E")
                                {
                                   
                                    Console.WriteLine(" ");
                                    Console.WriteLine("BİLGİSAYAR KAZANDI");
                                    Console.WriteLine(" ");
                                    kullaniciIkiSayi = kullaniciIkiSayi + 1;

                                }

                            }
                            else if (kullaniciBirSecim == 3)
                            {
                                if (kullaniciIkiSecim == "Q")
                                {
                                    
                                    Console.WriteLine(" ");
                                    Console.WriteLine("BİLGİSAYAR KAZANDI");
                                    Console.WriteLine(" ");
                                    kullaniciIkiSayi = kullaniciIkiSayi + 1;
                                }

                                else if (kullaniciIkiSecim == "Q")
                                {
                                    
                                    Console.WriteLine(" ");
                                    Console.WriteLine("SİZ KAZANDINIZ");
                                    Console.WriteLine(" ");
                                    kullaniciBirSayi = kullaniciBirSayi + 1;
                                }
                                else if (kullaniciIkiSecim == "Q")
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("DURUM BERABERE");
                                    Console.WriteLine(" ");
                                    Console.WriteLine("SİZ KAZANDINIZ");
                                    Console.WriteLine(" ");

                                }



                            }


                        }
                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama");
                        }
                    }
                    Console.WriteLine("1.Oyuncu Güncel Skor : " + kullaniciBirSayi + " 2.Oyuncu Güncel Skor : " + kullaniciIkiSayi);
                    Console.WriteLine(" ");
                    if (kullaniciBirSayi > 2)
                    {
                        

                        Console.WriteLine("KAZANAN 1.OYUNCU !");
                        Console.WriteLine("Devam Etmek İçin 0 tuşuna basın");

                        int geriDönüt = 0;
                        geriDönüt = Convert.ToInt32(Console.ReadLine());

                        if (geriDönüt == 0)
                        {
                            goto baslangic;
                        }
                    }
                    else
                    {
                        Console.WriteLine("KAZANAN 2.OYUNCU !");
                    }
                }
            }
            else
            {
                Console.WriteLine("Hatalı Tuşlama !");
            }
            Console.ReadLine();

        }
    }
}


