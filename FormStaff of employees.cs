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
    public partial class Form_Staff_of_employees : Form
    {
        public Form_Staff_of_employees()
        {
            InitializeComponent();
            ShowStaff_of_employees();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Staff_of_employees staff_of_employees = new Staff_of_employees();

            staff_of_employees.FirstName = textBoxFirstName.Text;
            staff_of_employees.MiddleName = textBoxMiddleName.Text;
            staff_of_employees.LastName = textBoxLastName.Text;
            staff_of_employees.Phone = Convert.ToInt32(textBoxPhone.Text);
            staff_of_employees.Salary = Convert.ToInt32(textBoxSalary.Text);


            Program.wftDb.Staff_of_employees.Add(staff_of_employees);
            Program.wftDb.SaveChanges();
            ShowStaff_of_employees();

        }
        void ShowStaff_of_employees()
        {

            listViewStaffofemployees.Items.Clear();

            foreach (Staff_of_employees staff_of_employees in Program.wftDb.Staff_of_employees)
            {


                ListViewItem item = new ListViewItem(new string[]
                {
                  
                    staff_of_employees.Id.ToString(),staff_of_employees.FirstName, staff_of_employees.MiddleName,
                    staff_of_employees.LastName, staff_of_employees.Phone.ToString(), staff_of_employees.Salary.ToString()
                });

                item.Tag = staff_of_employees;

                listViewStaffofemployees.Items.Add(item);
            }

            listViewStaffofemployees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            if (listViewStaffofemployees.SelectedItems.Count == 1)
            {

                Staff_of_employees staff_of_employees = listViewStaffofemployees.SelectedItems[0].Tag as Staff_of_employees;

                staff_of_employees.FirstName = textBoxFirstName.Text;
                staff_of_employees.MiddleName = textBoxMiddleName.Text;
                staff_of_employees.LastName = textBoxLastName.Text;
                staff_of_employees.Phone = Convert.ToInt32(textBoxPhone.Text);
                staff_of_employees.Salary = Convert.ToInt32(textBoxSalary.Text);

                Program.wftDb.SaveChanges();
                ShowStaff_of_employees();
            }
        }

        private void listViewStaffofemployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listViewStaffofemployees.SelectedItems.Count == 1)
            {

                Staff_of_employees staff_of_employees = (listViewStaffofemployees.SelectedItems[0].Tag as Staff_of_employees);
               
                textBoxFirstName.Text = staff_of_employees.FirstName;
                textBoxMiddleName.Text = staff_of_employees.MiddleName;
                textBoxLastName.Text = staff_of_employees.LastName;
                textBoxPhone.Text = Convert.ToString (staff_of_employees.Phone);
               
                textBoxSalary.Text = Convert.ToString(staff_of_employees.Salary);
            }
            else
            {
                
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxPhone.Text = "";
                textBoxSalary.Text ="";
        }
    }

        private void buttonDell_Click(object sender, EventArgs e)
        {
            try
            {

                if (listViewStaffofemployees.SelectedItems.Count == 1)
                {

                    Staff_of_employees staff_of_employees = listViewStaffofemployees.SelectedItems[0].Tag as Staff_of_employees;

                    Program.wftDb.Staff_of_employees.Remove(staff_of_employees);

                    Program.wftDb.SaveChanges();

                    ShowStaff_of_employees();

                }

                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxPhone.Text = "";
                textBoxSalary.Text = "";


            }

            catch
            {

                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
