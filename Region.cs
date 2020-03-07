using System;

namespace Coronachan
{
    class Region
    {
        string name;
        int full_pop;
        int time;
        int time_since;
        public Region(string title, int full, int inf, int time_total, int inf_time)
        {
            name = title;
            full_pop = full;
            time = time_total;
            time_since = inf_time;
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
