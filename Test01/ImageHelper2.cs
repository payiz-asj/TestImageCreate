using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using Image = SixLabors.ImageSharp.Image;

namespace TestImageCreate.Test01
{
    /// <summary>
    /// 图像操作助手类(使用跨平台库：ImageSharp)
    /// </summary>
    public class ImageHelper2
    {
        /// <summary>
        /// 从指定的文件路径加载图像，支持包含中文字符的路径。
        /// </summary>
        /// <param name="filePath">图像文件的完整路径，支持中文字符。</param>
        /// <returns>返回一个ImageSharp中的Image对象表示的图像。</returns>
        /// <exception cref="FileNotFoundException">如果提供的路径不存在，则抛出此异常。</exception>
        public static Image<Rgba32> LoadImage(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("指定的图像文件不存在。", filePath);
            }

            return Image.Load<Rgba32>(filePath);
        }

        /// <summary>
        /// 获取指定像素的颜色。
        /// </summary>
        /// <param name="image">要从中读取颜色的图像。</param>
        /// <param name="x">像素的X坐标。</param>
        /// <param name="y">像素的Y坐标。</param>
        /// <returns>位于(x, y)处的像素颜色。</returns>
        public static Color GetPixelColor(Image<Rgba32> image, int x, int y)
        {
            return image[x, y];
        }

        /// <summary>
        /// 修改指定位置的颜色。
        /// </summary>
        /// <param name="image">要修改颜色的图像。</param>
        /// <param name="x">像素的X坐标。</param>
        /// <param name="y">像素的Y坐标。</param>
        /// <param name="color">要设置的新颜色。</param>
        public static void SetPixelColor(Image<Rgba32> image, int x, int y, Color color)
        {
            image[x, y] = color;
        }

        /// <summary>
        /// 将彩色图像转换为灰度图像。
        /// </summary>
        /// <param name="originalImage">原始彩色图像。</param>
        /// <returns>转换后的灰度图像。</returns>
        public static Image<Rgba32> ConvertToGrayscale(Image<Rgba32> originalImage)
        {
            return originalImage.Clone(x => x.Grayscale());
        }

        /// <summary>
        /// 反转图像的颜色。
        /// </summary>
        /// <param name="originalImage">原始图像。</param>
        /// <returns>颜色反转后的图像副本。</returns>
        public static Image<Rgba32> InvertColors(Image<Rgba32> originalImage)
        {
            // 使用 Mutate 方法反转图像颜色
            return originalImage.Clone(ctx => ctx.Invert());
        }



        /// <summary>
        /// 应用棕褐色调效果到给定图像。
        /// </summary>
        /// <param name="originalImage">原始图像。</param>
        /// <returns>应用了棕褐色调后的图像副本。</returns>
        public static Image<Rgba32> ApplySepiaTone(Image<Rgba32> originalImage)
        {
            // 创建一个新的图像副本
            var sepiaImage = originalImage.Clone();

            // 遍历图像的每个像素并应用棕褐色调
            for (int y = 0; y < sepiaImage.Height; y++)
            {
                for (int x = 0; x < sepiaImage.Width; x++)
                {
                    // 获取当前像素
                    var pixel = sepiaImage[x, y];

                    // 获取原始像素的 RGB 值
                    byte r = pixel.R;
                    byte g = pixel.G;
                    byte b = pixel.B;

                    // 应用棕褐色调的转换公式
                    byte tr = (byte)Math.Min(255, (int)(0.393 * r + 0.769 * g + 0.189 * b));
                    byte tg = (byte)Math.Min(255, (int)(0.349 * r + 0.686 * g + 0.168 * b));
                    byte tb = (byte)Math.Min(255, (int)(0.272 * r + 0.534 * g + 0.131 * b));

                    // 更新像素值
                    sepiaImage[x, y] = new Rgba32(tr, tg, tb, pixel.A);
                }
            }

            return sepiaImage;
        }



    }
}
