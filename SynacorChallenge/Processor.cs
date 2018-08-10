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
			Stack = new Stack(Memory);
		}

		public Processor(byte[] mem) : base()
		{
			Memory = new Memory(mem);
			Stack = new Stack(Memory);
			Cursor = new Number(Memory, 0);
		}

		public Stack Stack { get; }

		public Memory Memory { get; }
		public bool Stopped { get; set; } = false;

		public Number Cursor;

		public Number GetNumber(Number address)
		{
			return Memory.Get(address);
		}
	}
}