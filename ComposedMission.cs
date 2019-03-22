//user name: bariuddd
//Id: 307758334

using System;
using System.Collections.Generic;

namespace Excercise_1
{    /*
     * Composed Mission class  
     * Member: name -the name of the mission
     *         Type- the type of the mission
     *         actions - list of dalagate Func
     * usisg interface IMission and all his methods
     * 
    */
    public class ComposedMission : IMission
    {
        List<Func<double, double>> actions;

        public ComposedMission(string name)
        {
            Name = name;
            Type = "Composed";
            actions = new List<Func<double, double>>();
        }

        public string Name { get; }

        public string Type { get; }
        //Event handler - Oncalculate
        public event EventHandler<double> OnCalculate;
        //Calculate each var in actions
        public double Calculate(double value)
        {
            foreach (var action in actions) {
                value = action(value);
            }
        //Oncalculate invoke value by Mission(Compose Mission)
            OnCalculate.Invoke(this, value);
            return value;
        }
        //Add mission by actions
        public ComposedMission Add(Func<double, double> func)
        {
            actions.Add(func);
            return this;
        }
    }
}
