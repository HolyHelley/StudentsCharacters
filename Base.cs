using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SQLite;
using Microsoft.Office.Interop.Excel;

namespace StudentCharacter
{
    public partial class Base : Form
    {
        public static SQLiteConnection Connection;
        public static string sampleFile = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "samples\\sample.docx");
        public static bool isConnected = false;
        private Custom CustomForm;
        private Subjects Subjects;
        private string CurrentTable;
        private string UserName;
        private User User;
        public TableType TableType;
        public Base()
        {
            InitializeComponent();
        }
        public Base(User user)
        {
            InitializeComponent();
            User = user;
            CurrentTable = User.GroupesList[User.CurrentGroupe];
            UserName = User.Login;
        }

        public void LoadTable(string find, TableType tableType)
        {
            Connection = Sqlite.SetConnection();
            System.Data.DataTable dataTable = new System.Data.DataTable();
            string command = "";
            //если выбрана таблица характеристик
            if (TableType == TableType.Characters)
            {
                //выбираем все поля из таблицы студентов и задаем им синонимы
                command = "select " +
                 "idStudent as ИД," +
                 " Name as Имя," +
                 " SurName as Фамилия," +
                 " MidName as Отчество," +
                 "Gender as Пол," +
                 "BirthDate as 'Дата рождения'," +
                 "Course as Курс," +
                 "GoodAbilities  as Склонности," +
                 "Criticism  as 'Отношение к критике'," +
                 "Relationship  as 'Отношения с группой'," +
                 "Lates  as Опоздания," +
                 "Discipline  as Дисциплина," +
                 "ClassHead  as Староста," +
                 "`students`.idGroup  as 'ИД Группы'," +
                 "GroupName  as Группа," +
                 "Commercial  as Коммерческий" +
                 " from `students` left join `group` on `students`.idGroup=`group`.idGroup where  `students`.idGroup=" + User.CurrentGroupe + " " + find;
                SQLiteDataAdapter mySqlDataAdapter = new SQLiteDataAdapter(command, Connection);
                //заполняем таблицу данных
                mySqlDataAdapter.Fill(dataTable);
                //устанавливаем источник данных
                studentsTable.DataSource = dataTable;
                Connection.Close();
                //ставим таблицу в режим только для чтения
                studentsTable.ReadOnly = true;
            }
            //если выбрана таблица оценок
            if (TableType == TableType.Marks)
            {
                //создаем выборку из таблиц оценок и студентов
                command = "select `students`.idStudent as ИД, `students`.Name as Имя," +
                    "`students`.SurName as Фамилия," +
                    " SubjectName as Предмет," +
                    " Mark as Оценка," +
                    $" Pass as Зачет from `marks` join `students` using(idStudent) join `subjects` using(idSubject) where `students`.idGroup={User.CurrentGroupe} {find} order by SubjectName";
                SQLiteDataAdapter mySqlDataAdapter = new SQLiteDataAdapter(command, Connection);
                mySqlDataAdapter.Fill(dataTable);
                studentsTable.DataSource = dataTable;
                Connection.Close();
                studentsTable.ReadOnly = false;
                //оставляем для редактирования поля оценок и зачетов
                studentsTable.Columns[0].ReadOnly = true;
                studentsTable.Columns[1].ReadOnly = true;
                studentsTable.Columns[2].ReadOnly = true;
                studentsTable.Columns[3].ReadOnly = true;
            }
            if (TableType == TableType.AverageMarks)
            {
                command = "select `students`.idStudent as ИД, `students`.Name as Имя," +
                    "`students`.SurName as Фамилия," +
                    "  avg(Mark) as Оценка" +
                    $"  from `marks` inner join `students` using(idStudent) where `students`.idGroup={User.CurrentGroupe} {find} group by `students`.idStudent";
                SQLiteDataAdapter mySqlDataAdapter = new SQLiteDataAdapter(command, Connection);
                mySqlDataAdapter.Fill(dataTable);
                studentsTable.DataSource = dataTable;
                Connection.Close();
                studentsTable.ReadOnly = true;
            }

        }

