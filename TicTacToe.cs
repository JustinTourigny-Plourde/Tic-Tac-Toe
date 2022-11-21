using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToe
    {
        char[] tableau;
        int tour;

        public TicTacToe()
        {
            tableau = new char[9]
            {
                ' ', ' ', ' ',
                ' ', ' ', ' ',
                ' ', ' ', ' ',
            };
            int tour = 1;
        }
        public bool gagnerTicTacToe(char symbol)
        {
            bool gagne = false;

            if (this.tableau[0] == symbol && this.tableau[1] == symbol && this.tableau[2] == symbol || this.tableau[3] == symbol && this.tableau[4] == symbol && this.tableau[5] == symbol || this.tableau[6] == symbol && this.tableau[7] == symbol && this.tableau[8] == symbol || this.tableau[0] == symbol && this.tableau[3] == symbol && this.tableau[6] == symbol|| this.tableau[1] == symbol && this.tableau[4] == symbol && this.tableau[7] == symbol|| this.tableau[2] == symbol && this.tableau[5] == symbol && this.tableau[8] == symbol|| this.tableau[0] == symbol && this.tableau[4] == symbol && this.tableau[8] == symbol || this.tableau[2] == symbol && this.tableau[4] == symbol && this.tableau[6] == symbol)
            {
                gagne = true;
            }

            return gagne;
        }

        public bool placerSymbole(int position)
        {
            bool placer = false;
            char symbolPlace = ' ';
            // quel symbol est-ce que je place

            int choixSymbole = this.tour % 2;
            if (choixSymbole == 0)
            {
                symbolPlace = 'X';
            }
            else
            {
                symbolPlace = 'O';
            }
            
            // est-ce que je peux placer la pièce à la position?
            if (this.tableau[position] != ' ')
            {
                Console.WriteLine("Action impossible!");
            }
            else
            {
                this.tableau[position] = symbolPlace;
                placer = true;
                this.tour++;
            }

            // quand je place une symbol passer au tour suivant

            return placer;
        }

        public bool isFini()
        {
            return this.tour >= 9;
        }

        public void afficherJeu()
        {
            Console.WriteLine("  " +this.tableau[0] + " | " + this.tableau[1] + " | " + this.tableau[2]);
            Console.WriteLine("--------------");
            Console.WriteLine("  " +this.tableau[3] + " | " + this.tableau[4] + " | " + this.tableau[5]);
            Console.WriteLine("--------------");
            Console.WriteLine("  " + this.tableau[6] + " | " + this.tableau[7] + " | " + this.tableau[8]);


        }

    }
}
