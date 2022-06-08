using System.Collections.Generic;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        List<UserClass> names = new List<UserClass>();
        public Form1()
        {
            InitializeComponent();
            names.Add(new UserClass("aboud", "123"));
            names.Add(new UserClass("ali", "589"));
            names.Add(new UserClass("Hoda", "742"));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            // Console.Write("Hello Aboud");
            string textUser = TextName.Text;
            string textPassword = TextPassword.Text;
            foreach(UserClass user in names)
            {
                
                if (user.getUserName().Equals(textUser))
                {
                    count = 1; 
                    if (user.getPassword().Equals(textPassword))
                    {
                        count = 2;
                    }
                }
            }

            if(count==1)
            {
                MessageBox.Show("WorngPassword");
            }
            else if (count==2){
                MessageBox.Show("Hello "+ textUser);
            }
            else
            {
                MessageBox.Show("That User Name Not Exsits");
            }


        }
    }
}