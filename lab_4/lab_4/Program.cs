using System;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Журнал журнал = new Журнал { Vidacha = "20.01.2001", Vipysk = "4" };
            
            Izdanie[] data = { журнал };

            PrintPersons(журнал);
        }

        static void PrintPersons(Izdanie[] журнал)
        {
            foreach (var person in журнал)
            {
                person.PrintFullName();
            }    
        }
    }
}