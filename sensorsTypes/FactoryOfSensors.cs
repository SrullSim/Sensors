using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors.sensorsTypes
{
    internal static class FactoryOfSensors
    {
        public static Sensor CreateSensor(sensorTypeEnum type)
        {
            switch (type)
            { 
                case sensorTypeEnum.Thermal:
                    return new ThermalSensor(type);

                case sensorTypeEnum.Motion:
                    return new MotionSensor( type);
                
                case sensorTypeEnum.Audio:
                    return new AudioSensor( type);
                
                case sensorTypeEnum.Pulse:
                    return new PulseSensor( type);
                
                case sensorTypeEnum.Magnetic:
                    return new MagneticSensor( type);
                
                case sensorTypeEnum.Signal:
                     return new SignalSensor( type);
                
                case sensorTypeEnum.Light:
                    return new LightSensor( type);
                
                default:
                    throw new ArgumentException("Unknown sensor type");
            }
        }





    }
}
