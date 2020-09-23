using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// Class that represents a motorcycle.
    /// It contains the Licenseplate and Date attributes
    /// and the Price and VehicleType method.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// The License plate of the motorcycle
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// The date and time the ticket is issued.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Method that gives you the price of the ticket for the motorcycle
        /// </summary>
        /// <returns>The price of the car ticket which is equal to 125 (double) </returns>
        public override double Price()
        {
            return 125;
        }

        /// <summary>
        /// Method that gives you the Vehicle Type of the motorcycle
        /// </summary>
        /// <returns>The vehicle type of the motorcycle (string)</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
