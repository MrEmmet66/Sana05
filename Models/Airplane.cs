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

        public string StartCity
        {
            get { return startCity; }
            set { startCity = value; }
        }
        public string FinishCity
        {
            get { return finishCity; }
            set { finishCity = value; }
        }
        public MyDate StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public MyDate FinishDate
        {
            get { return finishDate; }
            set { finishDate = value; }
        }

        public int GetTotalTime()
        {
            return (finishDate.Year - startDate.Year) * 365 * 24 * 60 +
                (finishDate.Month - startDate.Month) * 30 * 24 * 60 +
                (finishDate.Day - startDate.Day) * 24 * 60 +
                (finishDate.Hour - startDate.Hour) * 60 +
                (finishDate.Minute - startDate.Minute);
        }

        public bool IsArrivingtoday()
        {
            if (startDate.Year == finishDate.Year && startDate.Month == finishDate.Month && startDate.Day == finishDate.Day)
            {
                return true;
            }
            return false;
        }

    }
}
