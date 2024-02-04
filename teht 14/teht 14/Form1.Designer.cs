namespace teht_14
{
    partial class DiaryForm
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
            this.SyottoTB = new System.Windows.Forms.TextBox();
            this.talennaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyottoTB
            // 
            this.SyottoTB.Location = new System.Drawing.Point(5, 5);
            this.SyottoTB.Multiline = true;
            this.SyottoTB.Name = "SyottoTB";
            this.SyottoTB.Size = new System.Drawing.Size(962, 464);
            this.SyottoTB.TabIndex = 0;
            // 
            // talennaBT
            // 
            this.talennaBT.Location = new System.Drawing.Point(5, 486);
            this.talennaBT.Name = "talennaBT";
            this.talennaBT.Size = new System.Drawing.Size(962, 92);
            this.talennaBT.TabIndex = 1;
            this.talennaBT.Text = "Tallenna päiväkirjaan";
            this.talennaBT.UseVisualStyleBackColor = true;
            this.talennaBT.Click += new System.EventHandler(this.talennaBT_Click);
            // 
            // DiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 590);
            this.Controls.Add(this.talennaBT);
            this.Controls.Add(this.SyottoTB);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DiaryForm";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SyottoTB;
        private Button talennaBT;
    }
}