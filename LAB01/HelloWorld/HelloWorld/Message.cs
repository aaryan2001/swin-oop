using System;


namespace helloworld
{
    public class Message
    {
        private string text;

        public Message(string txt)
        {
            text = txt;
        }

        public void Print()
        {
            Console.WriteLine(text);
        }
    }
}
