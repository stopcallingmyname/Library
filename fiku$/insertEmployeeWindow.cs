using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace fiku_
{
    public partial class insertEmployeeWindow : Form
    {
        string id;

        public insertEmployeeWindow()
        {
            InitializeComponent();
            this.LoadComboBox();
            addButton.Visible = true;
        }

        public insertEmployeeWindow(string _id)
        {
            InitializeComponent();
            id = _id;
            this.LoadComboBox();
            this.LoadString();
            removeButton.Visible = true;
            changeButton.Visible = true;
        }

        private void LoadComboBox()
        {
            OleDbConnection connection1 = new OleDbConnection
            (@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Library.accdb");
            OleDbDataAdapter adapter1 = new OleDbDataAdapter("Select * from Книги", connection1);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            connection1.Close();
            bookNameComboBox.DataSource = dataTable1;
            bookNameComboBox.DisplayMember = "название";
            bookNameComboBox.ValueMember = "id";

            OleDbConnection connection2 = new OleDbConnection
           (@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Library.accdb");
            OleDbDataAdapter adapter2 = new OleDbDataAdapter("Select * from Сотрудники", connection2);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);
            connection2.Close();
            sotrudnikComboBox.DataSource = dataTable2;
            sotrudnikComboBox.DisplayMember = "фио";
            sotrudnikComboBox.ValueMember = "id";

            OleDbConnection connection3 = new OleDbConnection
           (@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Library.accdb");
            OleDbDataAdapter adapter3 = new OleDbDataAdapter("Select * from Поставщики", connection3);
            DataTable dataTable3 = new DataTable();
            adapter3.Fill(dataTable3);
            connection3.Close();
            postavshickComboBox.DataSource = dataTable3;
            postavshickComboBox.DisplayMember = "наименование";
            postavshickComboBox.ValueMember = "id";
        }

        private void LoadString()
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Library.accdb");
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Пополнение where id =" + id, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            dateTextBox.Text = dataTable.Rows[0][2].ToString();
            amountTextBox.Text = dataTable.Rows[0][3].ToString();
            cost.Value = Convert.ToDecimal(dataTable.Rows[0][5]);

            bookNameComboBox.SelectedValue = Convert.ToInt32(dataTable.Rows[0][1]);
            sotrudnikComboBox.SelectedValue = Convert.ToInt32(dataTable.Rows[0][4]);
            postavshickComboBox.SelectedValue = Convert.ToInt32(dataTable.Rows[0][6]);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Library.accdb");
            OleDbDataAdapter adapter = new OleDbDataAdapter("insert into Пополнение ([id книги], дата, количество, [id сотрудника], сумма, [id поставщика]) " +
                                                            $"values ('{bookNameComboBox.SelectedValue}', '{Convert.ToString(dateTextBox.Text)}', {Int32.Parse(amountTextBox.Text)}, {sotrudnikComboBox.SelectedValue}, {((double)cost.Value)}, {postavshickComboBox.SelectedValue})", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Library.accdb");
            OleDbDataAdapter adapter = new OleDbDataAdapter("Delete from Пополнение where id =" + id, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            Close();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Library.accdb");
            OleDbDataAdapter adapter = new OleDbDataAdapter("Update Пополнение set " +
                                                            $"[id книги]='{bookNameComboBox.SelectedValue}', " +
                                                            $"дата='{Convert.ToString(dateTextBox.Text)}', " +
                                                            $"количество={Int32.Parse(amountTextBox.Text)}, " +
                                                            $"[id сотрудника]={sotrudnikComboBox.SelectedValue}, " +
                                                            $"сумма={((double)cost.Value)}, " + 
                                                            $"[id поставщика]={postavshickComboBox.SelectedValue} " +
                                                             "where id=" + id, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            Close();
        }

    }
}
