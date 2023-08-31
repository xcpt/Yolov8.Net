using SixLabors.Fonts;
using SixLabors.ImageSharp.Drawing.Processing;
using Yolov8Net;

namespace ConsoleAppTest
{
	internal class Program
	{
		//private static Font font;

		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			//var fontCollection = new FontCollection();
			//var fontFamily = fontCollection.Add("assets/CONSOLA.TTF");
			//font = fontFamily.CreateFont(22, FontStyle.Bold);

			//using var yolo = YoloV8Predictor.Create("./assets/yolov8m.onnx", null, true);
			var lables = new string[] { "phone" };
			using var yolo = YoloV8Predictor.Create("d:/train20230831/best_n.onnx", lables, true);
			using var image = Image.Load("D:\\run0831\\camcache\\00001.jpg");
			var predictions = yolo.Predict(image);

			//foreach(var file in Directory.GetFiles("D:/webjpg", "*.jpg"))
			//{
			//	var image2 = Image.Load(file);
			//	DateTime dt1 = DateTime.Now;
			//	predictions = yolo.Predict(image2);
			//	DateTime dt2 = DateTime.Now;
			//	var ts = dt2.Subtract(dt1);
			//	Console.WriteLine($"{ts.TotalMilliseconds} ms NO.{file}");
			//	DrawBoxes(yolo.ModelInputHeight, yolo.ModelInputWidth, image2, predictions);

			//	image2.Save($"{file}.out.jpg");
			//}

			//DrawBoxes(yolo.ModelInputHeight, yolo.ModelInputWidth, image, predictions);

			//image.Save("result_cam234_0086.jpg");
		}

		//private static void DrawBoxes(int modelInputHeight, int modelInputWidth, Image image, Prediction[] predictions)
		//{
		//	foreach (var pred in predictions)
		//	{
		//		var originalImageHeight = image.Height;
		//		var originalImageWidth = image.Width;

		//		var x = (int)Math.Max(pred.Rectangle.X, 0);
		//		var y = (int)Math.Max(pred.Rectangle.Y, 0);
		//		var width = (int)Math.Min(originalImageWidth - x, pred.Rectangle.Width);
		//		var height = (int)Math.Min(originalImageHeight - y, pred.Rectangle.Height);

		//		//Note that the output is already scaled to the original image height and width.

		//		// Bounding Box Text
		//		string text = $"{pred.Label.Name} [{pred.Score}]";
		//		var size = TextMeasurer.MeasureSize(text, new TextOptions(font));

		//		image.Mutate(d => d.Draw(Pens.Solid(Color.Yellow, 2),
		//			new Rectangle(x, y, width, height)));

		//		image.Mutate(d => d.DrawText(text, font, Color.Yellow, new Point(x, (int)(y - size.Height - 1))));

		//	}
		//}
	}
}