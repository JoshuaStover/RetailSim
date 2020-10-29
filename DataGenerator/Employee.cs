using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DataGenerator
{
    class Employee
    {
        // availability in 3 hour increments, 6am - 12am, 42 slots per week
        private const byte NUMBER_OF_SHIFT_SLOTS = 42;

        private uint _employeeNumber, _storeNumber;
        private string _fname, _lname;
        private decimal _hourlyPay;
        private DateTime _startDate;
        private bool _fullTime, _active;
        private bool[] _availability;

        /// <summary>
        /// Randomly generates an employee with provided a store and employee numbers.
        /// Store and employee number are combined to create a unique employee ID.
        /// </summary>
        /// <param name="storeNumber">
        /// Must be between 1 and 9999.
        /// </param>
        /// <param name="employeeNumber">
        /// Must be between 1 and 9999.
        /// </param>
        public Employee(uint storeNumber, uint employeeNumber)
        {
            Random rand = new Random();

            _employeeNumber = (storeNumber * 10000) + employeeNumber;

            _storeNumber = storeNumber;

            _fname = Name.GetFirst();
            _lname = Name.GetLast();
            _hourlyPay = (decimal)(rand.Next(10, 20) + rand.NextDouble());
            
            _startDate = new DateTime(rand.Next(1980, DateTime.Today.Year),
                rand.Next(1, 12), rand.Next(1, 29));

            _fullTime = rand.Next(0, 50) >= 40;
            _active = rand.Next(0, 100) < 90;

            _availability = new bool[NUMBER_OF_SHIFT_SLOTS];

            for (byte i = 0; i < NUMBER_OF_SHIFT_SLOTS; i++)
            {
                _availability[i] = (rand.Next() % 2) == 0;
            }
        }

        /// <summary>
        /// Generates a list of Employee objects if parameters are in range.
        /// </summary>
        /// <param name="numberOfEmployees">
        /// Must be between 1 and 9999.
        /// </param>
        /// <param name="storeNumber">
        /// Must be between 1 and 9999.
        /// </param>
        /// <returns>
        /// Populated list of Employee objects, containing
        /// numberOfEmployees Employee objects assigned to store storeNumber.
        /// </returns>
        public static List<Employee> MakeList(uint numberOfEmployees, uint storeNumber)
        {
            if (numberOfEmployees < 1 || numberOfEmployees > 9999)
            {
                Console.WriteLine(
                    "ERROR: Number of employees must be between 1 and 9999.");
                return null;
            }
            else if(storeNumber < 1 || storeNumber > 9999)
            {
                Console.WriteLine("ERROR: Store number must be between 1 and 9999.");
                return null;
            }
            else
            {
                List<Employee> output = new List<Employee>();
                for (uint i = 0; i < numberOfEmployees; i++)
                {
                    output.Add(new Employee(storeNumber, i + 1));
                }
                return output;
            }

        }

        /// <summary>
        /// Converts an Employee object into a CSV-compatible string.
        /// </summary>
        /// <returns>
        /// CSV-compatible string representation of Employee object.
        /// </returns>
        public string ToCSV()
        {
            string availabilityString = "";
            for (byte i = 0; i < NUMBER_OF_SHIFT_SLOTS - 1; i++)
            {
                availabilityString += (_availability[i] + ",");
            }
            availabilityString += _availability[NUMBER_OF_SHIFT_SLOTS - 1];
            // Didn't want to put an if in that for loop. Wasted cycles.

            return _employeeNumber.ToString() + "," + _fname + "," + _lname +
                "," + _storeNumber.ToString() + "," +
                _hourlyPay.ToString("C", CultureInfo.CreateSpecificCulture("en-US")) +
                "," + _startDate + "," + _fullTime + "," + _active + availabilityString;
        }

    }
}
