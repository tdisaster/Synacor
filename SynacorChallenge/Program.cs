using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynacorChallenge.Model;

namespace SynacorChallenge
{
	class Program
	{
		static void Main(string[] args)
		{
			var filePath = "Resources/challenge.bin";
			var fs = new FileStream(filePath,FileMode.Open);
			var reader = new BinaryReader(fs);
			byte[] bytes = reader.ReadBytes((int) fs.Length);

			var runner = new Runner(new Processor(bytes));
			runner.Run();

			Console.ReadKey();
		}
	}
}
