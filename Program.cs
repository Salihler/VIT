using System;

namespace VIT
{
    class Program
    {
        static void Main(string[] args)
        {
            MailService _service = new MailService();
            try
            {
                _service.SendAcci();
            }
            finally
            {
                
                Console.ReadLine();
            }

        }
    }
}
