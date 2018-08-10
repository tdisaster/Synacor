using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class Stop : IOperation
	{
		public ushort Code { get; } = 0;
		public int Length { get; } = 1;

		public void Handle(Processor processor)
		{
			processor.Stopped = true;
		}
	}
}