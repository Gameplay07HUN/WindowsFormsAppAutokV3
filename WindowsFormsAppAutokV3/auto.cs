using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppAuutók
{
    internal class auto
    {
        int id;
        string marka;
        string nev;
        string motor;
        int uzembehelyezve;
        string szin;

        public auto(int id, string marka, string nev, string motor, int uzembehelyezve, string szin)
        {
            Id = id;
            Marka = marka;
            Nev = nev;
            Motor = motor;
            Uzembehelyezve = uzembehelyezve;
            Szin = szin;
        }

        public int Id { get => id; set => id = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Motor { get => motor; set => motor = value; }
        public int Uzembehelyezve { get => uzembehelyezve; set => uzembehelyezve = value; }
        public string Szin { get => szin; set => szin = value; }
    }
}
