using System.Data.SqlClient;

namespace bucuriaDarului
{
    public sealed class SingletonDB
    {
        static readonly SingletonDB instance = new SingletonDB();
        static SqlConnection con = new SqlConnection(@"Data Source=B288QV2;Initial Catalog=shipITdb;User ID=sa;Password=password1");
        //string connectrion for remote
        //string strcnn = "Data Source=192.168.100.215,1433; Network Library=DBMSSOCN;Initial Catalog=YourDB; User ID=YourUserName;Password=YourPassword";

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SingletonDB()
        {
        }

        SingletonDB()
        {
        }

        public static SingletonDB Instance
        {
            get
            {
                return instance;
            }
        }
        public static void OpenDatabaseConnection()
        {
            con.Open();
        }

        public static void CloseDatabaseConnection()
        {
            con.Close();
        }

        public static SqlConnection GetDBConnection()
        {
            return con;
        }
    }

}
