using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ElectricCar : Vehicle
    {
        CarProperties m_CarProperties;
        public ElectricCar(CarProperties i_CarProperties, string i_WheelManufacturerName, string i_ModelName, string i_LicensePlate) 
            : base(4, 32, i_WheelManufacturerName, i_ModelName, i_LicensePlate)
        {
            Tank = new Tank(FuelType.Electricity, 3.2f);
            m_CarProperties = i_CarProperties;
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendLine(base.ToString());
            toString.AppendLine(m_CarProperties.ToString());

            return toString.ToString();
        }

    }
}
