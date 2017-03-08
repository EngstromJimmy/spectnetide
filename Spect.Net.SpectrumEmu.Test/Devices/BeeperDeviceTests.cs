﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Spect.Net.SpectrumEmu.Devices;
using Spect.Net.SpectrumEmu.Test.Helpers;

namespace Spect.Net.SpectrumEmu.Test.Devices
{
    [TestClass]
    public class BeeperDeviceTests
    {
        [TestMethod]
        public void DeviceIsInitializedProperty()
        {
            // --- Arrange
            var spectrum = new SpectrumBeepTestMachine();

            // --- Act
            var beeperDevice = new BeeperDevice(spectrum, null);

            // --- Assert
            beeperDevice.Pulses.Count.ShouldBe(0);
            beeperDevice.LastEarBit.ShouldBeTrue();
            beeperDevice.LastPulseTact.ShouldBe(0);
            beeperDevice.FrameCount.ShouldBe(0);
        }

        [TestMethod]
        public void ProcessEarBitWorksForTheFirstHighPulse()
        {
            // --- Arrange
            var spectrum = new SpectrumBeepTestMachine();
            var beeperDevice = new BeeperDevice(spectrum, null);

            // --- Act
            beeperDevice.ProcessEarBitValue(true);

            // --- Assert
            beeperDevice.Pulses.Count.ShouldBe(0);
            beeperDevice.LastEarBit.ShouldBeTrue();
            beeperDevice.LastPulseTact.ShouldBe(0);
        }

        [TestMethod]
        public void ProcessEarBitWorksForTheFirstLowPulse()
        {
            // --- Arrange
            var spectrum = new SpectrumBeepTestMachine();
            var beeperDevice = new BeeperDevice(spectrum, null);

            // --- Act
            spectrum.SetCurrentFrameTact(100);
            beeperDevice.ProcessEarBitValue(false);

            // --- Assert
            beeperDevice.Pulses.Count.ShouldBe(1);
            beeperDevice.LastEarBit.ShouldBeFalse();
            beeperDevice.LastPulseTact.ShouldBe(100);
            var pulse = beeperDevice.Pulses[0];
            pulse.EarBit.ShouldBeTrue();
            pulse.Lenght.ShouldBe(100);
        }

        [TestMethod]
        public void ProcessEarBitWorksWithLowPulseAtTact0()
        {
            // --- Arrange
            var spectrum = new SpectrumBeepTestMachine();
            var beeperDevice = new BeeperDevice(spectrum, null);

            // --- Act
            spectrum.SetCurrentFrameTact(0);
            beeperDevice.ProcessEarBitValue(false);

            // --- Assert
            beeperDevice.Pulses.Count.ShouldBe(0);
            beeperDevice.LastEarBit.ShouldBeFalse();
            beeperDevice.LastPulseTact.ShouldBe(0);
        }

        [TestMethod]
        public void ProcessEarBitWorksForFourPulses()
        {
            // --- Arrange
            var spectrum = new SpectrumBeepTestMachine();
            var beeperDevice = new BeeperDevice(spectrum, null);

            // --- Act
            spectrum.SetCurrentFrameTact(100);
            beeperDevice.ProcessEarBitValue(false);
            spectrum.SetCurrentFrameTact(140);
            beeperDevice.ProcessEarBitValue(true);
            spectrum.SetCurrentFrameTact(160);
            beeperDevice.ProcessEarBitValue(true);
            spectrum.SetCurrentFrameTact(190);
            beeperDevice.ProcessEarBitValue(false);


            // --- Assert
            beeperDevice.Pulses.Count.ShouldBe(3);
            beeperDevice.LastEarBit.ShouldBeFalse();
            beeperDevice.LastPulseTact.ShouldBe(190);
            var pulse1 = beeperDevice.Pulses[0];
            pulse1.EarBit.ShouldBeTrue();
            pulse1.Lenght.ShouldBe(100);
            var pulse2 = beeperDevice.Pulses[1];
            pulse2.EarBit.ShouldBeFalse();
            pulse2.Lenght.ShouldBe(40);
            var pulse3 = beeperDevice.Pulses[2];
            pulse3.EarBit.ShouldBeTrue();
            pulse3.Lenght.ShouldBe(50);
        }

        [TestMethod]
        public void SignFrameCompletedWorksWithNoPulse()
        {
            // --- Arrange
            var spectrum = new SpectrumBeepTestMachine();
            var beeperDevice = new BeeperDevice(spectrum, null);

            // --- Act
            beeperDevice.SignFrameCompleted();

            // --- Assert
            beeperDevice.FrameCount.ShouldBe(0);
            beeperDevice.Pulses.Count.ShouldBe(0);
            beeperDevice.LastEarBit.ShouldBeTrue();
            beeperDevice.LastPulseTact.ShouldBe(0);
        }

