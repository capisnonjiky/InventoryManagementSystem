﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
      
        }

        //to show subform form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm(this));
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm(this));
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm(this));
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm(this));
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm(this));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide MainForm
            LoginForm login = new LoginForm();
            login.Show();

        }
    }
}
