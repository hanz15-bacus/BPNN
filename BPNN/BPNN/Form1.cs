using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BPNN
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        float[,] trainingData = new float[,]
           {
            {0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
            {0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
            {0.0f, 0.0f, 1.0f, 0.0f, 0.0f},
            {0.0f, 0.0f, 1.0f, 1.0f, 0.0f},
            {0.0f, 1.0f, 0.0f, 0.0f, 0.0f},
            {0.0f, 1.0f, 0.0f, 1.0f, 0.0f},
            {0.0f, 1.0f, 1.0f, 0.0f, 0.0f},
            {0.0f, 1.0f, 1.0f, 1.0f, 0.0f},
            {1.0f, 0.0f, 0.0f, 0.0f, 0.0f},
            {1.0f, 0.0f, 0.0f, 1.0f, 0.0f},
            {1.0f, 0.0f, 1.0f, 0.0f, 0.0f},
            {1.0f, 0.0f, 1.0f, 1.0f, 0.0f},
            {1.0f, 1.0f, 0.0f, 0.0f, 0.0f},
            {1.0f, 1.0f, 0.0f, 1.0f, 0.0f},
            {1.0f, 1.0f, 1.0f, 0.0f, 0.0f},
            {1.0f, 1.0f, 1.0f, 1.0f, 1.0f} 
           };

        public Form1()
        {
            InitializeComponent();
            //testEf();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 2, 1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9150; i++) {

              for (int j = 0; j < trainingData.GetLength(0); j++)
            {
            nn.setInputs(0, trainingData[j, 0]);
            nn.setInputs(1, trainingData[j, 1]);
            nn.setInputs(2, trainingData[j, 2]);
            nn.setInputs(3, trainingData[j, 3]);
            nn.setDesiredOutput(0, trainingData[j, 4]);
            nn.learn();
        }
        }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(InputA.Text));
            nn.setInputs(1, Convert.ToDouble(InputB.Text));
            nn.setInputs(2, Convert.ToDouble(InputC.Text));
            nn.setInputs(3, Convert.ToDouble(InputD.Text));
            nn.run();
            Output.Text = "" + nn.getOuputData(0);
        }

        private void testEf()
        {
            int ctr_error = 0;

            for (int k = 0; k < 100; k++)
            {
                nn = new NeuralNet(4, 2, 1);

                for (int i = 0; i < 9150; i++)
                {

                    for (int j = 0; j < trainingData.GetLength(0); j++)
                    {
                        nn.setInputs(0, trainingData[j, 0]);
                        nn.setInputs(1, trainingData[j, 1]);
                        nn.setInputs(2, trainingData[j, 2]);
                        nn.setInputs(3, trainingData[j, 3]);
                        nn.setDesiredOutput(0, trainingData[j, 4]);
                        nn.learn();
                    }
                }
                nn.setInputs(0, 1);
                nn.setInputs(1, 1);
                nn.setInputs(2, 1);
                nn.setInputs(3, 1);
                nn.run();
                if (nn.getOuputData(0) < 0.95f)
                {
                    ctr_error++;
                }
            }
            Console.WriteLine(ctr_error +" number of errors");

        }
    
    }
}
