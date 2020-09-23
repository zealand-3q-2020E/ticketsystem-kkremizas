using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        /// <summary>
        /// The License plate of the vehicle
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// The date and time the ticket is issued.
        /// </summary>
        public DateTime Date { get; set; }


        /// <summary>
        /// Method that gives you the price of the ticket for the vehicle
        /// </summary>
        /// <returns>The price of the type's ticket (double) </returns>
        public abstract double Price();

        /// <summary>
        /// Method that gives you the Vehicle Type of the vehicle
        /// </summary>
        /// <returns>The vehicle type of the vehicle (string)</returns>
        public abstract string VehicleType();
    }
}
