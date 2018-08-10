using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class Push : IOperation
	{
		public ushort Code { get; } = 2;
		public int Length { get; } = 2;

		public void Handle(Processor processor)
		{
			Number a = processor.GetNumber(processor.Cursor + 1);
			processor.Stack.Push(a);
			processor.Cursor += Length;
		}
	}
}