using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coronachan;

namespace bfs{
    class Vertex{
        String name;//City
        private int population;//Population 
        private int time_f;//Time
        private List<Tuple<Vertex, double>> adjlist; //Tr(A,...)

        Vertex(String name,List<Tuple<Vertex,double>> adjlist,int population,int time_f){
            this.name = name;
            this.adjlist = adjlist;
            this.population = population;
            this.time_f = time_f;
        }

        Vertex(String name, List<Tuple<Vertex, double>> adjlist){
            this.name = name;
            this.adjlist = adjlist;
            this.population = 0;
            this.time_f = 0;
        }

        public int time_if(int t){
            return t - this.time_f;
        }

        public void set_time_f(int t){
            this.time_f = t;
        }

        public void set_adjlist(List<Tuple<Vertex, double>> adjlist)
        {
            this.adjlist = adjlist;
        }

        public List<Tuple<Vertex, double>> get_adjlist()
        {
            return this.adjlist;
        }

        public int get_time_f(){
            return this.time_f;
        }

        public void set_population(int pop){
            this.population = pop;
        }

        public int get_population(){
            return this.population;
        }

        public void set_name(string name){
            this.name = name;
        }

        public string get_name(){
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
            double upperlevel;
            double lowerlevel;
            upperlevel = (cityA.get_population() * cityA.adjlist.Item2) - 1;
            lowerlevel = cityA.get_population() - 1;

            double result = -4 * Math.Log(upperlevel / lowerlevel);
            return result;
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

    public class graph{
        Vertex[] adjlist;
        public void bfs(){
            Queue<Int32> queue = new Queue<int>();
            bool[] visited = new bool[adjlist.Length];
            for (int v = 0; v < visited.Length; v++){
                if(!visited[v]){
                    bfs(v,visited,queue);
                }
            }
        }
        private void bfs(int start,bool[] visited,Queue<Int32> queue){
            visited[start] = true;
            Console.WriteLine("Visiting " + adjlist[start].get_name());
            queue.Enqueue(start);

            while(queue.Count != 0){
                int v = queue.Dequeue();
                    int vnum = (int) adjlist.adjlist.Item2;

                    if(!visited[vnum] && adjlist.transferRate(adjlist[v])){
                        Console.WriteLine("Visiting " + adjlist[v].get_name());

                        visited[vnum] = true;
                        queue.Enqueue(vnum);
                    }
                }
            }
        }
    }
}

