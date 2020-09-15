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
    public partial class Form5 : Form
    {
        public String html;
        public Uri url;
        public Form5()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void eB_Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Maçlar Çekiliyor ... ";
            progressBar1.Value = 0;
            for (int i = 3; i < 52; i++)
            {
                progressBar1.Value += 2;


                VeriAl("https://www.nesine.com/iddaa/populer-bahisler ", "//*[@id='divFootballPartial']/div[1]/div[" + i + "]/div[3]", listBox1);

                VeriAl("https://www.nesine.com/iddaa/populer-bahisler ", "//*[@id='divFootballPartial']/div[1]/div[" + i + "]/div[5]/div[2]", listBox2);

                VeriAl("https://www.nesine.com/iddaa/populer-bahisler ", "//*[@id='divFootballPartial']/div[1]/div[" + i + "]/div[6]/span", listBox3);

                VeriAl("https://www.nesine.com/iddaa/populer-bahisler ", "//*[@id='divFootballPartial']/div[1]/div[" + i + "]/div[2]/span[2]", listBox4);

                VeriAl("https://www.nesine.com/iddaa/populer-bahisler ", " //*[@id='divFootballPartial']/div[1]/div[" + i + "]/div[7]/strong", listBox5);

                VeriAl("https://www.nesine.com/iddaa/populer-bahisler ", "//*[@id='divFootballPartial']/div[1]/div[" + i + "]/div[2]/span[1]", listBox6);

            }


            progressBar1.Value = 100;

            label1.Text = "Maçlar Çekildi !";
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
            Form2 frm = new Form2();

            tablo.Columns.Add("TARİH", typeof(string));
            tablo.Columns.Add("SAAT", typeof(string));
            tablo.Columns.Add("KARŞILAŞMA", typeof(string));
            tablo.Columns.Add("MS - KG", typeof(string));
            tablo.Columns.Add("ORAN", typeof(string));
            tablo.Columns.Add("OYNANMA", typeof(string));

            // tablo.Columns.Add("KARŞILAŞMA", typeof(string));
            //tablo.Columns.Add("MS - KG", typeof(string));
            //tablo.Columns.Add("ORAN", typeof(string));
            // tablo.Columns.Add("SAAT", typeof(string));
            //tablo.Columns.Add("TARİH", typeof(string));
            //  tablo.Columns.Add("OYNANMA", typeof(string));
            // frm.dataGridView1.DataSource = tablo;

            for (int a = 0; a < listBox1.Items.Count; a++)
            {

                tablo.Rows.Add(listBox6.Items[a].ToString(), listBox4.Items[a].ToString(), listBox1.Items[a].ToString(), listBox2.Items[a].ToString(), listBox3.Items[a].ToString(), listBox5.Items[a].ToString());
                frm.dataGridView1.DataSource = tablo;

            }

            frm.Show();
        }
        int tiklama = 0;
        private void eB_Button3_Click(object sender, EventArgs e)
        {
            tiklama++;
            if (tiklama == 1)
            {

                label7.Text = Convert.ToString(listBox1.Items[2 - 2]);//karşılaşma
                label12.Text = Convert.ToString(listBox2.Items[2 - 2]);// ms
                label16.Text = Convert.ToString(listBox3.Items[2 - 2]);// oran
                label5.Text = Convert.ToString(listBox4.Items[2 - 2]);// saat
                label6.Text = Convert.ToString(listBox6.Items[2 - 2]); // Gün

                label17.Text = Convert.ToString(listBox3.Items[3 - 2]);//oran
                label19.Text = Convert.ToString(listBox1.Items[3 - 2]);// karşılaşma
                label18.Text = Convert.ToString(listBox2.Items[3 - 2]);//ms
                label14.Text = Convert.ToString(listBox4.Items[3 - 2]);// saat
                label15.Text = Convert.ToString(listBox6.Items[3 - 2]); // Gün

                label8.Text = Convert.ToString(listBox3.Items[4 - 2]);//oran
                label13.Text = Convert.ToString(listBox1.Items[4 - 2]);// karşılaşma
                label9.Text = Convert.ToString(listBox2.Items[4 - 2]);//ms
                label10.Text = Convert.ToString(listBox4.Items[4 - 2]);// saat
                label11.Text = Convert.ToString(listBox6.Items[4 - 2]); // Gün

                ////////////////////////////////////////////////////////////

                label31.Text = Convert.ToString(listBox3.Items[5 - 2]);//oran
                label27.Text = Convert.ToString(listBox1.Items[5 - 2]);// karşılaşma
                label29.Text = Convert.ToString(listBox2.Items[5 - 2]);//ms
                label24.Text = Convert.ToString(listBox4.Items[5 - 2]);// saat
                label25.Text = Convert.ToString(listBox6.Items[5 - 2]); // Gün

                label36.Text = Convert.ToString(listBox3.Items[6 - 2]);//oran
                label23.Text = Convert.ToString(listBox1.Items[6 - 2]);// karşılaşma
                label37.Text = Convert.ToString(listBox2.Items[6 - 2]);//ms
                label34.Text = Convert.ToString(listBox4.Items[6 - 2]);// saat
                label35.Text = Convert.ToString(listBox6.Items[6 - 2]); // Gün

                label26.Text = Convert.ToString(listBox3.Items[7 - 2]);//oran
                label30.Text = Convert.ToString(listBox1.Items[7 - 2]);// karşılaşma
                label28.Text = Convert.ToString(listBox2.Items[7 - 2]);//ms
                label32.Text = Convert.ToString(listBox4.Items[7 - 2]);// saat
                label33.Text = Convert.ToString(listBox6.Items[7 - 2]); // Gün

                ///////////////////////////////////////////////////////////

                label43.Text = Convert.ToString(listBox1.Items[8 - 2]);//karşılaşma
                label46.Text = Convert.ToString(listBox2.Items[8 - 2]);// ms
                label50.Text = Convert.ToString(listBox3.Items[8 - 2]);// oran
                label41.Text = Convert.ToString(listBox4.Items[8 - 2]);// saat
                label42.Text = Convert.ToString(listBox6.Items[8 - 2]); // Gün

                label51.Text = Convert.ToString(listBox3.Items[9 - 2]);//oran
                label55.Text = Convert.ToString(listBox1.Items[9 - 2]);// karşılaşma
                label52.Text = Convert.ToString(listBox2.Items[9 - 2]);//ms
                label53.Text = Convert.ToString(listBox4.Items[9 - 2]);// saat
                label54.Text = Convert.ToString(listBox6.Items[9 - 2]); // Gün

                label44.Text = Convert.ToString(listBox3.Items[10 - 2]);//oran
                label47.Text = Convert.ToString(listBox1.Items[10 - 2]);// karşılaşma
                label45.Text = Convert.ToString(listBox2.Items[10 - 2]);//ms
                label48.Text = Convert.ToString(listBox4.Items[10 - 2]);// saat
                label49.Text = Convert.ToString(listBox6.Items[10 - 2]); // Gün

                //////////////////////////////////////////////////////////

                label67.Text = Convert.ToString(listBox3.Items[11 - 2]);//oran
                label63.Text = Convert.ToString(listBox1.Items[11 - 2]);// karşılaşma
                label65.Text = Convert.ToString(listBox2.Items[11 - 2]);//ms
                label60.Text = Convert.ToString(listBox4.Items[11 - 2]);// saat
                label61.Text = Convert.ToString(listBox6.Items[11 - 2]); // Gün

                label72.Text = Convert.ToString(listBox3.Items[12 - 2]);//oran
                label59.Text = Convert.ToString(listBox1.Items[12 - 2]);// karşılaşma
                label73.Text = Convert.ToString(listBox2.Items[12 - 2]);//ms
                label70.Text = Convert.ToString(listBox4.Items[12 - 2]);// saat
                label71.Text = Convert.ToString(listBox6.Items[12 - 2]); // Gün


                label62.Text = Convert.ToString(listBox3.Items[13 - 2]);//oran
                label66.Text = Convert.ToString(listBox1.Items[13 - 2]);// karşılaşma
                label64.Text = Convert.ToString(listBox2.Items[13 - 2]);//ms
                label68.Text = Convert.ToString(listBox4.Items[13 - 2]);// saat
                label69.Text = Convert.ToString(listBox6.Items[13 - 2]); // Gün




                label4.Text = (float.Parse(label16.Text) * float.Parse(label17.Text) * float.Parse(label8.Text)).ToString();
                label22.Text = (float.Parse(label31.Text) * float.Parse(label36.Text) * float.Parse(label26.Text)).ToString();
                label40.Text = (float.Parse(label50.Text) * float.Parse(label51.Text) * float.Parse(label44.Text)).ToString();
                label58.Text = (float.Parse(label67.Text) * float.Parse(label72.Text) * float.Parse(label62.Text)).ToString();

            }
            else if (tiklama == 2)
            {


                label7.Text = Convert.ToString(listBox1.Items[14 - 2]);//karşılaşma
                label12.Text = Convert.ToString(listBox2.Items[14 - 2]);// ms
                label16.Text = Convert.ToString(listBox3.Items[14 - 2]);// oran
                label5.Text = Convert.ToString(listBox4.Items[14 - 2]);// saat
                label6.Text = Convert.ToString(listBox6.Items[14 - 2]); // Gün

                label17.Text = Convert.ToString(listBox3.Items[15 - 2]);//oran
                label19.Text = Convert.ToString(listBox1.Items[15 - 2]);// karşılaşma
                label18.Text = Convert.ToString(listBox2.Items[15 - 2]);//ms
                label14.Text = Convert.ToString(listBox4.Items[15 - 2]);// saat
                label15.Text = Convert.ToString(listBox6.Items[15 - 2]); // Gün

                label8.Text = Convert.ToString(listBox3.Items[16 - 2]);//oran
                label13.Text = Convert.ToString(listBox1.Items[16 - 2]);// karşılaşma
                label9.Text = Convert.ToString(listBox2.Items[16 - 2]);//ms
                label10.Text = Convert.ToString(listBox4.Items[16 - 2]);// saat
                label11.Text = Convert.ToString(listBox6.Items[16 - 2]); // Gün

                ////////////////////////////////////////////////////////////

                label31.Text = Convert.ToString(listBox3.Items[17 - 2]);//oran
                label27.Text = Convert.ToString(listBox1.Items[17 - 2]);// karşılaşma
                label29.Text = Convert.ToString(listBox2.Items[17 - 2]);//ms
                label24.Text = Convert.ToString(listBox4.Items[17 - 2]);// saat
                label25.Text = Convert.ToString(listBox6.Items[17 - 2]); // Gün

                label36.Text = Convert.ToString(listBox3.Items[18 - 2]);//oran
                label23.Text = Convert.ToString(listBox1.Items[18 - 2]);// karşılaşma
                label37.Text = Convert.ToString(listBox2.Items[18 - 2]);//ms
                label34.Text = Convert.ToString(listBox4.Items[18 - 2]);// saat
                label35.Text = Convert.ToString(listBox6.Items[18 - 2]); // Gün

                label26.Text = Convert.ToString(listBox3.Items[19 - 2]);//oran
                label30.Text = Convert.ToString(listBox1.Items[19 - 2]);// karşılaşma
                label28.Text = Convert.ToString(listBox2.Items[19 - 2]);//ms
                label32.Text = Convert.ToString(listBox4.Items[19 - 2]);// saat
                label33.Text = Convert.ToString(listBox6.Items[19 - 2]); // Gün

                ///////////////////////////////////////////////////////////

                label43.Text = Convert.ToString(listBox1.Items[20 - 2]);//karşılaşma
                label46.Text = Convert.ToString(listBox2.Items[20 - 2]);// ms
                label50.Text = Convert.ToString(listBox3.Items[20 - 2]);// oran
                label41.Text = Convert.ToString(listBox4.Items[20 - 2]);// saat
                label42.Text = Convert.ToString(listBox6.Items[20 - 2]); // Gün

                label51.Text = Convert.ToString(listBox3.Items[21 - 2]);//oran
                label55.Text = Convert.ToString(listBox1.Items[21 - 2]);// karşılaşma
                label52.Text = Convert.ToString(listBox2.Items[21 - 2]);//ms
                label53.Text = Convert.ToString(listBox4.Items[21 - 2]);// saat
                label54.Text = Convert.ToString(listBox6.Items[21 - 2]); // Gün

                label44.Text = Convert.ToString(listBox3.Items[22 - 2]);//oran
                label47.Text = Convert.ToString(listBox1.Items[22 - 2]);// karşılaşma
                label45.Text = Convert.ToString(listBox2.Items[22 - 2]);//ms
                label48.Text = Convert.ToString(listBox4.Items[22 - 2]);// saat
                label49.Text = Convert.ToString(listBox6.Items[22 - 2]); // Gün

                //////////////////////////////////////////////////////////

                label67.Text = Convert.ToString(listBox3.Items[23 - 2]);//oran
                label63.Text = Convert.ToString(listBox1.Items[23 - 2]);// karşılaşma
                label65.Text = Convert.ToString(listBox2.Items[23 - 2]);//ms
                label60.Text = Convert.ToString(listBox4.Items[23 - 2]);// saat
                label61.Text = Convert.ToString(listBox6.Items[23 - 2]); // Gün

                label72.Text = Convert.ToString(listBox3.Items[24 - 2]);//oran
                label59.Text = Convert.ToString(listBox1.Items[24 - 2]);// karşılaşma
                label73.Text = Convert.ToString(listBox2.Items[24 - 2]);//ms
                label70.Text = Convert.ToString(listBox4.Items[24 - 2]);// saat
                label71.Text = Convert.ToString(listBox6.Items[24 - 2]); // Gün


                label62.Text = Convert.ToString(listBox3.Items[25 - 2]);//oran
                label66.Text = Convert.ToString(listBox1.Items[25 - 2]);// karşılaşma
                label64.Text = Convert.ToString(listBox2.Items[25 - 2]);//ms
                label68.Text = Convert.ToString(listBox4.Items[25 - 2]);// saat
                label69.Text = Convert.ToString(listBox6.Items[25 - 2]); // Gün




                label4.Text = (float.Parse(label16.Text) * float.Parse(label17.Text) * float.Parse(label8.Text)).ToString();
                label22.Text = (float.Parse(label31.Text) * float.Parse(label36.Text) * float.Parse(label26.Text)).ToString();
                label40.Text = (float.Parse(label50.Text) * float.Parse(label51.Text) * float.Parse(label44.Text)).ToString();
                label58.Text = (float.Parse(label67.Text) * float.Parse(label72.Text) * float.Parse(label62.Text)).ToString();
            }
            else if (tiklama == 3)
            {


                label7.Text = Convert.ToString(listBox1.Items[26 - 2]);//karşılaşma
                label12.Text = Convert.ToString(listBox2.Items[26 - 2]);// ms
                label16.Text = Convert.ToString(listBox3.Items[26 - 2]);// oran
                label5.Text = Convert.ToString(listBox4.Items[26 - 2]);// saat
                label6.Text = Convert.ToString(listBox6.Items[26 - 2]); // Gün

                label17.Text = Convert.ToString(listBox3.Items[27 - 2]);//oran
                label19.Text = Convert.ToString(listBox1.Items[27 - 2]);// karşılaşma
                label18.Text = Convert.ToString(listBox2.Items[27 - 2]);//ms
                label14.Text = Convert.ToString(listBox4.Items[27 - 2]);// saat
                label15.Text = Convert.ToString(listBox6.Items[27 - 2]); // Gün

                label8.Text = Convert.ToString(listBox3.Items[28 - 2]);//oran
                label13.Text = Convert.ToString(listBox1.Items[28 - 2]);// karşılaşma
                label9.Text = Convert.ToString(listBox2.Items[28 - 2]);//ms
                label10.Text = Convert.ToString(listBox4.Items[28 - 2]);// saat
                label11.Text = Convert.ToString(listBox6.Items[28 - 2]); // Gün

                ////////////////////////////////////////////////////////////

                label31.Text = Convert.ToString(listBox3.Items[29 - 2]);//oran
                label27.Text = Convert.ToString(listBox1.Items[29 - 2]);// karşılaşma
                label29.Text = Convert.ToString(listBox2.Items[29 - 2]);//ms
                label24.Text = Convert.ToString(listBox4.Items[29 - 2]);// saat
                label25.Text = Convert.ToString(listBox6.Items[29 - 2]); // Gün

                label36.Text = Convert.ToString(listBox3.Items[30 - 2]);//oran
                label23.Text = Convert.ToString(listBox1.Items[30 - 2]);// karşılaşma
                label37.Text = Convert.ToString(listBox2.Items[30 - 2]);//ms
                label34.Text = Convert.ToString(listBox4.Items[30 - 2]);// saat
                label35.Text = Convert.ToString(listBox6.Items[30 - 2]); // Gün

                label26.Text = Convert.ToString(listBox3.Items[31 - 2]);//oran
                label30.Text = Convert.ToString(listBox1.Items[31 - 2]);// karşılaşma
                label28.Text = Convert.ToString(listBox2.Items[31 - 2]);//ms
                label32.Text = Convert.ToString(listBox4.Items[31 - 2]);// saat
                label33.Text = Convert.ToString(listBox6.Items[31 - 2]); // Gün

                ///////////////////////////////////////////////////////////

                label43.Text = Convert.ToString(listBox1.Items[32 - 2]);//karşılaşma
                label46.Text = Convert.ToString(listBox2.Items[32 - 2]);// ms
                label50.Text = Convert.ToString(listBox3.Items[32 - 2]);// oran
                label41.Text = Convert.ToString(listBox4.Items[32 - 2]);// saat
                label42.Text = Convert.ToString(listBox6.Items[32 - 2]); // Gün

                label51.Text = Convert.ToString(listBox3.Items[33 - 2]);//oran
                label55.Text = Convert.ToString(listBox1.Items[33 - 2]);// karşılaşma
                label52.Text = Convert.ToString(listBox2.Items[33 - 2]);//ms
                label53.Text = Convert.ToString(listBox4.Items[33 - 2]);// saat
                label54.Text = Convert.ToString(listBox6.Items[33 - 2]); // Gün

                label44.Text = Convert.ToString(listBox3.Items[34 - 2]);//oran
                label47.Text = Convert.ToString(listBox1.Items[34 - 2]);// karşılaşma
                label45.Text = Convert.ToString(listBox2.Items[34 - 2]);//ms
                label48.Text = Convert.ToString(listBox4.Items[34 - 2]);// saat
                label49.Text = Convert.ToString(listBox6.Items[34 - 2]); // Gün

                //////////////////////////////////////////////////////////

                label67.Text = Convert.ToString(listBox3.Items[35 - 2]);//oran
                label63.Text = Convert.ToString(listBox1.Items[35 - 2]);// karşılaşma
                label65.Text = Convert.ToString(listBox2.Items[35 - 2]);//ms
                label60.Text = Convert.ToString(listBox4.Items[35 - 2]);// saat
                label61.Text = Convert.ToString(listBox6.Items[35 - 2]); // Gün

                label72.Text = Convert.ToString(listBox3.Items[36 - 2]);//oran
                label59.Text = Convert.ToString(listBox1.Items[36 - 2]);// karşılaşma
                label73.Text = Convert.ToString(listBox2.Items[36 - 2]);//ms
                label70.Text = Convert.ToString(listBox4.Items[36 - 2]);// saat
                label71.Text = Convert.ToString(listBox6.Items[36 - 2]); // Gün


                label62.Text = Convert.ToString(listBox3.Items[37 - 2]);//oran
                label66.Text = Convert.ToString(listBox1.Items[37 - 2]);// karşılaşma
                label64.Text = Convert.ToString(listBox2.Items[37 - 2]);//ms
                label68.Text = Convert.ToString(listBox4.Items[37 - 2]);// saat
                label69.Text = Convert.ToString(listBox6.Items[37 - 2]); // Gün




                label4.Text = (float.Parse(label16.Text) * float.Parse(label17.Text) * float.Parse(label8.Text)).ToString();
                label22.Text = (float.Parse(label31.Text) * float.Parse(label36.Text) * float.Parse(label26.Text)).ToString();
                label40.Text = (float.Parse(label50.Text) * float.Parse(label51.Text) * float.Parse(label44.Text)).ToString();
                label58.Text = (float.Parse(label67.Text) * float.Parse(label72.Text) * float.Parse(label62.Text)).ToString();
            }
            else if (tiklama == 4)
            {


                label7.Text = Convert.ToString(listBox1.Items[38 - 2]);//karşılaşma
                label12.Text = Convert.ToString(listBox2.Items[38 - 2]);// ms
                label16.Text = Convert.ToString(listBox3.Items[38 - 2]);// oran
                label5.Text = Convert.ToString(listBox4.Items[38 - 2]);// saat
                label6.Text = Convert.ToString(listBox6.Items[38 - 2]); // Gün

                label17.Text = Convert.ToString(listBox3.Items[39 - 2]);//oran
                label19.Text = Convert.ToString(listBox1.Items[39 - 2]);// karşılaşma
                label18.Text = Convert.ToString(listBox2.Items[39 - 2]);//ms
                label14.Text = Convert.ToString(listBox4.Items[39 - 2]);// saat
                label15.Text = Convert.ToString(listBox6.Items[39 - 2]); // Gün

                label8.Text = Convert.ToString(listBox3.Items[40 - 2]);//oran
                label13.Text = Convert.ToString(listBox1.Items[40 - 2]);// karşılaşma
                label9.Text = Convert.ToString(listBox2.Items[40 - 2]);//ms
                label10.Text = Convert.ToString(listBox4.Items[40 - 2]);// saat
                label11.Text = Convert.ToString(listBox6.Items[40 - 2]); // Gün

                ////////////////////////////////////////////////////////////

                label31.Text = Convert.ToString(listBox3.Items[41 - 2]);//oran
                label27.Text = Convert.ToString(listBox1.Items[41 - 2]);// karşılaşma
                label29.Text = Convert.ToString(listBox2.Items[41 - 2]);//ms
                label24.Text = Convert.ToString(listBox4.Items[41 - 2]);// saat
                label25.Text = Convert.ToString(listBox6.Items[41 - 2]); // Gün

                label36.Text = Convert.ToString(listBox3.Items[42 - 2]);//oran
                label23.Text = Convert.ToString(listBox1.Items[42 - 2]);// karşılaşma
                label37.Text = Convert.ToString(listBox2.Items[42 - 2]);//ms
                label34.Text = Convert.ToString(listBox4.Items[42 - 2]);// saat
                label35.Text = Convert.ToString(listBox6.Items[42 - 2]); // Gün

                label26.Text = Convert.ToString(listBox3.Items[43 - 2]);//oran
                label30.Text = Convert.ToString(listBox1.Items[43 - 2]);// karşılaşma
                label28.Text = Convert.ToString(listBox2.Items[43 - 2]);//ms
                label32.Text = Convert.ToString(listBox4.Items[43 - 2]);// saat
                label33.Text = Convert.ToString(listBox6.Items[43 - 2]); // Gün

                ///////////////////////////////////////////////////////////

                label43.Text = Convert.ToString(listBox1.Items[44 - 2]);//karşılaşma
                label46.Text = Convert.ToString(listBox2.Items[44 - 2]);// ms
                label50.Text = Convert.ToString(listBox3.Items[44 - 2]);// oran
                label41.Text = Convert.ToString(listBox4.Items[44 - 2]);// saat
                label42.Text = Convert.ToString(listBox6.Items[44 - 2]); // Gün

                label51.Text = Convert.ToString(listBox3.Items[45 - 2]);//oran
                label55.Text = Convert.ToString(listBox1.Items[45 - 2]);// karşılaşma
                label52.Text = Convert.ToString(listBox2.Items[45 - 2]);//ms
                label53.Text = Convert.ToString(listBox4.Items[45 - 2]);// saat
                label54.Text = Convert.ToString(listBox6.Items[454 - 2]); // Gün

                label44.Text = Convert.ToString(listBox3.Items[46 - 2]);//oran
                label47.Text = Convert.ToString(listBox1.Items[46 - 2]);// karşılaşma
                label45.Text = Convert.ToString(listBox2.Items[46 - 2]);//ms
                label48.Text = Convert.ToString(listBox4.Items[46 - 2]);// saat
                label49.Text = Convert.ToString(listBox6.Items[46 - 2]); // Gün

                //////////////////////////////////////////////////////////

                label67.Text = Convert.ToString(listBox3.Items[47 - 2]);//oran
                label63.Text = Convert.ToString(listBox1.Items[47 - 2]);// karşılaşma
                label65.Text = Convert.ToString(listBox2.Items[47 - 2]);//ms
                label60.Text = Convert.ToString(listBox4.Items[47 - 2]);// saat
                label61.Text = Convert.ToString(listBox6.Items[47 - 2]); // Gün

                label72.Text = Convert.ToString(listBox3.Items[48 - 2]);//oran
                label59.Text = Convert.ToString(listBox1.Items[48 - 2]);// karşılaşma
                label73.Text = Convert.ToString(listBox2.Items[48 - 2]);//ms
                label70.Text = Convert.ToString(listBox4.Items[48 - 2]);// saat
                label71.Text = Convert.ToString(listBox6.Items[48 - 2]); // Gün


                label62.Text = Convert.ToString(listBox3.Items[49 - 2]);//oran
                label66.Text = Convert.ToString(listBox1.Items[49 - 2]);// karşılaşma
                label64.Text = Convert.ToString(listBox2.Items[49 - 2]);//ms
                label68.Text = Convert.ToString(listBox4.Items[49 - 2]);// saat
                label69.Text = Convert.ToString(listBox6.Items[49 - 2]); // Gün




                label4.Text = (float.Parse(label16.Text) * float.Parse(label17.Text) * float.Parse(label8.Text)).ToString();
                label22.Text = (float.Parse(label31.Text) * float.Parse(label36.Text) * float.Parse(label26.Text)).ToString();
                label40.Text = (float.Parse(label50.Text) * float.Parse(label51.Text) * float.Parse(label44.Text)).ToString();
                label58.Text = (float.Parse(label67.Text) * float.Parse(label72.Text) * float.Parse(label62.Text)).ToString();
            }
            else if (tiklama == 5)//
            {


                label7.Text = Convert.ToString(listBox1.Items[9 - 2]);//karşılaşma
                label12.Text = Convert.ToString(listBox2.Items[9 - 2]);// ms
                label16.Text = Convert.ToString(listBox3.Items[9 - 2]);// oran
                label5.Text = Convert.ToString(listBox4.Items[9 - 2]);// saat
                label6.Text = Convert.ToString(listBox6.Items[9 - 2]); // Gün

                label17.Text = Convert.ToString(listBox3.Items[13 - 2]);//oran
                label19.Text = Convert.ToString(listBox1.Items[13 - 2]);// karşılaşma
                label18.Text = Convert.ToString(listBox2.Items[13 - 2]);//ms
                label14.Text = Convert.ToString(listBox4.Items[13 - 2]);// saat
                label15.Text = Convert.ToString(listBox6.Items[13 - 2]); // Gün

                label8.Text = Convert.ToString(listBox3.Items[41 - 2]);//oran
                label13.Text = Convert.ToString(listBox1.Items[41 - 2]);// karşılaşma
                label9.Text = Convert.ToString(listBox2.Items[41 - 2]);//ms
                label10.Text = Convert.ToString(listBox4.Items[41 - 2]);// saat
                label11.Text = Convert.ToString(listBox6.Items[41- 2]); // Gün

                ////////////////////////////////////////////////////////////

                label31.Text = Convert.ToString(listBox3.Items[15 - 2]);//oran
                label27.Text = Convert.ToString(listBox1.Items[15 - 2]);// karşılaşma
                label29.Text = Convert.ToString(listBox2.Items[15 - 2]);//ms
                label24.Text = Convert.ToString(listBox4.Items[15 - 2]);// saat
                label25.Text = Convert.ToString(listBox6.Items[15 - 2]); // Gün

                label36.Text = Convert.ToString(listBox3.Items[16 - 2]);//oran
                label23.Text = Convert.ToString(listBox1.Items[16 - 2]);// karşılaşma
                label37.Text = Convert.ToString(listBox2.Items[16 - 2]);//ms
                label34.Text = Convert.ToString(listBox4.Items[16 - 2]);// saat
                label35.Text = Convert.ToString(listBox6.Items[16 - 2]); // Gün

                label26.Text = Convert.ToString(listBox3.Items[17 - 2]);//oran
                label30.Text = Convert.ToString(listBox1.Items[17 - 2]);// karşılaşma
                label28.Text = Convert.ToString(listBox2.Items[17 - 2]);//ms
                label32.Text = Convert.ToString(listBox4.Items[17 - 2]);// saat
                label33.Text = Convert.ToString(listBox6.Items[17 - 2]); // Gün

                ///////////////////////////////////////////////////////////

                label43.Text = Convert.ToString(listBox1.Items[33 - 2]);//karşılaşma
                label46.Text = Convert.ToString(listBox2.Items[33 - 2]);// ms
                label50.Text = Convert.ToString(listBox3.Items[33 - 2]);// oran
                label41.Text = Convert.ToString(listBox4.Items[33 - 2]);// saat
                label42.Text = Convert.ToString(listBox6.Items[33 - 2]); // Gün

                label51.Text = Convert.ToString(listBox3.Items[21 - 2]);//oran
                label55.Text = Convert.ToString(listBox1.Items[21 - 2]);// karşılaşma
                label52.Text = Convert.ToString(listBox2.Items[21 - 2]);//ms
                label53.Text = Convert.ToString(listBox4.Items[21 - 2]);// saat
                label54.Text = Convert.ToString(listBox6.Items[21 - 2]); // Gün

                label44.Text = Convert.ToString(listBox3.Items[14 - 2]);//oran
                label47.Text = Convert.ToString(listBox1.Items[14 - 2]);// karşılaşma
                label45.Text = Convert.ToString(listBox2.Items[14 - 2]);//ms
                label48.Text = Convert.ToString(listBox4.Items[14 - 2]);// saat
                label49.Text = Convert.ToString(listBox6.Items[14 - 2]); // Gün

                //////////////////////////////////////////////////////////

                label67.Text = Convert.ToString(listBox3.Items[11 - 2]);//oran
                label63.Text = Convert.ToString(listBox1.Items[11 - 2]);// karşılaşma
                label65.Text = Convert.ToString(listBox2.Items[11 - 2]);//ms
                label60.Text = Convert.ToString(listBox4.Items[11 - 2]);// saat
                label61.Text = Convert.ToString(listBox6.Items[11 - 2]); // Gün

                label72.Text = Convert.ToString(listBox3.Items[34 - 2]);//oran
                label59.Text = Convert.ToString(listBox1.Items[34 - 2]);// karşılaşma
                label73.Text = Convert.ToString(listBox2.Items[34 - 2]);//ms
                label70.Text = Convert.ToString(listBox4.Items[34 - 2]);// saat
                label71.Text = Convert.ToString(listBox6.Items[34 - 2]); // Gün


                label62.Text = Convert.ToString(listBox3.Items[36 - 2]);//oran
                label66.Text = Convert.ToString(listBox1.Items[36 - 2]);// karşılaşma
                label64.Text = Convert.ToString(listBox2.Items[36 - 2]);//ms
                label68.Text = Convert.ToString(listBox4.Items[36 - 2]);// saat
                label69.Text = Convert.ToString(listBox6.Items[36 - 2]); // Gün




                label4.Text = (float.Parse(label16.Text) * float.Parse(label17.Text) * float.Parse(label8.Text)).ToString();
                label22.Text = (float.Parse(label31.Text) * float.Parse(label36.Text) * float.Parse(label26.Text)).ToString();
                label40.Text = (float.Parse(label50.Text) * float.Parse(label51.Text) * float.Parse(label44.Text)).ToString();
                label58.Text = (float.Parse(label67.Text) * float.Parse(label72.Text) * float.Parse(label62.Text)).ToString();
            }

            else if (tiklama == 6)
            {

                label7.Text = Convert.ToString(listBox1.Items[29 - 2]);//karşılaşma
                label12.Text = Convert.ToString(listBox2.Items[29 - 2]);// ms
                label16.Text = Convert.ToString(listBox3.Items[29 - 2]);// oran
                label5.Text = Convert.ToString(listBox4.Items[29 - 2]);// saat
                label6.Text = Convert.ToString(listBox6.Items[29 - 2]); // Gün

                label17.Text = Convert.ToString(listBox3.Items[39 - 2]);//oran
                label19.Text = Convert.ToString(listBox1.Items[39 - 2]);// karşılaşma
                label18.Text = Convert.ToString(listBox2.Items[39 - 2]);//ms
                label14.Text = Convert.ToString(listBox4.Items[39 - 2]);// saat
                label15.Text = Convert.ToString(listBox6.Items[39 - 2]); // Gün

                label8.Text = Convert.ToString(listBox3.Items[19 - 2]);//oran
                label13.Text = Convert.ToString(listBox1.Items[19 - 2]);// karşılaşma
                label9.Text = Convert.ToString(listBox2.Items[19 - 2]);//ms
                label10.Text = Convert.ToString(listBox4.Items[19 - 2]);// saat
                label11.Text = Convert.ToString(listBox6.Items[19 - 2]); // Gün

                ////////////////////////////////////////////////////////////

                label31.Text = Convert.ToString(listBox3.Items[116 - 2]);//oran
                label27.Text = Convert.ToString(listBox1.Items[16 - 2]);// karşılaşma
                label29.Text = Convert.ToString(listBox2.Items[16 - 2]);//ms
                label24.Text = Convert.ToString(listBox4.Items[16 - 2]);// saat
                label25.Text = Convert.ToString(listBox6.Items[16 - 2]); // Gün

                label36.Text = Convert.ToString(listBox3.Items[37 - 2]);//oran
                label23.Text = Convert.ToString(listBox1.Items[37 - 2]);// karşılaşma
                label37.Text = Convert.ToString(listBox2.Items[37 - 2]);//ms
                label34.Text = Convert.ToString(listBox4.Items[37 - 2]);// saat
                label35.Text = Convert.ToString(listBox6.Items[37 - 2]); // Gün

                label26.Text = Convert.ToString(listBox3.Items[38 - 2]);//oran
                label30.Text = Convert.ToString(listBox1.Items[38 - 2]);// karşılaşma
                label28.Text = Convert.ToString(listBox2.Items[38 - 2]);//ms
                label32.Text = Convert.ToString(listBox4.Items[38 - 2]);// saat
                label33.Text = Convert.ToString(listBox6.Items[38 - 2]); // Gün

                ///////////////////////////////////////////////////////////

                label43.Text = Convert.ToString(listBox1.Items[18 - 2]);//karşılaşma
                label46.Text = Convert.ToString(listBox2.Items[18 - 2]);// ms
                label50.Text = Convert.ToString(listBox3.Items[18 - 2]);// oran
                label41.Text = Convert.ToString(listBox4.Items[18 - 2]);// saat
                label42.Text = Convert.ToString(listBox6.Items[18 - 2]); // Gün

                label51.Text = Convert.ToString(listBox3.Items[19 - 2]);//oran
                label55.Text = Convert.ToString(listBox1.Items[19 - 2]);// karşılaşma
                label52.Text = Convert.ToString(listBox2.Items[19 - 2]);//ms
                label53.Text = Convert.ToString(listBox4.Items[19 - 2]);// saat
                label54.Text = Convert.ToString(listBox6.Items[19 - 2]); // Gün

                label44.Text = Convert.ToString(listBox3.Items[6 - 2]);//oran
                label47.Text = Convert.ToString(listBox1.Items[6 - 2]);// karşılaşma
                label45.Text = Convert.ToString(listBox2.Items[6 - 2]);//ms
                label48.Text = Convert.ToString(listBox4.Items[6 - 2]);// saat
                label49.Text = Convert.ToString(listBox6.Items[6 - 2]); // Gün

                //////////////////////////////////////////////////////////

                label67.Text = Convert.ToString(listBox3.Items[7 - 2]);//oran
                label63.Text = Convert.ToString(listBox1.Items[7 - 2]);// karşılaşma
                label65.Text = Convert.ToString(listBox2.Items[7 - 2]);//ms
                label60.Text = Convert.ToString(listBox4.Items[7 - 2]);// saat
                label61.Text = Convert.ToString(listBox6.Items[7 - 2]); // Gün

                label72.Text = Convert.ToString(listBox3.Items[8 - 2]);//oran
                label59.Text = Convert.ToString(listBox1.Items[8 - 2]);// karşılaşma
                label73.Text = Convert.ToString(listBox2.Items[8 - 2]);//ms
                label70.Text = Convert.ToString(listBox4.Items[8 - 2]);// saat
                label71.Text = Convert.ToString(listBox6.Items[8 - 2]); // Gün


                label62.Text = Convert.ToString(listBox3.Items[9 - 2]);//oran
                label66.Text = Convert.ToString(listBox1.Items[9 - 2]);// karşılaşma
                label64.Text = Convert.ToString(listBox2.Items[9 - 2]);//ms
                label68.Text = Convert.ToString(listBox4.Items[9 - 2]);// saat
                label69.Text = Convert.ToString(listBox6.Items[9 - 2]); // Gün



                tiklama = 0;

                label4.Text = (float.Parse(label16.Text) * float.Parse(label17.Text) * float.Parse(label8.Text)).ToString();
                label22.Text = (float.Parse(label31.Text) * float.Parse(label36.Text) * float.Parse(label26.Text)).ToString();
                label40.Text = (float.Parse(label50.Text) * float.Parse(label51.Text) * float.Parse(label44.Text)).ToString();
                label58.Text = (float.Parse(label67.Text) * float.Parse(label72.Text) * float.Parse(label62.Text)).ToString();
            }

        }

        private void eB_Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
