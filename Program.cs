using System.Diagnostics;
using System.Drawing;
using System.Reflection;

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
            Test01.ImageHelper imageHandler = new Test01.ImageHelper();
            Bitmap bitmap = imageHandler.LoadImage(imagePath);


            // 1. 获取指定位置的像素颜色
            Color pixelColor = imageHandler.GetPixelColor(bitmap, 0, 0);
            Console.WriteLine($"像素位置(0,0)的颜色为：{pixelColor}");
        }

        /// <summary>
        /// 获得项目的根路径。
        /// </summary>
        /// <returns>项目的根路径。</returns>
        public static string GetProjectRootPath()
        {
            // 获取入口程序集的位置
            string assemblyPath = Assembly.GetEntryAssembly()?.Location ?? throw new InvalidOperationException("无法获取入口程序集位置。");

            // 获取包含程序集的目录
            string baseDirectory = Path.GetDirectoryName(assemblyPath);

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
                string parentDirectory = Directory.GetParent(baseDirectory)?.FullName;
                if (parentDirectory == baseDirectory)
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

