using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Threading;
using MathNet;
using System.Web.Http.Results;
using static Microsoft.FSharp.Core.ByRefKinds;
using Expr = MathNet.Symbolics.SymbolicExpression;
using MathNet.Numerics;
using MathNet.Symbolics;
using MathNet.Numerics.Differentiation;
using System.Reflection;
using System.Web;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Linq.Expressions;
using CsvHelper;
using System.Globalization;
using System.Net.Mail;
using Microsoft.Office.Interop.Excel;
using System.Net;



namespace DLR_Projekt.NetApp
{
    public partial class Form1 : Form
    {
        
        //variables
        public double UpperCharttime = 0;
        public double LowerCharttime = 0;
        public double LowerRightCharttime = 0;
        public static double PulseDuration; 
        public static double CentralWavelenght; //um
        public static double BBOCrystalLenght; //mm
        public static double CentralWavelenghty; 
        public static double GVM;
        public static double GVMTotal;
        public static double PulseElongation;

        public double yCoordinatesUpperChart;
        public double yCoordinatesLowerChart;
        public double yCoordinatesLowerRightChart;

        public double CentralWavelenghtInput;

        public static double Delay;
        static double c = 3e8; // m/s

        public bool calc1 = false;
        public bool calc2 = false;

        public static double BandWidth; //nm
        public static double SecondHarmonicBandWidth; //nm

        public double UpperChartcalcTime = 1;
        public double LowerChartcalcTime = 1;
        public double LowerRightChartcalcTime = 1;

        String timeStamp = GetTimestamp(DateTime.Now);

        Func<double, double> n = x => Math.Sqrt(0.90291 * x * x / (x * x - 0.003926) + 0.83155 * x * x / (x * x - 0.018786) + 0.76535 * x * x / (x * x - 60.01) + 1);
        Func<double, double> m = r => ((0.44 * Math.Pow(r, 2) / c) / PulseDuration) * Math.Pow(10, 12);

        public Excel.Application ExcelApp = null;
        public Excel.Workbooks ExcelBooks = null;
        public Excel.Sheets ExcelSheets = null;
        public Excel._Workbook ExcelBook = null;
        public Excel._Worksheet ExcelSheet = null;
        public Excel.Range ExcelRange = null;
        private object m_objOpt = System.Reflection.Missing.Value;
        private object m_strSampleFolder = "C:\\DLR_Calculations\\";

        public string ExcelATime;
        public string ExcelBTime;
        public string ExcelDTime;

        public int ExcelTime;

        public string[] ListOfVariables = {"0","Central Wavelength in nm", "Refractive Index in xyz", "BBO Crystallength in mm", "Bandwidth in nm", "Second Harmonic Bandwidth in nm", "GDD in fs²", "GVM in xyz", "GVM Total in xyz", "Pulse Duration", "Pulse Elongation" };
        public double[] ListOfVariablesValue = { 0, CentralWavelenght, CentralWavelenghty, BBOCrystalLenght, BandWidth, SecondHarmonicBandWidth, Delay, GVM, GVMTotal, PulseDuration, PulseElongation };

        public int NewCalcCount = 0;
        public int SheetExistsCount = 1;

        public bool DoesSheetExist = true;

        public string SheetExistsStr;

        DialogResult makeSheet;

        string user;

        //on start
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            upperChart.Series["upperChart"].BorderWidth = 3;
            lowerChart.Series["lowerChart"].BorderWidth = 3;
            lowerRightChart.Series["lowerRightChart"].BorderWidth = 3;

            upperChart.ChartAreas["UpperChartArea"].CursorX.Interval = 0.01;
            upperChart.ChartAreas["UpperChartArea"].AxisX.ScaleView.Zoomable = true;
            upperChart.ChartAreas["UpperChartArea"].CursorX.AutoScroll = true;
            upperChart.ChartAreas["UpperChartArea"].CursorX.IsUserSelectionEnabled = true;
            upperChart.ChartAreas["UpperChartArea"].AxisX.ScrollBar.Enabled = false;

