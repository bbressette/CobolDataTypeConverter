using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CobolDataTypeConverter
{
    public partial class MainForm : Form
    {
        private StringBuilder rawNumber = new StringBuilder();
        private StringBuilder rawPic = new StringBuilder();
        private StringBuilder outPic = new StringBuilder();
        private StringBuilder outNumber = new StringBuilder();
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
            displayQuestion();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult prompt;

            if (txtOutValue.Text == outNumber.ToString())
            {
                prompt = MessageBox.Show("Correct! Press OK to generate a new question.");
                displayQuestion();
            }
            else
            {
                prompt = MessageBox.Show("Incorrect. Try again?", "", MessageBoxButtons.YesNo);
                if (prompt == DialogResult.No)
                {
                    prompt = MessageBox.Show(outNumber + " was the answer. Press OK to generate a new question.");
                    displayQuestion();
                }
            }
        }

        private void displayQuestion()
        {
            generateQuestion();

            txtRawValue.Text = rawNumber.ToString();
            txtRawPic.Text = rawPic.ToString();
            txtOutPic.Text = outPic.ToString();
            txtOutValue.Text = "";
        }

        private void generateQuestion()
        {
            rawNumber.Clear();
            rawPic.Clear();
            outPic.Clear();
            outNumber.Clear();
            
            int rawLength = random.Next(2, 10);
            int rawDecimalIndex = random.Next(1, rawLength + 1);

            rawNumber.Append(random.Next((int)Math.Pow(10, rawLength - 1), (int)Math.Pow(10, rawLength) - 1));
            if (rawLength != rawDecimalIndex)
                rawNumber.Insert(rawDecimalIndex, ".");

            int outLength = random.Next(2, 10);
            int outDecimalIndex = random.Next(1, outLength + 1);
            string outPicChar = "9";
            string outValueChar = "0";

            bool usesS = false, usesCR = false, isNegative = false, usesCommas = false, isZero = false;

            if (random.Next(0, 2) == 1)
            {
                usesS = true;
                if (random.Next(0, 2) == 0)
                    isNegative = true;
            }

            if (random.Next(0, 2) == 1)
                usesCommas = true;

            if (rawDecimalIndex < outDecimalIndex)
            {
                switch (random.Next(0, 6))
                {
                    case 0:
                        outPicChar = "Z";
                        outValueChar = "b";
                        break;
                    case 1:
                        outPicChar = "$";
                        outValueChar = "b";
                        break;
                    case 2:
                        outPicChar = "*";
                        outValueChar = "*";
                        break;
                    case 3:
                        outPicChar = "+";
                        outValueChar = "b";
                        break;
                    case 4:
                        outPicChar = "-";
                        outValueChar = "b";
                        break;
                }
            }

            if (outPicChar != "+" && outPicChar != "-" && usesS && random.Next(0, 2) == 1)
                usesCR = true;

            // raw pic init
            if (rawLength - (rawLength - rawDecimalIndex) > 3)
                rawPic.Append("9(").Append(rawLength - (rawLength - rawDecimalIndex)).Append(")");
            else
                for (int ctr = rawLength - (rawLength - rawDecimalIndex); ctr > 0; ctr--)
                    rawPic.Append("9");
            if (rawLength != rawDecimalIndex)
                rawPic.Append("V");
            if (rawLength - rawDecimalIndex > 3)
                rawPic.Append("9(").Append(rawLength - rawDecimalIndex).Append(")");
            else
                for (int ctr = rawLength - rawDecimalIndex; ctr > 0; ctr--)
                    rawPic.Append("9");

            // out pic init
            if (outLength - (outLength - outDecimalIndex) > 3 && !usesCommas)
                outPic.Append(outPicChar).Append("(").Append(outLength - (outLength - outDecimalIndex)).Append(")");
            else
            {
                for (int ctr = outLength - (outLength - outDecimalIndex); ctr > 0; ctr--)
                {
                    outPic.Append(outPicChar);
                    if (ctr == 4 || ctr == 7)
                        outPic.Append(",");
                }
            }
            if (outLength != outDecimalIndex)
                outPic.Append(".");
            if (outLength - outDecimalIndex > 3)
                outPic.Append("9(").Append(outLength - outDecimalIndex).Append(")");
            else
                for (int ctr = outLength - outDecimalIndex; ctr > 0; ctr--)
                    outPic.Append("9");

            // outNumber init
            outNumber.Append(rawNumber);
            if (rawDecimalIndex > outDecimalIndex)
            {
                outNumber.Remove(0, rawDecimalIndex - outDecimalIndex);
                if (Convert.ToDouble(outNumber.ToString()) == 0.0)
                    isZero = true;
            }
            else if (rawDecimalIndex < outDecimalIndex)
            {
                bool first = true;
                for (int ctr = outDecimalIndex - rawDecimalIndex; ctr > 0; ctr--)
                {
                    if (first && outPicChar != "9" && outPicChar != "Z")
                    {
                        switch (outPicChar)
                        {
                            case "+":
                                outNumber.Insert(0, isNegative ? "-" : outPicChar);
                                break;
                            case "-":
                                outNumber.Insert(0, isNegative ? "-" : "b");
                                break;
                            default:
                                outNumber.Insert(0, outPicChar);
                                break;
                        }
                        first = false;
                    }
                    else
                        outNumber.Insert(0, outValueChar);
                }
            }
            if (rawLength - rawDecimalIndex > outLength - outDecimalIndex)
            {
                outNumber.Remove(outNumber.Length - ((rawLength - rawDecimalIndex) - (outLength - outDecimalIndex)), ((rawLength - rawDecimalIndex) - (outLength - outDecimalIndex)));
                if (outLength - outDecimalIndex == 0)
                    outNumber.Remove(outNumber.Length - 1, 1);
                if (rawDecimalIndex > outDecimalIndex && Convert.ToDouble(outNumber.ToString()) == 0.0)
                    isZero = true;
            }
            else if (rawLength - rawDecimalIndex < outLength - outDecimalIndex)
            {
                if (rawLength - rawDecimalIndex == 0)
                    outNumber.Insert(outNumber.Length, ".");
                for (int ctr = (outLength - outDecimalIndex) - (rawLength - rawDecimalIndex); ctr > 0; ctr--)
                    outNumber.Insert(outNumber.Length, "0");
            }
            if (usesCommas)
            {
                if (outDecimalIndex > 3)
                {
                    if (outDecimalIndex - 3 > outDecimalIndex - rawDecimalIndex || outValueChar == "0")
                        outNumber.Insert(outDecimalIndex - 3, ",");
                    else
                        outNumber.Insert(outDecimalIndex - 4, outValueChar);
                }
                if (outDecimalIndex > 6)
                {
                    if (outDecimalIndex - 6 > outDecimalIndex - rawDecimalIndex || outValueChar == "0")
                        outNumber.Insert(outDecimalIndex - 6, ",");
                    else
                        outNumber.Insert(outDecimalIndex - 7, outValueChar);
                }
            }

            // signs for raw pic, value
            if (usesS)
                rawPic.Insert(0, "S");
            if (isNegative)
                rawNumber.Insert(0, "-");

            // db, cr labels if needed
            if (usesCR)
            {
                string sign = random.Next(0, 2) == 1 ? "DB" : "CR";
                outPic.Append(sign);
                outNumber.Append(isNegative && !isZero ? sign : "bb");
            }
        }

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            displayQuestion();
        }
    }
}
