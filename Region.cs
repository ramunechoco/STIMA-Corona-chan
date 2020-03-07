using System;

namespace Coronachan
{
    class Region
    {
        string name;//string nama obyek Region
        int full_pop;//populasi total (konstan)
        int time_first;//waktu pertama kali infeksi
        int time_since;//waktu sejak infeksi
        public Region(string title, int full, int inf, int inf_time, int time_after)
        {
            name = title; 
            full_pop = full; 
            time_first = inf_time;
            time_since = time_after;
        }
        public Region(string title)
        {
            name = title;
            full_pop = 0;
            time = 0;
            time_since = 0;
        }
        public void setPop(int pop)
        {
            full_pop = pop;
        }
        public int getPop()
        {
            return full_pop;
        }
        public void getTime(int t)
        {
            time = 
        }
        public int infPop()
        {
            double result = full_pop / (1 + (Math.Exp(time_since * -0.25) * (full_pop - 1)));
            return (int)result;
        }
        public bool spread(int trip, Region B)
        {
            return (infPop() * trip) > 1;
        }

    }
}
