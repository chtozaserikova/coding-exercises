using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace лаба2

{
    public partial class Form1 : Form
    {

        public bool _dragging = true;
        int historyCounter;
        Point _oldLocation;
        public SolidBrush myBrush = new SolidBrush(Color.Red);
        Pen _currentPen;
        Cursor _penCursor;
        Cursor _eraserCursor;
        GraphicsPath _currentPath;
        Color _bgColor;
        public Color _fgColor;
        Color historyColor; //Сохранение текущего цвета перед использованием ластика
        List<Image> History; //Список для истори

        public Form1()
        {
            InitializeComponent();
            _dragging = false; //Переменная, ответственная за рисование
            _currentPen = new Pen(Color.Black); //Инициализация пера с черным цвето
            History = new List<Image>(); //Инициализация списка для истори
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
                savedialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image | *.png";
                //отображается ли кнопка "Справка" в диалоговом окне
                savedialog.FilterIndex = 4;
                savedialog.ShowHelp = true;
                savedialog.ShowDialog();

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
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка ? ", "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: saveToolStripMenuItem_Click_1(sender, e); break;
                    case DialogResult.Cancel: return;
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
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!");
                return;
            }

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
            if (History.Count != 0 && historyCounter != 0)
            {
                picDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            }
            else MessageBox.Show("История пуста");
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
            _dragging = false;
            try
            {
                _currentPath.Dispose();
            }
            catch { };         
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.Clear();
            historyCounter = 0;
            Bitmap pic = new Bitmap(750, 500);
            picDrawingSurface.Image = pic;
            History.Add(new Bitmap(picDrawingSurface.Image));

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1)
            {
                picDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            }
            else MessageBox.Show("История пуста");

        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentPen.DashStyle = DashStyle.Solid;
            solidStyleMenu.Checked = true;
            dotStyleMenu.Checked = false;
            dashDotDotStyleMenu.Checked = false;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentPen.DashStyle = DashStyle.Dot;
            solidStyleMenu.Checked = false;
            dotStyleMenu.Checked = true;
            dashDotDotStyleMenu.Checked = false;
        }

        private void styleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashDotDotStyleMenu_Click(object sender, EventArgs e)
        {
            _currentPen.DashStyle = DashStyle.DashDotDot;
            solidStyleMenu.Checked = false;
            dotStyleMenu.Checked = false;
            dashDotDotStyleMenu.Checked = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void myColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(_currentPen.Color);
            f.ShowDialog();
            _currentPen.Color =  f.get_color_result();
        }
    }
}