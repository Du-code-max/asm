using System;
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


            label1.Text = $"ID: {id}";
            label2.Text = $"Name: {name}";
            label3.Text = $"Phone: {phoneNumber}";
            label4.Text = $"Customer Type: {customerType}";
            label5.Text = $"Number of members: {numberOfMembers}";
            label6.Text = $"Last Month: {lastMonth}";
            label7.Text = $"This Month: {thisMonth}";
            label8.Text = $"Amount of Water: {amountOfWater}";
            label9.Text = $"Total Price: {totalPrice}";
            label10.Text = $"Description: {description}";
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
    }
}
