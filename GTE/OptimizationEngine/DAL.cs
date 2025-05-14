using System.Data.SQLite;

namespace OptimizationEngine
{
    ///
    internal class DAL
    {
        internal DAL()
        {
            InitDatabase();
        }

        private void InitDatabase()
        {
            SQLiteConnection conn = new SQLiteConnection("data source = OptimizationEngine.db");
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
