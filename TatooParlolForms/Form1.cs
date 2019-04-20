using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TatooParlolForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Master1_Click(object sender, EventArgs e)
        {
            Master1.Image = Properties.Resources.Anatoliy;
        }

        private void Master3_Click(object sender, EventArgs e)
        {
            Master3.Image = Properties.Resources.Rusana;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Фотография|*.jpg" };
            var dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Фотография|*.jpg" };
            var dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        int index = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            tabControl1.SelectedIndex = index;
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ff = new Form2();
            if (ff.ShowDialog(this) == DialogResult.OK)
            {
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ff = new Form2();
            if (ff.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            index--;
            tabControl1.SelectedIndex = index;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ff = new Form3(new TatooParlor.Comments { VisitDate = DateTime.Now });
            if (ff.ShowDialog(this) == DialogResult.OK)
            {
                listBox1.Items.Add(ff.Comments);
            }
        }
    }
}
