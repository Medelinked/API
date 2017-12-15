using System;
using System.Collections.Generic;

namespace Medelinked.Core.Response
{
	public class WellnessSettings
	{
		public WellnessSettings ()
		{
		}

		public string Smoker { get; set; }
        public string Diet { get; set; }
        public string Nutrition { get; set; }
        public string AlcoholConsumption { get; set; }
        public string Height { get; set; }
        public string Message { get; set; }
	}
}

