using LiveChartsCore.SkiaSharpView;
using MaterialSkin.Controls;
using Microsoft.ML.OnnxRuntime;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextClassification.ProcessingClass;
using TextClassification.ProcessingClass.Classification;
using TextClassification.ProcessingClass.dbComand;
using TextClassification.ProcessingClass.SplitFilesIntoFolder;
using TextClassification.ProcessingClass.Vizualization;

namespace TextClassification
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> LoadFilesPaths { get; set; } = new();
        private const string ONNX_MODEL_ENG_PATH = @"Data/Models/catBoost_FastTextWrapper.onnx";
        private const string ONNX_MODEL_RUS_PATH = @"empty.onnx";
        private InferenceSession session { get; set; }

        #region MainCode
        private async void Form1_Load(object sender, EventArgs e)
        {
            Classification Onnx = new();
            Onnx.modelPath = ONNX_MODEL_ENG_PATH;
            session = Onnx.LoadClassificationModel();

            radioAllTime.Checked = true;
            switchPioChart.Checked = true;
            timer1.Enabled = true;
            timer1.Interval = 5000;
            await Task.Run(()=> timer1.Start());
            
        }
        private async void materialButton1_Click(object sender, EventArgs e)
        {
            #region Обявление полей клссов
            TextSegmentation textSegmentation = new();
            Vectorization vectarization = new();
            Classification classification = new();
            dbLoadDocument SendDocToDB = new();
            DataGridDataAdd DataGridViewData = new();
            HttpPostRequest request = new();
            #endregion

            if (LoadFilesPaths.Count > 0)
            {
                if (await Task.Run(()=>request.isServerRunning()))
                {
                    var ProcessTime = Stopwatch.StartNew();
                    foreach (var pathToTextFile in LoadFilesPaths)
                    {
                        textSegmentation.filePath = pathToTextFile;
                        var SegmentationTextVector = await Task.Run(() => request.GetVectorFromWebAPI(textSegmentation.loadedTextLanguage, textSegmentation.GetTokenize()));
                        var TextClassValue = await Task.Run(() => classification.GetClassName(session,SegmentationTextVector));

                        DataGridViewData.AddData(dataGridView1, pathToTextFile, ChangeClassValueFormat(TextClassValue), textSegmentation.loadedTextLanguage);

                        //await Task.Run(() => SendDocToDB.AddToDbNewDoc(pathToTextFile, TextClassValue.ToString(), "NaN"));

                        materialProgressBar1.Value += 1;
                        label2.Text = "Обработанно документов:" + materialProgressBar1.Value + "/" + LoadFilesPaths.Count;
                    }
                    ProcessTime.Stop();
                    var ProcessTimeResult = ProcessTime.Elapsed.Hours+":" + ProcessTime.Elapsed.Minutes+":" + ProcessTime.Elapsed.Seconds;
                    label2.Text += " ("+ProcessTimeResult+")";
                    //DataGridDataAdd.ChengeColor(dataGridView1);
                }
                else MaterialMessageBox.Show("Проверьте соединение с сервером", false);  
            }
            else MaterialMessageBox.Show("Загрузите папку с текстами!",false);
        } //Обработка
        private async void materialButton2_Click(object sender, EventArgs e)
        {
            DataForCharts dataForCharts = new();
            CreateChart createChart = new();
            #region Chart Param
            pieChart1.LegendPosition = LiveChartsCore.Measure.LegendPosition.Bottom;
            pieChart1.LegendOrientation = LiveChartsCore.Measure.LegendOrientation.Auto;

            
            var XAxes = new Axis[]
                    {
                     new Axis
                     {
                         Labeler = value => new DateTime((long) value).ToString("MMMM dd"),
                         LabelsRotation = 15,
                         UnitWidth = TimeSpan.FromDays(1).Ticks,
                         MinStep = TimeSpan.FromDays(1).Ticks
                     }
                    };
            cartesianChart1.XAxes = XAxes;
            cartesianChart1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            #endregion

            if (radioAllTime.Checked)
            {
                if (switchPioChart.Checked)
                {
                    var AllDataForPioChart = await Task.Run(() => dataForCharts.GetAllDataFromDB());
                    pieChart1.Series = await Task.Run(() => createChart.BuildPieData(AllDataForPioChart));
                }
                if (switchColumnChart.Checked)
                {
                    string ClassValue = (materialComboBox1.SelectedIndex + 1).ToString();
                    var SelectDataForColumnChart = await Task.Run(() => dataForCharts.GetAllDataFromDBForColumnChart(ClassValue));
                    cartesianChart1.Series = await Task.Run(() => createChart.BuildColumnChartData(SelectDataForColumnChart));
                }
            }
            if (radioSection.Checked)
            {
                var StartData = DateTime.ParseExact(txtStartData.Text, "dd.MM.yyyy", null);
                var EndData = DateTime.ParseExact(txtEndData.Text, "dd.MM.yyyy", null);

                if (switchPioChart.Checked)
                {
                    var SelectDataForPieChart = await Task.Run(() => dataForCharts.GetSelectDataFromDBForPie(StartData, EndData));
                    pieChart1.Series = await Task.Run(() => createChart.BuildPieData(SelectDataForPieChart));
                }
                if (switchColumnChart.Checked)
                {
                    string ClassValue = (materialComboBox1.SelectedIndex + 1).ToString();
                    var SelectDataForColumnChart = await Task.Run(() => dataForCharts.GetSelectDataFromDBForColumnChart(StartData, EndData,ClassValue));
                    cartesianChart1.Series = createChart.BuildColumnChartData(SelectDataForColumnChart);
                }

            }
            
        } //Построить
        private void materialButton5_Click(object sender, EventArgs e)
        {
            var SplitFile = new SplitFile();
            SplitFile.Split(dataGridView1);
        } //Разбить по папкам
        private void saveChart_Click(object sender, EventArgs e)
        {
            ChartToImage chartToImage = new();
            if (switchPioChart.Checked) chartToImage.Save(pieChart1);
            if (switchColumnChart.Checked) chartToImage.Save(cartesianChart1);
        } // Сохранить в фото
        #endregion
        #region DragDrop FileLoad
        private void materialCard1_DragDrop(object sender, DragEventArgs e)
        {
            LoadFilesPaths.Clear();
            foreach (string pathik in (string[])e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop))
            {
                if (Directory.Exists(pathik))
                {
                    LoadFilesPaths.AddRange(Directory.GetFiles(pathik, "*.pdf", SearchOption.AllDirectories));
                    LoadFilesPaths.AddRange(Directory.GetFiles(pathik, "*.docx", SearchOption.AllDirectories));
                    LoadFilesPaths.AddRange(Directory.GetFiles(pathik, "*.txt", SearchOption.AllDirectories));
                }
            }
            MaterialMessageBox.Show("Загруженно "+LoadFilesPaths.Count+" документов");
            label2.Text = "Обработанно документов: 0/"+LoadFilesPaths.Count;
            materialProgressBar1.Maximum = LoadFilesPaths.Count;
            materialProgressBar1.Value = 0;
        }

        private void materialCard1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(System.Windows.Forms.DataFormats.FileDrop))
            {
                e.Effect = System.Windows.Forms.DragDropEffects.Copy;
            }
        }
        #endregion
        #region Swither
        private void switchPioChart_CheckedChanged(object sender, EventArgs e)
        {
            if (switchPioChart.Checked) 
            {
                materialComboBox1.Enabled = false;
                switchColumnChart.Checked = false; 
                pieChart1.Visible = true;
                cartesianChart1.Visible = false;

                //cartesianChart1.Dispose(); 
            }
        }

        private void switchColumnChart_CheckedChanged(object sender, EventArgs e)
        {
            if (switchColumnChart.Checked)
            {
                materialComboBox1.Enabled = true;
                switchPioChart.Checked = false;
                pieChart1.Visible = false;
                cartesianChart1.Visible = true;
               // pieChart1.Dispose();
            }
        }
        #endregion
        #region RadioButton
        private void radioSection_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSection.Checked)
            {
                txtStartData.Enabled = true;
                txtEndData.Enabled = true;

            }
        }

        private void radioAllTime_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAllTime.Checked)
            {
                txtStartData.Enabled = false;
                txtEndData.Enabled = false;
            }
        }
        #endregion
        private async void timer1_Tick(object sender, EventArgs e)
        {
            HttpPostRequest request = new();
            if (await Task.Run(() => request.isServerRunning()))
            {
                label1.Text = "Состояние сервера: Доступен";
                label1.ForeColor = Color.Green;
                pictureBox2.Image = TextClassification.Properties.Resources.added;
            }
            else
            {
                label1.Text = "Состояние сервера: Не найден";
                label1.ForeColor = Color.Red;
                pictureBox2.Image = TextClassification.Properties.Resources.remove;
            } 
        }
        #region Read File From DataGrid
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            materialButton2.Enabled = true;
            if (dataGridView1.CurrentRow.Cells[6].Value.ToString() != null)
            {
                Process.Start(new ProcessStartInfo(dataGridView1.CurrentRow.Cells[6].Value.ToString()) { UseShellExecute = true });
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                materialButton2.Enabled = true;
                //int RowIndex = dataGridView1.CurrentRow.Index;

                //if (dataGridView1.Rows[RowIndex].Cells[6].Value.ToString() != null)
                //{
                //    materialButton4.Enabled = true;
                //}
        }
        private void materialButton4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[6].Value.ToString() != null)
            {
                Process.Start(new ProcessStartInfo(dataGridView1.CurrentRow.Cells[6].Value.ToString()) { UseShellExecute = true });
            }
        }
        #endregion

        public string ChangeClassValueFormat(int ClassValue)
        {
            string ClassName = string.Empty;
            switch (ClassValue)
            {
                case 1: ClassName = "c1"; break;
                case 2: ClassName = "c2"; break;
                case 3: ClassName = "c3"; break;
                case 4: ClassName = "c4"; break;
                case 5: ClassName = "c5"; break;
            }
            return ClassName;
        }
    }
}
