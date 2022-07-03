using System.Text.RegularExpressions;

namespace CSE3200_Offline_190104079
{
    public partial class User_Interface1 : Form
    {
        public User_Interface1()
        {
            InitializeComponent();
        }

        public double check(double value)
        {
            double gradepoint = 0.00;

            if (value >= 80)
            {
                gradepoint = 4.00;
            }
            else if (value >= 75 && value < 80)
            {
                gradepoint = 3.75;
            }
            else if (value >= 70 && value < 75)
            {
                gradepoint = 3.50;
            }
            else if (value >= 65 && value < 70)
            {
                gradepoint = 3.25;
            }
            else if (value >= 60 && value < 65)
            {
                gradepoint = 3.00;
            }
            else if (value >= 55 && value < 60)
            {
                gradepoint = 2.75;
            }
            else if (value >= 50 && value < 55)
            {
                gradepoint = 2.50;
            }
            else if (value >= 45 && value < 50)
            {
                gradepoint = 2.25;
            }
            else if (value >= 40 && value < 45)
            {
                gradepoint = 2.00;
            }
            else if (value < 40)
            {
                gradepoint = 0.00;
            }
            return gradepoint;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox1.Text;
                string name = textBox2.Text;
                string checkname = "";
                int catcherror = 0;
                string first = id.Substring(0, 6);
                int last = Convert.ToInt32(id.Substring(6));
                List<int> gone = new List<int>() { 5, 6, 11, 23, 40, 48, 52, 64, 66, 69, 84, 91, 115, 112, 133 };
                List<string> readd = new List<string>() { "180104003", "180104040", "180104092", "180104099", "180104150", "180204001", "180204013", "180204020", "180204138" };

                for (int i= 0; i < name.Length;i++)
                {
                    if (name[i] != ' ')
                        checkname += name[i];
                    else
                    {
                        if (char.IsUpper(name[i+1]) == false)
                            catcherror = 1;
                    }
                }

                if (name == "" || id == "")
                {
                    MessageBox.Show("You must fill all the fields.", "Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(Regex.IsMatch(id, @"^[0-9]+$") == false)
                {
                    MessageBox.Show("Put the correct Id.", "Incorrect Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(char.IsUpper(checkname[0])==false || Regex.IsMatch(checkname, @"^[a-zA-Z]+$") == false || catcherror==1)
                {
                    MessageBox.Show("Put the correct Name.", "Incorrect Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if ((first == "190104" && gone.Contains(last) == false && last >= 1 && last <= 151) || (readd.Contains(id) == true))
                {
                    label1.Text = "Correct";
                    double CSE_4101 = Convert.ToDouble(cse4101.Value);
                    double CSE_4102 = Convert.ToDouble(cse4102.Value);
                    double CSE_4107 = Convert.ToDouble(cse4107.Value);
                    double CSE_4108 = Convert.ToDouble(cse4108.Value);
                    double CSE_4125 = Convert.ToDouble(cse4125.Value);
                    double CSE_4126 = Convert.ToDouble(cse4126.Value);
                    double CSE_4129 = Convert.ToDouble(cse4129.Value);
                    double CSE_4130 = Convert.ToDouble(cse4130.Value);
                    double CSE_4111 = Convert.ToDouble(cse4111.Value);

                    double result = ((check(CSE_4101) * 3.00) + (check(CSE_4102) * 1.50) + (check(CSE_4107) * 3.00) + (check(CSE_4108) * 0.75) + (check(CSE_4125) * 3.00) + (check(CSE_4126) * 0.75) + (check(CSE_4129) * 3.00) + (check(CSE_4130) * 0.75) + (check(CSE_4111) * 3.00)) / (3.00 * 5 + 0.75 * 3 + 1.50);


                     User_Interface2 interface2 = new User_Interface2(result,name);
                     this.Hide();
                     interface2.Show();
                }
                else
                {
                    MessageBox.Show("Id is Invalid for AUST CSE 3.2", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}