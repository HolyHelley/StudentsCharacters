using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using MySql.Data.MySqlClient;
using System.Data.SQLite;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Text;

namespace StudentCharacter
{
    public partial class Custom : Form
    {
        public static SQLiteConnection mysqlConnection;
        private static TextProcessor textProcessor;
        public static List<Control> neededControls = new List<Control>();
        public static bool ActChangeSize = false;
        public static bool QualChangeSize = false;
        public static string sampleFile = Path.Combine(Application.StartupPath, "samples\\sample.docx");
        public static Base baseForm;
        public static Settings SettingsForm;
        public static bool isConnected = false;
        public static User User;
        public static Autorization Autorization;
        private static Size resolution;
        private static Translitter transliter;

        public Dictionary<long, string> OlympiadsInd = new Dictionary<long, string>();
        public Dictionary<long, string> EventsInd = new Dictionary<long, string>();
        public Dictionary<long, string> OrdersInd = new Dictionary<long, string>();
        public Dictionary<long, string> QualitiesInd = new Dictionary<long, string>();

        public Custom()
        {
            InitializeComponent();
        }
        public Custom(User user, Autorization autorization)
        {
            InitializeComponent();
            User = user;
            Autorization = autorization;
        }
        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            List<char> charlist = new List<char>();
            
            bool checkControls = true; //флаг для проверки полей ввода
            Student student = new Student(this); //создаем новый объект студента
            //перебор полей ввода на правильность введенных данных
            foreach (Control control in neededControls)
            {
                if (control.Text == "")//если поле пустое
                {
                    control.BackColor = Color.Orange;//поле меняет цвет
                    checkControls = false;//проверка провалена
                    break;
                }
                foreach (var item in control.Text)
                {
                    var s = "";
                    //если поле содержит символ не из русского алфавита
                    if (!transliter.TryGetValue(item.ToString().ToUpperInvariant(),out s))
                    {
                        control.BackColor = Color.Orange;
                        checkControls = false;
                        break;
                    }
                }
            }
            if (checkControls)
            {
                //создать характеристику
                CreateCharAsync(student);
            }
            else
            {
                MessageBox.Show("Введены неверные данные","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private async void CreateCharAsync(Student student)
        {
            SaveFileDialog saveFile = new SaveFileDialog();//
            saveFile.Title = "Сохранить файл";
            saveFile.Filter = "Файл формата DOCX| *.docx";
            saveFile.FileName = $"{student.Name}_{student.SurName}_" +
                $"{student.Group}_Характеристика";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                await Task.Run(() =>
                {
                    lblStatus.Invoke(new Action(() =>
                    {
                        lblStatus.Text = "Создание характеристики...";
                        lblStatus.Visible = true;
                    }));

                    textProcessor.CreateCharacteristic(student, saveFile.FileName);

                    lblStatus.Invoke(new Action(() =>
                    {
                        lblStatus.Text = "Готово";
                    }));
                    MessageBox.Show("Файл сохранен: " + saveFile.FileName);
                });
            }
        }

        private void Custom_Load(object sender, EventArgs e)
        {
            InitControls();
            transliter = Translitter.Initialize();
            var x = Size.Width;
            var y = Size.Height;

            resolution = Screen.PrimaryScreen.Bounds.Size;
            resolution = Screen.GetWorkingArea(new Point(0, 0)).Size;

            MaximizedBounds = new Rectangle(0, 0, x, resolution.Height);
            textProcessor = TextProcessor.GetInstance(sampleFile);
            mysqlConnection = Sqlite.SetConnection();
            lblStatus.Text = "...";
            lblUser.Text = $"Пользователь: {User.Login}";
            lblTable.Text = $"Текущая таблица: {User.GroupesList[User.CurrentGroupe]}";
            foreach (var item in User.GroupesList.Values)
            {
                cbGroupe.Items.Add(item);
            }

            cbGroupe.SelectedIndex = 0;
            RefreshUserGroups();

            UserData.CreateOrRead(User);
            ColorTheme.SetTheme(this);
        }

        public void RefreshUserGroups()
        {
            CurrentTable.DropDownItems.Clear();
            foreach (var item in User.GroupesList.Values)
            {
                ToolStripMenuItem toolitem = (ToolStripMenuItem)CurrentTable.DropDownItems.Add(item);
                toolitem.Click += Toolitem_Click;
                toolitem.CheckOnClick = true;
                if (toolitem.Text == User.GroupesList[User.CurrentGroupe])
                {
                    toolitem.Checked = true;
                }
            }
            cbGroupe.Items.Clear();
            foreach (var item in User.GroupesList.Values)
            {
                cbGroupe.Items.Add(item);
            }
            cbGroupe.SelectedIndex = 0;
        }

        private void Toolitem_Click(object sender, EventArgs e)
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
            foreach (ToolStripMenuItem item in CurrentTable.DropDownItems)
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
            lblTable.Text = "Текущая таблица: " + menuItem.Text;
        }

