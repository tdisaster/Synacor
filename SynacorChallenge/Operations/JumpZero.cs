using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class JumpZero : IOperation
	{
		public ushort Code { get; } = 8;
		public int Length { get; } = 3;

		public void Handle(Processor processor)
		{
			Number a = processor.GetNumber(processor.Cursor + 1);
			Number b = processor.GetNumber(processor.Cursor + 2);
			if (a.Value == 0)
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