using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastText.NetWrapper;
using MaterialSkin.Controls;

namespace TextClassification.ProcessingClass.Classification
{
    public class Vectorization
    {
        public FastTextWrapper LoadModel(FastTextWrapper FT, string ModelPath)
        {

            FT.LoadModel(ModelPath);
            return FT;

        }
        public float[] GetSentanceVector(FastTextWrapper FT, string[] SegmentationText)
        {
            string ArrayToString = string.Join(" ", SegmentationText);
            var SentanceVector =  FT.GetSentenceVector(ArrayToString);
            return SentanceVector;
        }
    }
}
