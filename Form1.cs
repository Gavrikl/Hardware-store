using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Store_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Closing_application form_Closing_application = new Form_Closing_application();
            form_Closing_application.Show();
        }

        private void Making_an_application_Click(object sender, EventArgs e)
        {
           Form_Making_an_application form_Making_an_application = new Form_Making_an_application();
            form_Making_an_application.Show();
        }

        private void Staff_of_employees_Click(object sender, EventArgs e)
        {
            Form_Staff_of_employees form_Staff_of_employees = new Form_Staff_of_employees();
            form_Staff_of_employees.Show();
        }
    }
}
