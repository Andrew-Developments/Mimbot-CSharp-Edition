using System;
using System.Windows.Forms;

namespace Mimbot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                richTextBox1.Text +="Вы: " + textBox1.Text + "\n";
            textBox1.Clear();
            textBox1.Select();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char)Keys.Enter;
            if (e.KeyChar == 13)
                button1_Click(this, new EventArgs());
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Ответы мима
            Random rnd = new Random();
            int i = rnd.Next(4);
            if (i == 0)
                richTextBox1.Text += "Мим: " + "..." + "\n";
            if (i == 1)
                richTextBox1.Text += "Мим: " + "..." + "\n";
            if (i == 2)
                richTextBox1.Text += "Мим: " + "...?" + "\n";
            if (i == 3)
                richTextBox1.Text += "Мим: " + "...!" + "\n";

            //Прокрутка вниз
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
    }
}
