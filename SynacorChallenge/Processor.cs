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

		public Processor(byte[] mem)
		{
			Memory = new Memory(mem);
			Cursor = new Number(Memory, 0);
		}

		public Stack Stack { get; } = new Stack();

		public Memory Memory { get; }
		public bool Stopped { get; set; } = false;

		public Number Cursor;

		public Number GetNumber(Number address)
		{
			return Memory.Get(address);
		}
	}
}