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
        public double amountOfCustomer1ToAttend = 0;
        public double amountOfCustomer2ToAttend = 0;
        public double amountOfCustomer3ToAttend = 0;
        public double amountOfCustomer4ToAttend = 0;
        public double amountOfCustomer5ToAttend = 0;
        public double amountOfCustomer6ToAttend = 0;
        public double amountOfCustomer7ToAttend = 0;
        public AttendanceList()
        {
            this.percentageOfCustomersAttended = (amountOfCustomersToAttend + amountOfCustomersToNotAttend) * (amountOfCustomersToAttend * .01);
        }
    }
}
