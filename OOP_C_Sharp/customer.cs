using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C_Sharp
{
    internal class customer
    {

        //ctor => constructor
        // Custom Constructor
        public string Name { get; set; }
        public string Address { get; set; }

        public string ContactNummer { get; set; }

        // Default consturctor
        public customer()
        {
            Name = "New Constomer";
            Address = "Unknown adress";
            ContactNummer = "None";
            
        }


/*
        public customer(string name, string address, string contactNummer)
        {
            Name = name;
            Address = address;
            ContactNummer = contactNummer;
        }
*/
        //Optional Parameter
        public customer(string name, string address = "NA" , string contactNummer ="NA") 
        
        {
            Name = name;
            Address = address;
            ContactNummer = contactNummer;
        
        }

        //Default Parameters ContactNummer

        public void setDetails(string name, string address, string contactNummer = "NA")
        {

            Name = name;
            Address = address;
            ContactNummer = contactNummer;

        }












    }
}
