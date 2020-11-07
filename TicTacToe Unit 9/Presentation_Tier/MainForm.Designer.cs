﻿namespace Presentation_Tier
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnStartNewGame = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnGoComputer = new System.Windows.Forms.Button();
            this.btnCell00 = new System.Windows.Forms.Button();
            this.btnCell01 = new System.Windows.Forms.Button();
            this.btnCell02 = new System.Windows.Forms.Button();
            this.btnCell10 = new System.Windows.Forms.Button();
            this.btnCell11 = new System.Windows.Forms.Button();
            this.btnCell12 = new System.Windows.Forms.Button();
            this.btnCell20 = new System.Windows.Forms.Button();
            this.btnCell21 = new System.Windows.Forms.Button();
            this.btnCell22 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 403);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit Tic Tac Toe";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 362);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(121, 35);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About Tic Tac Toe";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnStartNewGame
            // 
            this.btnStartNewGame.Location = new System.Drawing.Point(12, 41);
            this.btnStartNewGame.Name = "btnStartNewGame";
            this.btnStartNewGame.Size = new System.Drawing.Size(121, 35);
            this.btnStartNewGame.TabIndex = 0;
            this.btnStartNewGame.Text = "Start New Game";
            this.btnStartNewGame.UseVisualStyleBackColor = true;
            this.btnStartNewGame.Click += new System.EventHandler(this.btnStartNewGame_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(12, 12);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(261, 23);
            this.txtPlayerName.TabIndex = 1;
            this.txtPlayerName.Text = "Prof Reynolds";
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
            this.txtPlayerName.Validated += new System.EventHandler(this.txtPlayerName_Validated);
            // 
            // btnGoComputer
            // 
            this.btnGoComputer.Location = new System.Drawing.Point(12, 82);
            this.btnGoComputer.Name = "btnGoComputer";
            this.btnGoComputer.Size = new System.Drawing.Size(121, 35);
            this.btnGoComputer.TabIndex = 0;
            this.btnGoComputer.Text = "GO! Computer";
            this.btnGoComputer.UseVisualStyleBackColor = true;
            this.btnGoComputer.Click += new System.EventHandler(this.btnGoComputer_Click);
            // 
            // btnCell00
            // 
            this.btnCell00.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell00.Location = new System.Drawing.Point(13, 15);
            this.btnCell00.Name = "btnCell00";
            this.btnCell00.Size = new System.Drawing.Size(94, 94);
            this.btnCell00.TabIndex = 2;
            this.btnCell00.Text = "?";
            this.btnCell00.UseVisualStyleBackColor = true;
            this.btnCell00.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell01
            // 
            this.btnCell01.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell01.Location = new System.Drawing.Point(113, 15);
            this.btnCell01.Name = "btnCell01";
            this.btnCell01.Size = new System.Drawing.Size(94, 94);
            this.btnCell01.TabIndex = 2;
            this.btnCell01.Text = "?";
            this.btnCell01.UseVisualStyleBackColor = true;
            this.btnCell01.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell02
            // 
            this.btnCell02.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell02.Location = new System.Drawing.Point(213, 15);
            this.btnCell02.Name = "btnCell02";
            this.btnCell02.Size = new System.Drawing.Size(94, 94);
            this.btnCell02.TabIndex = 2;
            this.btnCell02.Text = "?";
            this.btnCell02.UseVisualStyleBackColor = true;
            this.btnCell02.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell10
            // 
            this.btnCell10.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell10.Location = new System.Drawing.Point(13, 115);
            this.btnCell10.Name = "btnCell10";
            this.btnCell10.Size = new System.Drawing.Size(94, 94);
            this.btnCell10.TabIndex = 2;
            this.btnCell10.Text = "?";
            this.btnCell10.UseVisualStyleBackColor = true;
            this.btnCell10.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell11
            // 
            this.btnCell11.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell11.Location = new System.Drawing.Point(113, 115);
            this.btnCell11.Name = "btnCell11";
            this.btnCell11.Size = new System.Drawing.Size(94, 94);
            this.btnCell11.TabIndex = 2;
            this.btnCell11.Text = "?";
            this.btnCell11.UseVisualStyleBackColor = true;
            this.btnCell11.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell12
            // 
            this.btnCell12.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell12.Location = new System.Drawing.Point(213, 115);
            this.btnCell12.Name = "btnCell12";
            this.btnCell12.Size = new System.Drawing.Size(94, 94);
            this.btnCell12.TabIndex = 2;
            this.btnCell12.Text = "?";
            this.btnCell12.UseVisualStyleBackColor = true;
            this.btnCell12.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell20
            // 
            this.btnCell20.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell20.Location = new System.Drawing.Point(13, 215);
            this.btnCell20.Name = "btnCell20";
            this.btnCell20.Size = new System.Drawing.Size(94, 94);
            this.btnCell20.TabIndex = 2;
            this.btnCell20.Text = "?";
            this.btnCell20.UseVisualStyleBackColor = true;
            this.btnCell20.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell21
            // 
            this.btnCell21.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell21.Location = new System.Drawing.Point(113, 215);
            this.btnCell21.Name = "btnCell21";
            this.btnCell21.Size = new System.Drawing.Size(94, 94);
            this.btnCell21.TabIndex = 2;
            this.btnCell21.Text = "?";
            this.btnCell21.UseVisualStyleBackColor = true;
            this.btnCell21.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // btnCell22
            // 
            this.btnCell22.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell22.Location = new System.Drawing.Point(213, 215);
            this.btnCell22.Name = "btnCell22";
            this.btnCell22.Size = new System.Drawing.Size(94, 94);
            this.btnCell22.TabIndex = 2;
            this.btnCell22.Text = "?";
            this.btnCell22.UseVisualStyleBackColor = true;
            this.btnCell22.Click += new System.EventHandler(this.btnCellxx_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCell00);
            this.panel1.Controls.Add(this.btnCell22);
            this.panel1.Controls.Add(this.btnCell01);
            this.panel1.Controls.Add(this.btnCell21);
            this.panel1.Controls.Add(this.btnCell02);
            this.panel1.Controls.Add(this.btnCell20);
            this.panel1.Controls.Add(this.btnCell10);
            this.panel1.Controls.Add(this.btnCell12);
            this.panel1.Controls.Add(this.btnCell11);
            this.panel1.Location = new System.Drawing.Point(224, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 321);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGoComputer);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnStartNewGame);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Tic Tac Toe CSharp Version - Prof Reynolds";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnStartNewGame;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnGoComputer;
        private System.Windows.Forms.Button btnCell00;
        private System.Windows.Forms.Button btnCell01;
        private System.Windows.Forms.Button btnCell02;
        private System.Windows.Forms.Button btnCell10;
        private System.Windows.Forms.Button btnCell11;
        private System.Windows.Forms.Button btnCell12;
        private System.Windows.Forms.Button btnCell20;
        private System.Windows.Forms.Button btnCell21;
        private System.Windows.Forms.Button btnCell22;
        private System.Windows.Forms.Panel panel1;
    }
}

