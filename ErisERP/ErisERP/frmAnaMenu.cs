using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ErisERP
{
    public partial class frmAnaMenu : MaterialForm
    {
        // Men� ��elerini ve a��lacak formlar� e�le�tirmek i�in s�zl�k
        private readonly Dictionary<string, Type> menuForms = new Dictionary<string, Type>();

        public frmAnaMenu()
        {
            InitializeComponent();

            // MaterialSkin Manager ayarlar�
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800, Primary.Blue900,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);

            InitializeMenu();
        }

        private void InitializeMenu()
        {
            // Men� ��elerini ve kar��l�k gelen formlar� ekleyin
            menuForms.Add("M��teri Y�netimi", typeof(frmMusteriler));
            menuForms.Add("�r�n Y�netimi", typeof(frmUrunler));
            menuForms.Add("Sipari� Y�netimi", typeof(frmTedarikciler));

            // MaterialListBox'a men� ��elerini ekle (MaterialListBoxItem olarak)
            foreach (var item in menuForms.Keys)
            {
                menuListbox.Items.Add(new MaterialListBoxItem(item));
            }

            // �ift t�klama olay�n� ekle
            menuListbox.DoubleClick += (sender, e) => OpenSelectedForm();
        }

        private void OpenSelectedForm()
        {
            if (menuListbox.SelectedItem == null) return;

            string selectedMenu = menuListbox.SelectedItem.Text;

            if (menuForms.TryGetValue(selectedMenu, out Type formType))
            {
                // Form zaten a��ksa �ne getir, de�ilse yeni a�
                Form existingForm = Application.OpenForms[formType.Name];
                if (existingForm != null)
                {
                    existingForm.BringToFront();
                    if (existingForm.WindowState == FormWindowState.Minimized)
                    {
                        existingForm.WindowState = FormWindowState.Normal;
                    }
                }
                else
                {
                    Form newForm = (Form)Activator.CreateInstance(formType);
                    newForm.MdiParent = this;
                    newForm.Show();
                }
            }
        }

        private void frmAnaMenu_Load(object sender, EventArgs e)
        {
            // Form y�klendi�inde yap�lacak ek i�lemler
        }
    }
}