using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class Not : IOperation
	{
		public ushort Code { get; } = 14;
		public int Length { get; } = 3;

		public void Handle(Processor processor)
		{
			Number a = processor.GetNumber(processor.Cursor + 1);
			Number b = processor.GetNumber(processor.Cursor + 2);
			a.Value = (ushort) ((b.Value ^ b.Value) % Number.ARegister);

			processor.Cursor += Length;
		}
	}
}