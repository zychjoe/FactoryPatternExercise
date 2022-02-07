using System;
namespace FactoryPatternExercise
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
        }

        public void LoadData()
        {
            Console.WriteLine("I am reading data from a Mongo database.");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo database.");
        }
    }
}
