using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGME201_Final_Project
{
    public class UsersInfo
    {
       public Dictionary<string, string[][]> users;
        public UsersInfo()
        {
             users = new Dictionary<string, string[][]>();
        }

        public void LoadUsers()
        {
            FileStream aFile = new FileStream(@"..\..\..\Users.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(aFile);
            string line; while ((line = sr.ReadLine()) != null)
            {
                string[] user = line.Split(',');
                string username = user[0]; 
                string password = user.Length > 1 ? user[1] : null;
                string cardInfo = user.Length > 2 ? user[2] : null; 
                string[][] info = new string[2][];
                info[0] = new string[] { password };
                if (cardInfo != null && cardInfo.Split(':').Length > 4)
                {
                    info[1] = cardInfo.Split(':'); 
                }
                else
                {
                    info[1] = new string[0]; // Placeholder if cardInfo is not valid
                }
                                           
                                             users.Add(username, info);  }
                }


        public void SaveUsers()
        {
            StreamWriter sw = new StreamWriter(@"..\..\..\users.txt", false);
            foreach (KeyValuePair<string, string[][]> userInfo in users)
            {
                // do something with entry.Value or entry.Key
                sw.WriteLine($"{userInfo.Key},{userInfo.Value[0][0]},{userInfo.Value[1][0]}:{userInfo.Value[1][1]}:{userInfo.Value[1][2]}:{userInfo.Value[1][3]}");
            }
            sw.Close();
        }
    }
}