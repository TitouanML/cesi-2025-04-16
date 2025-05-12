using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Exercice01.Classes
{
    public class EmailService: IEmailService 
    {
        public void sendEmail(string message)
        {
            Console.WriteLine($"Email envoyé : {message}");
        }
    }

}
