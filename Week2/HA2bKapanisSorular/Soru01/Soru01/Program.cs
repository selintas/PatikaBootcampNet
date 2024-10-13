
//1 - Aşağıdaki çıktıyı yazan bir program.

//Merhaba
//Nasılsın ?
//İyiyim
//Sen nasılsın ?

/*
#region yontem 1 
Console.WriteLine("Merhaba");
Console.WriteLine("Nasılsın ?");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen nasılsın ?");
#endregion

#region yontem 2
Console.WriteLine("Merhaba\r\nNasılsın ?\r\nİyiyim\r\nSen nasılsın ?"); // \r\n wındos da satır bırakmayı saglayan ıfade
#endregion

#region yontem 3
Console.WriteLine("Merhaba" + Environment.NewLine + //non-unıx ve unıx programa göre satır ayarlar
   "Nasılsın ?" + Environment.NewLine +
   "İyiyim" + Environment.NewLine +
   "Sen nasılsın ?");
#endregion
*/ 

#region yontem 4
Console.WriteLine(@"Merhaba 
Nasılsın ?
İyiyim
Sen nasılsın ?
"); // @ ile başlamak bırakılan boşlukların cıktıda gorunmesını saglar alt satıra ınıp yazınca algılar.
#endregion