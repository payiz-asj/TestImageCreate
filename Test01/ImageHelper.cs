using System.Drawing;

namespace TestImageCreate.Test01
{
    /// <summary>
    /// 图像操作助手类
    /// </summary>
    public class ImageHelper
    {

        /// <summary>
        /// 从指定的文件路径加载图像，支持包含中文字符的路径。
        /// </summary>
        /// <param name="filePath">图像文件的完整路径，支持中文字符。</param>
        /// <returns>返回一个Bitmap对象表示的图像。</returns>
        /// <exception cref="FileNotFoundException">如果提供的路径不存在，则抛出此异常。</exception>
        /// <exception cref="ArgumentException">如果提供的路径无效或不是图像文件，则抛出此异常。</exception>
        public Bitmap LoadImage(string filePath)
        {
            // 检查文件是否存在
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("指定的图像文件不存在。", filePath);
            }

            try
            {
                // 使用FileStream以确保正确处理长路径和非ASCII字符
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // 使用Image.FromStream加载图像，避免锁定文件
                    using (Image image = Image.FromStream(fs, false, false))
                    {
                        // 将图像复制到一个新的Bitmap对象中，以确保原始文件可以关闭
                        return new Bitmap(image);
                    }
                }
            }
            catch (Exception ex) when (ex is ArgumentException || ex is OutOfMemoryException)
            {
                // ArgumentException: 如果提供的路径无效或不是图像文件
                // OutOfMemoryException: 当图像格式不支持时也会抛出此异常（虽然名字误导）
                throw new ArgumentException("无法加载图像文件，请检查文件路径和格式。", ex);
            }
        }

        /// <summary>
        /// 从给定的图像中读取指定坐标(x, y)处的颜色。
        /// </summary>
        /// <param name="image">要从中读取颜色的图像。</param>
        /// <param name="x">像素的X坐标。</param>
        /// <param name="y">像素的Y坐标。</param>
        /// <returns>位于(x, y)处的像素颜色。</returns>
        public Color GetPixelColor(Bitmap image, int x, int y)
        {
            // 检查坐标是否在图像边界内
            if (x >= 0 && x < image.Width && y >= 0 && y < image.Height)
            {
                return image.GetPixel(x, y);
            }
            else
            {
                throw new ArgumentOutOfRangeException("坐标超出图像边界");
            }
        }
    }
}