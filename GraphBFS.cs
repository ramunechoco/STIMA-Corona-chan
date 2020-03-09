using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace bfs{
    class Vertex{
        String name;
        Tonari adjlist;
        private int population; 
        
        Vertex(String name,Tonari adjlist,int population){
            this.name = name;
            this.adjlist = adjlist;
            this.population = population;
        }
    }

    class Tonari{
        public int vertexNum; //-->Tr(...,...)
        public Tonari next;
        
        public Tonari(int vnum,Tonari k){
            this.vertexNum = vnum;
            next = k;
        }

        public double[] infectedPeople(Vertex[] cityA,int time){//-->I(P(A),T(A))
            double time1 = Convert.ToDouble(time);
            double infected = new double[cityA.length];

            for(int v = 0; v < cityA.length;v++){
                infected[v] = cityA[v].population * time1 / 20;
            }
            return infected;
        }

        public double infectedF(Vertex[] cityA,int time){
            double time1 = Convert.ToDouble(time);
            
            double upperlevel = new double[cityA.length];
            double lowerlevel = new double[cityA.length];

            for(int v = 0;v < cityA.length;v++){
                upperlevel[v] = cityA[v].population;
                lowerlevel[v] = 1 + (cityA[v].population - 1) * Math.Exp(time1 * (-1) / 4);
            }

            double infectedF = new double[cityA.length];

            for(int v = 0;v < cityA.length;v++){
                infectedF[v] = upperlevel[v]/lowerlevel[v];
            }

            return infectedF;
        }

        public Vertex[] transferRate(Vertex[] cityA,int time,Tonari k){//S(A,B)
            Vertex[] transferRate = new Vertex[cityA.length];
            bool finish;
            finish = false;
            while(!finish){
                for(k = cityA[v].adjlist;k != null; k = k.next){
                    transferRate[v].adjlist = infectedPeople(cityA,time) * k.vertexNum;
                    if(k != null){
                        continue;
                    }
                    else if(k == null && v < cityA.length){
                        v++;
                    }
                    else{
                        finish = true;
                    }
                }
            }

            return transferRate;
        }
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
            int time;
            visited[start] = true;
            Console.Writeln("Visiting " + adjlist[start].name);
            queue.Enqueue(start);

            while(!queue.IsEmpty()){
                int v = queue.Dequeue();
                for(Tonari k = adjlist[v].adjlist; k != null; k = k.next){
                    int vnum = k.vertexNum;

                    if(!visited[vnum] && transferRate(adjlist,time,k)){
                        Console.Writeln("Visiting " + adjlist[vnum].name);
                        visited[vnum] = true;
                        queue.Enqueue(vnum);
                    }
                }
            }
        }
    }
}
