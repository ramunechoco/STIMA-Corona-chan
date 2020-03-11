using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coronachan;

namespace bfs{
    class Vertex{
        String name;//City
        Tonari adjlist;//Tr...
        private int population;//Population 
        private int time_f;//Time
        
        Vertex(String name,Tonari adjlist,int population,int time_f){
            this.name = name;
            this.adjlist = adjlist;
            this.population = population;
            this.time_f = time_f;
        }

        Vertex(String name,Tonari adjlist){
            this.name = name;
            this.adjlist = adjlist;
            this.population = 0;
            this.time_f = 0;
        }

        public string get_name()
        {
            return this.name;
        }

        public int time_if(int t){
            return t - this.time_f;
        }

        public void set_time_f(int t){
            this.time_f = t;
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

        public Tonari get_adjlist()
        {
            return this.adjlist;
        }
    }

    class Tonari{
        public double transmission; //Tr(A,...)
        public Tonari next;
        
        public Tonari(int vnum,Tonari k){
            this.transmission = vnum;
            next = k;
        }

        public double infectedPeople(Vertex cityA){//-->I(P(A),T(A))
            double time1 = (double) cityA.get_time_f();
            double infected = cityA.get_population() * time1 / 20;
            return infected;
        }

        public double infectedF(Vertex cityA){
            double time1 = (double) cityA.get_time_f();
            
            double upperlevel;
            double lowerlevel;

                upperlevel = cityA.get_population();
                lowerlevel = 1 + (cityA.get_population() - 1) * Math.Exp(time1 * (-1) / 4);

                double infectedF = upperlevel/lowerlevel;

            return infectedF;
        }

        private static bool transferRate(Vertex cityA){//S(A,B)
            bool infected = false;
            double transferRate = cityA.get_adjlist().transmission * infectedPeople(cityA);

            if(transferRate < 1){
                infected = true;
            }
            else{
                infected = false;
            }

            return infected;
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
                for(Tonari k = adjlist[v].get_adjlist(); k != null; k = k.next){
                    int vnum = (int) k.transmission;

                    if(!visited[vnum] && transferRate(adjlist[v])){
                        Console.WriteLine("Visiting " + adjlist[vnum].get_name());
                        visited[vnum] = true;
                        queue.Enqueue(vnum);
                    }
                }
            }
        }
    }
}
}
