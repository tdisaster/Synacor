using System;

namespace SynacorChallenge.Model
{
	public class Out : IOperation
	{
		public ushort Code { get; } = 19;
		public int Length { get; } = 2;

		public void Handle(Processor processor)
		{
			Console.Write('a');
		}
	}
}