using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesSC
{
    interface ANNMethods<T>
    {
        void BackPropagate();
        double ActivationF(double X);
        void Forward(double[] pattern, T output);
        double GetError();
        void InitializeNetwork(Dictionary<T, double[]> TrainingSet);
        void Recognize(double[] input, ref T Matched, ref double OutputValueHeight, ref T LowMatched , ref double OutputLowValueHeight);
    }
}
