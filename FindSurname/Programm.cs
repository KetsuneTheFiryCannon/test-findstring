using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSurname
{
    class Programm
    {
        static void Main()
        {
            string fio = "Akima Samurai Oishii";
            if (FileManager.FindLogFio(fio))
                Console.WriteLine($"FIO {fio} is found!");
            else
                Console.WriteLine($"FIO {fio} is not found!");
            Console.ReadKey();
        }
    }
}
