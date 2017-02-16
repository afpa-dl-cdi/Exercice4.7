using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Définitions des variables 
            int iPoint = 0,
                age, 
                anneePermis,
                nombreAccident,
                anneeFidelite;
            string situation;

            // récupération des valeurs 
            Console.WriteLine("Entrez votre âge : ");
            string agetemp = Console.ReadLine();
            age = Convert.ToInt16(agetemp);
            Console.WriteLine("Entrez le nombre d'année de permis : ");
            string anneePermistemp = Console.ReadLine();
            anneePermis = Convert.ToInt16(anneePermistemp);
            Console.WriteLine("Entrez le nombre d'accident : ");
            string nombreAccidentTemp = Console.ReadLine();
            nombreAccident = Convert.ToInt16(nombreAccidentTemp);
            Console.WriteLine("Entrez votre ancienneté dans la compagnie : " );
            string anneeFidelitetemp = Console.ReadLine();
            anneeFidelite = Convert.ToInt16(anneeFidelitetemp);


            // Vérification des conditions 
            if (age < 25)
            {
                iPoint += 1;
            } 

            if (anneePermis < 2 )
            {
                iPoint += 1;
            }

            iPoint += nombreAccident;

            if (iPoint < 3 && anneeFidelite > 5 )
            {
                iPoint -= 1;
            }

            // attributions du code couleur
            switch (iPoint)
            {
                case -1:
                    situation = "bleu";
                    break;
                case 0:
                    situation = "vert";
                    break;
                case 1:
                    situation = "orange";
                    break;
                case 2:
                    situation = "rouge";
                    break;
                default:
                    situation = "refusé";
                    break;
            }

            Console.WriteLine("Votre situation : {0}", situation); ;
        }
    }
}
