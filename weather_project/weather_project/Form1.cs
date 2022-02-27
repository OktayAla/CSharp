using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using HtmlAgilityPack;

namespace weather_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            var istanbul_url = new Uri("https://havadurumu15gunluk.xyz/havadurumu/630/istanbul-hava-durumu-15-gunluk.html");
            var istanbul_client = new WebClient();
            var istanbul_html = istanbul_client.DownloadString(istanbul_url);
            HtmlAgilityPack.HtmlDocument istanbul_doc = new HtmlAgilityPack.HtmlDocument();
            istanbul_doc.LoadHtml(istanbul_html);
            var istanbul_veri = istanbul_doc.DocumentNode.SelectNodes("/html/body/main/aside/div[1]/div/span[5]")[0];
            var istanbul_havagorsel = istanbul_doc.DocumentNode.SelectNodes("/html/body/main/aside/div[1]/div/span[4]")[0];


            if (istanbul_veri != null)
            {
                istanbul_derece_label.Text = istanbul_veri.InnerHtml;
            }

            if (istanbul_havagorsel.InnerHtml == "G�ne�li")
            {
                istanbul_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_gunesli.png");
            }

            else if (istanbul_havagorsel.InnerHtml == "K�smen g�ne�li")
            {
                istanbul_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_parcali_bulutlu.png");
            }

            else if (istanbul_havagorsel.InnerHtml == "Par�al� bulutlu")
            {
                istanbul_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_parcali_bulutlu.png");
            }

            else if (istanbul_havagorsel.InnerHtml == "Bulutlu")
            {
                istanbul_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_parcali_bulutlu.png");
            }

            else if (istanbul_havagorsel.InnerHtml == "�ok bulutlu")
            {
                istanbul_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_cok_bulutlu.png");
            }

            else if (istanbul_havagorsel.InnerHtml == "Hafif ya�mur")
            {
                istanbul_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_yagmurlu.png");
            }

            else if (istanbul_havagorsel.InnerHtml == "Yer yer ya�murlu")
            {
                istanbul_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_yagmurlu.png");
            }

            else if (istanbul_havagorsel.InnerHtml == "Ya�murlu")
            {
                istanbul_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_yagmurlu.png");
            }



            var ankara_url = new Uri("https://havadurumu15gunluk.xyz/havadurumu/90/ankara-hava-durumu-15-gunluk.html");
            var ankara_client = new WebClient();
            var ankara_html = ankara_client.DownloadString(ankara_url);
            HtmlAgilityPack.HtmlDocument ankara_doc = new HtmlAgilityPack.HtmlDocument();
            ankara_doc.LoadHtml(ankara_html);
            var ankara_veri = ankara_doc.DocumentNode.SelectNodes("/html/body/main/aside/div[1]/div/span[5]")[0];
            var ankara_havagorsel = ankara_doc.DocumentNode.SelectNodes("/html/body/main/aside/div[1]/div/span[4]")[0];


            if (ankara_veri != null)
            {
                ankara_derece_label.Text = ankara_veri.InnerHtml;
            }

            if (ankara_havagorsel.InnerHtml == "G�ne�li")
            {
                ankara_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_gunesli.png");
            }

            else if (ankara_havagorsel.InnerHtml == "K�smen g�ne�li")
            {
                ankara_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_parcali_bulutlu.png");
            }

            else if (ankara_havagorsel.InnerHtml == "Par�al� bulutlu")
            {
                ankara_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_parcali_bulutlu.png");
            }

            else if (ankara_havagorsel.InnerHtml == "Bulutlu")
            {
                ankara_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_parcali_bulutlu.png");
            }

            else if (ankara_havagorsel.InnerHtml == "�ok bulutlu")
            {
                ankara_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_cok_bulutlu.png");
            }

            else if (ankara_havagorsel.InnerHtml == "Hafif ya�mur")
            {
                ankara_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_yagmurlu.png");
            }

            else if (ankara_havagorsel.InnerHtml == "Yer yer ya�murlu")
            {
                ankara_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_yagmurlu.png");
            }

            else if (ankara_havagorsel.InnerHtml == "Ya�murlu")
            {
                ankara_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_yagmurlu.png");
            }



            var izmir_url = new Uri("https://havadurumu15gunluk.xyz/havadurumu/728/izmir-hava-durumu-15-gunluk.html");
            var izmir_client = new WebClient();
            var izmir_html = izmir_client.DownloadString(izmir_url);
            HtmlAgilityPack.HtmlDocument izmir_doc = new HtmlAgilityPack.HtmlDocument();
            izmir_doc.LoadHtml(izmir_html);
            var izmir_veri = izmir_doc.DocumentNode.SelectNodes("/html/body/main/aside/div[1]/div/span[5]")[0];
            var izmir_havagorsel = izmir_doc.DocumentNode.SelectNodes("/html/body/main/aside/div[1]/div/span[4]")[0];


            if (izmir_veri != null)
            {
                izmir_derece_label.Text = izmir_veri.InnerHtml;
            }

            if (izmir_havagorsel.InnerHtml == "G�ne�li")
            {
                izmir_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_gunesli.png");
            }

            else if (izmir_havagorsel.InnerHtml == "K�smen g�ne�li")
            {
                izmir_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_parcali_bulutlu.png");
            }

            else if (izmir_havagorsel.InnerHtml == "Par�al� bulutlu")
            {
                izmir_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_parcali_bulutlu.png");
            }

            else if (izmir_havagorsel.InnerHtml == "Bulutlu")
            {
                izmir_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_parcali_bulutlu.png");
            }

            else if (izmir_havagorsel.InnerHtml == "�ok bulutlu")
            {
                izmir_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_cok_bulutlu.png");
            }

            else if (izmir_havagorsel.InnerHtml == "Hafif ya�mur")
            {
                izmir_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_yagmurlu.png");
            }

            else if (izmir_havagorsel.InnerHtml == "Yer yer ya�murlu")
            {
                izmir_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_yagmurlu.png");
            }

            else if (izmir_havagorsel.InnerHtml == "Ya�murlu")
            {
                izmir_picturebox.ImageLocation = ("C:\\Users\\oktay\\source\\repos\\" +
                "weather_project\\weather_project\\Resources\\gunduz_yagmurlu.png");
            }
        }
    }
}
