using System;

namespace Planner 
{    
    public class Building
    {
        // Class Private Fields
        private string _designer = "Patti Perry";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

        // Class Public Properties
        public int stories {get; set;}
        public double width { get; set; }
        public double depth { get; set; }
        public double volume 
        {
            get 
            {
                return width * depth * (3 * stories);
            }
        }

        // Class Constructors 
        public Building (string address) 
        {
            _address = address;
        }

        // Class Methods
        public void Construct ()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase (string owner)
        {
            _owner = owner;
        }

        public void PrintBuilding ()
        {
        Console.WriteLine($"{this._address} \r\n Designed by {this._designer}. \r\n Constructed on {this._dateConstructed}. \r\n Owned by {this._owner} \r\n {this.volume} of space");
        }

    }


}