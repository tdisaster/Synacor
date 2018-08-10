using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SynacorChallenge.Model
{
	public class Stack
	{
		public Memory Memory { get; set; }

		public Stack(Memory mem)
		{
			Memory = mem;
		}

		public List<ushort> Values = new List<ushort>();

		public void Push(Number val)
		{
			Values.Add(val.Value);
		}

		public Number Pop()
		{
			var number = Values[Values.Count - 1];
			Values.RemoveAt(Values.Count - 1);
			return new Number(Memory, number);
		}
	}
}