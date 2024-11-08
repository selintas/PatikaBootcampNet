Bu örnekte:

Dictionary<string, int> türünde bir ages dictionary tanımlanmıştır. Bu dictionary, her biri string (isim) anahtarı ve int (yaş) değerini içeren çiftlerden oluşur.

ages dictionary'sine ["Alice"] = 30, ["Bob"] = 25 ve ["Charlie"] = 35 gibi anahtar-değer çiftleri eklenmiştir.

ages["Alice"] ifadesi ile "Alice" anahtarının değeri alınmış ve ekrana yazdırılmıştır.

foreach döngüsü kullanılarak dictionary üzerindeki her bir anahtar-değer çifti (person.Key ve person.Value) ekrana yazdırılmıştır.

ages.ContainsKey("Alice") yöntemi ile "Alice" anahtarının dictionary içinde olup olmadığı kontrol edilmiştir.

ages.Remove("Bob") ifadesi ile "Bob" anahtarı olan çift dictionary'den silinmiştir.

Son olarak güncellenmiş dictionary tekrar ekrana yazdırılmıştır.

Bu örnek, Dictionary<TKey, TValue> koleksiyonunun temel işlevlerini göstermektedir: ekleme, değer alıp yazdırma, döngü ile gezinme, anahtar kontrolü ve silme işlemleri. Bu koleksiyon, veri yönetimi gerektiren birçok senaryoda kullanışlıdır ve performanslı anahtar-değer eşlemeleri sağlar.

