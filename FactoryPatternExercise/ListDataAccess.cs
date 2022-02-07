using System;
namespace FactoryPatternExercise
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {
        }

        public void LoadData()
        {
            Console.WriteLine("I am reading data from a List database.");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List database.");
        }
    }
}
