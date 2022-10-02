using System;
using System.Threading;

namespace ThreadProjet
{

    class Program
    {
        static void Main(string[] args)
        {
            Compteur cptA = new Compteur("A", 1000, 2000);
            Compteur cptB = new Compteur("B", 1000, 2000);
            Compteur cptC = new Compteur("C", 1000, 2000);
            Compteur cptD = new Compteur("D", 1000, 2000);


            var anim = new Animation(@"mnop");

            while(true)
            {
                Console.Write("{0}\r", anim.Suivant());
            }

            var v = Task.Run(() =>
            {
                cptA.Lancer();
            });

            v.Wait();

            Console.WriteLine("je suis deva");

            Console.ReadKey();
        }

        
       
    }
}

