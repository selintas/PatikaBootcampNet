// nesne olusturma
using PropsFieldsMethodsVideoPractice;

CoffeeMachine machine = new CoffeeMachine(); // nesne olusturma new kyword ile

machine.Model = "Baristo pro"; //propertieslere (model) erişitoruz. 
machine.WaterLevel = 500;
machine.CoffeeBeans = 100;

machine.MakeCoffee(); //metot cagırma. make coffe metot kahve yapma işlemı tanımlar.

machine.AddWater(400);
machine.AddCoffeeBeans(100);

for (int i = 0; i < 3; i++)
{
    machine.MakeCoffee();
}

