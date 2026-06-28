using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{    
    class Door
    {
        public event Action OnDoorOpened;         // Creating an event

        public void OpenDoor()
        {
            Console.WriteLine("Door is opened");

            OnDoorOpened?.Invoke() ;             // Invoking the event
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();

            door.OnDoorOpened += LightOn;           // Subscribing
            door.OnDoorOpened += PlayWelcomeSound;  // Multiple subscribers

            Console.WriteLine("\n First Open: ");
            door.OpenDoor();

            door.OnDoorOpened -= PlayWelcomeSound;  // UnSubscribing
            Console.WriteLine("\n Second Open: ");
            door.OpenDoor();

            Console.ReadLine();
        }

        static void LightOn()
        {
            Console.WriteLine("Light turned on. ");
        }

        static void PlayWelcomeSound()
        {
            Console.WriteLine("Welcome sound played. ");
        }
    }
}
