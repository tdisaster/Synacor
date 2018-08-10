using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class Call: IOperation
	{
		public ushort Code { get; } = 17;
		public int Length { get; } = 2;

		public void Handle(Processor processor)
		{
			Number a = processor.GetNumber(processor.Cursor + 1);
			Number b = processor.GetNumber(processor.Cursor + 2);
			processor.Stack.Push(b);
			processor.Cursor.Value = a.Value;
		}
	}
}