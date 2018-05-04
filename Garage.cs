using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        public List<Vehicle> m_Vehicles;

        public Garage()
        {
            m_Vehicles = new List<Vehicle>();
        }

        public void addVehicle(Vehicle m_VehicleToAdd)
        {
            m_Vehicles.Add(m_VehicleToAdd);
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();   
            foreach(Vehicle vehicle in m_Vehicles)
            {
                toString.Append(vehicle.ToString());
            }
            toString.AppendLine();

            return toString.ToString();
        }

    }
    
}
