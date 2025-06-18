using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensors.sensorsTypes
{
    internal class MotionSensor:Sensor
    {

        public sensorTypeEnum Type;
        public int Disability { get; set; }
        public bool IsActive { get; set; }



        public MotionSensor(sensorTypeEnum type)
        {
            this.Type = type;
            this.Disability = 3;
            this.IsActive = true;
        }


        public void Activate()
        {
            if (this.Disability == 0)
            {
                IsActive = false;
            }
        }


    }
}
