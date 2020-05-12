namespace Hardware_Store_Project
{
    partial class Menu
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Making_an_application = new System.Windows.Forms.Button();
            this.Closing_application = new System.Windows.Forms.Button();
            this.Staff_of_employees = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Making_an_application
            // 
            this.Making_an_application.Location = new System.Drawing.Point(97, 207);
            this.Making_an_application.Name = "Making_an_application";
            this.Making_an_application.Size = new System.Drawing.Size(182, 60);
            this.Making_an_application.TabIndex = 1;
            this.Making_an_application.Text = "Оформление заявки";
            this.Making_an_application.UseVisualStyleBackColor = true;
            this.Making_an_application.Click += new System.EventHandler(this.Making_an_application_Click);
            // 
            // Closing_application
            // 
            this.Closing_application.Location = new System.Drawing.Point(97, 321);
            this.Closing_application.Name = "Closing_application";
            this.Closing_application.Size = new System.Drawing.Size(182, 60);
            this.Closing_application.TabIndex = 2;
            this.Closing_application.Text = "Закрытие заявки";
            this.Closing_application.UseVisualStyleBackColor = true;
            this.Closing_application.Click += new System.EventHandler(this.button2_Click);
            // 
            // Staff_of_employees
            // 
            this.Staff_of_employees.Location = new System.Drawing.Point(97, 423);
            this.Staff_of_employees.Name = "Staff_of_employees";
            this.Staff_of_employees.Size = new System.Drawing.Size(182, 60);
            this.Staff_of_employees.TabIndex = 3;
            this.Staff_of_employees.Text = "Штат сотрудников";
            this.Staff_of_employees.UseVisualStyleBackColor = true;
            this.Staff_of_employees.Click += new System.EventHandler(this.Staff_of_employees_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Hardware_Store_Project.Properties.Resources._5be1bde3354e9;
            this.Logo.Location = new System.Drawing.Point(114, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(132, 101);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 553);
            this.Controls.Add(this.Staff_of_employees);
            this.Controls.Add(this.Closing_application);
            this.Controls.Add(this.Making_an_application);
            this.Controls.Add(this.Logo);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button Making_an_application;
        private System.Windows.Forms.Button Closing_application;
        private System.Windows.Forms.Button Staff_of_employees;
    }
}

