using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class Return : IOperation
	{
		public ushort Code { get; } = 18;
		public int Length { get; } = 1;

		public void Handle(Processor processor)
		{
			var a = processor.Stack.Pop();
			processor.Cursor.Value = a.Value;
		}
	}
}