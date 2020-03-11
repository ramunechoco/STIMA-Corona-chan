using System;
using bfs;

namespace Coronachan
{
    class Helper 
    {
        string[][] readFile(string path)
        {
           string[] array = System.IO.File.ReadAllLines(path);
           string[][] filetext = new string[array.Length][];
           for (int i = 0; i < filetext.Length; i++)
            {
                filetext[i] = array[i].Split(' ');
            }
           return filetext;
        }
        Vertex[] readGraph(string[][] argone, string[][] argtwo)
        {
            Vertex[] vertices = new Vertex[Int16.Parse(argtwo[0][0])];
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
            for (int i = 1; i < vertices.Length; i++)
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
            return vertices;
        }
    }
}