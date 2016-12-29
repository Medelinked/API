using System;

namespace Medelinked.Core.Response
{
	public class HealthScore
    {
        public double Score { get; set; }
        public double Risk { get; set; }
        public string Message { get; set; }
    }
}