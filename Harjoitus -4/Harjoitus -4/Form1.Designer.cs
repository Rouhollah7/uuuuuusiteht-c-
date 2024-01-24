namespace Harjoitus__4
{
    partial class IkaForm
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
            this.SyntymaAikaDT = new System.Windows.Forms.DateTimePicker();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.VuosinaLB = new System.Windows.Forms.Label();
            this.KuukausinaLB = new System.Windows.Forms.Label();
            this.PaivinaLB = new System.Windows.Forms.Label();
            this.TunteinaLB = new System.Windows.Forms.Label();
            this.MinuteinaLB = new System.Windows.Forms.Label();
            this.SekunteinaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SyntymaAikaDT
            // 
            this.SyntymaAikaDT.Location = new System.Drawing.Point(43, 80);
            this.SyntymaAikaDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SyntymaAikaDT.Name = "SyntymaAikaDT";
            this.SyntymaAikaDT.Size = new System.Drawing.Size(448, 45);
            this.SyntymaAikaDT.TabIndex = 0;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(567, 80);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(112, 45);
            this.LaskeBT.TabIndex = 1;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // VuosinaLB
            // 
            this.VuosinaLB.AutoSize = true;
            this.VuosinaLB.Location = new System.Drawing.Point(43, 206);
            this.VuosinaLB.Name = "VuosinaLB";
            this.VuosinaLB.Size = new System.Drawing.Size(129, 38);
            this.VuosinaLB.TabIndex = 2;
            this.VuosinaLB.Text = "Vuoseina";
            this.VuosinaLB.Visible = false;
            this.VuosinaLB.Click += new System.EventHandler(this.VuoseinaLB_Click);
            // 
            // KuukausinaLB
            // 
            this.KuukausinaLB.AutoSize = true;
            this.KuukausinaLB.Location = new System.Drawing.Point(43, 277);
            this.KuukausinaLB.Name = "KuukausinaLB";
            this.KuukausinaLB.Size = new System.Drawing.Size(173, 38);
            this.KuukausinaLB.TabIndex = 3;
            this.KuukausinaLB.Text = "Kuukauseina";
            this.KuukausinaLB.Visible = false;
            // 
            // PaivinaLB
            // 
            this.PaivinaLB.AutoSize = true;
            this.PaivinaLB.Location = new System.Drawing.Point(43, 347);
            this.PaivinaLB.Name = "PaivinaLB";
            this.PaivinaLB.Size = new System.Drawing.Size(103, 38);
            this.PaivinaLB.TabIndex = 4;
            this.PaivinaLB.Text = "Päivinä";
            this.PaivinaLB.Visible = false;
            // 
            // TunteinaLB
            // 
            this.TunteinaLB.AutoSize = true;
            this.TunteinaLB.Location = new System.Drawing.Point(366, 206);
            this.TunteinaLB.Name = "TunteinaLB";
            this.TunteinaLB.Size = new System.Drawing.Size(125, 38);
            this.TunteinaLB.TabIndex = 5;
            this.TunteinaLB.Text = "Tunteina";
            this.TunteinaLB.Visible = false;
            // 
            // MinuteinaLB
            // 
            this.MinuteinaLB.AutoSize = true;
            this.MinuteinaLB.Location = new System.Drawing.Point(366, 277);
            this.MinuteinaLB.Name = "MinuteinaLB";
            this.MinuteinaLB.Size = new System.Drawing.Size(142, 38);
            this.MinuteinaLB.TabIndex = 6;
            this.MinuteinaLB.Text = "Minuteina";
            this.MinuteinaLB.Visible = false;
            // 
            // SekunteinaLB
            // 
            this.SekunteinaLB.AutoSize = true;
            this.SekunteinaLB.Location = new System.Drawing.Point(366, 347);
            this.SekunteinaLB.Name = "SekunteinaLB";
            this.SekunteinaLB.Size = new System.Drawing.Size(154, 38);
            this.SekunteinaLB.TabIndex = 7;
            this.SekunteinaLB.Text = "Sekunteina";
            this.SekunteinaLB.Visible = false;
            // 
            // IkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 684);
            this.Controls.Add(this.SekunteinaLB);
            this.Controls.Add(this.MinuteinaLB);
            this.Controls.Add(this.TunteinaLB);
            this.Controls.Add(this.PaivinaLB);
            this.Controls.Add(this.KuukausinaLB);
            this.Controls.Add(this.VuosinaLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.SyntymaAikaDT);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IkaForm";
            this.Text = "IkäLaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker SyntymaAikaDT;
        private Button LaskeBT;
        private Label VuosinaLB;
        private Label KuukausinaLB;
        private Label PaivinaLB;
        private Label TunteinaLB;
        private Label MinuteinaLB;
        private Label SekunteinaLB;
    }
}