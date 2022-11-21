using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Tableau
    {
        int[] tableau;


        public Tableau(int nbElements)
        {
            tableau = new int[nbElements];
        }

        public void remplirAleatoire(int min, int max)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
               Random rng = new Random();
                tableau[i] = rng.Next(min, max + 1);
            }
        }

        public void afficherTableau()
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.Write(tableau[i] + "");
            }
            Console.WriteLine();
        }

        public void trierAsc()
        {
            for (int i = 0; i < tableau.Length; i++)
            {
            
                int positionMin= trouverMin(i);

                int temporaire = this.tableau[positionMin];
            }
           
        }
        public int trouverMin(int depart)
        {
            int positionMinimum = depart;

            for(int i = depart; i<this.tableau.Length; i++)

                if (this.tableau[i] < this.tableau[positionMinimum])
                {
                    positionMinimum = i;
                }




            return positionMinimum;
        }
    }


}
