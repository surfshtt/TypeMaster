using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FallingWords : Form
    {
        LoginForm _logInstance;
        MainForm _mainInstance;
        int mode;

        private Random random = new Random();
        private char[][] russianWords = new char[][]
        {
            new char[] { 'м', 'а', 'ш', 'и', 'н', 'а' },
            new char[] { 'к', 'о', 'т' },
            new char[] { 'с', 'о', 'б', 'а', 'к', 'а' },
            new char[] { 'д', 'е', 'р', 'е', 'в', 'о' },
            new char[] { 'с', 'т', 'о', 'л' },
            new char[] { 'р', 'е', 'к', 'а' },
            new char[] { 'г', 'о', 'р', 'о', 'д' },
            new char[] { 'д', 'о', 'м' },
            new char[] { 'с', 'в', 'е', 'т' },
            new char[] { 'к', 'н', 'и', 'г', 'а' },
            new char[] { 'к', 'н', 'и', 'г', 'и' },
            new char[] { 'ж', 'у', 'к' },
            new char[] { 'с', 'н', 'е', 'г' },
            new char[] { 'л', 'и', 'с', 'а' },
            new char[] { 'м', 'и', 'р' },
            new char[] { 'т', 'е', 'л', 'е' },
            new char[] { 'п', 'е', 'н', 'ь' },
            new char[] { 'з', 'а', 'я', 'ц' },
            new char[] { 'н', 'о', 'в', 'ь' },
            new char[] { 'к', 'у', 'б' },
            new char[] { 'р', 'о', 'з', 'а' },
            new char[] { 'в', 'е', 'т' },
            new char[] { 'п', 'и', 'к', 'а' },
            new char[] { 'ш', 'а', 'р' },
            new char[] { 'б', 'е', 'л', 'ь' },
            new char[] { 'м', 'а', 'й' },
            new char[] { 'с', 'т', 'а' },
            new char[] { 'ж', 'и', 'т', 'ь' },
            new char[] { 'ч', 'а', 'й' },
            new char[] { 'к', 'у', 'р' },
            new char[] { 'с', 'н', 'и', 'г' },
            new char[] { 'д', 'е', 'н', 'ь' },
            new char[] { 'с', 'а', 'н' },
            new char[] { 'б', 'о', 'к' },
            new char[] { 'н', 'а', 'с' },
            new char[] { 'м', 'и', 'н' },
            new char[] { 'д', 'у', 'ш', 'а' },
            new char[] { 'з', 'а', 'в' },
            new char[] { 'п', 'а', 'р' },
            new char[] { 'л', 'и', 'с', 'т' },
            new char[] { 'с', 'о', 'л', 'н', 'ц', 'е' },
            new char[] { 'к', 'а', 'т' },
            new char[] { 'т', 'и', 'х', 'и' },
            new char[] { 'ж', 'а', 'н' },
            new char[] { 'к', 'л', 'и', 'н' },
            new char[] { 'в', 'и', 'к', 'и' },
            new char[] { 'п', 'а', 'ш', 'а' },
            new char[] { 'т', 'а', 'л', 'а' },
            new char[] { 'п', 'и', 'в' },
            new char[] { 'д', 'а', 'н' },
            new char[] { 'к', 'е', 'л', 'ь' },
            new char[] { 'г', 'а', 'р', 'н' },
            new char[] { 'ю', 'н' },
            new char[] { 'с', 'к', 'и' },
            new char[] { 'в', 'о', 'д' },
            new char[] { 'ш', 'и', 'н' },
            new char[] { 'б', 'а', 'л', 'к' },
            new char[] { 'н', 'и', 'к' },
            new char[] { 'м', 'а', 'к' },
            new char[] { 'п', 'е', 'р' },
            new char[] { 'к', 'и', 'н' },
            new char[] { 'ф', 'и', 'л' },
            new char[] { 'с', 'и', 'д' },
            new char[] { 'н', 'и', 'ш' },
            new char[] { 'з', 'а', 'м' },
            new char[] { 'ш', 'и', 'к' },
            new char[] { 'с', 'и', 'с' },
            new char[] { 'т', 'е', 'н' },
            new char[] { 'с', 'а', 'м' },
            new char[] { 'н', 'е', 'т' },
            new char[] { 'м', 'е', 'н' },
            new char[] { 'ч', 'е', 'р' },
            new char[] { 'ж', 'и', 'в' },
            new char[] { 'ц', 'а', 'р' },
            new char[] { 'м', 'а', 'р' },
            new char[] { 'р', 'а', 'ч' },
            new char[] { 'к', 'о', 'з' },
            new char[] { 'г', 'а', 'з' },
            new char[] { 'ш', 'а', 'н' },
            new char[] { 'ф', 'и', 'ш' },
            new char[] { 'н', 'и', 'ж' },
            new char[] { 'д', 'о', 'к' },
            new char[] { 'с', 'к', 'и' },
            new char[] { 'т', 'и', 'к' }
        };

        private static int startY = 150;
        private int[] squareY = { startY, startY, startY, startY, startY }; // Начальная позиция по Y для трех квадратов
        private int[] squareX = { 150, 400, 650, 900, 1150 }; // Начальная позиция по X для трех квадратов
        private int dropAmount = 1; // Количество пикселей, на которое опускается квадрат
        private bool[] down = { true, true, true, true, true, true }; // Направление движения для трех квадратов
        private Dictionary<int, Word> currentWords = new Dictionary<int, Word>();
        private int countOfSquares = 0;

        private int divisions = 0;
        private int filledDivisions = 0;
        private const int rectangleWidth = 400;
        private const int rectangleHeight = 50;

        private const int topStop = 100;
        private const int downStop = 792;


        public FallingWords(LoginForm _l, MainForm _m, int m)
        {
            this.Paint += new PaintEventHandler(DrawSquaresWithWords);
            InitializeComponent();

            _logInstance = _l;
            _mainInstance = _m;
            mode = m;
        }

        private void FallingWords_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logInstance.Close();
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

        private void DrawSquaresWithWords(object sender, PaintEventArgs e)
        {
            if (divisions == 0) return;

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
                RectangleF rect = new RectangleF(squareX[i], squareY[i], 200, 100);
                FillRoundedRectangle(e.Graphics, squareBrush, rect, 30); // 30 - радиус скругления

                // Слово
                string word = currentWords[i].getWord();
                int ch = currentWords[i].getCurrentNum();

                Brush greenBrush = new SolidBrush(Color.FromArgb(168, 255, 128));
                Brush whiteBrush = Brushes.White;

                if (ch != 0)
                {
                    string greenStr = word.Substring(0, ch);

                    // Рисуем слово
                    Font font = new Font("Arial", 21, FontStyle.Bold);
                    Brush textBrush = Brushes.White;
                    SizeF textSize = e.Graphics.MeasureString(word, font);
                    float textX = squareX[i] + (200 - textSize.Width) / 2;
                    float textY = squareY[i] + (100 - textSize.Height) / 2;

                    e.Graphics.DrawString(greenStr, font, greenBrush, textX, textY);

                    float remainingTextX = textX + e.Graphics.MeasureString(greenStr, font).Width;
                    e.Graphics.DrawString(word.Substring(ch), font, whiteBrush, remainingTextX, textY);
                }
                else
                {
                    // Рисуем слово
                    Font font = new Font("Arial", 21, FontStyle.Bold);
                    Brush textBrush = Brushes.White;
                    SizeF textSize = e.Graphics.MeasureString(word, font);
                    float textX = squareX[i] + (200 - textSize.Width) / 2;
                    float textY = squareY[i] + (100 - textSize.Height) / 2;

                    e.Graphics.DrawString(word, font, textBrush, textX, textY);
                }
            }

            // Рисуем основной прямоугольник
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.FromArgb(49, 45, 45)); // #312D2D
            g.FillRectangle(brush, 50, 50, rectangleWidth, rectangleHeight);

            Font f = new Font("Arial", 24, FontStyle.Bold);
            Brush tBrush = Brushes.White;
            SizeF tSize = e.Graphics.MeasureString(filledDivisions.ToString(), f);
            e.Graphics.DrawString(filledDivisions.ToString(), f, tBrush, rectangleWidth / 2 + 25, rectangleHeight / 2 + 30);

            // Рисуем заполненные деления
            Brush fillBrush = new SolidBrush(Color.LightGray);
            int filledWidth = (rectangleWidth / divisions) * filledDivisions;
            g.FillRectangle(fillBrush, 50, 50, filledWidth, rectangleHeight);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            divisions = 0;
            filledDivisions = 0;
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
                int tmp = random.Next(80);
                currentWords.Add(i, new Word(new string(russianWords[tmp])));
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

        private void FallingWords_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < countOfSquares; i++)
            {
                //проверка на пробел надо

                if (e.KeyChar == currentWords[i].getCurrentLetter())
                {
                    if (!currentWords[i].next())
                    {
                        squareX[i] = random.Next(1200); // Новая случайная позиция по X
                        squareY[i] = startY; // Сброс по Y
                        down[i] = true;
                        currentWords.Remove(i);
                        currentWords.Add(i, new Word(new string(russianWords[random.Next(russianWords.Length)])));
                        this.Invalidate();
                        return;
                    }
                    else
                    {
                        filledDivisions++;
                        this.Invalidate();
                        return;
                    }         
                }
            }
            filledDivisions = 0;
            this.Invalidate();
        }
    }

    public class Word
    {
        int currentLetterNum;
        string word;

        public Word(string w)
        {
            currentLetterNum = 0;
            word = w;
        }

        public char getCurrentLetter()
        {
            return word[currentLetterNum];
        }
        public int getCurrentNum()
        {
            return currentLetterNum;
        }

        public bool next()
        {
            currentLetterNum++;

            if (currentLetterNum >= word.Length)
                return false;
            else
                return true;
        }

        public string getWord()
        {
            return word;
        }
    }
}
