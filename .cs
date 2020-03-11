using System;

namespace Coronachan
{
	class FileReader
	{
		string[] readFile(string path)
		{
			var array = System.IO.File.ReadAllLines(path)
                .Select(line => line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(int.Parse)
                .ToArray();
            return array;
		} 
	}
}