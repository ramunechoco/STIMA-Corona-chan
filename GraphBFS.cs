using System;
using System.Collections.Generic;
using System.Linq;
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
        public string GetName()
        {
            return name;
        }
        public Tonari GetAdjlist()
        {
            return adjlist;
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
            Console.WriteLine("Visiting " + adjlist[start].GetName());
            queue.Enqueue(start);

            while(queue.Count != 0){
                int v = queue.Dequeue();
                for(Tonari k = adjlist[v].GetAdjlist(); k != null; k = k.next){
                    int vnum = k.vertexNum;

                    if(!visited[vnum]){
                        Console.WriteLine("Visiting " + adjlist[vnum].GetName());
                        visited[vnum] = true;
                        queue.Enqueue(vnum);
                    }
                }
            }
        }
    }
}