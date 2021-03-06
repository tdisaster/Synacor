﻿using System;
using SynacorChallenge.Model;

namespace SynacorChallenge.Operations
{
	public class In : IOperation
	{
		public ushort Code { get; } = 20;
		public int Length { get; } = 2;

		public void Handle(Processor processor)
		{
			int character = Console.ReadKey().KeyChar;
			Number a = processor.GetNumber(processor.Cursor + 1);
			a.Value = (ushort) character == 13 ? (ushort)10 : (ushort)character;
			processor.Cursor += Length;
		}
	}
}