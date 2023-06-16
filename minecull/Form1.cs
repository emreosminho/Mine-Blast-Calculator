using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minecull
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var pos = this.PointToScreen(label35.Location);  //arka plan şeffaf olsun//
            pos = pictureBox2.PointToClient(pos);
            label35.Parent = pictureBox2;
            label35.Location = pos;
            label35.BackColor = Color.Transparent;

            var pos1 = this.PointToScreen(label36.Location);  
            pos1 = pictureBox2.PointToClient(pos1);
            label36.Parent = pictureBox2;
            label36.Location = pos1;
            label36.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(label37.Location);
            pos2 = pictureBox2.PointToClient(pos2);
            label37.Parent = pictureBox2;
            label37.Location = pos2;
            label37.BackColor = Color.Transparent;

            var pos3 = this.PointToScreen(label38.Location);
            pos3 = pictureBox2.PointToClient(pos3);
            label38.Parent = pictureBox2;
            label38.Location = pos3;
            label38.BackColor = Color.Transparent;

            var pos4 = this.PointToScreen(label39.Location);
            pos4 = pictureBox2.PointToClient(pos4);
            label39.Parent = pictureBox2;
            label39.Location = pos4;
            label39.BackColor = Color.Transparent;

            var pos5 = this.PointToScreen(label40.Location);
            pos5 = pictureBox2.PointToClient(pos5);
            label40.Parent = pictureBox2;
            label40.Location = pos5;
            label40.BackColor = Color.Transparent;

            var pos6 = this.PointToScreen(label41.Location);
            pos6 = pictureBox2.PointToClient(pos6);
            label41.Parent = pictureBox2;
            label41.Location = pos6;
            label41.BackColor = Color.Transparent;

            var pos7 = this.PointToScreen(label42.Location);
            pos7 = pictureBox2.PointToClient(pos7);
            label42.Parent = pictureBox2;
            label42.Location = pos7;
            label42.BackColor = Color.Transparent;

            var pos8 = this.PointToScreen(label43.Location);
            pos8 = pictureBox2.PointToClient(pos8);
            label43.Parent = pictureBox2;
            label43.Location = pos8;
            label43.BackColor = Color.Transparent;

            var pos9 = this.PointToScreen(label44.Location);
            pos9 = pictureBox2.PointToClient(pos9);
            label44.Parent = pictureBox2;
            label44.Location = pos9;
            label44.BackColor = Color.Transparent;

            var pos10 = this.PointToScreen(label45.Location);
            pos10 = pictureBox2.PointToClient(pos10);
            label45.Parent = pictureBox2;
            label45.Location = pos10;
            label45.BackColor = Color.Transparent;

            var pos11 = this.PointToScreen(label46.Location);
            pos11 = pictureBox2.PointToClient(pos11);
            label46.Parent = pictureBox2;
            label46.Location = pos11;
            label46.BackColor = Color.Transparent;

            
            

        }


        double D, c, P, P1, S, f, K, K1, Vmax, V, T, U, H, k2, F, V1, E, L, Q, A ,
            Lk, Qk, Sb, Os, Od, Ds, Kh;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // printDocument1.DefaultPageSettings.Landscape = true;  // Yatay sayfa için
            try
            {
                Font font = new Font("Microsoft Sans Serif", 14);
                SolidBrush firca = new SolidBrush(Color.Black);
                e.Graphics.DrawString($"Tarih:{DateTime.Now.ToString("dd.MM.yyyy")}", font, firca, 60, 25);

                font = new Font("Microsoft Sans Serif", 18,FontStyle.Bold);
                e.Graphics.DrawString("PATLATMA PARAMETRELERİ", font, firca, 230, 70);

                font = new Font("Microsoft Sans Serif", 10,FontStyle.Bold);
                e.Graphics.DrawString("D. Ayna Uzaklığı", font, firca, 60, 170);
                e.Graphics.DrawString("D. Boyu", font, firca, 210, 170);
                e.Graphics.DrawString("D. Arası Mesafe", font, firca, 300, 170);
                e.Graphics.DrawString("Dip Ş. Miktarı (kg)", font, firca, 450, 170);
                e.Graphics.DrawString("Kolon Ş. Miktarı (kg)", font, firca, 600, 170);

                int i = 0;
                int y = 210;
                while (i <= dataGridView1.Rows.Count-1)
                {
                    font = new Font("Microsoft Sans Serif", 10);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(),font,firca,60,y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), font, firca, 210, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), font, firca, 300, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), font, firca, 450, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), font, firca, 600, y);

                    y = y + 40;  //satır atlamalı//
                    i = i + 1;
                }
                /*
                font = new Font("Microsoft Sans Serif", 14);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), font, firca, 60, y);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), font, firca, 250, y);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), font, firca, 420, y);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), font, firca, 550, y);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), font, firca, 700, y);
                */
            }
            catch (Exception)
            {

                
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();                               // yazdırma ön izleme//
        }

        private void button9_Click(object sender, EventArgs e)
        {
            printDocument1.Print();  //yazdırma işlemi//
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           

           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label26_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left = MousePosition.X - mouseX;
            this.Top = MousePosition.Y - mouseY;
        }

        int mouseX, mouseY;
        private void label26_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = MousePosition.X - this.Left;
            mouseY = MousePosition.Y - this.Top;

            timer1.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(textBox7.Text,textBox8.Text,textBox9.Text,textBox10.Text,textBox11.Text,textBox12.Text,textBox13.Text,
                textBox15.Text,textBox16.Text,textBox17.Text,textBox18.Text,textBox19.Text,textBox21.Text,textBox22.Text,
                textBox23.Text,textBox24.Text,textBox25.Text,textBox27.Text);
            
            dataGridView1.DataSource=tablo;   //listeye eklme işlemleri//
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        

        double p1 = 0.85, s1 = 1.10, p2 = 1.40, s2 = 1.00, p3 = 0.85, s3 = 0.96, p4 = 0.98, s4 = 1.06, p5 = 1.00, s5 = 0.94, p6 = 1.00, s6 = 1.05;
        double p7=1.55,s7=1.28,p8=1.57,s8=1.15,p9=1.55,s9=1.11,p10=1.53,s10=0.99,p11=1.50,s11=1.28,p12=1.50,s12=1.15;
        double p13 = 1.50, s13 = 1.02,p14=1.50,s14=0.58,p15=1.50,s15=1.00,p16=1.00,s16=0.76,p17=1.00,s17=0.81;
        double p18 = 1.20, s18 = 0.75,p19=1.21,s19=0.95,p20=1.25,s20=0.75,p21=1.28,s21=0.73;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Dynamex A")                            //patlayıcı listesi listbox//
            {
                textBox3.Text = Convert.ToDouble(p1).ToString();
                textBox4.Text = Convert.ToDouble(s1).ToString();
            }
            else if(comboBox1.Text=="Dynamex M")
            {
                textBox3.Text = Convert.ToDouble(p2).ToString();
                textBox4.Text = Convert.ToDouble(s2).ToString();
            }
            else if (comboBox1.Text == "ANFO")
            {
                textBox3.Text = Convert.ToDouble(p3).ToString();
                textBox4.Text = Convert.ToDouble(s3).ToString();
            }
            else if (comboBox1.Text == "Donarit 1")
            {
                textBox3.Text = Convert.ToDouble(p4).ToString();
                textBox4.Text = Convert.ToDouble(s4).ToString();
            }
            else if (comboBox1.Text == "Donarit 2")
            {
                textBox3.Text = Convert.ToDouble(p5).ToString();
                textBox4.Text = Convert.ToDouble(s5).ToString();
            }
            else if (comboBox1.Text == "Donarit 4")
            {
                textBox3.Text = Convert.ToDouble(p6).ToString();
                textBox4.Text = Convert.ToDouble(s6).ToString();
            }
            else if (comboBox1.Text == "Gomme A")
            {
                textBox3.Text = Convert.ToDouble(p7).ToString();
                textBox4.Text = Convert.ToDouble(s7).ToString();
            }
            else if (comboBox1.Text == "Gomme AS")
            {
                textBox3.Text = Convert.ToDouble(p8).ToString();
                textBox4.Text = Convert.ToDouble(s8).ToString();
            }
            else if (comboBox1.Text == "Gomme AT")
            {
                textBox3.Text = Convert.ToDouble(p9).ToString();
                textBox4.Text = Convert.ToDouble(s9).ToString();
            }
            else if (comboBox1.Text == "Gomme 777")
            {
                textBox3.Text = Convert.ToDouble(p10).ToString();
                textBox4.Text = Convert.ToDouble(s10).ToString();
            }
            else if (comboBox1.Text == "Gom 1")
            {
                textBox3.Text = Convert.ToDouble(p11).ToString();
                textBox4.Text = Convert.ToDouble(s11).ToString();
            }
            else if (comboBox1.Text == "Gom 2")
            {
                textBox3.Text = Convert.ToDouble(p12).ToString();
                textBox4.Text = Convert.ToDouble(s12).ToString();
            }
            else if (comboBox1.Text == "Gom 3")
            {
                textBox3.Text = Convert.ToDouble(p13).ToString();
                textBox4.Text = Convert.ToDouble(s13).ToString();
            }
            else if (comboBox1.Text == "Grizu Dinamit")
            {
                textBox3.Text = Convert.ToDouble(p14).ToString();
                textBox4.Text = Convert.ToDouble(s14).ToString();
            }
            else if (comboBox1.Text == "Jelatinit")
            {
                textBox3.Text = Convert.ToDouble(p15).ToString();
                textBox4.Text = Convert.ToDouble(s15).ToString();
            }
            else if (comboBox1.Text == "Elbar 1")
            {
                textBox3.Text = Convert.ToDouble(p16).ToString();
                textBox4.Text = Convert.ToDouble(s16).ToString();
            }
            else if (comboBox1.Text == "Gurit A")
            {
                textBox3.Text = Convert.ToDouble(p17).ToString();
                textBox4.Text = Convert.ToDouble(s17).ToString();
            }
            else if (comboBox1.Text == "Emulite 100")
            {
                textBox3.Text = Convert.ToDouble(p18).ToString();
                textBox4.Text = Convert.ToDouble(s18).ToString();
            }
            else if (comboBox1.Text == "Emulite 150")
            {
                textBox3.Text = Convert.ToDouble(p19).ToString();
                textBox4.Text = Convert.ToDouble(s19).ToString();
            }
            else if (comboBox1.Text == "Emulite 200")
            {
                textBox3.Text = Convert.ToDouble(p20).ToString();
                textBox4.Text = Convert.ToDouble(s20).ToString();
            }
            else if (comboBox1.Text == "Emulite 300")
            {
                textBox3.Text = Convert.ToDouble(p21).ToString();
                textBox4.Text = Convert.ToDouble(s21).ToString();
            }
        }

        DataTable tablo = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Dynamex A");                                        //datagrid tabloya aktarma//
            comboBox1.Items.Add("Dynamex M");
            comboBox1.Items.Add("ANFO");
            comboBox1.Items.Add("Donarit 1");
            comboBox1.Items.Add("Donarit 2");
            comboBox1.Items.Add("Donarit 4");
            comboBox1.Items.Add("Gomme A");
            comboBox1.Items.Add("Gomme AS");
            comboBox1.Items.Add("Gomme AT");
            comboBox1.Items.Add("Gomme 777");
            comboBox1.Items.Add("Gom 1");
            comboBox1.Items.Add("Gom 2");
            comboBox1.Items.Add("Gom 3");
            comboBox1.Items.Add("Grizu Dinamit");
            comboBox1.Items.Add("Jelatinit");
            comboBox1.Items.Add("Elbar 1");
            comboBox1.Items.Add("Gurit A");
            comboBox1.Items.Add("Emulite 100");
            comboBox1.Items.Add("Emulite 150");
            comboBox1.Items.Add("Emulite 200");
            comboBox1.Items.Add("Emulite 300");


            
            tablo.Columns.Add("Delik Ayna Uzaklığı (m)", typeof(double));
            tablo.Columns.Add("Kaya Düzeltme Faktörü", typeof(double));
            tablo.Columns.Add("Patlayıcı Düzeltme Faktörü", typeof(double));
            tablo.Columns.Add("Taban Zorluğu Faktörü", typeof(double));
            tablo.Columns.Add("Nihai Delik Ayna Uzaklığı (m))", typeof(double));
            tablo.Columns.Add("Alt Delme", typeof(double));
            tablo.Columns.Add("Delik Boyu", typeof(double));
            tablo.Columns.Add("Delgi Hatası", typeof(double));
            tablo.Columns.Add("Gerçek Delik Ayna Uzaklığı (m)", typeof(double));
            tablo.Columns.Add("Delikle Arası Uzaklık", typeof(double));
            tablo.Columns.Add("Dip Şarj Yüksekliği", typeof(double));
            tablo.Columns.Add("Dip Şarj Miktarı", typeof(double));
            tablo.Columns.Add("Kolon Şarj Yüksekliği", typeof(double));
            tablo.Columns.Add("Kolon Şarj Miktarı", typeof(double));
            tablo.Columns.Add("Sıkılama Boyu", typeof(double));
            tablo.Columns.Add("Özgül Delik", typeof(double));
            tablo.Columns.Add("Özgül Şarj", typeof(double));
            tablo.Columns.Add("Kübaj Hesabı", typeof(double));



            dataGridView1.DataSource = tablo;
            








        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)    //hesaplanan değerleri siler//
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox16.Clear();
                textBox17.Clear();
                textBox18.Clear();
                textBox19.Clear();
                textBox20.Clear();
                textBox21.Clear();
                textBox22.Clear();
                textBox23.Clear();
                textBox24.Clear();
                textBox25.Clear();
                textBox26.Clear();
                textBox27.Clear();
                label35.Text = string.Empty;
                label38.Text = string.Empty;
                label40.Text = string.Empty;
                label42.Text = string.Empty;
                label44.Text = string.Empty;
                label46.Text = string.Empty;

                comboBox1.SelectedIndex = -1;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //ekran aşağı indir//
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(WindowState== FormWindowState.Maximized)   //ekran büyüt//
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           var durum = MessageBox.Show("Çıkış Yapmak İstiyor Musunuz?", "Çıkış Yapılıyor...", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
           if (durum == DialogResult.OK)
            {
                Application.Exit();
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            D = Convert.ToDouble(textBox1.Text);                                    //tüm mat işlemleri//
            c = Convert.ToDouble(textBox2.Text);
            f = Convert.ToDouble(textBox5.Text);
            K = Convert.ToDouble(textBox6.Text);
            k2 = Convert.ToDouble(textBox14.Text);
            A = Convert.ToDouble(textBox20.Text);
            Ds = Convert.ToDouble(textBox26.Text);
            P = Convert.ToDouble(textBox3.Text);
            S = Convert.ToDouble(textBox4.Text);

            Vmax = D * 45 / 1000;
            textBox7.Text = Convert.ToDouble(Math.Round(Vmax,2)).ToString();

            K1 = Math.Round(Math.Sqrt(0.4 / c),2);
            textBox8.Text = Convert.ToDouble(K1).ToString();

            P1 = Math.Round(Math.Sqrt(P * S / 1.25),2);
            textBox9.Text = Convert.ToDouble(P1).ToString();

            T = Math.Round(Math.Sqrt(1 / f), 2);
            textBox10.Text = Convert.ToDouble(T).ToString();

            V = Vmax * K1 * P1 * T;
            textBox11.Text = Convert.ToDouble(Math.Round(V,2)).ToString();

            U = 0.3 * V;
            textBox12.Text = Convert.ToDouble(Math.Round(U, 2)).ToString();

            H = (K + U)*k2;
            textBox13.Text = Convert.ToDouble(Math.Round(H, 2)).ToString();

            F = (D / 1000) + 0.03 * H;
            textBox15.Text = Convert.ToDouble(Math.Round(F, 2)).ToString();

            V1 = V - F;
            textBox16.Text = Convert.ToDouble(Math.Round(V1, 2)).ToString();

            E = 1.25 * V1;
            textBox17.Text = Convert.ToDouble(Math.Round(E, 2)).ToString();

            L = 1.3 * V1;
            textBox18.Text = Convert.ToDouble(Math.Round(L, 2)).ToString();

            Q = L * 10 * A * P;
            textBox19.Text = Convert.ToDouble(Math.Round(Q, 2)).ToString();

            Lk = H - L - V1;
            textBox21.Text = Convert.ToDouble(Math.Round(Lk, 2)).ToString();

            Qk = Lk * 10 * A * P;
            textBox22.Text = Convert.ToDouble(Math.Round(Qk, 2)).ToString();

            Sb = V1;
            textBox23.Text = Convert.ToDouble(Math.Round(Sb, 2)).ToString();

            Os = H / (E * V1 * K);
            textBox24.Text = Convert.ToDouble(Math.Round(Os, 2)).ToString();

            Od = (Q + Qk) / (E * V1 * K);
            textBox25.Text = Convert.ToDouble(Math.Round(Od, 2)).ToString();

            Kh = (V1 * E * H * c * Ds);
            textBox27.Text = Convert.ToDouble(Math.Round(Kh,3)).ToString();



            label35.Text = textBox23.Text;       //ön izleme basıldığında görsel üzerinde değerler okunur//
            label38.Text = textBox21.Text;
            label40.Text = textBox18.Text;
            label42.Text = textBox17.Text;
            label44.Text = textBox19.Text;
            label46.Text = textBox22.Text;


        }

        

        
    }
}
