//James Fleming
//CS-021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_Skills_Demo_5
{
    class Dealer : Person
    {
        //Global Variables
        private int RunningTotal;
        
        //constructor
        public Dealer()
        {
            this.RunningTotal = 0;
        }

        //getters and setters
        public void setRunningTotal(int runningTotalIn)
        {
            this.RunningTotal = runningTotalIn;
        } 

        public int getRunningTotal()
        {
            return this.RunningTotal;
        }

        //Behaviours
        public void increaseTotal(int Amount)
        {
            this.RunningTotal = RunningTotal + Amount;
        }
    }
}
