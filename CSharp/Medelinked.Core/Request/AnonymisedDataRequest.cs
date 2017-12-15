using System;
using System.Collections.Generic;

namespace Medelinked.Core.Request
{
	public class AnonymisedDataRequest
	{
		public List<string> Filters { get; set; }
		public string DateFrom { get; set; }
		public string DateTo { get; set; }
	}
}
