using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_Overlay
{
    public partial class Form1 : Form
    {
        String url;
        String adr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            url = TxtBx.Text;
            adr = url.Substring(url.IndexOf("="), url.Length - url.IndexOf("="));
            adr = adr.Replace("=", "");
            groupBox1.Visible = false;
            webBrowser1.Visible = true;
            webBrowser1.DocumentText = "<iframe width=\"480\" height=\"360\" src=https://www.youtube.com/embed/" + adr + " frameborder=\"0\" allowfullscreen></iframe>";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            groupBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void nouvelleVidéoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            TxtBx.Visible = true;
            button1.Visible = true;
            webBrowser1.Visible = false;
        }

        private void affichageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            webBrowser1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            url = TxtBx.Text;
            adr = url.Substring(url.IndexOf("="), url.Length - url.IndexOf("="));
            adr = adr.Replace("=", "");
            TxtBx.Visible = false;
            button1.Visible = false;
            webBrowser1.Visible = true;
            webBrowser1.DocumentText = "<iframe width=\"480\" height=\"360\" src=https://www.youtube.com/embed/" + adr + " frameborder=\"0\" allowfullscreen></iframe>";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBx.Visible = false;
            groupBox1.Visible = false;
            webBrowser1.Visible = true;            
            webBrowser1.DocumentText = "<iframe width=" + textBox1.Text + " height=\""+textBox2.Text+"\" src=https://www.youtube.com/embed/" + adr + " frameborder=\"0\" allowfullscreen></iframe>";
            Form1.
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Double val1 = Convert.ToDouble(textBox2.Text);
            Double resultat = val1 / 1.77;
            textBox1.Text = Convert.ToString(Convert.ToInt32(resultat));
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Double val1 = Convert.ToDouble(textBox1.Text);
            Double resultat = val1 / 1.77;
            textBox2.Text = Convert.ToString(Convert.ToInt32(resultat));
        }

    }
}
