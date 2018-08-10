namespace SynacorChallenge.Model
{
	public class NoOperation : IOperation
	{
		public ushort Code { get; } = 21;
		public int Length { get; } = 1;

		public void Handle(Processor processor)
		{
		}
	}
}