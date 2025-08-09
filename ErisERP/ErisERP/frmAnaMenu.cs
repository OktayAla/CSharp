using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ErisERP
{
    public partial class frmAnaMenu : MaterialForm
    {
        // Menü öðelerini ve açýlacak formlarý eþleþtirmek için sözlük
        private readonly Dictionary<string, Type> menuForms = new Dictionary<string, Type>();

        public frmAnaMenu()
        {
            InitializeComponent();

            // MaterialSkin Manager ayarlarý
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
            // Menü öðelerini ve karþýlýk gelen formlarý ekleyin
            menuForms.Add("Müþteri Yönetimi", typeof(frmMusteriler));
            menuForms.Add("Ürün Yönetimi", typeof(frmUrunler));
            menuForms.Add("Sipariþ Yönetimi", typeof(frmTedarikciler));

            // MaterialListBox'a menü öðelerini ekle (MaterialListBoxItem olarak)
            foreach (var item in menuForms.Keys)
            {
                menuListbox.Items.Add(new MaterialListBoxItem(item));
            }

            // Çift týklama olayýný ekle
            menuListbox.DoubleClick += (sender, e) => OpenSelectedForm();
        }

        private void OpenSelectedForm()
        {
            if (menuListbox.SelectedItem == null) return;

            string selectedMenu = menuListbox.SelectedItem.Text;

            if (menuForms.TryGetValue(selectedMenu, out Type formType))
            {
                // Form zaten açýksa öne getir, deðilse yeni aç
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
            // Form yüklendiðinde yapýlacak ek iþlemler
        }
    }
}