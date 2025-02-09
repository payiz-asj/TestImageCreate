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


### TODO:

将来继续完成一些列图像处理练习。例如：

1. `GetPixelColor`：读取指定像素位置的RGB值。这个可以通过改造GetPixelExampleFunc函数得到。
2. `SetPixelColor`：修改指定位置的颜色。
3. `ConvertToGrayscale`：将彩色图像转换为灰度图像。
4. `InvertColors`：反转图像的颜色。
5. `ApplySepiaTone`：应用棕褐色调到图像。
6. `BrightnessAdjust`：调整图像的亮度。
7. `ContrastAdjust`：调整图像的对比度。
8. `SharpenImage`：锐化图像。
9. `BlurImage`：模糊图像。
10. `EmbossEffect`：应用浮雕效果。
11. `EdgeDetection`：边缘检测。
12. `Thresholding`：阈值处理。
13. `DilateImage`：图像膨胀。
14. `ErodeImage`：图像腐蚀。
15. `OpenImage`：图像开运算。
16. `CloseImage`：图像闭运算。
17. `FindEdges`：查找图像边缘。
18. `ConvertToBinary`：转换为二值图像。
19. `ApplyGaussianBlur`：应用高斯模糊。
20. `AddNoise`：向图像添加噪声。
21. `RemoveNoise`：去除图像噪声。
22. `RotateImage`：旋转图像。
23. `FlipImage`：翻转图像。
24. `CropImage`：裁剪图像。
25. `ResizeImage`：调整图像大小。
26. `ApplyHueShift`：改变图像色调。
27. `ApplySaturationAdjustment`：调整图像饱和度。
28. `ApplyLightnessAdjustment`：调整图像明度。
29. `DetectFaces`：检测图像中的人脸。
30. `DrawRectangle`：在图像上绘制矩形。
31. `DrawCircle`：在图像上绘制圆形。
32. `DrawLine`：在图像上绘制线条。
33. `DrawText`：在图像上绘制文本。
34. `FillColor`：填充颜色。
35. `ApplyWatermark`：添加水印。
36. `ExtractColorPalette`：提取图像调色板。
37. `QuantizeColors`：颜色量化。
38. `ApplyFilter`：应用自定义滤镜。
39. `SaveImage`：保存图像。
40. `LoadImage`：加载图像。
41. `ConvertToBitmap`：转换为位图。
42. `ConvertToJpeg`：转换为JPEG格式。
43. `ConvertToPng`：转换为PNG格式。
44. `HistogramEqualization`：直方图均衡化。
45. `FindDominantColors`：找到图像的主要颜色。
46. `ApplyColorBalance`：调整颜色平衡。
47. `ApplyVignetteEffect`：应用晕影效果。
48. `CreateThumbnail`：创建缩略图。
49. `DetectAndDrawContours`：检测并绘制轮廓。
50. `ApplyFisheyeEffect`：应用鱼眼效果。

这些函数覆盖了从基本的像素操作到复杂的图像变换和效果应用。可以通过实现这些函数来深入学习C#中的图像处理技术。
对于每个函数，需要了解其背后的图像处理原理，并使用合适的库（如System.Drawing、SkiaSharp等）来实现它们。


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
