using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_One
{
  public partial class NumThree : Form
  {
    public NumThree()
    {
      InitializeComponent();
      
      BackColor = Color.Aqua; // задаём размер фона
      
      button1.Click += new EventHandler(button1_Click); // обработчик нажатия клавиши
      
    }

    private void WorkingWithArray() // основная функция работы с массивом
    {
      label3.Text = "";
      if (Int32.TryParse(textBox2.Text, out var arrSize)) // пробуем достать размер массива из текстового блока
      { // если получается(пользователь ввёл верно), создаем массив и массив строк
        var numArray = new int[arrSize];
        var numStr = new string[arrSize * 2];
        
        numStr = (textBox1.Text).Split(' '); // разделяем массив, который ввёл пользователь на подстроки
        // и записываем в массив строк

        for (int i = 0; i < arrSize; i++)
        { // каждую подстроку пробуем перевести в число
          var checkNum = Int32.TryParse(numStr[i], out numArray[i]); 
          if (!checkNum)
          { // если не получается, выводим сообщение о неправильном вводе
            label3.Text = "Некорректный ввод";
            textBox1.Text = textBox2.Text = "";
            break;
          }
        }
        SwapMaxAndMin(ref numArray); // вызываем функцию замены максимальных на минимальные и наоборот
        for (var i = 0; i < arrSize; i++)
        {
          label3.Text += Convert.ToString(numArray[i]) + " "; // заносим всё это в табличку(обновленный массив)
        }
      }
      else
      {
        label3.Text = "Неверно задан размер массива";
        textBox1.Text = textBox2.Text = "";
      }


    }
    
    private void button1_Click(object sender, System.EventArgs e)
    {
      WorkingWithArray();
      this.Refresh();
      this.Invalidate();
    }

    private void SwapMaxAndMin(ref int[] array)
    { // функция замены наименьшего числа на наибольшее и наоборот
      if (array.Length == 0)
        return;

      var min = array.Min(); // готовая функция(находит максимальный элемент в массиве
      var max = array.Max(); // находит минимальный элемент в массиве

      if (min == max)
        return; // если все числа одинаковые, то ничего не меняем, возвращаем как есть

      for (var i = 0; i < array.Length; i++)
      { // проходимся по массиву и меняем элементы с минимальным значением на максимальные и наоборот
        if (array[i] == min)
          array[i] = max;
        else if (array[i] == max)
          array[i] = min;
      }
    }
  }
  
}