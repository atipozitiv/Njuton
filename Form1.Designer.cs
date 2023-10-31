namespace Njuton {
  partial class Form1 {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.рассчитатьПоэтапноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.label8 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 39);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(174, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Введите начало отрезка:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 68);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(165, 16);
      this.label2.TabIndex = 1;
      this.label2.Text = "Введите конец отрезка:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(23, 103);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(129, 16);
      this.label3.TabIndex = 2;
      this.label3.Text = "Введите точность:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(216, 39);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 22);
      this.textBox1.TabIndex = 3;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(216, 68);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 22);
      this.textBox2.TabIndex = 4;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(216, 103);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 22);
      this.textBox3.TabIndex = 5;
      this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(90, 9);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(528, 29);
      this.label4.TabIndex = 6;
      this.label4.Text = "Нахождение локального минимума функции";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 420);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1325, 30);
      this.menuStrip1.TabIndex = 7;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // действияToolStripMenuItem
      // 
      this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem,
            this.рассчитатьToolStripMenuItem,
            this.рассчитатьПоэтапноToolStripMenuItem});
      this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
      this.действияToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
      this.действияToolStripMenuItem.Text = "Действия";
      // 
      // очиститьToolStripMenuItem
      // 
      this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
      this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
      this.очиститьToolStripMenuItem.Text = "Очистить";
      this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
      // 
      // рассчитатьToolStripMenuItem
      // 
      this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
      this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
      this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
      this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
      // 
      // рассчитатьПоэтапноToolStripMenuItem
      // 
      this.рассчитатьПоэтапноToolStripMenuItem.Name = "рассчитатьПоэтапноToolStripMenuItem";
      this.рассчитатьПоэтапноToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
      this.рассчитатьПоэтапноToolStripMenuItem.Text = "Рассчитать поэтапно";
      // 
      // chart1
      // 
      chartArea3.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea3);
      this.chart1.Location = new System.Drawing.Point(476, 39);
      this.chart1.Name = "chart1";
      series7.ChartArea = "ChartArea1";
      series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series7.Legend = "Legend1";
      series7.Name = "Series1";
      series8.ChartArea = "ChartArea1";
      series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series8.Name = "Series2";
      series9.ChartArea = "ChartArea1";
      series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
      series9.Name = "Series3";
      this.chart1.Series.Add(series7);
      this.chart1.Series.Add(series8);
      this.chart1.Series.Add(series9);
      this.chart1.Size = new System.Drawing.Size(805, 380);
      this.chart1.TabIndex = 8;
      this.chart1.Text = "chart1";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(23, 220);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(977, 16);
      this.label5.TabIndex = 9;
      this.label5.Text = "Некорректные данные, обратите внимание на формат точности(через зяпятую) Начало о" +
    "трезка должно быть меньше его конца. Нажмите очистить";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(26, 220);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(0, 16);
      this.label6.TabIndex = 10;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(26, 138);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(145, 16);
      this.label7.TabIndex = 11;
      this.label7.Text = "достигнута точность";
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(2, 384);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(396, 20);
      this.checkBox1.TabIndex = 12;
      this.checkBox1.Text = "использовать метод Ньютона вместо золотого сечения";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(26, 254);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(0, 16);
      this.label8.TabIndex = 13;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1325, 450);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ToolStripMenuItem рассчитатьПоэтапноToolStripMenuItem;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Label label8;
  }
}

