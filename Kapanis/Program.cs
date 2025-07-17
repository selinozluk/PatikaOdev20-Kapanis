using Kapanis.Concrete;

namespace Kapanis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProduction = true;

            while (continueProduction)
            {
                // Kullanıcıdan ürün türü seçmesi istenir
                Console.WriteLine("Ürün üretmek için seçim yapınız:");
                Console.WriteLine("1 - Telefon");
                Console.WriteLine("2 - Bilgisayar");
                string choice = Console.ReadLine();


                // Değer 1 girilirse telefon üretilir
                if (choice == "1")
                {
                    Phone phone = new Phone();

                    Console.Write("Seri Numarası: ");
                    phone.SerialNumber = Console.ReadLine();

                    Console.Write("Ad: ");
                    phone.Name = Console.ReadLine();

                    Console.Write("Açıklama: ");
                    phone.Description = Console.ReadLine();

                    Console.Write("İşletim Sistemi: ");
                    phone.OperatingSystem = Console.ReadLine();

                    Console.Write("Türkiye Lisanslı mı? (y/n): ");
                    phone.IsLicensedInTurkiye = Console.ReadLine().ToLower() == "y";

                    // Telefon üretimi tamamlandığında bilgi yazdırılır
                    Console.WriteLine("Telefon başarıyla üretildi.");
                    phone.DisplayInfo();
                    phone.ShowDeviceName();
                }
                // Değer 2 girilirse bilgisayar üretilir
                else if (choice == "2")
                {
                    Computer computer = new Computer();

                    Console.Write("Seri Numarası: ");
                    computer.SerialNumber = Console.ReadLine();

                    Console.Write("Ad: ");
                    computer.Name = Console.ReadLine();

                    Console.Write("Açıklama: ");
                    computer.Description = Console.ReadLine();

                    Console.Write("İşletim Sistemi: ");
                    computer.OperatingSystem = Console.ReadLine();

                    Console.Write("USB Giriş Sayısı (2 ya da 4 giriniz): ");
                    computer.UsbPortCount = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Bluetooth Var mı? (y/n): ");
                    computer.HasBluetooth = Console.ReadLine().ToLower() == "y";

                    // Bilgisayar üretimi tamamlandığında bilgi yazdırılır
                    Console.WriteLine("Bilgisayar başarıyla üretildi.");
                    computer.DisplayInfo();
                    computer.ShowDeviceName();
                }
                else
                {
                    // Geçersiz seçim yapılırsa uyarı verir
                    Console.WriteLine("Hatalı seçim yaptınız.");
                }

                // Yeni bir ürün üretmek isteyip istemediği soruluyor
                Console.Write("Yeni bir ürün üretmek ister misiniz? (y/n): ");
                string answer = Console.ReadLine().ToLower();
                continueProduction = answer == "y";

                Console.WriteLine("------------------------------------------");
            }

            Console.WriteLine("Bizi tercih ettiğiniz için teşekkürler!");
        }
    }
}
