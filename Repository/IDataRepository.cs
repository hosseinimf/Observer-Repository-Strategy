using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    public interface IDataRepository
    {
        void Load();
        void Save(string data);        
        void Delete(string data);
    }
}
