using System;
using Xamarin.Forms;

namespace Xam.Forms.MarkdownView.Extensions
{
    public static class ImageExtensions
    {
        public static void RenderSvg(this Image view, string uri)
        {
            throw new NotImplementedException();
            
            // SkiaSharp does not provide the SKSvg type anymore.
            // Implement a new rendering strategy if needed (FFImageLoading based?).
        }
    }
}
