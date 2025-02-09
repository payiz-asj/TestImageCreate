using System.Drawing;
using SixLabors.ImageSharp;
using System.Reflection;
using TestImageCreate.Test01;

namespace TestImageCreate
{

    class Program
    {
        static void Main(string[] args)
        {
            // 获取项目文件的目录
            string projectDirectory = GetProjectRootPath();
            // 构建图片的完整路径
            //string imagePath = Path.Combine(projectDirectory, "Files", "1.jpg"); 
            string imagePath = Path.Combine(projectDirectory, "Files", "七仔.png");

            /* 使用System.Drawing来做图像操作
             * 优点：基于 Windows 的 GDI+ 图形接口。历史悠久。
             * 缺点：只能在 Windows 操作系统中使用，不支持跨平台；内存管理较复杂；线程安全问题。
             */

            //// 加载原始图像
            //Test01.ImageHelper imageHandler = new Test01.ImageHelper();
            //Bitmap bitmap = imageHandler.LoadImage(imagePath);

            //// 1. 获取指定位置的像素颜色
            //Color pixelColor = imageHandler.GetPixelColor(bitmap, 0, 0);  // ARGB
            //Console.WriteLine($"原始像素位置(0,0)的颜色为：{pixelColor}");

            //// 2. 设置指定位置的像素颜色
            //Color newColor = Color.AliceBlue;
            //imageHandler.SetPixelColor(bitmap, 0, 0, newColor);
            //Color updatedColor = imageHandler.GetPixelColor(bitmap, 0, 0);
            //Console.WriteLine($"更新后，像素位置(0,0)的颜色为：{updatedColor}");

            //// 保存修改后的图像到文件
            //string outputImagePath = Path.Combine(projectDirectory, "Files", "七仔_modified.png");
            //bitmap.Save(outputImagePath, System.Drawing.Imaging.ImageFormat.Png);
            //Console.WriteLine($"已保存修改后的图像至：{outputImagePath}");


            // 上面的是使用System.Drawing Bitmap来操作，该库只适合Windows使用，不具备跨平台能力
            // 下面是使用ImageSharp

            // 1. 加载原始图像, 并获取指定位置的像素颜色
            var image = ImageHelper2.LoadImage(imagePath.ToString());
            Console.WriteLine($"原始像素位置(0,0)的颜色为：{ImageHelper2.GetPixelColor(image, 0, 0)}");

            // 2. 设置指定位置的像素颜色
            ImageHelper2.SetPixelColor(image, 0, 0, SixLabors.ImageSharp.Color.AliceBlue);
            Console.WriteLine($"更新后，像素位置(0,0)的颜色为：{ImageHelper2.GetPixelColor(image, 0, 0)}");

            // 3.转还为灰度图
            var image2 = ImageHelper2.ConvertToGrayscale(image);
            Console.WriteLine($"转还为灰度图");
            // 保存并显示
            string outputImagePath = Path.Combine(GetProjectRootPath(), "Files", "七仔_灰度图.png");
            image2.Save(outputImagePath);
            System.Diagnostics.Process.Start("explorer.exe", outputImagePath);

            // 颜色反转
            var image3 = ImageHelper2.InvertColors(image);
            Console.WriteLine($"颜色反转");
            string outputImagePath2 = Path.Combine(GetProjectRootPath(), "Files", "七仔_颜色反转.png");
            image3.Save(outputImagePath2);
            System.Diagnostics.Process.Start("explorer.exe", outputImagePath2);

            // 应用棕褐色调
            var image4 = ImageHelper2.ApplySepiaTone(image);
            Console.WriteLine($"应用棕褐色调");
            string outputImagePath3 = Path.Combine(GetProjectRootPath(), "Files", "七仔_棕褐色调.png");
            image4.Save(outputImagePath3);
            System.Diagnostics.Process.Start("explorer.exe", outputImagePath3);




        }

        /// <summary>
        /// 获得项目的根路径。
        /// </summary>
        public static string GetProjectRootPath()
        {
            // 获取入口程序集的位置
            string assemblyPath = Assembly.GetEntryAssembly()?.Location ?? throw new InvalidOperationException("无法获取入口程序集位置。");

            // 获取包含程序集的目录
            string? baseDirectory = Path.GetDirectoryName(assemblyPath);

            // 查找项目根目录：寻找源代码控制文件（如.sln, .csproj）或已知的项目文件夹结构特征
            while (!string.IsNullOrEmpty(baseDirectory))
            {
                // 检查是否存在解决方案文件(.sln)或其他标志性文件/文件夹
                if (Directory.Exists(Path.Combine(baseDirectory, "Files")) || // 或者其他你认为标志性的文件夹名
                    File.Exists(Path.Combine(baseDirectory, "*.sln")) ||
                    File.Exists(Path.Combine(baseDirectory, "*.csproj")))
                {
                    return baseDirectory;
                }

                // 如果没有找到，则向上一级目录查找
                string parentDirectory = Directory.GetParent(baseDirectory)?.FullName ?? "";
                if (parentDirectory == baseDirectory || string.IsNullOrEmpty(parentDirectory))
                {
                    // 防止无限循环，当到达根目录时退出
                    break;
                }
                baseDirectory = parentDirectory;
            }

            throw new DirectoryNotFoundException("未能找到项目的根目录。");
        }

    }
}

