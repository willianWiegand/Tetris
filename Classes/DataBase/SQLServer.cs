using System;
using System.Data;
using System.Data.SqlClient;

namespace Tetris.Classes.DataBase {
  public class SQLServer {
    public string StringConn { get; set; }
    public SqlConnection ConnDB { get; set; }

    public SQLServer() {
      try {
        StringConn = "Integrated Security=SSPI;Persist Security Info=False;User ID=LAPTOP-B6H8I2CI\\Wiegand;Initial Catalog=Ranking_Tetris;Data Source=LAPTOP-B6H8I2CI";
        ConnDB = new SqlConnection(StringConn);
        ConnDB.Open();
      }
      catch (Exception ex) {

        throw new Exception(ex.Message);
      }
    }

    public string SQLCommand(string SQL) {
      try {
        var myCommand = new SqlCommand(SQL, ConnDB);
        myCommand.CommandTimeout = 0;
        var myReader = myCommand.ExecuteReader();

        return "";
      }
      catch (Exception ex) {

        throw new Exception(ex.Message);
      }
    }

    public DataTable SQLQuery(string SQL) {
      DataTable dt = new DataTable();
      try {
        var myCommand = new SqlCommand(SQL, ConnDB);
        myCommand.CommandTimeout = 0;
        var myReader = myCommand.ExecuteReader();

        dt.Load(myReader);

        return dt;
      }
      catch (Exception ex) {

        throw new Exception(ex.Message);
      }
    }

    public void SQLClose() {
      ConnDB.Close();
    }
  }
}
