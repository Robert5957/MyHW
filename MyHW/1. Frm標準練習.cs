
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHomeWork : Form
    {
        int from;
        int to;
        int step;
        public FrmHomeWork()
        {
            InitializeComponent();
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = 66;
            int c = 77;
            int[] num = { a, b, c };
            int Max = num.Max();
            lblResult.Text = "最大值是 :" + Max;
        }
        private void btnOddEven_Click(object sender, EventArgs e)
        {
            int[] nums = { 33, 4, 5, 11, 222, 34 };
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evenCount++;
                }
                else { oddCount++; }
            }
            lblResult.Text = "奇數有" + oddCount + "個" + "\n偶數有" + evenCount + "個";
        }
        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };
            int max = scores.Max();
            lblResult.Text = "Max value of integer array  is " + max +
        "\nMin value of integer array  is " + MyMinScore(scores);
        }
       private void btnMaxMethod_Click(object sender, EventArgs e)
        {
            int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };
            lblResult.Text = "Max value of integer array  is " + MyMaxScore(scores);
        }
        private void btnLottory_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] lotto = new int[6];
            for (int i = 0; i < 6; i++)
            {
                lotto[i] = rnd.Next(1, 42);
                for (int j = 0; j <i; j++)
                {
                    if (j != i)//avoid the initial i=0 and j=0;
                    {
                        if (lotto[i] == lotto[j])//chcek the repeated numbers 
                        {
                            lotto[i] = rnd.Next(0, 42);
                        }
                    }
                }
            }
            lblResult.Text = "";
            int countK = 0;
            foreach (int k in lotto)
            {
                countK++;
                if (countK < lotto.Length)//add the if clause to avoid the last number in list with a spacenumber
                {
                    lblResult.Text += k + " ,";
                }
                else
                {
                    lblResult.Text += k+"\nGood Luck! Be a richer.";
                }
            }
        }
        private void btnGuessOddEven_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtNum.Text);
                string txt = n % 2 == 0 ? "Even" : "Odd";
                lblResult.Text =txtNum.Text+ " is " + txt;
            }
            catch (Exception)
            { MessageBox.Show("Input context is error, please input agagin!"); };
        }
        private void button16_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }
        private void btnCovert2_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int num = 100,index=0;
            int[] arr=new int[1];//don't give a range of array, 
            while (num != 1) {
                arr[index] = num % 2;
                num /= 2;
                index++;
                Array.Resize(ref arr, index + 1);// resize of the array by the index increasing
            }
            Array.Resize(ref arr, index + 1);
            arr[index] = num;
            for (int i = index; i >= 0; i--)
            { lblResult.Text += arr[i].ToString(); }
        }
        private void btn9Plus9Table_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblResult.Font = new Font("標楷體", 12F);//change the font size and type to fit the show of result;
            lblResult.ForeColor = Color.White;
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    lblResult.Text += $"|{i}x{j}={i * j,2} |";//the{ i*j,2} 2 fit align the text result
                }
                lblResult.Text += "\n";
            }

        }
        private void btnMaxStringArr_Click(object sender, EventArgs e)
        {
            string[] arr = { "welcome", "hello", "hi", "good luck" };
            int maxString = 0;
            int minString = 100;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                maxString = arr[i].Length > maxString ? i : 9;
            }
            lblResult.Text = arr[maxString];
            //for (int i = 0; i < arr.Length; i++)// reverse to maxString
            //{
            //  index = arr[i].Length < minString ? 0 : 100;
            //    if (index == 0)
            //    {
            //        minString = arr[i].Length;
            //    }
            //}
            //lblResult.Text += "\n" + arr[minString];
        }
        private void btnContainCc_Click(object sender, EventArgs e)
        {
            String[] arr = { "Cindy", "John", "Nicolas", "Robert", "Cynthia", "coconut" };
            int count = 0;
            lblResult.Font = new Font("標楷體", 14f);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains("C") || arr[i].Contains("c"))//check contains the target char use coninue avoid to count over 1times in a string
                {
                    count++;
                    continue;
                }
            }
            lblResult.Text = "陣列 { Cindy, John, Nicolas, Robert, Cynthia, coconut }含有c與C的名字有" + count + "個";
        }
        private void btnFor_Click(object sender, EventArgs e)
        {
            try
            {
                inputData(); int sum = 0;
                for (int i = from; i <= to; i += step)
                {
                    sum += i;
                }
                lblResult.Text = "for " + sum.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Input the correct content!");
            };
        }
        private void btnWhile_Click(object sender, EventArgs e)
        {
            try
            {
                inputData(); int sum = 0;
                while (from <= to)
                {
                    sum += from;
                    from += step;
                }
                lblResult.Text = "while " + sum.ToString();
            }
            catch (Exception) { MessageBox.Show("Input the correct content!"); };
        }
        private void btnDoWhile_Click(object sender, EventArgs e)
        {

            try { inputData();
            int sum = 0;
            do {
               sum += from;
                from += step;
            } while (from<=to); 
            lblResult.Text = "do " + sum;} catch (Exception) { MessageBox.Show("Input the correct content!"); };  
        }
        int MyMinScore(int[] nums)
        {
            return nums.Min();
        }
        int MyMaxScore(int[] nums) {
            return nums.Max();
        }
        void inputData()
        {
            from = int.Parse(txtFrom.Text);
            to = int.Parse(txtTo.Text);
            step = int.Parse(txtStep.Text);
        }
    }
}