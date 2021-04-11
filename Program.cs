using System;

namespace VariablesExerciseTC2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string petName = "Ralph";

            int petAge = 10;

            char petNickName = 'R';

            bool petHasLegs = true;

            double yearBorn = 2008;

            decimal petWeight = 25.7m;

            Console.WriteLine($"My dog's name is {petName}, he's {petAge} years old.");
            Console.WriteLine($"{petName} is called {petNickName} most times and its {petHasLegs} he has four legs.");
            Console.WriteLine($"{petName} was born in {yearBorn} and weighs {petWeight} pounds.");
          

        }
    }
}
