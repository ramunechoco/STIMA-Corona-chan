using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coronachan
{
    class Vertex
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

        public double infectedF(Vertex cityA)
        {
            double time1 = (double)cityA.get_time_f();

            double upperlevel;
            double lowerlevel;

            upperlevel = cityA.get_population();
            lowerlevel = 1 + (cityA.get_population() - 1) * Math.Exp(time1 * (-1) / 4);

            double infectedF = upperlevel / lowerlevel;

            return infectedF;
        }

        public double timeTransfer(Vertex cityA)
        {
            List<Tuple<string, double>> list = new List<Tuple<string, double>>();
            list = cityA.get_adjlist();
            int index = list.FindIndex(t => t.Item1 == get_name());
            double upperlevel;
            double lowerlevel;
            upperlevel = (cityA.get_population() * list[index].Item2) - 1;
            lowerlevel = cityA.get_population() - 1;

            double result = -4 * Math.Log(upperlevel / lowerlevel);
            return result;
        }

        public Vertex[] timeAnother(Vertex[] city) //???
        {
            Vertex[] cityA = new Vertex[city.Length];
            List<Tuple<string, double>> list = new List<Tuple<string, double>>();
            int i = 0;
            list = cityA[i].get_adjlist();
            int index = list.FindIndex(t => t.Item1 == get_name());
            while (i < cityA.Length)
            {
                int j = 0;
                double time = Math.Floor(timeTransfer(cityA[i])) + 1;
                if (cityA[j].get_name() == list[index].Item1)
                {
                    cityA[j].time_if((int)time);
                    index++;
                    j = 0;
                }
                else if(cityA[j].get_name() != list[index].Item1 && index < list.Count)
                {
                    j++;
                }
                else
                {
                    i++;
                    if(i < cityA.Length)
                    {
                        list = cityA[i].get_adjlist();
                        index = list.FindIndex(t => t.Item1 == get_name());
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return cityA;
        }
        public bool transferRate(Vertex cityA)
        {//S(A,B)
            bool infected = false;
            double transferRate = timeTransfer(cityA);

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

    public class graph
    {
        Vertex[] adjlist;
        public void bfs()
        {
            Queue<Int32> queue = new Queue<int>();
            bool[] visited = new bool[adjlist.Count()];
            for (int v = 0; v < visited.Length; v++)
            {
                if (!visited[v])
                {
                    bfs(v, visited, queue);
                }
            }
        }
        private void bfs(int start, bool[] visited, Queue<Int32> queue)
        {
            visited[start] = true;
            List<Tuple<string, double>> list = new List<Tuple<string, double>>();

            //Console.WriteLine("Visiting " + adjlist[start].get_name());
            queue.Enqueue(start);

            while (queue.Count != 0)
            {
                list = adjlist[start].get_adjlist();
                int v = queue.Dequeue();

                if (!visited[v] && adjlist[v].transferRate(adjlist[v]))
                {
                    //Console.WriteLine("Visiting " + adjlist[v].get_name());

                    visited[v] = true;
                    queue.Enqueue(v);
                }
            }
        }
    }
}


