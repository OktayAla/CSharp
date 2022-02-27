namespace weather_project
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
            this.istanbul_derece_label = new System.Windows.Forms.Label();
            this.istanbul_picturebox = new System.Windows.Forms.PictureBox();
            this.ankara_derece_label = new System.Windows.Forms.Label();
            this.izmir_derece_label = new System.Windows.Forms.Label();
            this.ankara_picturebox = new System.Windows.Forms.PictureBox();
            this.izmir_picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.istanbul_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ankara_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izmir_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // istanbul_derece_label
            // 
            this.istanbul_derece_label.AutoSize = true;
            this.istanbul_derece_label.BackColor = System.Drawing.Color.Transparent;
            this.istanbul_derece_label.Font = new System.Drawing.Font("Bollivia Script Free Personal", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.istanbul_derece_label.ForeColor = System.Drawing.Color.White;
            this.istanbul_derece_label.Location = new System.Drawing.Point(457, 138);
            this.istanbul_derece_label.Name = "istanbul_derece_label";
            this.istanbul_derece_label.Size = new System.Drawing.Size(187, 83);
            this.istanbul_derece_label.TabIndex = 2;
            this.istanbul_derece_label.Text = "derece";
            // 
            // istanbul_picturebox
            // 
            this.istanbul_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.istanbul_picturebox.Image = global::weather_project.Properties.Resources.gunduz_yagmurlu;
            this.istanbul_picturebox.Location = new System.Drawing.Point(273, 124);
            this.istanbul_picturebox.Name = "istanbul_picturebox";
            this.istanbul_picturebox.Size = new System.Drawing.Size(114, 113);
            this.istanbul_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.istanbul_picturebox.TabIndex = 14;
            this.istanbul_picturebox.TabStop = false;
            // 
            // ankara_derece_label
            // 
            this.ankara_derece_label.AutoSize = true;
            this.ankara_derece_label.BackColor = System.Drawing.Color.Transparent;
            this.ankara_derece_label.Font = new System.Drawing.Font("Bollivia Script Free Personal", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ankara_derece_label.ForeColor = System.Drawing.Color.White;
            this.ankara_derece_label.Location = new System.Drawing.Point(457, 292);
            this.ankara_derece_label.Name = "ankara_derece_label";
            this.ankara_derece_label.Size = new System.Drawing.Size(187, 83);
            this.ankara_derece_label.TabIndex = 10;
            this.ankara_derece_label.Text = "derece";
            // 
            // izmir_derece_label
            // 
            this.izmir_derece_label.AutoSize = true;
            this.izmir_derece_label.BackColor = System.Drawing.Color.Transparent;
            this.izmir_derece_label.Font = new System.Drawing.Font("Bollivia Script Free Personal", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.izmir_derece_label.ForeColor = System.Drawing.Color.White;
            this.izmir_derece_label.Location = new System.Drawing.Point(457, 438);
            this.izmir_derece_label.Name = "izmir_derece_label";
            this.izmir_derece_label.Size = new System.Drawing.Size(187, 83);
            this.izmir_derece_label.TabIndex = 11;
            this.izmir_derece_label.Text = "derece";
            // 
            // ankara_picturebox
            // 
            this.ankara_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.ankara_picturebox.Image = global::weather_project.Properties.Resources.gunduz_yagmurlu;
            this.ankara_picturebox.Location = new System.Drawing.Point(273, 271);
            this.ankara_picturebox.Name = "ankara_picturebox";
            this.ankara_picturebox.Size = new System.Drawing.Size(114, 113);
            this.ankara_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ankara_picturebox.TabIndex = 15;
            this.ankara_picturebox.TabStop = false;
            // 
            // izmir_picturebox
            // 
            this.izmir_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.izmir_picturebox.Image = global::weather_project.Properties.Resources.gunduz_yagmurlu;
            this.izmir_picturebox.Location = new System.Drawing.Point(273, 420);
            this.izmir_picturebox.Name = "izmir_picturebox";
            this.izmir_picturebox.Size = new System.Drawing.Size(114, 113);
            this.izmir_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.izmir_picturebox.TabIndex = 16;
            this.izmir_picturebox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::weather_project.Properties.Resources.weather_app_background;
            this.ClientSize = new System.Drawing.Size(751, 550);
            this.Controls.Add(this.izmir_picturebox);
            this.Controls.Add(this.ankara_picturebox);
            this.Controls.Add(this.izmir_derece_label);
            this.Controls.Add(this.ankara_derece_label);
            this.Controls.Add(this.istanbul_picturebox);
            this.Controls.Add(this.istanbul_derece_label);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Hava Durumu Uygulaması | Weather App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.istanbul_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ankara_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izmir_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label istanbul_derece_label;
        public PictureBox istanbul_picturebox;
        public Label ankara_derece_label;
        public Label izmir_derece_label;
        public PictureBox ankara_picturebox;
        public PictureBox izmir_picturebox;
    }
}