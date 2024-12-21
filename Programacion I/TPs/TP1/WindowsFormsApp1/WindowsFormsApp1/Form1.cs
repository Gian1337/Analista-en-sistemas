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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


         
        }

        public void btnAgregar1_Click(object sender, EventArgs e)
        {
                //listBox1.Items.Add(numbersTextBox.Text);
                

             int[] array1 = new int[5] {1,2,3,4,5};

            for (int i = 0; i < array1.Length; i++)
            {
                
                listBox1.Items.Add(array1[i]);
            }


        }

        public void btnAgregar2_Click(object sender, EventArgs e)
        {
            int[] array2 = new int[5] { 6, 7, 8, 9, 10 };


            for (int i = 0; i < array2.Length; i++)
            {
                listBox2.Items.Add(array2[i]);
            }

             
        }

        public void btnMostrar_Click(object sender, EventArgs e)
        {
            int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[5] { 6, 7, 8, 9, 10 };
            int[] array3 = new int[5];

            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
                listBox3.Items.Add(array3[i]);
            }
        }
    }
}
