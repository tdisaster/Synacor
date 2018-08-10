using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class NoOperation : IOperation
	{
		public ushort Code { get; } = 21;
		public int Length { get; } = 1;

		public void Handle(Processor processor)
		{
			processor.Cursor += Length;
		}
	}
}