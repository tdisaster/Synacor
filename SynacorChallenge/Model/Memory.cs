using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			for (int i = 0; i < values.Length; i+=2)
			{
				Values[i] = new Number(values, i).Value;
			}
		}

		private readonly ushort[] Values = new ushort[Number.MaxValue + 8];

		public ushort A => Values[Number.MaxValue + 1];
		public ushort B => Values[Number.MaxValue + 2];
		public ushort C => Values[Number.MaxValue + 3];
		public ushort D => Values[Number.MaxValue + 4];
		public ushort E => Values[Number.MaxValue + 5];
		public ushort F => Values[Number.MaxValue + 6];
		public ushort G => Values[Number.MaxValue + 7];
		public ushort H => Values[Number.MaxValue + 8];


		public Number Get(Number address)
		{
			return new Number(Values[address.Value]);
		}

		public void Set(Number address, Number number)
		{
			Values[address.Value] = number.Value;
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
