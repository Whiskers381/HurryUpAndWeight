using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;


namespace NetworkAPI
{
    public class WorkOut
    {
        public string _name { get; protected set; }

        public Exercise _exercise_1 { get; protected set; }
        public Exercise _exercise_2 { get; protected set; }
        public Exercise _exercise_3 { get; protected set; }

        private WorkOut(string name, Exercise exercise_1, Exercise exercise_2, Exercise exercise_3)
        {
            _name = name;
            _exercise_1 = exercise_1;
            _exercise_2 = exercise_2;
            _exercise_3 = exercise_3;
        }

        /// <summary>
        /// Serializes User into Jason using the provided struct
        /// </summary>
        public string SerializeJson()
        {
            return JsonSerializer.Serialize(JsonMirrors.WorkOut.FormatWorkOutGoal(this), typeof(JsonMirrors.WorkOut.WorkOutGoal), null);
        }

        /// <summary>
        /// Deserialize Json back into the eqivalent C# datastructure using the provided struct
        /// </summary>
        public static JsonMirrors.WorkOut.WorkOutGoal DeSerializeJson(string serializedUser)
        {
            return (JsonMirrors.WorkOut.WorkOutGoal)JsonSerializer.Deserialize(serializedUser, typeof(JsonMirrors.WorkOut.WorkOutGoal));
        }
    }
}
