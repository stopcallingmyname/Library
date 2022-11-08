using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace fiku_
{
    public partial class insertWindow : Form
    {
        string id;

        public insertWindow()
        {
            InitializeComponent();
            this.LoadComboBox();
            addButton.Visible = true;
        }

        public insertWindow(string _id)
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
            OleDbDataAdapter adapter1 = new OleDbDataAdapter("Select * from Авторы", connection1);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            connection1.Close();
            authorComboBox.DataSource = dataTable1;
            authorComboBox.DisplayMember = "фио";
            authorComboBox.ValueMember = "id";

            OleDbConnection connection2 = new OleDbConnection
           (@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Library.accdb");
            OleDbDataAdapter adapter2 = new OleDbDataAdapter("Select * from Издательство", connection2);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);
            connection2.Close();
            CreationComboBox.DataSource = dataTable2;
            CreationComboBox.DisplayMember = "название";
            CreationComboBox.ValueMember = "id";

            OleDbConnection connection3 = new OleDbConnection
           (@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Library.accdb");
            OleDbDataAdapter adapter3 = new OleDbDataAdapter("Select * from [Виды книг]", connection3);
            DataTable dataTable3 = new DataTable();
            adapter3.Fill(dataTable3);
            connection3.Close();
            typeComboBox.DataSource = dataTable3;
            typeComboBox.DisplayMember = "наименование";
            typeComboBox.ValueMember = "id";
        }

        private void LoadString()
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Library.accdb");
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Книги where id =" + id, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            bookName.Text = dataTable.Rows[0][1].ToString();
            pages.Text = dataTable.Rows[0][3].ToString();
            year.Text = dataTable.Rows[0][4].ToString();
            cost.Value = Convert.ToDecimal(dataTable.Rows[0][7]);

            authorComboBox.SelectedValue = Convert.ToInt32(dataTable.Rows[0][2]);
            CreationComboBox.SelectedValue = Convert.ToInt32(dataTable.Rows[0][5]);
            typeComboBox.SelectedValue = Convert.ToInt32(dataTable.Rows[0][6]);
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Library.accdb");
            OleDbDataAdapter adapter = new OleDbDataAdapter("insert into Книги (название, [id автора], [количество страниц], год, [id издательство], [id вид книг], цена) " +
                                                            $"values ('{bookName.Text}', {authorComboBox.SelectedValue}, {Int32.Parse(pages.Text)}, {Int32.Parse(year.Text)}, {CreationComboBox.SelectedValue}, {typeComboBox.SelectedValue}, {((double)cost.Value)})", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Library.accdb");
            OleDbDataAdapter adapter = new OleDbDataAdapter("Delete from Книги where id =" + id, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            Close();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Library.accdb");
            OleDbDataAdapter adapter = new OleDbDataAdapter("Update Книги set " +
                                                            $"название='{bookName.Text}', " +
                                                            $"[id автора]={authorComboBox.SelectedValue}, " +
                                                            $"[количество страниц]={Int32.Parse(pages.Text)}, " +
                                                            $"год={Int32.Parse(year.Text)}, " +
                                                            $"[id издательство]={CreationComboBox.SelectedValue}, " +
                                                            $"[id вид книг]={typeComboBox.SelectedValue}, " +
                                                            $"цена={((double)cost.Value)} " +
                                                             "where id=" + id, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            Close();
        }
    }
}
