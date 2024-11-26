using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_11_26
{
    internal class Szemely
    {

        public Guid Guid { get; set; }
        public required string Nev { get; set; }

        public override string ToString() =>
            $"{Nev} Guid: {Guid}";
        public Szemely(string nev)
        {
            Guid = Guid.NewGuid();
            Nev = nev;
        }
    }
}
