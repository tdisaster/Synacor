using System;

namespace SynacorChallenge.Model
{
	public struct Number : IComparable<ushort>, IComparable<Number>, IEquatable<ushort>, IEquatable<Number>, IComparable<int>, IEquatable<int>
	{
		public ushort Value { get; set; }

		public Number(ushort value)
		{
			Value = value;
		}

		public Number(byte a, byte b)
		{
			Value = (ushort)((b << 8) + a);
		}

		public Number(byte[] arr, int index)
		{
			if (index >= 0 && arr.Length > index + 1)
			{
				Value = (ushort) ((arr[index+1] << 8) + arr[index]);
			}
			else
			{
				throw new Exception("Invalid range");
			}
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
			return obj is Number && Equals((Number)obj) || obj is int && Equals((int)obj);
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}


		public static readonly ushort MaxValue = 32768;
		public static Number operator +(Number b, Number c)
		{
			int sum = (b.Value + c.Value) % MaxValue;
			return new Number((ushort)sum);
		}

		public static Number operator +(Number b, int c)
		{
			int sum = (b.Value + c) % MaxValue;
			return new Number((ushort)sum);
		}

		public static bool operator ==(Number a, Number b)
		{
			return a.Value == b.Value;
		}

		public static bool operator !=(Number a, Number b)
		{
			return a.Value != b.Value;
		}
	}
}
