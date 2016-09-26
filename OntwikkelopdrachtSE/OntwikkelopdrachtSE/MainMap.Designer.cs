namespace OntwikkelopdrachtSE
{
    partial class MainMap
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pn_main = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pn_main
            // 
            this.pn_main.BackColor = System.Drawing.Color.Blue;
            this.pn_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_main.Location = new System.Drawing.Point(12, 12);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(203, 203);
            this.pn_main.TabIndex = 0;
            // 
            // MainMap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(232, 225);
            this.Controls.Add(this.pn_main);
            this.Name = "MainMap";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pn_main;
    }
}

