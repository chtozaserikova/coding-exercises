using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace лаба2

{
    public partial class Form1 : Form
    {

        public bool _dragging = true;
        Point _oldLocation;
        public System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        Pen _currentPen;
        Cursor _penCursor;
        Cursor _eraserCursor;
        GraphicsPath _currentPath;
        Color _bgColor;
        Color _fgColor;

        public Form1()
        {
            InitializeComponent();
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        { }
  
            private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {
                string[] fileNames;
                //int fileNumber = 0;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileNames = ofd.FileNames;
                    picDrawingSurface.Image = Image.FromFile(fileNames[0]);
                }
                ofd.Dispose();
            }

            private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                //отображается ли кнопка "Справка" в диалоговом окне
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        picDrawingSurface.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Серикова ПИ 3-3");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dragging = false;
            _currentPen = new Pen(myBrush);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = true;
                _oldLocation = e.Location;
                _currentPath = new GraphicsPath();
            }
            if (e.Button == MouseButtons.Right)
            {
                if (picDrawingSurface.Cursor == _penCursor)
                {
                    picDrawingSurface.Cursor = _eraserCursor;
                    _currentPen.Color = _bgColor;
                }
                else
                {
                    picDrawingSurface.Cursor = _penCursor;
                    _currentPen.Color = _fgColor;
                }
            }


        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();
            if (_dragging)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                _currentPath.AddLine(_oldLocation, e.Location);
                g.DrawPath(_currentPen, _currentPath);
                _oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(picDrawingSurface.Image);
            g.Clear(_bgColor);
            g.Dispose();
            picDrawingSurface.Invalidate();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _fgColor = dlg.Color;
                _currentPen.Color = _fgColor;
            }
        }

        private void trkPenWidth_ValueChanged(object sender, EventArgs e)
        {
            _currentPen.Width = trkPenWidth.Value;
        }

        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = false;
                try
                {
                    _currentPath.Dispose();
                }
                catch { };
            }
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void penToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trkPenWidth_Scroll(object sender, EventArgs e)
        {
            _currentPen.Width = trkPenWidth.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}