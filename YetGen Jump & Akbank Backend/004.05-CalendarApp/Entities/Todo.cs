using _004._05_CalendarApp.Abstract;
using _004._05_CalendarApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004._05_CalendarApp.Entities
{
    internal class Todo:Event, INotification
    {
        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($"Time to make this To-Do: {Title}");
        }
    }
}
