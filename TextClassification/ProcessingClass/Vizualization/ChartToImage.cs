using LiveChartsCore.SkiaSharpView.WinForms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace TextClassification.ProcessingClass.Vizualization
{
    public class ChartToImage
    {
        public void Save(PieChart pie)
        {

            Bitmap bm = new(pie.Size.Width, pie.Size.Height);
            pie.DrawToBitmap(bm, new Rectangle(0, 0, pie.Size.Width, pie.Size.Height));

            SaveFileDialog saveFileDialog = new() { Filter = "PNG file|*.png" };
            if(saveFileDialog.ShowDialog() == DialogResult.OK) bm.Save(saveFileDialog.FileName, ImageFormat.Png);


        }
        public void Save(CartesianChart cartesian)
        {
            Bitmap bm = new(cartesian.Size.Width, cartesian.Size.Height);
            cartesian.DrawToBitmap(bm, new Rectangle(0, 0, cartesian.Size.Width, cartesian.Size.Height));

            SaveFileDialog saveFileDialog = new() { Filter = "PNG file|*.png" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK) bm.Save(saveFileDialog.FileName, ImageFormat.Png);
        }
    }
}
