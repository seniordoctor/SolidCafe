# ☕ SolidCafe

Basit bir kahve sipariş uygulaması
Bu mini proje, .NET ile yazılmış ve tamamen **SOLID prensipleri** gözetilerek geliştirilmiştir.

## 🛠️ Kullanılan Teknolojiler

- .NET 8 (Console App)
- C#
- OOP, SOLID Prensipleri


## 🔍 SOLID Uygulamaları

| Prensip | Uygulama |
|--------|-----------|
| **S**ingle Responsibility | Her sınıf tek bir işi yapıyor (MenuService, OrderService vs.) |
| **O**pen/Closed | Logger yapısı genişlemeye açık, mevcut kod bozulmadan yeni logger eklenebiliyor |
| **L**iskov | Henüz miras örneği yok ama altyapı uygun |
| **I**nterface Segregation | ILogger interface'iyle servisler ihtiyaç kadar bilgiye erişiyor |
| **D**ependency Inversion | Servisler doğrudan sınıflara değil, interface’lere bağlı |
## 📦 Katmanlar

- `Models`: İçecek sınıfı (`Beverage`)
- `Services`: Menü, sipariş, ödeme, raporlama servisleri
- `Utils`: `ILogger` arayüzü ve `ConsoleLogger`, `FileLogger` implementasyonları
## 📷 Konsol Görüntüsü

```text
📋 Menü:
1. Türk Kahvesi - 25 TL
2. Latte - 30 TL
...
💳 Ödeme alındı!
📊 Gün Sonu Raporu
Toplam Sipariş: 3
Toplam Ciro: 85 TL
