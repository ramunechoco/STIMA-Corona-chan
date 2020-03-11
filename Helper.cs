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
        bfs.graph readGraph(string[][] arg)
        {

        }
    }
}