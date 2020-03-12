using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coronachan
{
    public class Vertex
    {
        String name;//City
        private int population;//Population 
        private int time_f;//Time
        private List<Tuple<string, double>> adjlist; //Tr(A,...)

        Vertex(String name, List<Tuple<string, double>> adjlist, int population, int time_f)
        {
            this.name = name;
            this.adjlist = adjlist;
            this.population = population;
            this.time_f = time_f;
        }

        Vertex(String name, List<Tuple<string, double>> adjlist)
        {
            this.name = name;
            this.adjlist = adjlist;
            this.population = 0;
            this.time_f = 0;
        }

        public Vertex()
        {
            this.name = "noname";
            this.adjlist = new List<Tuple<string, double>>();
            this.population = 0;
            this.time_f = 0;
        }

        public int time_if(int t)
        {
            return t - this.time_f;
        }

        public void set_time_f(int t)
        {
            this.time_f = t;
        }

        public void set_adjlist(List<Tuple<string, double>> adjlist)
        {
            this.adjlist = adjlist;
        }

        public List<Tuple<string, double>> get_adjlist()
        {
            return this.adjlist;
        }

        public int get_time_f()
        {
            return this.time_f;
        }

        public void set_population(int pop)
        {
            this.population = pop;
        }

        public int get_population()
        {
            return this.population;
        }

        public void set_name(string name)
        {
            this.name = name;
        }

        public string get_name()
        {
            return this.name;
        }

        public int infectedF(int T)
        {
            double time1 = T - this.get_time_f();

            double upperlevel;
            double lowerlevel;

            upperlevel = this.get_population();
            lowerlevel = 1 + (this.get_population() - 1) * Math.Exp(time1 * (-1) / 4);

            int infectedF = (int) (upperlevel / lowerlevel);

            return infectedF;
        }

        public void timeTransfer(Vertex cityA)
        {
            List<Tuple<string, double>> list = new List<Tuple<string, double>>();
            list = cityA.get_adjlist();
            int index = list.FindIndex(t => t.Item1 == this.name);
            double upperlevel;
            double lowerlevel;
            upperlevel = (cityA.get_population() * list[index].Item2) - 1;
            lowerlevel = cityA.get_population() - 1;

            double result = -4 * Math.Log(upperlevel / lowerlevel);
            int floor = (int) Math.Floor(result) + 1;
            this.time_f = floor;
        }

        public bool transferRate(Vertex cityB, int T)
        {//S(A,B)
            bool infected = false;
            List<Tuple<string, double>> list = new List<Tuple<string, double>>();
            list = this.adjlist;
            int index = list.FindIndex(t => t.Item1 == cityB.get_name());
            double transferRate = this.infectedF(T) * list[index].Item2;

            if (transferRate <= 1)
            {
                infected = true;
            }
            else
            {
                infected = false;
            }

            return infected;
        }
    }

    public class graphvertex
    {
        private Vertex[] adjlist;
        private bool[] infspread;
        private int T;
        public graphvertex(Vertex[] vertices, int T)
        {
            this.adjlist = vertices;
            this.infspread = new bool[adjlist.Length];
            for (int i = 0; i < infspread.Length; i++)
            {
                infspread[i] = false;
            }
            this.T = T;
        }
        public Vertex[] get_vertices()
        {
            return this.adjlist;
        }

        public bool[] get_infspread()
        {
            return this.infspread;
        }
        public void bfs()
        {
            Queue<Tuple<string, string>> queue = new Queue<Tuple<string, string>>();
            for (int i = 0; i < adjlist[0].get_adjlist().Count; i++)
            {
                string nameone = adjlist[0].get_name();
                string nametwo = adjlist[0].get_adjlist()[i].Item1;
                queue.Enqueue(Tuple.Create(nameone, nametwo));
            }
            while (queue.Count != 0)
            {
                Tuple<string, string> tuple = queue.Dequeue();
                Vertex A = this.adjlist.FirstOrDefault(o => o.get_name() == tuple.Item1);
                Vertex B = this.adjlist.FirstOrDefault(o => o.get_name() == tuple.Item2);
                int idx = Array.IndexOf(this.adjlist, B);
                if (A.transferRate(B, this.T) && !this.infspread[idx])
                {
                    B.timeTransfer(A);
                    for (int i = 0; i < B.get_adjlist().Count; i++)
                    {
                        string nameone = B.get_name();
                        string nametwo = B.get_adjlist()[i].Item1;
                        queue.Enqueue(Tuple.Create(nameone, nametwo));
                    }
                }
            }
        }
    }
}