            upperChart.ChartAreas["UpperChartArea"].CursorY.Interval = 0.01;
            upperChart.ChartAreas["UpperChartArea"].AxisY.ScaleView.Zoomable = true;
            upperChart.ChartAreas["UpperChartArea"].CursorY.AutoScroll = true;
            upperChart.ChartAreas["UpperChartArea"].CursorY.IsUserSelectionEnabled = true;
            upperChart.ChartAreas["UpperChartArea"].AxisY.ScrollBar.Enabled = false;



            lowerChart.ChartAreas["lowerChartArea"].CursorX.Interval = 0.01;
            lowerChart.ChartAreas["lowerChartArea"].AxisX.ScaleView.Zoomable = true;
            lowerChart.ChartAreas["lowerChartArea"].CursorX.AutoScroll = true;
            lowerChart.ChartAreas["lowerChartArea"].CursorX.IsUserSelectionEnabled = true;
            lowerChart.ChartAreas["lowerChartArea"].AxisX.ScrollBar.Enabled = false;

            lowerChart.ChartAreas["lowerChartArea"].CursorY.Interval = 0.01;
            lowerChart.ChartAreas["lowerChartArea"].AxisY.ScaleView.Zoomable = true;
            lowerChart.ChartAreas["lowerChartArea"].CursorY.AutoScroll = true;
            lowerChart.ChartAreas["lowerChartArea"].CursorY.IsUserSelectionEnabled = true;
            lowerChart.ChartAreas["lowerChartArea"].AxisY.ScrollBar.Enabled = false;



            lowerRightChart.ChartAreas["lowerRightChartArea"].CursorX.Interval = 0.01;
            lowerRightChart.ChartAreas["lowerRightChartArea"].AxisX.ScaleView.Zoomable = true;
            lowerRightChart.ChartAreas["lowerRightChartArea"].CursorX.AutoScroll = true;
            lowerRightChart.ChartAreas["lowerRightChartArea"].CursorX.IsUserSelectionEnabled = true;
            lowerRightChart.ChartAreas["lowerRightChartArea"].AxisX.ScrollBar.Enabled = false;

            lowerRightChart.ChartAreas["lowerRightChartArea"].CursorY.Interval = 0.01;
            lowerRightChart.ChartAreas["lowerRightChartArea"].AxisY.ScaleView.Zoomable = true;
            lowerRightChart.ChartAreas["lowerRightChartArea"].CursorY.AutoScroll = true;
            lowerRightChart.ChartAreas["lowerRightChartArea"].CursorY.IsUserSelectionEnabled = true;
            lowerRightChart.ChartAreas["lowerRightChartArea"].AxisY.ScrollBar.Enabled = false;


            Input3.Increment = 0.25M;
            Input2.Increment = 0.25M;
            Input1.Increment = 0.25M;

            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(Convert.ToInt32(workingRectangle.Width * 0.5), Convert.ToInt32(workingRectangle.Height * 0.5));
            this.Location = new System.Drawing.Point(10, 10);

            fillUpperChart();
            fillLowerChart();
            fillLowerRightChart();

            string dir = @"C:\DLR_Calculations";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            CreateSheet.Text = "Create" + Environment.NewLine + "Excel Sheet";


        }



