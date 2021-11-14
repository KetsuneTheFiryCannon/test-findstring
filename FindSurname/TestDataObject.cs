using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSurname
{
    class TestDataObject
    {
        public List<string> GetFiles()
        {
            List<string> list = new List<string>();
            list.Add("Akima Samurai Ooishi");
            list.Add("Miki Au Hitohido");
            list.Add("Hutabe Bushido Kazan");
            Console.WriteLine(list);
            return list;
        }
    }
}
