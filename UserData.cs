using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentCharacter
{
    static class UserData
    {
       // public static string MyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string UserFolder = "users";
        public static string UserFile = "";
        public static string AutorizFile = "PublicPreferences";
        public static bool Remember=false;
        public static void CreateOrRead(User user)
        {
            UserFile = user.Login + ".sch";
            if (!File.Exists(Path.Combine( UserFolder + "\\" + UserFile)))
            {
               
                WriteUserData(user);
                ColorTheme.ThemeType = ThemeType.light;
            }
            else
            {
               ReadUserData(user);
            }
        }

        public static string InitializePublicData()
        {
            var data = "";
            if (File.Exists(Path.Combine( UserFolder + "\\" + AutorizFile)))
              data =  ReadPublicData();
            return data;
        }

        public static void WriteUserData(User user)
        {
            Directory.CreateDirectory(Path.Combine( UserFolder));
            var folderpath = Path.Combine( UserFolder);
            FileStream stream = new FileStream(Path.Combine(folderpath, UserFile),
                FileMode.OpenOrCreate, FileAccess.Write);
            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();
            cryptic.Key = Encoding.ASCII.GetBytes("e0n8ppd1");
            cryptic.IV = Encoding.ASCII.GetBytes("19172211");
            CryptoStream crStream = new CryptoStream(stream,
               cryptic.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] data = Encoding.ASCII.GetBytes(user.Login + "~" + user.Password + "~" + Convert.ToByte(ColorTheme.ThemeType));
            crStream.Write(data, 0, data.Length);
            crStream.Close();
            stream.Close();
        }

        public static void WritePublicData(string textData)
        {
            Directory.CreateDirectory(Path.Combine( UserFolder));
            var folderpath = Path.Combine( UserFolder);
            FileStream stream = new FileStream(Path.Combine(folderpath, AutorizFile),
                FileMode.OpenOrCreate, FileAccess.Write);
            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();
            cryptic.Key = Encoding.ASCII.GetBytes("e0n8ppd1");
            cryptic.IV = Encoding.ASCII.GetBytes("19172211");
            CryptoStream crStream = new CryptoStream(stream,
               cryptic.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] data = Encoding.ASCII.GetBytes(textData);
            crStream.Write(data, 0, data.Length);
            crStream.Close();
            stream.Close();
        }

        public static string ReadPublicData()
        {
            var folderpath = Path.Combine( UserFolder);
            FileStream stream = new FileStream(Path.Combine(folderpath, AutorizFile),
                          FileMode.Open, FileAccess.Read);
            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();
            cryptic.Key = Encoding.ASCII.GetBytes("e0n8ppd1");
            cryptic.IV = Encoding.ASCII.GetBytes("19172211");
            CryptoStream crStream = new CryptoStream(stream,
                cryptic.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(crStream);
            string data = reader.ReadToEnd();
            reader.Close();
            stream.Close();
            return data;
        }

        public static string ReadUserData(User user)
        {
            var folderpath = Path.Combine( UserFolder);
            FileStream stream = new FileStream(Path.Combine(folderpath, UserFile),
                          FileMode.Open, FileAccess.Read);
            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();
            cryptic.Key = Encoding.ASCII.GetBytes("e0n8ppd1");
            cryptic.IV = Encoding.ASCII.GetBytes("19172211");
            CryptoStream crStream = new CryptoStream(stream,
                cryptic.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(crStream);
            string data = reader.ReadToEnd();
            var theme = data.Split('~')[2];
            ColorTheme.ThemeType = (ThemeType)Convert.ToByte(theme);
            reader.Close();
            stream.Close();
            return data;
        }
    }
}
