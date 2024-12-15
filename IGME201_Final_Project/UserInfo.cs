using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

public class UserInfo
{

	public UserInfo()
	{
        static Dictionary<string, string[][]> users;
    }

	private void LoadUsers()
	{
        StreamReader sr = new StreamReader(@"..\..\..\Users.txt");
        string line = sr.ReadLine();
        //Split the date into parts, and call them In variables.
        while (line != null)
        {
            string[] user = line.Split(",");
            string username = user[0];
            string password = user.Length > 1 ? user[1] : null;
            string[] cardInfo = user.Length > 2 ? user[2].Split(":") : null;
            string[][] array = new string[][] { 
                array[0] = password;
                 if (cardInfo != null && cardInfo.Length > 4)
                 {
                     array[1] = cardInfo;
                 }
                 line = sr.ReadLine();
            nodes.Add(username, array);
        }
        sr.Close();
     }

    }
    private void saveUsers()
    {
    StreamWriter sw = new StreamWriter(@"..\..\..\users.txt", false);
    foreach (KeyValuePair<string, string[][]> User in users)
    {
        // do something with entry.Value or entry.Key
        sw.WriteLine($"{user.Key},{user.Value[0][0]},{user.Value[1][0]}:{user.Value[1][1]}:{user.Value[1][2]}:{user.Value[1][3]}");
    }
    sw.Close();
}
}
