using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.DirectX.Direct3D;

namespace OCOL {
    class MyDisplayMode {

        public DisplayMode dm;

        public MyDisplayMode(DisplayMode dm) {
            this.dm = dm;
        }

        public int GetHeight() {
            return dm.Height;
        }

        public int GetWidth() {
            return dm.Width;
        }

        public override string ToString() {
            return dm.Width + "x" + dm.Height;
        }

        public override int GetHashCode() {
            return (this.GetHeight() + "x" + this.GetWidth()).GetHashCode();
        }

        public bool SameResolution(MyDisplayMode obj) {
            MyDisplayMode otherDM = (MyDisplayMode)obj;
            if (this.GetHeight() == otherDM.GetHeight() && this.GetWidth() == otherDM.GetWidth()) {
                return true;
            }
            return false;
        }
    }
}
