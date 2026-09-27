namespace OOP_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Q01
            ////a) the memory address (reference) is copied,Both variables will now refere to the exact same object in the heap memory.

            ////b)No, it does not create a new object. It only creates a new reference that points to the already existing object. Because they share the same reference

            ////c)Copying a reference means you have two variables pointing to a single object in memory (changes affect both).
            ////Copying an object (cloning) means you allocate new memory and create a duplicate of the original object, you have two independent objects in memory.
            #endregion
            #region Q02
            ////a)A Shallow Copy creates a new object and copies all the valuetype fields directly. However, for reference-type fields, it only copies the references
            ////, not the actual nested objects.

            ////b)A Deep Copy creates a new object and copies all valuetype fields as well as creating entirely new copies of all reference-type objects.
            //// The new object is completely independent of the original.

            ////c)In a Shallow Copy, the reference-type members in the cloned object point to the exact same objects as the original.

            ////d)In a Deep Copy, completely new instances of the reference type members are created in memory.Modifying the objects in the clone will not affect the original object.

            ////e)If an Employee object contains an array of Scores or a nested Address object, a Deep Copy is safer if you want to update the clone's scores or address without 
            ////accidentally overwriting the original employee's data.

            #endregion
            #region Q03
            ////a)A static field belongs to the class itself and is shared among all instances of that class An instance field belongs to a specific object, meaning every 
            ////object has its own separate copy of that field.

            ////b)A static method is a method that belongs to the class rather than an instance, meaning it can be called without creating an object of the class.
            ////A static method cannot directly access instance members

            ////c)A static constructor is used to initialize any static data in a class. It is executed automatically by the CLR only once, right before the 
            ////first instance of the class is created or before any static member is referenced for the first time.

            ////d)A static class is a class that can only contain static members and cannot be instantiated. No, you cannot create an object (using the new keyword)
            //// from a static class
            #endregion
            #region Q04
            ////a)An Extension Method allows you to "add" new methods to existing types without modifying the original source code, inheriting from the type.

            ////b)The this keyword must precede the type being extended in the first parameter

            ////c)It must be declared inside a top-level, non-generic, static class.

            ////d)No, extension methods cannot access private or protected members of the class they extend. They can only access public members, just like any other external method.
            #endregion
            #region Q05
            ////a)A Partial Class allows the definition of a single class to be split across multiple physical files using the partial keyword. The compiler combines all parts 
            ////into a single class during compilation.

            ////b)It is highly useful when multiple developers need to work on the same class simultaneously without merge conflicts, or when separating auto-generated code
            ////from the developers custom business logic.

            ////c)A Partial Method is a method whose signature is defined in one part of a partial class, but its implementation (the body) can be optionally provided in another part of the partial class.

            ////d)If a partial method is not implemented, the compiler completely removes the method signature and all calls to that method from the final compiled code, resulting in zero performance cost.
            #endregion
            #endregion
        }
    }
}
