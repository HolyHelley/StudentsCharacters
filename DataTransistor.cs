using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace StudentCharacter
{
    public static class DataTransistor
    {
        public static void DataToConstruct(Custom customForm, Student student)
        {
            customForm.tbStudName.Text = student.Name;
            customForm.tbStudSurname.Text = student.SurName;
            customForm.tbMidName.Text = student.MidName;
            customForm.dtBirthDate.Value = Convert.ToDateTime(student.BirthDate);
            customForm.numMidMark.Value = student.MidMark;
            customForm.cbCriticism.SelectedIndex = customForm.cbCriticism.Items.IndexOf(student.Criticism);
            customForm.cbGroupe.SelectedIndex = customForm.cbGroupe.Items.IndexOf(student.Group);
            customForm.cbGender.SelectedIndex = customForm.cbGender.Items.IndexOf(student.Gender);
            customForm.cbAbilities.SelectedIndex = customForm.cbAbilities.Items.IndexOf(student.Abilities);
            customForm.cbCourse.SelectedIndex = customForm.cbCourse.Items.IndexOf(student.Course);
            customForm.cbLates.SelectedIndex = customForm.cbLates.Items.IndexOf(student.Lates);
            customForm.cbRelationship.SelectedIndex = customForm.cbRelationship.Items.IndexOf(student.Relationship);
            customForm.cbDiscipline.SelectedIndex = customForm.cbDiscipline.Items.IndexOf(student.Discipline);
            customForm.chbHead.Checked = Convert.ToBoolean(student.ClassHead);
            customForm.chbCommercial.Checked = Convert.ToBoolean(student.Commercial);

            customForm.numMidMark.Value = student.MidMark;
            customForm.OlympiadsInd = new Dictionary<long,string>(student.OlympiadsInd);
            customForm.OrdersInd = new Dictionary<long,string>(student.OrdersInd);
            customForm.QualitiesInd = new Dictionary<long, string>(student.QualitiesInd);
            customForm.EventsInd = new Dictionary<long, string>(student.EventsInd);

            customForm.lbOlympiads.Items.Clear();
            foreach (var item in student.OlympiadsInd.Values)
            {
                customForm.lbOlympiads.Items.Add(item);
            }
            customForm.lbEvents.Items.Clear();
            foreach (var item in student.EventsInd.Values)
            {
                customForm.lbEvents.Items.Add(item);
            }
            customForm.lbPersonalQuality.Items.Clear();
            foreach (var item in student.QualitiesInd.Values)
            {
                customForm.lbPersonalQuality.Items.Add(item);
            }
            customForm.lbOrders.Items.Clear();
            foreach (var item in student.OrdersInd.Values)
            {
                customForm.lbOrders.Items.Add(item);
            }
        }

        public static void ConstructToData(Student student, SQLiteConnection sqlConnection)
        {
            SQLiteConnection Connection = Sqlite.SetConnection();
            Connection.Open();
            SQLiteCommand command = new SQLiteCommand($"select idGroup from `group` where GroupName='{student.Group}'", Connection);
            SQLiteDataReader liteDataReader = command.ExecuteReader();
            liteDataReader.Read();
            var groupid = Convert.ToInt32(liteDataReader[0]);
            liteDataReader.Close();
            command = new SQLiteCommand(string.Format("insert into `students`(" +
                "`Name`," +
                " `Surname`," +
                " `MidName`," +
                "`Gender`, " +
                " `BirthDate`," +
                "`Criticism`," +
                "`GoodAbilities`," +
                "`Course`," +
                "`Lates`," +
                "`Relationship`," +
                "`idGroup`," +
                "`Discipline`," +
                "`ClassHead`," +
                "`Commercial`) " +
            $"values(" +
            $"@Name," +
            $"@Surname," +
            $"@MidName," +
            $"@Gender," +
            $"@BirthDate," +
            $"@Criticism," +
            $"@Abilities," +
            $"@Course," +
            $"@Lates," +
            $"@Relationship," +
            $"@Group," +
            $"@Discipline," +
            $"@ClassHead," +
            $"@Commercial) on conflict (`Name`,`Surname`,`MidName`) do update set " +
            $"`Name`=@Name," +
             $"`Surname`=@Surname," +
            $"`MidName`=@MidName," +
            $"`Gender`=@Gender," +
            $"`BirthDate`=@BirthDate," +
            $"`Criticism`=@Criticism," +
            $"`GoodAbilities`=@Abilities," +
            $"`Course`=@Course," +
            $"`Lates`=@Lates," +
            $"`Relationship`=@Relationship," +
            $"`idGroup`=@Group," +
            $"`Discipline`=@Discipline," +
            $"`ClassHead`=@ClassHead," +
            $"`Commercial`=@Commercial"), Connection);
            command.Parameters.AddWithValue("@Name", student.Name);
            command.Parameters.AddWithValue("@Surname", student.SurName);
            command.Parameters.AddWithValue("@MidName", student.MidName);
            command.Parameters.AddWithValue("@Gender", student.Gender);
            command.Parameters.AddWithValue("@BirthDate", student.BirthDate.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@Criticism", student.Criticism);
            command.Parameters.AddWithValue("@Abilities", student.Abilities);
            command.Parameters.AddWithValue("@Course", student.Course);
            command.Parameters.AddWithValue("@Lates", student.Lates);
            command.Parameters.AddWithValue("@Relationship", student.Relationship);
            command.Parameters.AddWithValue("@Group", groupid);
            command.Parameters.AddWithValue("@Discipline", student.Discipline);
            command.Parameters.AddWithValue("@ClassHead", student.ClassHead);
            command.Parameters.AddWithValue("@Commercial", student.Commercial);
            command.ExecuteNonQuery();

            ///Добавление студента в таблицу оценок
            ///
            command = new SQLiteCommand($"SELECT idStudent from `students` where Name='{student.Name}' " +
                $"and Surname='{student.SurName}' and MidName='{student.MidName}'", Connection);
            liteDataReader = command.ExecuteReader();
            liteDataReader.Read();
            var studid = liteDataReader[0];
            List<int> subjectindexes = new List<int>();
            command = new SQLiteCommand($"SELECT idSubject from `subjects` where idGroup={groupid}", Connection);
            liteDataReader = command.ExecuteReader();
            if (liteDataReader.HasRows)
            {
                while (liteDataReader.Read())
                {
                    subjectindexes.Add(Convert.ToInt32(liteDataReader[0]));
                }
            }
            liteDataReader.Close();

            foreach (var item in subjectindexes)
            {
                command = new SQLiteCommand($"insert into `marks` (idStudent,idSubject) values({studid},{item})", Connection);
                command.ExecuteNonQuery();
            }
            //////

            if (student.OlympiadsInd.Count != 0)
            {
                foreach (var item in student.OlympiadsInd.Keys)
                {
                    command = new SQLiteCommand($"insert or replace into `olympiads_MM_students`(idOlympiad,idStudent) " +
                        $"values({item},{studid})", Connection);
                    command.ExecuteNonQuery();
                }
            }
            if (student.OrdersInd.Count != 0)
            {
                foreach (var item in student.OrdersInd.Keys)
                {
                    command = new SQLiteCommand($"insert or replace into `orders_MM_students`(idOrder,idStudent) " +
                        $"values({item},{studid})", Connection);
                    command.ExecuteNonQuery();

                }
            }
            if (student.QualitiesInd.Count != 0)
            {
                foreach (var item in student.QualitiesInd.Keys)
                {
                    command = new SQLiteCommand($"insert or replace into `persqualities_MM_students`(idQuality,idStudent) " +
                        $"values({item},{studid})", Connection);
                    command.ExecuteNonQuery();

                }
            }
            if (student.EventsInd.Count != 0)
            {
                foreach (var item in student.EventsInd.Keys)
                {
                    command = new SQLiteCommand($"insert or replace into `events_MM_students`(idEvent,idStudent) " +
                        $"values({item},{studid})", Connection);
                    command.ExecuteNonQuery();
                }
            }

            Connection.Close();
        }
    }
}
