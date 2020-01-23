/**
 * This class represents a test of classes city and flight
 * @author copied from Dr. Kelley
 * @version 1.0;
 * FlightProj - FlightTest
 * SP20
 */
using System;

namespace FlightProject
{
    class FlightTest
    {
        public static void Main(string[] args)
        {
            City o = new City("Louisville, KY", 38.2527, 85.7585);
            City d = new City("Los Angeles, CA", 34.0522, 118.243680);

            Flight f = new Flight("BU Air", "A2972", o, d);
            Console.Write(f.printFlightDetails());

            City o2 = new City("Louisville, KY", 38.2527, 85.7585);
            City d2 = new City("New York, NY", 40.7128, 74.0060);

            Flight f2 = new Flight("BU Air", "A2972", o2, d2);
            Console.Write(f2.printFlightDetails());
        }//end Main
    }//end class
}//end namespace
