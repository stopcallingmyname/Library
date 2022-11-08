using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fiku_
{
    public partial class loginWindow : Form
    {
        private string accountType;
        public string AccountType { get { return accountType; } }

        public loginWindow()
        {
            InitializeComponent();
            set_accTypes();
        }

        private void acceptAccButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void get_accType(object sender, EventArgs e)
        {
            accountType = accTypeComboBox.SelectedItem.ToString();
            acceptAccButton.Visible = true;
        }

        private void set_accTypes()
        {
            accTypeComboBox.Items.Add("Пользователь");
            accTypeComboBox.Items.Add("Сотрудник");
        }

    }
}
