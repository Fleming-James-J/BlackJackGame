//James Fleming
//CS-021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_Skills_Demo_5
{
    class Player : Person
    {
        //Global Variable
        private int RunningTotal;

        //Constructor
        public Player()
        {
            this.RunningTotal = 0;
        }

        //Getters and Setters
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
