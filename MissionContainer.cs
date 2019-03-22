//user name: bariuddd
//Id: 307758334
using System;
using System.Collections.Generic;


namespace Excercise_1
{    /*
     * Function Container 
     * Member: Dictionary - string,Func
     * Methods: getAllMissions- gets all Missions
     * 
    */
    public class FunctionsContainer : Dictionary<string, Func<double, double>>
    {
        public IEnumerable<string> getAllMissions()
        {
            return this.Keys;
        }
        // I overloaded "[]" by get and set
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
