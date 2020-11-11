using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing.Drawing2D;
using System.Threading;

namespace StudentCharacter
{
    public partial class Autorization : Form
    {
        private SQLiteConnection connection;
        private SQLiteCommand litecommand;
        private Color color1 = Color.FromArgb(255, 0, 64, 107);
        private Color color2 = Color.FromArgb(255, 5, 155, 255);
        private Translitter transliter;
        User User;
        public Autorization()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            EnterInto();
        }

        private void EnterInto()
        {
            connection.Open();
            litecommand = new SQLiteCommand();
            //создаем выборку из бд где логин и пароль равны введенным
            litecommand.CommandText = "select * from `users` where `Login` = @login and `Password`= @password";
            litecommand.Connection = connection;
            //передаем введенные логин и пароль через параметры
            litecommand.Parameters.AddWithValue("@login", tbLogin.Text);
            litecommand.Parameters.AddWithValue("@password", tbParol.Text);
            SQLiteDataReader sQLiteDataReader = litecommand.ExecuteReader();
            sQLiteDataReader.Read();
            if (sQLiteDataReader.HasRows) //если найдено соответствие
            {
                long id = (long)sQLiteDataReader["idUser"];
                var login = (string)sQLiteDataReader["Login"];
                var password = (string)sQLiteDataReader["Password"];
                sQLiteDataReader.Close();
                //создаем выборку групп принадлежащих пользователю
                litecommand = new SQLiteCommand($"select * from `group` where idUser={id}", connection);
                sQLiteDataReader = litecommand.ExecuteReader();
                List<string> tablesList = new List<string>();//массив названий групп
                List<long> indexList = new List<long>();//массив индексов групп
                //заполняем массив полученными группами
                while (sQLiteDataReader.Read())
                {
                    tablesList.Add(sQLiteDataReader["GroupName"].ToString());
                    indexList.Add((long)sQLiteDataReader["idGroup"]);
                }
                sQLiteDataReader.Close();
                //если у пользователя имеются созданные группы
                if (tablesList.Count != 0)
                {
                    User = new User(id, login, password, tablesList, indexList);
                    //если устаовлен флаг запомнить меня
                    if (chbRemember.Checked)
                    {
                        UserData.Remember = true;
                        //записываем в файл данные пользователя
                        UserData.WritePublicData(User.Login);
                    }
                    else
                    {
                        //записываем пустые данные
                        UserData.WritePublicData("");
                    }
                    //открытие формы конструктора
                    Custom custom = new Custom(User, this);
                    custom.Owner = this;
                    custom.Show();
                    this.Hide();
                }
                //если пользователь не создал ни одной группы
                else
                {
                    User = new User(id, login, password);
                    pnlCreateTable.BringToFront(); //показать панель создания группы
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
            connection.Close();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            pnlRegistration.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlAutorization.BringToFront();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            pnlRegistration.Location = new Point(12, 12);
            pnlRegistration.Visible = true;
            pnlAutorization.BringToFront();
            pnlCreateTable.Location = new Point(12, 12);

            Size = new Size(343, 489);
            connection = Sqlite.SetConnection();

            var data = UserData.InitializePublicData();
            if (data != "")
            {
                connection.Open();
                SQLiteCommand litecommand = new SQLiteCommand($"select * from `users` where Login='{data}'", connection);
                SQLiteDataReader liteDataReader = litecommand.ExecuteReader();
                liteDataReader.Read();
                long id = (long)liteDataReader["idUser"];
                var login = (string)liteDataReader["Login"];
                var password = (string)liteDataReader["Password"];

                liteDataReader.Close();

                litecommand = new SQLiteCommand($"select * from `group` where idUser={id}", connection);
                liteDataReader = litecommand.ExecuteReader();

                List<string> tablesList = new List<string>();
                List<long> indexList = new List<long>();
                while (liteDataReader.Read())
                {
                    tablesList.Add(liteDataReader["GroupName"].ToString());
                    indexList.Add((long)liteDataReader["idGroup"]);
                }

                liteDataReader.Close();

                if (tablesList.Count != 0)
                {
                    User = new User(id, login, password, tablesList, indexList);

                    Custom custom = new Custom(User, this);
                    custom.Owner = this;
                    custom.Show();
                    this.Hide();
                }
                else
                {
                    User = new User(id, login, password);
                    pnlCreateTable.BringToFront();
                }

                connection.Close();
            }
            else
            {


                connection.Open();
                SQLiteCommand litecommand = new SQLiteCommand("select * from `specialities` ", connection);
                SQLiteDataReader liteDataReader = litecommand.ExecuteReader();
                while (liteDataReader.Read())
                {
                    cbSpecialities.Items.Add(liteDataReader["SpecialityName"]);
                }

                connection.Close();

                cbSpecialities.SelectedIndex = 0;
                cbBase.SelectedIndex = 0;
                transliter = Translitter.Initialize();
                tbNewLogin.GotFocus += TbNewLogin_GotFocus;
                tbNewLogin.LostFocus += TbNewLogin_LostFocus;
            }
        }

        private void TbNewLogin_LostFocus(object sender, EventArgs e)
        {
            lbSample1.Visible = false;
            lbSample2.Visible = false;
            lbSample3.Visible = false;
        }

        private void TbNewLogin_GotFocus(object sender, EventArgs e)
        {
            if (tbNewSurname.Text != "" && tbNewName.Text != "" && tbNewMidName.Text != "")
            {
                lbSample1.Visible = true;
                lbSample2.Visible = true;
                lbSample3.Visible = true;
                var name = "";
                var surname = "";
                var midname = "";
                foreach (var item in tbNewName.Text)
                {
                    name += transliter[item.ToString().ToUpper()].ToLower();
                }
                foreach (var item in tbNewSurname.Text)
                {
                    surname += transliter[item.ToString().ToUpper()].ToLower();
                }
                foreach (var item in tbNewMidName.Text)
                {
                    midname += transliter[item.ToString().ToUpper()].ToLower();
                }
                lbSample1.Text = name + "_" + surname[0] + midname[0];
                lbSample2.Text = surname + "_" + name[0] + midname[0];
                lbSample3.Text = name + "_" + midname[0] + surname[0];
            }
        }

        public void ChangeBack(PaintEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
               new Point(0, 0),
               new Point(0, this.Height),
               color1,
               color2);
            Pen pen = new Pen(linGrBrush);
            e.Graphics.FillRectangle(linGrBrush, 0, 0, this.Width, this.Height);
        }

        private void btnDoRegistration_Click(object sender, EventArgs e)
        {
            if (tbNewLogin.Text != "" && tbNewParol.Text != "" && tbNewParol.Text == tbApplyParol.Text)
            {
                connection.Open();
                SQLiteCommand litecommand = new SQLiteCommand("select * from `users` where `Login` = @login", connection);
                litecommand.Parameters.AddWithValue("@login", tbNewLogin.Text);
                using (SQLiteDataReader sQLiteData = litecommand.ExecuteReader())
                {
                    sQLiteData.Read();
                    if (sQLiteData.HasRows)
                    {
                        MessageBox.Show("Пожалуйста выберите другое имя пользователя");
                    }
                    else
                    {
                        litecommand = new SQLiteCommand("insert into `users` (Login,Password,Name,MidName,Surname)" +
                            "values(@login,@password,@name,@midname,@surname)", connection);
                        litecommand.Parameters.AddWithValue("@login", tbNewLogin.Text);
                        litecommand.Parameters.AddWithValue("@password", tbNewParol.Text);
                        litecommand.Parameters.AddWithValue("@name", tbNewName.Text);
                        litecommand.Parameters.AddWithValue("@midname", tbNewMidName.Text);
                        litecommand.Parameters.AddWithValue("@surname", tbNewSurname.Text);
                        litecommand.ExecuteNonQuery();
                        litecommand = new SQLiteCommand("SELECT last_insert_rowid()", connection);
                        SQLiteDataReader liteDataReader = litecommand.ExecuteReader();
                        liteDataReader.Read();
                        var id = Convert.ToInt32(liteDataReader[0]);
                        MessageBox.Show("Пользователь создан");
                        pnlRegistration.Visible = false;
                        pnlCreateTable.BringToFront();
                        User = new User(id, tbNewLogin.Text, tbNewParol.Text);
                    }
                }

                connection.Close();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            connection.Open();

            SQLiteCommand litecommand = new SQLiteCommand("select idSpeciality,SpecialityShortName from `specialities`" +
                $" where SpecialityName='{cbSpecialities.SelectedItem.ToString()}'", connection);
            SQLiteDataReader liteDataReader = litecommand.ExecuteReader();
            liteDataReader.Read();
            var specid = liteDataReader[0].ToString();
            var shortname = liteDataReader[1].ToString();
            var groupname = shortname + "-" + numGroupId.Value.ToString();
            liteDataReader.Close();
            litecommand = new SQLiteCommand("insert into `group` (idUser,idSpeciality,GroupName,YearBegin,Base) " +
                    "values(@user,@speciality,@groupname,@yearbegin,@base)", connection);
            litecommand.Parameters.AddWithValue("@user", User.UserId);
            litecommand.Parameters.AddWithValue("@speciality", specid);
            litecommand.Parameters.AddWithValue("@groupname", groupname);
            litecommand.Parameters.AddWithValue("@yearbegin", numStartYear.Value);
            litecommand.Parameters.AddWithValue("@base", cbBase.SelectedItem.ToString());
            litecommand.ExecuteNonQuery();

            litecommand = new SQLiteCommand("SELECT last_insert_rowid()", connection);
            liteDataReader = litecommand.ExecuteReader();
            liteDataReader.Read();
            var groupid = Convert.ToInt32(liteDataReader[0]);
            liteDataReader.Close();
            connection.Close();

            User.SetGroups(groupid, groupname);

            pnlAutorization.Visible = true;
            pnlRegistration.Visible = false;
            pnlCreateTable.Visible = false;
            pnlRegistration.Location = new Point(328, 12);

            Custom custom = new Custom(User, this);
            custom.Owner = this;
            custom.Show();
            this.Hide();
        }

        private void Autorization_Paint(object sender, PaintEventArgs e)
        {
            ChangeBack(e);
        }

        private void tbNames_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbSample_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            tbNewLogin.Text = label.Text;
        }

        private void NewName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (transliter.ContainsKey(e.KeyChar.ToString().ToUpper()) || e.KeyChar == (char)Keys.Back) return;
            else
                e.Handled = true;
        }

        private void numGroupId_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
