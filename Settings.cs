using System;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;

namespace StudentCharacter
{
    public partial class Settings : Form
    {
        Custom CustomForm;
        User User;
        SQLiteConnection Connection;
        public Settings(User user)
        {
            InitializeComponent();

            User = user;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Connection = Sqlite.SetConnection();
            CustomForm = this.Owner as Custom;
            RefreshUserGroups();
            Connection.Open();
            SQLiteCommand liteCommand = new SQLiteCommand("select SpecialityName from `specialities`", Connection);
            SQLiteDataReader liteDataReader = liteCommand.ExecuteReader();
            while (liteDataReader.Read())
            {
                cbSpecialities.Items.Add(liteDataReader[0].ToString());
            }
            liteDataReader.Close();
            Connection.Close();
            
            cbSpecialities.SelectedIndex = 0;
            cbBase.SelectedIndex = 0;
            this.Size = new System.Drawing.Size(Width - pnlNewGroup.Width - 20, Height);
            pnlNewGroup.Location = new System.Drawing.Point(12, 12);
        }

        private void RefreshUserGroups()
        {
            lbTables.Items.Clear();
            foreach (var item in User.GroupesList)
            {
                var it = lbTables.Items.Add(item.Value);
                if (item.Key == User.CurrentGroupe)
                {
                    lbTables.SelectedItem = lbTables.Items[it];
                }
            }
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            pnlNewGroup.Visible = true;
            pnlUserGroups.Visible = false;
            pnlNewGroup.BringToFront();

            
        }
        /// <summary>
        /// Удаление таблицы пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
          var box =  MessageBox.Show("Вы уверены, что хотите удалить группу? Это сотрет данные о всех студентах в данной группе.","Предупреждение",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (box == DialogResult.Yes)
            {
                Connection.Open();
                SQLiteCommand litecommand = new SQLiteCommand("PRAGMA foreign_keys=ON", Connection);
                litecommand.ExecuteNonQuery();
                long key = 0;
                foreach (var item in User.GroupesList)
                {
                    if (lbTables.SelectedItem.ToString() == item.Value)
                    {

                        litecommand = new SQLiteCommand($"delete from `group` where idGroup={item.Key}", Connection);
                        litecommand.ExecuteReader();
                        key = item.Key;
                    }
                }
                Connection.Close();
                User.GroupesList.Remove(key);
                User.CurrentGroupe = User.GroupesList.ElementAt(0).Key;
                RefreshUserGroups();
                CustomForm.RefreshUserGroups();
            }
        }

        private void lbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            long ind = 0;
            foreach (var item in User.GroupesList)
            {     
                if (item.Value == (string) lbTables.SelectedItem)
                    ind = item.Key;
            }
            User.CurrentGroupe = ind;
            CustomForm.lblTable.Text = User.GroupesList[User.CurrentGroupe];
            foreach (ToolStripMenuItem item in CustomForm.CurrentTable.DropDownItems)
            {
                if (item.Text == User.GroupesList[User.CurrentGroupe])
                {
                    item.Checked=true;
                }
                else
                {
                    item.Checked = false;
                }
            }
        }

        private void Settings_Paint(object sender, PaintEventArgs e)
        {
            ColorTheme.ChangeBack(e,Width,Height);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlUserGroups.Visible = true;
            pnlNewGroup.Visible = false;
            pnlUserGroups.BringToFront();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Connection.Open();
            //создаем выборку из специальностей где название равно выбранному
            SQLiteCommand litecommand = new SQLiteCommand("select idSpeciality,SpecialityShortName from `specialities`" +
                $" where SpecialityName='{cbSpecialities.SelectedItem.ToString()}'", Connection);
            SQLiteDataReader liteDataReader = litecommand.ExecuteReader();
            liteDataReader.Read();
            var specid = liteDataReader[0].ToString();
            var shortname = liteDataReader[1].ToString();
            var groupname = shortname + "-" + numGroupId.Value.ToString();
            liteDataReader.Close();
            //вставляем в таблицу групп новую группу
            litecommand = new SQLiteCommand("insert into `group` (idUser,idSpeciality,GroupName,YearBegin,Base) " +
                    "values(@user,@speciality,@groupname,@yearbegin,@base)", Connection);
            litecommand.Parameters.AddWithValue("@user", User.UserId);
            litecommand.Parameters.AddWithValue("@speciality", specid);
            litecommand.Parameters.AddWithValue("@groupname", groupname);
            litecommand.Parameters.AddWithValue("@yearbegin", numStartYear.Value);
            litecommand.Parameters.AddWithValue("@base", cbBase.SelectedItem.ToString());
            litecommand.ExecuteNonQuery();
            //вычисляем последний вставленный индекс
            litecommand = new SQLiteCommand("SELECT last_insert_rowid()", Connection);
            liteDataReader = litecommand.ExecuteReader();
            liteDataReader.Read();
            var groupid = Convert.ToInt32(liteDataReader[0]);
            liteDataReader.Close();
            Connection.Close();
            User.SetGroups(groupid, groupname);
            //обновляем список групп
            RefreshUserGroups();
            CustomForm.RefreshUserGroups();
            pnlUserGroups.Visible = true;
            pnlNewGroup.Visible = false;
            pnlUserGroups.BringToFront();
        }
    }
}
