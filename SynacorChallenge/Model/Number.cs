using System;

namespace SynacorChallenge.Model
{
	public struct Number : IComparable<ushort>, IComparable<Number>, IEquatable<ushort>, IEquatable<Number>, IComparable<int>, IEquatable<int>
	{
		#region Properties

		public static readonly ushort MaxValue = 32768 - 1;
		public static readonly ushort MaxRegValue = 32768 + 7;
		public static readonly ushort ARegister = 32768 + 0;
		public static readonly ushort BRegister = 32768 + 1;
		public static readonly ushort CRegister = 32768 + 2;
		public static readonly ushort DRegister = 32768 + 3;
		public static readonly ushort ERegister = 32768 + 4;
		public static readonly ushort FRegister = 32768 + 5;
		public static readonly ushort GRegister = 32768 + 6;
		public static readonly ushort HRegister = 32768 + 7;
		private ushort _value;
		private Memory _memory;


		public ushort Value
		{
			get
			{
				if (_value > MaxValue)
				{
					return _memory.Get(_value).Value;
				}

				return _value;
			}
			set
			{
				if (value > MaxRegValue)
				{
					throw new Exception("Invalid number");
				}


				if (IsRegister)
				{
					_memory.Set(_value, value);
				}
				else
				{
					_value = value;
				}
			}
		}

		public bool IsRegister => _value > MaxValue;

		#endregion

		#region Constructor

		public Number(Memory memory, ushort value) : this()
		{
			_memory = memory;
			Value = value;
		}

		public Number(Memory memory, byte[] data, int index) : this()
		{
			_memory = memory;
			Value = ToShort(data, index);
		}

		#endregion

		private ushort ToShort(byte[] data, int index)
		{
			if (index >= 0 && data.Length > index + 1)
			{
				return (ushort) ((data[index + 1] << 8) + data[index]);
			}

			throw new Exception("Invalid array range");
		}


		public int CompareTo(Number other)
		{
			return other.Value.CompareTo(Value);
		}

		public int CompareTo(ushort other)
		{
			return other.CompareTo(Value);
		}

		public bool Equals(ushort other)
		{
			return other == Value;
		}

		public bool Equals(Number other)
		{
			return Value == other.Value;
		}

		public int CompareTo(int other)
		{
			return other.CompareTo(Value);
		}

		public bool Equals(int other)
		{
			return other.Equals(Value);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			return obj is Number && Equals((Number) obj) || obj is int && Equals((int) obj);
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}


		public static Number operator +(Number b, Number c)
		{
			int sum = (b.Value + c.Value) % (MaxValue + 1);
			return new Number(b._memory, (ushort) sum);
		}

		public static Number operator +(Number b, int c)
		{
			int sum = (b.Value + c) % (MaxValue + 1);
			return new Number(b._memory, (ushort) sum);
		}

		public static bool operator >(Number b, Number c)
		{
			return b.Value > c.Value;
		}

		public static bool operator <(Number b, Number c)
		{
			return b.Value < c.Value;
		}


		public static bool operator ==(Number a, Number b)
		{
			return a.Value == b.Value;
		}

		public static bool operator !=(Number a, Number b)
		{
			return a.Value != b.Value;
		}


		public override string ToString()
		{
			if (IsRegister)
			{
				return $"REG {_value - MaxValue} : {Value}";
			}

			return $"VAL {Value}";
		}
	}
}