        private void btnLoadToCustom_Click(object sender, EventArgs e)
        {

            if (studentsTable.SelectedRows.Count != 0)

            {
                if (studentsTable.SelectedRows.Count == 1)
                {
                    Student student = new Student(studentsTable.SelectedRows[0]);
                    DataTransistor.DataToConstruct(CustomForm, student);
                    MessageBox.Show("Данные выгружены");
                }
                else
                {
                    MessageBox.Show("Выбрано больше одной строки");
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана");
            }
        }

        private void Base_Load(object sender, EventArgs e)
        {
            pnlTable.Size = new Size(pnlTable.Size.Width + pnlSearch.Width + 20, pnlTable.Size.Height);
            dtYear.Format = DateTimePickerFormat.Custom;
            dtYearLast.Format = DateTimePickerFormat.Custom;

            dtYear.CustomFormat = "yyyy";
            dtYearLast.CustomFormat = "yyyy";
            dtYear.ShowUpDown = true;
            dtYearLast.ShowUpDown = true;

            cbGender.SelectedIndex = 0;
            Connection = Sqlite.SetConnection();
            CustomForm = this.Owner as Custom;
            lblStatus.Text = "...";
            lblTableUser.Text = $"Пользователь: {UserName} Таблица: {CurrentTable}";
            TableType = TableType.Characters;
            foreach (var item in User.GroupesList.Values)
            {
                ToolStripMenuItem dditem = (ToolStripMenuItem)MenuGroups.DropDownItems.Add(item);
                dditem.CheckOnClick = true;
                dditem.Click += Dditem_Click;
                if (dditem.Text == User.GroupesList[User.CurrentGroupe])
                {
                    dditem.Checked = true;
                }
            }

            if (TableType == TableType.Characters)
            {

                ContextSelectAll.Visible = true;
                ContextDelete.Visible = true;
            }
            if (TableType == TableType.Marks)
            {

                ContextSelectAll.Visible = false;
                ContextDelete.Visible = false;
                pnlMarksFind.Visible = true;
            }

            LoadTable("", TableType);

            Connection.Open();

            SQLiteCommand liteCommand = new SQLiteCommand("select SubjectName from `subjects` where idGroup=" + User.CurrentGroupe, Connection);
            SQLiteDataReader liteDataReader = liteCommand.ExecuteReader();
            while (liteDataReader.Read())
            {
                cbSubject.Items.Add(liteDataReader[0].ToString());
            }
            if (cbSubject.Items.Count != 0)
                cbSubject.SelectedIndex = 0;
            liteDataReader.Close();
            Connection.Close();
        }

        private void Dditem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            long groupInd = 0;
            foreach (var item in User.GroupesList)
            {
                if (item.Value == menuItem.Text)
                {
                    groupInd = item.Key;
                }

            }

            User.CurrentGroupe = groupInd;
            foreach (ToolStripMenuItem item in MenuGroups.DropDownItems)
            {
                if (item != menuItem)
                {
                    item.Checked = false;
                }
                else
                {
                    item.Checked = true;
                }
            }
            lblTableUser.Text = "Пользователь: " + User.Login + " Текущая группа: " + menuItem.Text;
            LoadTable("", TableType);

            Connection.Open();
            SQLiteCommand liteCommand = new SQLiteCommand("select SubjectName from `subjects` where idGroup=" + User.CurrentGroupe, Connection);
            SQLiteDataReader liteDataReader = liteCommand.ExecuteReader();
            cbSubject.Items.Clear();
            while (liteDataReader.Read())
            {
                cbSubject.Items.Add(liteDataReader[0].ToString());
            }
            if (cbSubject.Items.Count != 0)
                cbSubject.SelectedIndex = 0;
            Connection.Close();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Connection = Sqlite.SetConnection();
            SQLiteCommand mySqlCommand = new SQLiteCommand();
            System.Data.DataTable dataTable = new System.Data.DataTable();
            var fam = "";
            if (tbName.Text != "")
                fam = tbName.Text[0].ToString().ToUpper() + tbName.Text.Substring(1).ToLower();
            var year = dtYear.Value.Year;
            var lastyear = dtYearLast.Value.Year;
            var gender = cbGender.Text;
            var pass = chbPassSearch.Checked;
            var mark = numMark.Value;
            var subject = cbSubject.SelectedItem.ToString();

            var familySearch = "";
            var yearSearch = "";
            var genderSearch = "";
            var subjectSearch = "";
            var markSearch = "";
            var passSearch = "";


            if (chbFamily.Checked)
            {
                familySearch = $" and `Surname` like '%{fam}%' ";
            }
            if (chbBirthDate.Checked)
            {
                yearSearch += $" and `BirthDate` between '{year}%-%-%' and '{lastyear}-12-31'";
            }

            if (chbGender.Checked)
            {
                genderSearch += $" and `Gender`='{gender}' ";
            }

            if (TableType == TableType.Marks)
            {
                if (chbSubject.Checked)
                {
                    subjectSearch += $" and `SubjectName`='{subject}' ";
                }
                if (chbMark.Checked)
                {
                    markSearch += $" and `Mark`={mark} ";
                }
                if (chbPass.Checked)
                {
                    passSearch += $" and `Pass`={pass} ";
                }
            }

            string finder = familySearch + yearSearch + genderSearch + subjectSearch + markSearch + passSearch;
            LoadTable(finder, TableType);
            Connection.Close();
        }

