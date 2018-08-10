using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SynacorChallenge.Model;

namespace ChallengeTest
{
	[TestClass]
	public class NumberTests
	{
		[TestMethod]
		public void ConstructorTest()
		{
			byte b1 = 255;
			byte b2 = 0;
			var n = new Number(null, new byte[] {255, 0}, 0);
			Assert.AreEqual(n, 255);
		}

		[TestMethod]
		public void ComparisonTest()
		{
			var n1 = new Number(null, 1);
			var n2 = new Number(null, 1);
			var n3 = new Number(null, 2);
			Assert.AreEqual(n1, n2);
			Assert.IsTrue(n1 == n2);
			Assert.AreNotEqual(n1, n3);
			Assert.IsTrue(n1 != n3);
		}

		[TestMethod]
		public void AddTest()
		{
			var n1 = new Number(null, 32758);
			var n2 = new Number(null, 15);
			Assert.AreEqual(n1 + n2, 5);
		}


		[TestMethod]
		public void MemoryGetSetTest()
		{
			var mem = new Memory(new byte[] { });
			var a = new Number(mem, Number.ARegister);
			var b = new Number(mem, 1);

			//Set in register
			mem.Set(a, b);
			Assert.AreEqual(mem.Values[Number.ARegister], 1);
			Assert.AreEqual(mem.Get(Number.ARegister).Value, 1);

		}

		[TestMethod]
		public void ProcessorTest()
		{
			var ints = new List<int> {1};
			BitConverter.ToUInt16(new byte[] {255, 0}, 0);
			byte[] arr = ints.SelectMany(BitConverter.GetBytes).ToArray();
			var p = new Processor(arr);
		}
	}
}