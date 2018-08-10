namespace SynacorChallenge.Model
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