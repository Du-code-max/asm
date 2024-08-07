﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3(string id, string name, string phoneNumber, string customerType, string numberOfMembers, string lastMonth, string thisMonth, string amountOfWater, string totalPrice, string description)
        {
            InitializeComponent();


            lblID.Text = $"ID: {id}";
            lblName.Text = $"Name: {name}";
            lblPhone.Text = $"Phone: {phoneNumber}";
            lblType.Text = $"Customer Type: {customerType}";
            lblNumber.Text = $"Number of members: {numberOfMembers}";
            lblWaterLast.Text = $"Last Month: {lastMonth}";
            lblWaterThis.Text = $"This Month: {thisMonth}";
            lblAmount.Text = $"Amount of Water: {amountOfWater}";
            lblTotal.Text = $"Total Price: {totalPrice}";
            lblDescription.Text = $"Description: {description}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult check_Exit = MessageBox.Show("Do you want to exit?", "Confirm", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (check_Exit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
