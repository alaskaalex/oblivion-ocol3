using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OCOL {
    public partial class ButtonAction : Button {

        public Launcher launcher;

        public ButtonAction(Launcher launcher) {
            this.launcher = launcher;
            InitializeComponent();
        }
    }
}
