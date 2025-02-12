using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jared_Daniels_CPT_206_Lab_3
{
    internal class State
    {
        // Properties
        public int id { get; set; }
        public string state { get; set; }
        public string population { get; set; }
        public string capital { get; set; }
        public string income { get; set; }
        public string jobs { get; set; }
        public string flower { get; set; }
        public string bird { get; set; }
        public string color { get; set; }
        public string cities { get; set; }
        public string flag { get; set; }

    // Constructor
    public State(int id, string state, string population, string capital, string income, string jobs, string flower, string bird, string color, string cities, string flag)
        {
            this.id = id;
            this.state = state;
            this.population = population;
            this.capital = capital;
            this.income = income;
            this.jobs = jobs;
            this.flower = flower;
            this.bird = bird;
            this.color = color;
            this.cities = cities;
            this.flag = flag;
        }
    }
}
