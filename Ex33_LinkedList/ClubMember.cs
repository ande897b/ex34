using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex33_LinkedList
{
    public class ClubMember
    {
        public int Nr { get; set; }
        public string FNavn { get; set; }
        public string LNavn { get; set; }
        public int Alder { get; set; }
        public ClubMember(int nr,string Fnavn,string Lnavn, int alder)
        {
            Nr = nr;
            FNavn = Fnavn;
            LNavn = Lnavn;
            Alder = alder;
        }
        public override string ToString()
        {
            return $"{Nr} {FNavn} {LNavn} {Alder}";
        }
    }
}
