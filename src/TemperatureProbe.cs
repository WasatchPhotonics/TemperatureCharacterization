using System.Text;
using USBTC08Imports;
using WasatchNET;

namespace TemperatureCharacterization
{
    // encapsulates a Pico USB TC-08
    class TemperatureProbe
    {
        const int MAX_CHANNELS = 8;
        const int PICO_OK = 1;

        short handle;

        Logger logger = Logger.getInstance();

        public bool connect()
        {
            logger.debug("connecting to Pico TC08");
            handle = Imports.TC08OpenUnit();
            bool success = handle != 0;
            logger.debug("TC08 connection {0}", success ? "successful" : "failed");

            if (success)
            {
                setChannels();
                setMainsRejectionFrequency();
            }

            return success;
        }

        public void close()
        {
            if (handle == 0)
                return;
            logger.debug("closing TC08");
            Imports.TC08CloseUnit(handle);
        }

        void setChannels()
        {
            logger.debug("initializing channels");
            for (short chan = 0; chan <= MAX_CHANNELS; chan++)
                Imports.TC08SetChannel(handle, chan, 'K');
        }

        void setMainsRejectionFrequency()
        {
            if (handle == 0)
                return;

            // use FIFTY_HERTZ in UK
            logger.debug("setting TC08 mains rejection frequency");
            var mainsRejectionFrequency = (short)Imports.MainsFrequency.USBTC08_MAINS_SIXTY_HERTZ;
            if (PICO_OK != Imports.TC08SetMains(handle, (Imports.MainsFrequency)mainsRejectionFrequency))
                logger.error("failed to set mains rejection frequency");
        }

        // Read the device information
        public string getDeviceInfo()
        {
            if (handle == 0)
                return null;

            StringBuilder line = new StringBuilder(256);
            Imports.TC08GetFormattedInfo(handle, line, 256);
            return line.ToString();
        }

        public unsafe float[] getTempsDegC()
        {
            if (handle == 0)
                return null;

            float[] tempbuffer = new float[MAX_CHANNELS + 1];   // why +1?
            short overflow = 0;
            short status = Imports.TC08GetSingle(handle, tempbuffer, &overflow, Imports.TempUnit.USBTC08_UNITS_CENTIGRADE);
            if (status != PICO_OK)
            {
                logger.error("failed to read temperatures from TC08");
                return null;
            }

            Imports.TC08Stop(handle); // needed?
            return tempbuffer;
        }
    }
}
