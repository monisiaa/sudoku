namespace Sudoku
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bHow_Play = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bHow_Play
            // 
            this.bHow_Play.Location = new System.Drawing.Point(65, 36);
            this.bHow_Play.Name = "bHow_Play";
            this.bHow_Play.Size = new System.Drawing.Size(132, 62);
            this.bHow_Play.TabIndex = 0;
            this.bHow_Play.Text = "How to play";
            this.bHow_Play.UseVisualStyleBackColor = true;
            this.bHow_Play.Click += new System.EventHandler(this.bHow_Play_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(65, 135);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(132, 62);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start game";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bHow_Play);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bHow_Play;
        private System.Windows.Forms.Button bStart;
    }
}

