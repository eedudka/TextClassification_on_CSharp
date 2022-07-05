using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TextClassification.ProcessingClass.Classification
{
    public class Classification
    {
        public string modelPath { get; set; }
        public InferenceSession LoadClassificationModel()
        {
            return new InferenceSession(modelPath);
        }

        public int GetClassName(InferenceSession session, float[] TextVector)
        {
            try
            {
                if (session != null)
                {
                    var modelInputLayerName = session.InputMetadata.Keys.Single();

                    var dimensions = new int[] { 1, 300 };
                    var inputTensor = new DenseTensor<float>(TextVector, dimensions);
                    var modelInput = new List<NamedOnnxValue>()
                    {
                        NamedOnnxValue.CreateFromTensor(modelInputLayerName, inputTensor)
                    };
                    return int.Parse(session.Run(modelInput)
                                        .ToList()[0]
                                        .AsTensor<long>()
                                        .ToArray()[0]
                                        .ToString());
                }
                else { return -1; }
                
            }
            catch (Exception ex)
            {
                Log log = new();
                log.Add("Вызванна ошибка при получении класса текста", "GetClassName");
                return 0;
            }
        }


    }
}

