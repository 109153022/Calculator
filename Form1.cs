﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float firstNumber, secondNumber;
        int operators = -1;

        private void btnOne_Click(object sender, EventArgs e)
        {
            Add_Number("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Add_Number("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Add_Number("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Add_Number("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Add_Number("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Add_Number("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Add_Number("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Add_Number("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Add_Number("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Add_Number("0");
        }

        private void Add_Number(string _number)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + _number;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Select_Operator(0);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Select_Operator(1);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Select_Operator(2);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Select_Operator(3);
        }

        private void Select_Operator(int _operator)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第一個數字的全域變數
            txtNumber.Text = "0"; //重新將輸入文字框重新設定為0
            operators = _operator; //選擇「加」號
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            float finalResults = 0f;
            secondNumber = Convert.ToSingle(txtNumber.Text);

            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }
            txtNumber.Text = string.Format("{0:0.##########}", finalResults);

            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string number = txtNumber.Text;
            int length = number.Length;

            if (length > 0)
            {
                number = number.Substring(0, length - 1);
            }
            else
            {
                number = "0"; // 如果没有数字，将文本设置为0
            }

            txtNumber.Text = number; // Update the text box with the modified string
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text != "0")
            {
                float number = Convert.ToSingle(txtNumber.Text);
                number /= 100; // 計算百分比
                txtNumber.Text = string.Format("{0:P2}", number); // 格式化為百分比
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }
    }
}
