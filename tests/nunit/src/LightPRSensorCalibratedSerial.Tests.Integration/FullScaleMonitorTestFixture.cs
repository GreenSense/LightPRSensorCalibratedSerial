﻿using System;
using NUnit.Framework;
using duinocom;
using System.Threading;
using ArduinoSerialControllerClient;
using System.Collections.Generic;
using System.IO;

namespace LightPRSensorCalibratedSerial.Tests.Integration
{
	[TestFixture(Category = "Integration")]
	public class FullScaleTestFixture : BaseTestFixture
	{
		[Test]
		public void Test_FullScaleTest()
		{
			using (var helper = new FullScaleMonitorTestHelper())
			{
				helper.DevicePort = GetDevicePort();
				helper.DeviceBaudRate = GetDeviceSerialBaudRate();

				helper.SimulatorPort = GetSimulatorPort();
				helper.SimulatorBaudRate = GetSimulatorSerialBaudRate();

				helper.RunFullScaleTest();
			}
		}
	}
}
