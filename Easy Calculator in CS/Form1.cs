using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Calculator_in_CS
{

    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        int pos = 0; // 保存由上一个运算符决定的四则运算类型
        double temp1, temp2; // 上一次和这次四则运算符按键点击时textBox1显示的字符串
        bool open = false;

        bool statusAdd, statusSub, statusMul, statusDiv, statusEquare, statusSquare, statusSqrt = false;

        public void addNum(String num)
        {
            if (statusAdd || statusSub || statusMul || statusDiv)
            {
                textBox1.Text = "0";
            }
            if (num == ".")
            {
                if (textBox1.Text.IndexOf('.') > -1)    // .1.
                {
                    MessageBox.Show("fuck");
                }
                else // 1.1 or 0.1
                {
                    textBox1.Text = textBox1.Text + num;
                }
            }
            else if (textBox1.Text == "0") // 0 -> 1
            {
                textBox1.Text = "" + num;
            }
            else // 12345
            {
                textBox1.Text = textBox1.Text + num;
            }
        }

        public void operation()
        {
            if (!statusSquare && !statusSqrt)
            {
                textBox2.Text = textBox2.Text + textBox1.Text.TrimEnd('.');
            }
            temp2 = Convert.ToDouble(textBox1.Text);
            switch (pos)
            {
                case 1:
                    textBox1.Text = (temp1 + temp2).ToString();
                    break;
                case 2:
                    textBox1.Text = (temp1 - temp2).ToString();
                    break;
                case 3:
                    textBox1.Text = (temp1 * temp2).ToString();
                    break;
                case 4:
                    if (temp2 != 0)
                    {
                        textBox1.Text = (temp1 / temp2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error.");
                    }
                    break;
            }
            temp1 = Convert.ToDouble(textBox1.Text);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (statusEquare == true)
            {
                textBox1.Text = "0";
            }
            addNum("0");
            statusAdd = statusSub = statusMul = statusDiv = statusEquare = statusSquare = statusSqrt = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (statusSquare || statusSqrt)
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            if (statusEquare == true)
            {
                textBox1.Text = "0";
                temp1 = 0;
            }
            addNum("1");
            statusAdd = statusSub = statusMul = statusDiv = statusEquare = statusSquare = statusSqrt = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (statusSquare || statusSqrt)
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            if (statusEquare == true)
            {
                textBox1.Text = "0";
                temp1 = 0;
            }
            addNum("2");
            statusAdd = statusSub = statusMul = statusDiv = statusEquare = statusSquare = statusSqrt = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (statusSquare || statusSqrt)
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            if (statusEquare == true)
            {
                textBox1.Text = "0";
                temp1 = 0;
            }
            addNum("3");
            statusAdd = statusSub = statusMul = statusDiv = statusEquare = statusSquare = statusSqrt = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (statusSquare || statusSqrt)
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            if (statusEquare == true)
            {
                textBox1.Text = "0";
                temp1 = 0;
            }
            addNum("4");
            statusAdd = statusSub = statusMul = statusDiv = statusEquare = statusSquare = statusSqrt = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (statusSquare || statusSqrt)
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            if (statusEquare == true)
            {
                textBox1.Text = "0";
                temp1 = 0;
            }
            addNum("5");
            statusAdd = statusSub = statusMul = statusDiv = statusEquare = statusSquare = statusSqrt = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (statusSquare || statusSqrt)
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            if (statusEquare == true)
            {
                textBox1.Text = "0";
                temp1 = 0;
            }
            addNum("6");
            statusAdd = statusSub = statusMul = statusDiv = statusEquare = statusSquare = statusSqrt = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (statusSquare || statusSqrt)
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            if (statusEquare == true)
            {
                textBox1.Text = "0";
                temp1 = 0;
            }
            addNum("7");
            statusAdd = statusSub = statusMul = statusDiv = statusEquare = statusSquare = statusSqrt = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (statusSquare || statusSqrt)
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            if (statusEquare == true)
            {
                textBox1.Text = "0";
                temp1 = 0;
            }
            addNum("8");
            statusAdd = statusSub = statusMul = statusDiv = statusEquare = statusSquare = statusSqrt = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (statusSquare || statusSqrt)
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            if (statusEquare == true)
            {
                textBox1.Text = "0";
                temp1 = 0;
            }
            addNum("9");
            statusAdd = statusSub = statusMul = statusDiv = statusEquare = statusSquare = statusSqrt = false;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (statusSquare || statusSqrt)
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            if (statusEquare == true)
            {
                textBox1.Text = "0";
                temp1 = 0;
            }
            addNum(".");
            statusAdd = statusSub = statusMul = statusDiv = statusEquare = statusSquare = statusSqrt = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (statusEquare == true)
            {
                temp1 = Convert.ToDouble(textBox1.Text);
            }
            if (!statusAdd && !statusSub && !statusMul && !statusSub)
            {
                operation();
            }
            else
            {
                temp1 = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text[textBox2.Text.Length - 1] == ' ')
            {
                textBox2.Text = textBox2.Text.Trim(' ', '+', '-', '×', '÷');
            }
            textBox2.Text = textBox2.Text + " + ";
            pos = 1;
            statusSub = statusMul = statusDiv = statusEquare = statusSquare = statusSqrt = false;
            statusAdd = true;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (statusEquare == true)
            {
                temp1 = Convert.ToDouble(textBox1.Text);
            }
            if (!statusAdd && !statusSub && !statusMul && !statusSub)
            {
                operation();
            }
            else
            {
                temp1 = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text[textBox2.Text.Length - 1] == ' ')
            {
                textBox2.Text = textBox2.Text.Trim(' ', '+', '-', '×', '÷');
            }
            textBox2.Text = textBox2.Text + " - ";
            pos = 2;
            statusAdd = statusMul = statusDiv = statusEquare = statusSquare = statusSqrt = false;
            statusSub = true;
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            if (statusEquare == true)
            {
                temp1 = Convert.ToDouble(textBox1.Text);
            }
            if (!statusAdd && !statusSub && !statusMul && !statusSub)
            {
                operation();
            }
            else
            {
                temp1 = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text[textBox2.Text.Length - 1] == ' ')
            {
                textBox2.Text = textBox2.Text.Trim(' ', '+', '-', '×', '÷');
            }
            if(textBox2.Text.IndexOf('+') > -1 || textBox2.Text.IndexOf('-') > -1)
                if(textBox2.Text.IndexOf('+') == textBox2.Text.IndexOf("E+"))
                {
                    textBox2.Text = "(" + textBox2.Text + ")";
                }
            textBox2.Text = textBox2.Text + " × ";
            pos = 3;
            statusAdd = statusSub = statusDiv = statusEquare = statusSquare = statusSqrt = false;
            statusMul = true;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (statusEquare == true)
            {
                temp1 = Convert.ToDouble(textBox1.Text);
            }
            if (!statusAdd && !statusSub && !statusMul && !statusSub)
            {
                operation();
            }
            else
            {
                temp1 = Convert.ToDouble(textBox1.Text);
            }
            if (textBox2.Text[textBox2.Text.Length - 1] == ' ')
            {
                textBox2.Text = textBox2.Text.Trim(' ', '+', '-', '×', '÷');
            }
            if (textBox2.Text.IndexOf('+') > -1 || textBox2.Text.IndexOf('-') > -1)
                if (textBox2.Text.IndexOf('+') == textBox2.Text.IndexOf("E+"))
                {
                    textBox2.Text = "(" + textBox2.Text + ")";
                }
            textBox2.Text = textBox2.Text + " ÷ ";
            pos = 4;
            statusAdd = statusSub = statusMul = statusEquare = statusSquare = statusSqrt = false;
            statusDiv = true;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            if (open)
            {
                MaximumSize = new System.Drawing.Size(378, 371);
                MinimumSize = new System.Drawing.Size(378, 371);
                Size = new System.Drawing.Size(378, 371);
                open = false;
            }
            else
            {
                MaximumSize = new System.Drawing.Size(600, 371);
                MinimumSize = new System.Drawing.Size(600, 371);
                Size = new System.Drawing.Size(600, 371);
                open = true;
            }
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            if (statusSquare || statusSqrt)
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            if (statusEquare == true)
            {
                textBox1.Text = "0";
                temp1 = 0;
            }
            addNum("3.14159265359");
            statusAdd = statusSub = statusMul = statusDiv = statusEquare = statusSquare = statusSqrt = false;
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '-')
            {
                textBox1.Text = textBox1.Text.TrimStart('-');
            }
            else
            {
                textBox1.Text = textBox1.Text.Insert(0, "-");
            }
        }

        private void buttonBS_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            temp1 = 0;
            temp2 = 0;
            pos = 0;
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "sqr(" + textBox1.Text + ")";
            }
            else
            {
                textBox2.Text = "sqr(" + textBox2.Text + textBox1.Text + ")";
            }
            temp1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (temp1 * temp1).ToString();

            pos = 0;
            statusAdd = statusSub = statusMul = statusDiv = statusEquare = statusSqrt = false;
            statusSquare = true;
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "sqr(" + textBox1.Text + ")";
            }
            else
            {
                textBox2.Text = "sqr(" + textBox2.Text + textBox1.Text + ")";
            }
            temp1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Math.Sqrt(temp1).ToString();

            pos = 0;
            statusAdd = statusSub = statusMul = statusDiv = statusEquare = statusSquare = false;
            statusSqrt = true;
        }

        private void buttonEquare_Click(object sender, EventArgs e)
        {
            operation();
            textBoxHistory.Text = textBoxHistory.Text + "  " + textBox2.Text + " =\n";
            if (textBox1.Text.Length < 5)
            {
                for(int i = 0; i < 26; i++)
                {
                    textBoxHistory.Text = textBoxHistory.Text + " ";
                }
            }
            else if (textBox1.Text.Length < 10)
            {
                for (int i = 0; i < 21; i++)
                {
                    textBoxHistory.Text = textBoxHistory.Text + " ";
                }
            }
            else if (textBox1.Text.Length < 15)
            {
                for (int i = 0; i < 16; i++)
                {
                    textBoxHistory.Text = textBoxHistory.Text + " ";
                }
            }
            else if (textBox1.Text.Length < 20)
            {
                for (int i = 0; i < 11; i++)
                {
                    textBoxHistory.Text = textBoxHistory.Text + " ";
                }
            }
            else if (textBox1.Text.Length < 25)
            {
                for (int i = 0; i < 6; i++)
                {
                    textBoxHistory.Text = textBoxHistory.Text + " ";
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    textBoxHistory.Text = textBoxHistory.Text + " ";
                }
            }
            textBoxHistory.Text = textBoxHistory.Text + textBox1.Text + "\n\n";
            textBox2.Text = "";

            statusAdd = statusSub = statusMul = statusDiv = false;
            statusEquare = true;
            pos = 0;
        }
    }
}
