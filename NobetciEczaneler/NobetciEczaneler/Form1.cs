using System;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;
using System.Linq;
using System.Drawing;

namespace NobetciEczaneler
{
    public partial class DTH_NobetciEczaneler : Form
    {
        private readonly string url = "https://www.denizli.bel.tr/Default.aspx?k=NobetciEczaneler";
        private readonly Timer refreshTimer;

        public DTH_NobetciEczaneler()
        {
            InitializeComponent();

            refreshTimer = new Timer();
            refreshTimer.Interval = 3600000; 
            refreshTimer.Tick += new EventHandler(RefreshData);
            refreshTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.setdesktoplocation(int x, int y);
            this.windowstate = formwindowstate.maximized;
            RefreshData(null, null);
        }

        private void RefreshData(object sender, EventArgs e)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument document = web.Load(url);

                //CLASS: MERKEZEFENDI ID:M1
                {
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczaneisim1_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczaneadres1_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczanetelefon1_html = web.Load(url);

                    HtmlNodeCollection merkezefendi_eczaneisim1_nodes = merkezefendi_eczaneisim1_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[3]/div/b");

                    HtmlNodeCollection merkezefendi_eczaneadres1_nodes = merkezefendi_eczaneadres1_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[3]/div/text()[2]");

                    HtmlNodeCollection merkezefendi_eczanetelefon1_nodes = merkezefendi_eczanetelefon1_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[3]/div/text()[4]");


                    string merkezefendi_eczaneisim1_data = "";
                    foreach (HtmlNode node in merkezefendi_eczaneisim1_nodes)
                    {
                        merkezefendi_eczaneisim1_data += node.InnerText + "\n";
                        merkezefendi_isimlabel1.Text = merkezefendi_eczaneisim1_data;
                    }


                    string merkezefendi_eczaneadres1_data = "";
                    foreach (HtmlNode node in merkezefendi_eczaneadres1_nodes)
                    {
                        merkezefendi_eczaneadres1_data += node.InnerText + "\n";
                        merkezefendi_adreslabel1.Text = merkezefendi_eczaneadres1_data;
                    }


                    string merkezefendi_eczanetelefon1_data = "";
                    foreach (HtmlNode node in merkezefendi_eczanetelefon1_nodes)
                    {
                        merkezefendi_eczanetelefon1_data += node.InnerText + "\n";
                        merkezefendi_telefonlabel1.Text = merkezefendi_eczanetelefon1_data;
                    }
                }



                //CLASS: MERKEZEFENDI ID:M2
                {
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczaneisim2_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczaneadres2_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczanetelefon2_html = web.Load(url);

                    HtmlNodeCollection merkezefendi_eczaneisim2_nodes = merkezefendi_eczaneisim2_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[4]/div/b");

                    HtmlNodeCollection merkezefendi_eczaneadres2_nodes = merkezefendi_eczaneadres2_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[4]/div/text()[2]");

                    HtmlNodeCollection merkezefendi_eczanetelefon2_nodes = merkezefendi_eczanetelefon2_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[4]/div/text()[4]");


                    string merkezefendi_eczaneisim2_data = "";
                    foreach (HtmlNode node in merkezefendi_eczaneisim2_nodes)
                    {
                        merkezefendi_eczaneisim2_data += node.InnerText + "\n";
                        merkezefendi_isimlabel2.Text = merkezefendi_eczaneisim2_data;
                    }


                    string merkezefendi_eczaneadres2_data = "";
                    foreach (HtmlNode node in merkezefendi_eczaneadres2_nodes)
                    {
                        merkezefendi_eczaneadres2_data += node.InnerText + "\n";
                        merkezefendi_adreslabel2.Text = merkezefendi_eczaneadres2_data;
                    }


                    string merkezefendi_eczanetelefon2_data = "";
                    foreach (HtmlNode node in merkezefendi_eczanetelefon2_nodes)
                    {
                        merkezefendi_eczanetelefon2_data += node.InnerText + "\n";
                        merkezefendi_telefonlabel2.Text = merkezefendi_eczanetelefon2_data;
                    }
                }



