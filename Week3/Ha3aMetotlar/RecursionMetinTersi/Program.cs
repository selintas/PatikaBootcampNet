// Recursıon String tersi 
 
string Tersi(string metin)
{
    if (string.IsNullOrEmpty(metin) || metin.Length == 1) 
        return metin;

    return Tersi(metin.Substring(1)) + metin[0]; 
    // Substring 1 den sonrasını alır ..
}
string gonullu = "berkan";
string tersi = Tersi(gonullu);
Console.WriteLine($"{gonullu} tersi :  {tersi}");

Console.ReadKey();