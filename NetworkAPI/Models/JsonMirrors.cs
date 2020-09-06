using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkAPI
{
    public class JsonMirrors
    {
        public class User
        {
            public struct NameAndPassword
            {
                public string UserName { get; set; }
                public string UserPassword { get; set; }
            }

            public static NameAndPassword FormatNameAndPassword(string name, string password)
            {
                return new NameAndPassword { UserName = name, UserPassword = password };
            }

            public static NameAndPassword FormatNameAndPassword(NetworkAPI.User user)
            {
                return new NameAndPassword { UserName = user._name, UserPassword = user._password };
            }
        }

        public class WorkOut
        {
            public struct WorkOutGoal
            {
                public string WorkOutName { get; set; }
                
                public ExerciseGoal Exercise_1 { get; set; }
                public ExerciseGoal Exercise_2 { get; set; }
                public ExerciseGoal Exercise_3 { get; set; }
            }

            public struct ExerciseGoal
            {
                public string Name { get; set; }
                public int Reps { get; set; }

                public int Sets { get; set; }
            }

            public static WorkOutGoal FormatWorkOutGoal(string name, ExerciseGoal exercise_1, ExerciseGoal exercise_2, ExerciseGoal exercise_3)
            {
                return new WorkOutGoal { WorkOutName = name,  Exercise_1 = exercise_1, Exercise_2 = exercise_2, Exercise_3 = exercise_3 };
            }
            public static WorkOutGoal FormatWorkOutGoal(NetworkAPI.WorkOut workOut)
            {
                return new WorkOutGoal {
                    WorkOutName = workOut._name,
                    Exercise_1 = FormatExerciseGoal(workOut._exercise_1),
                    Exercise_2 = FormatExerciseGoal(workOut._exercise_2),
                    Exercise_3 = FormatExerciseGoal(workOut._exercise_3)};
            }

            public static ExerciseGoal FormatExerciseGoal(string name, int reps, int sets)
            {
                return new ExerciseGoal { Name = name, Reps = reps, Sets = sets };
            }
            public static ExerciseGoal FormatExerciseGoal(NetworkAPI.Exercise exercise)
            {
                return new ExerciseGoal { Name = exercise._name, Reps = exercise._reps, Sets = exercise._sets };
            }
        }
    }
}
