﻿using System.Collections.Generic;

namespace LinqToDB.EntityFrameworkCore.SqlServer.Tests.Models.IssueModel
{
	public sealed class Issue73Entity
	{
		public int Id { get; set; }

		public int? ParentId { get; set; }

		public Issue73Entity? Parent { get; set; } = null!;
		public List<Issue73Entity> Childs { get; set; } = null!;

		public string Name { get; set; } = null!;
	}

}
