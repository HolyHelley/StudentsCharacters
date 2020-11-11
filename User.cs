using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCharacter
{

    public class User
    {
        public long UserId;
        public string Login;
        public string Password;
        public Dictionary<long, string> GroupesList = new Dictionary<long, string>();
        public long CurrentGroupe;

        public User(long userid, string login, string password, List<string> tables, List<long> indexes)
        {
            UserId = userid;
            Login = login;
            Password = password;
            for (int i = 0; i < tables.Count; i++)
            {
                GroupesList.Add(indexes[i], tables[i]);
            }
            CurrentGroupe = GroupesList.ElementAt(0).Key;
        }
        public User(long userid, string login, string password)
        {
            Login = login;
            UserId = userid;
            Password = password;
        }
        public void SetGroups(long index, string table)
        {
            GroupesList.Add(index, table);
            CurrentGroupe = GroupesList.ElementAt(0).Key;
        }
    }
}
