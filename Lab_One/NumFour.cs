using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_One
{
  public partial class NumFour : Form
  {
    public NumFour()
    {
      InitializeComponent();
      
      BackColor = Color.Aqua; // задаём цвет фона
      
      button1.Click += new EventHandler(button1_Click); // обработчик нажатия кнопки
     
    }
    
    private void button1_Click(object sender, System.EventArgs e)
    {
      returnResult();
      this.Refresh();
      this.Invalidate();
    }

    private void returnResult() // основная функция
    {
      float x = 0;
      float y = 0;
      float z = 0;
      
      /*
       * пробуем вытащить данные из текстовых блоков, чтобы в дальнейшем использовать
       * (в данном случае числа x и y)
       * TryParse возвращает True, если получилось преобразовать в число и False в обратном случае
       */
      var first = float.TryParse(textBox1.Text, out x); 
      var second = float.TryParse(textBox2.Text, out y);

      if (first && second) 
      { // если получилось конвертировать данные, то вызываем функцию Max или Min в зависимости от условия
        // функции эти из библиотеки Math
        if (x < 0)
        {
          z = Math.Max(x, y);
        }
        if (x >= 0)
        {
          z = Math.Min(x, y);
        }

        label4.Text = Convert.ToString(z); // записываем в табличку значение z(результат)
      }
      else
      {
        label4.Text = "Некорректные данные";
      }

      textBox1.Text = "";
      textBox2.Text = "";
    }
  }
}