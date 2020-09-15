using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace İddaatahminprgrm
{
    public partial class Form6 : Form
    {
        public String html;
        public Uri url;
        public Form6()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        private void eB_Button3_Click(object sender, EventArgs e)
        {
            label74.Text = "Maçlar Çekiliyor ... ";
            progressBar1.Value = 0;
            for (int i = 3; i < 19; i++)
            {
                progressBar1.Value += 2;




                VeriAl("https://www.nesine.com/iddaa/populer-bahisler ", "//*[@id='divBasketballPartial']/div[1]/div[" + i + "]/div[2]/span[1]", listBox7);//tarih

                VeriAl("https://www.nesine.com/iddaa/populer-bahisler ", "//*[@id='divBasketballPartial']/div[1]/div[" + i + "]/div[2]/span[2]", listBox8);// saat

                VeriAl("https://www.nesine.com/iddaa/populer-bahisler ", "//*[@id='divBasketballPartial']/div[1]/div[" + i + "]/div[3]/span/a", listBox9);// karşılaşma

                VeriAl("https://www.nesine.com/iddaa/populer-bahisler ", "//*[@id='divBasketballPartial']/div[1]/div[" + i + "]/div[5]/div[2]", listBox10); // ms-kg

                VeriAl("https://www.nesine.com/iddaa/populer-bahisler ", "//*[@id='divBasketballPartial']/div[1]/div[" + i + "]/div[6]/span", listBox11); // oran

                VeriAl("https://www.nesine.com/iddaa/populer-bahisler ", "//*[@id='divBasketballPartial']/div[1]/div[" + i + "]/div[7]/strong", listBox12); // oynanma

            }


            progressBar1.Value = 100;

            label74.Text = "Maçlar Çekildi !";
        }
        public void VeriAl(String Url, String XPath, ListBox CikanSonuc)
        {
            try
            {
                url = new Uri(Url);
            }
            catch (UriFormatException)
            {


            }
            catch (ArgumentNullException)
            {

            }

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;

            html = client.DownloadString(url);
            html = html.Replace("&#231;", "ç");
            html = html.Replace("&#252;", "ü");
            html = html.Replace("&#246;", "ö");
            html = html.Replace("&#220;", "ü");
            html = html.Replace("&#39;", "ö");
            html = html.Replace("&#199;", "Ç");
            try
            {


            }
            catch (WebException)
            {

            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {

                CikanSonuc.Items.Add(doc.DocumentNode.SelectSingleNode(XPath).InnerText);


            }
            catch (NullReferenceException)
            {

            }
        }
        private void eB_Button2_Click(object sender, EventArgs e)
        {
            Form3 frmbasket = new Form3();
            tablo.Columns.Add("TARİH", typeof(string));
            tablo.Columns.Add("SAAT", typeof(string));
            tablo.Columns.Add("KARŞILAŞMA", typeof(string));
            tablo.Columns.Add("MS - KG", typeof(string));
            tablo.Columns.Add("ORAN", typeof(string));
            tablo.Columns.Add("OYNANMA", typeof(string));



            for (int a = 0; a < listBox7.Items.Count; a++)
            {

                tablo.Rows.Add(listBox7.Items[a].ToString(), listBox8.Items[a].ToString(), listBox9.Items[a].ToString(), listBox10.Items[a].ToString(), listBox11.Items[a].ToString(), listBox12.Items[a].ToString());
                frmbasket.dataGridView1.DataSource = tablo;

            }



            frmbasket.Show();
        }
        int tiklamaa = 0;
        private void eB_Button1_Click(object sender, EventArgs e)
        {
            tiklamaa++;
            if (tiklamaa == 1)
            {

                label80.Text = Convert.ToString(listBox9.Items[2 - 2]);//karşılaşma
                label85.Text = Convert.ToString(listBox10.Items[2 - 2]);// ms
                label89.Text = Convert.ToString(listBox11.Items[2 - 2]);// oran
                label78.Text = Convert.ToString(listBox8.Items[2 - 2]);// saat
                label79.Text = Convert.ToString(listBox7.Items[2 - 2]); // Gün

                label90.Text = Convert.ToString(listBox11.Items[3 - 2]);//oran
                label92.Text = Convert.ToString(listBox9.Items[3 - 2]);// karşılaşma
                label91.Text = Convert.ToString(listBox10.Items[3 - 2]);//ms
                label87.Text = Convert.ToString(listBox8.Items[3 - 2]);// saat
                label88.Text = Convert.ToString(listBox7.Items[3 - 2]); // Gün

                label81.Text = Convert.ToString(listBox11.Items[4 - 2]);//oran
                label86.Text = Convert.ToString(listBox9.Items[4 - 2]);// karşılaşma
                label82.Text = Convert.ToString(listBox10.Items[4 - 2]);//ms
                label83.Text = Convert.ToString(listBox8.Items[4 - 2]);// saat
                label84.Text = Convert.ToString(listBox7.Items[4 - 2]); // Gün

                ////////////////////////////////////////////////////////////




                label77.Text = (float.Parse(label89.Text) * float.Parse(label90.Text) * float.Parse(label81.Text)).ToString();

            }
            else if (tiklamaa == 2)
            {

                label80.Text = Convert.ToString(listBox9.Items[5 - 2]);//karşılaşma
                label85.Text = Convert.ToString(listBox10.Items[5 - 2]);// ms
                label89.Text = Convert.ToString(listBox11.Items[5 - 2]);// oran
                label78.Text = Convert.ToString(listBox8.Items[5 - 2]);// saat
                label79.Text = Convert.ToString(listBox7.Items[5 - 2]); // Gün

                label90.Text = Convert.ToString(listBox11.Items[6 - 2]);//oran
                label92.Text = Convert.ToString(listBox9.Items[6 - 2]);// karşılaşma
                label91.Text = Convert.ToString(listBox10.Items[6 - 2]);//ms
                label87.Text = Convert.ToString(listBox8.Items[6 - 2]);// saat
                label88.Text = Convert.ToString(listBox7.Items[6 - 2]); // Gün

                label81.Text = Convert.ToString(listBox11.Items[7 - 2]);//oran
                label86.Text = Convert.ToString(listBox9.Items[7 - 2]);// karşılaşma
                label82.Text = Convert.ToString(listBox10.Items[7 - 2]);//ms
                label83.Text = Convert.ToString(listBox8.Items[7 - 2]);// saat
                label84.Text = Convert.ToString(listBox7.Items[7 - 2]); // Gün

                ////////////////////////////////////////////////////////////




                label77.Text = (float.Parse(label89.Text) * float.Parse(label90.Text) * float.Parse(label81.Text)).ToString();

            }
            else if (tiklamaa == 3)
            {

                label80.Text = Convert.ToString(listBox9.Items[8 - 2]);//karşılaşma
                label85.Text = Convert.ToString(listBox10.Items[8 - 2]);// ms
                label89.Text = Convert.ToString(listBox11.Items[8 - 2]);// oran
                label78.Text = Convert.ToString(listBox8.Items[8 - 2]);// saat
                label79.Text = Convert.ToString(listBox7.Items[8 - 2]); // Gün

                label90.Text = Convert.ToString(listBox11.Items[9 - 2]);//oran
                label92.Text = Convert.ToString(listBox9.Items[9 - 2]);// karşılaşma
                label91.Text = Convert.ToString(listBox10.Items[9 - 2]);//ms
                label87.Text = Convert.ToString(listBox8.Items[9 - 2]);// saat
                label88.Text = Convert.ToString(listBox7.Items[9 - 2]); // Gün

                label81.Text = Convert.ToString(listBox11.Items[10 - 2]);//oran
                label86.Text = Convert.ToString(listBox9.Items[10 - 2]);// karşılaşma
                label82.Text = Convert.ToString(listBox10.Items[10 - 2]);//ms
                label83.Text = Convert.ToString(listBox8.Items[10 - 2]);// saat
                label84.Text = Convert.ToString(listBox7.Items[10 - 2]); // Gün

                ////////////////////////////////////////////////////////////




                label77.Text = (float.Parse(label89.Text) * float.Parse(label90.Text) * float.Parse(label81.Text)).ToString();

            }
            else if (tiklamaa == 4)
            {

                label80.Text = Convert.ToString(listBox9.Items[11 - 2]);//karşılaşma
                label85.Text = Convert.ToString(listBox10.Items[11 - 2]);// ms
                label89.Text = Convert.ToString(listBox11.Items[11 - 2]);// oran
                label78.Text = Convert.ToString(listBox8.Items[11 - 2]);// saat
                label79.Text = Convert.ToString(listBox7.Items[11 - 2]); // Gün

                label90.Text = Convert.ToString(listBox11.Items[12 - 2]);//oran
                label92.Text = Convert.ToString(listBox9.Items[12 - 2]);// karşılaşma
                label91.Text = Convert.ToString(listBox10.Items[12 - 2]);//ms
                label87.Text = Convert.ToString(listBox8.Items[12 - 2]);// saat
                label88.Text = Convert.ToString(listBox7.Items[12 - 2]); // Gün

                label81.Text = Convert.ToString(listBox11.Items[13 - 2]);//oran
                label86.Text = Convert.ToString(listBox9.Items[13 - 2]);// karşılaşma
                label82.Text = Convert.ToString(listBox10.Items[13 - 2]);//ms
                label83.Text = Convert.ToString(listBox8.Items[13 - 2]);// saat
                label84.Text = Convert.ToString(listBox7.Items[13 - 2]); // Gün

                ////////////////////////////////////////////////////////////




                label77.Text = (float.Parse(label89.Text) * float.Parse(label90.Text) * float.Parse(label81.Text)).ToString();

            }
            else if (tiklamaa == 5)
            {

                label80.Text = Convert.ToString(listBox9.Items[14 - 2]);//karşılaşma
                label85.Text = Convert.ToString(listBox10.Items[14 - 2]);// ms
                label89.Text = Convert.ToString(listBox11.Items[14 - 2]);// oran
                label78.Text = Convert.ToString(listBox8.Items[14 - 2]);// saat
                label79.Text = Convert.ToString(listBox7.Items[14 - 2]); // Gün

                label90.Text = Convert.ToString(listBox11.Items[15 - 2]);//oran
                label92.Text = Convert.ToString(listBox9.Items[15 - 2]);// karşılaşma
                label91.Text = Convert.ToString(listBox10.Items[15 - 2]);//ms
                label87.Text = Convert.ToString(listBox8.Items[15 - 2]);// saat
                label88.Text = Convert.ToString(listBox7.Items[15 - 2]); // Gün

                label81.Text = Convert.ToString(listBox11.Items[16 - 2]);//oran
                label86.Text = Convert.ToString(listBox9.Items[16 - 2]);// karşılaşma
                label82.Text = Convert.ToString(listBox10.Items[16 - 2]);//ms
                label83.Text = Convert.ToString(listBox8.Items[16 - 2]);// saat
                label84.Text = Convert.ToString(listBox7.Items[16 - 2]); // Gün

                ////////////////////////////////////////////////////////////




                label77.Text = (float.Parse(label89.Text) * float.Parse(label90.Text) * float.Parse(label81.Text)).ToString();

            }
            else if (tiklamaa == 6)
            {

                label80.Text = Convert.ToString(listBox9.Items[17 - 2]);//karşılaşma
                label85.Text = Convert.ToString(listBox10.Items[17 - 2]);// ms
                label89.Text = Convert.ToString(listBox11.Items[17 - 2]);// oran
                label78.Text = Convert.ToString(listBox8.Items[17 - 2]);// saat
                label79.Text = Convert.ToString(listBox7.Items[17 - 2]); // Gün

                label90.Text = Convert.ToString(listBox11.Items[11 - 2]);//oran
                label92.Text = Convert.ToString(listBox9.Items[11 - 2]);// karşılaşma
                label91.Text = Convert.ToString(listBox10.Items[11 - 2]);//ms
                label87.Text = Convert.ToString(listBox8.Items[11 - 2]);// saat
                label88.Text = Convert.ToString(listBox7.Items[11 - 2]); // Gün

                label81.Text = Convert.ToString(listBox11.Items[4 - 2]);//oran
                label86.Text = Convert.ToString(listBox9.Items[4 - 2]);// karşılaşma
                label82.Text = Convert.ToString(listBox10.Items[4 - 2]);//ms
                label83.Text = Convert.ToString(listBox8.Items[4 - 2]);// saat
                label84.Text = Convert.ToString(listBox7.Items[4 - 2]); // Gün

                ////////////////////////////////////////////////////////////




                label77.Text = (float.Parse(label89.Text) * float.Parse(label90.Text) * float.Parse(label81.Text)).ToString();

            }
            else if (tiklamaa == 7)
            {

                label80.Text = Convert.ToString(listBox9.Items[7 - 2]);//karşılaşma
                label85.Text = Convert.ToString(listBox10.Items[7 - 2]);// ms
                label89.Text = Convert.ToString(listBox11.Items[7 - 2]);// oran
                label78.Text = Convert.ToString(listBox8.Items[7 - 2]);// saat
                label79.Text = Convert.ToString(listBox7.Items[7 - 2]); // Gün

                label90.Text = Convert.ToString(listBox11.Items[11 - 2]);//oran
                label92.Text = Convert.ToString(listBox9.Items[11 - 2]);// karşılaşma
                label91.Text = Convert.ToString(listBox10.Items[11 - 2]);//ms
                label87.Text = Convert.ToString(listBox8.Items[11 - 2]);// saat
                label88.Text = Convert.ToString(listBox7.Items[1 - 2]); // Gün

                label81.Text = Convert.ToString(listBox11.Items[3 - 2]);//oran
                label86.Text = Convert.ToString(listBox9.Items[3 - 2]);// karşılaşma
                label82.Text = Convert.ToString(listBox10.Items[3 - 2]);//ms
                label83.Text = Convert.ToString(listBox8.Items[3 - 2]);// saat
                label84.Text = Convert.ToString(listBox7.Items[3 - 2]); // Gün

                ////////////////////////////////////////////////////////////

                tiklamaa = 0;


                label77.Text = (float.Parse(label89.Text) * float.Parse(label90.Text) * float.Parse(label81.Text)).ToString();

            }
        }

        private void eB_Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
