using System;
using System.Collections.Generic;

namespace Medelinked.Core.Request
{
	public class LoginModel
	{
		public string Username { get; set; }
		public string Password { get; set; }
		public string ProviderKey { get; set; }
		public string MedelinkedID { get; set; }
        public bool SimpleLogin { get; set; }
		
        //Additional Information
		public List<string> Tags { get; set; }
	}
}

