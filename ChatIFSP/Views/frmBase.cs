using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatIFSP.Views
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
			BackgroundDegrade();

		}

		private void BackgroundDegrade()
		{
			Color startColor = Color.FromArgb(8, 101, 25);
			Color endColor = Color.FromArgb(180, 230, 180);

			LinearGradientBrush brush = new LinearGradientBrush(
				this.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical);

			this.BackgroundImage = new Bitmap(this.Width, this.Height);

			using (Graphics g = Graphics.FromImage(this.BackgroundImage))
			{
				g.FillRectangle(brush, this.ClientRectangle);
			}

		}
	}
}
