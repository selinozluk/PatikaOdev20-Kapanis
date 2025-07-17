using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Kapanis.Abstract
{
    internal abstract class BaseDevice
    {
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }

        // Üretim tarihi field'ı
        private DateTime _productionDate;

        // Property sadece dışarıdan okunabilir
        public DateTime ProductionDate
        {
            get 
            { 
                return _productionDate;
            }
        }

        // Constructor (üretim tarihi nesne oluşturulurken atanır)
        public BaseDevice()
        {
            _productionDate = DateTime.Now;
        }

        // Ortak bilgileri yazdıran metot
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Üretim Tarihi: {ProductionDate}");
            Console.WriteLine($"Seri No: {SerialNumber}");
            Console.WriteLine($"Ad: {Name}");
            Console.WriteLine($"Açıklama: {Description}");
            Console.WriteLine($"İşletim Sistemi: {OperatingSystem}");
        }

        public abstract void ShowDeviceName();
    }
}

