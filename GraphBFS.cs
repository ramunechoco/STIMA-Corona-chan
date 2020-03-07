using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace bfs{
    class Vertex{
        String name;
        Tonari adjlist;
        Vertex(String name,Tonari adjlist){
            this.name = name;
            this.adjlist = adjlist;
        }
    }

    class Tonari{
        public int vertexNum;
        public Tonari next;
        public Tonari(int vnum,Tonari k){
            this.vertexNum = vnum;
            next = k;
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
            visited[start] = true;
            Console.Writeln("Visiting " + adjlist[start].name);
            queue.Enqueue(start);

            while(!queue.IsEmpty()){
                int v = queue.Dequeue();
                for(Tonari k = adjlist[v].adjlist; k !== null; k = k.next){
                    int vnum = k.vertexNum;

                    if(!visited[vnum]){
                        Console.Writeln("Visiting " + adjlist[vnum].name);
                        visited[vnum] = true;
                        queue.Enqueue(vnum);
                    }
                }
            }
        }
    }
}