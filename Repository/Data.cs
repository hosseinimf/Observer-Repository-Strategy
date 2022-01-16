using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    public class Data : IData
    {
        public List<string> StringList { get; set; }

        public Data()
        {
            StringList = new List<string>();
        }
    }
}
