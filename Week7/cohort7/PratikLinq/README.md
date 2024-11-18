## pratik Linq
Liste Oluşturma:

Random sınıfı kullanılarak -50 ile 50 arasında rastgele sayılar üretilir.

LINQ'in Enumerable.Range ve Select metotları ile rastgele 10 sayıdan oluşan bir liste oluşturulur.
Sorgular:

Çift Sayılar: Where(n => n % 2 == 0) ifadesiyle listede çift olan sayılar seçilir.

Tek Sayılar: Where(n => n % 2 != 0) ifadesiyle listede tek olan sayılar seçilir.

Negatif Sayılar: Where(n => n < 0) ifadesiyle negatif sayılar filtrelenir.

Pozitif Sayılar: Where(n => n > 0) ifadesiyle pozitif sayılar filtrelenir.

15 ile 22 Arasındaki Sayılar: Where(n => n > 15 && n < 22) ifadesiyle aralık kontrolü yapılır.

Sayıların Karesi: Select(n => n * n) ifadesiyle her bir sayının karesi hesaplanır.

Liste Yazdırma:

Her sonuç kümesi, ForEach metodu ile konsola yazdırılır.