                //CLASS: MERKEZEFENDI ID:M3
                {
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczaneisim3_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczaneadres3_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczanetelefon3_html = web.Load(url);

                    HtmlNodeCollection merkezefendi_eczaneisim3_nodes = merkezefendi_eczaneisim3_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[5]/div/b");

                    HtmlNodeCollection merkezefendi_eczaneadres3_nodes = merkezefendi_eczaneadres3_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[5]/div/text()[2]");

                    HtmlNodeCollection merkezefendi_eczanetelefon3_nodes = merkezefendi_eczanetelefon3_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[5]/div/text()[4]");


                    string merkezefendi_eczaneisim3_data = "";
                    foreach (HtmlNode node in merkezefendi_eczaneisim3_nodes)
                    {
                        merkezefendi_eczaneisim3_data += node.InnerText + "\n";
                        merkezefendi_isimlabel3.Text = merkezefendi_eczaneisim3_data;
                    }


                    string merkezefendi_eczaneadres3_data = "";
                    foreach (HtmlNode node in merkezefendi_eczaneadres3_nodes)
                    {
                        merkezefendi_eczaneadres3_data += node.InnerText + "\n";
                        merkezefendi_adreslabel3.Text = merkezefendi_eczaneadres3_data;
                    }


                    string merkezefendi_eczanetelefon3_data = "";
                    foreach (HtmlNode node in merkezefendi_eczanetelefon3_nodes)
                    {
                        merkezefendi_eczanetelefon3_data += node.InnerText + "\n";
                        merkezefendi_telefonlabel3.Text = merkezefendi_eczanetelefon3_data;
                    }
                }



                //CLASS: MERKEZEFENDI ID:M4
                {
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczaneisim4_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczaneadres4_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczanetelefon4_html = web.Load(url);

                    HtmlNodeCollection merkezefendi_eczaneisim4_nodes = merkezefendi_eczaneisim4_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[6]/div/b");

                    HtmlNodeCollection merkezefendi_eczaneadres4_nodes = merkezefendi_eczaneadres4_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[6]/div/text()[2]");

                    HtmlNodeCollection merkezefendi_eczanetelefon4_nodes = merkezefendi_eczanetelefon4_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[6]/div/text()[4]");


                    string merkezefendi_eczaneisim4_data = "";
                    foreach (HtmlNode node in merkezefendi_eczaneisim4_nodes)
                    {
                        merkezefendi_eczaneisim4_data += node.InnerText + "\n";
                        merkezefendi_isimlabel4.Text = merkezefendi_eczaneisim4_data;
                    }


                    string merkezefendi_eczaneadres4_data = "";
                    foreach (HtmlNode node in merkezefendi_eczaneadres4_nodes)
                    {
                        merkezefendi_eczaneadres4_data += node.InnerText + "\n";
                        merkezefendi_adreslabel4.Text = merkezefendi_eczaneadres4_data;
                    }


                    string merkezefendi_eczanetelefon4_data = "";
                    foreach (HtmlNode node in merkezefendi_eczanetelefon4_nodes)
                    {
                        merkezefendi_eczanetelefon4_data += node.InnerText + "\n";
                        merkezefendi_telefonlabel4.Text = merkezefendi_eczanetelefon4_data;
                    }
                }



