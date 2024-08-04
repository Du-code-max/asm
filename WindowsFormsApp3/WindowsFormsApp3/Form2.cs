using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Phone", 50);
            listView1.Columns.Add("Type of customer", 150);
            listView1.Columns.Add("Number of member", 150);
            listView1.Columns.Add("Last month", 100);
            listView1.Columns.Add("This month", 100);
            listView1.Columns.Add("Amount of water", 150);
            listView1.Columns.Add("Total price", 100);
            listView1.Columns.Add("Description", 200);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
               
                ListViewItem selectedItem = listView1.SelectedItems[0];

                
                textBox1.Text = selectedItem.Text; 
                textBox2.Text = selectedItem.SubItems[1].Text; 
                textBox3.Text = selectedItem.SubItems[2].Text; 
                comboBox1.SelectedItem = selectedItem.SubItems[3].Text; 
                textBox4.Text = selectedItem.SubItems[4].Text; 
                textBox5.Text = selectedItem.SubItems[5].Text; 
                textBox6.Text = selectedItem.SubItems[6].Text; 
                textBox7.Text = selectedItem.SubItems[7].Text;
                textBox8.Text = selectedItem.SubItems[8].Text; 
                textBox9.Text = selectedItem.SubItems[9].Text; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            string Name = textBox2.Text;
            string PhoneNumber = textBox3.Text;
            string Type = null;
            int NumberOfMembers = 0;
            double LastMonth, ThisMonth;
            double TotalAmount = 0;
            string Description = textBox9.Text;

            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please enter customer ID", "Notification",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Please enter customer name", "Notification",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(PhoneNumber))
            {
                MessageBox.Show("Please enter phone number", "Notification",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }
            else if (comboBox1.SelectedIndex == 0 && (string.IsNullOrEmpty(textBox4.Text) || !int.TryParse(textBox4.Text, out NumberOfMembers) || NumberOfMembers <= 0))
            {
                MessageBox.Show("Please enter a valid number of members greater than 0", "Notification",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBox5.Text) || !double.TryParse(textBox5.Text, out LastMonth) || LastMonth < 0)
            {
                MessageBox.Show("Please enter a valid previous month's water consumption (non-negative)", "Notification",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBox6.Text) || !double.TryParse(textBox6.Text, out ThisMonth) || ThisMonth < 0)
            {
                MessageBox.Show("Please enter a valid current month's water consumption (non-negative)", "Notification",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }
            else if (ThisMonth < LastMonth)
            {
                MessageBox.Show("This month's water consumption cannot be less than last month", "Notification",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(Description))
            {
                MessageBox.Show("Please enter description", "Notification",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox9.Focus();
                return;
            }

            int consumption = CalculateConsumption((int)LastMonth, (int)ThisMonth);
            int customerType = comboBox1.SelectedIndex + 1;

            switch (customerType)
            {
                case 1:
                    Type = "Household";
                    break;
                case 2:
                    Type = "Administrative Office";
                    break;
                case 3:
                    Type = "Production Unit";
                    break;
                case 4:
                    Type = "Business Service";
                    break;
                default:
                    MessageBox.Show("Please enter customer type", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            TotalAmount = CalculateWaterBill(consumption, customerType, NumberOfMembers);

            textBox7.Text = consumption.ToString();
            textBox8.Text = TotalAmount.ToString("C2");

            ListViewItem item = new ListViewItem();
            item.Text = ID;
            item.SubItems.Add(Name);
            item.SubItems.Add(PhoneNumber);
            item.SubItems.Add(Type);
            item.SubItems.Add(NumberOfMembers.ToString());
            item.SubItems.Add(LastMonth.ToString());
            item.SubItems.Add(ThisMonth.ToString());
            item.SubItems.Add(consumption.ToString());
            item.SubItems.Add(TotalAmount.ToString("C2"));
            item.SubItems.Add(Description);
            listView1.Items.Add(item);

            
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;
            comboBox1.SelectedIndex = -1;
        }

        private int CalculateConsumption(int lastMonth, int thisMonth)
        {
            return thisMonth - lastMonth;
        }

        public double CalculateWaterBill(double consumption, double customerType, double numberOfMembers)
        {
            double amount = 0;

            switch (customerType)
            {
                case 1:
                    if (consumption <= 10)
                    {
                        amount = 5.973 * consumption;
                    }
                    else if (consumption <= 20)
                    {
                        amount = 5.973 * 10 + 7.052 * (consumption - 10);
                    }
                    else if (consumption <= 30)
                    {
                        amount = 5.973 * 10 + 7.052 * 10 + 8.699 * (consumption - 20);
                    }
                    else
                    {
                        amount = 5.973 * 10 + 7.052 * 10 + 8.699 * 10 + 15.929 * (consumption - 30);
                    }
                    break;
                case 2:
                    amount = 9.955 * consumption;
                    break;
                case 3:
                    amount = 11.615 * consumption;
                    break;
                case 4:
                    amount = 22.068 * consumption;
                    break;
            }

            return amount * 1.21;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox4.ReadOnly = false;
                textBox4.Text = "";
                textBox9.Text = "Tax: 0.1 environmental protection fee x 0.1 VAT x 10% water fee = 1.21";
            }
            else
            {
                textBox4.ReadOnly = true;
                textBox4.Text = "0";
                if (comboBox1.SelectedIndex == 1)
                {
                    textBox9.Text = "Tax: 0.1 environmental protection fee x 0.1 VAT x 10% water fee = 1.21";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    textBox9.Text = "Tax: 0.1 environmental protection fee x 0.1 VAT x 10% water fee = 1.21";
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    textBox9.Text = "Tax: 0.1 environmental protection fee x 0.1 VAT x 10% water fee = 1.21";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0) 
            {
                ListViewItem selectedItem = listView1.SelectedItems[0]; 
                selectedItem.SubItems.Clear();

                string ID = textBox1.Text;
                string Name = textBox2.Text;
                string PhoneNumber = textBox3.Text;
                string Type = null;
                int NumberOfMembers = 0;
                double Last, This;
                double TotalAmount = 0;
                string Description = textBox9.Text;

               
                if (string.IsNullOrEmpty(ID))
                {
                    MessageBox.Show("Please Enter ID Customer", "Notice",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(Name))
                {
                    MessageBox.Show("Please Enter Customer Name", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(PhoneNumber))
                {
                    MessageBox.Show("Please Enter Phone Number", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Focus();
                    return;
                }
                else if (comboBox1.SelectedIndex == 0 && (string.IsNullOrEmpty(textBox4.Text) || !int.TryParse(textBox4.Text, out NumberOfMembers) || NumberOfMembers <= 0))
                {
                    MessageBox.Show("Please Enter a Valid Positive Number Of People", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(textBox5.Text) || !double.TryParse(textBox5.Text, out Last) || Last < 0)
                {
                    MessageBox.Show("Please Enter a Valid Non-negative Amount Of Water Used Last Month", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox5.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(textBox6.Text) || !double.TryParse(textBox6.Text, out This) || This < 0)
                {
                    MessageBox.Show("Please Enter a Valid Non-negative Amount Of Water Used This Month", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox6.Focus();
                    return;
                }
                else if (This < Last)
                {
                    MessageBox.Show("Water usage this month cannot be less than last month", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox6.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(Description))
                {
                    MessageBox.Show("Please Enter Description", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox9.Focus();
                    return;
                }

                int consumption = CalculateConsumption((int)Last, (int)This);
                int customerType = comboBox1.SelectedIndex + 1;

                switch (customerType)
                {
                    case 1:
                        Type = "Household";
                        break;
                    case 2:
                        Type = "Administrative agency";
                        break;
                    case 3:
                        Type = "Production units";
                        break;
                    case 4:
                        Type = "Business services";
                        break;
                    default:
                        MessageBox.Show("Please enter Type of customer", "Notice",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                TotalAmount = CalculateWaterBill(consumption, customerType, NumberOfMembers);

                textBox7.Text = consumption.ToString();
                textBox8.Text = TotalAmount.ToString("C2");

                
                selectedItem.Text = ID;
                selectedItem.SubItems.Add(Name);
                selectedItem.SubItems.Add(PhoneNumber);
                selectedItem.SubItems.Add(Type);
                selectedItem.SubItems.Add(NumberOfMembers.ToString());
                selectedItem.SubItems.Add(Last.ToString());
                selectedItem.SubItems.Add(This.ToString());
                selectedItem.SubItems.Add(consumption.ToString());
                selectedItem.SubItems.Add(TotalAmount.ToString("C2"));
                selectedItem.SubItems.Add(Description);

                
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                textBox6.Text = null;
                textBox7.Text = null;
                textBox8.Text = null;
                textBox9.Text = null;
                comboBox1.SelectedIndex = -1;
            }
        }

        
        private int Calculate(int lastMonth, int thisMonth)
        {
            return thisMonth - lastMonth;
        }

        public double CalculateBill(double consumption, double customerType, double numberOfMembers)
        {
            double amount = 0;

            switch (customerType)
            {
                case 1:
                    if (consumption <= 10)
                    {
                        amount = 5.973 * consumption;
                    }
                    else if (consumption <= 20)
                    {
                        amount = 5.973 * 10 + 7.052 * (consumption - 10);
                    }
                    else if (consumption <= 30)
                    {
                        amount = 5.973 * 10 + 7.052 * 10 + 8.699 * (consumption - 20);
                    }
                    else
                    {
                        amount = 5.973 * 10 + 7.052 * 10 + 8.699 * 10 + 15.929 * (consumption - 30);
                    }
                    break;
                case 2:
                    amount = 9.955 * consumption;
                    break;
                case 3:
                    amount = 11.615 * consumption;
                    break;
                case 4:
                    amount = 22.068 * consumption;
                    break;
            }

            return amount * 1.21;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);

                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                textBox6.Text = null;
                textBox7.Text = null;
                textBox8.Text = null;
                textBox9.Text = null;
                comboBox1.SelectedIndex = -1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                Form3 form3 = new Form3(
                    selectedItem.SubItems[0].Text,
                    selectedItem.SubItems[1].Text,
                    selectedItem.SubItems[2].Text,
                    selectedItem.SubItems[3].Text,
                    selectedItem.SubItems[4].Text,
                    selectedItem.SubItems[5].Text,
                    selectedItem.SubItems[6].Text,
                    selectedItem.SubItems[7].Text,
                    selectedItem.SubItems[8].Text,
                    selectedItem.SubItems[9].Text
                );

                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an item to show the bill.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
