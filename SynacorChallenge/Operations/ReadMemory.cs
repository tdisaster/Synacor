using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class ReadMemory : IOperation
	{
		public ushort Code { get; } = 15;
		public int Length { get; } = 3;

		public void Handle(Processor processor)
		{
			Number a = processor.GetNumber(processor.Cursor + 1);
			Number b = processor.GetNumber(processor.Cursor + 2);
			a.Value = processor.Memory.Get(b).Value;
			processor.Cursor += Length;
		}
	}
}