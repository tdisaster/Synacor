using System;

namespace SynacorChallenge.Model
{
	public class Memory
	{
		public Memory()
		{
		}

		public Memory(byte[] values)
		{
			if (values.Length % 2 != 0)
			{
				throw new Exception("Invalida data");
			}

			for (int i = 0; i < values.Length; i += 2)
			{
				Values[i / 2] = BitConverter.ToUInt16(values, i);
			}
		}

		public readonly ushort[] Values = new ushort[Number.MaxRegValue + 1];

		public Number Get(ushort address)
		{
			return new Number(this, Values[address]);
		}

		public Number Get(Number number)
		{
			return Get(number.Value);
		}


		public void Set(ushort a, ushort b)
		{
			Values[a] = b;
		}

		public void Set(Number a, Number b)
		{
			if (a.IsRegister)
			{
				a.Value = b.Value;
			}
			else
			{
				Values[a.Value] = b.Value;
			}
		}


		public void Clear()
		{
			for (int i = 0; i < Values.Length; i++)
			{
				Values[i] = 0;
			}
		}

		public void ClearReg()
		{
			for (int i = Number.MaxValue; i < Values.Length; i++)
			{
				Values[i] = 0;
			}
		}
	}
}