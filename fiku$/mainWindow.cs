using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace fiku_
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            get_currentTablesToLoad();
        }

        loginWindow login = new loginWindow();
        private string accType;

        private void LoadTable()
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Library.accdb");
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select Книги.id as ID, Книги.название as Название, фио as Автор, Книги.[количество страниц] as [Кол-во Страниц], Книги.год as Год, Издательство.название as Издательство, [Виды книг].наименование as [Вид Книги], Книги.цена as Цена " +
                                                            "from Книги, Издательство, Авторы, [Виды книг] " +
                                                            "Where Книги.[id автора] = Авторы.id " +
                                                            "and Книги.[id издательство] = Издательство.id " +
                                                            "and Книги.[id вид книг] = [Виды книг].id", connection);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            dataGridView1.DataSource = dataTable;
        }

        private void LoadEmployeeTable()
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Library.accdb");
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select Пополнение.id as ID, Книги.название as Название, Пополнение.дата as Дата, Пополнение.количество as Количество, Сотрудники.фио as Сотрудник, Пополнение.сумма as Цена, Поставщики.наименование as Поставщик " +
                                                            "from Пополнение, Книги, Сотрудники, Поставщики " +
                                                            "Where Пополнение.[id книги] = Книги.id " +
                                                            "and Пополнение.[id сотрудника] = Сотрудники.id " +
                                                            "and Пополнение.[id поставщика] = Поставщики.id", connection);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            dataGridView1.DataSource = dataTable;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (accType == "Пользователь")
            {
                insertWindow insert = new insertWindow();
                insert.ShowDialog();
            }
            else if (accType == "Сотрудник")
            {
                insertEmployeeWindow privateInsert = new insertEmployeeWindow();
                privateInsert.ShowDialog();
            }
            get_currentTablesToLoad();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (accType == "Пользователь")
            {
                insertWindow insert = new insertWindow(dataGridView1[0, e.RowIndex].Value.ToString());
                insert.ShowDialog();
            }
            else if (accType == "Сотрудник")
            {
                insertEmployeeWindow privateInsert = new insertEmployeeWindow(dataGridView1[0, e.RowIndex].Value.ToString());
                privateInsert.ShowDialog();
            }
            get_currentTablesToLoad();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            login.ShowDialog();
        }

        private void mainWindow_update(object sender, EventArgs e)
        {
            get_currentTablesToLoad();
        }

        private void get_currentTablesToLoad()
        {
            accType = login.AccountType;
            Account.Text = accType;
            if (accType == "Сотрудник")
            {
                Account.ForeColor = System.Drawing.Color.DarkRed;
                Account.Location = new System.Drawing.Point(701, 10);
                this.LoadEmployeeTable();
                addButton.Visible = true;
                Account.Visible = true;
                panel2.Visible = true;
                panel2.BackColor = System.Drawing.Color.DarkRed;
                panel2.Location = new System.Drawing.Point(704, 26);
                panel2.Size = new System.Drawing.Size(53, 3);
                acc_notification.Visible = false;
            }
            else if (accType == "Пользователь")
            {
                Account.ForeColor = System.Drawing.Color.RoyalBlue;
                Account.Location = new System.Drawing.Point(681, 10);
                this.LoadTable();
                addButton.Visible = true; 
                Account.Visible = true;
                panel2.Visible = true;
                panel2.BackColor = System.Drawing.Color.RoyalBlue;
                panel2.Location = new System.Drawing.Point(684, 26);
                panel2.Size = new System.Drawing.Size(73, 3);
                acc_notification.Visible = false;
            }
            else
            {
                Account.Visible = false;
                acc_notification.Visible = true;
                panel2.Visible = false;
            }    
                
        }
        
        private void accountButton_MouseHover(object sender, EventArgs e)
        {
            accountButton.BackgroundImage = fiku_.Properties.Resources.user_hover;
        }

        private void accountButton_MouseLeave(object sender, EventArgs e)
        {
            accountButton.BackgroundImage = fiku_.Properties.Resources.user;
        }
    }
}
