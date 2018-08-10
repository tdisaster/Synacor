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
			processor.Stack.Push(processor.Cursor + 2);
			processor.Cursor.Value = a.Value;
		}
	}
}