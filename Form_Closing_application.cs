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
    public partial class Form_Closing_application : Form
    {
        public Form_Closing_application()
        {
            InitializeComponent();
            Makinganapplication();
            ShowStaffofemployees();
        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void Form_Closing_application_Load(object sender, EventArgs e)
        {

        }
        void Makinganapplication()
        {

            comboBoxIdMakinganapplication.Items.Clear();
            foreach (Making_an_application making_an_application in Program.wftDb.Making_an_application)
            {

                string[] item = { making_an_application.FirstName, making_an_application.MiddleName, making_an_application.LastName,  making_an_application.Type };
                comboBoxIdMakinganapplication.Items.Add(string.Join(" ", item));

            }
        }
        void ShowStaffofemployees()
        {
            comboBoxIdStaffofemployees.Items.Clear();
            foreach (Staff_of_employees staff_of_employees in Program.wftDb.Staff_of_employees)
            {

                string[] item = {  staff_of_employees.FirstName, staff_of_employees.MiddleName, staff_of_employees.LastName};
                comboBoxIdStaffofemployees.Items.Add(string.Join(" ", item));


            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxIdMakinganapplication.SelectedItem != null && comboBoxIdStaffofemployees.SelectedItem != null &&  textBoxPrice.Text != " ")
            {
                Closing_application closing_application = new Closing_application();
               
                closing_application.IdMakinganapplication = Convert.ToInt32(comboBoxIdMakinganapplication.SelectedItem.ToString().Split('.')[0]);
                closing_application.IdStaffofemployees = Convert.ToInt32(comboBoxIdStaffofemployees.SelectedItem.ToString().Split('.')[0]);

                closing_application.Price = Convert.ToInt32(textBoxPrice.Text);
                Program.wftDb.Closing_application.Add(closing_application);
                Program.wftDb.SaveChanges();

            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}