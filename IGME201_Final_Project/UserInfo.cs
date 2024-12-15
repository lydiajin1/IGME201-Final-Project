using System;

public class UserInfo
{
	public UserInfo()
	{
        static Dictionary<string, string[][]> users;
    }

	private void loadUsers()
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

    }
}
