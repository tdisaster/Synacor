using System.Collections.Generic;

namespace SynacorChallenge.Model
{
	public class Stack
	{
		public List<Number> Values = new List<Number>();

		public void Push(Number val)
		{
			Values.Add(val);
		}

		public Number Pop()
		{
			var number = Values[Values.Count - 1];
			Values.RemoveAt(Values.Count - 1);
			return number;
		}

		public Number Peek()
		{
			return Values[Values.Count - 1];
		}
	}
}