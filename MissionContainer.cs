using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{

    public class FunctionsContainer : Dictionary<string, Func<double, double>>
    {
        public IEnumerable<string> getAllMissions()
        {
            return this.Keys;
        }

        new public Func<double, double> this[string key]
        {

            get
            {
                if (this.ContainsKey(key))
                    return base[key];
                else
                    base[key] = x => x;
                    return x => x;
            }
            set { base[key] = value; }
        }
    }
}
