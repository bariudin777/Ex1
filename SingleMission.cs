using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private Func<double, double> func;
        public SingleMission(Func<double, double> func, string name)
        {
            this.func = func;
            Name = name;
            Type = "Single";
        }

        public string Name { get; }

        public string Type { get; }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            double res = func(value);
            OnCalculate?.Invoke(this, res);
            return res;
        }
    }
}
