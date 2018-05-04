using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class CombustionMotorcycle : Vehicle
    {
        private MotorcycleProperties m_MotorcycleProperties;
        public CombustionMotorcycle(MotorcycleProperties i_MotorcycleProperties, string i_WheelManufacturerName, string i_ModelName, string i_LicensePlate) : base(2, 30, i_WheelManufacturerName, i_ModelName, i_LicensePlate)
        {
            Tank = new Tank(FuelType.Octan96, 6);
            m_MotorcycleProperties = i_MotorcycleProperties;
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendLine(base.ToString());
            toString.AppendLine(m_MotorcycleProperties.ToString());

            return toString.ToString();
        }
    }
}
