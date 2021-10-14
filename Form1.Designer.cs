
namespace Memory
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.carta1 = new System.Windows.Forms.PictureBox();
            this.carta2 = new System.Windows.Forms.PictureBox();
            this.carta3 = new System.Windows.Forms.PictureBox();
            this.carta4 = new System.Windows.Forms.PictureBox();
            this.carta5 = new System.Windows.Forms.PictureBox();
            this.carta6 = new System.Windows.Forms.PictureBox();
            this.carta7 = new System.Windows.Forms.PictureBox();
            this.carta8 = new System.Windows.Forms.PictureBox();
            this.restartGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta8)).BeginInit();
            this.SuspendLayout();
            // 
            // carta1
            // 
            this.carta1.Location = new System.Drawing.Point(22, 60);
            this.carta1.Name = "carta1";
            this.carta1.Size = new System.Drawing.Size(150, 190);
            this.carta1.TabIndex = 0;
            this.carta1.TabStop = false;
            this.carta1.Click += new System.EventHandler(this.carta1_Click);
            // 
            // carta2
            // 
            this.carta2.Location = new System.Drawing.Point(218, 60);
            this.carta2.Name = "carta2";
            this.carta2.Size = new System.Drawing.Size(150, 190);
            this.carta2.TabIndex = 1;
            this.carta2.TabStop = false;
            this.carta2.Click += new System.EventHandler(this.carta2_Click);
            // 
            // carta3
            // 
            this.carta3.Location = new System.Drawing.Point(417, 60);
            this.carta3.Name = "carta3";
            this.carta3.Size = new System.Drawing.Size(150, 190);
            this.carta3.TabIndex = 2;
            this.carta3.TabStop = false;
            this.carta3.Click += new System.EventHandler(this.carta3_Click);
            // 
            // carta4
            // 
            this.carta4.Location = new System.Drawing.Point(602, 60);
            this.carta4.Name = "carta4";
            this.carta4.Size = new System.Drawing.Size(150, 190);
            this.carta4.TabIndex = 3;
            this.carta4.TabStop = false;
            this.carta4.Click += new System.EventHandler(this.carta4_Click);
            // 
            // carta5
            // 
            this.carta5.Location = new System.Drawing.Point(22, 276);
            this.carta5.Name = "carta5";
            this.carta5.Size = new System.Drawing.Size(150, 190);
            this.carta5.TabIndex = 4;
            this.carta5.TabStop = false;
            this.carta5.Click += new System.EventHandler(this.carta5_Click);
            // 
            // carta6
            // 
            this.carta6.Location = new System.Drawing.Point(218, 276);
            this.carta6.Name = "carta6";
            this.carta6.Size = new System.Drawing.Size(150, 190);
            this.carta6.TabIndex = 5;
            this.carta6.TabStop = false;
            this.carta6.Click += new System.EventHandler(this.carta6_Click);
            // 
            // carta7
            // 
            this.carta7.Location = new System.Drawing.Point(417, 276);
            this.carta7.Name = "carta7";
            this.carta7.Size = new System.Drawing.Size(150, 190);
            this.carta7.TabIndex = 6;
            this.carta7.TabStop = false;
            this.carta7.Click += new System.EventHandler(this.carta7_Click);
            // 
            // carta8
            // 
            this.carta8.Location = new System.Drawing.Point(602, 276);
            this.carta8.Name = "carta8";
            this.carta8.Size = new System.Drawing.Size(150, 190);
            this.carta8.TabIndex = 7;
            this.carta8.TabStop = false;
            this.carta8.Click += new System.EventHandler(this.carta8_Click);
            // 
            // restartGame
            // 
            this.restartGame.Location = new System.Drawing.Point(291, 499);
            this.restartGame.Name = "restartGame";
            this.restartGame.Size = new System.Drawing.Size(196, 37);
            this.restartGame.TabIndex = 8;
            this.restartGame.Text = "Rimescola";
            this.restartGame.UseVisualStyleBackColor = true;
            this.restartGame.Visible = false;
            this.restartGame.Click += new System.EventHandler(this.restartGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.restartGame);
            this.Controls.Add(this.carta8);
            this.Controls.Add(this.carta7);
            this.Controls.Add(this.carta6);
            this.Controls.Add(this.carta5);
            this.Controls.Add(this.carta4);
            this.Controls.Add(this.carta3);
            this.Controls.Add(this.carta2);
            this.Controls.Add(this.carta1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox carta1;
        private System.Windows.Forms.PictureBox carta2;
        private System.Windows.Forms.PictureBox carta3;
        private System.Windows.Forms.PictureBox carta4;
        private System.Windows.Forms.PictureBox carta5;
        private System.Windows.Forms.PictureBox carta6;
        private System.Windows.Forms.PictureBox carta7;
        private System.Windows.Forms.PictureBox carta8;
        private System.Windows.Forms.Button restartGame;
    }
}

