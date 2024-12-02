namespace ASP_NET_MVC_Projesi.Models
{
    public class CustomerViewModel
    {

        public Customer Customer { get; set; }
        public string WelcomeMessage { get; set; } // Ekstra bir veri
    }
}
//Burada, CustomerViewModel sınıfı, Customer modelini ve view'da göstermek için ek bir WelcomeMessage özelliğini içerir. Yani ViewModel'i asıl modelinizden eksik ya da fazla fark etmeksizin, View ile Controller arasında taşımak istediğiniz tüm özelliklerle açabilirsiniz.