using System;

namespace Partie3Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean reussi = false;
            var rand = new Random();
            int val=rand.Next(1, 50);
            int nbrdevin;
            int nbreinitiative = 0;
            Console.WriteLine("le nombre choisi"+val);


            while (!reussi) 
            {
                Console.WriteLine("Deviner un nombre");
                nbrdevin = Convert.ToInt32(Console.ReadLine());

                if (nbrdevin < val)
                {
                    nbreinitiative += 1;
                    Console.WriteLine($"tentative num {nbreinitiative} {nbrdevin} ’est plus petit {val} ");
                    reussi = false;
                   
                }
                else if (nbrdevin > val)
                {
                    nbreinitiative += 1;
                    Console.WriteLine($"tentative num {nbreinitiative} {nbrdevin} ’est plus grand {val} ");
                    reussi = false;
                    
                }
                else if (nbrdevin == val)
                {
                    nbreinitiative += 1;
                    Console.WriteLine($"tentative num {nbreinitiative} {nbrdevin} Bravo {val} ");
                    reussi = true;
                   
                }
            }



        }
    }
}
