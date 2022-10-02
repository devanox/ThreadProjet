using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadProjet
{
    public class Animation
    {
        public int Actuel { get; set; }
        public string Motif { get; set; }

        public Animation(string motif)
        {
            this.Actuel = -1;
            this.Motif = motif;
        }

        public char Suivant()
        {
            return Motif[this.Actuel = (this.Actuel + 1)%this.Motif.Length];
        }
    }
}
