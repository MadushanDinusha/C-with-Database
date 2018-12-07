using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dsStudent11.Clear();
            sqlDataAdapter1.Fill(dsStudent11);//
        }

        private void btnUpadate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlDataAdapter1.Update(dsStudent11);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }
    }
}
