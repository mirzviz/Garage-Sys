using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{ 
    public class ElectricMotorcycle : Vehicle
    {
        private MotorcycleProperties m_MotorciclyProperties;

        public ElectricMotorcycle(MotorcycleProperties i_MotorcycleProperties, string i_WheelManufacturerName, string i_ModelName, string i_LicensePlate) : base(2, 30, i_WheelManufacturerName, i_ModelName, i_LicensePlate)
        {
            Tank = new Tank(FuelType.Electricity, 1.8f);
            m_MotorciclyProperties = i_MotorcycleProperties;
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendLine(base.ToString());
            toString.AppendLine(m_MotorciclyProperties.ToString());

            return toString.ToString();
        }
    }
}
