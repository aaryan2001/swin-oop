using System;

namespace helloworld
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Message myMessage;
            Message[] mssg = new Message[4];
            string name;

            myMessage = new Message("Hello World");
            myMessage.Print();


            mssg[0] = new Message("wow nice name");
            mssg[1] = new Message("great name");
            mssg[2] = new Message("ok name");
            mssg[3] = new Message("SILLY NAME BOO!");

            Console.WriteLine("Name: ");
            name = Console.ReadLine();

            if (name.ToLower() == "aaryan")
            {
                mssg[0].Print();
            }
            else if (name.ToLower() == "nishta")
            {
                mssg[1].Print();
            }
            else if (name.ToLower() == "kartik")
            {
                mssg[2].Print();
            }
            else
            {
                mssg[3].Print();
            }

            Console.ReadLine();
        }
    }
}