                //CLASS: MERKEZEFENDI ID:M5
                {
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczaneisim5_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczaneadres5_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument merkezefendi_eczanetelefon5_html = web.Load(url);

                    HtmlNodeCollection merkezefendi_eczaneisim5_nodes = merkezefendi_eczaneisim5_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[7]/div/b");

                    HtmlNodeCollection merkezefendi_eczaneadres5_nodes = merkezefendi_eczaneadres5_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[7]/div/text()[2]");

                    HtmlNodeCollection merkezefendi_eczanetelefon5_nodes = merkezefendi_eczanetelefon5_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[7]/div/text()[4]");


                    string merkezefendi_eczaneisim5_data = "";
                    foreach (HtmlNode node in merkezefendi_eczaneisim5_nodes)
                    {
                        merkezefendi_eczaneisim5_data += node.InnerText + "\n";
                        merkezefendi_isimlabel5.Text = merkezefendi_eczaneisim5_data;
                    }


                    string merkezefendi_eczaneadres5_data = "";
                    foreach (HtmlNode node in merkezefendi_eczaneadres5_nodes)
                    {
                        merkezefendi_eczaneadres5_data += node.InnerText + "\n";
                        merkezefendi_adreslabel5.Text = merkezefendi_eczaneadres5_data;
                    }


                    string merkezefendi_eczanetelefon5_data = "";
                    foreach (HtmlNode node in merkezefendi_eczanetelefon5_nodes)
                    {
                        merkezefendi_eczanetelefon5_data += node.InnerText + "\n";
                        merkezefendi_telefonlabel5.Text = merkezefendi_eczanetelefon5_data;
                    }
                }





                //CLASS: pamukkale ID:P1
                {
                    HtmlAgilityPack.HtmlDocument pamukkale_eczaneisim1_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument pamukkale_eczaneadres1_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument pamukkale_eczanetelefon1_html = web.Load(url);

                    HtmlNodeCollection pamukkale_eczaneisim1_nodes = pamukkale_eczaneisim1_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[8]/div/b");

                    HtmlNodeCollection pamukkale_eczaneadres1_nodes = pamukkale_eczaneadres1_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[8]/div/text()[2]");

                    HtmlNodeCollection pamukkale_eczanetelefon1_nodes = pamukkale_eczanetelefon1_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[8]/div/text()[4]");


                    string pamukkale_eczaneisim1_data = "";
                    foreach (HtmlNode node in pamukkale_eczaneisim1_nodes)
                    {
                        pamukkale_eczaneisim1_data += node.InnerText + "\n";
                        pamukkale_isimlabel1.Text = pamukkale_eczaneisim1_data;
                    }


                    string pamukkale_eczaneadres1_data = "";
                    foreach (HtmlNode node in pamukkale_eczaneadres1_nodes)
                    {
                        pamukkale_eczaneadres1_data += node.InnerText + "\n";
                        pamukkale_adreslabel1.Text = pamukkale_eczaneadres1_data;
                    }


                    string pamukkale_eczanetelefon1_data = "";
                    foreach (HtmlNode node in pamukkale_eczanetelefon1_nodes)
                    {
                        pamukkale_eczanetelefon1_data += node.InnerText + "\n";
                        pamukkale_telefonlabel1.Text = pamukkale_eczanetelefon1_data;
                    }
                }



                //CLASS: pamukkale ID:P2
                {
                    HtmlAgilityPack.HtmlDocument pamukkale_eczaneisim2_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument pamukkale_eczaneadres2_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument pamukkale_eczanetelefon2_html = web.Load(url);

                    HtmlNodeCollection pamukkale_eczaneisim2_nodes = pamukkale_eczaneisim2_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[9]/div/b");

                    HtmlNodeCollection pamukkale_eczaneadres2_nodes = pamukkale_eczaneadres2_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[9]/div/text()[2]");

                    HtmlNodeCollection pamukkale_eczanetelefon2_nodes = pamukkale_eczanetelefon2_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[9]/div/text()[4]");


                    string pamukkale_eczaneisim2_data = "";
                    foreach (HtmlNode node in pamukkale_eczaneisim2_nodes)
                    {
                        pamukkale_eczaneisim2_data += node.InnerText + "\n";
                        pamukkale_isimlabel2.Text = pamukkale_eczaneisim2_data;
                    }


                    string pamukkale_eczaneadres2_data = "";
                    foreach (HtmlNode node in pamukkale_eczaneadres2_nodes)
                    {
                        pamukkale_eczaneadres2_data += node.InnerText + "\n";
                        pamukkale_adreslabel2.Text = pamukkale_eczaneadres2_data;
                    }


                    string pamukkale_eczanetelefon2_data = "";
                    foreach (HtmlNode node in pamukkale_eczanetelefon2_nodes)
                    {
                        pamukkale_eczanetelefon2_data += node.InnerText + "\n";
                        pamukkale_telefonlabel2.Text = pamukkale_eczanetelefon2_data;
                    }
                }



