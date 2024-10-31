Bu örnekte:

GeometricShape adında bir ana sınıf (base class) tanımlanmıştır. Bu sınıfın Draw() adında sanal (virtual) bir metodu bulunmaktadır. Sanal metotlar, türetilmiş sınıflar tarafından override edilebilirler.

Circle ve Square sınıfları, GeometricShape sınıfından kalıtım alır ve Draw() metotunu override eder. Her iki sınıf da kendi şeklini çizmek için farklı Draw() implementasyonlarına sahiptir.

Main metodu içinde, GeometricShape türünde değişkenler oluşturulmuş ve bu değişkenler hem Circle hem de Square nesnelerini alabilmektedir.

sekil1 ve sekil2 değişkenleri üzerinden çağrılan Draw() metotları, her bir nesnenin kendi override edilmiş versiyonunu çağırır. Bu sayede polymorphism gerçekleşmiş olur.

Bu örnekte, virtual keywordü ile işaretlenmiş Draw() metodu, türetilmiş sınıflar tarafından override edilerek farklı davranışlar gösterebilmektedir. Böylece, aynı şekilde adlandırılmış metodlar farklı türetilmiş sınıflar tarafından farklı şekilde uygulanabilir, yani polymorphism sağlanmış olur.