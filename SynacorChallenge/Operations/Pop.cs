using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class Pop : IOperation
	{
		public ushort Code { get; } = 3;
		public int Length { get; } = 2;

		public void Handle(Processor processor)
		{
			Number a = processor.GetNumber(processor.Cursor + 1);
			var nr = processor.Stack.Pop();
			a.Value = nr.Value;
			processor.Cursor += Length;
		}
	}
}