namespace DataMatrixGenerator
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.InitializeComponent();
        }

        private void EncodeClick(object sender, EventArgs e)
        {
            try
            {
                this.dataMatrixImage.Image = this.EncodeText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InputTextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataMatrixImage.Image = this.EncodeText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Bitmap EncodeText()
        {
            var encoder = new DataMatrixEncoder();
            encoder.Encode(this.input.Text);

            var columns = encoder.GetColumns();
            var rows = encoder.GetRows();

            var image = new Bitmap(this.dataMatrixImage.Width, this.dataMatrixImage.Height);
            var scale = (float)image.Width / columns;

            using (var graphics = Graphics.FromImage(image))
            {
                for (var row = 0; row < rows; row++)
                {
                    for (var column = 0; column < columns; column++)
                    {
                        var colorCode = encoder.GetModule(column, row) == 0
                                            ? Color.White
                                            : Color.Black;

                        graphics.FillRectangle(
                            new SolidBrush(colorCode),
                            new RectangleF(
                            column * scale,
                            row * scale,
                            scale,
                            scale));
                    }
                }
            }

            return image;
        }

        private void TrackTextChangeCheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                this.input.TextChanged += this.InputTextChanged;
                this.encodeButton.Enabled = false;
            }
            else
            {
                this.input.TextChanged -= this.InputTextChanged;
                this.encodeButton.Enabled = true;
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (this.dataMatrixImage.Image == null)
            {
                MessageBox.Show("Nothing to save!");
                return;
            }

            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            this.dataMatrixImage.Image
                .Save(Path.Combine(desktopPath, $"datamatrix {DateTime.Now:yyyy-MM-dd_hh_mm_ss}.jpg"));
        }
    }
}
