using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir bilgi yarışması yapıyoruz!");
        Console.WriteLine("2 cevap şıklı 3 adet sorumuz var!\n");
        
        int correctAnswers = 0; // Doğru cevap sayacı

        // Soru 1
        Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir?");
        Console.WriteLine("a) Lama");
        Console.WriteLine("b) Deve");
        string answer1 = Console.ReadLine().ToLower(); // Harf duyarlılığını ortadan kaldırmak için küçük harfe çeviriyoruz.

        if (answer1 == "b")
        {
            Console.WriteLine("Doğru cevap!\n");
            correctAnswers++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap! Doğru cevap b) Deve.\n");
        }

        // Soru 2
        Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir?");
        Console.WriteLine("a) Venüs");
        Console.WriteLine("b) Mars");
        string answer2 = Console.ReadLine().ToLower(); // Harf duyarlılığını ortadan kaldırmak için küçük harfe çeviriyoruz.

        if (answer2 == "a")
        {
            Console.WriteLine("Doğru cevap!\n");
            correctAnswers++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap! Doğru cevap a) Venüs.\n");
        }

        // İlk 2 soruya cevap veren kullanıcının büyük ödülü kazanma ihtimali ortadan kalktığı için 3. soruyu sormuyoruz.
        if (correctAnswers >= 2)
        {
            // Soru 3
            Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
            Console.WriteLine("a) 7");
            Console.WriteLine("b) 12");
            string answer3 = Console.ReadLine().ToLower(); // Harf duyarlılığını ortadan kaldırmak için küçük harfe çeviriyoruz.

            if (answer3 == "b")
            {
                Console.WriteLine("Doğru cevap!\n");
                correctAnswers++;
                Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
            }
            else
            {
                Console.WriteLine("Yanlış cevap! Doğru cevap b) 12.\n");
            }
            Console.WriteLine("Yarışmaya katıldığınız için teşekkürler!");
        }
        else
        {
            Console.WriteLine("Maalesef, büyük ödülü kazanamadınız. Daha fazla şans dileriz!");
        }
        
        

        
    }
}