        private void btnCreateAll_Click(object sender, EventArgs e)
        {
            if (studentsTable.SelectedRows.Count != 0)
            {
                List<Student> students = new List<Student>();

                foreach (DataGridViewRow dataGridViewRow in studentsTable.SelectedRows)
                {
                    Student student = new Student(dataGridViewRow);
                    students.Add(student);
                }

                createMultipleCharAsync(students);
            }
            else
            {
                MessageBox.Show("Строки не выбраны");
            }
        }

        private async void createMultipleCharAsync(List<Student> students)
        {
            TextProcessor textProcessor = TextProcessor.GetInstance(sampleFile);
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedPath = folderBrowserDialog.SelectedPath;
                await Task.Run(() =>
                {
                    lblStatus.Invoke(new System.Action(() =>
                    {
                        lblStatus.Text = "Создание характеристик...";
                    }));

                    foreach (Student student1 in students)
                    {
                        textProcessor.CreateCharacteristic(student1, selectedPath + $"\\{student1.Name}_{student1.SurName}_" +
                            $"{student1.Group}_Характеристика");
                    }

                    lblTableUser.Invoke(new System.Action(() =>
                    {
                        lblStatus.Text = "Готово";
                    }));

                    var messageBox = MessageBox.Show("Файлы сохранены: " + selectedPath, "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

                });
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < studentsTable.Rows.Count; i++)
            //{
            //    studentsTable.Rows[i].Selected = true;
            //}
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            tbName.Text = "";

            Connection.Open();
            LoadTable("", TableType);
            Connection.Close();
        }

        private void Base_Paint(object sender, PaintEventArgs e)
        {
            ColorTheme.ChangeBack(e, Width, Height);
        }

