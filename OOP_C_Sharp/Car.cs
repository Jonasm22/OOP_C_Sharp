using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_Sharp
{
    internal class Car
    {

        //Member variable
        //private hides the variable from other classes
        //Backing Field of the Model propierty
        //private string _model = "";
        private string _model = "";
        private string _brand = "";
        private bool _isLuxury;

       //Propierty
       //Propierty with lamda
        public string Model1 { get => _model; set => _model = value; }
        public string Brand
        {
            get
            {
                if (_isLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered Nothing. ");
                    _brand = "DEFAULTVALUE";

                }

                else
                {
                    _brand = value;
                }

            }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        // Custom Constructor
        public Car(string model, string brand, bool isLuxury  )
        {
            _model = model;
            _brand = brand;

            Console.WriteLine("An Object of Car has been created "
                + _model + " was created " + _brand);
            _isLuxury = isLuxury;
        }


        public void Drive()
        {
            Console.WriteLine("I'm driving");
        }




    }
}
