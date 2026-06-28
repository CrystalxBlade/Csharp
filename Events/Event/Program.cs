using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{    
    class Door
    {
        public event Action OnDoorOpened;

        public void OpenDoor()
        {
            Console.WriteLine("Door is opened");

            OnDoorOpened?.Invoke() ;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();

            door.OnDoorOpened += LightOn;
            door.OnDoorOpened += PlayWelcomeSound;

            Console.WriteLine("\n First Open: ");
            door.OpenDoor();

            door.OnDoorOpened -= PlayWelcomeSound;
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
