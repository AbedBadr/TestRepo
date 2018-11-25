using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp
{
    class Vehicle
    {
        #region Enum
        public enum Type { Sedan, Offroad, Hatchback, SUV, Convertible}
        public enum Make { VW, BMW, Audi, Mercedes, Peugeot, Ford}
        #endregion

        #region Properties
        public Type CarType { get; set; }
        public Make CarMake { get; set; }
        public int SerialNr { get; set; }
        public string Model { get; set; }
        #endregion

        #region Constructor
        public Vehicle(Type carType, Make carMake, int serialNr, string model)
        {
            CarType = carType;
            CarMake = carMake;
            SerialNr = serialNr;
            Model = model;
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return $"{nameof(CarType)}: {CarType}, {nameof(CarMake)}: {CarMake}, {nameof(SerialNr)}: {SerialNr}, {nameof(Model)}: {Model}";
        }
        #endregion
    }
}
