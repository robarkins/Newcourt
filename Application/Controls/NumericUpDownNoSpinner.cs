using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newcourt.Controls {
  public partial class NumericUpDownNoSpinner: NumericUpDown {
    public NumericUpDownNoSpinner() {
      InitializeComponent();
      Controls[0].Visible = false;
    }

    protected override void OnPaint(PaintEventArgs e) {
      e.Graphics.Clear(SystemColors.Window);
      base.OnPaint(e);
    }
  }
}
