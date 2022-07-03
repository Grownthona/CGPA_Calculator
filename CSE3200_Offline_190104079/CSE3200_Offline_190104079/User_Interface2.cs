using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE3200_Offline_190104079
{
    public partial class User_Interface2 : Form
    {
        double GPA;
        string name;
        public User_Interface2()
        {
            InitializeComponent();
        }
        public User_Interface2(double GPA, string name)
        {
            InitializeComponent();
            this.GPA = GPA;
            this.name = name;
        }

        private void User_Interface2_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(GPA);
            label2.Text = "Welcome "+name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Interface1 interface1 = new User_Interface1();
            this.Hide();
            interface1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
