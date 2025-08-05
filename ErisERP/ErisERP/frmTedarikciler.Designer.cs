namespace ErisERP
{
    partial class frmTedarikciler
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
            Button btnListele;
            dgvTedarikciler = new DataGridView();
            btnEkle = new Button();
            btnListele = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTedarikciler).BeginInit();
            SuspendLayout();
            // 
            // btnListele
            // 
            btnListele.Location = new Point(12, 12);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(94, 29);
            btnListele.TabIndex = 3;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // dgvTedarikciler
            // 
            dgvTedarikciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTedarikciler.Location = new Point(12, 303);
            dgvTedarikciler.Name = "dgvTedarikciler";
            dgvTedarikciler.RowHeadersWidth = 51;
            dgvTedarikciler.Size = new Size(1158, 188);
            dgvTedarikciler.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 47);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // frmTedarikciler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 503);
            Controls.Add(btnEkle);
            Controls.Add(btnListele);
            Controls.Add(dgvTedarikciler);
            Name = "frmTedarikciler";
            Text = "frmTedarikciler";
            ((System.ComponentModel.ISupportInitialize)dgvTedarikciler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTedarikciler;
        private Button btnEkle;
    }
}