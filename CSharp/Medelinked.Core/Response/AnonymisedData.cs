using System;
using System.Collections.Generic;

namespace Medelinked.Core.Response
{
	public class AnonymisedData
	{
		public string Category { get; set; }
		public string Data { get; set; }
		public string SNOWMEDCode { get; set; }
		public int YearOfBirth { get; set; }
		public string Gender { get; set; }
		public decimal? ReadingValue { get; set; }
		public string Country { get; set; }
		public int DataType { get; set; }
		public DateTime DateRecorded { get; set; }
	}

	public class AnonymisedRecords
	{
		public string Message { get; set; }
		public List<AnonymisedData> Results;
	}
}
