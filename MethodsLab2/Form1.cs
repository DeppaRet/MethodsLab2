using System;
using System.Drawing;
using System.Windows.Forms;

namespace MethodsLab1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    void timer1_Tick(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }
    private void Start_Click(object sender, EventArgs e)
    {
      try
      {
        
        double player1Bank = Convert.ToDouble(Player1Bank.Text);
        double player2Bank = Convert.ToDouble(Player2Bank.Text);
        double bet = Convert.ToDouble(Bet.Text);
        int player1 = 0, player2 = 0, tmp;

        if ((player1Bank <= 0) || (player2Bank <= 0))
        {
          MessageBox.Show("Баланс одного из игроков меньше нуля");
          Player1Bank.ReadOnly = false;
          Player2Bank.ReadOnly = false;
          return;
        }

        Progress.Value = 0;
        Progress.Maximum = Convert.ToInt32(QueryCount.Text);
        Player1Bank.ReadOnly = true;
        Player2Bank.ReadOnly = true;
        timer1.Enabled = true;
        timer1.Start();
        timer1.Interval = Convert.ToInt32(QueryCount.Text);
        Random rnd = new Random();
        pictureBox2.BackColor = Color.Transparent;
        pictureBox3.BackColor = Color.Transparent;

        for (int i = 0; i < Convert.ToInt32(QueryCount.Text); i++)
        {
          //timer1.Tick += new EventHandler(timer1_Tick);
          Progress.Value++;
          tmp = rnd.Next(Convert.ToInt32(LeftBorder.Text), Convert.ToInt32(RightBorder.Text));
          if ((tmp & 1) == 0)
          {
            player1++;
            player1Bank += bet;
            player2Bank -= bet;
          }
          else if ((tmp & 1) == 1)
          {
            player2++;
            player1Bank -= bet;
            player2Bank += bet;
          }
          else
          {
            continue;
          }
        }

        Player1Bank.Text = player1Bank.ToString();
        Player2Bank.Text = player2Bank.ToString();
        Player1.Text = player1.ToString();
        Player2.Text = player2.ToString();

        if (player2 < player1)
        {
          Winner.Text = "Победил игрок номер 1";
          dataGridView1.Rows.Add(player1, player2, "Player 1");
          pictureBox2.BackColor = Color.Green;
          pictureBox3.BackColor = Color.Red;
        }
        else if (player2 > player1)
        {
          Winner.Text = "Победил игрок номер 2";
          dataGridView1.Rows.Add(player1, player2, "Player 2");
          pictureBox2.BackColor = Color.Red;
          pictureBox3.BackColor = Color.Green;
        }
        else
        {
          Winner.Text = "Произошла ничья";
          dataGridView1.Rows.Add(player1, player2, "Ничья");
          pictureBox2.BackColor = Color.Yellow;
          pictureBox3.BackColor = Color.Yellow;
        }

        Winner.Visible = true;
        timer1.Stop();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка");
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      dataGridView1.Columns.Add("Player 1", "Player 1");
      dataGridView1.Columns.Add("Player 2", "Player 2");
      dataGridView1.Columns.Add("Winner", "Winner");
    }

    private void LeftBorder_TextChanged(object sender, EventArgs e)
    {
      try
        {
          int s = Convert.ToInt32(LeftBorder.Text);
        }
        catch (System.FormatException)
        {
          MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
          LeftBorder.Text = "0";
      }
      catch (System.OverflowException)
      {
        MessageBox.Show("Значение было недопустимо малым или большим!");
        LeftBorder.Text = "0";
      }
    }

    private void RightBorder_TextChanged(object sender, EventArgs e)
    {
      try
      {
        int s = Convert.ToInt32(RightBorder.Text);
      }
      catch (System.FormatException)
      {
        MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
        RightBorder.Text = "10000";
      }
      catch (System.OverflowException)
      {
        MessageBox.Show("Значение было недопустимо малым или большим!");
        RightBorder.Text = "10000";
      }
    }

    private void QueryCount_TextChanged(object sender, EventArgs e)
    {
      try
      {
        int s = Convert.ToInt32(QueryCount.Text);
      }
      catch (System.FormatException)
      {
        MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
        QueryCount.Text = "100";
      }
      catch (System.OverflowException)
      {
        MessageBox.Show("Значение было недопустимо малым или большим!");
        QueryCount.Text = "100";
      }
    }

    private void Player1Bank_TextChanged(object sender, EventArgs e)
    {
      try
      {
        int s = Convert.ToInt32(Player1Bank.Text);
      }
      catch (System.FormatException)
      {
        MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
        Player1Bank.Text = "100";
      }
      catch (System.OverflowException)
      {
        MessageBox.Show("Значение было недопустимо малым или большим!");
        Player1Bank.Text = "100";
      }
    }

    private void Player2Bank_TextChanged(object sender, EventArgs e)
    {
      try
      {
        int s = Convert.ToInt32(Player2Bank.Text);
      }
      catch (System.FormatException)
      {
        MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
        Player2Bank.Text = "100";
      }
      catch (System.OverflowException)
      {
        MessageBox.Show("Значение было недопустимо малым или большим!");
        Player2Bank.Text = "100";
      }
    }

    private void Bet_TextChanged(object sender, EventArgs e)
    {
      try
      {
        int s = Convert.ToInt32(Bet.Text);
      }
      catch (System.FormatException)
      {
        MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
        Bet.Text = "1";
      }
      catch (System.OverflowException)
      {
        MessageBox.Show("Значение было недопустимо малым или большим!");
        Bet.Text = "1";
      }
    }
  }
}