        //UI 1
        public void Calculation1UIfun() 
        {
            Input1.Visible = true;
            Input2.Visible = true;
            Input3.Visible = false;
            Input4.Visible = false;

            PulseDurationDrop.Visible = false;
            BandWidthDrop.Visible = false;

            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            yLabel.Visible = true;
            label11.Visible = false;


            LowerRightCharttime = 0;
            LowerCharttime = 0;
            UpperCharttime = 0;
            lowerRightChart.Series["lowerRightChart"].Points.Clear();
            lowerChart.Series["lowerChart"].Points.Clear();
            upperChart.Series["upperChart"].Points.Clear();

            upperChart.ChartAreas[0].AxisX.Maximum = 2;
            upperChart.ChartAreas[0].AxisX.Minimum = 0.25;
            upperChart.ChartAreas[0].AxisY.Maximum = 2;
            upperChart.ChartAreas[0].AxisY.Minimum = 1.5;

            upperChart.ChartAreas[0].AxisX.Interval = 0.25;
            upperChart.ChartAreas[0].AxisY.Interval = 0.1;

            upperChart.ChartAreas[0].AxisX.Title = "Wavelength";
            upperChart.ChartAreas[0].AxisY.Title = "Refractive Index";

            upperChart.Titles[0].Text = "Refractive Index / Wavelength";

            lowerChart.ChartAreas[0].AxisX.Title = "Wavelength";
            lowerChart.ChartAreas[0].AxisY.Title = "Refractive Index";

            lowerChart.Titles[0].Text = "First Derivative";

            lowerRightChart.ChartAreas[0].AxisX.Title = "fs²";
            lowerRightChart.ChartAreas[0].AxisY.Title = "GDD";

            lowerRightChart.Titles[0].Text = "GDD";


            lowerRightChart.ChartAreas[0].AxisX.Maximum = 2;
            lowerRightChart.ChartAreas[0].AxisX.Minimum = 0.25;
            lowerRightChart.ChartAreas[0].AxisY.Maximum = 3000;
            lowerRightChart.ChartAreas[0].AxisY.Minimum = -500;

            lowerRightChart.ChartAreas[0].AxisX.Interval = 0.25;
            lowerRightChart.ChartAreas[0].AxisY.Interval = 700;


            lowerChart.ChartAreas[0].AxisX.Maximum = 2;
            lowerChart.ChartAreas[0].AxisX.Minimum = 0.25;
            lowerChart.ChartAreas[0].AxisY.Maximum = 1;
            lowerChart.ChartAreas[0].AxisY.Minimum = -2;

            lowerChart.ChartAreas[0].AxisX.Interval = 0.25;
            lowerChart.ChartAreas[0].AxisY.Interval = 0.5;




        }
        //UI 2
        public void Calculation2UIfun()
        {
            Input1.Visible = true;
            Input2.Visible = true;
            Input3.Visible = true;
            Input4.Visible = true;

            PulseDurationDrop.Visible = true;
            BandWidthDrop.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            yLabel.Visible = true;
            label11.Visible = true;


            LowerRightCharttime = -0.25;
            LowerCharttime = -0.25;
            UpperCharttime = -0.25;
            lowerRightChart.Series["lowerRightChart"].Points.Clear();
            lowerChart.Series["lowerChart"].Points.Clear();
            upperChart.Series["upperChart"].Points.Clear();
            
            lowerRightChart.ChartAreas[0].AxisX.Maximum = 1000;
            lowerRightChart.ChartAreas[0].AxisX.Minimum = 0;
            lowerRightChart.ChartAreas[0].AxisY.Maximum = 1000;
            lowerRightChart.ChartAreas[0].AxisY.Minimum = 0;

            lowerRightChart.ChartAreas[0].AxisX.Interval = 100;
            lowerRightChart.ChartAreas[0].AxisY.Interval = 100;

            lowerRightChart.ChartAreas[0].AxisX.Title = "Input Pulse Duration in fs";
            lowerRightChart.ChartAreas[0].AxisY.Title = "Pulse Elongation in fs";

            lowerRightChart.Titles[0].Text = "Pulse Elongation";
            
            lowerChart.ChartAreas[0].AxisX.Maximum = 10;
            lowerChart.ChartAreas[0].AxisX.Minimum = 0;
            lowerChart.ChartAreas[0].AxisY.Maximum = 1000;
            lowerChart.ChartAreas[0].AxisY.Minimum = 0;

            lowerChart.ChartAreas[0].AxisX.Interval = 1;
            lowerChart.ChartAreas[0].AxisY.Interval = 100;

            lowerChart.ChartAreas[0].AxisX.Title = "Crystal length in mm";
            lowerChart.ChartAreas[0].AxisY.Title = "Second Harmonic Bandwidth in nm";

            lowerChart.Titles[0].Text = "Second Harmonic Bandwidth";
            
            upperChart.ChartAreas[0].AxisX.Maximum = 100;
            upperChart.ChartAreas[0].AxisX.Minimum = 0;
            upperChart.ChartAreas[0].AxisY.Maximum = 100;
            upperChart.ChartAreas[0].AxisY.Minimum = 0;

            upperChart.ChartAreas[0].AxisX.Interval = 10;
            upperChart.ChartAreas[0].AxisY.Interval = 10;

            upperChart.ChartAreas[0].AxisX.Title = "Pulse Duration in fs";
            upperChart.ChartAreas[0].AxisY.Title = "Bandwidth in nm";

            upperChart.Titles[0].Text = "Bandwidth";
            
        }
        //feedback


