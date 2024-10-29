using PropertyAciklama2;

//Calisan ticari = new Calisan();
//ticari._ad = "Hamit";
//ticari._yas = -33; // get set olmadan yazamadı. 
 
// get set yazdıktan sonrası 
Calisan simitci = new Calisan();
simitci.Ad = "Berkan"; // set çalışır (= atama yaptık)
simitci.Yas = 24; 
simitci.KunyeYazdir();

Console.WriteLine(simitci.Ad); // get çalışır. aldık atama yok.  
Calisan menajer = new Calisan();
menajer.Ad = "Yaşar";
menajer.Yas = -23;  // try catch blogu ile geliştirilebilir.

menajer.KunyeYazdir();  


 
Console.ReadKey();