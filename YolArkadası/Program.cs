using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Lütfen aşağıdaki lokasyonlardan birini seçiniz:");
            Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı: 4000 TL)");
            Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı: 3000 TL)");
            Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı: 5000 TL)");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine().Trim().ToLower();

            int fiyat = 0;

            switch (secim)
            {
                case "1":
                case "bodrum":
                    fiyat = 4000;
                    break;
                case "2":
                case "marmaris":
                    fiyat = 3000;
                    break;
                case "3":
                case "çeşme":
                    fiyat = 5000;
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir lokasyon seçiniz.");
                    continue;
            }

            int kisiSayisi;
            while (true)
            {
                Console.Write("Kaç kişi için plan yapmak istiyorsunuz? ");
                if (int.TryParse(Console.ReadLine(), out kisiSayisi))
                    break;
                else
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
            }

            Console.WriteLine("\nLütfen aşağıdaki ulaşım seçeneklerinden birini seçiniz:");
            Console.WriteLine("1 - Kara yolu (Kişi başı gidiş-dönüş ücret: 1500 TL)");
            Console.WriteLine("2 - Hava yolu (Kişi başı gidiş-dönüş ücret: 4000 TL)");
            Console.Write("Seçiminiz (1 veya 2): ");
            string ulasimSecimi = Console.ReadLine().Trim();

            int ulasimUcreti = 0;

            switch (ulasimSecimi)
            {
                case "1":
                    ulasimUcreti = 1500;
                    break;
                case "2":
                    ulasimUcreti = 4000;
                    break;
                default:
                    Console.WriteLine("Hatalı giriş! Lütfen sadece 1 veya 2 giriniz.");
                    continue;
            }

          
            int toplamFiyat = (fiyat + ulasimUcreti) * kisiSayisi;
            Console.WriteLine($"\nToplam tatil masrafınız: {toplamFiyat} TL");


            Console.Write("\nBaşka bir tatil planlamak ister misiniz? (Evet/Hayır): ");
            string devamEt = Console.ReadLine().Trim().ToLower();

            if (devamEt != "evet")
            {
                Console.WriteLine("İyi günler!");
                break;
            }
        }
    }
}
