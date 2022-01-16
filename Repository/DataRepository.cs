using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    public class DataRepository : IDataRepository
    {
        public IData DB = new Data();
       

        public void Load()
        {
            Console.WriteLine("\nLoading data ... ----------------");
            if (DB.StringList.Count > 0)
            {
                foreach (var item in DB.StringList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("There is no data in the list.");
            }        
        }

        public void Save(string data)
        {
            Console.WriteLine($"\nSaving data ... ({data})---------------");
            DB.StringList.Add(data);
            Console.WriteLine($"Data ({data}) is saved to the database.");
        }

        public void Delete(string data)
        {

        }
    }
}
