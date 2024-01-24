namespace Harjoitus_6_salasana
{
    partial class SalasanaForm
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
            this.SalasanaPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.TarkistaBT = new System.Windows.Forms.Button();
            this.VirheviestiLB = new System.Windows.Forms.Label();
            this.SalasanaOikeinPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SalasanaPanel.SuspendLayout();
            this.SalasanaOikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaPanel
            // 
            this.SalasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPanel.Controls.Add(this.VirheviestiLB);
            this.SalasanaPanel.Controls.Add(this.TarkistaBT);
            this.SalasanaPanel.Controls.Add(this.SalasanaTB);
            this.SalasanaPanel.Controls.Add(this.KayttajaTB);
            this.SalasanaPanel.Controls.Add(this.label2);
            this.SalasanaPanel.Controls.Add(this.label1);
            this.SalasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPanel.Name = "SalasanaPanel";
            this.SalasanaPanel.Size = new System.Drawing.Size(831, 216);
            this.SalasanaPanel.TabIndex = 0;
            this.SalasanaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SalasanaPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(374, 25);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(397, 52);
            this.KayttajaTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(374, 83);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(397, 52);
            this.SalasanaTB.TabIndex = 3;
            // 
            // TarkistaBT
            // 
            this.TarkistaBT.ForeColor = System.Drawing.Color.Black;
            this.TarkistaBT.Location = new System.Drawing.Point(43, 83);
            this.TarkistaBT.Name = "TarkistaBT";
            this.TarkistaBT.Size = new System.Drawing.Size(152, 52);
            this.TarkistaBT.TabIndex = 4;
            this.TarkistaBT.Text = "Tarkista";
            this.TarkistaBT.UseVisualStyleBackColor = true;
            // 
            // VirheviestiLB
            // 
            this.VirheviestiLB.AutoSize = true;
            this.VirheviestiLB.Location = new System.Drawing.Point(43, 149);
            this.VirheviestiLB.Name = "VirheviestiLB";
            this.VirheviestiLB.Size = new System.Drawing.Size(100, 46);
            this.VirheviestiLB.TabIndex = 5;
            this.VirheviestiLB.Text = "Virhe";
            this.VirheviestiLB.Click += new System.EventHandler(this.VirheviestiLB_Click);
            // 
            // SalasanaOikeinPanel
            // 
            this.SalasanaOikeinPanel.BackColor = System.Drawing.Color.Maroon;
            this.SalasanaOikeinPanel.Controls.Add(this.label3);
            this.SalasanaOikeinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPanel.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SalasanaOikeinPanel.ForeColor = System.Drawing.Color.Snow;
            this.SalasanaOikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            this.SalasanaOikeinPanel.Size = new System.Drawing.Size(831, 216);
            this.SalasanaOikeinPanel.TabIndex = 1;
            this.SalasanaOikeinPanel.Visible = false;
            this.SalasanaOikeinPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SalasanaOikeinPanel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(827, 120);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tervetuloa sivulleni";
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 216);
            this.Controls.Add(this.SalasanaOikeinPanel);
            this.Controls.Add(this.SalasanaPanel);
            this.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SalasanaForm";
            this.Text = "Salasanan tarkastus";
            this.SalasanaPanel.ResumeLayout(false);
            this.SalasanaPanel.PerformLayout();
            this.SalasanaOikeinPanel.ResumeLayout(false);
            this.SalasanaOikeinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SalasanaPanel;
        private Label VirheviestiLB;
        private Button TarkistaBT;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Label label2;
        private Label label1;
        private Panel SalasanaOikeinPanel;
        private Label label3;
    }
}