using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class JumpNotZero : IOperation
	{
		public ushort Code { get; } = 7;
		public int Length { get; } = 3;

		public void Handle(Processor processor)
		{
			Number a = processor.GetNumber(processor.Cursor + 1);
			Number b = processor.GetNumber(processor.Cursor + 2);
			if (a.Value != 0)
			{
				processor.Cursor.Value = b.Value;
			}
			else
			{
				processor.Cursor += Length;
			}
		}
	}
}