        private void OpenSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlSearch.Visible = true;
            llOpenSearch.Visible = false;
            pnlTable.Size = new Size(pnlTable.Width - pnlSearch.Width - 20, pnlTable.Height);
        }

        private void CloseSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llOpenSearch.Visible = true;

            pnlSearch.Visible = false;
            pnlTable.Size = new Size(pnlTable.Width + pnlSearch.Width + 20, pnlTable.Height);
        }

        private void ContextSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < studentsTable.Rows.Count; i++)
            {
                studentsTable.Rows[i].Selected = true;
            }
        }

        private void ContextDelete_Click(object sender, EventArgs e)
        {
            if (studentsTable.SelectedRows.Count != 0)
            {
                Connection = Sqlite.SetConnection();
                Connection.Open();
                SQLiteCommand command = new SQLiteCommand("PRAGMA foreign_keys=ON", Connection);
                command.ExecuteNonQuery();

                for (int i = 0; i < studentsTable.SelectedRows.Count; i++)
                {
                    var studId = studentsTable.SelectedRows[i].Cells["ИД"].Value;
                    command = new SQLiteCommand($"delete from `students` where idStudent={studId}", Connection);
                    command.ExecuteNonQuery();
                }
                Connection.Close();
                LoadTable("", TableType);
            }
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            if (TableType == TableType.Characters)
            {
                TableType = TableType.Marks;
                btnSwitch.Text = btnSwitch.Text.Replace("Оценки", "Характеристики");
                LoadTable("", TableType);
                ContextDelete.Visible = false;
                ContextSelectAll.Visible = false;
                ContextView.Visible = true;
                pnlMarksFind.Visible = true;
                studentsTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
            else if (TableType == TableType.Marks || TableType == TableType.AverageMarks)
            {
                TableType = TableType.Characters;
                btnSwitch.Text = btnSwitch.Text.Replace("Характеристики", "Оценки");
                LoadTable("", TableType);
                ContextDelete.Visible = true;
                ContextSelectAll.Visible = true;
                ContextView.Visible = false;
                pnlMarksFind.Visible = false;
                studentsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void MenuSubjects_Click(object sender, EventArgs e)
        {
            if (Subjects == null || !Subjects.Visible)
            {
                Subjects = new Subjects(User);
                Subjects.Owner = this;
                Subjects.Show();

            }
            else
            {
                Subjects.Focus();
            }
        }

        private void studentsTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentsTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (TableType == TableType.Marks)
            {
                Connection.Open();
                var row = studentsTable.Rows[e.RowIndex];
                bool pass = (bool)row.Cells["Зачет"].Value;
                long mark = 0;
                if (row.Cells["Оценка"].Value != DBNull.Value)
                {
                    mark = (long)row.Cells["Оценка"].Value;
                }
                var studid = row.Cells["ИД"].Value;
                var subject = row.Cells["Предмет"].Value;

                SQLiteCommand liteCommand = new SQLiteCommand($"select idSubject from `marks` join `subjects` using(idSubject) where `marks`.idStudent={studid} and SubjectName='{subject}'", Connection);
                SQLiteDataReader liteDataReader = liteCommand.ExecuteReader();
                liteDataReader.Read();

                var idSubject = liteDataReader[0];
                liteDataReader.Close();
                if (mark == 0)
                    liteCommand = new SQLiteCommand($"update `marks` set Pass={pass} where idStudent={studid} and idSubject={idSubject} ", Connection);
                else
                    liteCommand = new SQLiteCommand($"update `marks` set Mark={mark}, Pass={pass} where idStudent={studid} and idSubject={idSubject} ", Connection);
                liteCommand.ExecuteNonQuery();
                Connection.Close();
            }
        }

        private void MenuExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FileName = "students_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss");
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                for (int j = 0; j < studentsTable.ColumnCount; j++)
                {
                    (ExcelApp.Cells[1, j + 1] as Range).Font.Bold = true;
                    ExcelApp.Cells[1, j + 1] = studentsTable.Columns[j].HeaderText;
                }
                for (int i = 0; i < studentsTable.Rows.Count; i++)
                {
                    for (int j = 0; j < studentsTable.ColumnCount; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = studentsTable.Rows[i].Cells[j].Value;
                    }
                }
                var range = ExcelWorkSheet.Range[ExcelApp.Cells[1, 1], ExcelApp.Cells[studentsTable.Rows.Count + 1, studentsTable.ColumnCount]];
                Microsoft.Office.Interop.Excel.Borders borders = range.Borders;
                borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
                borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
                borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                borders.Color = Color.Black;

                ExcelApp.Visible = false;
                ExcelApp.UserControl = true;
                ExcelWorkBook.SaveAs(saveFileDialog.FileName);
            }
            ExcelApp.Quit();
            LoadTable("", TableType);
        }

        private void MenuImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            //saveFileDialog.FileName = "students_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss");
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application(); //Excel
            Microsoft.Office.Interop.Excel.Workbook xlWB; //рабочая книга              
            Microsoft.Office.Interop.Excel.Worksheet xlSht; //лист Excel   
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                xlWB = xlApp.Workbooks.Open(openFileDialog.FileName); //название файла Excel                                             
                xlSht = xlWB.Worksheets["Лист1"]; //название листа или 1-й лист в книге xlSht = xlWB.Worksheets[1];
                int iLastRow = xlSht.Cells[xlSht.Rows.Count, "A"].End[Microsoft.Office.Interop.Excel.XlDirection.xlUp].Row;  //последняя заполненная строка в столбце А            
                var arrData = (object[,])xlSht.Range["A1:P" + iLastRow].Value; //берём данные с листа Excel
                                                                               //xlApp.Visible = true; //отображаем Excel     
                xlWB.Close(false); //закрываем книгу, изменения не сохраняем
                xlApp.Quit(); //закрываем Excel

                int RowsCount = arrData.GetUpperBound(0);
                int ColumnsCount = arrData.GetUpperBound(1);

                Connection.Open();
                SQLiteCommand liteCommand;
                int i, j;
                List<object> list = new List<object>();
                for (i = 2; i <= RowsCount; i++)
                {
                    for (j = 1; j <= ColumnsCount; j++)
                    {
                        list.Add(arrData[i, j]);
                    }

                    Student student = new Student(list);
                    DataTransistor.ConstructToData(student, Connection);


                    list.Clear();
                }

                Connection.Close();

            }
        }

        private void ContextView_Click(object sender, EventArgs e)
        {
            if (TableType == TableType.Marks)
            {
                TableType = TableType.AverageMarks;
                LoadTable("", TableType);
            }
           else if(TableType == TableType.AverageMarks)
            {
                TableType = TableType.Marks;
                LoadTable("", TableType);
            }
        }
    }
}
