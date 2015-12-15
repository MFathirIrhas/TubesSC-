using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesSC
{
    [Serializable]
    class ANNProcess<T> : ANNMethods<T> where T : IComparable<T>
    {
        private int PreInputNum;
        private int InputNum;
        private int HiddenNum;
        private int OutputNum;

        private PreInput[] PreInputLayer;
        private Input[] InputLayer;
        private Hidden[] HiddenLayer;
        private Output<T>[] OutputLayer;

        private double learningRate = 0.2;

        public ANNProcess(int preInputNum, int inputNum, int hiddenNum, int outputNum)
        {
            PreInputNum = preInputNum;
            InputNum = inputNum;
            HiddenNum = hiddenNum;
            OutputNum = outputNum;

            PreInputLayer = new PreInput[PreInputNum];
            InputLayer = new Input[InputNum];
            HiddenLayer = new Hidden[HiddenNum];
            OutputLayer = new Output<T>[OutputNum];
        }

        #region ANNMethods Members<T> Members

        public void BackPropagate()
        {
            int i, j;
            double total;

            //Update Hidden Layer Error
            for (i = 0; i < HiddenNum; i++)
            {
                total = 0.0;
                for (j = 0; j < OutputNum; j++)
                {
                    total += HiddenLayer[i].Weights[j] * OutputLayer[j].Error;
                }
                HiddenLayer[i].Error = total;
            }

            //Update Input layer error
            for (i = 0; i < InputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < HiddenNum; j++)
                {
                    total += InputLayer[i].Weights[j] * HiddenLayer[j].Error;
                }
                InputLayer[i].Error = total;
            }

            //Update bobot input layer
            for (i = 0; i < InputNum; i++)
            {
                for (j = 0; j < PreInputNum; j++)
                {
                    PreInputLayer[j].Weights[i] +=
                        learningRate * InputLayer[i].Error * PreInputLayer[j].Value;
                }
            }

            //Update hidden layer bobot
            for (i = 0; i < HiddenNum; i++)
            {
                for (j = 0; j < InputNum; j++)
                {
                    InputLayer[j].Weights[i] +=
                        learningRate * HiddenLayer[i].Error * InputLayer[j].Output;
                }
            }

            //Update output layer bobot
            for (i = 0; i < OutputNum; i++)
            {
                for (j = 0; j < HiddenNum; j++)
                {
                    HiddenLayer[j].Weights[i] +=
                        learningRate * OutputLayer[i].Error * HiddenLayer[j].Output;
                }
            }
        }

        public double ActivationF(double x) //Fungsi Aktivasi : Sigmoid
        {
            return (1 / (1 + Math.Exp(-x)));
        }

        public void Forward(double[] pattern, T output) //Forward Propagate
        {
            int i, j;
            double total;

            //Input layer ANN
            for (i = 0; i < PreInputNum; i++)
            {
                PreInputLayer[i].Value = pattern[i];
            }

            //Proses summing function dan activation function inputlayer ke hiddenlayer
            for (i = 0; i < InputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < PreInputNum; j++)
                {
                    total += PreInputLayer[j].Value * PreInputLayer[j].Weights[i];
                }
                InputLayer[i].InputSum = total;
                InputLayer[i].Output = ActivationF(total);
            }

            //proses summing function dan activation function hidden layer ke outputlayer
            for (i = 0; i < HiddenNum; i++)
            {
                total = 0.0;
                for (j = 0; j < InputNum; j++)
                {
                    total += InputLayer[j].Output * InputLayer[j].Weights[i];
                }

                HiddenLayer[i].InputSum = total;
                HiddenLayer[i].Output = ActivationF(total);
            }

            //menghitung Outputs, Targets and Errors
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
            for (i = 0; i < PreInputNum; i++)
            {
                PreInputLayer[i].Weights = new double[InputNum];
                for (j = 0; j < InputNum; j++)
                {
                    PreInputLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 8) / 100);
                }
            }

            for (i = 0; i < InputNum; i++)
            {
                InputLayer[i].Weights = new double[HiddenNum];
                for (j = 0; j < HiddenNum; j++)
                {
                    InputLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 8) / 100);
                }
            }

            for (i = 0; i < HiddenNum; i++)
            {
                HiddenLayer[i].Weights = new double[OutputNum];
                for (j = 0; j < OutputNum; j++)
                {
                    HiddenLayer[i].Weights[j] = 0.01 + ((double)rand.Next(0, 8) / 100);
                }
            }

            int k = 0;
            foreach (KeyValuePair<T, double[]> p in TrainingSet)
            {
                OutputLayer[k++].Value = p.Key;
            }
        }

        public void Recognize(double[] Input, ref T MatchedHigh, ref double OutputValueHight, ref T MatchedLow, ref double OutputValueLow)
        {
            int i, j;
            double total = 0.0;
            double max = -1;

            //Set input layer
            for (i = 0; i < PreInputNum; i++) //total pixel values
            {
                PreInputLayer[i].Value = Input[i];
            }

            //menghitung summing function dan activation function dari test image pada input ke hidden
            for (i = 0; i < InputNum; i++)
            {
                total = 0.0;
                for (j = 0; j < PreInputNum; j++)
                {
                    total += PreInputLayer[j].Value * PreInputLayer[j].Weights[i];
                }
                InputLayer[i].InputSum = total;
                InputLayer[i].Output = ActivationF(total);
            }

            //menghitung summing function dan activation fungsi dari hidden ke output
            for (i = 0; i < HiddenNum; i++)
            {
                total = 0.0;
                for (j = 0; j < InputNum; j++)
                {
                    total += InputLayer[j].Output * InputLayer[j].Weights[i];
                }

                HiddenLayer[i].InputSum = total;
                HiddenLayer[i].Output = ActivationF(total);
            }

            //2 Output tertinggi
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
