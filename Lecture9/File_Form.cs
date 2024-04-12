using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture9
{
    public partial class File_Form : Form
    {
        public File_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String? MyText;
                StreamReader MyFile = new StreamReader("MyTextFile.txt");
                MyText = MyFile.ReadLine();
                MyFile.Close();
                richTextBox1.Text = MyText;
            }
            catch
            {
                richTextBox1.Text = "Cannot read file";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] names = { "Cuong", "An", "Binh" };
            string myText = "";
            try
            {
                myText = "Try\n";
                myText += names[10];
            }
            catch (Exception ex)
            {
                myText = "Catch\n";
                myText += ex.Message;
            }
            finally
            {
                myText += "\nFinally";
            }
            richTextBox1.Text = myText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader MyFile = new StreamReader("MyTextFile.txt");
            //Char s= Convert.ToChar(MyFile.Peek());
            //richTextBox1.Text = ""+s;
            //richTextBox1.Text = Convert.ToString(MyFile.Peek()) + "\n";
            //richTextBox1.Text += Convert.ToString(MyFile.Peek());
            //richTextBox1.Text = Convert.ToString(MyFile.Read()) + "\n";
            //richTextBox1.Text += Convert.ToString(MyFile.Read());

            while (MyFile.Peek() != -1)
            {
                Char s = Convert.ToChar(MyFile.Read());
                richTextBox1.Text += s;
            }

            MyFile.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*StreamReader MyFile = new StreamReader("MyTextFile.txt");
            richTextBox1.Text = MyFile.ReadLine();
            while(MyFile.Peek() != -1)
            {
                richTextBox1.Text += MyFile.ReadLine() + "\n";
            }
            MyFile.Close();*/

            StreamReader MyFile = new StreamReader("MyTextFile.txt");
            richTextBox1.Text = MyFile.ReadToEnd();
            MyFile.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String S = "Hello World";
            StreamWriter MyFile = new StreamWriter("MyTextFile.txt");
            //append new data
            //StreamWriter MyFile = new StreamWriter("MyTextFile.txt", true);
            //MyFile.Write(S);
            //MyFile.Write(S);
            MyFile.WriteLine(S);
            MyFile.WriteLine(S);
            MyFile.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader MyFile = new StreamReader("nums.txt");

                string textNum = "";
                List<int> nums = new List<int>();
                int sum = 0;

                while (MyFile.Peek() != -1)
                {
                    int ascii_code = MyFile.Read();
                    char current_Char = (char)ascii_code;
                    if (current_Char == ' ' || current_Char == '\n')
                    {
                        int num = Convert.ToInt32(textNum);
                        nums.Add(num);
                        textNum = "";
                    }
                    else
                    {
                        textNum += current_Char;
                    }

                    if (current_Char == '\n')
                    {
                        sum = 0;

                        // Add your code
                        for (int i = 0; i < nums.Count; i++)
                        {
                            richTextBox1.Text += Convert.ToString(nums[i]);
                            if (i != nums.Count - 1)
                                richTextBox1.Text += "+";
                            sum += nums[i];
                        }
                        richTextBox1.Text += "=" + Convert.ToString(sum);
                        richTextBox1.Text += "\n";
                        nums.Clear();
                    }

                }

                sum = 0;
                int last_num = Convert.ToInt32(textNum);
                nums.Add(last_num);
                for (int i = 0; i < nums.Count; i++)
                {
                    richTextBox1.Text += Convert.ToString(nums[i]);
                    if (i != nums.Count - 1)
                        richTextBox1.Text += "+";
                    sum += nums[i];
                }
                richTextBox1.Text += "=" + Convert.ToString(sum);

                MyFile.Close();
            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.Message;
            }
        }
    }
}
