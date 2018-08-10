using System.Runtime.Remoting.Lifetime;
using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class Add : IOperation
	{
		public ushort Code { get; } = 9;
		public int Length { get; } = 4;

		public void Handle(Processor processor)
		{
			var dest = processor.GetNumber(processor.Cursor + 1);
			Number a = processor.GetNumber(processor.Cursor + 2);
			Number b = processor.GetNumber(processor.Cursor + 3);
			processor.Memory.Set(dest, a + b);

			processor.Cursor += Length;
		}
	}
}