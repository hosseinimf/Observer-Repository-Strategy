using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    public class DataRepository : IDataRepository
    {
        private readonly List<string> _stringList = new List<string>();
       

        public void Load()
        {
            Console.WriteLine("\nLoading data ... ----------------");
            if (_stringList.Count > 0)
            {
                foreach (var item in _stringList)
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
            _stringList.Add(data);
            Console.WriteLine($"Data ({data}) is saved to the database.");
        }

        public void Delete(string data)
        {

        }
    }
}
