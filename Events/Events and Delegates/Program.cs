using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    public delegate void DoorEventHandler();

    class Door
    {
        public event DoorEventHandler OnDoorOpened;

        public void OpenDoor()
        {
            Console.WriteLine("Door is opened");

            OnDoorOpened?.Invoke();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();

            door.OnDoorOpened += LightsOn;
            door.OnDoorOpened += WelcomeSound;

            door.OpenDoor();
            Console.ReadLine();
        }

        static void LightsOn()
        {
            Console.WriteLine("Lights turned on");
        }
        static void WelcomeSound()
        {
            Console.WriteLine("Welcome sound played");
        }
    }
}
