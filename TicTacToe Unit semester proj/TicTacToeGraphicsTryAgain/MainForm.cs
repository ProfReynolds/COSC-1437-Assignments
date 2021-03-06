﻿using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using CoreLibrary;
using TicTacToe_Interfaces;

/*
 * ProfReynolds
 */

namespace TicTacToeGraphics
{
    public partial class MainForm : Form
    {
        private Middle_Tier.TicTacToeGame _ticTacToeGame = new Middle_Tier.TicTacToeGame();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _ticTacToeGame.CellOwnerChanged += this.CellOwnerChangedHandler;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            // as the content changes, this event will trigger as each character changes

            var playerNameIsValid = (txtPlayerName.Text.Length >= 3);

            btnStartNewGame.Enabled = playerNameIsValid;
            btnGoComputer.Enabled = playerNameIsValid;
            tableLayoutPanel1.Enabled = playerNameIsValid;
        }

        private void txtPlayerName_Validated(object sender, EventArgs e)
        {
            // when the focus leaves the text box, this event is triggered
        }

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            _ticTacToeGame.ResetGrid();

            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is GameCell gameCell)
                {
                    gameCell.GameCellOwner = CellOwners.Open;
                }
            }
        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            if (_ticTacToeGame.Winner != CellOwners.Open) return;

            _ticTacToeGame.AutoPlayComputer();

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show("The Winner!");
            }
        }

        private void CellOwnerChangedHandler(object sender, Middle_Tier.TicTacToeGame.CellOwnerChangedArgs e)
        {
            foreach (var control in tableLayoutPanel1.Controls)
            {
                if (control is GameCell gameCell)
                {
                    if (gameCell.GameCellRow == e.RowID &&
                        gameCell.GameCellCol == e.ColID)
                    {
                        gameCell.GameCellOwner = e.CellOwner;
                    }
                }
            }
        }

        private void gameCell_CellOwnerChanged(object sender)
        {
            if (_ticTacToeGame.Winner != CellOwners.Open) return;

            var gameCell = sender as GameCell;

            _ticTacToeGame.AssignCellOwner(gameCell.GameCellRow, gameCell.GameCellCol, CellOwners.Human);

            if (_ticTacToeGame.CheckForWinner())
            {
                MessageBox.Show("The Winner!");
            }
        }
    }
}
