using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
  public partial class Form1 : Form
  {
    //int index pou eimaste analogos to button press
    int index = 1;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      //ROLE
      //if index= kati
      switch (index)
      {
        case 1:
          textBox1.Text = Roll().ToString();
          break;
        case 2:
          textBox2.Text = Roll().ToString();
          break;
        case 3:
          textBox3.Text = Roll().ToString();
          break;
        case 4:
          textBox4.Text = Roll().ToString();
          break;
        case 5:
          textBox5.Text = Roll().ToString();
          break;
        case 6:
          textBox6.Text = Roll().ToString();
          break;
      }

      //kate fora pou trexei index+1
      index++;

    }
    //ROLL random numbers 3x times 
    int Roll()
    {
      //set ints
      int sum = 0;
      int dice = 0;
      Random rand = new Random();//create random

      //set label7 visible 
      label7.Text = "";
      if (label7.Visible == false)
      {
        label7.Visible = true;
      }
      //run 3x times
      for (int i=0; i < 3; i++)
      {
        dice = rand.Next(1, 6);
        //removelast '+' from lablel7
        if (i == 2)
        {
          label7.Text += dice;
        }
        else
        {
          label7.Text += string.Format("{0} + ", dice);
        }
        sum += dice;
      }
      return sum;
    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      //reset button
      index = 1;
      textBox1.Text = "";
      textBox2.Text = "";
      textBox3.Text = "";
      textBox4.Text = "";
      textBox5.Text = "";
      textBox6.Text = "";
      label7.Text = "";
      label7.Visible = false;

    }
  }
}
