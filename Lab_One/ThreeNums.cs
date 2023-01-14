using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_One
{
  public partial class ThreeNums : Form
  {
    public ThreeNums()
    {
      InitializeComponent();
      BackColor = Color.Aqua; // задаём цвет фона
      
      button1.Click += new EventHandler(button1_Click); // обработчик нажатия клавиши
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      conditionHandler(); // вызывает основную функцию
      this.Refresh();
      this.Invalidate();
    }

    private void conditionHandler()
    {
      float firstNumber = 0;
      float secondNumber = 0;
      float thirdNumber = 0;
      
      // заносим то, что написал пользователь в текстовых блоках, в переменные
      var first = float.TryParse(textBox1.Text, out firstNumber);
      var second = float.TryParse(textBox2.Text, out secondNumber);
      var third = float.TryParse(textBox3.Text, out thirdNumber);
      if (first && second && third)
      { // если получается, проверяем условие: число1 < число2 < число3
        if (firstNumber < secondNumber && secondNumber < thirdNumber)
        {
          label5.Text = "Условие выполняется"; // выводим сообщение о выполнение условия на табличку
        }
        else
        {
          label5.Text = "Условие не выполняется";
        }
      }
      else
      {
        label5.Text = "Некорректные значения";
      }

      textBox1.Text = "";
      textBox2.Text = ""; // очищаем текстовые блоки для нового ввода пользователя
      textBox3.Text = "";
    }
  }
}