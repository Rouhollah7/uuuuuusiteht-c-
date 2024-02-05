namespace teht_18
{
    partial class AvainhenkilotForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OppilaitosCB = new System.Windows.Forms.ComboBox();
            this.VastuuhloCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.PostiNumeroLB = new System.Windows.Forms.Label();
            this.PostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.PuhLB = new System.Windows.Forms.Label();
            this.EmailLB = new System.Windows.Forms.Label();
            this.OsastoLB = new System.Windows.Forms.Label();
            this.TitteliLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainkenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // OppilaitosCB
            // 
            this.OppilaitosCB.FormattingEnabled = true;
            this.OppilaitosCB.Location = new System.Drawing.Point(12, 155);
            this.OppilaitosCB.Name = "OppilaitosCB";
            this.OppilaitosCB.Size = new System.Drawing.Size(230, 46);
            this.OppilaitosCB.TabIndex = 2;
            this.OppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitosCB_SelectedIndexChanged);
            // 
            // VastuuhloCB
            // 
            this.VastuuhloCB.FormattingEnabled = true;
            this.VastuuhloCB.Location = new System.Drawing.Point(462, 155);
            this.VastuuhloCB.Name = "VastuuhloCB";
            this.VastuuhloCB.Size = new System.Drawing.Size(281, 46);
            this.VastuuhloCB.TabIndex = 4;
            this.VastuuhloCB.TextChanged += new System.EventHandler(this.VastuuhloCB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valitse vastuuhenkilö:";
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.Location = new System.Drawing.Point(12, 217);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.Size = new System.Drawing.Size(97, 38);
            this.OsoiteLB.TabIndex = 5;
            this.OsoiteLB.Text = "Osoite";
            // 
            // PostiNumeroLB
            // 
            this.PostiNumeroLB.AutoSize = true;
            this.PostiNumeroLB.Location = new System.Drawing.Point(12, 265);
            this.PostiNumeroLB.Name = "PostiNumeroLB";
            this.PostiNumeroLB.Size = new System.Drawing.Size(173, 38);
            this.PostiNumeroLB.TabIndex = 6;
            this.PostiNumeroLB.Text = "Postinumero";
            // 
            // PostitoimipaikkaLB
            // 
            this.PostitoimipaikkaLB.AutoSize = true;
            this.PostitoimipaikkaLB.Location = new System.Drawing.Point(12, 315);
            this.PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            this.PostitoimipaikkaLB.Size = new System.Drawing.Size(218, 38);
            this.PostitoimipaikkaLB.TabIndex = 7;
            this.PostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Location = new System.Drawing.Point(12, 362);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(110, 38);
            this.PuhelinLB.TabIndex = 8;
            this.PuhelinLB.Text = "Puhelin";
            // 
            // PuhLB
            // 
            this.PuhLB.AutoSize = true;
            this.PuhLB.Location = new System.Drawing.Point(462, 362);
            this.PuhLB.Name = "PuhLB";
            this.PuhLB.Size = new System.Drawing.Size(110, 38);
            this.PuhLB.TabIndex = 12;
            this.PuhLB.Text = "Puhelin";
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Location = new System.Drawing.Point(462, 315);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(152, 38);
            this.EmailLB.TabIndex = 11;
            this.EmailLB.Text = "Sähköposti";
            // 
            // OsastoLB
            // 
            this.OsastoLB.AutoSize = true;
            this.OsastoLB.Location = new System.Drawing.Point(462, 265);
            this.OsastoLB.Name = "OsastoLB";
            this.OsastoLB.Size = new System.Drawing.Size(101, 38);
            this.OsastoLB.TabIndex = 10;
            this.OsastoLB.Text = "Osasto";
            // 
            // TitteliLB
            // 
            this.TitteliLB.AutoSize = true;
            this.TitteliLB.Location = new System.Drawing.Point(462, 217);
            this.TitteliLB.Name = "TitteliLB";
            this.TitteliLB.Size = new System.Drawing.Size(86, 38);
            this.TitteliLB.TabIndex = 9;
            this.TitteliLB.Text = "Titteli";
            // 
            // AvainhenkilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 406);
            this.Controls.Add(this.PuhLB);
            this.Controls.Add(this.EmailLB);
            this.Controls.Add(this.OsastoLB);
            this.Controls.Add(this.TitteliLB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PostitoimipaikkaLB);
            this.Controls.Add(this.PostiNumeroLB);
            this.Controls.Add(this.OsoiteLB);
            this.Controls.Add(this.VastuuhloCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OppilaitosCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AvainhenkilotForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.AvainhenkilotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox OppilaitosCB;
        private ComboBox VastuuhloCB;
        private Label label3;
        private Label OsoiteLB;
        private Label PostiNumeroLB;
        private Label PostitoimipaikkaLB;
        private Label PuhelinLB;
        private Label PuhLB;
        private Label EmailLB;
        private Label OsastoLB;
        private Label TitteliLB;
    }
}