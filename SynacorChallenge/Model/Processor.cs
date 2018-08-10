using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynacorChallenge.Model
{
	public class Processor
	{
		public Processor()
		{
			Memory = new Memory();
		}

		public Processor(byte []mem)
		{
			Memory = new Memory(mem);
		}
		public List<Number> Stack { get; } = new List<Number>();

		public Memory Memory { get; }
		public bool Stopped { get; set; } = false;

		public Number Cursor = new Number(0);

		public Number GetNumber(Number address)
		{
			return Memory.Get(address);
		}
	}
}
