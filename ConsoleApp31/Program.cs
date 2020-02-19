using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        public static Random r1;

        public static void printDirections()
        {
            //prints directions for game
            Console.WriteLine("-----------------------TIC-TAC-TOE GAME-----------------------");
            Console.WriteLine("    In this game you will square off against the computer.    ");
            Console.WriteLine("                  You will be playing as Os.                  ");
            Console.WriteLine(" To play you will entering the number of a square where you...");
            Console.WriteLine("                 wish to place on of your Os.                 ");
            Console.WriteLine("            The goal is to get 3 in a row either..            ");
            Console.WriteLine("           vertically, horizontally, or diagonally.           ");
            Console.WriteLine("     The first player(you or the computer)to do so wins.      ");
            Console.WriteLine("           Good Luck! And may the best player win!            ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("");
        }

        public static void initboard(char[,] gameBoard)
        {
            //sets values of positions in board so player knows what num to enter to claim a spot on board as their's
            gameBoard[0, 0] = '1';
            gameBoard[0, 1] = '2';
            gameBoard[0, 2] = '3';
            gameBoard[1, 0] = '4';
            gameBoard[1, 1] = '5';
            gameBoard[1, 2] = '6';
            gameBoard[2, 0] = '7';
            gameBoard[2, 1] = '8';
            gameBoard[2, 2] = '9';

        }

        public static void printBoard(char[,] board)
        {
            //prints the board with whatever values are passed up
            for (int i = 0; i < 3; i++)//prints board
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " | ");
                }
                Console.WriteLine("");
            }
        }

        public static int getInt()
        {
            //gets an inputed number
            int n1 = 0;
            String input = "";
            Console.WriteLine("Please enter an integer: ");
            input = Console.ReadLine();
            n1 = Convert.ToInt32(input);
            return n1;
        }

        public static int compAI(char[,]board)
        {
            //basic AI checks for winning moves, then blocking moves, then optimal moves if no win/block, then random
            int comp=0;

            //check for winning move starts with collumns, then checks rows, then checks diagonals
            if ((board[0, 0] == 'X') && (board[1, 0] == 'X'))
            {
                comp = 7;
            }
            else if ((board[0, 0] == 'X') && (board[2, 0] == 'X'))
            {
                comp = 4;
            }
            else if ((board[1, 0] == 'X') && (board[2, 0] == 'X'))
            {
                comp = 1;
            }
            else if ((board[0, 1] == 'X') && (board[1, 1] == 'X'))
            {
                comp = 8;
            }
            else if ((board[0, 1] == 'X') && (board[2, 1] == 'X'))
            {
                comp = 5;
                //should not occur as 5 should be an optimal move done at begining of game 
            }
            else if ((board[1, 1] == 'X') && (board[2, 1] == 'X'))
            {
                comp = 2;
            }
            else if ((board[0, 2] == 'X') && (board[1, 2] == 'X'))
            {
                comp = 9;
            }
            else if ((board[0, 2] == 'X') && (board[2, 2] == 'X'))
            {
                comp = 6;
            }
            else if ((board[1, 2] == 'X') && (board[2, 2] == 'X'))
            {
                comp = 3;
            }
            else if ((board[0, 0] == 'X') && (board[0, 1] == 'X'))
            {
                comp = 3;
            }
            else if ((board[0, 0] == 'X') && (board[0, 2] == 'X'))
            {
                comp = 2;
            }
            else if ((board[0, 1] == 'X') && (board[0, 2] == 'X'))
            {
                comp = 1;
            }
            else if ((board[1, 0] == 'X') && (board[1, 1] == 'X'))
            {
                comp = 6;
            }
            else if ((board[1, 0] == 'X') && (board[1, 2] == 'X'))
            {
                comp = 5;
                //should not occur as 5 is optimal move that should occur at start of game
            }
            else if ((board[1, 1] == 'X') && (board[1, 2] == 'X'))
            {
                comp = 4;
            }
            else if ((board[2, 0] == 'X') && (board[2, 1] == 'X'))
            {
                comp = 9;
            }
            else if ((board[2, 0] == 'X') && (board[2, 2] == 'X'))
            {
                comp = 8;
            }
            else if ((board[2, 1] == 'X') && (board[2, 2] == 'X'))
            {
                comp = 7;
            }
            else if ((board[0, 0] == 'X') && (board[1, 1] == 'X'))
            {
                comp = 9;
            }
            else if ((board[0, 0] == 'X') && (board[2, 2] == 'X'))
            {
                comp = 5;
                //should not occur as 5 is an optimal move that should occur at start of game
            }
            else if ((board[1, 1] == 'X') && (board[2, 2] == 'X'))
            {
                comp = 1;
            }
            else if ((board[0, 2] == 'X') && (board[1, 1] == 'X'))
            {
                comp = 7;
            }
            else if ((board[0, 2] == 'X') && (board[2, 0] == 'X'))
            {
                comp = 5;
                //should not occur as 5 is an optimal move that should occur at start of game
            }
            else if ((board[2, 0] == 'X') && (board[1, 1] == 'X'))
            {
                comp = 3;
            }
            //start blocking starts with collumns, then rows, then diagonals
            else if ((board[0, 0] == 'O') && (board[1, 0] == 'O'))
            {
                comp = 7;
            }
            else if ((board[0, 0] == 'O') && (board[2, 0] == 'O'))
            {
                comp = 4;
            }
            else if ((board[1, 0] == 'O') && (board[2, 0] == 'O'))
            {
                comp = 1;
            }
            else if ((board[0, 1] == 'O') && (board[1, 1] == 'O'))
            {
                comp = 8;
            }
            else if ((board[0, 1] == 'O') && (board[2, 1] == 'O'))
            {
                comp = 5;
            }
            else if ((board[1, 1] == 'O') && (board[2, 1] == 'O'))
            {
                comp = 2;
            }
            else if ((board[0, 2] == 'O') && (board[1, 2] == 'O'))
            {
                comp = 9;
            }
            else if ((board[0, 2] == 'O') && (board[2, 2] == 'O'))
            {
                comp = 6;
            }
            else if ((board[1, 2] == 'O') && (board[2, 2] == 'O'))
            {
                comp = 3;
            }
            else if ((board[0, 0] == 'O') && (board[0, 1] == 'O'))
            {
                comp = 3;
            }
            else if ((board[0, 0] == 'O') && (board[0, 2] == 'O'))
            {
                comp = 2;
            }
            else if ((board[0, 1] == 'O') && (board[0, 2] == 'O'))
            {
                comp = 1;
            }
            else if ((board[1, 0] == 'O') && (board[1, 1] == 'O'))
            {
                comp = 6;
            }
            else if ((board[1, 0] == 'O') && (board[1, 2] == 'O'))
            {
                comp = 5;
            }
            else if ((board[1, 1] == 'O') && (board[1, 2] == 'O'))
            {
                comp = 4;
            }
            else if ((board[2, 0] == 'O') && (board[2, 1] == 'O'))
            {
                comp = 9;
            }
            else if ((board[2, 0] == 'O') && (board[2, 2] == 'O'))
            {
                comp = 8;
            }
            else if ((board[2, 1] == 'O') && (board[2, 2] == 'O'))
            {
                comp = 7;
            }
            else if ((board[0, 0] == 'O') && (board[1, 1] == 'O'))
            {
                comp = 9;
            }
            else if ((board[0, 0] == 'O') && (board[2, 2] == 'O'))
            {
                comp = 5;
            }
            else if ((board[1, 1] == 'O') && (board[2, 2] == 'O'))
            {
                comp = 1;
            }
            else if ((board[0, 2] == 'O') && (board[1, 1] == 'O'))
            {
                comp = 7;
            }
            else if ((board[0, 2] == 'O') && (board[2, 0] == 'O'))
            {
                comp = 5;
            }
            else if ((board[2, 0] == 'O') && (board[1, 1] == 'O'))
            {
                comp = 3;
            }
            //optimal moves towards begining of game 
            else if (board[1, 1] == '5')
            {
                comp = 5;
            }
            
            else if ((board[1, 0] == 'O') || (board[2, 0] == 'O') || (board[0, 1]=='O')||(board[1,1]=='O'))
            {
                comp = 1; 
            }
            else if ((board[1, 0] == 'O') || (board[0, 0] == 'O') || (board[2, 1] == 'O'))
            {
                comp = 7;
            }
            else if ((board[1, 2] == 'O') || (board[2, 2] == 'O') || (board[0, 1] == 'O'))
            {
                comp = 3;
            }
            else if ((board[1, 2] == 'O') || (board[0, 2] == 'O') || (board[2, 1] == 'O'))
            {
                comp = 9;
            }
            //last resort.....not likely to happen
            else
            {
                comp = r1.Next(1, 10);
            }
            return comp;
        }

        public static void placePlayerMove(int playermove, char[,] board)
        {
            //determines where to place player's move based off the number they entered
            if (playermove <= 3)
            {
                playermove = playermove - 1;
                board[0, playermove] = 'O';
            }
            else if ((playermove > 3) && (playermove < 7))
            {
                if (playermove == 4)
                {
                    board[1, 0] = 'O';
                }
                else if (playermove == 5)
                {
                    board[1, 1] = 'O';
                }
                else
                {
                    board[1, 2] = 'O';
                }
            }
            else
            {
                if (playermove == 7)
                {
                    board[2, 0] = 'O';
                }
                else if (playermove == 8)
                {
                    board[2, 1] = 'O';
                }
                else
                {
                    board[2, 2] = 'O';
                }
            }
        }

        public static void placeCompMove(int comp, char[,] board)
        {
            //places computer move based off the number chosen by the AI
            if (comp <= 3)
            {
                comp = comp - 1;
                board[0, comp] = 'X';
            }
            else if ((comp > 3) && (comp < 7))
            {
                if (comp == 4)
                {
                    board[1, 0] = 'X';
                }
                else if (comp == 5)
                {
                    board[1, 1] = 'X';
                }
                else
                {
                    board[1, 2] = 'X';
                }
            }
            else
            {
                if (comp == 7)
                {
                    board[2, 0] = 'X';
                }
                else if (comp == 8)
                {
                    board[2, 1] = 'X';
                }
                else
                {
                    board[2, 2] = 'X';
                }
            }
        }

        public static bool checkForPlayerWin(char[,]board)
        {
            //checks for 3 in a row of Os for player win
            if ((board[0, 0] == 'O') && (board[0, 1] == 'O') && (board[0, 2] == 'O'))
            {
                return true;
            }
            else if ((board[1, 0] == 'O') && (board[1, 1] == 'O') && (board[1, 2] == 'O'))
            {
                return true;
            }
            else if ((board[2, 0] == 'O') && (board[2, 1] == 'O') && (board[2, 2] == 'O'))
            {
                return true;
            }
            else if ((board[0, 0] == 'O') && (board[1, 0] == 'O') && (board[2, 0] == 'O'))
            {
                return true;
            }
            else if ((board[0, 1] == 'O') && (board[1, 1] == 'O') && (board[2, 1] == 'O'))
            {
                return true;
            }
            else if ((board[0, 2] == 'O') && (board[1, 2] == 'O') && (board[2, 2] == 'O'))
            {
                return true;
            }
            else if ((board[0, 2] == 'O') && (board[1, 1] == 'O') && (board[2, 0] == 'O'))
            {
                return true;
            }
            else if ((board[0, 0] == 'O') && (board[1, 1] == 'O') && (board[2, 2] == 'O'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool checkForCompWin(char[,]board)
        {
            //checks for three of a row of Xs for computer win
            if ((board[0, 0] == 'X') && (board[0, 1] == 'X') && (board[0, 2] == 'X'))
            {
                return true;
            }
            else if ((board[1, 0] == 'X') && (board[1, 1] == 'X') && (board[1, 2] == 'X'))
            {
                return true;
            }
            else if ((board[2, 0] == 'X') && (board[2, 1] == 'X') && (board[2, 2] == 'X'))
            {
                return true;
            }
            else if ((board[0, 0] == 'X') && (board[1, 0] == 'X') && (board[2, 0] == 'X'))
            {
                return true;
            }
            else if ((board[0, 1] == 'X') && (board[1, 1] == 'X') && (board[2, 1] == 'X'))
            {
                return true;
            }
            else if ((board[0, 2] == 'X') && (board[1, 2] == 'X') && (board[2, 2] == 'X'))
            {
                return true;
            }
            else if ((board[0, 2] == 'X') && (board[1, 1] == 'X') && (board[2, 0] == 'X'))
            {
                return true;
            }
            else if ((board[0, 0] == 'X') && (board[1, 1] == 'X') && (board[2, 2] == 'X'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static void printWinner(bool player, bool comp)
        {
            //prints who won based off results of checkForPlayerWin and checkForCompWin
            if(player==true)
            {
                Console.WriteLine("You Win!");
            }
            else if(comp==true)
            {
                Console.WriteLine("The computer wins.");
            }
            else
            {
                Console.WriteLine("Neither you nor the computer won.");
            }
        }

        public static void game(char[,]board)
        {
            //runs the game, checks for repeat values
            bool[] valueCheck = { false, false, false, false, false, false, false, false, false, false };
            int playermove = 0;
            int moves = 0;
            int computer = 0;
            bool playerWin = false;
            bool compWin = false;

            while ((moves < 9) &&(playerWin == false)&&(compWin==false))
            {
                Console.WriteLine("Please select the number of the space where you wish to place an O.");
                playermove = getInt();
                while((playermove<1)||(playermove>9)||(valueCheck[playermove]==true))
                {
                    Console.WriteLine("That is not a valid move. Please try again.");
                    playermove = getInt();
                }
                valueCheck[playermove] = true;
                placePlayerMove(playermove, board);
                printBoard(board);
                playerWin = checkForPlayerWin(board);
                if (playerWin == false)
                {
                    computer = compAI(board);
                    while(valueCheck[computer]==true)
                    {
                        computer = compAI(board);
                    }
                    valueCheck[computer] = true;
                    Console.WriteLine(" ");
                    Console.WriteLine("The computer places an X at spot number " + computer);
                    placeCompMove(computer, board);
                    printBoard(board);
                    moves = moves + 2;
                    Console.WriteLine(" ");
                    compWin=checkForCompWin(board);
                }
                else
                {
                    Console.WriteLine(" ");
                }
            }
            printWinner(playerWin, compWin);
        }

        public static void ticTacToe()
        { 
            //creates board, calls methods to create game
            char[,] board = new char[3, 3];

            printDirections();
            initboard(board);
            printBoard(board);
            game(board);
        }

        static void Main(string[] args)
        {
            //creates random and game
            r1 = new Random();
            ticTacToe();
        }
    }
}