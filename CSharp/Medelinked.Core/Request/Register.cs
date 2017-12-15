using System;
using System.Collections.Generic;

namespace Medelinked.Core.Request
{
	public class Register
	{
		public Register ()
		{
            Tags = new List<string>();
		}

		public string Title { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
		public string Forename { get; set; }
		public string Surname { get; set; }
		public string Country { get; set; }
		public string PromotionCode { get; set; }
		public string DOB { get; set; }
		public string NationalHealthNumber { get; set; }
		public string Sex { get; set; }
		public bool SendRegistrationEmail { get; set; }
		public string ProviderKey { get; set; }
        public bool SimpleRegistration { get; set; }

        public List<string> Tags { get; set; }
	}
}

