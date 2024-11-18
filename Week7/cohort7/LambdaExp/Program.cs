// (parameterList) => expression

//Burada:

//parameterList: Lambda ifadesinin parametre listesidir.


//=>: Lambda operatörü, parametre listesini ifadenin (expression) sağ tarafına bağlar.

////expression: Lambda ifadesinin geri dönüş değerini veya işlemi temsil eden ifadedir. 

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

// Lambda ifadesiyle her elemanın karesini alalım
List<int> squares = numbers.Select(x => x * x).ToList();

foreach (var square in squares)
{
    Console.WriteLine(square); // Çıktı: 1, 4, 9, 16, 25
}