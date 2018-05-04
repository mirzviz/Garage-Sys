using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class CombustionCar : Vehicle
    {
        CarProperties m_CarProperties;
        public CombustionCar(CarProperties i_CarProperties, string i_WheelManufacturerName, string i_ModelName, string i_LicensePlate) 
            : base(4, 32, i_WheelManufacturerName, i_ModelName, i_LicensePlate)
        {
            Tank = new Tank(FuelType.Octan98, 45f);
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
