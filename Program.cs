/**Créer un nouveau projet Exercice39

Le programme doit permettre de saisir un vecteur de nombre (après avoir saisi la taille). Le but est ensuite de permuter les éléments (inverser le 1er élément avec le dernier, le 2ème avec l’avant dernier, etc…).
Il est interdit d’utiliser un autre vecteur, l’inversion doit se faire directement dans le même vecteur. Au final le vecteur inversé sera affiché.
 */

using System;
using System.Numerics;

namespace Exercice39
{
    class Program
    {
        static void Main(string[] args)
        {
            //Saisir le nombre de cases
            Console.Write("Saisir le nombre de case du tableau/Vecteur : ");
            int nb= int.Parse(Console.ReadLine());

            //Déclaration du vecteur/tableau
            int[] vec = new int[nb];

            //Saisie du tableau/vecteur
            for (int i = 0; i < nb; i++) {
                Console.Write("Saisir le nombre n°" + (i + 1) + " : ");
                vec[i] = int.Parse(Console.ReadLine());
                }
            
            //Inversion
            for (int i=0;i<nb/2;i++)//On s'arrête au milieu du vecteur sans quoi on continue l'inversion et on se retrouve avec le tableau initial
            {
                int sauv = vec[i];
                vec[i] = vec[nb - (i + 1)];
                vec[nb - (i + 1)] = sauv;
            }

            //Affichage du vecteur final
            for (int i = 0;i < nb;i++)
            {
                Console.Write(vec[i]+" | ");
            }
            //Console.Write(vec[nb-1]);
            Console.ReadLine();
        }
    }
}


