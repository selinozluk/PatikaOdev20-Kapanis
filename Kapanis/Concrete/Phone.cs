using Kapanis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapanis.Concrete
{
    // Phone sınıfı, BaseDevice soyut sınıfından türetildi
    internal class Phone : BaseDevice
    {
        // Telefonun Türkiye lisanslı olup olmadığını belirten özellik
        public bool IsLicensedInTurkiye { get; set; }

        // Ortak bilgileri yazdıran DisplayInfo metodunu override edip
        // telefona özel bilgiyi de ek olarak yazar
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // BaseDevice sınıfındaki bilgileri yazdırır
            Console.WriteLine($"Türkiye Lisanslı mı?: {(IsLicensedInTurkiye ? "Evet" : "Hayır")}");
        }

        // Metodu override ederek telefonun adını yazdırır
        public override void ShowDeviceName()
        {
            Console.WriteLine($"Telefonunuzun Adını Giriniz: {Name}");
        }
    }
}
