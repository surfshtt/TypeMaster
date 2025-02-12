using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FallingLetters : Form
    {
        LoginForm _logInstance;
        MainForm _mainInstance;
        int mode;

        private Random random = new Random();
        private char[] russianAlphabet =
        {
            'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
            'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
            'ы', 'ь', 'э', 'ю', 'я'
        };

        private static int startY = 150;
        private int[] squareY = { startY, startY, startY, startY, startY }; // Начальная позиция по Y для трех квадратов
        private int[] squareX = { 200, 400, 600, 800, 1000 }; // Начальная позиция по X для трех квадратов
        private int dropAmount = 1; // Количество пикселей, на которое опускается квадрат
        private bool[] down = { true, true, true, true, true, true }; // Направление движения для трех квадратов
        private char[] currentLetters = new char[5]; // Массив текущих букв
        private int countOfSquares = 0;

        private int divisions = 0;
        private int filledDivisions = 0;
        private const int rectangleWidth = 400;
        private const int rectangleHeight = 50;

        private const int topStop = 100;
        private const int downStop = 792;

        public FallingLetters(LoginForm loginst, MainForm maininst, int m)
        {
            this.Paint += new PaintEventHandler(DrawSquaresWithLetters);
            InitializeComponent();

            _logInstance = loginst;
            _mainInstance = maininst;
            mode = m;
        }

        private void FillRoundedRectangle(Graphics g, Brush brush, RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            g.FillPath(brush, path);
        }

        private void DrawSquaresWithLetters(object sender, PaintEventArgs e)
        {
            if(divisions == 0) return;

            for (int i = 0; i < countOfSquares; i++)
            {
                Color squareColor;

                if (down[i])
                {
                    squareColor = ColorTranslator.FromHtml("#312D2D");
                }
                else
                {
                    squareColor = ColorTranslator.FromHtml("#FFA8A8");
                    filledDivisions = 0;
                }

                // Рисуем квадрат со скругленными краями
                Brush squareBrush = new SolidBrush(squareColor);
                RectangleF rect = new RectangleF(squareX[i], squareY[i], 100, 100);
                FillRoundedRectangle(e.Graphics, squareBrush, rect, 30); // 20 - радиус скругления

                // Генерируем случайную букву
                string randomLetter = currentLetters[i].ToString();

                // Рисуем букву
                Font font = new Font("Arial", 34, FontStyle.Bold);
                Brush textBrush = Brushes.White;
                SizeF textSize = e.Graphics.MeasureString(randomLetter, font);
                float textX = squareX[i] + (100 - textSize.Width) / 2;
                float textY = squareY[i] + (100 - textSize.Height) / 2;

                e.Graphics.DrawString(randomLetter, font, textBrush, textX, textY);
            }

            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.FromArgb(49, 45, 45)); // #312D2D
            g.FillRectangle(brush, 50, 50, rectangleWidth, rectangleHeight);

            Font f = new Font("Arial", 24, FontStyle.Bold);
            Brush tBrush = Brushes.White;
            SizeF tSize = e.Graphics.MeasureString(filledDivisions.ToString(), f);
            e.Graphics.DrawString(filledDivisions.ToString(), f, tBrush, rectangleWidth / 2 + 25, rectangleHeight / 2 + 30);

            // Draw filled divisions
            Brush fillBrush = new SolidBrush(Color.LightGray);
            int filledWidth = (rectangleWidth / divisions) * filledDivisions;
            g.FillRectangle(fillBrush, 50, 50, filledWidth, rectangleHeight);
        }

        private void FallingLetters_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logInstance.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            divisions = 0;
            filledDivisions = 0;
            _mainInstance.Show();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.Image = Image.FromFile($"pics/BackButtonP.png");
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.Image = Image.FromFile($"pics/BackButtonNP.png");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            filledDivisions = 0;

            switch (mode)
            {
                case 1:
                    timer.Interval = 20;
                    divisions = 20;
                    countOfSquares = 3;
                    dropAmount = 1;
                    break;

                case 2:
                    timer.Interval = 20;
                    divisions = 30;
                    countOfSquares = 5;
                    dropAmount = 2;
                    break;

                case 3:
                    timer.Interval = 20;
                    divisions = 40;
                    countOfSquares = 5;
                    dropAmount = 3;
                    break;
            }

            for (int i = 0; i < countOfSquares; i++)
            {
                currentLetters[i] = russianAlphabet[random.Next(russianAlphabet.Length)];
            }

            timer.Enabled = true;
            StartButton.Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < countOfSquares; i++)
            {
                if (down[i])
                {
                    squareY[i] += dropAmount;
                }
                else
                {
                    squareY[i] -= dropAmount;
                }

                if (squareY[i] < topStop)
                    down[i] = true;
                else if (squareY[i] > downStop)
                    down[i] = false;
            }

            this.Invalidate();
        }

        private void FallingLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < countOfSquares; i++)
            {
                if (e.KeyChar == currentLetters[i])
                {
                    squareY[i] = -100; // Убираем квадрат за пределы видимости
                    squareX[i] = random.Next(1200); // Новая случайная позиция по X
                    squareY[i] = startY; // Сброс по Y
                    down[i] = true;
                    currentLetters[i] = russianAlphabet[random.Next(russianAlphabet.Length)]; // Новая буква
                    filledDivisions++;
                    this.Invalidate();
                    return;
                }
            }
            filledDivisions = 0;
            this.Invalidate();
        }
    }
}
