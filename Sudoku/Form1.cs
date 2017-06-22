﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bHow_Play_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sudoku is played on 9x9 board divided into 3x3 smaller areas. " +
                "At the beginning of the game some of the Sudoku board boxes are already filled with numbers. " +
                "The object of the game is to complete the remaining board areas with numbers from 1 to 9 (one digit in each field)," +
                " with the following rules: \n" +
                "1. Each digit can only appear once per line. \n" +
                "2. Each digit can appear only once in each column. \n" +
                "3. Each digit can appear only once in each area 3x3. \n");
        }

        private System.Windows.Forms.Button bEasy;
        private System.Windows.Forms.Button bMedium;
        private System.Windows.Forms.Button bHard;

        private void bStart_Click(object sender, EventArgs e)
        {
            Form Levels = new Form();
            Levels.Size = new System.Drawing.Size(284, 361);
            Levels.Text = "Levels";
            Levels.MaximizeBox = false;
            this.bEasy = new Button()
            {
                Location = new System.Drawing.Point(65, 35),
                Size = new System.Drawing.Size(132,62),
                Name = "bEasy",
                TabIndex = 1,
                Text = "Easy",
                UseVisualStyleBackColor = true
            };
            Levels.Controls.Add(this.bEasy);
            this.bMedium = new Button()
            {
                Location = new System.Drawing.Point(65, 115),
                Size = new System.Drawing.Size(132,62),
                Name = "bMedium",
                TabIndex = 1,
                Text = "Medium",
                UseVisualStyleBackColor = true
            };
            Levels.Controls.Add(this.bMedium);
            this.bHard = new Button()
            {
                Location = new System.Drawing.Point(65, 195),
                Size = new System.Drawing.Size(132, 62),
                Name = "bHard",
                TabIndex = 1,
                Text = "Hard",
                UseVisualStyleBackColor = true
            };
            Levels.Controls.Add(this.bHard);
            Levels.ShowDialog();
        }
    }
}