                //CLASS: pamukkale ID:P3
                {
                    HtmlAgilityPack.HtmlDocument pamukkale_eczaneisim3_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument pamukkale_eczaneadres3_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument pamukkale_eczanetelefon3_html = web.Load(url);

                    HtmlNodeCollection pamukkale_eczaneisim3_nodes = pamukkale_eczaneisim3_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[10]/div/b");

                    HtmlNodeCollection pamukkale_eczaneadres3_nodes = pamukkale_eczaneadres3_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[10]/div/text()[2]");

                    HtmlNodeCollection pamukkale_eczanetelefon3_nodes = pamukkale_eczanetelefon3_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[10]/div/text()[4]");


                    string pamukkale_eczaneisim3_data = "";
                    foreach (HtmlNode node in pamukkale_eczaneisim3_nodes)
                    {
                        pamukkale_eczaneisim3_data += node.InnerText + "\n";
                        pamukkale_isimlabel3.Text = pamukkale_eczaneisim3_data;
                    }


                    string pamukkale_eczaneadres3_data = "";
                    foreach (HtmlNode node in pamukkale_eczaneadres3_nodes)
                    {
                        pamukkale_eczaneadres3_data += node.InnerText + "\n";
                        pamukkale_adreslabel3.Text = pamukkale_eczaneadres3_data;
                    }


                    string pamukkale_eczanetelefon3_data = "";
                    foreach (HtmlNode node in pamukkale_eczanetelefon3_nodes)
                    {
                        pamukkale_eczanetelefon3_data += node.InnerText + "\n";
                        pamukkale_telefonlabel3.Text = pamukkale_eczanetelefon3_data;
                    }
                }



                //CLASS: pamukkale ID:P4
                {
                    HtmlAgilityPack.HtmlDocument pamukkale_eczaneisim4_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument pamukkale_eczaneadres4_html = web.Load(url);
                    HtmlAgilityPack.HtmlDocument pamukkale_eczanetelefon4_html = web.Load(url);

                    HtmlNodeCollection pamukkale_eczaneisim4_nodes = pamukkale_eczaneisim4_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[11]/div/b");

                    HtmlNodeCollection pamukkale_eczaneadres4_nodes = pamukkale_eczaneadres4_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[11]/div/text()[2]");

                    HtmlNodeCollection pamukkale_eczanetelefon4_nodes = pamukkale_eczanetelefon4_html.DocumentNode.SelectNodes
                        ("//*[@id=\"ctl14_rightcontent\"]/div[11]/div/text()[4]");


                    string pamukkale_eczaneisim4_data = "";
                    foreach (HtmlNode node in pamukkale_eczaneisim4_nodes)
                    {
                        pamukkale_eczaneisim4_data += node.InnerText + "\n";
                        pamukkale_isimlabel4.Text = pamukkale_eczaneisim4_data;
                    }


                    string pamukkale_eczaneadres4_data = "";
                    foreach (HtmlNode node in pamukkale_eczaneadres4_nodes)
                    {
                        pamukkale_eczaneadres4_data += node.InnerText + "\n";
                        pamukkale_adreslabel4.Text = pamukkale_eczaneadres4_data;

                    }


                    string pamukkale_eczanetelefon4_data = "";
                    foreach (HtmlNode node in pamukkale_eczanetelefon4_nodes)
                    {
                        pamukkale_eczanetelefon4_data += node.InnerText + "\n";
                        pamukkale_telefonlabel4.Text = pamukkale_eczanetelefon4_data;
                    }
                }


                foreach (System.Windows.Forms.Label label in this.Controls.OfType<System.Windows.Forms.Label>())
                {
                    this.Controls.Add(label);
                }
            }
            catch (Exception ex)
            {
                // Hata yönetimi: Veri çekme sırasında bir hata olursa burada işlenebilir.
                MessageBox.Show("Veri çekerken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
