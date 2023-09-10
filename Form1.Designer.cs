namespace Bubbles_Particle_WFApp
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
            ParticlesTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ParticlesTimer
            // 
            ParticlesTimer.Enabled = true;
            ParticlesTimer.Interval = 20;
            ParticlesTimer.Tick += ParticlesTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Name = "Form1";
            Text = "Bobbles";
            Paint += FormPaintEvent;
            KeyUp += KeyIsUp;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer ParticlesTimer;
    }
}