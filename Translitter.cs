using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCharacter
{
    class Translitter:Dictionary<string,string>
    {
        public static Translitter Initialize()
        {
            Translitter translitter = new Translitter();
            translitter.Add("А", "A");
            translitter.Add("Б", "B");
            translitter.Add("В", "V");
            translitter.Add("Г", "G");
            translitter.Add("Д", "D");
            translitter.Add("Е", "E");
            translitter.Add("Ё", "E");
            translitter.Add("Ж", "G");
            translitter.Add("З", "Z");
            translitter.Add("И", "I");
            translitter.Add("Й", "Y");
            translitter.Add("К", "K");
            translitter.Add("Л", "L");
            translitter.Add("М", "M");
            translitter.Add("Н", "N");
            translitter.Add("О", "O");
            translitter.Add("П", "P");
            translitter.Add("Р", "R");
            translitter.Add("С", "S");
            translitter.Add("Т", "T");
            translitter.Add("У", "U");
            translitter.Add("Ф", "F");
            translitter.Add("Х", "H");
            translitter.Add("Ц", "C");
            translitter.Add("Ч", "CH");
            translitter.Add("Ш", "SH");
            translitter.Add("Щ", "SH");
            translitter.Add("Ъ", "");
            translitter.Add("Ь", "`");
            translitter.Add("Ы", "I");
            translitter.Add("Э", "A");
            translitter.Add("Ю", "U");
            translitter.Add("Я", "YA");

            return translitter;
        }
    }
}
