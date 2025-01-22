using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSZRandomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> sagas = new List<string>();

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    if (!sagas.Contains(checkBox.Text))
                    {
                        sagas.Add(checkBox.Text);
                    }
                }
                else
                {
                    if (sagas.Contains(checkBox.Text))
                    {
                        sagas.Remove(checkBox.Text);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            if (sagas.Count > 2)
            {
                int Random1 = random.Next(sagas.Count);
                int Random2;
                do
                {
                    Random2 = random.Next(sagas.Count);
                } while (Random1 == Random2);

                string name1 = sagas[Random1];
                string name2 = sagas[Random2];

                label5.Text = name1;
                label4.Text = name2;
            }
            else if (sagas.Count < 2 && sagas.Count > 0)
            {
                MessageBox.Show("du måste välja mer än 1, tjokis");
            }
            else
            {
                MessageBox.Show("Välj nåt retard");
            }
        }
    }
}
