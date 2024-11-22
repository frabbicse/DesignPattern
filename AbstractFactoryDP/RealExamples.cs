using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP
{
    public interface IEngine
    {
        string GetEngineType();
    }

    public interface ITire
    {
        string GetTireTYpe();
    }

    public class ElectricCarEngine : IEngine
    {
        public string GetEngineType()
        {
            return "Electric Car Engine";
        }
    }

    public class ElectricCarTire : ITire
    {
        public string GetTireTYpe()
        {
            return "Electric Car Tire";
        }
    }


    public class GasCarEngine : IEngine
    {
        public string GetEngineType()
        {
            return "Gas Car Engine";
        }
    }

    public class GasCarTire : ITire
    {
        public string GetTireTYpe()
        {
            return "Gas Car Tire";
        }
    }

    public class ElectricTruckEngine : IEngine
    {
        public string GetEngineType()
        {
            return "Electric Truck Engine";
        }
    }

    public class ElectricTruckTire : ITire
    {
        public string GetTireTYpe()
        {
            return "Electric Truck Tire";
        }
    }

    public class GasTruckEngine : IEngine
    {
        public string GetEngineType()
        {
            return "Gas Truck Engine";
        }
    }

    public class GasTruckTire : ITire
    {
        public string GetTireTYpe()
        {
            return "Gas Truck Tire";
        }
    }


    public interface IVehicleFactory
    {
        IEngine CreateEngine();
        ITire CreateTire();
    }

    public class ElectricCarFactory : IVehicleFactory
    {
        public IEngine CreateEngine() => new ElectricCarEngine();

        public ITire CreateTire() => new ElectricCarTire();
    }

    public class GasCarFactory : IVehicleFactory
    {
        public IEngine CreateEngine() => new GasCarEngine();

        public ITire CreateTire() => new GasCarTire();
    }

    public class ElectricTruckFactory : IVehicleFactory
    {
        public IEngine CreateEngine() => new ElectricTruckEngine();

        public ITire CreateTire() => new ElectricTruckTire();
    }

    public class GasTruckFactory : IVehicleFactory
    {
        public IEngine CreateEngine() => new GasTruckEngine();

        public ITire CreateTire() => new GasCarTire();
    }


    public class VehicleManufacturingPlant
    {
        private readonly IEngine engine;
        private readonly ITire tire;
        public VehicleManufacturingPlant(IVehicleFactory vehicleFactory)
        {
            engine = vehicleFactory.CreateEngine();
            tire = vehicleFactory.CreateTire();
        }

        public void DescribeVehicle()
        {
            Console.WriteLine($"Vehicle with Engine: {engine.GetEngineType} and Tire : {tire.GetTireTYpe}");
        }

    }
}
