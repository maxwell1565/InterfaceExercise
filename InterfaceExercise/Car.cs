using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public bool HasTrunk { get; set; } = true;
        public bool IsAWD { get; set; } = false;


        public int NumOfWheels { get; set; } = 4;
        public string Color { get; set; } = "red";
        public string FuelType { get; set; } = "gasoline";
        public bool HasFourDoors { get; set; } = true;

       
        string ICompany.Logo { get; set; } = "blue and white ford";
        string ICompany.Slogan { get; set; } = "build ford tough";

        public void DisplayDetails()
        {
            ICompany company = this;
            Console.WriteLine($"Trunk?{HasTrunk} AWD? {IsAWD} Wheels: {NumOfWheels} Color: {Color} Fuel: {FuelType} How many doors? {HasFourDoors} Logo: {company.Logo} Slogan: {company.Slogan}");
        }
        

    }
    
}
