using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Repository;
using System;

namespace Design_Patterns_Assignment
{
    internal class Repository1
    {
        internal static void Run()
        {
            IDataRepository _repository = new DataRepository();

            _repository.Load();
            _repository.Save("Hossein");
            _repository.Save("Webbutvecklare");
            _repository.Load();




            //-------------------------------------------------------------
            //// Refactor this code so that it uses the Repository Pattern
            //Console.WriteLine("Repository");
            //var data = SimulatedDatabase.Load("Dataset A");
            //var customer = SimulatedDatabase.Load("From Table Customer Where Name==Steve"); // this is a search
            //var animal = SimulatedDatabase.Load("From Table Animal Where Owner==Steve"); // this is a search
            //SimulatedDatabase.Save(data);
            //SimulatedDatabase.Save(customer);
            //SimulatedDatabase.Save(animal);
            //Console.WriteLine();
        }
    }
}