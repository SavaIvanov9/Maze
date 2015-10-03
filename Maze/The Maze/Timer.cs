/*
 * ********************************************
 * The Maze- A 2D console maze game in C#!
 * ********************************************
 * Created By: Antony Lloyd
 * http://only-antony.com
 * 
 * If any of this code is used, please give credit!
 * 
 * THIS CODE IS NOT YET COMPLETE AND IT IS BUGGY. FOR A LIST OF BUGS VISIT https://bitbucket.org/OnlyAntony/the-maze
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace The_Maze
{
    class Timer
    {
        public int Time = 15;

        public void ReduceTime()
        {
            while (true)
            {
                Time--;
                Thread.Sleep(1000);
            }
        }
    }
}
