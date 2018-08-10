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
		public void Constructor()
		{
			byte b1 = 255;
			byte b2 = 0;
			var n = new Number(b1,b2);
			Assert.AreEqual(n, 255);
			n =  new Number(new byte[]{255,0},0);
			Assert.AreEqual(n, 255);
		}

		[TestMethod]
		public void TestComparison()
		{
			var n1 = new Number(1);
			var n2 = new Number(1);
			var n3 = new Number(2);
			Assert.AreEqual(n1, n2);
			Assert.IsTrue(n1 == n2);
			Assert.AreNotEqual(n1, n3);
			Assert.IsTrue(n1 != n3);

		}

		[TestMethod]
		public void TestAdd()
		{
			var n1 = new Number(32758);
			var n2 = new Number(15);
			Assert.AreEqual(n1 +n2, 5);
		}

		[TestMethod]
		public void TestProcessor()
		{
			var ints = new List<int> {1};
			BitConverter.ToUInt16(new byte[] {255, 0}, 0);
			byte[] arr =ints.SelectMany(BitConverter.GetBytes).ToArray();
			var p = new Processor(arr);
		}


	}

}
