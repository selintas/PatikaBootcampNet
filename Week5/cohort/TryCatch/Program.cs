// Try - Catch

using System;

public class Program
{
    public static void Main()
    {
        try
        {
            // Potansiyel hata oluşturabilecek kod bloğu
            Console.Write("Lütfen bir sayı giriniz: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            Console.WriteLine("Girdiğiniz sayı: " + number);
        }
        catch (FormatException ex)
        {
            // Format hatası durumunda burası çalışır
            Console.WriteLine("Hata: Sayı formatı geçersiz. Lütfen doğru formatta bir sayı giriniz.");
        }
        catch (Exception ex)
        {
            // Genel hata durumu için burası çalışır
            Console.WriteLine("Bir hata oluştu: " + ex.Message); // ex.Message hata detayını anlamak ıcın (ex.Message ise bu hatanın sistem tarafından sağlanan açıklamasıdır.)
            // çıktı ise; Bir hata oluştu: Input string was not in a correct format. olarak gorunur ex.message ile

                                                                 // ex.StackTrace: Hatanın hangi satırda ve hangi metotta oluştuğunu gösterir.
                                                                 // ex.InnerException: Eğer bir hata başka bir hatayı tetiklediyse, bu hataya ulaşmanı sağlar.
        }
        finally
        {
            // Her durumda çalışmasını istediğiniz kodlar buraya yazılır
            Console.WriteLine("İşlem tamamlandı.");
        }
    }
}