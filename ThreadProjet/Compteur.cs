using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadProjet
{
    public class Compteur
    {
        public int Debut { get; set; }
        public int Fin { get; set; }
        public string NomCompteur { get; set; }

        public Compteur(string name, int debut, int fin)
        {
            this.NomCompteur = name;
            this.Debut = debut;
            this.Fin = fin;
        }

        public void Lancer()
        {
            for(int i = Debut;i<= Fin;i++)
            {
                Console.Write($"{this.NomCompteur}-{i} \t");
                Thread.Sleep(10);
            }
        }
    }
}
