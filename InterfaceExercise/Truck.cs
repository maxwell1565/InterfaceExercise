using System;
using Microsoft.VisualBasic.FileIO;
using System.Drawing;

namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public Truck()
		{
		}

		public bool IsTough { get; set; } = true;
		public string TowingCapacity { get; set; } = "10,000 LBS";



        int IVehicle.NumOfWheels { get; set; } = 4;
        string IVehicle.Color { get; set; } = "brown";
        string IVehicle.FuelType { get; set; } = "gasoline";
        bool IVehicle.HasFourDoors { get; set; } = true;


        string ICompany.Logo { get; set; } = "gold bowtie";
        string ICompany.Slogan { get; set; } = "together let's drive";

        public void DisplayDetails()
        {
            ICompany company = this;
            IVehicle vehicle = this;
            Console.WriteLine($"Is it a tough truck?{IsTough} Towing capacity? {TowingCapacity} Wheels: {vehicle.NumOfWheels} Color: {vehicle.Color} Fuel: {vehicle.FuelType} How many doors? {vehicle.HasFourDoors} Logo: {company.Logo} Slogan: {company.Slogan}");
        }
    }
}

