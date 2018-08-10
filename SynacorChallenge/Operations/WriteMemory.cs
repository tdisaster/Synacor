using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class WriteMemory : IOperation
	{
		public ushort Code { get; } = 16;
		public int Length { get; } = 3;

		public void Handle(Processor processor)
		{
			Number a = processor.GetNumber(processor.Cursor + 1);
			Number b = processor.GetNumber(processor.Cursor + 2);
			processor.Memory.Set(a, b);
			processor.Cursor += Length;
		}
	}
}