using System;
using System.Collections.Generic;

namespace Medelinked.Core.Response
{
	public class Record
	{
		public Record ()
		{
			this.ReturnAllRecords = false;
            Description = new RecordDescription();
            this.Files = new List<HealthFile>();
		}

		public string Username { get; set; }
		public string Title { get; set; }
		public string Date { get; set; }
		public string Category { get; set; }
		public string Type { get; set; }
		public string RecordID { get; set; }
		public bool Protected { get; set; }
		public string Provider { get; set; }
		public string ProviderKey { get; set; }
		public List<HealthFile> Files { get; set; }
		public RecordDescription Description { get; set; }
		public bool ReturnAllRecords { get; set; }
		public string ScanOrXRayLink { get; set; }
        public string OriginalDocument { get; set; }
        public List<Guid> LinkedRecords { get; set; }
	}
}

