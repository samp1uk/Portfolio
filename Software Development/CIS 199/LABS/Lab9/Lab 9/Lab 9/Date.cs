//ID: M2564
//Lab: 9
//Class: CIS 199
//Course Section: 1
//Due Date: 04-21-19
//This program let user update the display date to the user requirement. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Date
    {
        // Private Fields
        private int _month;
        private int _day;
        private int _year;

        // Month property
        public int Month
        {
            // Precondition: None
            // Postcondition: Retrives _month
            get
            {
                return _month;
            }
            // Precondition: Greater than 0 or less than or equal to 12.
            // Postcondition: Month is set to numeric value entered by user if the requirement not meet then it sets a default value.
            set
            {
                if (value > 0 && value <= 12)
                {
                    _month = value;
                }
                else
                {
                    _month = 1;
                }
            }
        }

        // Day property
        public int Day
        {
            // Precondition: None
            // Postcondition: Retrives _day
            get
            {
                return _day;
            }

            // Precondition: Greater than 0 or less than or equal to 31.
            // Postcondition: Month is set to numeric value entered by user if the requirement not meet then it sets a default value.
            set
            {
                if (value > 0 && value <= 31)
                {
                    _day = value;
                }
                else
                {
                    _day = 1;
                }
            }
        }

        // Year property
        public int Year
        {
            // Precondition: None
            // Postcondition: Retrives _year
            get
            {
                return _year;
            }
            // Precondition: Greater than 0.
            // Postcondition: Month is set to numeric value entered by user if the requirement not meet then it sets a default value.
            set
            {
                if (value >= 0)
                {
                    _year = value;
                }
                else
                {
                    _year = 2019;
                }
            }
        }

        // Constructor accepting three parameters
        public Date(int m, int d, int y)
        {
            Month = m;
            Day = d;
            Year = y;
        }

        // Precondition: None
        // Postcondition: Creates a string in MM/DD/YYYY format
        public override string ToString()
        {
            string result = $"{Month:D2}" + "/" + $"{Day:D2}" + "/" + $"{Year:D4}";
            return result;
        }
    }
}
