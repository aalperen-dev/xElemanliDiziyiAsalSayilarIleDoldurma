using System;

namespace xElemanliDiziyiAsalSayilarIleDoldurma
{
    class Program
    {
        static void Main(string[] args)
        {
            //15 elemanlı bir diziyi en küçük asal sayıdan itibaren, asal sayılar ile dolduran kodu yazın.

            int[] dizi = new int[15]; //daha fazla asal sayi isteniyorsa burda dizi uzunlugu arttırılabilir.
            int sayac = 0;
            int sayaccikti = 0;
            int sayi = 2;
            while (true)
            {
                if (AsalMi(sayi) == true)
                {
                    dizi[sayac] = sayi;
                    sayac++;                    
                    if (sayac == dizi.Length)
                    {
                        break;
                    }
                }
                sayi++;
            }

            Console.Write("İlk 15 asal sayı : "); //dizi uzunlugu artırmıssak çıktı yazısını editlemek lazım.
            while (sayaccikti < dizi.Length)
            {
                Console.Write(dizi[sayaccikti] + " ");
                sayaccikti++;
            }
        }
        
        //Sayinin asal olup olmadığını kontrol eden bool metot
        //Sayi asalsa true dondurup diziye ekliyoruz
        public static bool AsalMi(int sayi)
        {
            bool durum = false;
            int kontrol = 0;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            return durum;
        }
    }
}
