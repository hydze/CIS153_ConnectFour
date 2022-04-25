using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    public enum Color
    {
        RED,
        YELLOW,
        NONE
    }

    public class Cell
    {
        int color;          //0 YELLOW, 1 RED, 2 NONE

        public Cell(int color)
        {
            this.color = color;
        }
    }

    public class Board
    {

        private int column = 7;
        private int row = 6;
        private int moves = 0;
        private Color currentPlayer;
        private Color lastPlayer = Color.RED; //since currentPlayer is reassinged in insertcoin before the images are updated in the twoPlayer form im adding this to get the color of which token we should make visible

        private Color[,] gameBoard;

        public Board()
        {
            gameBoard = new Color[row, column];
            currentPlayer = Color.RED;

            for (int i = 0; i < row; i++)
            {
                for (int ii = 0; ii < column; ii++)
                {
                    gameBoard[i, ii] = Color.NONE;
                }
            }
        }

        public bool hasWinner()
        {
            return checkWinHorizontal() || checkWinVertical() || checkWinDiagonal();
        }

        public Color[,] getGameBoard()
        {
            return gameBoard;
        }

        public bool checkWinHorizontal()
        {
            for (int i = 0; i < row; i++)
            {
                for (int ii = 0; ii < column - 3; ii++)
                {
                    if(gameBoard[i, ii] == lastPlayer && gameBoard[i, ii + 1] == lastPlayer && gameBoard[i, ii + 2] == lastPlayer &&  gameBoard[i, ii + 3] == lastPlayer)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool checkWinVertical()
        {
            for (int i = 0; i < row - 3; i++)
            {
                for (int ii = 0; ii < column; ii++)
                {
                    if (gameBoard[i, ii] == lastPlayer && gameBoard[i + 1, ii] == lastPlayer && gameBoard[i + 2, ii] == lastPlayer && gameBoard[i + 3, ii] == lastPlayer)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool checkWinDiagonal()
        {
            try
            {
                // Check top left to bottom right
                for (int i = 0; i < row - 3; i++)
                {
                    for (int ii = 0; ii < column - 3; ii++)
                    {
                        if (gameBoard[i, ii] == lastPlayer && gameBoard[i + 1, ii + 1] == lastPlayer && gameBoard[i + 2, ii + 2] == lastPlayer && gameBoard[i + 3, ii + 3] == lastPlayer)
                        {
                            return true;
                        }
                    }
                }

                // Check bottom left to top right
                for (int i = 0; i < row - 3; i++)
                {
                    for (int ii = 0; ii < column - 3; ii++)
                    {
                        if (gameBoard[i, ii] == lastPlayer && gameBoard[i + 1, ii - 1] == lastPlayer && gameBoard[i + 2, ii - 2] == lastPlayer && gameBoard[i + 3, ii - 3] == lastPlayer)
                        {
                            return true;
                        }
                    }
                }
            }
            catch
            {
                return false;
                //Console.WriteLine("Too much sauce");
            }

            return false;
        }

        public bool canPlaceCoin(int c)
        {
            Console.WriteLine(c.ToString());

            if (c >= 0 && c <= 6)
            {
                if (gameBoard[0, c] == Color.NONE)
                {
                    return true;
                }
            }
            return false;
        }

        public int insertCoin(int c)
        {

            for (int i = row - 1; i >= 0; i--) // changed from > to >= to get the top token number correct for placement
            {
                if(gameBoard[i, c] == Color.NONE)
                {
                    gameBoard[i, c] = currentPlayer;
                    //save player color before switching to use after inserting coin before turn is really over
                    lastPlayer = currentPlayer;
                    //switches current player color
                    currentPlayer = currentPlayer == Color.RED ? Color.YELLOW : Color.RED;
                    moves++; // a coin was inserted increment moves counter
                    return i;
                }
            }

            return 0; //returning 100 here led to row being set to 5 - 100 or -95 crashing program, setting to 0 corrects math elsewhere 
        }

        public int insertCoinHover(int c)
        {
            for (int i = row - 1; i >= 0; i--) // changed from > to >= to get the top token number correct for placement
            {
                if (gameBoard[i, c] == Color.NONE)
                {
                    return i;
                }
            }
            return 0; 
        }

        public bool isFinished()
        {
            if(hasWinner() || moves == 42)
            {
                return true;
            }
            return false;
        }

        public Color getLastPlayer() //misleading name as we are using it to set the game token visiblity on different form
        {
            return lastPlayer;
        }

        public int getMoves()
        {
            return moves;
        }





        /// stuff for 'AI' 6 basic rules that return a column to place a token / Logic also in bot function in SP form to try to take middle row
        public int takeHorizontalWin() 
        {
            for (int i = 0; i < row; i++)
            {
                for (int ii = 0; ii < column - 3; ii++)
                {
                    try
                    {
                        if (gameBoard[i, ii] == Color.YELLOW && gameBoard[i, ii + 1] == Color.YELLOW && gameBoard[i, ii + 2] == Color.YELLOW)
                        {
                            //pick which side to put coin on
                            if (canPlaceCoin(ii + 3))
                            {
                                return ii + 3;
                            }
                            if (canPlaceCoin(ii - 1))
                            {
                                return ii - 1;
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Checked out of bounds");
                    }
                }
            }
            return 99;
        }

        public int blockHorizontalBase() //favor center in overall strategy, if red takes center we gotta lock out row 
        {
            if(gameBoard[5,3] == Color.RED && moves == 1)
            {
                if (canPlaceCoin(4))
                {
                    return 4;
                }
            }
            if (gameBoard[5,3] == Color.RED && moves > 1)
            {
                if (canPlaceCoin(2) && gameBoard[5,2] == Color.NONE)
                {
                    return 2;
                }
                else if(canPlaceCoin(1) && gameBoard[5,1] == Color.NONE)
                {
                    return 1;
                }
            }

            return 99;
        }

        public int blockVertical() //return 
        {
            for (int col = 0; col <= 6; col++)
            {
                //3,0
                //4,0
                //5,0
                //Console.WriteLine(col.ToString());

                for (int row = 5; row >= 0; row--)
                {
                    //Console.WriteLine(row.ToString());
                    try
                    {
                        if (gameBoard[row, col] == Color.RED && gameBoard[row - 1, col] == Color.RED && gameBoard[row - 2, col] == Color.RED)
                        {
                            //due to the nature of board structure, you only ever need to block once  for each column as there are not enough spots to try again
                            return col;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Checked out of bounds");
                    }
                }
            }
            return 99;
        }

        public int takeVerticalWin() //return 
        {
            for (int col = 0; col <= 6; col++)
            {

                //Console.WriteLine(col.ToString());

                for (int row = 5; row >= 0; row--)
                {
                    //Console.WriteLine(row.ToString());

                    try
                    {
                        if (gameBoard[row, col] == Color.YELLOW && gameBoard[row - 1, col] == Color.YELLOW && gameBoard[row - 2, col] == Color.YELLOW)
                        {
                            return col;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Checked out of bounds");
                    }
                }
            }
            return 99;
        }

        public int pushVertical2() //return 
        {
            for (int col = 0; col <= 6; col++)
            {
                bool stop = false;

                //Console.WriteLine(col.ToString());

                for (int row = 5; row >= 0; row--)
                {
                    //Console.WriteLine(row.ToString());

                    if (stop == false)
                    {
                        try
                        {
                            if (gameBoard[row, col] == Color.YELLOW)
                            {
                                if(gameBoard[row -1, col] != Color.RED)
                                {
                                    return col;
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Checked out of bounds");
                        }
                    }
                }
            }
            return 99;
        }

        public int pushVertical3() //return 
        {
            for (int col = 0; col <= 6; col++)
            {

                //Console.WriteLine(col.ToString());

                for (int row = 5; row >= 0; row--)
                {
                    //Console.WriteLine(row.ToString());

                    try
                    {
                        if (gameBoard[row, col] == Color.YELLOW && gameBoard[row - 1, col] == Color.YELLOW)
                        {
                            if (gameBoard[row - 1, col] != Color.RED)
                            {
                                return col;
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Checked out of bounds");
                    }
                }
            }
            return 99;
        }

    }
}
