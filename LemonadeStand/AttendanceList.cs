using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class AttendanceList
    {
        public double amountOfCustomersToAttend = 0;
        public double amountOfCustomersToNotAttend = 0;
        public dynamic percentageOfCustomersAttended;
        public dynamic amountOfAllCustomersToAttend =0;
        public AttendanceList()
        {
            this.percentageOfCustomersAttended = (amountOfCustomersToAttend + amountOfCustomersToNotAttend) * (amountOfCustomersToAttend * .01);
        }
    }
}
