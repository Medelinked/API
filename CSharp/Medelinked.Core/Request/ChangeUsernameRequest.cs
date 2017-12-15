using System;

namespace Medelinked.Core.Request
{
    public class ChangeUsernameRequest
    {
        public ChangeUsernameRequest()
        {
        }

		public string NewUsername { get; set; }
		public string ConfirmUsername { get; set; }
    }
}
