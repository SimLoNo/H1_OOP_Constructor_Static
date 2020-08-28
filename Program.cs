using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonN_Constructor_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            Person P2 = new Person("Abraham");
            Person P3 = new Person("Abraham", "Lincoln");
            Person P4 = new Person("Abraham", "Lincoln", "Abevej 20");
            Person P5 = new Person("Abraham", "Lincoln", "Abevej 20", 2400, "Hobro");

            List<Person> PersonListe = new List<Person>() { P1, P2, P3, P4, P5 };

            foreach (var item in PersonListe)
            {
                if (item.GetId() == 4)
                {
                    Console.WriteLine("Skriver PersonInstans");
                    item.skrivPersonInstans();
                }
                else if (item.GetId() == 2) 
                {
                    Console.WriteLine("Skriver Instans");
                    Person.skrivInstans(item);
                }
            }
            Console.WriteLine(Person.GetTaeller()); ;




            Console.ReadKey();
            }
    }
}
