using System.Windows.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace Lab_One
{
  public partial class Matrix_18x24_ : Form
  {
    TextBox[] _txtBoxArr; // создаём матрицу текстовых полей для вывода на экран
    float[,] matrix = new float[18,24]; // обычная матрица, с которой будем работать
    private int _textBoxSize = 0; // переменная, в которой будет храниться размер матрицы текстовых полей
    private Random _rand = new Random(); // создаём экземпляр класса рандом
    public Matrix_18x24_()
    {
      InitializeComponent();
      BackColor = Color.Aqua; // задаём цвет фона
      
      ShowTextBox();
      
      { // обработчики событий нажатия клавиш
        button1.Click += new EventHandler(button1_Click);

        button2.Click += new EventHandler(button2_Click);

        button3.Click += new EventHandler(button3_Click);

      }
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      label2.Text = ""; // делаем текст таблички пустым
      /*
       * пробуем вытащить данные из текстовых блоков, чтобы в дальнейшем использовать
       * (в данном случае размер матрицы n и m)
       * TryParse возвращает True, если получилось преобразовать в число и False в обратном случае
       */
      var first = Int32.TryParse(textBox1.Text, out var n);  
      var second = Int32.TryParse(textBox2.Text, out var m);
      if (first && second) // проверяем, получилось ли достать данные
      {
        Swapij(n, m); // если получилось, вызываем функцию обмена столбцов матрицы
      }
      else
      {
        label2.Text = "Неверно введены индексы!"; // при ошибке выносим надпись на табличку
      }
      this.Refresh(); //  нужно для обновления содержимого окна
      this.Invalidate();
    }
    
    private void button2_Click(object sender, System.EventArgs e)
    {
      RandomFill(); //  вызываем функцию заполнения случайными числами
      this.Refresh();
      this.Invalidate();
    }
    
    private void button3_Click(object sender, System.EventArgs e)
    { //Кнопка обнуляет значения матрицы текстовых блоков
      for (var i = 1; i <= 18 * 24; i++)
      {
        _txtBoxArr[i].Text = ""; // собственно каждому блоку присваиваем значение пустой строки
      }
      this.Refresh();
      this.Invalidate();
    }

    private void AddControls(int cNumber) 
    {
      // создаем массив текстовых блоков размером cNumer = n*m
      _txtBoxArr = new System.Windows.Forms.TextBox[cNumber + 1];
      for (int i = 0; i < cNumber + 1; i++)
      {
        // В цикле инициализируем каждый текстовый блок
        _txtBoxArr[i] = new System.Windows.Forms.TextBox();
      }
    }

    private void ShowTextBox()
    {
      // задаём начальную позицию по х и y:
      int xPos = 8; 
      int yPos = 32;
      _textBoxSize = 18 * 24; // задаём количество текстовых блоков
      AddControls(_textBoxSize); // Вызываем функцию создания блоков с передачей количества
      int n = 1;
      // в цикле проходимся по каждому блоку и задаём ему размеры и значения:
      while (n < _textBoxSize + 1)
      {
        _txtBoxArr[n].Tag = n;
        _txtBoxArr[n].Width = 32;
        _txtBoxArr[n].Height = 24;
        _txtBoxArr[n].BackColor = System.Drawing.SystemColors.Info;
        _txtBoxArr[n].Text = "0";

        if (xPos > 24 * 32 + 1) // меняем координаты, пока в строке не будет столько блоков, сколько мы хотим
        { // в нашем случае 24 блока в строке
          xPos = 8;
          yPos = yPos + _txtBoxArr[n].Height;
        }

        _txtBoxArr[n].Left = xPos;
        _txtBoxArr[n].Top = yPos;
        xPos = xPos + _txtBoxArr[n].Width; // меняем позицию каждого нового блока по иксу
        this.Controls.Add(_txtBoxArr[n]);
        n++;
      }
    }

    private void RandomFill() // функция заполнения матрицы случайными числами
    {
      var txtBoxCounter = 1;
      for (var i = 0; i < 18; i++)
      {
        for (var j = 0; j < 24; j++)
        {
          matrix[i, j] = (float)_rand.NextDouble() * 300F; // заполняем случайными десятичными числами от 0 до 300 
          _txtBoxArr[txtBoxCounter].Text = Convert.ToString(matrix[i, j]); // вписываем информацию из матрицы в текст. блоки
          txtBoxCounter++;
        }
      }
    }

    private void Swapij(int n, int m) // функция замены двух столбцов
    {
      if ((n > 0 && n < 25) && (m > 0 && m < 25)) // проверяем, верно ли заданы номера столбцов( не должно быть больше 24)
      {
        var txtBoxCounter = 1;
        float temp;
        for (var k = 0; k < 18; k++)
        {
          temp = matrix[k, n-1];
          matrix[k, n-1] = matrix[k, m-1]; //меняем каждое значение в столбце i и j друг на друга
          matrix[k, m-1] = temp;
        }
        for (var i = 0; i < 18; i++)
        {
          for (var j = 0; j < 24; j++)
          {
            _txtBoxArr[txtBoxCounter].Text = Convert.ToString(matrix[i, j]); // вносим обновленные данные в тексовые блоки
            txtBoxCounter++;
          }
        }
      }
      else
      {
        label2.Text = "Неверно введены индексы!";
      }
    }
  }
}