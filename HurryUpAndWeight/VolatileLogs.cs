using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server
{
    public sealed class VolatileLogs
    {
        private static VolatileLogs _instance = null;
        private static readonly object _padlock = new object();

        private string _logs;

        private VolatileLogs()
        {
            _logs = string.Empty;
        }

        public static string Get()
        {
            lock(_padlock)
            {
                if(_instance == null)
                {
                    _instance = new VolatileLogs();
                }
                return _instance.ToString();
            }
        }

        public static void Add(string log)
        {
            lock (_padlock)
            {
                if (_instance == null)
                {
                    _instance = new VolatileLogs();
                }
                _instance._logs += log + "\n";
            }
        }

        public override string ToString()
        {
            return _logs;
        }
    }
}
