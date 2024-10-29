using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace InheritanceV
{
    public abstract class Person // bu sınıf soyut olmalı mıras yenı nesne ureterek kullan. abstract yazdık person new yapmayacagız
    { 
        public string FirstName { get; set; }   
        public string LastName { get; set; }

        public void Work()
        {
            Console.WriteLine(" workıng ");
        }
    } 
     
    public class Teacher : Person 
    {   
        public void Study()
        {
            Console.WriteLine(" teaching");
        }
    } 
     
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine(" studıng");
        }
    }
}
