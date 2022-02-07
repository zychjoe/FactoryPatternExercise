using System;
namespace FactoryPatternExercise
{


    public interface IDataAccess
    {
        public void LoadData();

        public void SaveData();
    }
}
