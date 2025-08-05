using MaterialSkin;
using MaterialSkin.Controls;

namespace ErisERP
{
    public partial class frmAnaMenu : MaterialForm
    {
        public frmAnaMenu()
        {
            InitializeComponent();

            // MaterialSkin ayarlarý
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800, Primary.Blue900,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void frmAnaMenu_Load(object sender, EventArgs e)
        {
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            frmUrunler urunlerForm = new frmUrunler();
            urunlerForm.ShowDialog();
        }

        private void btnTedarikciler_Click(object sender, EventArgs e)
        {
            frmTedarikciler tedarikciForm = new frmTedarikciler();
            tedarikciForm.ShowDialog();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            frmMusteriler musteriForm = new frmMusteriler();
            musteriForm.ShowDialog();
        }
    }
}