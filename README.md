# TextClassification on C#
A project of a classical classification problem built on C# WinFroms using CatBoost converted to Onnx, as well as FastText.NetWrapper.

## User Interface
![img1](https://user-images.githubusercontent.com/74446737/177034059-1a965130-3ea8-4a16-a942-ff442650b626.png)
![img2](https://user-images.githubusercontent.com/74446737/177034060-ed7e548a-d426-43fb-a920-ddd14a512de6.png)

## Third-party librarys used
1. [FastText NetWrapper](https://github.com/olegtarasov/FastText.NetWrapper)
2. [Yandex.CatBoost](https://github.com/catboost/catboost)
3. [Onnx.Runtime](https://github.com/microsoft/onnxruntime)
4. [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin)

## How it works (in the form of a diagram)
![Text](https://github.com/hobbitkrd/Csharp_TextClassificationWithCatBoostAndFastText/blob/master/diagramm.svg)

## DataSet 
[BBC News DataSet](https://www.kaggle.com/datasets/pariza/bbc-news-summary)

# Solutions that I have been looking for for a long time and wanted to share
- Connecting and using the onnx model
  - This is the most difficult of all stages in the course of solving this problem, since there is documentation on the Internet, but it is not exhaustive. Therefore, here is the part of the code that is responsible for the operation of the Onnx model.
```C#
 var modelInputLayerName = session.InputMetadata.Keys.Single(); // we get the name of the first (input) layer of the model

                    var dimensions = new int[] { 1, 300 }; // we set the size of the input data (if we draw analogies, it's like in Tensorflow input_shame)
                    var inputTensor = new DenseTensor<float>(TextVector, dimensions); // description of the input Tensor
                    var modelInput = new List<NamedOnnxValue>() //create input data
                    {
                        NamedOnnxValue.CreateFromTensor(modelInputLayerName, inputTensor)
                    };
                    return int.Parse(session.Run(modelInput) // processing and return of the result
                                        .ToList()[0]
                                        .AsTensor<long>()
                                        .ToArray()[0]
                                        .ToString());
```

- Сontextual removal of homonymy and application to a certain form of the word
  - For ease of processing the input text, the [MyStem(Yandex)](https://yandex.ru/dev/mystem/) was used. Of course, deeper semantic analysis requires the use of more modern solutions and approaches.
```C#
await File.WriteAllTextAsync("Data/input.txt", textFromPath.ToString(), Encoding.Default);
                using (var MySt = new Process())
                {
                    MySt.StartInfo.FileName = "Data/mystem.exe";
                    MySt.StartInfo.Arguments = "-lc Data/input.txt Data/output.txt";
                    MySt.StartInfo.UseShellExecute = false;
                    MySt.StartInfo.CreateNoWindow = true;
                    MySt.Start();
                    MySt.WaitForExit();
                    MySt.Close();
                }
                var textAfterMyStem =await File.ReadAllTextAsync("Data/output.txt", Encoding.Default);
```

## Updates 
- 02 july 2022 - Update class TextSegmaentation : after refactoring the TS class, processing decreased from 01:52 min (380 files) until 00:56.
- 03 jule 2022 - Update class Classification : processing time has improved slightly, but now it has become more readable.
- 05 jule 2022 - Update class DataGridDataAdd : А bit of a shift from procedural to oop. There was a need to change the idea of presenting data in tables. This change will increase the speed of work.
- 09 jule 2022 - During the revision of the HttpPostRequest class, it became clear that it was necessary to abandon the use of var with types where the system selects a Nullable option for them. Nullable types can certainly be modern, but I don't think they are correct. 
