using System;

namespace Algo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("entrer nombre element:");
            int nbrElements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            List<int> entiers = GetListeEntiers(nbrElements);

            int total = entiers.Count;

            int k = 30;
            int debut = 0;


            if (total <= 60)
            {

                if(total<=30)
                {
                    k = total;
                }

                do
                {
                    Affiche(entiers, debut, k);
                    
                    debut = k;
                    int reste = total - debut;

                    if(reste<=30 && reste>0)
                    {
                        Affiche(entiers.TakeLast(reste).ToList(), 0, entiers.TakeLast(reste).Count());
                        break;
                    }
                    k = k + 30;
                }

                while (k < total);
                k = total;
                return;

            }

            do
            {
                Affiche(entiers, debut, k);
               

                int reste = total - debut;

                if (reste <= 60)
                {
                    int kk = 30;
                    int total2 = entiers.TakeLast(reste).ToList().Count;
                    int debutt = 0;

                    if(total2<=30)
                    {

                        Affiche(entiers.TakeLast(reste).ToList(), 0, entiers.TakeLast(reste).Count());
                        break;
                    }

                    Affiche(entiers.TakeLast(reste).ToList(), debutt, kk);
                  
                    debutt = kk;
                    int reste2 = total2 - debutt;

                    if(reste2<=30)
                    {
                        Affiche(entiers.TakeLast(reste2).ToList(), 0, entiers.TakeLast(reste2).Count());
                        break;
                    }

                }

                debut = k;
                k = k + 30;
            }
            while (k < total);

            Console.ReadKey();
        }

        private static List<int> GetListeEntiers(int nombre)
        {
            List<int> listeEntiers = new List<int>();
            int i = 0;

            while(i<nombre)
            {
                listeEntiers.Add(i);
                i++;
            }

            return listeEntiers;
        }

        private static void Affiche(List<int> liste,int debut,int fin)
        {
            Parallel.For(debut, fin, i =>
            {
                Console.WriteLine($"{liste[i]}");
            });

            Thread.Sleep(1000);
            Console.WriteLine("----------------");
        }
    }
}
