using System.ComponentModel;

namespace Lab_One
{
  partial class NumThree
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(1, 59);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(327, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Введите числа(целые) массива через пробел:";
      this.label1.BackColor = System.Drawing.Color.Chartreuse;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(1, 82);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(1000, 20);
      this.textBox1.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(1, 115);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(173, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Результат замены:";
      this.label2.BackColor = System.Drawing.Color.Chartreuse;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(1, 135);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(1000, 26);
      this.label3.TabIndex = 3;
      this.label3.Text = "Ожидание ввода...";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(0, 25);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(190, 19);
      this.label4.TabIndex = 4;
      this.label4.Text = "Введите размер массива:";
      this.label4.BackColor = System.Drawing.Color.Chartreuse;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(196, 24);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(95, 20);
      this.textBox2.TabIndex = 5;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(0, 225);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(158, 40);
      this.button1.TabIndex = 6;
      this.button1.Text = "Получить результат";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // NumThree
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(670, 319);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Name = "NumThree";
      this.Text = "NumThree";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Label label1;

    #endregion
  }
}