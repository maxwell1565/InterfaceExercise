using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int NumOfWheels { get; set; }
		public string Color { get; set; }
		public string FuelType { get; set; }
		public bool HasFourDoors { get; set; }

		public void DisplayDetails();

	}
}

