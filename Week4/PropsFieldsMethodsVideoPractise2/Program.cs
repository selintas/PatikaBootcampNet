using PropsFieldsMethodsVideoPractise2;

Product laptop = new Product(); //instance nesne oluşturduk new keyword ıle
laptop.Name = "Laptop";
laptop.Price = 10000;
laptop.Stock = 10;
 
Product phone = new Product();
phone.Name = "Telefon";
phone.Price = 3000;
phone.Stock = 20;

laptop.DisplayProduct();
phone.DisplayProduct();

laptop.SellProduct(2);
phone.SellProduct(5);

laptop.RestockProduct(5); 

phone.RestockProduct(10);

