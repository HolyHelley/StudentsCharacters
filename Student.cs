using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq;

namespace StudentCharacter
{
    public class Student
    {
        public long Id;
        public string Name;
        public string SurName;
        public string MidName;
        public string Gender;
        public DateTime BirthDate;
        public string Course;
        public decimal MidMark;
        public string Abilities;
        public string Speciality;
        public string Criticism;
        public string Lates;
        public string Discipline;
        public string Relationship;
        public long idGroup;
        public long StartYear;
        public string Group;
        public string ClassTeacher;
        public byte ClassHead;
        public byte Commercial;

        public Dictionary<long, string> OlympiadsInd = new Dictionary<long, string>();
        public Dictionary<long, string> EventsInd = new Dictionary<long, string>();
        public Dictionary<long, string> OrdersInd = new Dictionary<long, string>();
        public Dictionary<long, string> QualitiesInd = new Dictionary<long, string>();
        public Student(DataGridViewRow dataGridViewRow)
        {
            Id = Convert.ToInt64(dataGridViewRow.Cells["ИД"].Value);
            Name = dataGridViewRow.Cells["Имя"].Value.ToString();
            SurName = dataGridViewRow.Cells["Фамилия"].Value.ToString();
            MidName = dataGridViewRow.Cells["Отчество"].Value.ToString();
            Gender = dataGridViewRow.Cells["Пол"].Value.ToString();
            BirthDate = Convert.ToDateTime(dataGridViewRow.Cells["Дата рождения"].Value.ToString());
            Course = dataGridViewRow.Cells["Курс"].Value.ToString();
            Abilities = dataGridViewRow.Cells["Склонности"].Value.ToString();
            Criticism = dataGridViewRow.Cells["Отношение к критике"].Value.ToString();
            Relationship = dataGridViewRow.Cells["Отношения с группой"].Value.ToString();
            Lates = dataGridViewRow.Cells["Опоздания"].Value.ToString();
            Discipline = dataGridViewRow.Cells["Дисциплина"].Value.ToString();
            Group = dataGridViewRow.Cells["Группа"].Value.ToString();
            ClassHead = Convert.ToByte(dataGridViewRow.Cells["Староста"].Value);
            Commercial = Convert.ToByte(dataGridViewRow.Cells["Коммерческий"].Value);

            SQLiteConnection liteConnection;
            liteConnection = Sqlite.SetConnection();
            liteConnection.Open();

            SQLiteCommand liteCommand = new SQLiteCommand("select `olympiads`.idOlympiad,OlympiadName,Description from `olympiads` left join `olympiads_MM_students` using(idOlympiad)" +
                " where idStudent=" + Id, liteConnection);
            SQLiteDataReader liteDataReader = liteCommand.ExecuteReader();
            while (liteDataReader.Read())
            {
                OlympiadsInd.Add(Convert.ToInt64(liteDataReader[0]), liteDataReader[1].ToString()+" ("+ liteDataReader[2].ToString()+")");
            }
            liteDataReader.Close();
            liteCommand = new SQLiteCommand("select `events`.idEvent,EventName,Description from `events` left join `events_MM_students` using(idEvent)" +
                " where idStudent=" + Id, liteConnection);
            liteDataReader = liteCommand.ExecuteReader();
            while (liteDataReader.Read())
            {
                EventsInd.Add(Convert.ToInt64(liteDataReader[0]), liteDataReader[1].ToString() + " (" + liteDataReader[2].ToString() + ")");
            }
            liteDataReader.Close();
            liteCommand = new SQLiteCommand("select `personalqualities`.idQuality,Quality from `personalqualities` left join `persqualities_MM_students` using(idQuality)" +
                " where idStudent=" + Id, liteConnection);
            liteDataReader = liteCommand.ExecuteReader();
            while (liteDataReader.Read())
            {
                QualitiesInd.Add(Convert.ToInt64(liteDataReader[0]), liteDataReader[1].ToString());
            }
            liteDataReader.Close();
            liteCommand = new SQLiteCommand("select `orders`.idOrder,OrderName,Description from `orders` left join `orders_MM_students` using(idOrder)" +
                " where idStudent=" + Id, liteConnection);
            liteDataReader = liteCommand.ExecuteReader();
            while (liteDataReader.Read())
            {
                OrdersInd.Add(Convert.ToInt64(liteDataReader[0]), liteDataReader[1].ToString() + " (" + liteDataReader[2].ToString() + ")");
            }
            liteDataReader.Close();


            liteCommand = new SQLiteCommand($"select Mark from marks where idStudent={Id}", liteConnection);
            liteDataReader = liteCommand.ExecuteReader();
            List<long> marks = new List<long>();
            var mark = (long)0;
            while (liteDataReader.Read())
            {
                if (Int64.TryParse(liteDataReader[0].ToString(), out mark)){
                    marks.Add(mark);
                }
            }
            var average = marks.ToArray().Average();
            MidMark = Convert.ToDecimal(average);
            liteDataReader.Close();

            liteCommand = new SQLiteCommand($"select Name,Surname,MidName from `users` left join `group` where GroupName='{Group}'", liteConnection);
            liteDataReader = liteCommand.ExecuteReader();
            liteDataReader.Read();
            ClassTeacher = liteDataReader[0] + " " + liteDataReader[1] + " " + liteDataReader[2];
            liteDataReader.Close();

            liteCommand = new SQLiteCommand($"select SpecialityName,SpecialityCode from `specialities` left join `group` where GroupName='{Group}'", liteConnection);
            liteDataReader = liteCommand.ExecuteReader();
            liteDataReader.Read();
            Speciality = liteDataReader[0] + " " + liteDataReader[1];
            liteDataReader.Close();

            liteCommand = new SQLiteCommand($"select YearBegin from `group` where GroupName='{Group}'", liteConnection);
            liteDataReader = liteCommand.ExecuteReader();
            liteDataReader.Read();
            StartYear = (long) liteDataReader[0];
            liteDataReader.Close();

            liteConnection.Close();
        }

