using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
    }

    private void Form1_Load(object sender, EventArgs e) {
      label5.Visible = false;

      this.chart1.Series[0].Points.Clear();
      double x = 0;
      double y;
      while(x <= 8) {
        y = Func(x);
        this.chart1.Series[0].Points.AddXY(x, y);
        x += 0.1;
      }
    }
    public void Mistake() {
      label5.Visible = true;
      label1.Visible = false;
      label2.Visible = false;
      label3.Visible = false;
      label4.Visible = false;
      label6.Text = "";
      textBox1.Visible = false;
      textBox2.Visible = false;
      textBox3.Visible = false;
      chart1.Visible = false;
    }
    public bool CheckPrecision(double Myx, double lastX, double precision) {
      bool check = true;
      if (Math.Abs(Func(lastX) - Func(Myx)) < precision) {
        check = false;
      }
      return check;
    }

    double Func(double x) {
      double y = (27 - 18 * x + 2 * x * x) * Math.Exp(-x / 3);
      return y;
    }

    private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e) {
      try {

        double startLine = Convert.ToDouble(textBox1.Text);
        double endLine = Convert.ToDouble(textBox2.Text);
        double precision = Convert.ToDouble(textBox3.Text);
        if ((startLine >= endLine) || (precision <= 0)) {
          Mistake();
        } else {
          double answer = Double.MinValue;
          double lastX = Double.MaxValue;
          while (CheckPrecision(answer, lastX, precision)) {
            lastX = answer;
            double R = (endLine - startLine) * 0.618043;
            double x1 = startLine + R;
            double x2 = endLine - R;
            if (Func(x1) < Func(x2)) {
              startLine = x2;
              answer = x1;
            } else {
              endLine = x1;
              answer = x2;
            }
          }
          label6.Text = $"Минимум: x = {answer} y = {Func(answer)}";
        }
      } catch {
        Mistake();
      }
    }

    private void очиститьToolStripMenuItem_Click(object sender, EventArgs e) {
      label5.Visible = false;
      label1.Visible = true;
      label2.Visible = true;
      label3.Visible = true;
      label4.Visible = true;
      label6.Text = "";
      textBox1.Visible = true;
      textBox2.Visible = true;
      textBox3.Visible = true;
      chart1.Visible = true;
    }

  }
}
