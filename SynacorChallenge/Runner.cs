using System;
using SynacorChallenge.Operations;

namespace SynacorChallenge.Model
{
	public class Runner
	{
		public Runner(Processor processor)
		{
			_processor = processor;
		}

		private Processor _processor;

		public void Run()
		{
			Tick(_processor);
		}

		private void Tick(Processor processor)
		{
			while (!processor.Stopped)
			{
				Number x = processor.Memory.Get(processor.Cursor);
				var op = GetOperation(x);
				op.Handle(processor);
			}
		}

		private IOperation GetOperation(Number number)
		{
			switch (number.Value)
			{
				case 0:
					return new Stop();
				case 1: 
					return new Set();
				case 2:
					return new Push();
				case 3:
					return new Pop();
				case 4:
					return new Equality();
				case 5:
					return new GreatherThan();
				case 6:
					return new Jump();
				case 7:
					return new JumpNotZero();
				case 8:
					return new JumpZero();
				case 9:
					return new Add();
				case 10:
					return new Multiply();
				case 11:
					return new Mod();
				case 12:
					return new And();
				case 13:
					return new Or();
				case 14:
					return new Not();
				case 15:
					return new ReadMemory();
				case 16:
					return new WriteMemory();
				case 17:
					return new Call();
				case 18:
					return new Return();
				case 19:
					return new Out();
				case 20:
					return new In();
				case 21:
					return new NoOperation();
				default:
					throw new Exception($"Invalid operation code {number.Value}");
			}
		}
	}
}