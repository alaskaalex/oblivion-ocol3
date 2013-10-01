using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace OCOL {
    class MyAdapterInformation {

        AdapterInformation ai;


        public MyAdapterInformation(AdapterInformation ai){
            this.ai = ai;
        }

        public override String ToString() {
            return this.ai.Information.Description;
        }

        public DisplayModeCollection GetDisplayModes() {
            return this.ai.SupportedDisplayModes;
        }

        public String GetUUID() {
            return this.ai.Information.DeviceIdentifier.ToString();
        }

        /*
         * Notes on this bitch-ass bitch. So apparently Bethesda REALLY didn't want other applications to be screwing with graphics configuration. Here's the low-down
         * on how we get from hex UUID of the graphics card to the set of longs that go into the ini file.
         * 
         * The first long is straight hex-to-decimal of the first 4 bytes.
         * 
         * The second long is decimal of bytes 7 and 8 followed by 5 and 6
         * 
         * The third long is decimal of the next four bytes in reverse order.
         * 
         * The fourth long is decimal of the last four bytes in reverse order.
         * 
         * */
        public long[] GetIntegerUUID() {
            String uuid = this.GetUUID();
            uuid = uuid.Replace("{", "").Replace("}", "").Replace("-", "");

            long[] sects = new long[4];
            sects[0] = Int64.Parse(uuid.Substring(0, 8), System.Globalization.NumberStyles.HexNumber);
            sects[1] = Int64.Parse(uuid.Substring(12, 4) + uuid.Substring(8, 4), System.Globalization.NumberStyles.HexNumber);
            sects[2] = Int64.Parse(uuid.Substring(22, 2) + uuid.Substring(20, 2) + uuid.Substring(18, 2) + uuid.Substring(16, 2), System.Globalization.NumberStyles.HexNumber);
            sects[3] = Int64.Parse(uuid.Substring(30, 2) + uuid.Substring(28, 2) + uuid.Substring(26, 2) + uuid.Substring(24, 2), System.Globalization.NumberStyles.HexNumber);
            return sects;
            
        }

    }
}
