using System;
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

        public TextBox[] Sudoku_board;
        private Button bEasy;
        private Button bMedium;
        private Button bHard;
        private Button bNew_Game;
        private Button bCheck;
        private Button bClear;
        private Button bSolve;
        private Button bHighlight;
        private TextBox txHighlight;
        private GroupBox GroupBox1;
        
        private void bStart_Click(object sender, EventArgs e)
        {
            Form Levels = new Form();
            Levels.Size = new Size(284, 361);
            Levels.Text = "Levels";
            Levels.MaximizeBox = false;
            this.bEasy = new Button()
            {
                Location = new Point(65, 35),
                Size = new Size(132,62),
                Name = "bEasy",
                TabIndex = 1,
                Text = "Easy",
                UseVisualStyleBackColor = true
            };
            Levels.Controls.Add(this.bEasy);
            this.bEasy.Click += new System.EventHandler(this.bEasy_Click);
            this.bMedium = new Button()
            {
                Location = new Point(65, 115),
                Size = new Size(132,62),
                Name = "bMedium",
                TabIndex = 1,
                Text = "Medium",
                UseVisualStyleBackColor = true
            };
            Levels.Controls.Add(this.bMedium);
            this.bMedium.Click += new System.EventHandler(this.bMedium_Click);
            this.bHard = new Button()
            {
                Location = new Point(65, 195),
                Size = new Size(132, 62),
                Name = "bHard",
                TabIndex = 1,
                Text = "Hard",
                UseVisualStyleBackColor = true
            };
            Levels.Controls.Add(this.bHard);
            this.bHard.Click += new System.EventHandler(this.bHard_Click);
            Levels.ShowDialog();
        }

        #region[TextBox'es]
        private TextBox field1;
        private TextBox field2;
        private TextBox field3;
        private TextBox field4;
        private TextBox field5;
        private TextBox field6;
        private TextBox field7;
        private TextBox field8;
        private TextBox field9;
        private TextBox field10;
        private TextBox field11;
        private TextBox field12;
        private TextBox field13;
        private TextBox field14;
        private TextBox field15;
        private TextBox field16;
        private TextBox field17;
        private TextBox field18;
        private TextBox field19;
        private TextBox field20;
        private TextBox field21;
        private TextBox field22;
        private TextBox field23;
        private TextBox field24;
        private TextBox field25;
        private TextBox field26;
        private TextBox field27;
        private TextBox field28;
        private TextBox field29;
        private TextBox field30;
        private TextBox field31;
        private TextBox field32;
        private TextBox field33;
        private TextBox field34;
        private TextBox field35;
        private TextBox field36;
        private TextBox field37;
        private TextBox field38;
        private TextBox field39;
        private TextBox field40;
        private TextBox field41;
        private TextBox field42;
        private TextBox field43;
        private TextBox field44;
        private TextBox field45;
        private TextBox field46;
        private TextBox field47;
        private TextBox field48;
        private TextBox field49;
        private TextBox field50;
        private TextBox field51;
        private TextBox field52;
        private TextBox field53;
        private TextBox field54;
        private TextBox field55;
        private TextBox field56;
        private TextBox field57;
        private TextBox field58;
        private TextBox field59;
        private TextBox field60;
        private TextBox field61;
        private TextBox field62;
        private TextBox field63;
        private TextBox field64;
        private TextBox field65;
        private TextBox field66;
        private TextBox field67;
        private TextBox field68;
        private TextBox field69;
        private TextBox field70;
        private TextBox field71;
        private TextBox field72;
        private TextBox field73;
        private TextBox field74;
        private TextBox field75;
        private TextBox field76;
        private TextBox field77;
        private TextBox field78;
        private TextBox field79;
        private TextBox field80;
        private TextBox field81;
        #endregion

        private void check_number(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "")
            {
                if ((sender as TextBox).Text[0] < '0' || (sender as TextBox).Text[0] > '9')
                {
                    MessageBox.Show("You can't write letters.");
                    (sender as TextBox).Clear();
                }
            }
        }

        private void bEasy_Click(object sender, EventArgs e)
        {
            Form Easy = new Form();
            Easy.Size = new Size(700, 500);
            Easy.Text = "Easy level";
            #region[Adding field's]
            this.field1 = new TextBox()
            {
                Location = new Point(24, 21),
                Multiline = true,
                Name = "field1",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 0,
                TextAlign = HorizontalAlignment.Center,
            };
            field1.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field1);
            this.field2 = new TextBox()
            {
                Location = new Point(64, 21),
                Multiline = true,
                Name = "field2",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 1,
                TextAlign = HorizontalAlignment.Center
            };
            field2.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field2);
            this.field3 = new TextBox()
            {
                Location = new Point(104, 21),
                Multiline = true,
                Name = "field3",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 2,
                TextAlign = HorizontalAlignment.Center
            };
            field3.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field3);
            this.field4 = new TextBox()
            {
                Location = new Point(164, 21),
                Multiline = true,
                Name = "field4",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 3,
                TextAlign = HorizontalAlignment.Center
            };
            field4.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field4);
            this.field5 = new TextBox()
            {
                Location = new Point(204, 21),
                Multiline = true,
                Name = "field5",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 4,
                TextAlign = HorizontalAlignment.Center
            };
            field5.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field5);
            this.field6 = new TextBox()
            {
                Location = new Point(244, 21),
                Multiline = true,
                Name = "field6",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 5,
                TextAlign = HorizontalAlignment.Center
            };
            field6.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field6);
            this.field7 = new TextBox()
            {
                Location = new Point(304, 21),
                Multiline = true,
                Name = "field7",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 6,
                TextAlign = HorizontalAlignment.Center
            };
            field7.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field7);
            this.field8 = new TextBox()
            {
                Location = new Point(344, 21),
                Multiline = true,
                Name = "field8",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 7,
                TextAlign = HorizontalAlignment.Center
            };
            field8.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field8);
            this.field9 = new TextBox()
            {
                Location = new Point(384, 21),
                Multiline = true,
                Name = "field9",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 8,
                TextAlign = HorizontalAlignment.Center
            };
            field9.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field9);
            this.field10 = new TextBox()
            {
                Location = new Point(24, 61),
                Multiline = true,
                Name = "field10",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 9,
                TextAlign = HorizontalAlignment.Center
            };
            field10.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field10);
            this.field11 = new TextBox()
            {
                Location = new Point(64, 61),
                Multiline = true,
                Name = "field11",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 10,
                TextAlign = HorizontalAlignment.Center
            };
            field11.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field11);
            this.field12 = new TextBox()
            {
                Location = new Point(104, 61),
                Multiline = true,
                Name = "field12",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 11,
                TextAlign = HorizontalAlignment.Center
            };
            field12.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field12);
            this.field13 = new TextBox()
            {
                Location = new Point(164, 61),
                Multiline = true,
                Name = "field13",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 12,
                TextAlign = HorizontalAlignment.Center
            };
            field13.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field13);
            this.field14 = new TextBox()
            {
                Location = new Point(204, 61),
                Multiline = true,
                Name = "field14",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 13,
                TextAlign = HorizontalAlignment.Center
            };
            field14.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field14);
            this.field15 = new TextBox()
            {
                Location = new Point(244, 61),
                Multiline = true,
                Name = "field15",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 14,
                TextAlign = HorizontalAlignment.Center
            };
            field15.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field15);
            this.field16 = new TextBox()
            {
                Location = new Point(304, 61),
                Multiline = true,
                Name = "field16",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 15,
                TextAlign = HorizontalAlignment.Center
            };
            field16.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field16);
            this.field17 = new TextBox()
            {
                Location = new Point(344, 61),
                Multiline = true,
                Name = "field17",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 16,
                TextAlign = HorizontalAlignment.Center
            };
            field17.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field17);
            this.field18 = new TextBox()
            {
                Location = new Point(384, 61),
                Multiline = true,
                Name = "field18",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 17,
                TextAlign = HorizontalAlignment.Center
            };
            field18.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field18);
            this.field19 = new TextBox()
            {
                Location = new Point(24, 101),
                Multiline = true,
                Name = "field19",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 18,
                TextAlign = HorizontalAlignment.Center
            };
            field19.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field19);
            this.field20 = new TextBox()
            {
                Location = new Point(64, 101),
                Multiline = true,
                Name = "field20",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 19,
                TextAlign = HorizontalAlignment.Center
            };
            field20.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field20);
            this.field21 = new TextBox()
            {
                Location = new Point(104, 101),
                Multiline = true,
                Name = "field21",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 20,
                TextAlign = HorizontalAlignment.Center
            };
            field21.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field21);
            this.field22 = new TextBox()
            {
                Location = new Point(164, 101),
                Multiline = true,
                Name = "field22",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 21,
                TextAlign = HorizontalAlignment.Center
            };
            field22.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field22);
            this.field23 = new TextBox()
            {
                Location = new Point(204, 101),
                Multiline = true,
                Name = "field23",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 22,
                TextAlign = HorizontalAlignment.Center
            };
            field23.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field23);
            this.field24 = new TextBox()
            {
                Location = new Point(244, 101),
                Multiline = true,
                Name = "field24",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 23,
                TextAlign = HorizontalAlignment.Center
            };
            field24.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field24);
            this.field25 = new TextBox()
            {
                Location = new Point(304, 101),
                Multiline = true,
                Name = "field25",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 24,
                TextAlign = HorizontalAlignment.Center
            };
            field25.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field25);
            this.field26 = new TextBox()
            {
                Location = new Point(344, 101),
                Multiline = true,
                Name = "field26",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 25,
                TextAlign = HorizontalAlignment.Center
            };
            field26.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field26);
            this.field27 = new TextBox()
            {
                Location = new Point(384, 101),
                Multiline = true,
                Name = "field27",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 26,
                TextAlign = HorizontalAlignment.Center
            };
            field27.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field27);
            this.field28 = new TextBox()
            {
                Location = new Point(24, 161),
                Multiline = true,
                Name = "field28",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 27,
                TextAlign = HorizontalAlignment.Center
            };
            field28.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field28);
            this.field29 = new TextBox()
            {
                Location = new Point(64, 161),
                Multiline = true,
                Name = "field29",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 28,
                TextAlign = HorizontalAlignment.Center
            };
            field29.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field29);
            this.field30 = new TextBox()
            {
                Location = new Point(104, 161),
                Multiline = true,
                Name = "field30",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 29,
                TextAlign = HorizontalAlignment.Center
            };
            field30.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field30);
            this.field31 = new TextBox()
            {
                Location = new Point(164, 161),
                Multiline = true,
                Name = "field31",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 30,
                TextAlign = HorizontalAlignment.Center
            };
            field31.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field31);
            this.field32 = new TextBox()
            {
                Location = new Point(204, 161),
                Multiline = true,
                Name = "field32",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 31,
                TextAlign = HorizontalAlignment.Center
            };
            field32.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field32);
            this.field33 = new TextBox()
            {
                Location = new Point(244, 161),
                Multiline = true,
                Name = "field33",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 32,
                TextAlign = HorizontalAlignment.Center
            };
            field33.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field33);
            this.field34 = new TextBox()
            {
                Location = new Point(304, 161),
                Multiline = true,
                Name = "field34",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 33,
                TextAlign = HorizontalAlignment.Center
            };
            field34.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field34);
            this.field35 = new TextBox()
            {
                Location = new Point(344, 161),
                Multiline = true,
                Name = "field35",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 34,
                TextAlign = HorizontalAlignment.Center
            };
            field35.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field35);
            this.field36 = new TextBox()
            {
                Location = new Point(384, 161),
                Multiline = true,
                Name = "field36",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 35,
                TextAlign = HorizontalAlignment.Center
            };
            field36.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field36);
            this.field37 = new TextBox()
            {
                Location = new Point(24, 201),
                Multiline = true,
                Name = "field37",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 36,
                TextAlign = HorizontalAlignment.Center
            };
            field37.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field37);
            this.field38 = new TextBox()
            {
                Location = new Point(64, 201),
                Multiline = true,
                Name = "field38",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 37,
                TextAlign = HorizontalAlignment.Center
            };
            field38.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field38);
            this.field39 = new TextBox()
            {
                Location = new Point(104, 201),
                Multiline = true,
                Name = "field39",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 38,
                TextAlign = HorizontalAlignment.Center
            };
            field39.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field39);
            this.field40 = new TextBox()
            {
                Location = new Point(164, 201),
                Multiline = true,
                Name = "field40",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 39,
                TextAlign = HorizontalAlignment.Center
            };
            field40.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field40);
            this.field41 = new TextBox()
            {
                Location = new Point(204, 201),
                Multiline = true,
                Name = "field41",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 40,
                TextAlign = HorizontalAlignment.Center
            };
            field41.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field41);
            this.field42 = new TextBox()
            {
                Location = new Point(244, 201),
                Multiline = true,
                Name = "field42",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 41,
                TextAlign = HorizontalAlignment.Center
            };
            field42.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field42);
            this.field43 = new TextBox()
            {
                Location = new Point(304, 201),
                Multiline = true,
                Name = "field43",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 42,
                TextAlign = HorizontalAlignment.Center
            };
            field43.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field43);
            this.field44 = new TextBox()
            {
                Location = new Point(344, 201),
                Multiline = true,
                Name = "field44",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 43,
                TextAlign = HorizontalAlignment.Center
            };
            field44.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field44);
            this.field45 = new TextBox()
            {
                Location = new Point(384, 201),
                Multiline = true,
                Name = "field45",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 44,
                TextAlign = HorizontalAlignment.Center
            };
            field45.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field45);
            this.field46 = new TextBox()
            {
                Location = new Point(24, 241),
                Multiline = true,
                Name = "field46",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 45,
                TextAlign = HorizontalAlignment.Center
            };
            field46.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field46);
            this.field47 = new TextBox()
            {
                Location = new Point(64, 241),
                Multiline = true,
                Name = "field47",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 46,
                TextAlign = HorizontalAlignment.Center
            };
            field47.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field47);
            this.field48 = new TextBox()
            {
                Location = new Point(104, 241),
                Multiline = true,
                Name = "field48",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 47,
                TextAlign = HorizontalAlignment.Center
            };
            field48.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field48);
            this.field49 = new TextBox()
            {
                Location = new Point(164, 241),
                Multiline = true,
                Name = "field49",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 48,
                TextAlign = HorizontalAlignment.Center
            };
            field49.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field49);
            this.field50 = new TextBox()
            {
                Location = new Point(204, 241),
                Multiline = true,
                Name = "field50",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 49,
                TextAlign = HorizontalAlignment.Center
            };
            field50.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field50);
            this.field51 = new TextBox()
            {
                Location = new Point(244, 241),
                Multiline = true,
                Name = "field51",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 50,
                TextAlign = HorizontalAlignment.Center
            };
            field51.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field51);
            this.field52 = new TextBox()
            {
                Location = new Point(304, 241),
                Multiline = true,
                Name = "field52",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 51,
                TextAlign = HorizontalAlignment.Center
            };
            field52.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field52);
            this.field53 = new TextBox()
            {
                Location = new Point(344, 241),
                Multiline = true,
                Name = "field53",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 52,
                TextAlign = HorizontalAlignment.Center
            };
            field53.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field53);
            this.field54 = new TextBox()
            {
                Location = new Point(384, 241),
                Multiline = true,
                Name = "field54",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 53,
                TextAlign = HorizontalAlignment.Center
            };
            field54.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field54);
            this.field55 = new TextBox()
            {
                Location = new Point(24, 301),
                Multiline = true,
                Name = "field55",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 54,
                TextAlign = HorizontalAlignment.Center
            };
            field55.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field55);
            this.field56 = new TextBox()
            {
                Location = new Point(64, 301),
                Multiline = true,
                Name = "field56",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 55,
                TextAlign = HorizontalAlignment.Center
            };
            field56.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field56);
            this.field57 = new TextBox()
            {
                Location = new Point(104, 301),
                Multiline = true,
                Name = "field57",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 56,
                TextAlign = HorizontalAlignment.Center
            };
            field57.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field57);
            this.field58 = new TextBox()
            {
                Location = new Point(164, 301),
                Multiline = true,
                Name = "field58",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 57,
                TextAlign = HorizontalAlignment.Center
            };
            field58.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field58);
            this.field59 = new TextBox()
            {
                Location = new Point(204, 301),
                Multiline = true,
                Name = "field59",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 58,
                TextAlign = HorizontalAlignment.Center
            };
            field59.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field59);
            this.field60 = new TextBox()
            {
                Location = new Point(244, 301),
                Multiline = true,
                Name = "field60",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 59,
                TextAlign = HorizontalAlignment.Center
            };
            field60.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field60);
            this.field61 = new TextBox()
            {
                Location = new Point(304, 301),
                Multiline = true,
                Name = "field61",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 60,
                TextAlign = HorizontalAlignment.Center
            };
            field61.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field61);
            this.field62 = new TextBox()
            {
                Location = new Point(344, 301),
                Multiline = true,
                Name = "field62",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 61,
                TextAlign = HorizontalAlignment.Center
            };
            field62.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field62);
            this.field63 = new TextBox()
            {
                Location = new Point(384, 301),
                Multiline = true,
                Name = "field63",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 62,
                TextAlign = HorizontalAlignment.Center
            };
            field63.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field63);
            this.field64 = new TextBox()
            {
                Location = new Point(24, 341),
                Multiline = true,
                Name = "field64",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 63,
                TextAlign = HorizontalAlignment.Center
            };
            field64.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field64);
            this.field65 = new TextBox()
            {
                Location = new Point(64, 341),
                Multiline = true,
                Name = "field65",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 64,
                TextAlign = HorizontalAlignment.Center
            };
            field65.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field65);
            this.field66 = new TextBox()
            {
                Location = new Point(104, 341),
                Multiline = true,
                Name = "field66",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 65,
                TextAlign = HorizontalAlignment.Center
            };
            field66.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field66);
            this.field67 = new TextBox()
            {
                Location = new Point(164, 341),
                Multiline = true,
                Name = "field67",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 66,
                TextAlign = HorizontalAlignment.Center
            };
            field67.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field67);
            this.field68 = new TextBox()
            {
                Location = new Point(204, 341),
                Multiline = true,
                Name = "field68",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 67,
                TextAlign = HorizontalAlignment.Center
            };
            field68.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field68);
            this.field69 = new TextBox()
            {
                Location = new Point(244, 341),
                Multiline = true,
                Name = "field69",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 68,
                TextAlign = HorizontalAlignment.Center
            };
            field69.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field69);
            this.field70 = new TextBox()
            {
                Location = new Point(304, 341),
                Multiline = true,
                Name = "field70",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 69,
                TextAlign = HorizontalAlignment.Center
            };
            field70.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field70);
            this.field71 = new TextBox()
            {
                Location = new Point(344, 341),
                Multiline = true,
                Name = "field71",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 70,
                TextAlign = HorizontalAlignment.Center
            };
            field71.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field71);
            this.field72 = new TextBox()
            {
                Location = new Point(384, 341),
                Multiline = true,
                Name = "field72",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 71,
                TextAlign = HorizontalAlignment.Center
            };
            field72.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field72);
            this.field73 = new TextBox()
            {
                Location = new Point(24, 381),
                Multiline = true,
                Name = "field73",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 72,
                TextAlign = HorizontalAlignment.Center
            };
            field73.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field73);
            this.field74 = new TextBox()
            {
                Location = new Point(64, 381),
                Multiline = true,
                Name = "field74",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 73,
                TextAlign = HorizontalAlignment.Center
            };
            field74.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field74);
            this.field75 = new TextBox()
            {
                Location = new Point(104, 381),
                Multiline = true,
                Name = "field75",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 74,
                TextAlign = HorizontalAlignment.Center
            };
            field75.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field75);
            this.field76 = new TextBox()
            {
                Location = new Point(164, 381),
                Multiline = true,
                Name = "field76",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 75,
                TextAlign = HorizontalAlignment.Center
            };
            field76.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field76);
            this.field77 = new TextBox()
            {
                Location = new Point(204, 381),
                Multiline = true,
                Name = "field77",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 76,
                TextAlign = HorizontalAlignment.Center
            };
            field77.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field77);
            this.field78 = new TextBox()
            {
                Location = new Point(244, 381),
                Multiline = true,
                Name = "field78",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 77,
                TextAlign = HorizontalAlignment.Center
            };
            field78.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field78);
            this.field79 = new TextBox()
            {
                Location = new Point(304, 381),
                Multiline = true,
                Name = "field79",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 78,
                TextAlign = HorizontalAlignment.Center
            };
            field79.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field79);
            this.field80 = new TextBox()
            {
                Location = new Point(344, 381),
                Multiline = true,
                Name = "field80",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 79,
                TextAlign = HorizontalAlignment.Center
            };
            field80.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field80);
            this.field81 = new TextBox()
            {
                Location = new Point(384, 381),
                Multiline = true,
                Name = "field81",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 80,
                TextAlign = HorizontalAlignment.Center
            };
            field81.TextChanged += new EventHandler(check_number);
            Easy.Controls.Add(this.field81);
            #endregion
            this.Sudoku_board = new TextBox[81];
            #region[table fields]
            Sudoku_board[0] = field1;
            Sudoku_board[1] = field2;
            Sudoku_board[2] = field3;
            Sudoku_board[3] = field4;
            Sudoku_board[4] = field5;
            Sudoku_board[5] = field6;
            Sudoku_board[6] = field7;
            Sudoku_board[7] = field8;
            Sudoku_board[8] = field9;
            Sudoku_board[9] = field10;
            Sudoku_board[10] = field11;
            Sudoku_board[11] = field12;
            Sudoku_board[12] = field13;
            Sudoku_board[13] = field14;
            Sudoku_board[14] = field15;
            Sudoku_board[15] = field16;
            Sudoku_board[16] = field17;
            Sudoku_board[17] = field18;
            Sudoku_board[18] = field19;
            Sudoku_board[19] = field20;
            Sudoku_board[20] = field21;
            Sudoku_board[21] = field22;
            Sudoku_board[22] = field23;
            Sudoku_board[23] = field24;
            Sudoku_board[24] = field25;
            Sudoku_board[25] = field26;
            Sudoku_board[26] = field27;
            Sudoku_board[27] = field28;
            Sudoku_board[28] = field29;
            Sudoku_board[29] = field30;
            Sudoku_board[30] = field31;
            Sudoku_board[31] = field32;
            Sudoku_board[32] = field33;
            Sudoku_board[33] = field34;
            Sudoku_board[34] = field35;
            Sudoku_board[35] = field36;
            Sudoku_board[36] = field37;
            Sudoku_board[37] = field38;
            Sudoku_board[38] = field39;
            Sudoku_board[39] = field40;
            Sudoku_board[40] = field41;
            Sudoku_board[41] = field42;
            Sudoku_board[42] = field43;
            Sudoku_board[43] = field44;
            Sudoku_board[44] = field45;
            Sudoku_board[45] = field46;
            Sudoku_board[46] = field47;
            Sudoku_board[47] = field48;
            Sudoku_board[48] = field49;
            Sudoku_board[49] = field50;
            Sudoku_board[50] = field51;
            Sudoku_board[51] = field52;
            Sudoku_board[52] = field53;
            Sudoku_board[53] = field54;
            Sudoku_board[54] = field55;
            Sudoku_board[55] = field56;
            Sudoku_board[56] = field57;
            Sudoku_board[57] = field58;
            Sudoku_board[58] = field59;
            Sudoku_board[59] = field60;
            Sudoku_board[60] = field61;
            Sudoku_board[61] = field62;
            Sudoku_board[62] = field63;
            Sudoku_board[63] = field64;
            Sudoku_board[64] = field65;
            Sudoku_board[65] = field66;
            Sudoku_board[66] = field67;
            Sudoku_board[67] = field68;
            Sudoku_board[68] = field69;
            Sudoku_board[69] = field70;
            Sudoku_board[70] = field71;
            Sudoku_board[71] = field72;
            Sudoku_board[72] = field73;
            Sudoku_board[73] = field74;
            Sudoku_board[74] = field75;
            Sudoku_board[75] = field76;
            Sudoku_board[76] = field77;
            Sudoku_board[77] = field78;
            Sudoku_board[78] = field79;
            Sudoku_board[79] = field80;
            Sudoku_board[80] = field81;
            #endregion
            this.GroupBox1 = new GroupBox()
            {
                BackColor = SystemColors.InactiveBorder,
                Size = new Size(450, 450),
                Name = "GroupBox1",
                TabIndex = 87,
                TabStop = false,
            };
            #region[GroupBox]
            GroupBox1.Controls.Add(this.field1);
            GroupBox1.Controls.Add(this.field2);
            GroupBox1.Controls.Add(this.field3);
            GroupBox1.Controls.Add(this.field4);
            GroupBox1.Controls.Add(this.field5);
            GroupBox1.Controls.Add(this.field6);
            GroupBox1.Controls.Add(this.field7);
            GroupBox1.Controls.Add(this.field8);
            GroupBox1.Controls.Add(this.field9);
            GroupBox1.Controls.Add(this.field10);
            GroupBox1.Controls.Add(this.field11);
            GroupBox1.Controls.Add(this.field12);
            GroupBox1.Controls.Add(this.field13);
            GroupBox1.Controls.Add(this.field14);
            GroupBox1.Controls.Add(this.field15);
            GroupBox1.Controls.Add(this.field16);
            GroupBox1.Controls.Add(this.field17);
            GroupBox1.Controls.Add(this.field18);
            GroupBox1.Controls.Add(this.field19);
            GroupBox1.Controls.Add(this.field20);
            GroupBox1.Controls.Add(this.field21);
            GroupBox1.Controls.Add(this.field22);
            GroupBox1.Controls.Add(this.field23);
            GroupBox1.Controls.Add(this.field24);
            GroupBox1.Controls.Add(this.field25);
            GroupBox1.Controls.Add(this.field26);
            GroupBox1.Controls.Add(this.field27);
            GroupBox1.Controls.Add(this.field28);
            GroupBox1.Controls.Add(this.field29);
            GroupBox1.Controls.Add(this.field30);
            GroupBox1.Controls.Add(this.field31);
            GroupBox1.Controls.Add(this.field32);
            GroupBox1.Controls.Add(this.field33);
            GroupBox1.Controls.Add(this.field34);
            GroupBox1.Controls.Add(this.field35);
            GroupBox1.Controls.Add(this.field36);
            GroupBox1.Controls.Add(this.field37);
            GroupBox1.Controls.Add(this.field38);
            GroupBox1.Controls.Add(this.field39);
            GroupBox1.Controls.Add(this.field40);
            GroupBox1.Controls.Add(this.field41);
            GroupBox1.Controls.Add(this.field42);
            GroupBox1.Controls.Add(this.field43);
            GroupBox1.Controls.Add(this.field44);
            GroupBox1.Controls.Add(this.field45);
            GroupBox1.Controls.Add(this.field46);
            GroupBox1.Controls.Add(this.field47);
            GroupBox1.Controls.Add(this.field48);
            GroupBox1.Controls.Add(this.field49);
            GroupBox1.Controls.Add(this.field50);
            GroupBox1.Controls.Add(this.field51);
            GroupBox1.Controls.Add(this.field52);
            GroupBox1.Controls.Add(this.field53);
            GroupBox1.Controls.Add(this.field54);
            GroupBox1.Controls.Add(this.field55);
            GroupBox1.Controls.Add(this.field56);
            GroupBox1.Controls.Add(this.field57);
            GroupBox1.Controls.Add(this.field58);
            GroupBox1.Controls.Add(this.field59);
            GroupBox1.Controls.Add(this.field60);
            GroupBox1.Controls.Add(this.field61);
            GroupBox1.Controls.Add(this.field62);
            GroupBox1.Controls.Add(this.field63);
            GroupBox1.Controls.Add(this.field64);
            GroupBox1.Controls.Add(this.field65);
            GroupBox1.Controls.Add(this.field66);
            GroupBox1.Controls.Add(this.field67);
            GroupBox1.Controls.Add(this.field68);
            GroupBox1.Controls.Add(this.field69);
            GroupBox1.Controls.Add(this.field70);
            GroupBox1.Controls.Add(this.field71);
            GroupBox1.Controls.Add(this.field72);
            GroupBox1.Controls.Add(this.field73);
            GroupBox1.Controls.Add(this.field74);
            GroupBox1.Controls.Add(this.field75);
            GroupBox1.Controls.Add(this.field76);
            GroupBox1.Controls.Add(this.field77);
            GroupBox1.Controls.Add(this.field78);
            GroupBox1.Controls.Add(this.field79);
            GroupBox1.Controls.Add(this.field80);
            GroupBox1.Controls.Add(this.field81);
            #endregion
            //this.GroupBox1.SuspendLayout();
            //this.SuspendLayout();
            Easy.Controls.Add(this.GroupBox1);
            #region[Adding other buttons]
            this.bNew_Game = new Button()
            {
                Location = new Point(497, 133),
                Name = "bNew_Game",
                Size = new Size(106, 30),
                TabIndex = 81,
                Text = "New Game",
                UseVisualStyleBackColor = true,
            };
            bNew_Game.Click += new EventHandler(this.bNew_Game_Click);
            Easy.Controls.Add(this.bNew_Game);
            this.bCheck = new Button()
            {
                Location = new Point(497, 173),
                Name = "bCheck",
                Size = new Size(106, 30),
                TabIndex = 82,
                Text = "Check",
                UseVisualStyleBackColor = true,
            };
            bCheck.Click += new EventHandler(this.bCheck_Click);
            Easy.Controls.Add(this.bCheck);
            this.bClear = new Button()
            {
                Location = new Point(497, 213),
                Name = "bClear",
                Size = new Size(106, 30),
                TabIndex = 83,
                Text = "Clear Board",
                UseVisualStyleBackColor = true,
            };
            bClear.Click += new EventHandler(this.bClear_Click);
            Easy.Controls.Add(this.bClear);
            this.bSolve = new Button()
            {
                Location = new Point(497, 253),
                Name = "bSolve",
                Size = new Size(106, 30),
                TabIndex = 84,
                Text = "Solve Sudoku",
                UseVisualStyleBackColor = true,
            };
            bSolve.Click += new EventHandler(this.bSolve_Click);
            Easy.Controls.Add(this.bSolve);
            this.bHighlight = new Button()
            {
                Location = new Point(497, 293),
                Name = "bHighlight",
                Size = new Size(106, 30),
                TabIndex = 85,
                Text = "Highlight",
                UseVisualStyleBackColor = true,
            };
            bHighlight.Click += new EventHandler(this.bHighlight_Click);
            Easy.Controls.Add(this.bHighlight);
            this.txHighlight = new TextBox()
            {
                Location = new Point(617, 298),
                MaxLength = 1,
                Name = "txHighlight",
                Size = new Size(30, 30),
                TabIndex = 86,
                Text = "1",
                TextAlign = HorizontalAlignment.Center,
            };
            Easy.Controls.Add(this.txHighlight);
            #endregion
            Easy.ShowDialog();
        }

        private void bMedium_Click(object sender, EventArgs e)
        {
            Form Medium = new Form();
            Medium.Size = new Size(700, 500);
            Medium.Text = "Medium level";
            #region[Adding field's]
            this.field1 = new TextBox()
            {
                Location = new Point(24, 21),
                Multiline = true,
                Name = "field1",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 0,
                TextAlign = HorizontalAlignment.Center
            };
            field1.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field1);
            this.field2 = new TextBox()
            {
                Location = new Point(64, 21),
                Multiline = true,
                Name = "field2",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 1,
                TextAlign = HorizontalAlignment.Center
            };
            field2.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field2);
            this.field3 = new TextBox()
            {
                Location = new Point(104, 21),
                Multiline = true,
                Name = "field3",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 2,
                TextAlign = HorizontalAlignment.Center
            };
            field3.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field3);
            this.field4 = new TextBox()
            {
                Location = new Point(164, 21),
                Multiline = true,
                Name = "field4",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 3,
                TextAlign = HorizontalAlignment.Center
            };
            field4.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field4);
            this.field5 = new TextBox()
            {
                Location = new Point(204, 21),
                Multiline = true,
                Name = "field5",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 4,
                TextAlign = HorizontalAlignment.Center
            };
            field5.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field5);
            this.field6 = new TextBox()
            {
                Location = new Point(244, 21),
                Multiline = true,
                Name = "field6",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 5,
                TextAlign = HorizontalAlignment.Center
            };
            field6.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field6);
            this.field7 = new TextBox()
            {
                Location = new Point(304, 21),
                Multiline = true,
                Name = "field7",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 6,
                TextAlign = HorizontalAlignment.Center
            };
            field7.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field7);
            this.field8 = new TextBox()
            {
                Location = new Point(344, 21),
                Multiline = true,
                Name = "field8",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 7,
                TextAlign = HorizontalAlignment.Center
            };
            field8.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field8);
            this.field9 = new TextBox()
            {
                Location = new Point(384, 21),
                Multiline = true,
                Name = "field9",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 8,
                TextAlign = HorizontalAlignment.Center
            };
            field9.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field9);
            this.field10 = new TextBox()
            {
                Location = new Point(24, 61),
                Multiline = true,
                Name = "field10",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 9,
                TextAlign = HorizontalAlignment.Center
            };
            field10.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field10);
            this.field11 = new TextBox()
            {
                Location = new Point(64, 61),
                Multiline = true,
                Name = "field11",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 10,
                TextAlign = HorizontalAlignment.Center
            };
            field11.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field11);
            this.field12 = new TextBox()
            {
                Location = new Point(104, 61),
                Multiline = true,
                Name = "field12",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 11,
                TextAlign = HorizontalAlignment.Center
            };
            field12.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field12);
            this.field13 = new TextBox()
            {
                Location = new Point(164, 61),
                Multiline = true,
                Name = "field13",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 12,
                TextAlign = HorizontalAlignment.Center
            };
            field13.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field13);
            this.field14 = new TextBox()
            {
                Location = new Point(204, 61),
                Multiline = true,
                Name = "field14",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 13,
                TextAlign = HorizontalAlignment.Center
            };
            field14.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field14);
            this.field15 = new TextBox()
            {
                Location = new Point(244, 61),
                Multiline = true,
                Name = "field15",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 14,
                TextAlign = HorizontalAlignment.Center
            };
            field15.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field15);
            this.field16 = new TextBox()
            {
                Location = new Point(304, 61),
                Multiline = true,
                Name = "field16",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 15,
                TextAlign = HorizontalAlignment.Center
            };
            field16.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field16);
            this.field17 = new TextBox()
            {
                Location = new Point(344, 61),
                Multiline = true,
                Name = "field17",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 16,
                TextAlign = HorizontalAlignment.Center
            };
            field17.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field17);
            this.field18 = new TextBox()
            {
                Location = new Point(384, 61),
                Multiline = true,
                Name = "field18",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 17,
                TextAlign = HorizontalAlignment.Center
            };
            field18.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field18);
            this.field19 = new TextBox()
            {
                Location = new Point(24, 101),
                Multiline = true,
                Name = "field19",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 18,
                TextAlign = HorizontalAlignment.Center
            };
            field19.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field19);
            this.field20 = new TextBox()
            {
                Location = new Point(64, 101),
                Multiline = true,
                Name = "field20",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 19,
                TextAlign = HorizontalAlignment.Center
            };
            field20.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field20);
            this.field21 = new TextBox()
            {
                Location = new Point(104, 101),
                Multiline = true,
                Name = "field21",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 20,
                TextAlign = HorizontalAlignment.Center
            };
            field21.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field21);
            this.field22 = new TextBox()
            {
                Location = new Point(164, 101),
                Multiline = true,
                Name = "field22",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 21,
                TextAlign = HorizontalAlignment.Center
            };
            field22.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field22);
            this.field23 = new TextBox()
            {
                Location = new Point(204, 101),
                Multiline = true,
                Name = "field23",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 22,
                TextAlign = HorizontalAlignment.Center
            };
            field23.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field23);
            this.field24 = new TextBox()
            {
                Location = new Point(244, 101),
                Multiline = true,
                Name = "field24",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 23,
                TextAlign = HorizontalAlignment.Center
            };
            field24.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field24);
            this.field25 = new TextBox()
            {
                Location = new Point(304, 101),
                Multiline = true,
                Name = "field25",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 24,
                TextAlign = HorizontalAlignment.Center
            };
            field25.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field25);
            this.field26 = new TextBox()
            {
                Location = new Point(344, 101),
                Multiline = true,
                Name = "field26",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 25,
                TextAlign = HorizontalAlignment.Center
            };
            field26.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field26);
            this.field27 = new TextBox()
            {
                Location = new Point(384, 101),
                Multiline = true,
                Name = "field27",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 26,
                TextAlign = HorizontalAlignment.Center
            };
            field27.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field27);
            this.field28 = new TextBox()
            {
                Location = new Point(24, 161),
                Multiline = true,
                Name = "field28",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 27,
                TextAlign = HorizontalAlignment.Center
            };
            field28.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field28);
            this.field29 = new TextBox()
            {
                Location = new Point(64, 161),
                Multiline = true,
                Name = "field29",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 28,
                TextAlign = HorizontalAlignment.Center
            };
            field29.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field29);
            this.field30 = new TextBox()
            {
                Location = new Point(104, 161),
                Multiline = true,
                Name = "field30",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 29,
                TextAlign = HorizontalAlignment.Center
            };
            field30.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field30);
            this.field31 = new TextBox()
            {
                Location = new Point(164, 161),
                Multiline = true,
                Name = "field31",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 30,
                TextAlign = HorizontalAlignment.Center
            };
            field31.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field31);
            this.field32 = new TextBox()
            {
                Location = new Point(204, 161),
                Multiline = true,
                Name = "field32",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 31,
                TextAlign = HorizontalAlignment.Center
            };
            field32.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field32);
            this.field33 = new TextBox()
            {
                Location = new Point(244, 161),
                Multiline = true,
                Name = "field33",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 32,
                TextAlign = HorizontalAlignment.Center
            };
            field33.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field33);
            this.field34 = new TextBox()
            {
                Location = new Point(304, 161),
                Multiline = true,
                Name = "field34",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 33,
                TextAlign = HorizontalAlignment.Center
            };
            field34.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field34);
            this.field35 = new TextBox()
            {
                Location = new Point(344, 161),
                Multiline = true,
                Name = "field35",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 34,
                TextAlign = HorizontalAlignment.Center
            };
            field35.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field35);
            this.field36 = new TextBox()
            {
                Location = new Point(384, 161),
                Multiline = true,
                Name = "field36",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 35,
                TextAlign = HorizontalAlignment.Center
            };
            field36.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field36);
            this.field37 = new TextBox()
            {
                Location = new Point(24, 201),
                Multiline = true,
                Name = "field37",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 36,
                TextAlign = HorizontalAlignment.Center
            };
            field37.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field37);
            this.field38 = new TextBox()
            {
                Location = new Point(64, 201),
                Multiline = true,
                Name = "field38",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 37,
                TextAlign = HorizontalAlignment.Center
            };
            field38.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field38);
            this.field39 = new TextBox()
            {
                Location = new Point(104, 201),
                Multiline = true,
                Name = "field39",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 38,
                TextAlign = HorizontalAlignment.Center
            };
            field39.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field39);
            this.field40 = new TextBox()
            {
                Location = new Point(164, 201),
                Multiline = true,
                Name = "field40",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 39,
                TextAlign = HorizontalAlignment.Center
            };
            field40.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field40);
            this.field41 = new TextBox()
            {
                Location = new Point(204, 201),
                Multiline = true,
                Name = "field41",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 40,
                TextAlign = HorizontalAlignment.Center
            };
            field41.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field41);
            this.field42 = new TextBox()
            {
                Location = new Point(244, 201),
                Multiline = true,
                Name = "field42",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 41,
                TextAlign = HorizontalAlignment.Center
            };
            field42.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field42);
            this.field43 = new TextBox()
            {
                Location = new Point(304, 201),
                Multiline = true,
                Name = "field43",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 42,
                TextAlign = HorizontalAlignment.Center
            };
            field43.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field43);
            this.field44 = new TextBox()
            {
                Location = new Point(344, 201),
                Multiline = true,
                Name = "field44",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 43,
                TextAlign = HorizontalAlignment.Center
            };
            field44.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field44);
            this.field45 = new TextBox()
            {
                Location = new Point(384, 201),
                Multiline = true,
                Name = "field45",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 44,
                TextAlign = HorizontalAlignment.Center
            };
            field45.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field45);
            this.field46 = new TextBox()
            {
                Location = new Point(24, 241),
                Multiline = true,
                Name = "field46",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 45,
                TextAlign = HorizontalAlignment.Center
            };
            field46.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field46);
            this.field47 = new TextBox()
            {
                Location = new Point(64, 241),
                Multiline = true,
                Name = "field47",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 46,
                TextAlign = HorizontalAlignment.Center
            };
            field47.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field47);
            this.field48 = new TextBox()
            {
                Location = new Point(104, 241),
                Multiline = true,
                Name = "field48",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 47,
                TextAlign = HorizontalAlignment.Center
            };
            field48.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field48);
            this.field49 = new TextBox()
            {
                Location = new Point(164, 241),
                Multiline = true,
                Name = "field49",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 48,
                TextAlign = HorizontalAlignment.Center
            };
            field49.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field49);
            this.field50 = new TextBox()
            {
                Location = new Point(204, 241),
                Multiline = true,
                Name = "field50",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 49,
                TextAlign = HorizontalAlignment.Center
            };
            field50.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field50);
            this.field51 = new TextBox()
            {
                Location = new Point(244, 241),
                Multiline = true,
                Name = "field51",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 50,
                TextAlign = HorizontalAlignment.Center
            };
            field51.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field51);
            this.field52 = new TextBox()
            {
                Location = new Point(304, 241),
                Multiline = true,
                Name = "field52",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 51,
                TextAlign = HorizontalAlignment.Center
            };
            field52.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field52);
            this.field53 = new TextBox()
            {
                Location = new Point(344, 241),
                Multiline = true,
                Name = "field53",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 52,
                TextAlign = HorizontalAlignment.Center
            };
            field53.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field53);
            this.field54 = new TextBox()
            {
                Location = new Point(384, 241),
                Multiline = true,
                Name = "field54",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 53,
                TextAlign = HorizontalAlignment.Center
            };
            field54.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field54);
            this.field55 = new TextBox()
            {
                Location = new Point(24, 301),
                Multiline = true,
                Name = "field55",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 54,
                TextAlign = HorizontalAlignment.Center
            };
            field55.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field55);
            this.field56 = new TextBox()
            {
                Location = new Point(64, 301),
                Multiline = true,
                Name = "field56",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 55,
                TextAlign = HorizontalAlignment.Center
            };
            field56.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field56);
            this.field57 = new TextBox()
            {
                Location = new Point(104, 301),
                Multiline = true,
                Name = "field57",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 56,
                TextAlign = HorizontalAlignment.Center
            };
            field57.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field57);
            this.field58 = new TextBox()
            {
                Location = new Point(164, 301),
                Multiline = true,
                Name = "field58",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 57,
                TextAlign = HorizontalAlignment.Center
            };
            field58.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field58);
            this.field59 = new TextBox()
            {
                Location = new Point(204, 301),
                Multiline = true,
                Name = "field59",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 58,
                TextAlign = HorizontalAlignment.Center
            };
            field59.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field59);
            this.field60 = new TextBox()
            {
                Location = new Point(244, 301),
                Multiline = true,
                Name = "field60",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 59,
                TextAlign = HorizontalAlignment.Center
            };
            field60.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field60);
            this.field61 = new TextBox()
            {
                Location = new Point(304, 301),
                Multiline = true,
                Name = "field61",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 60,
                TextAlign = HorizontalAlignment.Center
            };
            field61.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field61);
            this.field62 = new TextBox()
            {
                Location = new Point(344, 301),
                Multiline = true,
                Name = "field62",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 61,
                TextAlign = HorizontalAlignment.Center
            };
            field62.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field62);
            this.field63 = new TextBox()
            {
                Location = new Point(384, 301),
                Multiline = true,
                Name = "field63",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 62,
                TextAlign = HorizontalAlignment.Center
            };
            field63.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field63);
            this.field64 = new TextBox()
            {
                Location = new Point(24, 341),
                Multiline = true,
                Name = "field64",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 63,
                TextAlign = HorizontalAlignment.Center
            };
            field64.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field64);
            this.field65 = new TextBox()
            {
                Location = new Point(64, 341),
                Multiline = true,
                Name = "field65",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 64,
                TextAlign = HorizontalAlignment.Center
            };
            field65.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field65);
            this.field66 = new TextBox()
            {
                Location = new Point(104, 341),
                Multiline = true,
                Name = "field66",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 65,
                TextAlign = HorizontalAlignment.Center
            };
            field66.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field66);
            this.field67 = new TextBox()
            {
                Location = new Point(164, 341),
                Multiline = true,
                Name = "field67",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 66,
                TextAlign = HorizontalAlignment.Center
            };
            field67.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field67);
            this.field68 = new TextBox()
            {
                Location = new Point(204, 341),
                Multiline = true,
                Name = "field68",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 67,
                TextAlign = HorizontalAlignment.Center
            };
            field68.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field68);
            this.field69 = new TextBox()
            {
                Location = new Point(244, 341),
                Multiline = true,
                Name = "field69",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 68,
                TextAlign = HorizontalAlignment.Center
            };
            field69.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field69);
            this.field70 = new TextBox()
            {
                Location = new Point(304, 341),
                Multiline = true,
                Name = "field70",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 69,
                TextAlign = HorizontalAlignment.Center
            };
            field70.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field70);
            this.field71 = new TextBox()
            {
                Location = new Point(344, 341),
                Multiline = true,
                Name = "field71",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 70,
                TextAlign = HorizontalAlignment.Center
            };
            field71.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field71);
            this.field72 = new TextBox()
            {
                Location = new Point(384, 341),
                Multiline = true,
                Name = "field72",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 71,
                TextAlign = HorizontalAlignment.Center
            };
            field72.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field72);
            this.field73 = new TextBox()
            {
                Location = new Point(24, 381),
                Multiline = true,
                Name = "field73",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 72,
                TextAlign = HorizontalAlignment.Center
            };
            field73.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field73);
            this.field74 = new TextBox()
            {
                Location = new Point(64, 381),
                Multiline = true,
                Name = "field74",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 73,
                TextAlign = HorizontalAlignment.Center
            };
            field1.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field74);
            this.field75 = new TextBox()
            {
                Location = new Point(104, 381),
                Multiline = true,
                Name = "field75",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 74,
                TextAlign = HorizontalAlignment.Center
            };
            field75.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field75);
            this.field76 = new TextBox()
            {
                Location = new Point(164, 381),
                Multiline = true,
                Name = "field76",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 75,
                TextAlign = HorizontalAlignment.Center
            };
            field76.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field76);
            this.field77 = new TextBox()
            {
                Location = new Point(204, 381),
                Multiline = true,
                Name = "field77",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 76,
                TextAlign = HorizontalAlignment.Center
            };
            field77.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field77);
            this.field78 = new TextBox()
            {
                Location = new Point(244, 381),
                Multiline = true,
                Name = "field78",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 77,
                TextAlign = HorizontalAlignment.Center
            };
            field78.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field78);
            this.field79 = new TextBox()
            {
                Location = new Point(304, 381),
                Multiline = true,
                Name = "field79",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 78,
                TextAlign = HorizontalAlignment.Center
            };
            field79.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field79);
            this.field80 = new TextBox()
            {
                Location = new Point(344, 381),
                Multiline = true,
                Name = "field80",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 79,
                TextAlign = HorizontalAlignment.Center
            };
            field80.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field80);
            this.field81 = new TextBox()
            {
                Location = new Point(384, 381),
                Multiline = true,
                Name = "field81",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 80,
                TextAlign = HorizontalAlignment.Center
            };
            field81.TextChanged += new EventHandler(check_number);
            Medium.Controls.Add(this.field81);
            #endregion
            this.Sudoku_board = new TextBox[81];
            #region[table fields]
            Sudoku_board[0] = field1;
            Sudoku_board[1] = field2;
            Sudoku_board[2] = field3;
            Sudoku_board[3] = field4;
            Sudoku_board[4] = field5;
            Sudoku_board[5] = field6;
            Sudoku_board[6] = field7;
            Sudoku_board[7] = field8;
            Sudoku_board[8] = field9;
            Sudoku_board[9] = field10;
            Sudoku_board[10] = field11;
            Sudoku_board[11] = field12;
            Sudoku_board[12] = field13;
            Sudoku_board[13] = field14;
            Sudoku_board[14] = field15;
            Sudoku_board[15] = field16;
            Sudoku_board[16] = field17;
            Sudoku_board[17] = field18;
            Sudoku_board[18] = field19;
            Sudoku_board[19] = field20;
            Sudoku_board[20] = field21;
            Sudoku_board[21] = field22;
            Sudoku_board[22] = field23;
            Sudoku_board[23] = field24;
            Sudoku_board[24] = field25;
            Sudoku_board[25] = field26;
            Sudoku_board[26] = field27;
            Sudoku_board[27] = field28;
            Sudoku_board[28] = field29;
            Sudoku_board[29] = field30;
            Sudoku_board[30] = field31;
            Sudoku_board[31] = field32;
            Sudoku_board[32] = field33;
            Sudoku_board[33] = field34;
            Sudoku_board[34] = field35;
            Sudoku_board[35] = field36;
            Sudoku_board[36] = field37;
            Sudoku_board[37] = field38;
            Sudoku_board[38] = field39;
            Sudoku_board[39] = field40;
            Sudoku_board[40] = field41;
            Sudoku_board[41] = field42;
            Sudoku_board[42] = field43;
            Sudoku_board[43] = field44;
            Sudoku_board[44] = field45;
            Sudoku_board[45] = field46;
            Sudoku_board[46] = field47;
            Sudoku_board[47] = field48;
            Sudoku_board[48] = field49;
            Sudoku_board[49] = field50;
            Sudoku_board[50] = field51;
            Sudoku_board[51] = field52;
            Sudoku_board[52] = field53;
            Sudoku_board[53] = field54;
            Sudoku_board[54] = field55;
            Sudoku_board[55] = field56;
            Sudoku_board[56] = field57;
            Sudoku_board[57] = field58;
            Sudoku_board[58] = field59;
            Sudoku_board[59] = field60;
            Sudoku_board[60] = field61;
            Sudoku_board[61] = field62;
            Sudoku_board[62] = field63;
            Sudoku_board[63] = field64;
            Sudoku_board[64] = field65;
            Sudoku_board[65] = field66;
            Sudoku_board[66] = field67;
            Sudoku_board[67] = field68;
            Sudoku_board[68] = field69;
            Sudoku_board[69] = field70;
            Sudoku_board[70] = field71;
            Sudoku_board[71] = field72;
            Sudoku_board[72] = field73;
            Sudoku_board[73] = field74;
            Sudoku_board[74] = field75;
            Sudoku_board[75] = field76;
            Sudoku_board[76] = field77;
            Sudoku_board[77] = field78;
            Sudoku_board[78] = field79;
            Sudoku_board[79] = field80;
            Sudoku_board[80] = field81;
            #endregion
            this.GroupBox1 = new GroupBox()
            {
                BackColor = SystemColors.InactiveBorder,
                Size = new Size(450, 450),
                Name = "GroupBox1",
                TabIndex = 87,
                TabStop = false,
            };
            #region[GroupBox]
            GroupBox1.Controls.Add(this.field1);
            GroupBox1.Controls.Add(this.field2);
            GroupBox1.Controls.Add(this.field3);
            GroupBox1.Controls.Add(this.field4);
            GroupBox1.Controls.Add(this.field5);
            GroupBox1.Controls.Add(this.field6);
            GroupBox1.Controls.Add(this.field7);
            GroupBox1.Controls.Add(this.field8);
            GroupBox1.Controls.Add(this.field9);
            GroupBox1.Controls.Add(this.field10);
            GroupBox1.Controls.Add(this.field11);
            GroupBox1.Controls.Add(this.field12);
            GroupBox1.Controls.Add(this.field13);
            GroupBox1.Controls.Add(this.field14);
            GroupBox1.Controls.Add(this.field15);
            GroupBox1.Controls.Add(this.field16);
            GroupBox1.Controls.Add(this.field17);
            GroupBox1.Controls.Add(this.field18);
            GroupBox1.Controls.Add(this.field19);
            GroupBox1.Controls.Add(this.field20);
            GroupBox1.Controls.Add(this.field21);
            GroupBox1.Controls.Add(this.field22);
            GroupBox1.Controls.Add(this.field23);
            GroupBox1.Controls.Add(this.field24);
            GroupBox1.Controls.Add(this.field25);
            GroupBox1.Controls.Add(this.field26);
            GroupBox1.Controls.Add(this.field27);
            GroupBox1.Controls.Add(this.field28);
            GroupBox1.Controls.Add(this.field29);
            GroupBox1.Controls.Add(this.field30);
            GroupBox1.Controls.Add(this.field31);
            GroupBox1.Controls.Add(this.field32);
            GroupBox1.Controls.Add(this.field33);
            GroupBox1.Controls.Add(this.field34);
            GroupBox1.Controls.Add(this.field35);
            GroupBox1.Controls.Add(this.field36);
            GroupBox1.Controls.Add(this.field37);
            GroupBox1.Controls.Add(this.field38);
            GroupBox1.Controls.Add(this.field39);
            GroupBox1.Controls.Add(this.field40);
            GroupBox1.Controls.Add(this.field41);
            GroupBox1.Controls.Add(this.field42);
            GroupBox1.Controls.Add(this.field43);
            GroupBox1.Controls.Add(this.field44);
            GroupBox1.Controls.Add(this.field45);
            GroupBox1.Controls.Add(this.field46);
            GroupBox1.Controls.Add(this.field47);
            GroupBox1.Controls.Add(this.field48);
            GroupBox1.Controls.Add(this.field49);
            GroupBox1.Controls.Add(this.field50);
            GroupBox1.Controls.Add(this.field51);
            GroupBox1.Controls.Add(this.field52);
            GroupBox1.Controls.Add(this.field53);
            GroupBox1.Controls.Add(this.field54);
            GroupBox1.Controls.Add(this.field55);
            GroupBox1.Controls.Add(this.field56);
            GroupBox1.Controls.Add(this.field57);
            GroupBox1.Controls.Add(this.field58);
            GroupBox1.Controls.Add(this.field59);
            GroupBox1.Controls.Add(this.field60);
            GroupBox1.Controls.Add(this.field61);
            GroupBox1.Controls.Add(this.field62);
            GroupBox1.Controls.Add(this.field63);
            GroupBox1.Controls.Add(this.field64);
            GroupBox1.Controls.Add(this.field65);
            GroupBox1.Controls.Add(this.field66);
            GroupBox1.Controls.Add(this.field67);
            GroupBox1.Controls.Add(this.field68);
            GroupBox1.Controls.Add(this.field69);
            GroupBox1.Controls.Add(this.field70);
            GroupBox1.Controls.Add(this.field71);
            GroupBox1.Controls.Add(this.field72);
            GroupBox1.Controls.Add(this.field73);
            GroupBox1.Controls.Add(this.field74);
            GroupBox1.Controls.Add(this.field75);
            GroupBox1.Controls.Add(this.field76);
            GroupBox1.Controls.Add(this.field77);
            GroupBox1.Controls.Add(this.field78);
            GroupBox1.Controls.Add(this.field79);
            GroupBox1.Controls.Add(this.field80);
            GroupBox1.Controls.Add(this.field81);
            #endregion
            //this.GroupBox1.SuspendLayout();
            //this.SuspendLayout();
            Medium.Controls.Add(this.GroupBox1);
            #region[Adding other buttons]
            this.bNew_Game = new Button()
            {
                Location = new Point(497, 133),
                Name = "bNew_Game",
                Size = new Size(106, 30),
                TabIndex = 81,
                Text = "New Game",
                UseVisualStyleBackColor = true,
            };
            bNew_Game.Click += new EventHandler(this.bNew_Game_Click);
            Medium.Controls.Add(this.bNew_Game);
            this.bCheck = new Button()
            {
                Location = new Point(497, 173),
                Name = "bCheck",
                Size = new Size(106, 30),
                TabIndex = 82,
                Text = "Check",
                UseVisualStyleBackColor = true,
            };
            bCheck.Click += new EventHandler(this.bCheck_Click);
            Medium.Controls.Add(this.bCheck);
            this.bClear = new Button()
            {
                Location = new Point(497, 213),
                Name = "bClear",
                Size = new Size(106, 30),
                TabIndex = 83,
                Text = "Clear Board",
                UseVisualStyleBackColor = true,
            };
            bClear.Click += new EventHandler(this.bClear_Click);
            Medium.Controls.Add(this.bClear);
            this.bSolve = new Button()
            {
                Location = new Point(497, 253),
                Name = "bSolve",
                Size = new Size(106, 30),
                TabIndex = 84,
                Text = "Solve Sudoku",
                UseVisualStyleBackColor = true,
            };
            bSolve.Click += new EventHandler(this.bSolve_Click);
            Medium.Controls.Add(this.bSolve);
            this.bHighlight = new Button()
            {
                Location = new Point(497, 293),
                Name = "bHighlight",
                Size = new Size(106, 30),
                TabIndex = 85,
                Text = "Highlight",
                UseVisualStyleBackColor = true,
            };
            bHighlight.Click += new EventHandler(this.bHighlight_Click);
            Medium.Controls.Add(this.bHighlight);
            this.txHighlight = new TextBox()
            {
                Location = new Point(617, 298),
                MaxLength = 1,
                Name = "txHighlight",
                Size = new Size(30, 30),
                TabIndex = 86,
                Text = "1",
                TextAlign = HorizontalAlignment.Center,
            };
            Medium.Controls.Add(this.txHighlight);
            #endregion
            Medium.ShowDialog();
        }

        private void bHard_Click(object sender, EventArgs e)
        {
            Form Hard = new Form();
            Hard.Size = new Size(700, 500);
            Hard.Text = "Hard level";
            #region[Adding field's]
            this.field1 = new TextBox()
            {
                Location = new Point(24, 21),
                Multiline = true,
                Name = "field1",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 0,
                TextAlign = HorizontalAlignment.Center
            };
            field1.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field1);
            this.field2 = new TextBox()
            {
                Location = new Point(64, 21),
                Multiline = true,
                Name = "field2",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 1,
                TextAlign = HorizontalAlignment.Center
            };
            field2.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field2);
            this.field3 = new TextBox()
            {
                Location = new Point(104, 21),
                Multiline = true,
                Name = "field3",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 2,
                TextAlign = HorizontalAlignment.Center
            };
            field3.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field3);
            this.field4 = new TextBox()
            {
                Location = new Point(164, 21),
                Multiline = true,
                Name = "field4",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 3,
                TextAlign = HorizontalAlignment.Center
            };
            field4.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field4);
            this.field5 = new TextBox()
            {
                Location = new Point(204, 21),
                Multiline = true,
                Name = "field5",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 4,
                TextAlign = HorizontalAlignment.Center
            };
            field5.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field5);
            this.field6 = new TextBox()
            {
                Location = new Point(244, 21),
                Multiline = true,
                Name = "field6",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 5,
                TextAlign = HorizontalAlignment.Center
            };
            field6.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field6);
            this.field7 = new TextBox()
            {
                Location = new Point(304, 21),
                Multiline = true,
                Name = "field7",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 6,
                TextAlign = HorizontalAlignment.Center
            };
            field7.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field7);
            this.field8 = new TextBox()
            {
                Location = new Point(344, 21),
                Multiline = true,
                Name = "field8",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 7,
                TextAlign = HorizontalAlignment.Center
            };
            field8.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field8);
            this.field9 = new TextBox()
            {
                Location = new Point(384, 21),
                Multiline = true,
                Name = "field9",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 8,
                TextAlign = HorizontalAlignment.Center
            };
            field9.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field9);
            this.field10 = new TextBox()
            {
                Location = new Point(24, 61),
                Multiline = true,
                Name = "field10",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 9,
                TextAlign = HorizontalAlignment.Center
            };
            field10.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field10);
            this.field11 = new TextBox()
            {
                Location = new Point(64, 61),
                Multiline = true,
                Name = "field11",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 10,
                TextAlign = HorizontalAlignment.Center
            };
            field11.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field11);
            this.field12 = new TextBox()
            {
                Location = new Point(104, 61),
                Multiline = true,
                Name = "field12",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 11,
                TextAlign = HorizontalAlignment.Center
            };
            field12.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field12);
            this.field13 = new TextBox()
            {
                Location = new Point(164, 61),
                Multiline = true,
                Name = "field13",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 12,
                TextAlign = HorizontalAlignment.Center
            };
            field13.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field13);
            this.field14 = new TextBox()
            {
                Location = new Point(204, 61),
                Multiline = true,
                Name = "field14",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 13,
                TextAlign = HorizontalAlignment.Center
            };
            field14.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field14);
            this.field15 = new TextBox()
            {
                Location = new Point(244, 61),
                Multiline = true,
                Name = "field15",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 14,
                TextAlign = HorizontalAlignment.Center
            };
            field15.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field15);
            this.field16 = new TextBox()
            {
                Location = new Point(304, 61),
                Multiline = true,
                Name = "field16",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 15,
                TextAlign = HorizontalAlignment.Center
            };
            field16.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field16);
            this.field17 = new TextBox()
            {
                Location = new Point(344, 61),
                Multiline = true,
                Name = "field17",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 16,
                TextAlign = HorizontalAlignment.Center
            };
            field17.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field17);
            this.field18 = new TextBox()
            {
                Location = new Point(384, 61),
                Multiline = true,
                Name = "field18",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 17,
                TextAlign = HorizontalAlignment.Center
            };
            field18.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field18);
            this.field19 = new TextBox()
            {
                Location = new Point(24, 101),
                Multiline = true,
                Name = "field19",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 18,
                TextAlign = HorizontalAlignment.Center
            };
            field19.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field19);
            this.field20 = new TextBox()
            {
                Location = new Point(64, 101),
                Multiline = true,
                Name = "field20",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 19,
                TextAlign = HorizontalAlignment.Center
            };
            field20.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field20);
            this.field21 = new TextBox()
            {
                Location = new Point(104, 101),
                Multiline = true,
                Name = "field21",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 20,
                TextAlign = HorizontalAlignment.Center
            };
            field21.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field21);
            this.field22 = new TextBox()
            {
                Location = new Point(164, 101),
                Multiline = true,
                Name = "field22",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 21,
                TextAlign = HorizontalAlignment.Center
            };
            field22.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field22);
            this.field23 = new TextBox()
            {
                Location = new Point(204, 101),
                Multiline = true,
                Name = "field23",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 22,
                TextAlign = HorizontalAlignment.Center
            };
            field23.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field23);
            this.field24 = new TextBox()
            {
                Location = new Point(244, 101),
                Multiline = true,
                Name = "field24",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 23,
                TextAlign = HorizontalAlignment.Center
            };
            field24.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field24);
            this.field25 = new TextBox()
            {
                Location = new Point(304, 101),
                Multiline = true,
                Name = "field25",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 24,
                TextAlign = HorizontalAlignment.Center
            };
            field25.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field25);
            this.field26 = new TextBox()
            {
                Location = new Point(344, 101),
                Multiline = true,
                Name = "field26",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 25,
                TextAlign = HorizontalAlignment.Center
            };
            field26.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field26);
            this.field27 = new TextBox()
            {
                Location = new Point(384, 101),
                Multiline = true,
                Name = "field27",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 26,
                TextAlign = HorizontalAlignment.Center
            };
            field27.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field27);
            this.field28 = new TextBox()
            {
                Location = new Point(24, 161),
                Multiline = true,
                Name = "field28",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 27,
                TextAlign = HorizontalAlignment.Center
            };
            field28.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field28);
            this.field29 = new TextBox()
            {
                Location = new Point(64, 161),
                Multiline = true,
                Name = "field29",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 28,
                TextAlign = HorizontalAlignment.Center
            };
            field29.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field29);
            this.field30 = new TextBox()
            {
                Location = new Point(104, 161),
                Multiline = true,
                Name = "field30",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 29,
                TextAlign = HorizontalAlignment.Center
            };
            field30.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field30);
            this.field31 = new TextBox()
            {
                Location = new Point(164, 161),
                Multiline = true,
                Name = "field31",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 30,
                TextAlign = HorizontalAlignment.Center
            };
            field31.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field31);
            this.field32 = new TextBox()
            {
                Location = new Point(204, 161),
                Multiline = true,
                Name = "field32",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 31,
                TextAlign = HorizontalAlignment.Center
            };
            field32.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field32);
            this.field33 = new TextBox()
            {
                Location = new Point(244, 161),
                Multiline = true,
                Name = "field33",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 32,
                TextAlign = HorizontalAlignment.Center
            };
            field33.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field33);
            this.field34 = new TextBox()
            {
                Location = new Point(304, 161),
                Multiline = true,
                Name = "field34",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 33,
                TextAlign = HorizontalAlignment.Center
            };
            field34.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field34);
            this.field35 = new TextBox()
            {
                Location = new Point(344, 161),
                Multiline = true,
                Name = "field35",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 34,
                TextAlign = HorizontalAlignment.Center
            };
            field35.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field35);
            this.field36 = new TextBox()
            {
                Location = new Point(384, 161),
                Multiline = true,
                Name = "field36",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 35,
                TextAlign = HorizontalAlignment.Center
            };
            field36.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field36);
            this.field37 = new TextBox()
            {
                Location = new Point(24, 201),
                Multiline = true,
                Name = "field37",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 36,
                TextAlign = HorizontalAlignment.Center
            };
            field37.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field37);
            this.field38 = new TextBox()
            {
                Location = new Point(64, 201),
                Multiline = true,
                Name = "field38",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 37,
                TextAlign = HorizontalAlignment.Center
            };
            field38.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field38);
            this.field39 = new TextBox()
            {
                Location = new Point(104, 201),
                Multiline = true,
                Name = "field39",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 38,
                TextAlign = HorizontalAlignment.Center
            };
            field39.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field39);
            this.field40 = new TextBox()
            {
                Location = new Point(164, 201),
                Multiline = true,
                Name = "field40",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 39,
                TextAlign = HorizontalAlignment.Center
            };
            field40.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field40);
            this.field41 = new TextBox()
            {
                Location = new Point(204, 201),
                Multiline = true,
                Name = "field41",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 40,
                TextAlign = HorizontalAlignment.Center
            };
            field41.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field41);
            this.field42 = new TextBox()
            {
                Location = new Point(244, 201),
                Multiline = true,
                Name = "field42",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 41,
                TextAlign = HorizontalAlignment.Center
            };
            field42.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field42);
            this.field43 = new TextBox()
            {
                Location = new Point(304, 201),
                Multiline = true,
                Name = "field43",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 42,
                TextAlign = HorizontalAlignment.Center
            };
            field43.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field43);
            this.field44 = new TextBox()
            {
                Location = new Point(344, 201),
                Multiline = true,
                Name = "field44",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 43,
                TextAlign = HorizontalAlignment.Center
            };
            field44.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field44);
            this.field45 = new TextBox()
            {
                Location = new Point(384, 201),
                Multiline = true,
                Name = "field45",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 44,
                TextAlign = HorizontalAlignment.Center
            };
            field45.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field45);
            this.field46 = new TextBox()
            {
                Location = new Point(24, 241),
                Multiline = true,
                Name = "field46",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 45,
                TextAlign = HorizontalAlignment.Center
            };
            field46.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field46);
            this.field47 = new TextBox()
            {
                Location = new Point(64, 241),
                Multiline = true,
                Name = "field47",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 46,
                TextAlign = HorizontalAlignment.Center
            };
            field47.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field47);
            this.field48 = new TextBox()
            {
                Location = new Point(104, 241),
                Multiline = true,
                Name = "field48",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 47,
                TextAlign = HorizontalAlignment.Center
            };
            field48.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field48);
            this.field49 = new TextBox()
            {
                Location = new Point(164, 241),
                Multiline = true,
                Name = "field49",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 48,
                TextAlign = HorizontalAlignment.Center
            };
            field49.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field49);
            this.field50 = new TextBox()
            {
                Location = new Point(204, 241),
                Multiline = true,
                Name = "field50",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 49,
                TextAlign = HorizontalAlignment.Center
            };
            field50.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field50);
            this.field51 = new TextBox()
            {
                Location = new Point(244, 241),
                Multiline = true,
                Name = "field51",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 50,
                TextAlign = HorizontalAlignment.Center
            };
            field51.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field51);
            this.field52 = new TextBox()
            {
                Location = new Point(304, 241),
                Multiline = true,
                Name = "field52",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 51,
                TextAlign = HorizontalAlignment.Center
            };
            field52.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field52);
            this.field53 = new TextBox()
            {
                Location = new Point(344, 241),
                Multiline = true,
                Name = "field53",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 52,
                TextAlign = HorizontalAlignment.Center
            };
            field53.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field53);
            this.field54 = new TextBox()
            {
                Location = new Point(384, 241),
                Multiline = true,
                Name = "field54",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 53,
                TextAlign = HorizontalAlignment.Center
            };
            field54.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field54);
            this.field55 = new TextBox()
            {
                Location = new Point(24, 301),
                Multiline = true,
                Name = "field55",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 54,
                TextAlign = HorizontalAlignment.Center
            };
            field55.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field55);
            this.field56 = new TextBox()
            {
                Location = new Point(64, 301),
                Multiline = true,
                Name = "field56",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 55,
                TextAlign = HorizontalAlignment.Center
            };
            field56.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field56);
            this.field57 = new TextBox()
            {
                Location = new Point(104, 301),
                Multiline = true,
                Name = "field57",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 56,
                TextAlign = HorizontalAlignment.Center
            };
            field57.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field57);
            this.field58 = new TextBox()
            {
                Location = new Point(164, 301),
                Multiline = true,
                Name = "field58",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 57,
                TextAlign = HorizontalAlignment.Center
            };
            field58.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field58);
            this.field59 = new TextBox()
            {
                Location = new Point(204, 301),
                Multiline = true,
                Name = "field59",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 58,
                TextAlign = HorizontalAlignment.Center
            };
            field59.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field59);
            this.field60 = new TextBox()
            {
                Location = new Point(244, 301),
                Multiline = true,
                Name = "field60",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 59,
                TextAlign = HorizontalAlignment.Center
            };
            field60.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field60);
            this.field61 = new TextBox()
            {
                Location = new Point(304, 301),
                Multiline = true,
                Name = "field61",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 60,
                TextAlign = HorizontalAlignment.Center
            };
            field61.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field61);
            this.field62 = new TextBox()
            {
                Location = new Point(344, 301),
                Multiline = true,
                Name = "field62",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 61,
                TextAlign = HorizontalAlignment.Center
            };
            field62.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field62);
            this.field63 = new TextBox()
            {
                Location = new Point(384, 301),
                Multiline = true,
                Name = "field63",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 62,
                TextAlign = HorizontalAlignment.Center
            };
            field63.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field63);
            this.field64 = new TextBox()
            {
                Location = new Point(24, 341),
                Multiline = true,
                Name = "field64",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 63,
                TextAlign = HorizontalAlignment.Center
            };
            field64.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field64);
            this.field65 = new TextBox()
            {
                Location = new Point(64, 341),
                Multiline = true,
                Name = "field65",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 64,
                TextAlign = HorizontalAlignment.Center
            };
            field65.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field65);
            this.field66 = new TextBox()
            {
                Location = new Point(104, 341),
                Multiline = true,
                Name = "field66",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 65,
                TextAlign = HorizontalAlignment.Center
            };
            field66.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field66);
            this.field67 = new TextBox()
            {
                Location = new Point(164, 341),
                Multiline = true,
                Name = "field67",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 66,
                TextAlign = HorizontalAlignment.Center
            };
            field67.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field67);
            this.field68 = new TextBox()
            {
                Location = new Point(204, 341),
                Multiline = true,
                Name = "field68",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 67,
                TextAlign = HorizontalAlignment.Center
            };
            field68.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field68);
            this.field69 = new TextBox()
            {
                Location = new Point(244, 341),
                Multiline = true,
                Name = "field69",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 68,
                TextAlign = HorizontalAlignment.Center
            };
            field69.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field69);
            this.field70 = new TextBox()
            {
                Location = new Point(304, 341),
                Multiline = true,
                Name = "field70",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 69,
                TextAlign = HorizontalAlignment.Center
            };
            field70.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field70);
            this.field71 = new TextBox()
            {
                Location = new Point(344, 341),
                Multiline = true,
                Name = "field71",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 70,
                TextAlign = HorizontalAlignment.Center
            };
            field71.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field71);
            this.field72 = new TextBox()
            {
                Location = new Point(384, 341),
                Multiline = true,
                Name = "field72",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 71,
                TextAlign = HorizontalAlignment.Center
            };
            field72.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field72);
            this.field73 = new TextBox()
            {
                Location = new Point(24, 381),
                Multiline = true,
                Name = "field73",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 72,
                TextAlign = HorizontalAlignment.Center
            };
            field73.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field73);
            this.field74 = new TextBox()
            {
                Location = new Point(64, 381),
                Multiline = true,
                Name = "field74",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 73,
                TextAlign = HorizontalAlignment.Center
            };
            field74.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field74);
            this.field75 = new TextBox()
            {
                Location = new Point(104, 381),
                Multiline = true,
                Name = "field75",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 74,
                TextAlign = HorizontalAlignment.Center
            };
            field75.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field75);
            this.field76 = new TextBox()
            {
                Location = new Point(164, 381),
                Multiline = true,
                Name = "field76",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 75,
                TextAlign = HorizontalAlignment.Center
            };
            field76.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field76);
            this.field77 = new TextBox()
            {
                Location = new Point(204, 381),
                Multiline = true,
                Name = "field77",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 76,
                TextAlign = HorizontalAlignment.Center
            };
            field77.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field77);
            this.field78 = new TextBox()
            {
                Location = new Point(244, 381),
                Multiline = true,
                Name = "field78",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 77,
                TextAlign = HorizontalAlignment.Center
            };
            field78.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field78);
            this.field79 = new TextBox()
            {
                Location = new Point(304, 381),
                Multiline = true,
                Name = "field79",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 78,
                TextAlign = HorizontalAlignment.Center
            };
            field79.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field79);
            this.field80 = new TextBox()
            {
                Location = new Point(344, 381),
                Multiline = true,
                Name = "field80",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 79,
                TextAlign = HorizontalAlignment.Center
            };
            field80.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field80);
            this.field81 = new TextBox()
            {
                Location = new Point(384, 381),
                Multiline = true,
                Name = "field81",
                Size = new Size(32, 32),
                Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))),
                TabIndex = 80,
                TextAlign = HorizontalAlignment.Center
            };
            field81.TextChanged += new EventHandler(check_number);
            Hard.Controls.Add(this.field81);
            #endregion
            this.Sudoku_board = new TextBox[81];
            #region[table fields]
            Sudoku_board[0] = field1;
            Sudoku_board[1] = field2;
            Sudoku_board[2] = field3;
            Sudoku_board[3] = field4;
            Sudoku_board[4] = field5;
            Sudoku_board[5] = field6;
            Sudoku_board[6] = field7;
            Sudoku_board[7] = field8;
            Sudoku_board[8] = field9;
            Sudoku_board[9] = field10;
            Sudoku_board[10] = field11;
            Sudoku_board[11] = field12;
            Sudoku_board[12] = field13;
            Sudoku_board[13] = field14;
            Sudoku_board[14] = field15;
            Sudoku_board[15] = field16;
            Sudoku_board[16] = field17;
            Sudoku_board[17] = field18;
            Sudoku_board[18] = field19;
            Sudoku_board[19] = field20;
            Sudoku_board[20] = field21;
            Sudoku_board[21] = field22;
            Sudoku_board[22] = field23;
            Sudoku_board[23] = field24;
            Sudoku_board[24] = field25;
            Sudoku_board[25] = field26;
            Sudoku_board[26] = field27;
            Sudoku_board[27] = field28;
            Sudoku_board[28] = field29;
            Sudoku_board[29] = field30;
            Sudoku_board[30] = field31;
            Sudoku_board[31] = field32;
            Sudoku_board[32] = field33;
            Sudoku_board[33] = field34;
            Sudoku_board[34] = field35;
            Sudoku_board[35] = field36;
            Sudoku_board[36] = field37;
            Sudoku_board[37] = field38;
            Sudoku_board[38] = field39;
            Sudoku_board[39] = field40;
            Sudoku_board[40] = field41;
            Sudoku_board[41] = field42;
            Sudoku_board[42] = field43;
            Sudoku_board[43] = field44;
            Sudoku_board[44] = field45;
            Sudoku_board[45] = field46;
            Sudoku_board[46] = field47;
            Sudoku_board[47] = field48;
            Sudoku_board[48] = field49;
            Sudoku_board[49] = field50;
            Sudoku_board[50] = field51;
            Sudoku_board[51] = field52;
            Sudoku_board[52] = field53;
            Sudoku_board[53] = field54;
            Sudoku_board[54] = field55;
            Sudoku_board[55] = field56;
            Sudoku_board[56] = field57;
            Sudoku_board[57] = field58;
            Sudoku_board[58] = field59;
            Sudoku_board[59] = field60;
            Sudoku_board[60] = field61;
            Sudoku_board[61] = field62;
            Sudoku_board[62] = field63;
            Sudoku_board[63] = field64;
            Sudoku_board[64] = field65;
            Sudoku_board[65] = field66;
            Sudoku_board[66] = field67;
            Sudoku_board[67] = field68;
            Sudoku_board[68] = field69;
            Sudoku_board[69] = field70;
            Sudoku_board[70] = field71;
            Sudoku_board[71] = field72;
            Sudoku_board[72] = field73;
            Sudoku_board[73] = field74;
            Sudoku_board[74] = field75;
            Sudoku_board[75] = field76;
            Sudoku_board[76] = field77;
            Sudoku_board[77] = field78;
            Sudoku_board[78] = field79;
            Sudoku_board[79] = field80;
            Sudoku_board[80] = field81;
            #endregion
            this.GroupBox1 = new GroupBox()
            {
                BackColor = SystemColors.InactiveBorder,
                Size = new Size(450, 450),
                Name = "GroupBox1",
                TabIndex = 87,
                TabStop = false,
            };
            #region[GroupBox]
            GroupBox1.Controls.Add(this.field1);
            GroupBox1.Controls.Add(this.field2);
            GroupBox1.Controls.Add(this.field3);
            GroupBox1.Controls.Add(this.field4);
            GroupBox1.Controls.Add(this.field5);
            GroupBox1.Controls.Add(this.field6);
            GroupBox1.Controls.Add(this.field7);
            GroupBox1.Controls.Add(this.field8);
            GroupBox1.Controls.Add(this.field9);
            GroupBox1.Controls.Add(this.field10);
            GroupBox1.Controls.Add(this.field11);
            GroupBox1.Controls.Add(this.field12);
            GroupBox1.Controls.Add(this.field13);
            GroupBox1.Controls.Add(this.field14);
            GroupBox1.Controls.Add(this.field15);
            GroupBox1.Controls.Add(this.field16);
            GroupBox1.Controls.Add(this.field17);
            GroupBox1.Controls.Add(this.field18);
            GroupBox1.Controls.Add(this.field19);
            GroupBox1.Controls.Add(this.field20);
            GroupBox1.Controls.Add(this.field21);
            GroupBox1.Controls.Add(this.field22);
            GroupBox1.Controls.Add(this.field23);
            GroupBox1.Controls.Add(this.field24);
            GroupBox1.Controls.Add(this.field25);
            GroupBox1.Controls.Add(this.field26);
            GroupBox1.Controls.Add(this.field27);
            GroupBox1.Controls.Add(this.field28);
            GroupBox1.Controls.Add(this.field29);
            GroupBox1.Controls.Add(this.field30);
            GroupBox1.Controls.Add(this.field31);
            GroupBox1.Controls.Add(this.field32);
            GroupBox1.Controls.Add(this.field33);
            GroupBox1.Controls.Add(this.field34);
            GroupBox1.Controls.Add(this.field35);
            GroupBox1.Controls.Add(this.field36);
            GroupBox1.Controls.Add(this.field37);
            GroupBox1.Controls.Add(this.field38);
            GroupBox1.Controls.Add(this.field39);
            GroupBox1.Controls.Add(this.field40);
            GroupBox1.Controls.Add(this.field41);
            GroupBox1.Controls.Add(this.field42);
            GroupBox1.Controls.Add(this.field43);
            GroupBox1.Controls.Add(this.field44);
            GroupBox1.Controls.Add(this.field45);
            GroupBox1.Controls.Add(this.field46);
            GroupBox1.Controls.Add(this.field47);
            GroupBox1.Controls.Add(this.field48);
            GroupBox1.Controls.Add(this.field49);
            GroupBox1.Controls.Add(this.field50);
            GroupBox1.Controls.Add(this.field51);
            GroupBox1.Controls.Add(this.field52);
            GroupBox1.Controls.Add(this.field53);
            GroupBox1.Controls.Add(this.field54);
            GroupBox1.Controls.Add(this.field55);
            GroupBox1.Controls.Add(this.field56);
            GroupBox1.Controls.Add(this.field57);
            GroupBox1.Controls.Add(this.field58);
            GroupBox1.Controls.Add(this.field59);
            GroupBox1.Controls.Add(this.field60);
            GroupBox1.Controls.Add(this.field61);
            GroupBox1.Controls.Add(this.field62);
            GroupBox1.Controls.Add(this.field63);
            GroupBox1.Controls.Add(this.field64);
            GroupBox1.Controls.Add(this.field65);
            GroupBox1.Controls.Add(this.field66);
            GroupBox1.Controls.Add(this.field67);
            GroupBox1.Controls.Add(this.field68);
            GroupBox1.Controls.Add(this.field69);
            GroupBox1.Controls.Add(this.field70);
            GroupBox1.Controls.Add(this.field71);
            GroupBox1.Controls.Add(this.field72);
            GroupBox1.Controls.Add(this.field73);
            GroupBox1.Controls.Add(this.field74);
            GroupBox1.Controls.Add(this.field75);
            GroupBox1.Controls.Add(this.field76);
            GroupBox1.Controls.Add(this.field77);
            GroupBox1.Controls.Add(this.field78);
            GroupBox1.Controls.Add(this.field79);
            GroupBox1.Controls.Add(this.field80);
            GroupBox1.Controls.Add(this.field81);
            #endregion
            //this.GroupBox1.SuspendLayout();
            //this.SuspendLayout();
            Hard.Controls.Add(this.GroupBox1);
            #region[Adding other buttons]
            this.bNew_Game = new Button()
            {
                Location = new Point(497, 133),
                Name = "bNew_Game",
                Size = new Size(106, 30),
                TabIndex = 81,
                Text = "New Game",
                UseVisualStyleBackColor = true,
            };
            bNew_Game.Click += new EventHandler(this.bNew_Game_Click);
            Hard.Controls.Add(this.bNew_Game);
            this.bCheck = new Button()
            {
                Location = new Point(497, 173),
                Name = "bCheck",
                Size = new Size(106, 30),
                TabIndex = 82,
                Text = "Check",
                UseVisualStyleBackColor = true,
            };
            bCheck.Click += new EventHandler(this.bCheck_Click);
            Hard.Controls.Add(this.bCheck);
            this.bClear = new Button()
            {
                Location = new Point(497, 213),
                Name = "bClear",
                Size = new Size(106, 30),
                TabIndex = 83,
                Text = "Clear Board",
                UseVisualStyleBackColor = true,
            };
            bClear.Click += new EventHandler(this.bClear_Click);
            Hard.Controls.Add(this.bClear);
            this.bSolve = new Button()
            {
                Location = new Point(497, 253),
                Name = "bSolve",
                Size = new Size(106, 30),
                TabIndex = 84,
                Text = "Solve Sudoku",
                UseVisualStyleBackColor = true,
            };
            bSolve.Click += new EventHandler(this.bSolve_Click);
            Hard.Controls.Add(this.bSolve);
            this.bHighlight = new Button()
            {
                Location = new Point(497, 293),
                Name = "bHighlight",
                Size = new Size(106, 30),
                TabIndex = 85,
                Text = "Highlight",
                UseVisualStyleBackColor = true,
            };
            bHighlight.Click += new EventHandler(this.bHighlight_Click);
            Hard.Controls.Add(this.bHighlight);
            this.txHighlight = new TextBox()
            {
                Location = new Point(617, 298),
                MaxLength = 1,
                Name = "txHighlight",
                Size = new Size(30, 30),
                TabIndex = 86,
                Text = "1",
                TextAlign = HorizontalAlignment.Center,
            };
            Hard.Controls.Add(this.txHighlight);
            #endregion
            Hard.ShowDialog();
        }

        private void bNew_Game_Click(object sender, EventArgs e)
        {

        }

        private void bCheck_Click(object sender, EventArgs e)
        {

        }

        private void bClear_Click(object sender, EventArgs e)
        {

        }

        private void bSolve_Click(object sender, EventArgs e)
        {

        }

        private void bHighlight_Click(object sender, EventArgs e)
        {

        }
    }
}
