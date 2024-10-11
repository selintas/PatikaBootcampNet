//yıldız ücgen yapımı  iç içe for kullanarak 2 for kullandık.

for (int i = 1; i <=10; i++) // sayısını oluşturur.
{
    #region satırın içeriğini * oluşturur
    for (int j = 0; j < i; j++) 
    {
        Console.Write("* ");
    }
    #endregion
    Console.WriteLine();
}

Console.ReadKey();

/*  
 For (initialization; condition; iteratör) 
..code..
 */