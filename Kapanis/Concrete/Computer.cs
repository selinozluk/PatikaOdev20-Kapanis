using Kapanis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapanis.Concrete
{
    // Computer sınıfı, BaseDevice sınıfından kalıtım aldı
    internal class Computer : BaseDevice
    {
        // Bluetooth özelliği var mı
        public bool HasBluetooth { get; set; }

        // USB giriş sayısı için kapsülleme kullanılan özel alan
        private int _usbPortCount;

        // USB giriş sayısı özelliği (sadece 2 ya da 4 değerlerini kabul eder)
        public int UsbPortCount {

            get
            {
                // Değer okunurken direkt _usbPortCount döndürülür
                return _usbPortCount;
            }

            set {

                // Eğer giriş 2 veya 4 ise kabul edilir
                if (value == 2 || value == 4)
                {
                    _usbPortCount = value;
                }

                else
                {

                    // Hatalı giriş yapıldığında kullanıcı uyarılır ve -1 değeri atanır
                    Console.WriteLine("USB giriş sayısı 2 veya 4 dışında bir değer alamaz. Yanlış bir giriş yapıldığı için değer -1 olarak belirlendi.");
                    _usbPortCount = -1;

                }

            }
        }

        // Ortak bilgileri yazdırır DisplayInfo metodunu ovveride edip diğer bilgileri de yazdırır 
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"USB Giriş Sayısı: {UsbPortCount}");
            Console.WriteLine($"Bluetooth var mı?: {(HasBluetooth ? "Evet" : "Hayır")}");

        }

        // Metodu override ederek bilgisayarın adını yazdırır
        public override void ShowDeviceName()
        {
            Console.WriteLine($"Bilgisayarınızın Adını Giriniz: {Name}");
        }
    }
}
