using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string file1 = comboBox1.SelectedItem.ToString();
                Process.Start(@"C:\\Users\\watadeni_ps14058\\Documents\\new\\"+file1+".txt");
            }
            catch
            {
                MessageBox.Show("please Select a file to open");
            }
        }
    }
}
