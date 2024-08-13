using Single.Responsiblity.Principal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single.Responsiblity.Principal
{
    // EmailSender class (responsibility: sending emails)
    public class EmailSender
    {
        public void SendEmail(Employee employee)
        {
            //SMTP details
            // Send email to employee's email address
            Console.WriteLine("Sending email to " + employee.EmailAddress);
        }
    }
}
