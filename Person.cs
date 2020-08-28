using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonN_Constructor_Static
{
    class Person
    {
        private static int Taeller;
       private int Id;

        public static int GetTaeller() { return Taeller; }
        private static void SetTaeller() { Taeller++; }

        public int GetId() { return Id; }
        private void SetId(int I) { Id = I; }

        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string Adresse { get; set; }

        public int PostNr { get; set; }

        public string By { get; set; }

        public void skrivPersonInstans() 
        {
            Console.WriteLine(Id + " " + Fornavn + " " + Efternavn + " " + Adresse);
        }

        public static void skrivInstans(Person Prsn) 
        {
            Console.WriteLine(Prsn.Id + " " + Prsn.Fornavn + " " + Prsn.Efternavn + " " + Taeller); ;
        }

        public Person() : this("N/A") { }
        public Person(string ForNvn) : this(ForNvn, "N/A") { }
        public Person(String ForNvn, string EftNvn) : this(ForNvn,EftNvn, "N/A") { }
        public Person(String ForNvn, string EftNvn, string Addr) : this(ForNvn, EftNvn, Addr, 0) { }
        public Person(String ForNvn, string EftNvn, string Addr, int PNr) : this(ForNvn, EftNvn, Addr, PNr, "N/A") { }
        public Person(String ForNvn, string EftNvn, string Addr, int PNr, String Bn) {
            if (Id == 0) 
            {
                SetTaeller();
                Id = Taeller;
            }
            Fornavn = ForNvn;
            Efternavn = EftNvn;
            Adresse = Addr;
            PostNr = PNr;
            By = Bn;
        }
    }
}
