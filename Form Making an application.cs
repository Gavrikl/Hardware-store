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
    public partial class Form_Making_an_application : Form
    {
        public Form_Making_an_application()
        {
            InitializeComponent();
            ShowMaking_an_application();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            try
            {
                
                if (listViewMaking_an_application.SelectedItems.Count == 1)
                {
                    
                    Making_an_application making_an_application = listViewMaking_an_application.SelectedItems[0].Tag as Making_an_application;
                    
                    Program.wftDb.Making_an_application.Remove(making_an_application);
                   
                    Program.wftDb.SaveChanges();
                   
                    ShowMaking_an_application();

                }

                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxPhone.Text = "";
                textBoxQuantity.Text = "";
                comboBoxType.Text = "";
                

            }
            
            catch
            {
                
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Making_an_application making_an_application = new Making_an_application();

            making_an_application.FirstName = textBoxFirstName.Text;
            making_an_application.MiddleName = textBoxMiddleName.Text;
            making_an_application.LastName = textBoxLastName.Text;
            making_an_application.Phone = Convert.ToInt32(textBoxPhone.Text);
            making_an_application.Type = comboBoxType.Text;

            making_an_application.Quantity = Convert.ToInt32(textBoxQuantity.Text);
            Program.wftDb.Making_an_application.Add(making_an_application);
            Program.wftDb.SaveChanges();
            ShowMaking_an_application();

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_Making_an_application_Load(object sender, EventArgs e)
        {

        }
        void ShowMaking_an_application()
        {

            listViewMaking_an_application.Items.Clear();

            foreach (Making_an_application making_an_application in Program.wftDb.Making_an_application)
            {


                ListViewItem item = new ListViewItem(new string[]
                {
                  
                    making_an_application.Id.ToString(),making_an_application.FirstName, making_an_application.MiddleName,
                    making_an_application.LastName, making_an_application.Phone.ToString(), making_an_application.Type.ToString(), making_an_application.Quantity.ToString()
                });

                item.Tag = making_an_application;

                listViewMaking_an_application.Items.Add(item);
            }

            listViewMaking_an_application.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
        if (listViewMaking_an_application.SelectedItems.Count == 1)
        {
            
           Making_an_application making_an_application = listViewMaking_an_application.SelectedItems[0].Tag as  Making_an_application;
            
            making_an_application.FirstName = textBoxFirstName.Text;
            making_an_application.MiddleName = textBoxMiddleName.Text;
            making_an_application.LastName = textBoxLastName.Text;
            making_an_application.Phone = Convert.ToInt32(textBoxPhone.Text);
            making_an_application.Type = comboBoxType.Text;
           
            making_an_application.Quantity = Convert.ToInt32(textBoxQuantity.Text);
            
            
            Program.wftDb.SaveChanges();
            ShowMaking_an_application();
            
        }
    }

        private void listViewMaking_an_application_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listViewMaking_an_application.SelectedItems.Count == 1)
            {
                
                Making_an_application making_an_application = listViewMaking_an_application.SelectedItems[0].Tag as Making_an_application;
               
                textBoxFirstName.Text = making_an_application.FirstName;
                textBoxMiddleName.Text = making_an_application.MiddleName;
                textBoxLastName.Text = making_an_application.LastName;
                textBoxPhone.Text = Convert.ToString (making_an_application.Phone);

                comboBoxType.Text = making_an_application.Type;
                textBoxQuantity.Text = Convert.ToString(making_an_application.Quantity);
            }
            else
            {
                
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxPhone.Text = "";
                textBoxQuantity.Text = "";
                comboBoxType.Text = "";

            }
        }
    }
}