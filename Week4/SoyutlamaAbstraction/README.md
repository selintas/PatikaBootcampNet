## Soyutlama (Abstraction)

abstract class kullanarak abstraction (soyutlama) kavramını açıklayalım. Bir hayvan (animal) sınıfı üzerinden ilerleyelim: 
 
 Animal adında bir abstract sınıf tanımlanmıştır. Bu sınıf, Name adında bir özellik, MakeSound() adında soyut (abstract) bir metot ve PrintInfo() adında somut (concrete) bir metot içerir.

Dog ve Cat sınıfları, Animal sınıfından kalıtım alarak MakeSound() metotunu override eder. Her bir hayvan sınıfı kendi sesini çıkarmak için farklı mantıklar kullanır.

Main metodu içinde, Animal türünde değişkenler oluşturulmuş ve bu değişkenler hem Dog hem de Cat nesnelerini alabilmektedir. Bu, Animal sınıfının soyutlama kavramını nasıl sağladığını gösterir.

Animal sınıfı soyut (abstract) bir MakeSound() metodu tanımlar ve bu metotu türetilmiş sınıfların kendi özgün şekilde uygulamasını sağlar. Bu sayede her hayvan sınıfı kendi özelliklerini ve davranışlarını gösterebilir, ancak temel Animal sınıfının sağladığı ortak özelliklere (örneğin Name özelliği ve PrintInfo() metodu) erişebilirler.