using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multidimensional_arrays_2
{
    public partial class Array : Form
    {
        int[,] myarray = new int[10, 7];
        public Array()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Random myrandom = new Random();
            myrandom.Next(0, 100);
            int[,] myarray = new int[10, 7];

            for (int i = 0; i < 10; i++)
            {
                myarray[i, 0] = myrandom.Next(0, 100);
                myarray[i, 1] = myrandom.Next(0, 100);
                myarray[i, 2] = myrandom.Next(0, 100);
                myarray[i, 3] = myrandom.Next(0, 100);
                myarray[i, 4] = GetMinimumValue();
                myarray[i, 5] = myarray[i, 0] + myarray[i, 1] + myarray[i, 2] + myarray[i, 3];
                myarray[i, 6] = myarray[i, 5] / 4;

                printArray(myarray);



            }


        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void printArray(int[,] arrayToPrint)
        {

            txtResult.Text = "";
            for (int iRow = 0; iRow < arrayToPrint.GetLowerBound(0) + 10; iRow++)
            {
                for (int iColumn = 0; iColumn < arrayToPrint.GetUpperBound(1) + 1; iColumn++)
                {
                    txtResult.Text += arrayToPrint[iRow, iColumn].ToString() + "\t";


                }
            }
        }
        private int GetMinimumValue()
        {

                var Minimum = 0D;
                Minimum = myarray[0, 0];

                

                

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (Minimum > myarray[i, j])
                            Minimum = myarray[i, j];
                    }
                }

            return Convert.ToInt32(Minimum);


           
        }
    }
}

