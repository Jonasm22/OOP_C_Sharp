using OOP_C_Sharp;

namespace OOP_C_Sharp
{
    internal class Program
    {


        static void Main(string[] args)
        {


            customer customr = new customer();

            customr.setDetails("Denis", "MeinStreet1");

            customer customr1 = new customer("Frank");

     
            Console.WriteLine("Contactnumber of Frank is: " + customr1.ContactNummer);
          Console.ReadKey();

        }



       



    }
}


/*
 * /Creating an Object of the Class Car
            //Creating an instance of the Class Car
            /*
            Car audi = new Car("A3" , "AUDI" , false);
            Car bmw = new Car("i7" , "BWM", true);
            /*
            Console.WriteLine("Please enter the brand Name. ");
            //"SETTING BRAND"
            audi.Brand = Console.ReadLine();
            //"GETTING BRAND"
            Console.WriteLine("You entered " + audi.Brand);
            */

//"GETTING BRAND"
/*
Console.WriteLine("Brand is " + audi.Brand);
Console.WriteLine("Brand is " + bmw.Brand);

*/

/*
customer earl =  new customer("Earl");
customer Frank =  new customer("Frank" , "Mainstring", "555222");
//Default Costumer
customer newCostomer = new customer();
Console.WriteLine("Please enter your Name: ");
newCostomer.Name = Console.ReadLine();
//Console.WriteLine("Name of Costumer is: " +earl.Name);
Console.WriteLine("Name of Costumer is: " +  newCostomer.Name);

*/
/*
customer newCustomer = new customer();

newCustomer.setDetails("Frank", "MainStreet2", "55566");
Console.WriteLine("My costumer is: " + newCustomer.Name + " and he lives in " + newCustomer.Address); ;


Car myAudi = new Car("A3", "Audi", false);

myAudi.Drive();
Console.WriteLine();
Console.ReadKey();

*/