        //Upper Chart1
        public void UpperChartFunctionFunction1()
        {
            yCoordinatesUpperChart = Math.Sqrt(0.90291 * UpperCharttime * UpperCharttime / (UpperCharttime * UpperCharttime - 0.003926) + 0.83155 * UpperCharttime * UpperCharttime / (UpperCharttime * UpperCharttime - 0.018786) + 0.76535 * UpperCharttime * UpperCharttime / (UpperCharttime * UpperCharttime - 60.01) + 1);
        }
        //Upper Chart2
        public void UpperChartFunctionFunction2()
        {
            yCoordinatesUpperChart = (0.44 * Math.Pow(CentralWavelenght, 2) / c) / UpperCharttime * Math.Pow(10,12);
        }


        //Upper Chart1
        public void UpperChartFunctionFunction1Excel()
        {
            yCoordinatesUpperChart = Math.Sqrt(0.90291 * ExcelTime * ExcelTime / (ExcelTime * ExcelTime - 0.003926) + 0.83155 * ExcelTime * ExcelTime / (ExcelTime * ExcelTime - 0.018786) + 0.76535 * ExcelTime * ExcelTime / (ExcelTime * ExcelTime - 60.01) + 1);
        }


        //Lower Chart1
        public void LowerChartFunctionFunction1()
        {
            yCoordinatesLowerChart = Differentiate.FirstDerivative(n, LowerCharttime);
        }
        //Lower Chart2
        public void LowerChartFunctionFunction2()
        {
            yCoordinatesLowerChart = (0.44 * CentralWavelenght / LowerCharttime) / (Differentiate.FirstDerivative(n, CentralWavelenght) - (0.5 * Differentiate.FirstDerivative(n, CentralWavelenght / 2))) * Math.Pow(10, 3);
        }


        // lower right chart1
        public void LowerRightChartFunctionFunction1()
        {
            yCoordinatesLowerRightChart = ((Differentiate.SecondDerivative(n, LowerRightCharttime)) * Math.Pow(10, 21)) * (Math.Pow(LowerRightCharttime, 3) / (2 * Math.PI * Math.Pow(c, 2)) * BBOCrystalLenght);
        }
        // lower right chart2
        public void LowerRightChartFunctionFunction2()
        {
            yCoordinatesLowerRightChart = (LowerRightCharttime * Math.Sqrt(1 + Math.Pow(4 * Math.Log(2) * (Delay / Math.Pow(LowerRightCharttime, 2)), 2)));
        }



        //upper chart fill
        private void fillUpperChart()
        {
            
            while (UpperCharttime < UpperChartcalcTime)
            {
                if (calc1)
                {
                    UpperChartcalcTime = 2;
                    UpperCharttime += 0.05;
                    UpperChartFunctionFunction1();
                }
                else if (calc2)
                {
                    UpperChartcalcTime = 100;
                    UpperCharttime += 0.5;
                    UpperChartFunctionFunction2();
                }
                else
                {
                    UpperChartcalcTime = 100;
                    UpperCharttime += 0.5;
                    UpperChartFunctionFunction3();
                }
                upperChart.Series["upperChart"].Points.AddXY(UpperCharttime, yCoordinatesUpperChart);
            }
            
        }
        //lower chart fill
        private void fillLowerChart()
        {
            
            while (LowerCharttime < LowerChartcalcTime)
            {
                if (calc1)
                {
                    LowerChartcalcTime = 2;
                    LowerCharttime += 0.05;
                    LowerChartFunctionFunction1();
                }
                else if (calc2)
                {
                    LowerChartcalcTime = 1000;
                    LowerCharttime += 1;
                    LowerChartFunctionFunction2();
                }
                else
                {
                    LowerChartcalcTime = 1000;
                    LowerCharttime += 0.5;
                    LowerChartFunctionFunction3();
                }
                lowerChart.Series["lowerChart"].Points.AddXY(LowerCharttime, yCoordinatesLowerChart);
            }
            
        }
        //fill lower right chart
        private void fillLowerRightChart()
        {
            
            while (LowerRightCharttime < LowerRightChartcalcTime)
            {
                if (calc1)
                {
                    LowerRightChartcalcTime = 2;
                    LowerRightCharttime += 0.05;
                    LowerRightChartFunctionFunction1();
                }
                else if (calc2)
                {
                    LowerRightChartcalcTime = 1000;
                    LowerRightCharttime += 1;
                    LowerRightChartFunctionFunction2();
                }
                else
                {
                    LowerRightChartcalcTime = 1000;
                    LowerRightCharttime += 0.5;
                    LowerRightChartFunctionFunction3();
                }
                lowerRightChart.Series["lowerRightChart"].Points.AddXY(LowerRightCharttime, yCoordinatesLowerRightChart);
                
            }
            
        }
        


