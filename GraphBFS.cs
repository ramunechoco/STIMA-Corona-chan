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
    }

    class Tonari{
        public double transmission; //Tr(A,...)
        public Tonari next;
        
        public Tonari(int vnum,Tonari k){
            this.transmission = vnum;
            next = k;
        }

        public static double infectedPeople(Vertex cityA){//-->I(P(A),T(A))
            double time1 = (double) cityA.time_f;
            double infected = cityA.population * time1 / 20;
            return infected;
        }

        public static double infectedF(Vertex cityA){
            double time1 = (double) cityA.time_f;
            
            double upperlevel;
            double lowerlevel;

                upperlevel = cityA.population;
                lowerlevel = 1 + (cityA.population - 1) * Math.Exp(time1 * (-1) / 4);

                double infectedF = upperlevel/lowerlevel;

            return infectedF;
        }

        public double timeTransfer(Vertex cityA){
            double upperlevel;
            double lowerlevel;

            upperlevel = (cityA.population * cityA.adjlist.transmission) - 1;
            lowerlevel =  cityA.population - 1;

            double result = -4 * Math.Log(upperlevel/lowerlevel);
            return result;
        }

        public static bool transferRate(Vertex cityA){//S(A,B)
            bool infected = false;
            double transferRate = timeTransfer(cityA);

            if(transferRate <= 1){
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
            Queue<Int32> queue = new Queue<Int>();
            bool[] visited = new bool[adjlist.length];
            for (int v = 0; v < visited.length; v++){
                if(!visited[v]){
                    bfs(v,visited,queue);
                }
            }
        }

        private void bfs(int start,bool[] visited,Queue<Int32> queue){
            visited[start] = true;
            Console.Writeln("Visiting " + adjlist[start].name);
            queue.Enqueue(start);

            while(!queue.IsEmpty()){
                int v = queue.Dequeue();
                for(Tonari k = adjlist[v].adjlist; k != null; k = k.next){
                    int vnum = k.transmission;


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
