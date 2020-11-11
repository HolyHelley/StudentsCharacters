using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic;

namespace StudentCharacter
{
    public partial class AdvancedInfo : Form
    {
        PersonalInfo PersonalInfo;
        SQLiteConnection Connection;
        Custom Custom;
        public AdvancedInfo(PersonalInfo personalInfo)
        {
            InitializeComponent();
            PersonalInfo = personalInfo;
            Connection = Sqlite.SetConnection();
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            Custom = (Custom)this.Owner;
            lblName.Text = Custom.tbStudName.Text + " " + Custom.tbStudSurname.Text;
            LoadTable();
        }

        private void LoadTable()
        {
            dgvBase.Rows.Clear();
            if (PersonalInfo == PersonalInfo.Events)
            {
                lblInfoType.Text = "Мероприятие";
                Connection.Open();
                dgvBase.Columns.Add("Event", "Событие");
                dgvBase.Columns.Add("Date", "Дата");
                dgvBase.Columns["Event"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvBase.Columns["Date"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dgvStudent.Columns.Add("Event", "Событие");
                dgvStudent.Columns.Add("Date", "Дата");
                dgvStudent.Columns.Add("Description", "Комментарий");
                dgvStudent.Columns["Event"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvStudent.Columns["Date"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvStudent.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                SQLiteCommand command = new SQLiteCommand("select * from `events` group by EventName", Connection);
                SQLiteDataReader liteDataReader = command.ExecuteReader();
                while (liteDataReader.Read())
                {
                    dgvBase.Rows.Add(liteDataReader["EventName"], Convert.ToDateTime(liteDataReader["EventDate"]).ToShortDateString());
                }
                liteDataReader.Close();

                command = new SQLiteCommand("select * from `events`", Connection);
                liteDataReader = command.ExecuteReader();

                while (liteDataReader.Read())
                {
                    if (Custom.EventsInd.Keys.Contains(Convert.ToInt32(liteDataReader["idEvent"])))
                    {
                        dgvStudent.Rows.Add(liteDataReader["EventName"], liteDataReader["EventDate"], liteDataReader["Description"]);
                    }
                }


                liteDataReader.Close();

                Connection.Close();
            }
            if (PersonalInfo == PersonalInfo.Qualities)
            {
                lblTextDate.Visible = false;
                dtDate.Visible = false;
                lblInfoType.Text = "Качество";
                Connection.Open();


                dgvStudent.Columns.Add("Quality", "Качество");
                dgvStudent.Columns["Quality"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvBase.Columns.Add("Quality", "Качества");

                dgvBase.Columns["Quality"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                SQLiteCommand command = new SQLiteCommand("select * from `personalqualities`", Connection);
                SQLiteDataReader liteDataReader = command.ExecuteReader();
                while (liteDataReader.Read())
                {
                    dgvBase.Rows.Add(liteDataReader["Quality"]);
                }
                liteDataReader.Close();

                command = new SQLiteCommand("select * from `personalqualities`", Connection);
                liteDataReader = command.ExecuteReader();

                while (liteDataReader.Read())
                {
                    if (Custom.QualitiesInd.Keys.Contains(Convert.ToInt32(liteDataReader["idQuality"])))
                    {
                        dgvStudent.Rows.Add(liteDataReader["Quality"]);
                    }
                }


                liteDataReader.Close();

                Connection.Close();
            }
            if (PersonalInfo == PersonalInfo.Olympiads)
            {
                Connection.Open();
                dgvBase.Columns.Add("Olympiad", "Олимпиада");
                dgvBase.Columns.Add("Date", "Дата");
                dgvBase.Columns["Olympiad"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvBase.Columns["Date"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dgvStudent.Columns.Add("Olympiad", "Олимпиада");
                dgvStudent.Columns.Add("Date", "Дата");
                dgvStudent.Columns.Add("Description", "Комментарий");
                dgvStudent.Columns["Olympiad"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvStudent.Columns["Date"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvStudent.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                SQLiteCommand command = new SQLiteCommand("select * from `olympiads` group by OlympiadName", Connection);
                SQLiteDataReader liteDataReader = command.ExecuteReader();
                while (liteDataReader.Read())
                {
                    dgvBase.Rows.Add(liteDataReader["OlympiadName"], Convert.ToDateTime(liteDataReader["OlympiadDate"]).ToShortDateString());
                }
                liteDataReader.Close();

                command = new SQLiteCommand("select * from `olympiads`", Connection);
                liteDataReader = command.ExecuteReader();

                while (liteDataReader.Read())
                {
                    if (Custom.OlympiadsInd.Keys.Contains(Convert.ToInt32(liteDataReader["idOlympiad"])))
                    {
                        dgvStudent.Rows.Add(liteDataReader["OlympiadName"], liteDataReader["OlympiadDate"], liteDataReader["Description"]);
                    }
                }
                liteDataReader.Close();

                Connection.Close();
            }
            if (PersonalInfo == PersonalInfo.Orders)
            {
                Connection.Open();
                dgvBase.Columns.Add("Order", "Приказ");
                dgvBase.Columns.Add("Date", "Дата");
                dgvBase.Columns["Order"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvBase.Columns["Date"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;


                dgvStudent.Columns.Add("Orders", "Приказ");
                dgvStudent.Columns.Add("Date", "Дата");
                dgvStudent.Columns.Add("Description", "Комментарий");
                dgvStudent.Columns["Orders"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvStudent.Columns["Date"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvStudent.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                SQLiteCommand command = new SQLiteCommand("select * from `orders` group by OrderName", Connection);
                SQLiteDataReader liteDataReader = command.ExecuteReader();
                while (liteDataReader.Read())
                {
                    dgvBase.Rows.Add(liteDataReader["OrderName"], Convert.ToDateTime(liteDataReader["OrderDate"]).ToShortDateString());
                }
                liteDataReader.Close();

                command = new SQLiteCommand("select * from `orders`", Connection);
                liteDataReader = command.ExecuteReader();

                while (liteDataReader.Read())
                {
                    if (Custom.OrdersInd.Keys.Contains(Convert.ToInt32(liteDataReader["idOrder"])))
                    {
                        dgvStudent.Rows.Add(liteDataReader["OrderName"], liteDataReader["OrderDate"], liteDataReader["Description"]);
                    }
                }
                liteDataReader.Close();

                Connection.Close();
            }
        }

        private void AdvancedInfo_Paint(object sender, PaintEventArgs e)
        {
            ColorTheme.ChangeBack(e, Width, Height);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (PersonalInfo == PersonalInfo.Events)
            {
                var box = Interaction.InputBox("Введите описание", "?");
                if (box != "")
                {
                    Connection.Open();
                    var currentRow = dgvBase.SelectedRows[0].Cells;
                    var date = Convert.ToDateTime(currentRow["Date"].Value).ToString("yyyy-MM-dd");
                    SQLiteCommand command = new SQLiteCommand("insert into `events`(EventName,EventDate,Description) " +
                        $"values('{currentRow["Event"].Value}','{date}','{box}')", Connection);


                    command.ExecuteNonQuery();

                    command = new SQLiteCommand("SELECT last_insert_rowid()", Connection);
                    SQLiteDataReader liteDataReader = command.ExecuteReader();
                    liteDataReader.Read();
                    var lastind = liteDataReader[0];
                    liteDataReader.Close();
                    Connection.Close();

                    dgvStudent.Rows.Add(currentRow["Event"].Value, currentRow["Date"].Value, box);
                    Custom.EventsInd.Add(Convert.ToInt32(lastind), currentRow["Event"].Value.ToString());
                    Custom.lbEvents.Items.Add(currentRow["Event"].Value.ToString());
                }
            }
            if (PersonalInfo == PersonalInfo.Qualities)
            {
                Connection.Open();
                SQLiteCommand command = new SQLiteCommand($"select idQuality from `personalqualities` " +
                    $"where Quality='{dgvBase.SelectedRows[0].Cells[0].Value.ToString()}'", Connection);
                SQLiteDataReader liteDataReader = command.ExecuteReader();
                liteDataReader.Read();
                var ind = liteDataReader[0];
                liteDataReader.Close();

                Connection.Close();
                var currentRow = dgvBase.SelectedRows[0].Cells;
                dgvStudent.Rows.Add(currentRow["Quality"].Value);
                Custom.QualitiesInd.Add(Convert.ToInt32(ind), currentRow["Quality"].Value.ToString());
                Custom.lbPersonalQuality.Items.Add(currentRow["Quality"].Value.ToString());
            }
            if (PersonalInfo == PersonalInfo.Olympiads)
            {
                var box = Interaction.InputBox("Введите описание", "?");
                if (box != "")
                {
                    Connection.Open();
                    var currentRow = dgvBase.SelectedRows[0].Cells;
                    var date = Convert.ToDateTime(currentRow["Date"].Value).ToString("yyyy-MM-dd");
                    SQLiteCommand command = new SQLiteCommand("insert into `olympiads`(OlympiadName,OlympiadDate,Description) " +
                        $"values('{currentRow["Olympiad"].Value}','{date}','{box}')", Connection);


                    command.ExecuteNonQuery();

                    command = new SQLiteCommand("SELECT last_insert_rowid()", Connection);
                    SQLiteDataReader liteDataReader = command.ExecuteReader();
                    liteDataReader.Read();
                    var lastind = liteDataReader[0];
                    liteDataReader.Close();

                    Connection.Close();

                    dgvStudent.Rows.Add(currentRow["Olympiad"].Value, currentRow["Date"].Value, box);
                    Custom.OlympiadsInd.Add(Convert.ToInt32(lastind), currentRow["Olympiad"].Value.ToString());
                    Custom.lbOlympiads.Items.Add(currentRow["Olympiad"].Value.ToString());
                }
            }
            if (PersonalInfo == PersonalInfo.Orders)
            {
                var box = Interaction.InputBox("Введите описание", "?");
                if (box != "")
                {
                    Connection.Open();
                    var currentRow = dgvBase.SelectedRows[0].Cells;
                    var date = Convert.ToDateTime(currentRow["Date"].Value).ToString("yyyy-MM-dd");
                    SQLiteCommand command = new SQLiteCommand("insert into `orders`(OrderName,OrderDate,Description) " +
                        $"values('{currentRow["Order"].Value}','{date}','{box}')", Connection);


                    command.ExecuteNonQuery();

                    command = new SQLiteCommand("SELECT last_insert_rowid()", Connection);
                    SQLiteDataReader liteDataReader = command.ExecuteReader();
                    liteDataReader.Read();
                    var lastind = liteDataReader[0];
                    liteDataReader.Close();

                    Connection.Close();

                    dgvStudent.Rows.Add(currentRow["Order"].Value, currentRow["Date"].Value, box);
                    Custom.OrdersInd.Add(Convert.ToInt32(lastind), currentRow["Order"].Value.ToString());
                    Custom.lbOrders.Items.Add(currentRow["Order"].Value.ToString());
                }
            }
        }

        private void tbApply_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                if (PersonalInfo == PersonalInfo.Events)
                {
                    Connection.Open();
                    SQLiteCommand liteCommand = new SQLiteCommand("insert into `events`(EventName,EventDate)" +
                        $" values('{tbName.Text}','{dtDate.Value.ToString("yyyy-MM-dd")}') ", Connection);
                    liteCommand.ExecuteNonQuery();

                    Connection.Close();
                    MessageBox.Show("Данные добавлены");
                }
                if (PersonalInfo == PersonalInfo.Qualities)
                {
                    Connection.Open();
                    SQLiteCommand liteCommand = new SQLiteCommand("insert into `personalqualities`(Quality)" +
                        $" values('{tbName.Text}') ", Connection);
                    liteCommand.ExecuteNonQuery();

                    Connection.Close();
                    MessageBox.Show("Данные добавлены");
                }
                if (PersonalInfo == PersonalInfo.Olympiads)
                {
                    Connection.Open();
                    SQLiteCommand liteCommand = new SQLiteCommand("insert into `olympiads`(OlympiadName,OlympiadDate)" +
                        $" values('{tbName.Text}','{dtDate.Value.ToString("yyyy-MM-dd")}') ", Connection);
                    liteCommand.ExecuteNonQuery();

                    Connection.Close();
                    MessageBox.Show("Данные добавлены");
                }
                if (PersonalInfo == PersonalInfo.Orders)
                {
                    Connection.Open();
                    SQLiteCommand liteCommand = new SQLiteCommand("insert into `orders`(OrderName,OrderDate)" +
                        $" values('{tbName.Text}','{dtDate.Value.ToString("yyyy-MM-dd")}') ", Connection);
                    liteCommand.ExecuteNonQuery();

                    Connection.Close();
                    MessageBox.Show("Данные добавлены");
                }
                LoadTable();
            }
        }
    }
}
