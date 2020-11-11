using System;
using System.Collections.Generic;
using Word = Microsoft.Office.Interop.Word;

namespace StudentCharacter
{
    public class TextProcessor
    {
        public static string Samplefile;
        public static string Newfile;
        public static object FileName;
        public static object Missing = Type.Missing;

        public static Dictionary<string, string> ReplaceDict = new Dictionary<string, string>();
        public static Word.Application WordApp;
        private static TextProcessor textProcessor;

        private TextProcessor(string sampleFile)
        {
            Samplefile = sampleFile;
            FileName = Samplefile;
        }

        public static TextProcessor GetInstance(string sampleFile)
        {
            if (textProcessor == null)
                textProcessor = new TextProcessor(sampleFile);
            return textProcessor;
        }

        public void FindReplace(string str_old, string str_new)
        {
            Word.Find find = WordApp.Selection.Find;
            find.Text = str_old;
            find.Replacement.Text = str_new;
            find.Execute(FindText: Type.Missing, MatchCase: false, MatchWholeWord: false, MatchWildcards: false,
                        MatchSoundsLike: Missing, MatchAllWordForms: false, Forward: true, Wrap: Word.WdFindWrap.wdFindContinue,
                        Format: false, ReplaceWith: Missing, Replace: Word.WdReplace.wdReplaceAll);
        }

        public void CreateCharacteristic(Student student, string directory)
        {
            WordApp = new Word.Application();
            WordApp.Documents.Open(ref FileName);

            FillReplaceDict(student);
            SaveCloseFile(student, directory);
        }
        private void SaveCloseFile(Student student, string directory)
        {
            string newfile = directory;
            WordApp.ActiveDocument.SaveAs(newfile);

            foreach (KeyValuePair<string, string> tagPair in ReplaceDict)
            {
                FindReplace(tagPair.Key, tagPair.Value);
            }

            WordApp.ActiveDocument.Close();
            WordApp.Quit();
        }
        private void FillReplaceDict(Student student)
        {
            ReplaceDict.Clear();
            ReplaceDict.Add("<ИМЯ_СТУДЕНТА>", student.Name);
            ReplaceDict.Add("<ФАМИЛИЯ_СТУДЕНТА>", student.SurName);
            ReplaceDict.Add("<ОТЧЕСТВО_СТУДЕНТА>", student.MidName);
            ReplaceDict.Add("<ДАТА_РОЖДЕНИЯ>", student.BirthDate.ToShortDateString());
            ReplaceDict.Add("<SPEC_CODE>", "");
            ReplaceDict.Add("<СПЕЦИАЛЬНОСТЬ>", student.Speciality);
           

            var ability = student.Abilities;
            
            ReplaceDict.Add("<СКЛОННОСТИ>", ability.ToLower());

            var qualities = "";
            foreach (var item in student.QualitiesInd.Values)
            {
                qualities += item + ", ";
            }

            ReplaceDict.Add("<ЛИЧНЫЕ_КАЧЕСТВА>", qualities);

            var achievments = "";
            foreach (var item in student.OlympiadsInd.Values)
            {
                achievments += item + ", ";
            }

            foreach (var item in student.EventsInd.Values)
            {
                achievments += item + ", ";
            }

            ReplaceDict.Add("<ДОСТИЖЕНИЯ>", achievments);
            ReplaceDict.Add("", "");
            ReplaceDict.Add("<ОТНОШЕНИЯ_С_ГРУППОЙ>", student.Relationship.ToLower());
            ReplaceDict.Add("<ОТНОШЕНИЕ_К_КРИТИКЕ>", student.Criticism.ToLower());
            ReplaceDict.Add("<ДИСЦИПЛИНА>", student.Discipline.ToLower());
            ReplaceDict.Add("<КЛАССНЫЙ_РУКОВОДИТЕЛЬ>", student.ClassTeacher);
            ReplaceDict.Add("<ГОД_ПОСТУПЛЕНИЯ>", student.StartYear.ToString());

            if (student.MidMark != 0)
            {
                var phrase = "По итогам " + student.Course + " курса имеет ";
                
                var mark = student.MidMark;
                if (mark > 4.0m && mark < 5.0m)
                    ReplaceDict.Add("<ОЦЕНКИ>", phrase+"хорошо и отлично");
                if (mark == 5.0m)
                    ReplaceDict.Add("<ОЦЕНКИ>", phrase+ "отлично");
                if (mark < 4.0m && mark > 3.0m)
                    ReplaceDict.Add("<ОЦЕНКИ>", phrase + "удовлетворительно и хорошо");
            }
            else
            {
                ReplaceDict.Add("<ОЦЕНКИ>", "");
            }

            var lates = student.Lates;
            var negative = "";
            if (lates == "Никогда")
                negative = "не";
            ReplaceDict.Add("<ОПОЗДАНИЯ>", lates + $" {negative} опаздывает и {negative} пропускает занятия.");
           
            ReplaceDict.Add("<ТЕКУЩАЯ_ДАТА>", DateTime.Today.ToShortDateString());
       
            if (student.ClassHead == 1)
                ReplaceDict.Add("<СТАРОСТА>", "Является старостой группы");
            else
                ReplaceDict.Add("<СТАРОСТА>", "");
            if (student.Commercial == 1)
                ReplaceDict.Add("<КОММЕРЧЕСКИЙ>", "коммерческой основе");
            else
                ReplaceDict.Add("<КОММЕРЧЕСКИЙ>", "бюджетной основе");
        }
    }
}
