using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSurname
{
    public class FileManager
    {
        public static bool FindLogFio(string checkFio)
        {
            FileDataObject obj = new FileDataObject();
            //TestDataObject obj = new TestDataObject();
            List<string> fios = obj.GetFiles();
            foreach (var fio in fios)
            {
                if (fio.Contains(checkFio))
                    return true;
            }
            return false;
        }
    }
}