        public void ExcelConnectFun()
        {
            double[] ListOfVariablesValue = { 0, CentralWavelenght, CentralWavelenghty, BBOCrystalLenght, BandWidth, SecondHarmonicBandWidth, Delay, GVM, GVMTotal, PulseDuration, PulseElongation };

            String timeStamp = GetTimestamp(DateTime.Now);
            string dir = @"C:\DLR_Calculations";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            ExcelApp = new Excel.Application();
            ExcelBooks = (Excel.Workbooks)ExcelApp.Workbooks;
            ExcelBook = (Excel._Workbook)(ExcelBooks.Add(m_objOpt));

            ExcelSheets = (Excel.Sheets)ExcelBook.Worksheets;
            ExcelSheet = (Excel._Worksheet)(ExcelSheets.get_Item(1));

            ExcelSheet.Columns[1].ColumnWidth= 29;
            
            for (int ExcelTime = 1; ExcelTime < 11; ExcelTime++)
            {
                ExcelATime = "A" + ExcelTime.ToString();
                ExcelRange = ExcelSheet.get_Range(ExcelATime, m_objOpt);
                ExcelRange.Value = ListOfVariables[ExcelTime];
            }
            for (int ExcelTime = 1; ExcelTime < 11; ExcelTime++)
            {
                ExcelBTime = "B" + ExcelTime.ToString();
                ExcelRange = ExcelSheet.get_Range(ExcelBTime, m_objOpt);
                ExcelRange.Value = ListOfVariablesValue[ExcelTime];
            }
            try
            {
                ExcelBook.SaveAs(m_strSampleFolder + "Calculations in Excel" + timeStamp.ToString() + ".xlsx");
                ExcelBook.Close(false, m_objOpt, m_objOpt);
                ExcelApp.Quit();
            }
            catch { }
        
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy.MM.dd.HH.mm.ss.ff");
        }



