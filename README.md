# PatikaOdev20-Kapanis
Bu C# konsol uygulaması, kullanıcıdan aldığı bilgilerle **Telefon** veya **Bilgisayar** üretimi yapar. Her cihaz türü için kullanıcıdan gerekli bilgiler alınır, geçerli kontroller yapılır ve cihazın bilgileri ekrana yazdırılır.

## Özellikler

- **Soyutlama (Abstraction)** prensibine uygun olarak `BaseDevice` soyut sınıfı kullanılmıştır.
- **Kalıtım (Inheritance)** yoluyla `Phone` ve `Computer` sınıfları `BaseDevice` sınıfından türetilmiştir.
- **Kapsülleme (Encapsulation)** ile üretim tarihi ve USB giriş sayısı gibi özellikler denetlenmiştir.
- **Çok Biçimlilik (Polymorphism)** ile cihazların adlarını gösteren `ShowDeviceName()` metodu override edilmiştir.
- USB giriş sayısı yalnızca **2 veya 4** olabilir, aksi halde sistem kullanıcıyı uyarır ve değer `-1` olarak atanır.
- Bilgisayar ve telefon üretildikten sonra, kullanıcıya devam etmek isteyip istemediği sorulur.

## Kullanım

1. Program çalıştırılır.
2. Telefon veya Bilgisayar seçimi yapılır.
3. Cihaza ait bilgiler girilir.
4. Ürün başarıyla üretildiğinde bilgileri görüntülenir.
5. Kullanıcı isterse yeni bir ürün daha üretebilir.
