using Xamarin.Forms;

namespace Todo.Models
{
	public class Progress
	{
		public Progress(int total, int done)
		{
			if (total > 0)
			{
				Value = (double) done / total;
			}
			else
			{
				Value = 0;
			}

			if (done == 0 && total > 0)
			{
				BackgroundColor = Color.Red;
			}
			else
			{
				BackgroundColor = Color.Default;
			}

			Color = Color.FromRgb(1D - Value, Value, 0);
		}

		public double Value { get; set; }
		public Color Color { get; set; }
		public Color BackgroundColor { get; set; }
	}
}