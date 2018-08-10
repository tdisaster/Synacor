namespace SynacorChallenge.Model
{
	public interface IOperation
	{
		ushort Code { get; }

		int Length { get; }
		void Handle(Processor processor);
	}
}