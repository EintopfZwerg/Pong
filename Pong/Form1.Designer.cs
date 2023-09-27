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
            pbPaddelSpieler.Size = new Size(10, 125);
            pbPaddelSpieler.TabIndex = 0;
            pbPaddelSpieler.TabStop = false;
            // 
            // pbPaddelGegner
            // 
            pbPaddelGegner.BackColor = SystemColors.ActiveCaptionText;
            pbPaddelGegner.Location = new Point(780, 160);
            pbPaddelGegner.Name = "pbPaddelGegner";
            pbPaddelGegner.Size = new Size(10, 125);
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
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
            Controls.Add(pbPong);
            Controls.Add(pbPaddelGegner);
            Controls.Add(pbPaddelSpieler);
            Name = "Form1";
            Text = "Pong";
            ((System.ComponentModel.ISupportInitialize)pbPaddelSpieler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPaddelGegner).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbPaddelSpieler;
        private PictureBox pbPaddelGegner;
        private PictureBox pbPong;
        private System.Windows.Forms.Timer timer1;
    }
}