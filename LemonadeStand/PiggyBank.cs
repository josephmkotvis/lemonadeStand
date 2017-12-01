using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class PiggyBank
    {
        Store store;

        public double money = 100;
        public double gainedMoney = 0;
        public double preGameMoney;
        public double totalGainedMoney;
        public PiggyBank(Store store)
        {
            this.store = store;
        }
        public void DeductMoneyForItem1()
        {
            money -= store.item1Cost;
        }
        public void DeductMoneyForItem2()
        {
            money -= store.item2Cost;
        }
        public void DeductMoneyForItem3()
        {
            money -= store.item3Cost;
        }
        public void DeductMoneyForItem4()
        {
            money -= store.item4Cost;
        }
        public void DeductMoneyForItem1Bundle1()
        {
            money -= store.item1Bundle1Cost;
        }
        public void DeductMoneyForItem1Bundle2()
        {
            money -= store.item1Bundle2Cost;
        }
        public void DeductMoneyForItem1Bundle3()
        {
            money -= store.item1Bundle3Cost;
        }
        public void DeductMoneyForItem2Bundle1()
        {
            money -= store.item2Bundle1Cost;
        }
        public void DeductMoneyForItem2Bundle2()
        {
            money -= store.item2Bundle2Cost;
        }
        public void DeductMoneyForItem2Bundle3()
        {
            money -= store.item2Bundle3Cost;
        }
        public void DeductMoneyForItem3Bundle1()
        {
            money -= store.item3Bundle1Cost;
        }
        public void DeductMoneyForItem3Bundle2()
        {
            money -= store.item3Bundle2Cost;
        }
        public void DeductMoneyForItem3Bundle3()
        {
            money -= store.item3Bundle3Cost;
        }
        public void DeductMoneyForItem4Bundle1()
        {
            money -= store.item4Bundle1Cost;
        }
        public void DeductMoneyForItem4Bundle2()
        {
            money -= store.item4Bundle1Cost;
        }
        public void DeductMoneyForItem4Bundle3()
        {
            money -= store.item4Bundle3Cost;
        }
    }
}
