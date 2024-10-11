// birden ona sayılar goto
int a = 1;
baslangıc:
if (a <= 10)
{ 
    Console.WriteLine(a++); 
    goto baslangıc;
}

Console.ReadKey(); 

