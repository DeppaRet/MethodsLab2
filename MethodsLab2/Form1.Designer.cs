using System;

namespace MethodsLab1
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.Start = new System.Windows.Forms.Button();
      this.Player1 = new System.Windows.Forms.Label();
      this.Player2 = new System.Windows.Forms.Label();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.Winner = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.LeftBorder = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.RightBorder = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.QueryCount = new System.Windows.Forms.TextBox();
      this.Progress = new System.Windows.Forms.ProgressBar();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.Player1Bank = new System.Windows.Forms.TextBox();
      this.Player2Bank = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.Bet = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // Start
      // 
      this.Start.Location = new System.Drawing.Point(249, 178);
      this.Start.Name = "Start";
      this.Start.Size = new System.Drawing.Size(211, 35);
      this.Start.TabIndex = 0;
      this.Start.Text = "Кто выиграл?";
      this.Start.UseVisualStyleBackColor = true;
      this.Start.Click += new System.EventHandler(this.Start_Click);
      // 
      // Player1
      // 
      this.Player1.AutoSize = true;
      this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Player1.Location = new System.Drawing.Point(85, 341);
      this.Player1.Name = "Player1";
      this.Player1.Size = new System.Drawing.Size(24, 25);
      this.Player1.TabIndex = 1;
      this.Player1.Text = "?";
      // 
      // Player2
      // 
      this.Player2.AutoSize = true;
      this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Player2.Location = new System.Drawing.Point(586, 341);
      this.Player2.Name = "Player2";
      this.Player2.Size = new System.Drawing.Size(24, 25);
      this.Player2.TabIndex = 2;
      this.Player2.Text = "?";
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(15, 81);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(189, 257);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox2.TabIndex = 4;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox3
      // 
      this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
      this.pictureBox3.Location = new System.Drawing.Point(506, 81);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(189, 257);
      this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox3.TabIndex = 5;
      this.pictureBox3.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(37, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(136, 24);
      this.label1.TabIndex = 6;
      this.label1.Text = "Первый игрок";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(537, 20);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(132, 24);
      this.label2.TabIndex = 7;
      this.label2.Text = "Второй игрок";
      // 
      // Winner
      // 
      this.Winner.AutoSize = true;
      this.Winner.Location = new System.Drawing.Point(280, 162);
      this.Winner.Name = "Winner";
      this.Winner.Size = new System.Drawing.Size(35, 13);
      this.Winner.TabIndex = 8;
      this.Winner.Text = "label3";
      this.Winner.Visible = false;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(210, 219);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(290, 119);
      this.dataGridView1.TabIndex = 9;
      // 
      // LeftBorder
      // 
      this.LeftBorder.Location = new System.Drawing.Point(271, 78);
      this.LeftBorder.Name = "LeftBorder";
      this.LeftBorder.Size = new System.Drawing.Size(84, 20);
      this.LeftBorder.TabIndex = 14;
      this.LeftBorder.Text = "0";
      this.LeftBorder.TextChanged += new System.EventHandler(this.LeftBorder_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(246, 62);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(208, 13);
      this.label3.TabIndex = 15;
      this.label3.Text = "Введите диапазон генерируемых чисел";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(252, 81);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(13, 13);
      this.label4.TabIndex = 16;
      this.label4.Text = "L";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(359, 81);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(15, 13);
      this.label5.TabIndex = 17;
      this.label5.Text = "R";
      // 
      // RightBorder
      // 
      this.RightBorder.Location = new System.Drawing.Point(376, 78);
      this.RightBorder.Name = "RightBorder";
      this.RightBorder.Size = new System.Drawing.Size(84, 20);
      this.RightBorder.TabIndex = 18;
      this.RightBorder.Text = "10000";
      this.RightBorder.TextChanged += new System.EventHandler(this.RightBorder_TextChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(246, 137);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(174, 13);
      this.label6.TabIndex = 19;
      this.label6.Text = "Введите колличество испытаний";
      // 
      // QueryCount
      // 
      this.QueryCount.Location = new System.Drawing.Point(416, 134);
      this.QueryCount.Name = "QueryCount";
      this.QueryCount.Size = new System.Drawing.Size(44, 20);
      this.QueryCount.TabIndex = 20;
      this.QueryCount.Text = "100";
      this.QueryCount.TextChanged += new System.EventHandler(this.QueryCount_TextChanged);
      // 
      // Progress
      // 
      this.Progress.Location = new System.Drawing.Point(249, 27);
      this.Progress.Name = "Progress";
      this.Progress.Size = new System.Drawing.Size(211, 17);
      this.Progress.TabIndex = 21;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(37, 51);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(53, 24);
      this.label7.TabIndex = 22;
      this.label7.Text = "Банк";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(537, 51);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(53, 24);
      this.label8.TabIndex = 23;
      this.label8.Text = "Банк";
      // 
      // Player1Bank
      // 
      this.Player1Bank.Location = new System.Drawing.Point(96, 55);
      this.Player1Bank.Name = "Player1Bank";
      this.Player1Bank.Size = new System.Drawing.Size(77, 20);
      this.Player1Bank.TabIndex = 24;
      this.Player1Bank.Text = "100";
      this.Player1Bank.TextChanged += new System.EventHandler(this.Player1Bank_TextChanged);
      // 
      // Player2Bank
      // 
      this.Player2Bank.Location = new System.Drawing.Point(591, 55);
      this.Player2Bank.Name = "Player2Bank";
      this.Player2Bank.Size = new System.Drawing.Size(78, 20);
      this.Player2Bank.TabIndex = 25;
      this.Player2Bank.Text = "100";
      this.Player2Bank.TextChanged += new System.EventHandler(this.Player2Bank_TextChanged);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(246, 114);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(155, 13);
      this.label9.TabIndex = 26;
      this.label9.Text = "Укажите ставку на одну игру";
      // 
      // Bet
      // 
      this.Bet.Location = new System.Drawing.Point(416, 111);
      this.Bet.Name = "Bet";
      this.Bet.Size = new System.Drawing.Size(44, 20);
      this.Bet.TabIndex = 27;
      this.Bet.Text = "1";
      this.Bet.TextChanged += new System.EventHandler(this.Bet_TextChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(710, 372);
      this.Controls.Add(this.Bet);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.Player2Bank);
      this.Controls.Add(this.Player1Bank);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.Progress);
      this.Controls.Add(this.QueryCount);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.RightBorder);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.LeftBorder);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.Winner);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox3);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.Player2);
      this.Controls.Add(this.Player1);
      this.Controls.Add(this.Start);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "MainWindow";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button Start;
    private System.Windows.Forms.Label Player1;
    private System.Windows.Forms.Label Player2;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label Winner;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.TextBox LeftBorder;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox RightBorder;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox QueryCount;
    private System.Windows.Forms.ProgressBar Progress;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox Player1Bank;
    private System.Windows.Forms.TextBox Player2Bank;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox Bet;
  }
}

