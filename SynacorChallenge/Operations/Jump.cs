using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class Jump : IOperation
	{
		public ushort Code { get; } = 6;
		public int Length { get; } = 2;

		public void Handle(Processor processor)
		{
			Number a = processor.GetNumber(processor.Cursor + 1);
			processor.Cursor.Value = a.Value;
		}
	}
}