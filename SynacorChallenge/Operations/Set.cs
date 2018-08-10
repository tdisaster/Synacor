using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class Set : IOperation
	{
		public ushort Code { get; } = 1;
		public int Length { get; } = 3;

		public void Handle(Processor processor)
		{
			Number a = processor.GetNumber(processor.Cursor + 1);
			Number b = processor.GetNumber(processor.Cursor + 2);
			a.Value = b.Value;
			processor.Cursor += Length;
		}
	}
}