using System;
using MySql.Data.MySqlClient;
using HairSalon;

namespace HairSalon.Models
{
  public class DB
  {
    public static MySqlConnection Connection()
    {
    //   MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;database=sharon_lee;uid=root;pwd=epicodus;");
      return conn;
    }
  }
}