        //calculations 1
        private void GetValuesFun1()
        {
            CentralWavelenght = Decimal.ToDouble(Input2.Value);
            string PulseDurationDropInput = PulseDurationDrop.Text;
            BBOCrystalLenght = Decimal.ToDouble(Input1.Value);
            Delay = ((Differentiate.SecondDerivative(n, CentralWavelenght)) * Math.Pow(10, 21)) * (Math.Pow(CentralWavelenght, 3) / (2 * Math.PI * Math.Pow(c, 2)) * BBOCrystalLenght);
            DelayLabel.Text = "GDD = " + Delay.ToString();
            CentralWavelenghty = Math.Sqrt(0.90291 * CentralWavelenght * CentralWavelenght / (CentralWavelenght * CentralWavelenght - 0.003926) + 0.83155 * CentralWavelenght * CentralWavelenght / (CentralWavelenght * CentralWavelenght - 0.018786) + 0.76535 * CentralWavelenght * CentralWavelenght / (CentralWavelenght * CentralWavelenght - 60.01) + 1);
            yLabel.Text = "Refractive Index = " + CentralWavelenghty;
        }
        //calculations 2
        private void GetValuesFun2()
        {
            CentralWavelenght = Decimal.ToDouble(Input2.Value) * Math.Pow(10,-3);
            string PulseDurationDropInput = PulseDurationDrop.Text;
            string BandWidthDropInput = BandWidthDrop.Text;
            BBOCrystalLenght = Decimal.ToDouble(Input1.Value);


            if (PulseDurationDropInput == "fs")
            {
                PulseDuration = Decimal.ToDouble(Input3.Value);
            }
            else if (PulseDurationDropInput == "ps")
            {
                PulseDuration = Decimal.ToDouble(Input3.Value) * Math.Pow(10, -3);
            }
            else if (PulseDurationDropInput == "ns")
            {
                PulseDuration = Decimal.ToDouble(Input3.Value) * Math.Pow(10, -6);
            }
            else { PulseDuration = 0; }

            if (BandWidthDropInput == "nm")
            {
                BandWidth = Decimal.ToDouble(Input4.Value);
            }
            else if (BandWidthDropInput == "mm")
            {
                BandWidth = Decimal.ToDouble(Input4.Value) * Math.Pow(10, 6);
            }
            else { BandWidth = 0; }

            if (BandWidth == 0) 
            {
                BandWidth = (0.44 * Math.Pow(CentralWavelenght, 2) / c) / PulseDuration * Math.Pow(10, 12);
            }

            
            Delay = ((Differentiate.SecondDerivative(n, CentralWavelenght)) * Math.Pow(10, 21)) * (Math.Pow(CentralWavelenght, 3) / (2 * Math.PI * Math.Pow(c, 2)) * BBOCrystalLenght);
            CentralWavelenghty = Math.Sqrt(0.90291 * CentralWavelenght * CentralWavelenght / (CentralWavelenght * CentralWavelenght - 0.003926) + 0.83155 * CentralWavelenght * CentralWavelenght / (CentralWavelenght * CentralWavelenght - 0.018786) + 0.76535 * CentralWavelenght * CentralWavelenght / (CentralWavelenght * CentralWavelenght - 60.01) + 1);
            GVM = (CentralWavelenght / c) * (Differentiate.FirstDerivative(n, CentralWavelenght) - (0.5 * Differentiate.FirstDerivative(n, CentralWavelenght / 2))) * Math.Pow(10,12);
            GVMTotal = GVM * BBOCrystalLenght;
            SecondHarmonicBandWidth = (0.44 * CentralWavelenght / BBOCrystalLenght) / (Differentiate.FirstDerivative(n, CentralWavelenght) - (0.5 * Differentiate.FirstDerivative(n, CentralWavelenght / 2))) * Math.Pow(10,3);
            PulseElongation = (PulseDuration * Math.Sqrt(1 + Math.Pow(4 * Math.Log(2) * (Delay / Math.Pow(PulseDuration, 2)), 2))) - PulseDuration;



            label6.Text = "Second Harmonic Bandwidth = " + Math.Round(SecondHarmonicBandWidth,4) + " nm";
            label9.Text = "GVM Total = " + Math.Round(GVMTotal, 4) + " fs";
            yLabel.Text = "Refractive Index = " + Math.Round(CentralWavelenghty, 4);
            label8.Text = "GVM = " + Math.Round(GVM, 4) + " fs/mm";
            label7.Text = "Bandwidth = " + Math.Round(BandWidth, 4) + " nm";
            DelayLabel.Text = "GDD = " + Math.Round(Delay, 4) + " fs²";
            label11.Text = "Pulse elongation = " + Math.Round(PulseElongation) + " fs";
        }


        //if calc 1
        private void Calculation1btn_Click(object sender, EventArgs e)
        {
            calc1 = true;
            calc2 = false;
            Calculation1UIfun();
        }
        //if calc2
        private void Calculation2btn_Click(object sender, EventArgs e)
        {
            calc1 = false;
            calc2 = true;
            Calculation2UIfun();
        }





        //upperchart resize
        private void upperChart_Click(object sender, EventArgs e)
        {
            upperChart.ChartAreas["UpperChartArea"].AxisX.ScaleView.ZoomReset();
            upperChart.ChartAreas["UpperChartArea"].AxisY.ScaleView.ZoomReset();
        }

        //lower chart resize
        private void lowerChart_Click(object sender, EventArgs e)
        {
            lowerChart.ChartAreas["lowerChartArea"].AxisX.ScaleView.ZoomReset();
            lowerChart.ChartAreas["lowerChartArea"].AxisY.ScaleView.ZoomReset();
        }

        // lower right chart resize
        private void lowerRightChart_Click(object sender, EventArgs e)
        {
            lowerRightChart.ChartAreas["lowerRightChartArea"].AxisX.ScaleView.ZoomReset();
            lowerRightChart.ChartAreas["lowerRightChartArea"].AxisY.ScaleView.ZoomReset();
        }



