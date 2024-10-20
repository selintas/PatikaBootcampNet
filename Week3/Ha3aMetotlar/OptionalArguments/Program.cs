//Optional Arguments
//void SaatiYazdir(bool saniyeGizle = false)


void SaatiYazdir(bool saniyeGizle = false)
{ 
    { 
    Console.WriteLine(DateTime.Now.ToShortTimeString());
    return; //** dipnot oku
    }
Console.WriteLine(DateTime.Now.ToLongTimeString()); 
}

SaatiYazdir();
SaatiYazdir(true);

Console.ReadKey();

Console.ReadKey();
 
// *** Return Keyword'ü coid metotlarda derhal çıkış sağlar
// ve sonrasındakı metoda dahil hiç bir kod çalışmaz.
