using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterfaceV
{

    public interface IDatabase
    {
        void Connect();
        void Disconnect();
        void ExecuteQuery(string query);
        //void Retrieve(string v);
        //void Store(string v, object value);
    }

    public interface ICashe
    {
        void Store(string key, object data);
        object Retrieve(string key);

    }
    internal class MsSQLDatabase : IDatabase, ICashe
    {
        public void Connect()
        {
            Console.WriteLine("conncect, Mssql");
        }

        public void Disconnect()
        {
            Console.WriteLine("disconnect mssql");
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine("query mssql");
        }

        public object Retrieve(string key)
        {
            Console.WriteLine($"retrıve mssql {key}");
            return null;
        }

        public void Store(string key, object data)
        {
            Console.WriteLine($" store mysql {key} data {data}");
        }
    }
}
