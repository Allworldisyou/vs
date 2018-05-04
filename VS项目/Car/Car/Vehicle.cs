using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public abstract class Vehicle
    {
        private string color;

        protected string Color
        {
            get { return color; }
            set { color = value; }
        }
        private double dailyRent;

        protected double DailyRent
        {
            get { return dailyRent; }
            set { dailyRent = value; }
        }
        private string licenesNO;

        protected string LicenesNO
        {
            get { return licenesNO; }
            set { licenesNO = value; }
        }
        private string name;

        protected string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int rentDate;

        protected int RentDate
        {
            get { return rentDate; }
            set { rentDate = value; }
        }
        private string rentUser;

        protected string RentUser
        {
            get { return rentUser; }
            set { rentUser = value; }
        }
        private int yearOfService;

        protected int YearOfService
        {
            get { return yearOfService; }
            set { yearOfService = value; }
        }

        


        public Vehicle()
        { 
        }


    }
}
