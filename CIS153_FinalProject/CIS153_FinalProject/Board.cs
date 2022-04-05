using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    enum Color
    {
        RED,
        YELLOW,
        NONE
    }

    class Cell
    {
        int color;          //0 YELLOW, 1 RED, 2 NONE

        public Cell(int color)
        {
            this.color = color;
        }
    }

    class Board
    {

        private int column = 7;
        private int row = 6;
        private int moves = 0;
        private Color currentPlayer;

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

        public bool checkWinHorizontal()
        {
            for (int i = 0; i < row; i++)
            {
                for (int ii = 0; ii < column - 3; ii++)
                {
                    if(gameBoard[i, ii] == currentPlayer && gameBoard[i, ii + 1] == currentPlayer && gameBoard[i, ii + 2] == currentPlayer &&  gameBoard[i, ii + 3] == currentPlayer)
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
                    if (gameBoard[i, ii] == currentPlayer && gameBoard[i + 1, ii] == currentPlayer && gameBoard[i + 2, ii] == currentPlayer && gameBoard[i + 3, ii] == currentPlayer)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool checkWinDiagonal()
        {
            // Check top left to bottom right
            for (int i = 0; i < row - 3; i++)
            {
                for (int ii = 0; ii < column - 3; ii++)
                {
                    if (gameBoard[i, ii] == currentPlayer && gameBoard[i + 1, ii + 1] == currentPlayer && gameBoard[i + 2, ii + 2] == currentPlayer && gameBoard[i + 3, ii + 3] == currentPlayer)
                    {
                        return true;
                    }
                }
            }

            // Check bottom left to top right
            // TODO -- FIX WHEN DESIGN IS CREATED
            for (int i = 0; i < row - 3; i++)
            {
                for (int ii = 0; ii < column - 3; ii++)
                {
                    if (gameBoard[i, ii] == currentPlayer && gameBoard[i - 1, ii + 1] == currentPlayer && gameBoard[i - 2, ii + 2] == currentPlayer && gameBoard[i - 3, ii + 3] == currentPlayer)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool canPlaceCoin(int c)
        {
            return gameBoard[0, c] == Color.NONE;
        }

        public bool insertCoin(int c)
        {
            if (!canPlaceCoin(c))
            {
                return false;
            }

            for (int i = row - 1; i > 0; i--)
            {
                if(gameBoard[i, c] == Color.NONE)
                {
                    gameBoard[i, c] = currentPlayer;
                    //switches current player color
                    currentPlayer = currentPlayer == Color.RED ? Color.YELLOW : Color.RED;
                    return true;
                }
            }

            return false;
        }

        public bool isFinished()
        {
            return hasWinner() || moves == 42;
        }
    }
}
