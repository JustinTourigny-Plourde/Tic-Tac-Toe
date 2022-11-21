namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToe ticTacToe = new TicTacToe();
            bool partieTermine = false;
            while (ticTacToe.isFini() ||partieTermine == false)
            {
                Console.Clear();
                ticTacToe.afficherJeu();

                Console.WriteLine("Placer symbole 1-9");
                int position = 0;
                int.TryParse(Console.ReadLine(), out position );
                position--;
                ticTacToe.placerSymbole(position);

                if (ticTacToe.gagnerTicTacToe('X'))
                {
                    Console.Clear();
                    ticTacToe.afficherJeu();
                    Console.WriteLine("C'est les 'X' qui gagne");
                    partieTermine = true;



                }
                else if (ticTacToe.gagnerTicTacToe('O'))
                {
                    Console.Clear();
                    ticTacToe.afficherJeu();
                    Console.WriteLine("C'est les 'O' qui gagne");
                    partieTermine = true;


                }
            }

        }
    }
}