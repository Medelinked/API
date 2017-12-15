using System;
using System.Collections.Generic;

namespace Medelinked.Core.Response
{
	public class DeviceData
	{
		public DeviceData()
		{
			Devices = new List<Device>();
		}

		public string Message { get; set; }
		public List<Device> Devices { get; set; }
	}

	public class Device
	{
		public string DeviceName { get; set; }
		public DateTime LastSynchronised { get; set; }
	}
}
