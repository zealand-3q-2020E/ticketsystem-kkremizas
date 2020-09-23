﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car
    {
        /// <summary>
        /// The License plate of the car
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// The date and time the ticket is issued.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Method that gives you the price of the ticket for the car
        /// </summary>
        /// <returns>The price of the car ticket which is equal to 240 (double) </returns>
        public double Price()
        {
            return 240;
        }

        /// <summary>
        /// Method that gives you the Vehicle Type of the car
        /// </summary>
        /// <returns>The vehicle type of the car (string)</returns>
        public string VehicleType()
        {
            return "Car";
        }


    }
}