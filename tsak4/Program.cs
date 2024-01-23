

 Car car =  new  Car();
 car.Make = "Mersedes";
 car. Model = "AMG";
 car.Year = 2023;
 car.Mileage = 100;
 System.Console.WriteLine();

public class Car{
   public string  Make;
   public string  Model;
   public int Year;
   public int Mileage;
   public double Fuel;
   public void AddFuel(double gallons)  {
     Fuel= gallons ;
   }
}
