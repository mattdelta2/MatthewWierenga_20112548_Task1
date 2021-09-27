using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatthewWierenga_20112548_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            string[,] map = new string[10, 10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    map[i, j] = "x";
                    lblMap.Text = map[i, j];
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(map[i, j]);
                    map[i, j] = "x";
                    lblMap.Text = map[i, j];
                }
                Console.WriteLine();
            }
            Console.ReadLine(); ;
            
            


        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }
    }
}
