# C# ͼ������ϰ��Ŀ

## ���

����Ŀּ���ṩһϵ��C#������ѧϰ��ʵ���������߼���ͼ��������ͨ����Щ�������û������˽���ζ�ȡ���޸ĺͱ���ͼ���Լ�Ӧ�ø���ͼ����Ч����



## �����б�

### ��������
- **LoadImage**�����ļ�·������ͼ��֧������·����
- **GetPixelColor**����ȡָ������λ�õ�RGBֵ��
- **SetPixelColor**���޸�ָ��λ�õ���ɫ��
- **ConvertToGrayscale**������ɫͼ��ת��Ϊ�Ҷ�ͼ��
- **InvertColors**����תͼ�����ɫ��
- **ApplySepiaTone**��Ӧ���غ�ɫ����ͼ��
- ...�����๦�ܣ�

### �߼�����
- **BrightnessAdjust**������ͼ������ȡ�
- **ContrastAdjust**������ͼ��ĶԱȶȡ�
- **SharpenImage**����ͼ��
- **BlurImage**��ģ��ͼ��
- **EmbossEffect**��Ӧ�ø���Ч����
- **EdgeDetection**����Ե��⡣
- ...�����๦�ܣ�


### TODO:

�����������һЩ��ͼ������ϰ�����磺

1. `GetPixelColor`����ȡָ������λ�õ�RGBֵ���������ͨ������GetPixelExampleFunc�����õ���
2. `SetPixelColor`���޸�ָ��λ�õ���ɫ��
3. `ConvertToGrayscale`������ɫͼ��ת��Ϊ�Ҷ�ͼ��
4. `InvertColors`����תͼ�����ɫ��
5. `ApplySepiaTone`��Ӧ���غ�ɫ����ͼ��
6. `BrightnessAdjust`������ͼ������ȡ�
7. `ContrastAdjust`������ͼ��ĶԱȶȡ�
8. `SharpenImage`����ͼ��
9. `BlurImage`��ģ��ͼ��
10. `EmbossEffect`��Ӧ�ø���Ч����
11. `EdgeDetection`����Ե��⡣
12. `Thresholding`����ֵ����
13. `DilateImage`��ͼ�����͡�
14. `ErodeImage`��ͼ��ʴ��
15. `OpenImage`��ͼ�����㡣
16. `CloseImage`��ͼ������㡣
17. `FindEdges`������ͼ���Ե��
18. `ConvertToBinary`��ת��Ϊ��ֵͼ��
19. `ApplyGaussianBlur`��Ӧ�ø�˹ģ����
20. `AddNoise`����ͼ�����������
21. `RemoveNoise`��ȥ��ͼ��������
22. `RotateImage`����תͼ��
23. `FlipImage`����תͼ��
24. `CropImage`���ü�ͼ��
25. `ResizeImage`������ͼ���С��
26. `ApplyHueShift`���ı�ͼ��ɫ����
27. `ApplySaturationAdjustment`������ͼ�񱥺Ͷȡ�
28. `ApplyLightnessAdjustment`������ͼ�����ȡ�
29. `DetectFaces`�����ͼ���е�������
30. `DrawRectangle`����ͼ���ϻ��ƾ��Ρ�
31. `DrawCircle`����ͼ���ϻ���Բ�Ρ�
32. `DrawLine`����ͼ���ϻ���������
33. `DrawText`����ͼ���ϻ����ı���
34. `FillColor`�������ɫ��
35. `ApplyWatermark`�����ˮӡ��
36. `ExtractColorPalette`����ȡͼ���ɫ�塣
37. `QuantizeColors`����ɫ������
38. `ApplyFilter`��Ӧ���Զ����˾���
39. `SaveImage`������ͼ��
40. `LoadImage`������ͼ��
41. `ConvertToBitmap`��ת��Ϊλͼ��
42. `ConvertToJpeg`��ת��ΪJPEG��ʽ��
43. `ConvertToPng`��ת��ΪPNG��ʽ��
44. `HistogramEqualization`��ֱ��ͼ���⻯��
45. `FindDominantColors`���ҵ�ͼ�����Ҫ��ɫ��
46. `ApplyColorBalance`��������ɫƽ�⡣
47. `ApplyVignetteEffect`��Ӧ����ӰЧ����
48. `CreateThumbnail`����������ͼ��
49. `DetectAndDrawContours`����Ⲣ����������
50. `ApplyFisheyeEffect`��Ӧ������Ч����

��Щ���������˴ӻ��������ز��������ӵ�ͼ��任��Ч��Ӧ�á�����ͨ��ʵ����Щ����������ѧϰC#�е�ͼ��������
����ÿ����������Ҫ�˽��䱳���ͼ����ԭ����ʹ�ú��ʵĿ⣨��System.Drawing��SkiaSharp�ȣ���ʵ�����ǡ�


## ʹ�÷���

### ����׼��
1. ��װ [Visual Studio](https://visualstudio.microsoft.com/) ��������֧��C#��IDE��
2. ����һ���µ�C#����̨Ӧ�ó�����Ŀ��
3. ������Ŀ��Դ���븴�Ƶ��´�������Ŀ�С�

### ����ʾ��
1. �� `Program.cs` �ļ���ȷ�� `Files` �ļ����е�ͼƬ·����ȷ����
2. �޸� `Main` �����еĲ�������Ӧ�������
3. ���벢������Ŀ���۲����̨����Ľ����

### ���ͼ��
- ��Ҫ�����ͼ����� `Files` �ļ����С�
- ȷ��ͼ���ļ�������������õ�����һ�¡�

## ע������

- ��ʹ��ͼ������ʱ����ȷ���ṩ��·������ȷ�ģ�����ͼ���ļ�ȷʵ������ָ����λ�á�
- �����Ҫ����ϴ��ͼ�����������ͼ�񣬿����Ż��������ܻ�ʹ�ö��̴߳���
- ĳЩ�߼����ܿ����������ض��Ŀ���㷨ʵ�֣���OpenCV�ȡ�������Ҫ������Ӧ�Ŀ⡣


## ����

��ӭ���״��������Ľ����飡����㷢���˴�������и��õ�ʵ�ַ�ʽ�����ύIssue��Pull Request��

## ���֤

����Ŀ����MIT���֤������μ� [LICENSE](LICENSE) �ļ���
