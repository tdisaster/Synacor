using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynacorChallenge.Model
{
	public class OperationGenerator
	{
		public void Tick(Processor processor)
		{
			Number x = processor.Memory.Get(processor.Cursor);
			var op = GetOperation(x);
			op.Handle(processor);
			if (!processor.Stopped)
			{
				Tick(processor);
			}
		}

		private IOperation GetOperation(Number number)
		{
			switch (number.Value)
			{
				case 0:
					return new Stop();
				case 9:
					return new Add();
				case 19:
					return new Stop();
				case 21:
					return new Stop();
				default:
					throw new Exception($"Invalid operation code {number.Value}");
			}
		}
	}
}