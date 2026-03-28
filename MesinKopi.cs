using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400040
{
    class MesinKopi
    {
        enum State { OFF, STANDBY, BREWING, MAINTANANCE }
        private State currentState = State.OFF;
        public void PowerOn()
        {
            if (currentState == State.OFF)
            {
                Console.WriteLine("Mesin OFF berubah menjadi Standby");
                currentState = State.STANDBY;
            }
            else
            {
                Invalid();
            }
        }
        public void PowerOff()
        {
            if (currentState == State.STANDBY)
            {
                Console.WriteLine("Mesin Standby berubah menjadi OFF");
                currentState = State.OFF;
            }
            else
            {
                Invalid();
            }
        }
        public void StartBrew()
        {
            if (currentState == State.STANDBY)
            {
                Console.WriteLine("Mesin Standby berubah berubah menjadi Brewing");
                currentState = State.BREWING;
            }
            else
            {
                Invalid();
            }
        }
        public void FinishBrew()
        {
            if (currentState == State.BREWING)
            {
                Console.WriteLine("Mesin Brewing berubah menjadi Standby");
                currentState = State.STANDBY;
            }
            else
            {
                Invalid();
            }
        }
        public void StartMaintenance()
        {
            if (currentState == State.STANDBY)
            {
                Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
                currentState = State.MAINTANANCE;
            }
            else
            {
                Invalid();
            }
        }
        public void FinishMaintenance()
        {
            if (currentState == State.MAINTANANCE)
            {
                Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
                currentState = State.STANDBY;
            }
            else
            {
                Invalid();
            }
        }
        private void Invalid()
        {
            Console.WriteLine("Perubahan state tidak valid");
        }
    }
}
