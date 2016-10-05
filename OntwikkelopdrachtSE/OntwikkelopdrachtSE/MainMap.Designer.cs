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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_currentHP = new System.Windows.Forms.Label();
            this.lb_maxHP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_currentAP = new System.Windows.Forms.Label();
            this.lb_maxAP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_currentMP = new System.Windows.Forms.Label();
            this.lb_maxMP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pn_main
            // 
            this.pn_main.BackColor = System.Drawing.Color.Black;
            this.pn_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_main.Location = new System.Drawing.Point(12, 51);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(410, 410);
            this.pn_main.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Map:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stats:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "HP";
            // 
            // lb_currentHP
            // 
            this.lb_currentHP.AutoSize = true;
            this.lb_currentHP.Location = new System.Drawing.Point(491, 50);
            this.lb_currentHP.Name = "lb_currentHP";
            this.lb_currentHP.Size = new System.Drawing.Size(46, 17);
            this.lb_currentHP.TabIndex = 4;
            this.lb_currentHP.Text = "label4";
            // 
            // lb_maxHP
            // 
            this.lb_maxHP.AutoSize = true;
            this.lb_maxHP.Location = new System.Drawing.Point(608, 50);
            this.lb_maxHP.Name = "lb_maxHP";
            this.lb_maxHP.Size = new System.Drawing.Size(46, 17);
            this.lb_maxHP.TabIndex = 5;
            this.lb_maxHP.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "AP";
            // 
            // lb_currentAP
            // 
            this.lb_currentAP.AutoSize = true;
            this.lb_currentAP.Location = new System.Drawing.Point(491, 76);
            this.lb_currentAP.Name = "lb_currentAP";
            this.lb_currentAP.Size = new System.Drawing.Size(46, 17);
            this.lb_currentAP.TabIndex = 7;
            this.lb_currentAP.Text = "label7";
            // 
            // lb_maxAP
            // 
            this.lb_maxAP.AutoSize = true;
            this.lb_maxAP.Location = new System.Drawing.Point(608, 76);
            this.lb_maxAP.Name = "lb_maxAP";
            this.lb_maxAP.Size = new System.Drawing.Size(46, 17);
            this.lb_maxAP.TabIndex = 8;
            this.lb_maxAP.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "MP";
            // 
            // lb_currentMP
            // 
            this.lb_currentMP.AutoSize = true;
            this.lb_currentMP.Location = new System.Drawing.Point(491, 105);
            this.lb_currentMP.Name = "lb_currentMP";
            this.lb_currentMP.Size = new System.Drawing.Size(54, 17);
            this.lb_currentMP.TabIndex = 10;
            this.lb_currentMP.Text = "label10";
            // 
            // lb_maxMP
            // 
            this.lb_maxMP.AutoSize = true;
            this.lb_maxMP.Location = new System.Drawing.Point(608, 105);
            this.lb_maxMP.Name = "lb_maxMP";
            this.lb_maxMP.Size = new System.Drawing.Size(54, 17);
            this.lb_maxMP.TabIndex = 11;
            this.lb_maxMP.Text = "label11";
            // 
            // MainMap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(691, 475);
            this.Controls.Add(this.lb_maxMP);
            this.Controls.Add(this.lb_currentMP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_maxAP);
            this.Controls.Add(this.lb_currentAP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_maxHP);
            this.Controls.Add(this.lb_currentHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pn_main);
            this.Name = "MainMap";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMap_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_currentHP;
        private System.Windows.Forms.Label lb_maxHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_currentAP;
        private System.Windows.Forms.Label lb_maxAP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_currentMP;
        private System.Windows.Forms.Label lb_maxMP;
    }
}

