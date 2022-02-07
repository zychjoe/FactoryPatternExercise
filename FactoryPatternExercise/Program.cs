using System;

namespace FactoryPatternExercise
{
    class Program
    {



        /*
Lastly in the Main()
Ask the user what database they want to use: a List, SQL, or Mongo
Store their response in a variable
Call your factory method and pass in what the user types and store what your factory method returns in an IDataAccess variable
Call the LoadData and SaveData methods of the IDataAccess variable
Run the program a few times using the different types.

         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         */





        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use? List, SQL, or Mongo?");
            string database = Console.ReadLine().ToLower();
            IDataAccess choice = DataAccessFactory.GetDataAccessType(database);
            choice.LoadData();
            choice.SaveData();
        }
    }
}
