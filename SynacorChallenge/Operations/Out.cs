using System;
using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class Out : IOperation
	{
		public ushort Code { get; } = 19;
		public int Length { get; } = 2;

		public void Handle(Processor processor)
		{
			Number character = processor.GetNumber(processor.Cursor + 1);
			Console.Write(Convert.ToChar(character.Value));
			processor.Cursor += Length;
		}
	}
}