        private void InitControls()
        {
            cbAbilities.SelectedIndex = 0;
            cbCourse.SelectedIndex = 0;
            cbRelationship.SelectedIndex = 0;
            cbLates.SelectedIndex = 0;
            cbDiscipline.SelectedIndex = 0;
            cbCriticism.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
            numMidMark.Value = 0.0m;

            neededControls.Add(tbStudName);
            neededControls.Add(tbMidName);
            neededControls.Add(tbStudSurname);
        }

        private void btnLoadFromBase_Click(object sender, EventArgs e)
        {
            if (baseForm == null || !baseForm.Visible)
            {
                baseForm = new Base(User);
                baseForm.Owner = this;
                baseForm.Show();
            }
            else
            {
                baseForm.Focus();
            }
        }

                private void btnAddToBase_Click(object sender, EventArgs e)
        {
            bool checkControls = true;
            foreach (Control control in neededControls)
            {
                if (control.Text == "" || control.Text == " .")
                {
                    control.BackColor = Color.Red;
                    checkControls = false;
                }
            }

            if (checkControls)
            {
                TransferData();
            }
            else
            {
                MessageBox.Show("Не все данные заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TransferData()
        {
            mysqlConnection = Sqlite.SetConnection();
            Custom customForm = this;
            Student student = new Student(this);
            lblStatus.Text = "Отправка данных...";
            DataTransistor.ConstructToData(student, mysqlConnection);
            lblStatus.Text = "Готово";
            MessageBox.Show("Данные отправлены");
        }

        private void tbGroupCode_TextChanged(object sender, EventArgs e)
        {
            Control textBox = (Control)sender;
            textBox.BackColor = Color.White;
        }


        private void Custom_Paint(object sender, PaintEventArgs e)
        {
            if(Owner.Visible)
                Owner.Hide();
            ColorTheme.ChangeBack(e, Width, Height);
        }

        private void Custom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ChangeUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorization.Show();
        }

        private void LightTheme_click(object sender, EventArgs e)
        {
            ColorTheme.ThemeType = ThemeType.light;
            ColorTheme.SetTheme(this);
            UserData.WriteUserData(User);
        }

        private void Dark_Click(object sender, EventArgs e)
        {
            ColorTheme.ThemeType = ThemeType.dark;
            ColorTheme.SetTheme(this);
            UserData.WriteUserData(User);
        }


        private void CurrentTable_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            long ind = 0;
            foreach (var item in User.GroupesList)
            {
                if (item.Value == menuItem.Text)
                    ind = item.Key;
            }
            User.CurrentGroupe = ind;
        }

        private void MenuControl_Click(object sender, EventArgs e)
        {
            if (SettingsForm == null || !SettingsForm.Visible)
            {
                SettingsForm = new Settings(User);
                SettingsForm.Owner = this;
                SettingsForm.Show();
            }
            else
            {
                SettingsForm.Focus();
            }
        }

        private void btnGroupe_Click(object sender, EventArgs e)
        {
            if (SettingsForm == null || !SettingsForm.Visible)
            {
                SettingsForm = new Settings(User);
                SettingsForm.Owner = this;
                SettingsForm.Show();
            }
            else
            {
                SettingsForm.Focus();
            }
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "btnEvents")
            {
                AdvancedInfo personal = new AdvancedInfo(PersonalInfo.Events);
                personal.Owner = this;
                personal.Show();
            }
            if (button.Name == "btnPersonalQuality")
            {
                AdvancedInfo personal = new AdvancedInfo(PersonalInfo.Qualities);
                personal.Owner = this;
                personal.Show();
            }
            if (button.Name == "btnOrders")
            {
                AdvancedInfo personal = new AdvancedInfo(PersonalInfo.Orders);
                personal.Owner = this;
                personal.Show();
            }
            if (button.Name == "btnOlympiads")
            {
                AdvancedInfo personal = new AdvancedInfo(PersonalInfo.Olympiads);
                personal.Owner = this;
                personal.Show();
            }
        }
        private void Custom_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                if (baseForm == null || !baseForm.Visible)
                {
                    baseForm = new Base(User);
                    baseForm.Owner = this;
                    baseForm.Show();
                }
                else
                {
                    baseForm.Focus();
                }
                baseForm.Location = new Point(Size.Width, 0);
                baseForm.Size = new Size(resolution.Width - Width, baseForm.Size.Height);
            }
            if (WindowState == FormWindowState.Normal)
            {
                for (int i = 0; i < OwnedForms.Length; i++)
                {
                    OwnedForms[i].Close();

                }
            }
        }

    }
}
