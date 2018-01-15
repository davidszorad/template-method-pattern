using System;

namespace TemplateMethodDesignPattern
{
    /*
     This real-world code demonstrates a Template method named Run() which provides a skeleton 
     calling sequence of methods. Implementation of these steps are deferred to the CustomerDataObject 
     subclass which implements the Connect, Select, Process, and Disconnect methods.


        OUTPUT:
        Categories ----
        Beverages
        Condiments
        Confections
        Dairy Products
        Grains/Cereals
        Meat/Poultry
        Produce
        Seafood

        Products ----
        Chai
        Chang
        Aniseed Syrup
        Chef Anton's Cajun Seasoning
        Chef Anton's Gumbo Mix
        Grandma's Boysenberry Spread
        Uncle Bob's Organic Dried Pears
        Northwoods Cranberry Sauce
        Mishi Kobe Niku
    */

    /// <summary>
    /// Program startup class for Real-World 
    /// Template Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();

            // Wait for user
            Console.ReadKey();
        }
    }
}
