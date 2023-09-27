namespace Pong
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbPaddelSpieler = new PictureBox();
            pbPaddelGegner = new PictureBox();
            pbPong = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lGewonnen = new Label();
            lVerloren = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPaddelSpieler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPaddelGegner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPong).BeginInit();
            SuspendLayout();
            // 
            // pbPaddelSpieler
            // 
            pbPaddelSpieler.BackColor = SystemColors.ActiveCaptionText;
            pbPaddelSpieler.Location = new Point(12, 160);
            pbPaddelSpieler.Name = "pbPaddelSpieler";
            pbPaddelSpieler.Size = new Size(10, 120);
            pbPaddelSpieler.TabIndex = 0;
            pbPaddelSpieler.TabStop = false;
            // 
            // pbPaddelGegner
            // 
            pbPaddelGegner.BackColor = SystemColors.ActiveCaptionText;
            pbPaddelGegner.Location = new Point(780, 160);
            pbPaddelGegner.Name = "pbPaddelGegner";
            pbPaddelGegner.Size = new Size(10, 120);
            pbPaddelGegner.TabIndex = 1;
            pbPaddelGegner.TabStop = false;
            // 
            // pbPong
            // 
            pbPong.Image = (Image)resources.GetObject("pbPong.Image");
            pbPong.Location = new Point(383, 199);
            pbPong.Name = "pbPong";
            pbPong.Size = new Size(30, 30);
            pbPong.TabIndex = 2;
            pbPong.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
            // 
            // lGewonnen
            // 
            lGewonnen.AutoSize = true;
            lGewonnen.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lGewonnen.Location = new Point(272, 103);
            lGewonnen.Name = "lGewonnen";
            lGewonnen.Size = new Size(246, 50);
            lGewonnen.TabIndex = 3;
            lGewonnen.Text = "Gewonnen";
            lGewonnen.Visible = false;
            // 
            // lVerloren
            // 
            lVerloren.AutoSize = true;
            lVerloren.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lVerloren.Location = new Point(272, 293);
            lVerloren.Name = "lVerloren";
            lVerloren.Size = new Size(228, 50);
            lVerloren.TabIndex = 4;
            lVerloren.Text = "Verloren";
            lVerloren.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
            Controls.Add(lVerloren);
            Controls.Add(lGewonnen);
            Controls.Add(pbPong);
            Controls.Add(pbPaddelGegner);
            Controls.Add(pbPaddelSpieler);
            Name = "Form1";
            Text = "Pong";
            ((System.ComponentModel.ISupportInitialize)pbPaddelSpieler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPaddelGegner).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPaddelSpieler;
        private PictureBox pbPaddelGegner;
        private PictureBox pbPong;
        private System.Windows.Forms.Timer timer1;
        private Label lGewonnen;
        private Label lVerloren;
    }
}