        public Student(Custom custom)
        {
            SQLiteConnection liteConnection;
            liteConnection = Sqlite.SetConnection();
            liteConnection.Open();

            Name = custom.tbStudName.Text;
            SurName = custom.tbStudSurname.Text;
            MidName = custom.tbMidName.Text;
            Gender = custom.cbGender.Text;
            BirthDate = custom.dtBirthDate.Value;
            Course = custom.cbCourse.SelectedItem.ToString();
            MidMark = custom.numMidMark.Value;
            QualitiesInd = new Dictionary<long, string>(custom.QualitiesInd);
            OlympiadsInd = new Dictionary<long, string>(custom.OlympiadsInd);
            OrdersInd = new Dictionary<long, string>(custom.OrdersInd);
            EventsInd = new Dictionary<long, string>(custom.EventsInd);
            Abilities = custom.cbAbilities.SelectedItem.ToString();
            Criticism = custom.cbCriticism.SelectedItem.ToString();
            Relationship = custom.cbRelationship.SelectedItem.ToString();
            Lates = custom.cbLates.SelectedItem.ToString();
            Discipline = custom.cbDiscipline.SelectedItem.ToString();
            Group = custom.cbGroupe.SelectedItem.ToString();
            if (custom.chbHead.Checked)
                ClassHead = 1;
            else
                ClassHead = 0;
            if (custom.chbCommercial.Checked)
                Commercial = 1;
            else
                Commercial = 0;
            OlympiadsInd = new Dictionary<long, string>(custom.OlympiadsInd);
            EventsInd = new Dictionary<long, string>(custom.EventsInd);
            QualitiesInd = new Dictionary<long, string>(custom.QualitiesInd);
            OrdersInd = new Dictionary<long, string>(custom.OrdersInd);

            SQLiteCommand liteCommand = new SQLiteCommand($"select `Name`,`Surname`,`MidName` from `users` join `group` where GroupName='{Group}'",liteConnection);
            SQLiteDataReader liteDataReader;
            liteDataReader = liteCommand.ExecuteReader();
            liteDataReader.Read();
            ClassTeacher = liteDataReader[0] + " " + liteDataReader[1] + " " + liteDataReader[2];
            liteDataReader.Close();

            liteCommand = new SQLiteCommand($"select SpecialityName,SpecialityCode from `specialities` left join `group` where GroupName='{Group}'", liteConnection);
            liteDataReader = liteCommand.ExecuteReader();
            liteDataReader.Read();
            Speciality = liteDataReader[0] + " " + liteDataReader[1];
            liteDataReader.Close();

            liteCommand = new SQLiteCommand($"select YearBegin from `group` where GroupName='{Group}'", liteConnection);
            liteDataReader = liteCommand.ExecuteReader();
            liteDataReader.Read();
            StartYear = (long)liteDataReader[0];
            liteDataReader.Close();

            liteConnection.Close();

        }

        public Student(List<object> data)
        {
            Name = data[1].ToString();
            SurName = data[2].ToString();
            MidName = data[3].ToString();
            Gender = data[4].ToString();
            BirthDate = Convert.ToDateTime(data[5]);
            Course = data[6].ToString();
            Abilities = data[7].ToString();
            Criticism = data[8].ToString();
            Relationship = data[9].ToString();
            Lates = data[10].ToString();
            Discipline = data[11].ToString();
            if ((bool)data[12])
                ClassHead = 1;
            else
                ClassHead = 0;
            idGroup = Convert.ToInt64(data[13]);
            Group = data[14].ToString();
            if ((bool)data[15])
                Commercial = 1;
            else
                Commercial = 0;


        }
    }
}
