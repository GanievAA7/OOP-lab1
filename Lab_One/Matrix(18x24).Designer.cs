using System.ComponentModel;

namespace Lab_One
{
  partial class Matrix_18x24_
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(0, 0);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(138, 30);
      this.button1.TabIndex = 0;
      this.button1.Text = "Поменять столбцы";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button2.Location = new System.Drawing.Point(144, 0);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(186, 30);
      this.button2.TabIndex = 1;
      this.button2.Text = "Случайные значения";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button3.Location = new System.Drawing.Point(337, 0);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(167, 29);
      this.button3.TabIndex = 2;
      this.button3.Text = "Очистить матрицу";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(513, 1);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(96, 28);
      this.label1.TabIndex = 3;
      this.label1.Text = "Введите i и j:";
      label1.BackColor = System.Drawing.Color.Chartreuse;
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(609, 5);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(31, 20);
      this.textBox1.TabIndex = 4;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(646, 5);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(31, 20);
      this.textBox2.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.Location = new System.Drawing.Point(671, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(117, 30);
      this.label2.TabIndex = 6;
      this.label2.Text = "";
      this.label2.BackColor = System.Drawing.Color.Aqua;
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Matrix_18x24_
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 514);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "Matrix_18x24_";
      this.Text = "Matrix_18x24_";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    #endregion
  }
}