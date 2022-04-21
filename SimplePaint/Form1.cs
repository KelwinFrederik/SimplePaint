using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        DrawningOptions _drawningOptions = new DrawningOptions();
        public Form1()
        {
            InitializeComponent();
            AjustarComponentes();
        }

        #region Methods
        private void AjustarComponentes()
        {
            AjustarEspessuraComboBox();
            AjustarDrawningOptions(true);
            AjustarBorrachaButton();
        }

        private void AjustarEspessuraComboBox()
        {
            espessuraComboBox.MaxDropDownItems = 5;
            espessuraComboBox.IntegralHeight = false;

            for (int cont = 4; cont <= 100; cont += 4)
                espessuraComboBox.Items.Add(cont);

            espessuraComboBox.SelectedIndex = 0;
        }

        private void AjustarDrawningOptions(bool newGraphicsPanel)
        {
            if (newGraphicsPanel)
            {
                _drawningOptions.BitmapSave = new Bitmap(paintPanel.Width, paintPanel.Height);
                _drawningOptions.GraphicsPanel = paintPanel.CreateGraphics();
                _drawningOptions.GraphicsImage = Graphics.FromImage(_drawningOptions.BitmapSave);
                _drawningOptions.GraphicsImage.Clear(paintPanel.BackColor);
            }

            _drawningOptions.PenOptions = new Pen(corButton.BackColor, float.Parse(espessuraComboBox.Text));
            _drawningOptions.EraserOptions.Width = float.Parse(espessuraComboBox.Text);
        }

        private void AjustarBorrachaButton()
        {
            if (_drawningOptions.CanErase)
                borrachaButton.BackColor = _drawningOptions.EraserOptions.Color;
            else
                borrachaButton.BackColor = Color.Transparent;
        }
        #endregion

        #region Events
        private void CorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            DialogResult escolha =  colorDialog.ShowDialog(this);

            if (escolha == DialogResult.OK)
                corButton.BackColor = colorDialog.Color;

            AjustarDrawningOptions(false);
        }
        
        private void espessuraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AjustarDrawningOptions(false);
        }

        private void paintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            _drawningOptions.Drawn(point);
        }

        private void paintPanel_MouseDown(object sender, MouseEventArgs e)
        {

            if (_drawningOptions.CanErase)
                _drawningOptions.Erasing = true;
            else
                _drawningOptions.CanDrawning = true;
        }   

        private void paintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (_drawningOptions.CanDrawning)
                _drawningOptions.CanDrawning = false;
            else if (_drawningOptions.Erasing)
                _drawningOptions.Erasing = false;
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Ao limpar todo o desenho será perdido. Deseja limpar todo o desenho ?", "Limpar Desenho", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogresult == DialogResult.Yes)
                _drawningOptions.ClearGraphic();
        }
        
        private void borrachaButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    _drawningOptions.EraserOptions.Color = colorDialog.Color;
                    AjustarBorrachaButton();
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                _drawningOptions.ChangeErase();
                AjustarBorrachaButton();
            }
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            _drawningOptions.SaveImage();
        }

        private void paintPanel_Resize(object sender, EventArgs e)
        {
            _drawningOptions.GraphicsPanel = paintPanel.CreateGraphics();

            var imagemTemp = _drawningOptions.BitmapSave = new Bitmap(paintPanel.Width, paintPanel.Height);
            var GraphicsImagemTemp = Graphics.FromImage(imagemTemp);
            GraphicsImagemTemp.DrawImage(_drawningOptions.BitmapSave, 0,0);

            _drawningOptions.BitmapSave = imagemTemp;
            _drawningOptions.GraphicsImage = GraphicsImagemTemp;
        }
        #endregion
    }

    class DrawningOptions 
    {
        public bool CanDrawning { get; set; } = false;
        public bool CanErase { get; private set; } = false;
        public bool Erasing { get; set; } = false;
        public Pen PenOptions { get; set; } = new Pen(Color.Red);
        public Pen EraserOptions { get; set; } = new Pen(Color.White);
        public Graphics GraphicsPanel { get; set; }
        public Graphics GraphicsImage { get; set; }
        public Bitmap BitmapSave { get; set; } = new Bitmap(1, 1);

        public void ChangeErase()
        {
            CanErase = !CanErase;
        }

        public void Drawn(Point point)
        { 
            if (CanDrawning)
            {
                SizeF size = new SizeF(PenOptions.Width, PenOptions.Width);
                GraphicsPanel.DrawEllipse(PenOptions, new RectangleF(point, size));
                GraphicsImage.DrawEllipse(PenOptions, new RectangleF(point, size));
            }
            else if (Erasing)
            {
                SizeF size = new SizeF(EraserOptions.Width, EraserOptions.Width);
                GraphicsPanel.DrawRectangle(EraserOptions, new Rectangle(point, size.ToSize()));
                GraphicsImage.DrawRectangle(EraserOptions, new Rectangle(point, size.ToSize()));
            }
        }

        public void ClearGraphic()
        {
            GraphicsPanel.Clear(Color.White);
            GraphicsImage.Clear(Color.White);
        }

        public void SaveImage()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Portable Network Graphics|.png|Arquivi JPEG|.jpeg";
            
            if(saveFile.ShowDialog() == DialogResult.OK)
                switch (saveFile.FilterIndex)
                {
                    case 1:
                        BitmapSave.Save(saveFile.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        BitmapSave.Save(saveFile.FileName, ImageFormat.Jpeg);
                        break;
                }
        }
    }
}