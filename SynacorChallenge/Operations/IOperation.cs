using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public interface IOperation
	{
		ushort Code { get; }
		int Length { get; }
		void Handle(Processor processor);
	}
}