        [TestMethod]
        public void SignFrameCompletedWorksWithHighPulse()
        {
            // --- Arrange
            var spectrum = new SpectrumBeepTestMachine();
            var beeperDevice = new BeeperDevice(spectrum, null);

            // --- Act
            beeperDevice.ProcessEarBitValue(true);
            beeperDevice.SignFrameCompleted();

            // --- Assert
            beeperDevice.FrameCount.ShouldBe(0);
            beeperDevice.Pulses.Count.ShouldBe(0);
            beeperDevice.LastEarBit.ShouldBeTrue();
            beeperDevice.LastPulseTact.ShouldBe(0);
        }

        [TestMethod]
        public void SignFrameCompletedWorksWithLowPulseAtTact0()
        {
            // --- Arrange
            var spectrum = new SpectrumBeepTestMachine();
            var beeperDevice = new BeeperDevice(spectrum, null);

            // --- Act
            spectrum.SetCurrentFrameTact(0);
            beeperDevice.ProcessEarBitValue(false);
            spectrum.SetCurrentFrameTact(spectrum.DisplayPars.UlaFrameTactCount);
            beeperDevice.SignFrameCompleted();

            // --- Assert
            beeperDevice.FrameCount.ShouldBe(0);
            beeperDevice.Pulses.Count.ShouldBe(1);
            beeperDevice.LastEarBit.ShouldBeFalse();
            beeperDevice.LastPulseTact.ShouldBe(0);
            var pulse = beeperDevice.Pulses[0];
            pulse.EarBit.ShouldBeFalse();
            pulse.Lenght.ShouldBe(spectrum.DisplayPars.UlaFrameTactCount);
        }

        [TestMethod]
        public void SignFrameCompletedWorksWithLowPulseAfterTheFirsttact()
        {
            // --- Arrange
            var spectrum = new SpectrumBeepTestMachine();
            var beeperDevice = new BeeperDevice(spectrum, null);

            // --- Act
            spectrum.SetCurrentFrameTact(100);
            beeperDevice.ProcessEarBitValue(false);
            spectrum.SetCurrentFrameTact(spectrum.DisplayPars.UlaFrameTactCount);
            beeperDevice.SignFrameCompleted();

            // --- Assert
            beeperDevice.FrameCount.ShouldBe(0);
            beeperDevice.Pulses.Count.ShouldBe(2);
            beeperDevice.LastEarBit.ShouldBeFalse();
            beeperDevice.LastPulseTact.ShouldBe(100);
            var pulse1 = beeperDevice.Pulses[0];
            pulse1.EarBit.ShouldBeTrue();
            pulse1.Lenght.ShouldBe(100);
            var pulse2 = beeperDevice.Pulses[1];
            pulse2.EarBit.ShouldBeFalse();
            pulse2.Lenght.ShouldBe(spectrum.DisplayPars.UlaFrameTactCount - 100);
        }

        [TestMethod]
        public void StartNewFrameInitsNextFrame()
        {
            // --- Arrange
            var spectrum = new SpectrumBeepTestMachine();
            var beeperDevice = new BeeperDevice(spectrum, null);

            // --- Act
            beeperDevice.StartNewFrame();

            // --- Assert
            beeperDevice.FrameCount.ShouldBe(1);
            beeperDevice.Pulses.Count.ShouldBe(0);
            beeperDevice.LastEarBit.ShouldBeTrue();
            beeperDevice.LastPulseTact.ShouldBe(0);
        }

        [TestMethod]
        public void StartNewFrameKeepsLastEarBitValue()
        {
            // --- Arrange
            var spectrum = new SpectrumBeepTestMachine();
            var beeperDevice = new BeeperDevice(spectrum, null);

            // --- Act
            spectrum.SetCurrentFrameTact(100);
            beeperDevice.ProcessEarBitValue(false);
            spectrum.SetCurrentFrameTact(spectrum.DisplayPars.UlaFrameTactCount);
            beeperDevice.SignFrameCompleted();
            beeperDevice.StartNewFrame();

            // --- Assert
            beeperDevice.FrameCount.ShouldBe(1);
            beeperDevice.Pulses.Count.ShouldBe(0);
            beeperDevice.LastEarBit.ShouldBeFalse();
            beeperDevice.LastPulseTact.ShouldBe(0);
        }

        private class SpectrumBeepTestMachine : SpectrumAdvancedTestMachine
        {
            private int _tact;

            /// <summary>
            /// Override this property for mocking its value
            /// </summary>
            public override int CurrentFrameTact => _tact;

            public void SetCurrentFrameTact(int tact)
            {
                _tact = tact;
            }
        }
    }
}
