using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        public ComposedMission(string name)
        {
            Name = name;
            Type = "Composed";
            actions = new List<Func<double, double>>();
        }

        public string Name { get; }

        public string Type { get; }

        List<Func<double, double>> actions;

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            foreach (var action in actions) {
                value = action(value);
            }
            OnCalculate.Invoke(this, value);
            return value;
        }
        
        public ComposedMission Add(Func<double, double> func) //TODO: not working properly.
        {
            actions.Add(func);
            return this;
        }
    }
}
