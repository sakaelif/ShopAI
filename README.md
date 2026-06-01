# ShopAI

ShopAI, C# Windows Forms ve SQL Server kullanılarak geliştirilmiş masaüstü tabanlı bir alışveriş ve yönetim sistemidir.  
Projede müşteri tarafında ürün görüntüleme, sepete ekleme, sipariş oluşturma ve sipariş takibi; yönetici tarafında ise ürün ve sipariş yönetimi işlemleri bulunmaktadır. Ayrıca Gemini API ile çalışan bir yapay zekâ asistanı da sisteme entegre edilmiştir.

## Özellikler

### Müşteri
- Kayıt olma ve giriş yapma
- Kategorilere göre ürün görüntüleme
- Dinamik ürün kartları ile ürün listeleme
- Sepete ürün ekleme
- Sipariş oluşturma
- Önceki siparişleri görüntüleme
- Yapay zekâ asistanı ile ürün ve sipariş geçmişi hakkında soru sorma

### Yönetici
- Yönetici girişi
- Siparişleri görüntüleme
- Sipariş durumu güncelleme
- Yeni ürün ekleme
- Ürün güncelleme
- Ürün silme

## Kullanılan Teknolojiler

- C#
- Windows Forms
- SQL Server
- ADO.NET
- Gemini API
- Newtonsoft.Json
- HttpClient
- Visual Studio

## Veritabanı Tabloları

Projede kullanılan temel tablolar:

- Musteriler
- Yoneticiler
- Siparisler
- ElektronikUrunler
- GiyimUrunleri
- AyakkabiUrunleri
- EvVeYasamUrunleri

## Proje Yapısı

- `Modeller` → veri modelleri
- `Servisler` → veritabanı ve iş mantığı işlemleri
- `Formlar` → kullanıcı arayüzü ekranları

## Kurulum

1. Projeyi bilgisayarına indir.
2. SQL Server üzerinde veritabanını oluştur.
3. Gerekli tablo ve verileri SQL script dosyasından çalıştır.
4. Proje içindeki bağlantı cümlesini kendi bilgisayarına göre düzenle.
5. Yapay zekâ özelliğini kullanacaksan `App.config` içine Gemini API key bilgisini ekle.
6. Projeyi Visual Studio üzerinden çalıştır.

## Notlar

- Ürünler kategori bazlı ayrı tablolarda tutulmaktadır.
- Siparişler ürün satırı bazlı kaydedilmektedir.
- Yapay zekâ asistanı, veritabanındaki gerçek ürün bilgileri ve kullanıcının geçmiş sipariş bilgileri ile çalışmaktadır.

## Ekran Görüntüleri

Proje raporu içinde ekran görüntüleri ve temel modüller detaylı olarak açıklanmıştır.

## Geliştirici

@sakaelif