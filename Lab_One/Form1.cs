using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_One
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      Refresh();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      BackColor = Color.Aqua;
      
      { 
        /*
         * Обработчики нажатия кнопок, можно было сделать не в этом файле, но для наглядности тут.
         */
        button1.Click += new EventHandler(button1_Click);

        button2.Click += new EventHandler(button2_Click);

        button3.Click += new EventHandler(button3_Click);
        
        button4.Click += new EventHandler(button4_Click);
        
        button5.Click += new EventHandler(button5_Click);
        
        button6.Click += new EventHandler(button6_Click);
      }
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      var FirstEx = new ThreeNums(); // Создаёт новый экземпляр формы
      FirstEx.Show(); // Показывает новую форму
    }  
    
    private void button2_Click(object sender, System.EventArgs e)
    {
      var SecondEx = new Matrix_18x24_(); // Создаёт новый экземпляр формы
      SecondEx.Show(); 
    }  
    
    private void button3_Click(object sender, System.EventArgs e)
    {
      var NumThree = new NumThree(); // Создаёт новый экземпляр формы
      NumThree.Show();
    }  
    
    private void button4_Click(object sender, System.EventArgs e)
    {
      var FourthEx = new NumFour(); // Создаёт новый экземпляр формы
      FourthEx.Show();
    }  
    
    private void button5_Click(object sender, System.EventArgs e)
    {
      var Matrix2 = new MatrixDyn(); // Создаёт новый экземпляр формы
      Matrix2.Show();
    }  
    
    private void button6_Click(object sender, System.EventArgs e)  
    {  
      Application.Exit(); // Выходит из программы(закрывает)
    }  
  }
}