using System.Windows.Forms;

namespace LaundryOrderSystem
{
	public partial class Form1 : Form
	{
		//App Varaibles NOT Window Control


		//Window Location varaible
		bool isMovingWindow = false;
		int x;
		int y;

		//Window Button Control Varaibles
		bool isWindowMax = false;
		Size startingWindowSize;
		List<Size> startingSizes = new List<Size>();
		public Form1()
		{
			InitializeComponent();
			//Setting of Window Control Varables
			panTopBar.Width = this.Width;
			startingWindowSize = this.Size;
			foreach (var item in panMain.Controls.OfType<Control>())
			{
				startingSizes.Add(item.Size);
			}
			WindowScale();
		}
		//Close Button Top Bar
		private void btnTopBarWindowClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		//Max Window Size BTN
		private void btnTopBarMaxWindow_Click(object sender, EventArgs e)
		{
			if (!isWindowMax)
			{
				this.Size = Screen.FromControl(this).WorkingArea.Size;
				panTopBar.Width = this.Width;
				this.CenterToScreen();
				isWindowMax = true;
				WindowScale();
			}
			else
			{
				isWindowMax = false;
				this.Size = startingWindowSize;
				this.CenterToScreen();
				panTopBar.Width = this.Width;
				WindowScale();
			}

		}
		//Minimize Window BTN
		private void btnTopBarMinWindow_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		//Movement of window Controls
		private void panTopBar_MouseDown(object sender, MouseEventArgs e)
		{
			if (!isWindowMax)
			{
				isMovingWindow = true;
				x = e.Location.X;
				y = e.Location.Y;
			}

		}

		private void panTopBar_MouseUp(object sender, MouseEventArgs e)
		{
			isMovingWindow = false;
		}

		private void panTopBar_MouseMove(object sender, MouseEventArgs e)
		{
			if (isMovingWindow)
			{
				this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
			}
		}

		private void WindowScale()
		{	panMain.Location = new Point(0, panTopBar.Height);
			panMain.Size = new Size(this.Width, Screen.FromControl(this).WorkingArea.Size.Height - panTopBar.Height);
			int index = 0;
			if (isWindowMax)
			{
				foreach (var item in panMain.Controls.OfType<Control>())
				{
					item.Size = new Size(startingSizes[index].Width * panMain.Width , startingSizes[index].Height * panMain.Height);
					index++;
				}
			}
			else
			{
				foreach (var item in panMain.Controls.OfType<Control>())
				{
					item.Size = startingSizes[index];
					index++;
				}
			}

		}

		// End of Window Movement Controls

	}
}