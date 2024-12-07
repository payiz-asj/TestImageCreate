# C# 图像处理练习项目

## 简介

本项目旨在提供一系列C#函数来学习和实践基本到高级的图像处理技术。通过这些函数，用户可以了解如何读取、修改和保存图像，以及应用各种图像处理效果。



## 功能列表

### 基础功能
- **LoadImage**：从文件路径加载图像，支持中文路径。
- **GetPixelColor**：读取指定像素位置的RGB值。
- **SetPixelColor**：修改指定位置的颜色。
- **ConvertToGrayscale**：将彩色图像转换为灰度图像。
- **InvertColors**：反转图像的颜色。
- **ApplySepiaTone**：应用棕褐色调到图像。
- ...（更多功能）

### 高级功能
- **BrightnessAdjust**：调整图像的亮度。
- **ContrastAdjust**：调整图像的对比度。
- **SharpenImage**：锐化图像。
- **BlurImage**：模糊图像。
- **EmbossEffect**：应用浮雕效果。
- **EdgeDetection**：边缘检测。
- ...（更多功能）

## 使用方法

### 环境准备
1. 安装 [Visual Studio](https://visualstudio.microsoft.com/) 或者任意支持C#的IDE。
2. 创建一个新的C#控制台应用程序项目。
3. 将本项目的源代码复制到新创建的项目中。

### 运行示例
1. 打开 `Program.cs` 文件，确保 `Files` 文件夹中的图片路径正确无误。
2. 修改 `Main` 方法中的参数以适应你的需求。
3. 编译并运行项目，观察控制台输出的结果。

### 添加图像
- 将要处理的图像放入 `Files` 文件夹中。
- 确保图像文件名与代码中引用的名称一致。

## 注意事项

- 在使用图像处理函数时，请确保提供的路径是正确的，并且图像文件确实存在于指定的位置。
- 如果需要处理较大的图像或批量处理图像，考虑优化代码性能或使用多线程处理。
- 某些高级功能可能依赖于特定的库或算法实现，如OpenCV等。根据需要引入相应的库。

## 贡献

欢迎贡献代码或提出改进建议！如果你发现了错误或者有更好的实现方式，请提交Issue或Pull Request。

## 许可证

本项目采用MIT许可证，详情参见 [LICENSE](LICENSE) 文件。

---