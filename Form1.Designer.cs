namespace MixerBoja
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Crvena = new System.Windows.Forms.TrackBar();
            this.Zelena = new System.Windows.Forms.TrackBar();
            this.Plava = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crvena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zelena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plava)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 157);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            //this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Crvena
            // 
            this.Crvena.BackColor = System.Drawing.Color.Red;
            this.Crvena.Location = new System.Drawing.Point(12, 201);
            this.Crvena.Maximum = 255;
            this.Crvena.Name = "Crvena";
            this.Crvena.Size = new System.Drawing.Size(357, 45);
            this.Crvena.TabIndex = 1;
            this.Crvena.Scroll += new System.EventHandler(this.Crvena_Scroll);
            // 
            // Zelena
            // 
            this.Zelena.BackColor = System.Drawing.Color.Green;
            this.Zelena.Location = new System.Drawing.Point(12, 252);
            this.Zelena.Maximum = 255;
            this.Zelena.Name = "Zelena";
            this.Zelena.Size = new System.Drawing.Size(357, 45);
            this.Zelena.TabIndex = 2;
            this.Zelena.Scroll += new System.EventHandler(this.Zelena_Scroll);
            // 
            // Plava
            // 
            this.Plava.BackColor = System.Drawing.Color.Blue;
            this.Plava.Location = new System.Drawing.Point(12, 303);
            this.Plava.Maximum = 255;
            this.Plava.Name = "Plava";
            this.Plava.Size = new System.Drawing.Size(357, 45);
            this.Plava.TabIndex = 3;
            this.Plava.Scroll += new System.EventHandler(this.Plava_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 360);
            this.Controls.Add(this.Plava);
            this.Controls.Add(this.Zelena);
            this.Controls.Add(this.Crvena);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Mixer Boja";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crvena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zelena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar Crvena;
        private System.Windows.Forms.TrackBar Zelena;
        private System.Windows.Forms.TrackBar Plava;

    }
}

