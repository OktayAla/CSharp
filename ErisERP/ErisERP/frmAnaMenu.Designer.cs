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
            this.menuListbox = new MaterialSkin.Controls.MaterialListBox();
            this.SuspendLayout();
            // 
            // menuListbox
            // 
            this.menuListbox.BackColor = System.Drawing.Color.White;
            this.menuListbox.Depth = 0;
            this.menuListbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.menuListbox.Location = new System.Drawing.Point(0, 64);
            this.menuListbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuListbox.Name = "menuListbox";
            this.menuListbox.Size = new System.Drawing.Size(250, 564);
            this.menuListbox.TabIndex = 0;
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 628);
            this.Controls.Add(this.menuListbox);
            this.IsMdiContainer = true;
            this.Name = "frmAnaMenu";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErisERP - Ana Menü";
            this.Load += new System.EventHandler(this.frmAnaMenu_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox menuListbox;
    }
}