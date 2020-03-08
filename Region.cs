using System;

namespace Coronachan
{
    class Region
    {
        string name;//string nama obyek Region
        int full_pop;//populasi total (konstan)
        int time_first;//waktu pertama kali infeksi
        public Region(string title, int full, int inf_time)
        {
            name = title; 
            full_pop = full; 
            time_first = inf_time;
        }
        public Region(string title)
        {
            name = title;
            full_pop = 0;
            time_first = 0;
        }
        public void setPop(int pop)
        {
            full_pop = pop;
        }
        public int getPop()
        {
            return full_pop;
        }
        public void setTime(int t)
        {
            time_first = t;
        }
        public int getTime()
        {
            return time_first;
        }
        public int getTimeInf(int t)
        {
            return t - time_first;
        }
        public int infPop(int t)
        {
            int timeInf = getTimeInf(t);
            double result = full_pop / (1 + (Math.Exp(timeInf * -0.25) * (full_pop - 1)));
            return (int)result;
        }
        public bool spread(int trip, int infPop, Region B)
        {
            return (infPop * trip) > 1;
        }
    }
}
