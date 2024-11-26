// doya işlemleri 

// dosya nereye kaydolacak 
using System.Security.AccessControl;

string logFile = "app.log"; // dosyaya eklemek 
 
if(!File.Exists(logFile)) // dosya, varı yokmu bakar logfıle ı kontrol eder yoksa oluşturacak
{
    using (FileStream fs = File.Create(logFile)) //create dosya oluştur.// usıng anlık olarak temızler .
    {
        using (StreamWriter writer = new StreamWriter(fs)) // yazdır
        {
            writer.WriteLine($"{DateTime.Now}: Log dosyası oluşturuldu.");
        }

    }
        
}

//mevcut dosyaya ekleme yapmak (appendtext ile)
using (var writer = File.AppendText(logFile))
{
    writer.WriteLine($"{DateTime.Now} uygulama başlatıldı");
}

// File.ReadLines(logFile); // dosya okuma yontemı


using (var reader = File.OpenText(logFile)) // log okuma
{
    string line;

    while ((line = reader.ReadLine()) != null) // satırları okuma
    {
        Console.WriteLine(line);
    }
} 

//async uzantılı oluncca--> asenkron
var result = await File.ReadAllTextAsync(logFile);

// oluşturlan dosyaya bakma: 
// debug mod calıştıgı ıcın uygulamanın debugta kayıtlı
 
// GİDİŞ YOLU 
//projeye sag tıkla --> Open Folder Fİle EXplorer --> bin -->debug --> .ner8.0 --> app.log (içinde -- Notepad ile açtık) 

// proje dagıtmak proje sag tıkla publısh ..  
//or 
// assagıda powershell tıkla --> dotnet publish -c Release yaz