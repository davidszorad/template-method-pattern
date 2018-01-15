using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDesignPattern.Structural
{
    /*
    Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. 
    Template Method lets subclasses redefine certain steps of an algorithm without changing 
    the algorithm's structure. 


    The classes and objects participating in this pattern are:
        AbstractClass  (DataObject)
            defines abstract primitive operations that concrete subclasses define to implement steps of an algorithm
            implements a template method defining the skeleton of an algorithm. The template method calls primitive 
            operations as well as operations defined in AbstractClass or those of other objects.
        ConcreteClass  (CustomerDataObject)
            implements the primitive operations ot carry out subclass-specific steps of the algorithm
    

    This structural code demonstrates the Template method which provides a skeleton calling sequence of methods. 
    One or more steps can be deferred to subclasses which implement these steps without changing the overall calling sequence.


    OUTPUT:
    ConcreteClassA.PrimitiveOperation1()
    ConcreteClassA.PrimitiveOperation2()
    */

    /// <summary>
    /// Main startup class for Real-World 
    /// Template Design Pattern.
    /// </summary>
    class Main
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();

            // Wait for user
            Console.ReadKey();
        }
    }
}
