
using PolymorphismV;

Guitar guitar = new Guitar();

guitar.PlaySound(); // burda base kullanmıstık

Piano piano = new Piano();

piano.PlaySound();
Console.WriteLine("____");

MusicalInstrument musical = new Piano();    // musical enstruman pianodan türerilebilir. temel sınıf değişkenle türetilmiş sınıf öz. erişilebilir.

musical.PlaySound(); // piano sesı cagrılır.