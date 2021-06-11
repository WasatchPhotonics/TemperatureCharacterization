using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WasatchNET;

namespace TemperatureCharacterization
{
    public partial class TestForm : Form
    {
        Spectrometer spec;
        TemperatureProbe tempProbe;

        Logger logger = Logger.getInstance();

        public TestForm()
        {
            InitializeComponent();

            logger.setTextBox(textBoxEventLog);
        }

        private void buttonConnectTemperatureProbe_Click(object sender, EventArgs e)
        {
            TemperatureProbe probe = new TemperatureProbe();
            bool success = probe.connect();
            if (!success)
                return;

            tempProbe = probe;
            logger.info("successfully connected to {0}", probe.getDeviceInfo());
            buttonConnectTemperatureProbe.Enabled = false;
            testReady();
        }

        private void buttonConnectSpectrometer_Click(object sender, EventArgs e)
        {
            Driver driver = Driver.getInstance();
            var numberOfSpectrometers = driver.openAllSpectrometers();
            logger.info("{0} spectrometers found", numberOfSpectrometers);
            if (numberOfSpectrometers == 0)
                return;

            spec = driver.getSpectrometer(0);
            logger.info("connected to {0} {1} with {2} pixels ({3:f2}, {4:f2})", spec.model, spec.serialNumber, spec.pixels,
                spec.wavelengths[0], spec.wavelengths[spec.pixels - 1]);

            buttonConnectSpectrometer.Enabled = false;
            testReady();
        }

        void testReady()
        {
            buttonStart.Enabled = (spec != null && tempProbe != null);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            var temps = tempProbe.getTempsDegC();
            if (temps is null)
            {
                logger.error("failed to read temperatures");
                return;
            }

            for (int i = 0; i < temps.Length; i++)
                logger.info("Temperature channel {0}: {1:f2} degC", i, temps[i]);
        }

    }
}
