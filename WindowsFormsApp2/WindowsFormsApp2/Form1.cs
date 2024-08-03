using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            listView1.Columns.Add("Description", 100);

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

            // Clear all fields
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
            if (comboBox1.SelectedIndex == 0) // Household
            {
                textBox4.ReadOnly = false; // Unlock the number of people input
                textBox4.Text = ""; // Clear any previous input
                textBox9.Text = $"Household customer{"",-22}|Price{"",-15}|Up to 10 m3/person/month{"",-16}|5.973 VND" +
                             $"\r\nFrom 10-20 m3/person/month{"",-6}|7.052 VND/m3 \r\nFrom 20-30 m3/person/month{"",-5}|8.699 VND/m3 \r\nAbove 30 m3/person/month{"",-12}|15.929 VND/m3" +
                             $"\r\nEnvironment fees (10%)\r\nVAT (10%)";
            }
            else
            {
                textBox4.ReadOnly = true; // Lock the number of people input
                textBox4.Text = "0"; // Set number of people to 0
                if (comboBox1.SelectedIndex == 1) // Administrative agency, public services
                {
                    textBox9.Text = $"Administrative agency, public services{"",-13}|Price{"",-6}|9.955 VND/m3" +
                                 $"\r\nEnvironment fees (10%)\r\nVAT (10%)";
                }
                else if (comboBox1.SelectedIndex == 2) // Production units
                {
                    textBox9.Text = $"Production units{"",-13}|Price{"",-6}|11.615 VND/m3" +
                                 $"\r\nEnvironment fees (10%)\r\nVAT (10%)";
                }
                else if (comboBox1.SelectedIndex == 3) // Business services
                {
                    textBox9.Text = $"Business services{"",-13}|Price{"",-6}|22.068 VND/m3" +
                                 $"\r\nEnvironment fees (10%)\r\nVAT (10%)";

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0) // Đảm bảo mục đã được chọn
            {
                ListViewItem selectedItem = listView1.SelectedItems[0]; // Lấy mục đã chọn
                selectedItem.SubItems.Clear();

                string ID = textBox1.Text;
                string Name = textBox2.Text;
                string PhoneNumber = textBox3.Text;
                string Type = null;
                int NumberOfMembers = 0;
                double Last, This;
                double TotalAmount = 0;
                string Description = textBox9.Text;

                // Các kiểm tra nhập liệu
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

                // Cập nhật lại thông tin cho mục đã chọn
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

                // Reset all fields
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

        // Đặt các phương thức này bên ngoài phương thức `button2_Click`
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Lấy thông tin từ các SubItems và đặt chúng vào các TextBox tương ứng
                textBox1.Text = selectedItem.Text; // ID
                textBox2.Text = selectedItem.SubItems[1].Text; // Name
                textBox3.Text = selectedItem.SubItems[2].Text; // Phone
                comboBox1.SelectedItem = selectedItem.SubItems[3].Text; // Type
                textBox4.Text = selectedItem.SubItems[4].Text; // Number of members
                textBox5.Text = selectedItem.SubItems[5].Text; // Last month's water usage
                textBox6.Text = selectedItem.SubItems[6].Text; // This month's water usage
                textBox7.Text = selectedItem.SubItems[7].Text; // Consumption
                textBox8.Text = selectedItem.SubItems[8].Text; // Total amount
                textBox9.Text = selectedItem.SubItems[9].Text; // Description
            }
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


        public static string Name;
        public static string PhoneNumber;
        public static string NumberofMembers;


        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem tempitem = listView1.SelectedItems[0];
                string name = tempitem.SubItems[0].Text;
                string phone = tempitem.SubItems[1].Text;
                string type = tempitem.SubItems[2].Text;
                int Numberofmembers = int.Parse(tempitem.SubItems[3].Text);
                double Lastmonth = double.Parse(tempitem.SubItems[4].Text);
                double Thismonth = double.Parse(tempitem.SubItems[5].Text);
                int Amountofwater = int.Parse(tempitem.SubItems[6].Text);
                double Totalprice = double.Parse(tempitem.SubItems[7].Text);
                string description = tempitem.SubItems[8].Text;

                Name = name;
                PhoneNumber = phone;
                

                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
                this.Close();

            } 
             
            
        
        }
    }
}
    

