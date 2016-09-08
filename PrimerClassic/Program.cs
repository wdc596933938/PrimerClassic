using System;
using System.Collections;
using System.Timers;

namespace PrimerClassic
{
    class Program
    {
        static void Main()
        {
            ArrayList ar = new ArrayList(50);
            int index = 0;
            Random ran = new Random();
            for (int i = 0; i < 50; i++)
            {
                ar.Add(ran.Next(100));
            }
            for (int i = 0; i < 50; i++)
            {
                index = ran.Next(50 - i);
                ar.RemoveAt(index);
            }

            Connection myConnection = new Connection();
            Display myDisplay = new Display();
            myConnection.MessageArrived +=
            new MessageHandler(myDisplay.DisplayMessage);
            myConnection.Connect();
            Console.ReadKey();
            myConnection.Disconnect();
        }

    }
}