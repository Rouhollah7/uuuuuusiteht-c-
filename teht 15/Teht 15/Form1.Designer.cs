namespace Teht_15
{
    partial class SekkariForm
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
            this.components = new System.ComponentModel.Container();
            this.AikaLB = new System.Windows.Forms.Label();
            this.KaynnistaBT = new System.Windows.Forms.Button();
            this.LopetaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AikaLB.Location = new System.Drawing.Point(3, 9);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(797, 191);
            this.AikaLB.TabIndex = 0;
            this.AikaLB.Text = "00.00.00.00";
            // 
            // KaynnistaBT
            // 
            this.KaynnistaBT.Location = new System.Drawing.Point(39, 227);
            this.KaynnistaBT.Name = "KaynnistaBT";
            this.KaynnistaBT.Size = new System.Drawing.Size(167, 73);
            this.KaynnistaBT.TabIndex = 1;
            this.KaynnistaBT.Text = "Käynnistä";
            this.KaynnistaBT.UseVisualStyleBackColor = true;
            this.KaynnistaBT.Click += new System.EventHandler(this.KaynnistaBT_Click);
            // 
            // LopetaBT
            // 
            this.LopetaBT.Location = new System.Drawing.Point(266, 227);
            this.LopetaBT.Name = "LopetaBT";
            this.LopetaBT.Size = new System.Drawing.Size(167, 73);
            this.LopetaBT.TabIndex = 2;
            this.LopetaBT.Text = "Lopeta";
            this.LopetaBT.UseVisualStyleBackColor = true;
            this.LopetaBT.Click += new System.EventHandler(this.LopetaBT_Click);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(494, 227);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(167, 73);
            this.TyhjennaBT.TabIndex = 3;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SekkariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 330);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.LopetaBT);
            this.Controls.Add(this.KaynnistaBT);
            this.Controls.Add(this.AikaLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SekkariForm";
            this.Text = "Sekuntikello";
            this.Load += new System.EventHandler(this.SekkariForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AikaLB;
        private Button KaynnistaBT;
        private Button LopetaBT;
        private Button TyhjennaBT;
        private System.Windows.Forms.Timer timer1;
    }
}