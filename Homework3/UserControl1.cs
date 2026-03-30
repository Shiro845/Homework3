using System;
using System.Windows.Forms;

namespace Homework3
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1(string name, string price, string calories, string date, string type)
        {
            InitializeComponent();

            label1.Text = name;
            label2.Text = $"${price}";
            label3.Text = $"Calories: {calories}";
            label4.Text = $"Date Expire: {date}";
            label5.Text = type;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control parent = this.Parent;

            if (parent is FlowLayoutPanel panel)
            {
                panel.Controls.Remove(this);
                this.Dispose();
            }
        }
    }
}
