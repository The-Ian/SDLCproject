using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Hexdecimal;
                string Bin;
                string Arabic;
                int Roman;
                string Roman2Bin;
                string Bin2Roman;
                string Ara2Hex;
                string Hex2Ara;
                string Ara2Bin;
                string Bin2Ara;
                string Hex2Roman;
                string Roman2Hex;

                if (numericTypeEntryCB.SelectedItem.Equals("Roman Numerals") &&
                  numericTypeResultCB.SelectedItem.Equals("Arabic"))

                {
                    Roman = Roman_Arabic.RomanToArabic(numberTB.Text);
                    resultOutput.Text = Roman.ToString();
                }


                else if (numericTypeEntryCB.SelectedItem.Equals("Arabic") &&
                      numericTypeResultCB.SelectedItem.Equals("Roman Numerals"))

                {
                    Arabic = Arabic_Roman.ArabicToRoman(int.Parse(numberTB.Text));
                    resultOutput.Text = Arabic.ToString();
                }

                else if (numericTypeEntryCB.SelectedItem.Equals("Binary") &&
                  numericTypeResultCB.SelectedItem.Equals("Hexadecimal"))
                {
                    Bin = Bin_Hex.BinaryToHexadecimal((numberTB.Text));
                    resultOutput.Text = Bin.ToString();
                }

                else if (numericTypeEntryCB.SelectedItem.Equals("Hexadecimal") &&
                  numericTypeResultCB.SelectedItem.Equals("Binary"))
                {
                    Hexdecimal = Hex_Bin.HexadecimalToBinary((numberTB.Text));
                    resultOutput.Text = Hexdecimal.ToString();
                }

                else if (numericTypeEntryCB.SelectedItem.Equals("Roman Numerals") &&
                  numericTypeResultCB.SelectedItem.Equals("Binary"))
                {
                    Roman2Bin = Roman_Bin.RomanToBinary((numberTB.Text));
                    resultOutput.Text = Roman2Bin.ToString();
                }

                else if (numericTypeEntryCB.SelectedItem.Equals("Binary") &&
                  numericTypeResultCB.SelectedItem.Equals("Roman Numerals"))
                {
                    Bin2Roman = Bin_Roman.BinaryToRoman(int.Parse(numberTB.Text));
                    resultOutput.Text = Bin2Roman.ToString();
                }

                else if (numericTypeEntryCB.SelectedItem.Equals("Arabic") &&
                  numericTypeResultCB.SelectedItem.Equals("Hexadecimal"))
                {
                    Ara2Hex = Arabic_Hex.ArabicToHexadecimal((numberTB.Text));
                    resultOutput.Text = Ara2Hex.ToString();
                }

                else if (numericTypeEntryCB.SelectedItem.Equals("Hexadecimal") &&
                  numericTypeResultCB.SelectedItem.Equals("Arabic"))
                {
                    Hex2Ara = Hex_Arabic.HexadecimalToArabic((numberTB.Text));
                    resultOutput.Text = Hex2Ara.ToString();
                }

                else if (numericTypeEntryCB.SelectedItem.Equals("Arabic") &&
                   numericTypeResultCB.SelectedItem.Equals("Binary"))
                {
                    Ara2Bin = Arabic_Bin.ArabicToBinary((int.Parse(numberTB.Text)));
                    resultOutput.Text = Ara2Bin.ToString();
                }

                else if (numericTypeEntryCB.SelectedItem.Equals("Binary") &&
                   numericTypeResultCB.SelectedItem.Equals("Arabic"))
                {
                    Bin2Ara = Bin_Arabic.BinaryToArabic((numberTB.Text));
                    resultOutput.Text = Bin2Ara.ToString();
                }

                else if (numericTypeEntryCB.SelectedItem.Equals("Hexadecimal") &&
                   numericTypeResultCB.SelectedItem.Equals("Roman Numerals"))
                {

                    Hex2Roman = Hex_Roman.HexToRoman((numberTB.Text));
                    resultOutput.Text = Hex2Roman.ToString();
                }

                else if (numericTypeEntryCB.SelectedItem.Equals("Roman Numerals") &&
                   numericTypeResultCB.SelectedItem.Equals("Hexadecimal"))
                {

                    Roman2Hex = Roman_Hex.RomanToHexadecimal((numberTB.Text));
                    resultOutput.Text = Roman2Hex.ToUpper();
                }

                else if (numericTypeEntryCB.SelectedItem == numericTypeResultCB.SelectedItem)
                {

                    resultOutput.Text = numberTB.Text;
                }

                else
                {
                    MessageBox.Show("You messed up dude.");
                };

            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            numberTB.Text = "";
            numericTypeEntryCB.Text = "";
            numericTypeResultCB.Text = "";
            resultOutput.Text = "";
        }
    }
}
