/**
 * This class represents a City with
 * a name, lat and long.
 * @author copied from Dr. Kelley
 * @version 1.0;
 * FlightProj - City
 * SP20
 */
using System;
namespace FlightProject
{
    public class City
    {
        private string name;
	    private double latitude;
        private double longitude;

        /**
	     * Empty-argument constructor to put 
	     * object into a consistent state.
	     */
        private City()
        {
            name = "";
            latitude = 0.0;
            longitude = 0.0;
        }//end constructor

        /**
	     * Constructor to instantiate the object.
	     * @param name
	     * @param latitude
	     * @param longitude
	     */
        public City(string name, double latitude, double longitude)
        {
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
        }//end constructor

        /**
	     * Getter for name
	     * @return
	     */
        public string getName()
        {
            return name;
        }//end getName

        /**
	     * Getter for latitude
	     * @return
	     */
        public double getLatitude()
        {
            return latitude;
        }//end getLatitude

        /**
	     * Getter for longitude
	     * @return
	     */
        public double getLongitude()
        {
            return longitude;
        }//end getLongitude

        public String toString()
        {
            return "City [name=" + name + ", latitude=" + latitude + ", longitude=" + longitude + "]";
        }//end toString
    }//end class
}//end namespace
