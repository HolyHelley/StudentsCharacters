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

namespace StudentCharacter
{
    public partial class Subjects : Form
    {
        SQLiteConnection connection;
        User User;
        Base Base;
        public Subjects(User user)
        {
            User = user;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //если название предмета введено
            if (tbName.Text != "")
            {
                List<int> studentIndexes = new List<int>(); //массив для индексов студентов
                connection.Open();
                //создаем выборку из предметов текущей группы
                SQLiteCommand command = new SQLiteCommand($"insert into `subjects`(SubjectName,Semester,idGroup) " +
                    $"values('{tbName.Text}',{numSemester.Value},{User.CurrentGroupe})", connection);
                command.ExecuteNonQuery();
                //вычисляем последний индекс вставки
                command = new SQLiteCommand("SELECT last_insert_rowid()", connection);
                SQLiteDataReader liteDataReader = command.ExecuteReader();
                liteDataReader.Read();
                var lastind = liteDataReader[0];
                liteDataReader.Close();
                //создаем выборку студентов из текущей группы
                command = new SQLiteCommand($"SELECT idStudent from `students` where idGroup={User.CurrentGroupe}", connection);
                liteDataReader = command.ExecuteReader();
                if (liteDataReader.HasRows)
                {
                    while (liteDataReader.Read())
                    {
                        //добавляем индексы студентов в массив
                        studentIndexes.Add(Convert.ToInt32(liteDataReader[0]));
                    }
                }
                liteDataReader.Close();
                //перебираем массив индексов присваивая студентам новый предмет
                foreach (var item in studentIndexes)
                {
                    command = new SQLiteCommand($"insert into `marks` (idStudent,idSubject) values({item},{lastind})", connection);
                    command.ExecuteNonQuery();
                }

                connection.Close();
                LoadTable();
                Base.LoadTable("",Base.TableType);
            }
            else
            {
                MessageBox.Show("Название не введено","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            Base = (Base) this.Owner;
            dgvSubjects.Columns.Add("Name", "Название предмета");
            dgvSubjects.Columns.Add("Semester", "Семестр");
            connection = Sqlite.SetConnection();

            LoadTable();
        }

        private void LoadTable()
        {
            dgvSubjects.Rows.Clear();
            connection.Open();
            SQLiteCommand command = new SQLiteCommand($"select SubjectName,Semester from `subjects` where idGroup={User.CurrentGroupe}", connection);
            SQLiteDataReader liteDataReader = command.ExecuteReader();
            while (liteDataReader.Read())
            {
                dgvSubjects.Rows.Add(liteDataReader[0].ToString(), liteDataReader[1].ToString());
            }
            liteDataReader.Close();
            connection.Close();
        }

        private void Subjects_Paint(object sender, PaintEventArgs e)
        {
            ColorTheme.ChangeBack(e, Width, Height);
        }
    }
}
