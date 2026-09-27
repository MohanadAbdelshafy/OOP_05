namespace OOP_05
{
    #region Part 02
    #region Helper Classes & Interfaces
    //public class DeliveryAddress
    //{
    //    public string City { get; set; }
    //    public string Street { get; set; }
    //    public int BuildingNumber { get; set; }

    //    public DeliveryAddress(string city, string street, int buildingNumber)
    //    {
    //        City = city;
    //        Street = street;
    //        BuildingNumber = buildingNumber;
    //    }
    //    public DeliveryAddress DeepCopy()
    //    {
    //        return new DeliveryAddress(City, Street, BuildingNumber);
    //    }
    //}
    //public interface ITrackable
    //{
    //    string GetTrackingStatus();
    //}

    //public interface IInsurable
    //{
    //    decimal CalculateInsurance();
    //}

    #endregion
    #region Shipment Class
    //public abstract partial class Shipment : ITrackable, IInsurable
    //{
    //    public static int TotalShipmentsCreated;
    //    static Shipment()
    //    {
    //        Console.WriteLine("Shipment System Initialized\n");
    //        TotalShipmentsCreated = 0;
    //    }

    //    public string TrackingCode { get; private set; }
    //    public string Description { get; set; }
    //    public decimal Weight { get; protected set; }
    //    public decimal DeliveryFee { get; protected set; }
    //    public DeliveryAddress Destination { get; set; }

    //    public abstract decimal EstimatedCost { get; }

    //    public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string initialStatus)
    //    {
    //        TrackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "Unknown" : trackingCode;
    //        Description = description;
    //        Weight = weight > 0 ? weight : 1;
    //        DeliveryFee = deliveryFee >= 0 ? deliveryFee : 0;
    //        Destination = destination;

    //        InitializeTracking(initialStatus);

    //        TotalShipmentsCreated++;
    //    }

    //    public abstract void PrintShipment();
    //    public abstract decimal CalculateInsurance();
    //    public Shipment CopyShipment()
    //    {
    //        return ShallowCopy();
    //    }

    //    public Shipment ShallowCopy()
    //    {
    //        return (Shipment)this.MemberwiseClone();
    //    }

    //    public abstract Shipment DeepCopy();
    //    public static int GetTotalShipmentsCreated()
    //    {
    //        return TotalShipmentsCreated;
    //    }
    //}
    //public abstract partial class Shipment
    //{
    //    public string TrackingStatus { get; protected set; }

    //    protected void InitializeTracking(string status)
    //    {
    //        TrackingStatus = status;
    //    }

    //    public string GetTrackingStatus()
    //    {
    //        return $"Shipment {TrackingCode} is {TrackingStatus}";
    //    }

    //    public void UpdateTrackingStatus(string newStatus)
    //    {
    //        TrackingStatus = newStatus;
    //        OnTrackingStatusChanged(newStatus); 
    //    }
    //    partial void OnTrackingStatusChanged(string newStatus);

    //    partial void OnTrackingStatusChanged(string newStatus)
    //    {
    //        Console.WriteLine($"Tracking status changed to: {newStatus}\n");
    //    }
    //}

    #endregion
    #region Derived Shipment Types
    //public class StandardShipment : Shipment
    //{
    //    public StandardShipment(string code, string desc, decimal weight, decimal fee, DeliveryAddress dest, string status)
    //        : base(code, desc, weight, fee, dest, status) { }

    //    public override decimal EstimatedCost => DeliveryFee + (Weight * 5);

    //    public override void PrintShipment() { }
    //    public override decimal CalculateInsurance() => EstimatedCost * 0.05m;

    //    public override Shipment DeepCopy()
    //    {
    //        return new StandardShipment(TrackingCode, Description, Weight, DeliveryFee, Destination.DeepCopy(), TrackingStatus);
    //    }
    //}

    //public class ExpressShipment : Shipment
    //{
    //    public decimal ExtraFee { get; set; }

    //    public ExpressShipment(string code, string desc, decimal weight, decimal fee, DeliveryAddress dest, decimal extraFee, string status)
    //        : base(code, desc, weight, fee, dest, status)
    //    {
    //        ExtraFee = extraFee >= 0 ? extraFee : 0;
    //    }

    //    public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + ExtraFee;
    //    public override void PrintShipment() { }
    //    public override decimal CalculateInsurance() => EstimatedCost * 0.08m;

    //    public override Shipment DeepCopy()
    //    {
    //        return new ExpressShipment(TrackingCode, Description, Weight, DeliveryFee, Destination.DeepCopy(), ExtraFee, TrackingStatus);
    //    }
    //}

    //public class InternationalShipment : Shipment
    //{
    //    public string DestinationCountry { get; set; }
    //    public decimal CustomsFee { get; set; }

    //    public InternationalShipment(string code, string desc, decimal weight, decimal fee, DeliveryAddress dest, string country, decimal customs, string status)
    //        : base(code, desc, weight, fee, dest, status)
    //    {
    //        DestinationCountry = country;
    //        CustomsFee = customs;
    //    }

    //    public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + CustomsFee;
    //    public override void PrintShipment() { }
    //    public override decimal CalculateInsurance() => EstimatedCost * 0.12m;

    //    public override Shipment DeepCopy()
    //    {
    //        return new InternationalShipment(TrackingCode, Description, Weight, DeliveryFee, Destination.DeepCopy(), DestinationCountry, CustomsFee, TrackingStatus);
    //    }
    //}
    #endregion
    #region Static class
    //public static class DeliveryUtilities
    //{
    //    public static void PrintSeparator()
    //    {
    //        Console.WriteLine("======================");
    //    }

    //    public static void PrintSubSeparator()
    //    {
    //        Console.WriteLine("----------------------------------");
    //    }

    //    public static void PrintSystemTitle()
    //    {
    //        PrintSeparator();
    //        Console.WriteLine("Smart Delivery Management System");
    //        PrintSeparator();
    //        Console.WriteLine();
    //    }
    //}
    #endregion
    #region Extension methods
    //public static class ShipmentExtensions
    //{
    //    public static string GetSummary(this Shipment shipment)
    //    {
    //        string type = shipment.GetType().Name.Replace("Shipment", "");
    //        return $"{shipment.TrackingCode} | {type} | {shipment.Weight} KG | {shipment.TrackingStatus}";
    //    }

    //    public static bool IsDelivered(this Shipment shipment)
    //    {
    //        return shipment.TrackingStatus.Equals("Delivered", StringComparison.OrdinalIgnoreCase);
    //    }
    //}
    #endregion
    #endregion
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
            #region Part02 main
            //DeliveryUtilities.PrintSystemTitle();

            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Creating Shipments...");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();

            //DeliveryAddress address1 = new DeliveryAddress("Cairo", "Tahrir", 15);
            //DeliveryAddress address2 = new DeliveryAddress("Cairo", "Maadi", 10);
            //DeliveryAddress address3 = new DeliveryAddress("Alexandria", "Smouha", 5);

            //StandardShipment s1 = new StandardShipment("SH001", "Laptop", 3, 80m, address1, "In Transit");
            //Console.WriteLine("Standard Shipment Created");

            //ExpressShipment s2 = new ExpressShipment("SH002", "Mobile Phone", 2, 60m, address2, 30m, "Out For Delivery");
            //Console.WriteLine("Express Shipment Created");

            //InternationalShipment s3 = new InternationalShipment("SH003", "Television", 8, 120m, address3, "Germany", 100m, "Delivered");
            //Console.WriteLine("International Shipment Created\n");

            //Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}\n");

            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Object Copying");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();

            //Shipment assignedShipment = s1;
            //Console.WriteLine($"Original Shipment  : {s1.TrackingCode}");
            //Console.WriteLine($"Assigned Shipment  : {assignedShipment.TrackingCode}\n");
            //Console.WriteLine($"Same Object : {object.ReferenceEquals(s1, assignedShipment)}\n");

            //DeliveryUtilities.PrintSubSeparator();
            //Console.WriteLine("Shallow Copy");
            //DeliveryUtilities.PrintSubSeparator();
            //Console.WriteLine();

            //StandardShipment shallowOriginal = new StandardShipment("SH100", "Book", 1, 20m, new DeliveryAddress("Cairo", "Street 1", 1), "Pending");
            //Shipment shallowCopied = shallowOriginal.ShallowCopy();

            //Console.WriteLine($"Original Shipment Address : {shallowOriginal.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address   : {shallowCopied.Destination.City}\n");

            //Console.WriteLine("Changing copied shipment address...\n");
            //shallowCopied.Destination.City = "Giza";

            //Console.WriteLine($"Original Shipment Address : {shallowOriginal.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address   : {shallowCopied.Destination.City}\n");
            //Console.WriteLine($"Same DeliveryAddress Object : {object.ReferenceEquals(shallowOriginal.Destination, shallowCopied.Destination)}\n");

            //DeliveryUtilities.PrintSubSeparator();
            //Console.WriteLine("Deep Copy");
            //DeliveryUtilities.PrintSubSeparator();
            //Console.WriteLine();

            //StandardShipment deepOriginal = new StandardShipment("SH200", "Camera", 2, 50m, new DeliveryAddress("Cairo", "Street 2", 2), "Pending");
            //Shipment deepCopied = deepOriginal.DeepCopy();

            //Console.WriteLine($"Original Shipment Address : {deepOriginal.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address   : {deepCopied.Destination.City}\n");

            //Console.WriteLine("Changing copied shipment address...\n");
            //deepCopied.Destination.City = "Giza";

            //Console.WriteLine($"Original Shipment Address : {deepOriginal.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address   : {deepCopied.Destination.City}\n");
            //Console.WriteLine($"Same DeliveryAddress Object : {object.ReferenceEquals(deepOriginal.Destination, deepCopied.Destination)}\n");

            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Extension Methods");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();

            //Console.WriteLine(s1.GetSummary());
            //Console.WriteLine(s2.GetSummary());
            //Console.WriteLine(s3.GetSummary() + "\n");

            //Console.WriteLine($"{s1.TrackingCode} Is Delivered : {s1.IsDelivered()}");
            //Console.WriteLine($"{s3.TrackingCode} Is Delivered : {s3.IsDelivered()}\n");

            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Tracking Status");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();

            //s1.UpdateTrackingStatus("Out For Delivery");


            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Static Utilities");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();

            //DeliveryUtilities.PrintSubSeparator();
            //Console.WriteLine("Delivery Center");
            //DeliveryUtilities.PrintSubSeparator();
            //Console.WriteLine();

            //Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}\n");

            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Partial Method");
            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine();

            //s3.UpdateTrackingStatus("Delivered");

            //DeliveryUtilities.PrintSeparator();
            //Console.WriteLine("Assignment Completed");
            //DeliveryUtilities.PrintSeparator();

            //Console.ReadLine(); 
            #endregion
        }
    }
}
