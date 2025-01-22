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

        private void checkBox26_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                string tagValue = checkBox.Tag.ToString();

                if (checkBox.Checked)
                {
                    if (!sagas.Contains(tagValue))
                    {
                        sagas.Add(tagValue);
                    }
                }
                else
                {
                    if (sagas.Contains(tagValue))
                    {
                        sagas.Remove(tagValue);
                    }
                }
            }
        }
    }
}
