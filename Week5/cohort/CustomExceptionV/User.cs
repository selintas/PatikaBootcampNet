using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionV
{
    public class User
    { 
        public void SetAge(int age)
        {
            if (age < 0)
            {
                throw new InvalidAgeException("Yaş negatif girilemez.");
            }

            throw new Exception("genel hata.");

        }
    }

    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)  
        {  

        }
    }
}
