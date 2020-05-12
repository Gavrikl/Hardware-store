namespace Hardware_Store_Project
{
    partial class Form_Closing_application
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Logo = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDell = new System.Windows.Forms.Button();
            this.listViewMaking_an_application = new System.Windows.Forms.ListView();
            this.Покупатель = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Кассир = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Цена = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelIdMakinganapplication = new System.Windows.Forms.Label();
            this.labelIdStaffofemployees = new System.Windows.Forms.Label();
            this.comboBoxIdMakinganapplication = new System.Windows.Forms.ComboBox();
            this.comboBoxIdStaffofemployees = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::Hardware_Store_Project.Properties.Resources._5be1bde3354e9;
            this.Logo.Location = new System.Drawing.Point(41, 474);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(132, 101);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 17;
            this.Logo.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(317, 521);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 34);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Создать ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(481, 521);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(90, 34);
            this.buttonEdit.TabIndex = 19;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDell
            // 
            this.buttonDell.Location = new System.Drawing.Point(658, 521);
            this.buttonDell.Name = "buttonDell";
            this.buttonDell.Size = new System.Drawing.Size(107, 34);
            this.buttonDell.TabIndex = 20;
            this.buttonDell.Text = "Удалить  ";
            this.buttonDell.UseVisualStyleBackColor = true;
            // 
            // listViewMaking_an_application
            // 
            this.listViewMaking_an_application.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Покупатель,
            this.Кассир,
            this.Цена});
            this.listViewMaking_an_application.FullRowSelect = true;
            this.listViewMaking_an_application.GridLines = true;
            this.listViewMaking_an_application.Location = new System.Drawing.Point(166, 53);
            this.listViewMaking_an_application.MultiSelect = false;
            this.listViewMaking_an_application.Name = "listViewMaking_an_application";
            this.listViewMaking_an_application.Size = new System.Drawing.Size(851, 372);
            this.listViewMaking_an_application.TabIndex = 21;
            this.listViewMaking_an_application.UseCompatibleStateImageBehavior = false;
            this.listViewMaking_an_application.View = System.Windows.Forms.View.Details;
            // 
            // Покупатель
            // 
            this.Покупатель.Text = "Покупатель";
            this.Покупатель.Width = 258;
            // 
            // Кассир
            // 
            this.Кассир.Text = "Кассир";
            this.Кассир.Width = 260;
            // 
            // Цена
            // 
            this.Цена.Text = "Цена";
            this.Цена.Width = 89;
            // 
            // labelIdMakinganapplication
            // 
            this.labelIdMakinganapplication.AutoSize = true;
            this.labelIdMakinganapplication.Location = new System.Drawing.Point(12, 42);
            this.labelIdMakinganapplication.Name = "labelIdMakinganapplication";
            this.labelIdMakinganapplication.Size = new System.Drawing.Size(86, 17);
            this.labelIdMakinganapplication.TabIndex = 22;
            this.labelIdMakinganapplication.Text = "Покупатель";
            this.labelIdMakinganapplication.Click += new System.EventHandler(this.labelFirstName_Click);
            // 
            // labelIdStaffofemployees
            // 
            this.labelIdStaffofemployees.AutoSize = true;
            this.labelIdStaffofemployees.Location = new System.Drawing.Point(12, 119);
            this.labelIdStaffofemployees.Name = "labelIdStaffofemployees";
            this.labelIdStaffofemployees.Size = new System.Drawing.Size(55, 17);
            this.labelIdStaffofemployees.TabIndex = 24;
            this.labelIdStaffofemployees.Text = "Кассир";
            // 
            // comboBoxIdMakinganapplication
            // 
            this.comboBoxIdMakinganapplication.FormattingEnabled = true;
            this.comboBoxIdMakinganapplication.Location = new System.Drawing.Point(12, 62);
            this.comboBoxIdMakinganapplication.Name = "comboBoxIdMakinganapplication";
            this.comboBoxIdMakinganapplication.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIdMakinganapplication.TabIndex = 25;
            // 
            // comboBoxIdStaffofemployees
            // 
            this.comboBoxIdStaffofemployees.FormattingEnabled = true;
            this.comboBoxIdStaffofemployees.Location = new System.Drawing.Point(12, 139);
            this.comboBoxIdStaffofemployees.Name = "comboBoxIdStaffofemployees";
            this.comboBoxIdStaffofemployees.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIdStaffofemployees.TabIndex = 26;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 191);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(43, 17);
            this.labelPrice.TabIndex = 27;
            this.labelPrice.Text = "Цена";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 211);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 22);
            this.textBoxPrice.TabIndex = 28;
            // 
            // Form_Closing_application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 587);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.comboBoxIdStaffofemployees);
            this.Controls.Add(this.comboBoxIdMakinganapplication);
            this.Controls.Add(this.labelIdStaffofemployees);
            this.Controls.Add(this.labelIdMakinganapplication);
            this.Controls.Add(this.listViewMaking_an_application);
            this.Controls.Add(this.buttonDell);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.Logo);
            this.Name = "Form_Closing_application";
            this.Text = "Закрытие заявки";
            this.Load += new System.EventHandler(this.Form_Closing_application_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDell;
        private System.Windows.Forms.ListView listViewMaking_an_application;
        private System.Windows.Forms.ColumnHeader Покупатель;
        private System.Windows.Forms.ColumnHeader Кассир;
        private System.Windows.Forms.ColumnHeader Цена;
        private System.Windows.Forms.Label labelIdMakinganapplication;
        private System.Windows.Forms.Label labelIdStaffofemployees;
        private System.Windows.Forms.ComboBox comboBoxIdMakinganapplication;
        private System.Windows.Forms.ComboBox comboBoxIdStaffofemployees;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}