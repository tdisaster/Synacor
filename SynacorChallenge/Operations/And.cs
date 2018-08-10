using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class And : IOperation
	{
		public ushort Code { get; } = 12;
		public int Length { get; } = 4;

		public void Handle(Processor processor)
		{
			Number a = processor.GetNumber(processor.Cursor + 1);
			Number b = processor.GetNumber(processor.Cursor + 2);
			Number c = processor.GetNumber(processor.Cursor + 3);
			a.Value = (ushort) (b.Value & c.Value);

			processor.Cursor += Length;
		}
	}
}