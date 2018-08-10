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
			ushort val = b.Value;
			val = (ushort) (val << 1);
			val = (ushort) ~val ;
			val = (ushort)(val >> 1);

			a.Value = val;

			processor.Cursor += Length;
		}
	}
}