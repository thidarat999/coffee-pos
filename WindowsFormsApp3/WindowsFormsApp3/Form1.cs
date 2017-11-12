using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    { string nn = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Environment.Exit(0);
            //Close();ปิดระบบออกทุกอย่าง
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nanny("Esspresso Hot", "35");
        }
        public void nanny(string m, string u)
        {
            string[] mm = { m, u };
            var listview = new ListViewItem(mm);
            listView1.Items.Add(listview);
            ListPricce();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            nanny("Esspresso Ice", "45");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            nanny("Esspresso Frappe", "50");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nanny("Americano Hot", "35");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            nanny("Americano Ice", "45");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            nanny("Americano Frappe", "50");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nanny("Latte Hot", "35");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nanny("Latte Ice", "45");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            nanny("Latte Frappe", "50");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nanny("Mocha Hot", "35");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            nanny("Mocha Ice", "45");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            nanny("Mocha Frappe", "50");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nanny("Cappuccino Hot", "35");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            nanny("Cappuccino Ice", "45");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            nanny("Cappuccino Frappe", "50");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            nanny("GreenTea Hot", "20");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            nanny("GreenTea Ice", "25");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            nanny("GreenTea Frappe", "30");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            nanny("ThaiTea Hot", "20");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            nanny("ThaiTea Ice", "25");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            nanny("ThaiTea Frappe", "30");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            nanny("CoCoa Hot", "20");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            nanny("CoCoa Ice", "25");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            nanny("CoCoa Frappe", "30");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            nanny("Milk Hot", "20");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            nanny("Milk Ice", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            nanny("Milk Frappe", "30");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            nanny("MilkTea Ice", "25");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            nanny("MilkTea Frappe", "30");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            nanny("LemonTea Ice", "25");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            nanny("LemonTea Frappe", "30");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            nanny("Milo Hot", "20");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            nanny("Milo Ice", "25");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            nanny("Milo Frappe", "30");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            nanny("Nescafe Hot", "20");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            nanny("Nescafe Ice", "25");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            nanny("Nescafe Frappe", "30");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            nanny("NesteaTea Hot", "20");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            nanny("NesteaTea Ice", "25");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            nanny("NesteaTea Frappe", "30");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            nanny("Cantaloupe Ice", "25");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            nanny("BlueHawai Ice", "25");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            nanny("Red lime Soda Ice", "25");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            nanny("Strawbery Ice", "25");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            nanny("Apple Ice", "25");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            nanny("Honey lime Soda Ice", "25");
        }
        double rr;
        public string[] ListPricce()
        {
            rr = 0;
            string[] s = new string[listView1.Items.Count];
            int ll = listView1.Items.Count;
            for (int i = 0; i < ll; i++)
            {
                rr += double.Parse(listView1.Items[i].SubItems[1].Text);
                s[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            textBox1.Text = rr.ToString();
            return s;
        }
        public string[] inListPricce()
        {
            string[] s = new string[listView1.Items.Count];
            int ll = listView1.Items.Count;
            for (int i = 0; i < ll; i++)
            {
                s[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return s;
        }
        public void sss()
        {
            string[] uu = ListPricce();
            string[] oo = inListPricce();
            string fi = "Nnanny_Coffe" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string bill = "Nnanny_Coffe";
            bill += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd//mm//yyyy");
            bill += "Menu" + "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                bill += uu[i] + new string(' ', 20) + oo[i] + "฿" + "\r\n";
            }
            bill += "\r\n";
            bill += "ราคารวม  : " + textBox1.Text;
            label24.Text = "";
            System.IO.File.WriteAllText(nn + @"\" + fi + ".txt", bill);
            label24.Text += bill + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at " + nn + @"\" + fi + ".txt";
        }
        bool kk = false;
        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (kk == false)
            {
                tabControl1.TabPages.Insert(1, tp2);
                kk = true;
                tabControl1.SelectedTab = tp2;
            }
            else tabControl1.SelectedTab = tp2;
            if (listView1.Items.Count > 0)
                sss();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            kk = false;
            tabControl1.Controls.Remove(tp2);
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(tp2);
        }
    } 
}
