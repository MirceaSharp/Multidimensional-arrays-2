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
        private int[,] myarray = new int[10, 7];
        Random myrandom = new Random();
        int r;
        int c;





        public Array()
        {


            InitializeComponent();

            int numOfRows = 10;  /* myarray.GetLength(0);*/
            int numOfColumns = 4;  /* myarray.GetLength(1);*/

            int lowest = myarray[0, 0];
            int highest = myarray[0, 0];

            for (int r = 0; r < numOfRows; r++)
            {
                for (int c = 0; c < numOfColumns; c++)
                {


                    if (myarray[r, c] > highest)


                        highest = myarray[r, c];

                }

            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Random myrandom = new Random();
           
            int[,] myarray = new int[10, 7];

            for (int i = 0; i < 10; i++)
            {
                myarray[i, 0] = myrandom.Next(0, 100);
                myarray[i, 1] = myrandom.Next(0, 100);
                myarray[i, 2] = myrandom.Next(0, 100);
                myarray[i, 3] = myrandom.Next(0, 100);
                
                myarray[i, 5] = myarray[i, 0] + myarray[i, 1] + myarray[i, 2] + myarray[i, 3];
                myarray[i, 6] = myarray[i, 5] / 4;

                printArray(myarray);


               

                myarray[i, 4] = myarray[r, c];

                

               




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

        //private int GetMinimumValue()
        //{

          

            //return highest;

        }
    }







