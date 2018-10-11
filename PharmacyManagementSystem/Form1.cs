using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            panel3.Show();
            String s1 = "Alex      1112233     9/19/2018 07:30";
            String s2 = "Ethen    3216549     9/21/2018 16:15";
            listBox1.Items.Add(s1);
            listBox1.Items.Add(s2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            String s1 = "1112233     Example Drug A     New            9/18/2018";
            String s2 = "3216549     Example Drug B     Complete    7/20/2018";
            listBox2.Items.Add(s1);
            listBox2.Items.Add(s2);
            panel2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            String s1 = "Name: Warfarin";
            String s2 = "Dosage: 50mg";
            String s3 = "Frequency: Twice daily";
            String s4 = "Route: By mouth";
            listView1.Items.Add(s1);
            listView1.Items.Add(s2);
            listView1.Items.Add(s3);
            listView1.Items.Add(s4);
            panel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
