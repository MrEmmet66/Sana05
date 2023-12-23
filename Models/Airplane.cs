using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05.Models
{
    public class Airplane
    {
        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            this.startCity = startCity;
            this.finishCity = finishCity;
            this.startDate = startDate;
            this.finishDate = finishDate;
        }
        public Airplane(string startCity, string finishCity, MyDate startDate)
        {
            this.startCity = startCity;
            this.finishCity = finishCity;
            this.startDate = startDate;
        }
        public Airplane(Airplane airplane) : this(airplane.startCity, airplane.finishCity, airplane.startDate, airplane.finishDate) { }
        public Airplane() { }


        protected string startCity;
        protected string finishCity;
        protected MyDate startDate;
        protected MyDate finishDate;


    }
}
