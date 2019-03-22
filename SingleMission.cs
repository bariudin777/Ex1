//user name: bariuddd
//Id: 307758334

using System;

namespace Excercise_1
{
    /*
     * Singel Mission class  
     * Member: "dalagete" Func func
     * usisg interface IMission and all his methods
     * 
    */
    public class SingleMission : IMission
    {
        private Func<double, double> func;
        //Constractor of this class
        //Init the name and the type of Single Mission
        public SingleMission(Func<double, double> func, string name)
        {
            this.func = func;
            Name = name;
            Type = "Single";
        }

        public string Name { get; }

        public string Type { get; }
        //using event handker to manage the events
        public event EventHandler<double> OnCalculate;
        //Calculate and return an value
        public double Calculate(double value)
        {
            double res = func(value);
            //if OmCalculate is null- dont invoke it
            OnCalculate?.Invoke(this, res);
            return res;
        }
    }
}
