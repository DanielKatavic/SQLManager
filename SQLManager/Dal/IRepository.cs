using SQLManager.Models;
using System.Data;

namespace SQLManager.Dal
{
    internal interface IRepository
    {
        void LogIn(string server, string username, string password);
        IEnumerable<Database> GetDatabases();
        dynamic ExecuteQuery(Database database, string query);
    }
}
