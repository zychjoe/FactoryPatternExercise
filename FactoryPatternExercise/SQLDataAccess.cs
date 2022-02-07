using System;
namespace FactoryPatternExercise
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {
        }

        public void LoadData()
        {
            Console.WriteLine("I am reading data from a SQL database.");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database.");
        }
    }
}
