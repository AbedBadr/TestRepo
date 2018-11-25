using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp
{
    class Vehicle
    {
        public enum Type { Sedan, Offroad, Hatchback, SUV, Convertible}
        public enum Make { VW, BMW, Audi, Mercedes, Peugeot, Ford}

        public Type CarType { get; set; }
        public Make CarMake { get; set; }
        public int SerialNr { get; set; }
        public string Model { get; set; }

        public Vehicle(Type carType, Make carMake, int serialNr, string model)
        {
            CarType = carType;
            CarMake = carMake;
            SerialNr = serialNr;
            Model = model;
        }

        public override string ToString()
        {
            return $"{nameof(CarType)}: {CarType}, {nameof(CarMake)}: {CarMake}, {nameof(SerialNr)}: {SerialNr}, {nameof(Model)}: {Model}";
        }
    }
}
