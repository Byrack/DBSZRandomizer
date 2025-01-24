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
            addToList();
        }

        List<string> sagas = new List<string>();
        List<string> movies = new List<string>();
        List<CheckBox> CheckBoxList = new List<CheckBox>();

        bool turn = false;

        string name1;
        string name2;

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            // Från serien
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

            if (MovSagaToggle.Checked)
            {
                foreach (string movie in movies)
                {
                    sagas.Remove(movie);
                }
            }
            else
            {
                foreach (string movie in movies)
                {
                    sagas.Add(movie);
                }
            }

            if (sagas.Count >= 2)
            {
                int RandomMov = random.Next(movies.Count);
                int Random1 = random.Next(sagas.Count);
                int Random2;
                do
                {
                    Random2 = random.Next(sagas.Count);
                } while (Random1 == Random2);


                if (MovSagaToggle.Checked)
                {
                    name1 = movies[RandomMov];
                    name2 = sagas[Random2];
                }
                else
                {
                    name1 = sagas[Random1];
                    name2 = sagas[Random2];
                }

                // ger ut filmen/sagan
                if (MovSagaToggle.Checked)
                {
                    if (turn == true)
                    {
                        label5.Text = name1;
                        label4.Text = name2;
                        turn = false;
                    }
                    else if (turn == false)
                    {
                        label5.Text = name2;
                        label4.Text = name1;
                        turn = true;
                    }
                }
                else
                {
                    label5.Text = name1;
                    label4.Text = name2;
                }
            }
            else if (sagas.Count < 2 && sagas.Count > 0)
            {
                MessageBox.Show("du måste välja mer än 1, tjokis");
            }
            else if (sagas.Count < 1)
            {
                MessageBox.Show("Välj nåt retard");
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            // Från filmer
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    if (!movies.Contains(checkBox.Text))
                    {
                        movies.Add(checkBox.Text);
                    }
                }
                else
                {
                    if (movies.Contains(checkBox.Text))
                    {
                        movies.Remove(checkBox.Text);
                    }
                }
            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            int temp = 0;
       
            foreach (CheckBox checkbox in CheckBoxList)
            {
                if (!checkbox.Checked)
                {
                    temp++;
                }
            }

            if (temp != 0)
            {
                foreach (CheckBox checkbox in CheckBoxList)
                {
                    checkbox.Checked = true;
                }
            }
            else
            {
                foreach (CheckBox checkbox in CheckBoxList)
                {
                    checkbox.Checked = false;
                }

                sagas.Clear();
                movies.Clear();
            }
        }

        public void addToList()
        {
            CheckBoxList.Add(checkBox1);
            CheckBoxList.Add(checkBox2);
            CheckBoxList.Add(checkBox3);
            CheckBoxList.Add(checkBox4);
            CheckBoxList.Add(checkBox5);
            CheckBoxList.Add(checkBox6);
            CheckBoxList.Add(checkBox7);
            CheckBoxList.Add(checkBox8);
            CheckBoxList.Add(checkBox9);
            CheckBoxList.Add(checkBox10);
            CheckBoxList.Add(checkBox11);
            CheckBoxList.Add(checkBox12);
            CheckBoxList.Add(checkBox13);
            CheckBoxList.Add(checkBox14);
            CheckBoxList.Add(checkBox15);
            CheckBoxList.Add(checkBox16);
            CheckBoxList.Add(checkBox17);
            CheckBoxList.Add(checkBox18);
            CheckBoxList.Add(checkBox19);
            CheckBoxList.Add(checkBox20);
            CheckBoxList.Add(checkBox21);
            CheckBoxList.Add(checkBox22);
            CheckBoxList.Add(checkBox23);
            CheckBoxList.Add(checkBox24);
            CheckBoxList.Add(checkBox25);
            CheckBoxList.Add(checkBox26);
            CheckBoxList.Add(checkBox27);
            CheckBoxList.Add(checkBox28);
            CheckBoxList.Add(checkBox29);
            CheckBoxList.Add(checkBox30);
            CheckBoxList.Add(checkBox31);
            CheckBoxList.Add(checkBox32);
            CheckBoxList.Add(checkBox33);
        }
    }
}
