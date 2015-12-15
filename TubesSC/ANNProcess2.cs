using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesSC
{
    [Serializable]
    class ANNProcess2<T> : ANNMethods<T> where T : IComparable<T>
    {
        private int InputNum;
        private int HiddenNum;
        private int OutputNum;

        private Input[] InputLayer;
        private Hidden[] HiddenLayer;
        private Output<T>[] OutputLayer;

        private double learningRate = 0.2;      

        public ANNProcess2(int inputNum, int hiddenNum, int outputNum)
        {
            InputNum = inputNum;
            HiddenNum = hiddenNum;
            OutputNum = outputNum;

            InputLayer = new Input[InputNum];
            HiddenLayer = new Hidden[HiddenNum];
            OutputLayer = new Output<T>[OutputNum];          
        }

        #region ANNMethods<T> Members
        public void BackPropagate()
        {
            int i, j;
            double total;

            //fix bobot
            for (i = 0; i < HiddenNum; i++)
            {
                total = 0.0;
                for (j = 0; j < OutputNum; j++)
                {
                    total += HiddenLayer[i].Weights[j] * OutputLayer[j].Error;
                }
                HiddenLayer[i].Error = total;
            }

            //update bobot ke layer hidden
            for (i = 0; i < HiddenNum; i++)
            {
                for (j = 0; j < InputNum; j++)
                {
                    InputLayer[j].Weights[i] +=
                        learningRate * HiddenLayer[i].Error * InputLayer[j].Value;
                }
            }

            //updata bobot layer ke output
            for (i = 0; i < OutputNum; i++)
            {
                for (j = 0; j < HiddenNum; j++)
                {
                    HiddenLayer[j].Weights[i] +=
                        learningRate * OutputLayer[i].Error * HiddenLayer[j].Output;
                }
            }            
        }

        public double ActivationF(double x)
        {
            return (1 / (1 + Math.Exp(-x)));
        }

        public void Forward(double[] pattern, T output)
        {
            int i, j;
            double total = 0.0;

            //Set input layer
            for (i = 0; i < InputNum; i++)
            {
                InputLayer[i].Value = pattern[i];
            }

            //Menghitung summing function dan activation function antara input dan hidden
            for (i = 0; i < HiddenNum; i++)
            {
                total = 0.0;
                for (j = 0; j < InputNum; j++)
                {
                    total += InputLayer[j].Value * InputLayer[j].Weights[i];
                }

                HiddenLayer[i].InputSum = total;
                HiddenLayer[i].Output = ActivationF(total);
            }

            //Menghitung summing function dan activation function antara hidden dan output
            for (i = 0; i < OutputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < HiddenNum; j++)
                {
                    total += HiddenLayer[j].Output * HiddenLayer[j].Weights[i];
                }

                OutputLayer[i].InputSum = total;
                OutputLayer[i].output = ActivationF(total);
                OutputLayer[i].Target = OutputLayer[i].Value.CompareTo(output) == 0 ? 1.0 : 0.0;
                OutputLayer[i].Error = (OutputLayer[i].Target - OutputLayer[i].output) * (OutputLayer[i].output) * (1 - OutputLayer[i].output);
            }
        }

        public double GetError()
        {
            double total = 0.0;
            for (int j = 0; j < OutputNum; j++)
            {
                total += Math.Pow((OutputLayer[j].Target - OutputLayer[j].output), 2) / 2;
            }
            return total;
        }

        public void InitializeNetwork(Dictionary<T, double[]> TrainingSet)
        {
            int i, j;
            Random rand = new Random();
            for (i = 0; i < InputNum; i++)
            {
                InputLayer[i].Weights = new double[HiddenNum];
                for (j = 0; j < HiddenNum; j++)
                {
                    InputLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 5) / 100);
                }
            }

            for (i = 0; i < HiddenNum; i++)
            {
                HiddenLayer[i].Weights = new double[OutputNum];
                for (j = 0; j < OutputNum; j++)
                {
                    HiddenLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 5) / 100);
                }
            }

            int k = 0;
            foreach (KeyValuePair<T, double[]> p in TrainingSet)
            {
                OutputLayer[k++].Value = p.Key;
            }
        }

        public void Recognize(double[] Hidden, ref T MatchedHigh, ref double OutputValueHight, ref T MatchedLow, ref double OutputValueLow)
        {
            int i, j;
            double total = 0.0;
            double max = -1;

            
            for (i = 0; i < InputNum; i++)
            {
                InputLayer[i].Value = Hidden[i];
            }

            
            for (i = 0; i < HiddenNum; i++)
            {
                total = 0.0;
                for (j = 0; j < InputNum; j++)
                {
                    total += InputLayer[j].Value * InputLayer[j].Weights[i];
                }
                HiddenLayer[i].InputSum = total;
                HiddenLayer[i].Output = ActivationF(total);
            }

            //2 tertinggi
            for (i = 0; i < OutputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < HiddenNum; j++)
                {
                    total += HiddenLayer[j].Output * HiddenLayer[j].Weights[i];
                }
                OutputLayer[i].InputSum = total;
                OutputLayer[i].output = ActivationF(total);
                if (OutputLayer[i].output > max)
                {
                    MatchedLow = MatchedHigh;
                    OutputValueLow = max;
                    max = OutputLayer[i].output;
                    MatchedHigh = OutputLayer[i].Value;
                    OutputValueHight = max;
                }
            }
        }

        #endregion

        public double LearningRate
        {
            get { return learningRate; }
            set { learningRate = value; }
        }
    }
}