        private void CreateSheet_Click(object sender, EventArgs e)
        {

                makeSheet = MessageBox.Show("Are you sure you want to make this sheet?","", MessageBoxButtons.YesNo);
                if (makeSheet == DialogResult.Yes)
                {
                    ExcelConnectFun();
                }
            
            
        }

        

        //Upper Chart1
        public void UpperChartFunctionFunction3()
        {
            yCoordinatesUpperChart = Math.Pow(UpperCharttime,2);
        }


        //Lower Chart1
        public void LowerChartFunctionFunction3()
        {
            yCoordinatesLowerChart = Math.Pow(LowerCharttime, 2);
        }


        // lower right chart1
        public void LowerRightChartFunctionFunction3()
        {
            yCoordinatesLowerRightChart = Math.Pow(LowerRightCharttime, 2);
        }

        private void CalculateButton_Click_2(object sender, EventArgs e)
        {
            if (calc1)
            {
                try
                {
                    LowerRightCharttime = 0;
                    LowerCharttime = 0;
                    UpperCharttime = 0;
                    lowerRightChart.Series["lowerRightChart"].Points.Clear();
                    lowerChart.Series["lowerChart"].Points.Clear();
                    upperChart.Series["upperChart"].Points.Clear();
                    GetValuesFun1();
                    fillLowerChart();
                    fillUpperChart();
                    fillLowerRightChart();
                }
                catch { }
            }
            else
            {
                try
                {
                    BandWidth = 0;
                    LowerCharttime = 0;
                    UpperCharttime = 0;
                    lowerChart.Series["lowerChart"].Points.Clear();
                    upperChart.Series["upperChart"].Points.Clear();
                    GetValuesFun2();
                    fillLowerChart();
                    fillUpperChart();
                    fillLowerRightChart();
                }
                catch { }
            }
        }

        private void CreateCSV_Click(object sender, EventArgs e)
        {

                makeSheet = MessageBox.Show("Are you sure you want to make this file?", "", MessageBoxButtons.YesNo);
                if (makeSheet == DialogResult.Yes)
                {
                    double[] ListOfVariablesValue = { 0, CentralWavelenght, CentralWavelenghty, BBOCrystalLenght, BandWidth, SecondHarmonicBandWidth, Delay, GVM, GVMTotal, PulseDuration, PulseElongation };

                    String timeStamp = GetTimestamp(DateTime.Now);
                    string dir = @"C:\DLR_Calculations";
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    ExcelApp = new Excel.Application();
                    ExcelBooks = (Excel.Workbooks)ExcelApp.Workbooks;
                    ExcelBook = (Excel._Workbook)(ExcelBooks.Add(m_objOpt));

                    ExcelSheets = (Excel.Sheets)ExcelBook.Worksheets;
                    ExcelSheet = (Excel._Worksheet)(ExcelSheets.get_Item(1));

                    ExcelSheet.Columns[1].ColumnWidth = 29;

                    for (int ExcelTime = 1; ExcelTime < 11; ExcelTime++)
                    {
                        ExcelATime = "A" + ExcelTime.ToString();
                        ExcelRange = ExcelSheet.get_Range(ExcelATime, m_objOpt);
                        ExcelRange.Value = ListOfVariables[ExcelTime];
                    }
                    for (int ExcelTime = 1; ExcelTime < 11; ExcelTime++)
                    {
                        ExcelBTime = "B" + ExcelTime.ToString();
                        ExcelRange = ExcelSheet.get_Range(ExcelBTime, m_objOpt);
                        ExcelRange.Value = ListOfVariablesValue[ExcelTime];
                    }
                    try
                    {
                        ExcelBook.SaveAs("C:\\DLR_Calculations\\Calculations in CSV" + timeStamp + ".csv", Microsoft.Office.Interop.Excel.XlFileFormat.xlCSV);
                        ExcelBook.Close(false, m_objOpt, m_objOpt);
                        ExcelApp.Quit();
                    }
                    catch { }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=DmwnWsdCtjtbmnbPNtXKqhhzCvtKzQDWfdxNZGcMcQmBMBTDMxWXRbRpCgBptXDJdFvGThzXwGwV");
        }


    }
}
