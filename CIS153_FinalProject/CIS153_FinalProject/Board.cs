﻿using System;
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
            //if(moves > 2) //using this to test game over form loading and board correctly passing between forms on game over
            //{
            //    return true;
            //}

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
            // TODO -- FIX WHEN DESIGN IS CREATED
            for (int i = 0; i < row - 3; i++)
            {
                for (int ii = 0; ii < column - 3; ii++)
                {
                    if (gameBoard[i, ii] == currentPlayer && gameBoard[i + 1, ii - 1] == currentPlayer && gameBoard[i + 2, ii - 2] == currentPlayer && gameBoard[i + 3, ii - 3] == currentPlayer)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool canPlaceCoin(int c)
        {
            Console.WriteLine(c.ToString());

            if(gameBoard[0, c] == Color.NONE)
            {
                return true;
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


        public int takeWinHorizontal() //idealy this should return an int of the column to insert at
        {
            for (int i = 0; i < row; i++)
            {
                for (int ii = 0; ii < column - 3; ii++)
                {
                    if (gameBoard[i, ii] == Color.YELLOW && gameBoard[i, ii + 1] == Color.YELLOW && gameBoard[i, ii + 2] == Color.YELLOW)
                    {
                        return ii + 3;
                    }
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

                    if (gameBoard[row, col] == Color.RED && gameBoard[row - 1, col] == Color.RED && gameBoard[row - 2, col] == Color.RED)
                    {
                        //due to the nature of board structure, you only ever need to block once as there are not enough spots to try again
                        
                        return col;
                    }
                }
            }
            return 99;
        }


    }
}
