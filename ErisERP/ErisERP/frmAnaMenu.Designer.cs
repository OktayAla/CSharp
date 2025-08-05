namespace ErisERP
{
    partial class frmAnaMenu
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
            btnUrunler = new MaterialSkin.Controls.MaterialButton();
            btnTedarikciler = new MaterialSkin.Controls.MaterialButton();
            btnMusteriler = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // btnUrunler
            // 
            btnUrunler.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUrunler.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUrunler.Depth = 0;
            btnUrunler.HighEmphasis = true;
            btnUrunler.Icon = null;
            btnUrunler.Location = new Point(30, 115);
            btnUrunler.Margin = new Padding(4, 6, 4, 6);
            btnUrunler.MouseState = MaterialSkin.MouseState.HOVER;
            btnUrunler.Name = "btnUrunler";
            btnUrunler.NoAccentTextColor = Color.Empty;
            btnUrunler.Size = new Size(86, 36);
            btnUrunler.TabIndex = 0;
            btnUrunler.Text = "Ürünler";
            btnUrunler.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUrunler.UseAccentColor = false;
            btnUrunler.UseVisualStyleBackColor = true;
            btnUrunler.Click += btnUrunler_Click;
            // 
            // btnTedarikciler
            // 
            btnTedarikciler.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTedarikciler.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTedarikciler.Depth = 0;
            btnTedarikciler.HighEmphasis = true;
            btnTedarikciler.Icon = null;
            btnTedarikciler.Location = new Point(205, 115);
            btnTedarikciler.Margin = new Padding(4, 6, 4, 6);
            btnTedarikciler.MouseState = MaterialSkin.MouseState.HOVER;
            btnTedarikciler.Name = "btnTedarikciler";
            btnTedarikciler.NoAccentTextColor = Color.Empty;
            btnTedarikciler.Size = new Size(120, 36);
            btnTedarikciler.TabIndex = 1;
            btnTedarikciler.Text = "Tedarikçiler";
            btnTedarikciler.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTedarikciler.UseAccentColor = false;
            btnTedarikciler.UseVisualStyleBackColor = true;
            btnTedarikciler.Click += btnTedarikciler_Click;
            // 
            // btnMusteriler
            // 
            btnMusteriler.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMusteriler.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnMusteriler.Depth = 0;
            btnMusteriler.HighEmphasis = true;
            btnMusteriler.Icon = null;
            btnMusteriler.Location = new Point(396, 115);
            btnMusteriler.Margin = new Padding(4, 6, 4, 6);
            btnMusteriler.MouseState = MaterialSkin.MouseState.HOVER;
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.NoAccentTextColor = Color.Empty;
            btnMusteriler.Size = new Size(109, 36);
            btnMusteriler.TabIndex = 2;
            btnMusteriler.Text = "Müşteriler";
            btnMusteriler.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnMusteriler.UseAccentColor = false;
            btnMusteriler.UseVisualStyleBackColor = true;
            btnMusteriler.Click += btnMusteriler_Click;
            // 
            // frmAnaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 222);
            Controls.Add(btnMusteriler);
            Controls.Add(btnTedarikciler);
            Controls.Add(btnUrunler);
            Name = "frmAnaMenu";
            Padding = new Padding(3, 80, 3, 3);
            Text = "ErisERP - Ana Menü";
            Load += frmAnaMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnUrunler;
        private MaterialSkin.Controls.MaterialButton btnTedarikciler;
        private MaterialSkin.Controls.MaterialButton btnMusteriler;
    }
}