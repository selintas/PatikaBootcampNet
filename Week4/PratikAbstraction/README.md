## Pratik - Abstraction
Düşünün ki bir şirketin çalışanlarını temsil eden bir program yazıyorsunuz.

Her çalışan için ad, soyad, departman gibi ortak özellikler bulunmaktadır

Ancak her çalışanın görevi (pozisyonu) farklı olabilir (Örneğin, Yazılım Geliştirici, Proje Yöneticisi, Satış Temsilcisi).

Gorev metodunu çağırdığımızda her çalışan kendi yaptığı işi konsol ekranında söyleyecek.

Örneğin

Hasan Çıldırmış şirketin Proje yönetcisi, kendisi üzerinden Gorev() abstract metodu çağırıldığında konsol ekranında

" Proje yöneticisi olarak çalışıyorum. " yazdırılmasını istiyoruz. 

___
Açıklama:

Calisan (Çalışan) Abstract Sınıfı:
Calisan sınıfı, her çalışan için ortak özellikleri (Ad, Soyad, Departman) içerir. Gorev() metodu soyut olarak tanımlanmıştır, yani bu metodu Calisan sınıfından türeyen her alt sınıf kendine özgü şekilde uygulamalıdır.

Alt Sınıflar (YazilimGelistirici, ProjeYoneticisi, SatisTemsilcisi):
YazilimGelistirici, ProjeYoneticisi ve SatisTemsilcisi sınıfları Calisan sınıfını devralır ve Gorev() metodunu kendi ihtiyaçlarına göre uygular. Bu sayede her pozisyon, kendine uygun bir görev mesajını konsola yazdırır.

Program Sınıfı ve Görev Çağrısı:
Main metodunda, her çalışandan birer nesne oluşturulur. Her nesneye Gorev() metodu çağrıldığında, her sınıfın kendine özgü Gorev() uygulaması çalışır ve farklı görev mesajları görüntülenir.