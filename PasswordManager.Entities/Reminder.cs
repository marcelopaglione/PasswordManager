using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Entities
{
    public class Reminder
    {
        public int ID { get; set; }
        public string ReminderText { get; set; }
        public DateTime ShowReminderDate { get; set; }
        public Password ReminderPassword { get; set; }
        public bool ReminderShown { get; set; }
    }
}
