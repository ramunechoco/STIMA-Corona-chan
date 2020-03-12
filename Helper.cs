using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coronachan
{
    class Helper 
    {
        public static string[][] readFile(string path)
        {
           string[] array = System.IO.File.ReadAllLines(path);
           string[][] filetext = new string[array.Length][];
           for (int i = 0; i < filetext.Length; i++)
            {
                filetext[i] = array[i].Split(' ');
            }
           return filetext;
        }
        public static Vertex[] readGraph(string[][] argone, string[][] argtwo)
        {
            Vertex[] vertices = new Vertex[Int16.Parse(argtwo[0][0])];
            for (int a = 0; a < vertices.Length; a++)
            {
                vertices[a] = new Vertex();
            }
            vertices[0].set_name(argtwo[0][1]);
            int j = 1;
            Boolean pop_found = false;
            while (j <= vertices.Length && pop_found == false)
            {
                if (argtwo[j][0] == vertices[0].get_name())
                {
                    vertices[0].set_population(Int16.Parse(argtwo[j][1]));
                    pop_found = true;
                }
                j++;
            }
            for (int i = 1; i <= vertices.Length; i++)
            {
                if (argtwo[i][0] != vertices[0].get_name())
                {
                   if (i <= (j - 1))
                    {
                        vertices[i].set_name(argtwo[i][0]);
                        vertices[i].set_population(Int16.Parse(argtwo[i][1]));
                    }
                   else
                    {
                        vertices[i-1].set_name(argtwo[i][0]);
                        vertices[i-1].set_population(Int16.Parse(argtwo[i][1]));
                    }
                }
            }
            for (int k = 0; k < vertices.Length; k++)
            {
                var tupleList = new List<Tuple<string, double>>();
                for (int l = 1; l <= Int16.Parse(argone[0][0]); l++)
                {
                    if (argone[l][0] == vertices[k].get_name())
                    {
                        tupleList.Add(new Tuple<string, double>(argone[l][1], Convert.ToDouble(argone[l][2].Replace('.',','))));
                    }
                }
                vertices[k].set_adjlist(tupleList);
            }
            return vertices;
        }
    }
}