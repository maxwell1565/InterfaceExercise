using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public SUV()
		{
		}

		public bool CanHaulGroceries { get; set; } = true;
		public string TypeofInterior { get; set; } = "cloth";


        public int NumOfWheels { get; set; } = 4;
        public string Color { get; set; } = "blue";
        public string FuelType { get; set; } = "gasoline";
        public bool HasFourDoors { get; set; } = true;


        string ICompany.Logo { get; set; } = "infinity T";
        string ICompany.Slogan { get; set; } = "let's go places";

        public void DisplayDetails()
        {
            ICompany company = this;
            IVehicle vehicle = this;
            Console.WriteLine($"Grocery getter?{CanHaulGroceries} Interior: {TypeofInterior} Wheels: {vehicle.NumOfWheels} Color: {vehicle.Color} Fuel: {vehicle.FuelType} How many doors? {vehicle.HasFourDoors} Logo: {company.Logo} Slogan: {company.Slogan}");
        }
    }
}

