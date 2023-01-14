using System.ComponentModel;
using System.Drawing;

namespace Lab_One
{
  partial class MatrixDyn
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }

      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.button4 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(1, 2);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(108, 27);
      this.label1.TabIndex = 0;
      this.label1.Text = "Введите n и m:";
      this.label1.BackColor = Color.Chartreuse;
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox1.Location = new System.Drawing.Point(115, 0);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(30, 29);
      this.textBox1.TabIndex = 1;
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBox2
      // 
      this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox2.Location = new System.Drawing.Point(142, 0);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(30, 29);
      this.textBox2.TabIndex = 2;
      this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(189, 0);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(119, 30);
      this.button1.TabIndex = 3;
      this.button1.Text = "Создать";
      this.button1.BackColor = Color.Chartreuse;
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button2.Location = new System.Drawing.Point(305, 0);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(158, 30);
      this.button2.TabIndex = 4;
      this.button2.Text = "Случайные значения";
      this.button2.BackColor = Color.Chartreuse;
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(612, 0);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(124, 30);
      this.button3.TabIndex = 5;
      this.button3.Text = "Результат: ";
      this.button3.BackColor = Color.Chartreuse;
      this.button3.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(732, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(65, 29);
      this.label2.TabIndex = 6;
      this.label2.Text = "";
      this.label2.BackColor = Color.Chartreuse;
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(456, 0);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(159, 30);
      this.button4.TabIndex = 7;
      this.button4.Text = "Обновить матрицу";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // MatrixDyn
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Name = "MatrixDyn";
      this.Text = "MatrixDyn";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Label label1;

    #endregion
  }
}