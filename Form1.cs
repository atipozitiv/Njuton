using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Njuton {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      MaximizeBox = false;
      FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Text = "Метод Ньютона(золотого сечения)";
      рассчитатьПоэтапноToolStripMenuItem.Visible = false;
    }

    private void Form1_Load(object sender, EventArgs e) {
      label5.Visible = false;
      label7.Visible = false;
    }
    public void Mistake() {
      label5.Visible = true;
      label1.Visible = false;
      label2.Visible = false;
      label3.Visible = false;
      label4.Visible = false;
      label6.Text = "";
      label8.Text = "";
      textBox1.Visible = false;
      textBox2.Visible = false;
      textBox3.Visible = false;
      chart1.Visible = false;
    }

    double Func(double x) {
      return Math.Pow(x, 5) * Math.Exp(x);
    }
    double FirstPro(double x) {
      return (Math.Pow(x, 5) + 5 * Math.Pow(x, 4)) * Math.Exp(x);
    }

    double Njuton(double endLine, double startLine, double precision) {
      double x1 = 10000000;
      bool flag = false;
      double x0 = endLine;
      while (Math.Abs(x1-x0) > precision) {
        if (flag) {
          x0 = x1;
        }
        x1 = x0 - Func(x0) / FirstPro(x0);
        flag = true;
      }
      return x1;
    }

    double GoldSechMin(double endLine, double startLine, double precision) {
      double answer = Double.MinValue;
      while (endLine - startLine > precision) {
        double R = (endLine - startLine) * 0.618043;
        double x1 = startLine + R;
        double x2 = endLine - R;
        if(Func(x1) < Func(x2)) {
          startLine = x2;
          answer = x1;
        } else {
          endLine = x1;
          answer = x2;
        }
      }
      return answer;
    }

    double GoldSechMax(double endLine, double startLine, double precision) {
      double answer = Double.MinValue;
      while (endLine - startLine > precision) {
        double R = (endLine - startLine) * 0.618043;
        double x1 = startLine + R;
        double x2 = endLine - R;
        if (-1*Func(x1) < -1*Func(x2)) {
          startLine = x2;
          answer = x1;
        } else {
          endLine = x1;
          answer = x2;
        }
      }
      return answer;
    }

    private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e) {
      try {
        double startLine = Convert.ToDouble(textBox1.Text);
        double endLine = Convert.ToDouble(textBox2.Text);
        double precision = Convert.ToDouble(textBox3.Text);

        this.chart1.Series[0].Points.Clear();
        double x = startLine;
        double y;
        while (x <= endLine) {
          y = Func(x);
          this.chart1.Series[0].Points.AddXY(x, y);
          x += 0.1;
        }

        double answerMin;
        double answerMax;
        if ((startLine >= endLine) || (precision <= 0)) {
          Mistake();
        } else {
          if (checkBox1.Checked) {
            answerMin = Njuton(endLine, startLine, precision);
            label6.Text = $"Точнка экстремума: x = {Math.Round(answerMin, 9)} y = {Math.Round(Func(answerMin), 9)}";
            label8.Text = "";
            answerMax = answerMin;
          } else {
            answerMin = GoldSechMin(endLine, startLine, precision);
            answerMax = GoldSechMax(endLine, startLine, precision);
            if (precision < 1) {
              label6.Text = $"Минимум: x = {Math.Round(answerMin, Convert.ToString(precision).Length - 2)} y = {Math.Round(Func(answerMin), 9)}";
              label8.Text = $"Максимум: x = {Math.Round(answerMax, Convert.ToString(precision).Length - 2)} y = {Math.Round(Func(answerMax), 9)}";
            } else {
              label6.Text = $"Минимум: x = {answerMin} y = {Func(answerMin)}";
              label8.Text = $"Максимум: x = {answerMin} y = {Func(answerMin)}";
            }
          }
      
          this.chart1.Series[1].Color = Color.Red;
          this.chart1.Series[1].Points.Clear();
          this.chart1.Series[1].Points.AddXY(answerMin, Func(answerMin));
          this.chart1.Series[2].Color = Color.Red;
          this.chart1.Series[2].Points.Clear();
          this.chart1.Series[2].Points.AddXY(answerMax, Func(answerMax));
        }
      } catch {
        Mistake();
      }
    }

    private void очиститьToolStripMenuItem_Click(object sender, EventArgs e) {
      textBox1.Text = "";
      textBox2.Text = "";
      textBox3.Text = "";
      label5.Visible = false;
      label1.Visible = true;
      label2.Visible = true;
      label3.Visible = true;
      label4.Visible = true;
      label7.Visible = false;
      label6.Text = "";
      label8.Text = "";
      textBox1.Visible = true;
      textBox2.Visible = true;
      textBox3.Visible = true;
      chart1.Visible = true;
      рассчитатьToolStripMenuItem.Visible = true;
    }

    private void textBox3_TextChanged(object sender, EventArgs e) {

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) {

    }
  }
}
