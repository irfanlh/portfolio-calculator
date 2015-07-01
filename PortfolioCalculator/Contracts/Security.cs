﻿using Contracts.Interfaces;

namespace Contracts
{
	public class Security : IDomainEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}