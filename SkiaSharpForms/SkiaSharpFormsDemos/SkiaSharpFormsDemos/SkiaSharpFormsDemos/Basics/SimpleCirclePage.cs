using Xamarin.Forms;

using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace SkiaSharpFormsDemos.Basics
{
    public class SimpleCirclePage : ContentPage
    {
        public SimpleCirclePage()
        {
            Title = "Simple Circle";

            SKCanvasView canvasView = new SKCanvasView()
            {
                HeightRequest = 50,
                WidthRequest = 50,
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.Center
            };
            canvasView.PaintSurface += OnCanvasViewPaintSurface;

            StackLayout sl = new StackLayout()
            {
                Orientation = StackOrientation.Vertical
            };
            sl.Children.Add(canvasView);
            sl.Children.Add(new Label()
            {
                Text = "This Is My Circle"
            });

            Frame frame = new Frame()
            {
                Margin = new Thickness(0, 50, 0, 0),
                HeightRequest = 100,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(0),
                HasShadow = true
            };
            frame.Content = sl;

            StackLayout mainStack = new StackLayout() {
                Orientation = StackOrientation.Vertical
            };
            mainStack.Children.Add(frame);
            mainStack.Children.Add(new Button()
            {
                Text="Click Here"
            });

            Content = mainStack;
        }

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = Color.Red.ToSKColor(),
                IsAntialias = true,
                StrokeWidth = 1
            };
            
            canvas.DrawCircle(info.Width / 2, info.Height / 2, info.Height / 3, paint);

            paint.Style = SKPaintStyle.Fill;
            paint.Color = SKColors.Blue;
            canvas.DrawCircle(info.Width / 2, info.Height / 2, info.Height / 3, paint);
        }
    }
}
