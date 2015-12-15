using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace TubesSC
{
    class ANN<T> where T : IComparable<T>
    {
        private ANNMethods<T> NeuralNet;
        private double maximumError = 1.0;
        private int Epoch = 100000;
        Dictionary<T, double[]> TrainingSet;

        public delegate void IterationChangedCallBack(object o, NeuralEventArgs args);
        public event IterationChangedCallBack IterationChanged = null;

        public ANN(ANNMethods<T> IBackPro, Dictionary<T, double[]> trainingSet)
        {
            NeuralNet = IBackPro;
            TrainingSet = trainingSet;
            NeuralNet.InitializeNetwork(TrainingSet);
        }

        public bool Train()
        {
            double currentError = 0;
            int currentIteration = 0;
            NeuralEventArgs Args = new NeuralEventArgs() ;

            do
            {
                currentError = 0;
                foreach (KeyValuePair<T, double[]> p in TrainingSet)
                {
                    NeuralNet.Forward(p.Value, p.Key);
                    NeuralNet.BackPropagate();
                    currentError += NeuralNet.GetError();
                }
                
                currentIteration++;

                if (IterationChanged != null && currentIteration % 5 == 0)
                {
                    Args.CurrentError = currentError;
                    Args.CurrentIteration = currentIteration;
                    IterationChanged(this, Args);
                }

            } while (currentError > maximumError && currentIteration < Epoch && !Args.Stop);
                        
            if (IterationChanged != null)
            {
                Args.CurrentError = currentError;
                Args.CurrentIteration = currentIteration;
                IterationChanged(this, Args);
            }

            if (currentIteration >= Epoch || Args.Stop)   
                return false;//Training Not Successful
            
            return true;
        }

        public bool Validate()
        {
            double currentError = 0;
            int currentIteration = 0;
            NeuralEventArgs Args = new NeuralEventArgs();

            do
            {
                currentError = 0;
                foreach (KeyValuePair<T, double[]> p in TrainingSet)
                {
                    NeuralNet.Forward(p.Value, p.Key);
                    NeuralNet.BackPropagate();
                    currentError += NeuralNet.GetError();
                }

                currentIteration++;

                if (IterationChanged != null && currentIteration % 5 == 0)
                {
                    Args.CurrentError = currentError;
                    Args.CurrentIteration = currentIteration;
                    IterationChanged(this, Args);
                }

            } while (currentError > maximumError && currentIteration < Epoch && !Args.Stop);

            if (IterationChanged != null)
            {
                Args.CurrentError = currentError;
                Args.CurrentIteration = currentIteration;
                IterationChanged(this, Args);
            }

            if (currentIteration >= Epoch || Args.Stop)
                return false;//Training Not Successful

            return true;
        }

        public void Recognize(double[] Input, ref T MatchedHigh, ref double OutputValueHight,ref T MatchedLow, ref double OutputValueLow)
        {
            NeuralNet.Recognize(Input, ref MatchedHigh,ref OutputValueHight,ref MatchedLow,ref OutputValueLow);
        }

        

        public double MaximumError
        {
            get { return maximumError; }
            set { maximumError = value; }
        }

        public int MaxEpoch
        {
            get { return Epoch; }
            set { Epoch = value; }
        }
    }
}
