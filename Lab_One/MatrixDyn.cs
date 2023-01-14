using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Printing;

namespace Lab_One
{
  public partial class MatrixDyn : Form
  {
    private TextBox[] _txtBoxArr = null;
    private float[,] _matrix = null;
    private int _textBoxSize = 0;
    private Random _rand = new Random();
    private int _n, _m;
    
    public MatrixDyn()
    {
      BackColor = Color.Aqua;
      InitializeComponent();

      { // создаем обработчики нажатия кнопок
        button1.Click += new EventHandler(button1_Click);
        
        button2.Click += new EventHandler(button2_Click);
        
        button3.Click += new EventHandler(button3_Click);
        
        button4.Click += new EventHandler(button4_Click);

      }
    }
    
    private void button1_Click(object sender, System.EventArgs e)
    {
      _matrix = null; //обнуляем матрицу
      CreateMatrix(); // функция создания матрицы текстовых блоков
      this.Refresh();
      this.Invalidate();
    }
    
    private void button2_Click(object sender, System.EventArgs e)
    {
      if (_n != 0 && _m != 0) // проверяем, чтоб размер не был равен нулю
      {
        RandomFill(_n, _m); // заполняем матрицу случайными числами
      }

      Refresh();
      Invalidate();
    }
    
    private void button3_Click(object sender, System.EventArgs e)
    {
      FindMinAmongMax(); // вызываем функцию поиска минимального числа среди максимальных в каждой строке
      Refresh();
      Invalidate();
    }
    
    private void button4_Click(object sender, System.EventArgs e)
    {
      GetIntoMatrix(); // вызываем функцию переноса данных из текстовых блоков в матрицу
      Refresh();
      Invalidate();
    }
    
    private void AddControls(int cNumber)
    { // создаем массив текстовых блоков размером cNumer = n*m
      _txtBoxArr = new System.Windows.Forms.TextBox[cNumber];
      for (int i = 0; i < cNumber; i++)
      {
        // В цикле инициализируем каждый текстовый блок
        _txtBoxArr[i] = new System.Windows.Forms.TextBox();
      }
    }
    
    private void ShowTextBox(int i, int j)
    { // всё точно так же как в Matrix(18x24), но размер задаёт пользователь(i и j)
      var xPos = 8;
      var yPos = 32;
      _textBoxSize = i * j; 
      AddControls(_textBoxSize);
      var n = 0;
      while (n < _textBoxSize)
      {
        _txtBoxArr[n].Tag = n;
        _txtBoxArr[n].Width = 32;
        _txtBoxArr[n].Height = 24;
        _txtBoxArr[n].Text = "0";

        if (xPos > j * 32)
        {
          xPos = 8;
          yPos += _txtBoxArr[n].Height;
        }

        _txtBoxArr[n].Left = xPos;
        _txtBoxArr[n].Top = yPos;
        xPos = xPos + _txtBoxArr[n].Width;
        Controls.Add(_txtBoxArr[n]);
        n++;
      }
    }

    private void CreateMatrix()
    {
      if (_txtBoxArr != null)
      {
        DeleteTextboxes(_n, _m); // если матрица уже была создана, вызываем функцию удаления текстовых блоков, чтоб создать потом заново
      }
      /*
       * пробуем вытащить данные из текстовых блоков, чтобы в дальнейшем использовать
       * (в данном случае размер матрицы n и m)
       * TryParse возвращает True, если получилось преобразовать в число и False в обратном случае
       */
      var first = Int32.TryParse(textBox1.Text, out _n);
      var second = Int32.TryParse(textBox2.Text, out _m); 

      if (first && second)
      {
        _matrix = null;
        _matrix = new float[_n, _m]; // создаем матрицу n на m
        ShowTextBox(_n, _m); // вызываем функцию создания матрицы текстовых блоков

      }
    }
    
    private void RandomFill(int n, int m) // заполнение случайными числами, как в Matrix(18x24)
    {
      var txtBoxCounter = 0;
      for (var i = 0; i < n; i++)
      {
        for (var j = 0; j < m; j++)
        {
          _matrix[i, j] = (float)_rand.NextDouble() * 500F;
          _txtBoxArr[txtBoxCounter].Text = Convert.ToString(_matrix[i, j]);
          txtBoxCounter++;
        }
      }
    }

    private void DeleteTextboxes(int n, int m)
    {
      for (var i = 0; i < n * m; i++)
      {
        _txtBoxArr[i].Dispose(); // удаляем каждый текстовых блок в цикле
      }
      _txtBoxArr = null; // обнуляем массив текстовых блоков
    }

    private void FindMinAmongMax()
    {
      var maxMatrix = new float[_n]; // создаем массив, куда будем записывать максимальные числа в строке
      var indexesMtrx = new int[_n, 2]; // массив для индексов этих чисел
      float max;

      for (var i = 0; i < _n; i++)
      { // приравниваем переменную max  к первому элементу в строку
        max = _matrix[i, 0];
        for (var j = 0; j < _m; j++)
        { // в цикле проходимся по каждому числу в строке матрицы
          if (_matrix[i, j] > max)
          { // если элемент больше, чем предыдущий, то max берёт значение этого элемента
            max = _matrix[i, j];
            indexesMtrx[i, 0] = i;
            indexesMtrx[i, 1] = j;
          }
        }
        maxMatrix[i] = max;
      }

      max = maxMatrix[0];
      for (var i = 0; i < _n; i++)
      { // выводим в табличку на экран индекс минимального среди максимальных
        if (maxMatrix[i] < max) label2.Text = Convert.ToString(indexesMtrx[i, 0]) +
                                              "  " + Convert.ToString(indexesMtrx[i, 1]);
      }
    }

    private void GetIntoMatrix() // собираем данные из текстовых блоков в матрицу, чтоб дальше работать с ними
    {
      var txtBoxCounter = 0;
      for (var i = 0; i < _n; i++)
      {
        for (var j = 0; j < _m; j++)
        {
          var check = float.TryParse(_txtBoxArr[txtBoxCounter].Text, out _matrix[i, j]);
          txtBoxCounter++;
          if (!check)
          {
            txtBoxCounter = -1;
            break;
          }
        }

        if (txtBoxCounter == -1) break;
      }
    }
  }
}