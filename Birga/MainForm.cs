using ScottPlot;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birga
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class mainForm : Form
    {
        string _path = "";
        int _progress = 0;
        FolderBrowserDialog _folderBrowserDialog =  new FolderBrowserDialog();
        List<OHLC> _prices = null;
        List<double> _values = null;
        List<DateTime> _times = null;
        Coordinates _mouseCoordinates;
        string _selectedCompany = "";
        bool load_started;

        DataSelectForm _dataSelectForm = new DataSelectForm();
        ScottPlot.Plottables.Crosshair CH;

        /// <summary>
        /// Constructor
        /// </summary>
        public mainForm()
        {
            InitializeComponent();
            pbLoadChart.Maximum = 100;
            pbLoadChart.Minimum = 0;

            CH = fpCharts.Plot.Add.Crosshair(0, 0);
            CH.TextColor = Colors.White;
            CH.TextBackgroundColor = CH.HorizontalLine.Color;

            fpCharts.Menu?.Clear();

            fpCharts.Menu?.Add("Add Positive Template", (plot) =>
            {
                DateTime dateTime = DateTime.FromOADate(_mouseCoordinates.X);
                string selection =string.Format("[{0}][{1}][{2}]", _selectedCompany, dateTime.ToString("yyyy-MM-dd"), _dataSelectForm.PointsCount);
                _dataSelectForm.AddSelection(selection, true);
            });

            fpCharts.Menu?.Add("Add Negative Template", (plot) =>
            {
                DateTime dateTime = DateTime.FromOADate(_mouseCoordinates.X);
                string selection = string.Format("[{0}][{1}][{2}]", _selectedCompany, dateTime.ToString("yyyy-MM-dd"), _dataSelectForm.PointsCount);
                _dataSelectForm.AddSelection(selection, false);
            });

            fpCharts.Menu?.Add("Auto Scale", (plot) =>
            {
                plot.Axes.AutoScale();
                plot.PlotControl?.Refresh();
            });

            fpCharts.MouseMove += (s, e) =>
            {
                try
                {
                    Pixel mousePixel = new Pixel(e.X, e.Y);
                    Coordinates mouseCoordinates = fpCharts.Plot.GetCoordinates(mousePixel);
                    _mouseCoordinates = mouseCoordinates;
                    CH.Position = mouseCoordinates;
                    CH.VerticalLine.Text = $"{DateTime.FromOADate(mouseCoordinates.X)}";
                    CH.HorizontalLine.IsVisible = false;
                    fpCharts.Refresh();
                }
                catch
                {
                }
            };

        }

        private void LoadCharts(string path)
        {
            string [] files = Directory.GetFiles(path);
            lbxCharts.Items.Clear();
            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".csv")
                {
                    long length = new System.IO.FileInfo(file).Length;
                    if (length > 1024 )
                    {
                        lbxCharts.Items.Add(Path.GetFileName(file));
                    }
                }
            }
        }

        #region UI events
        private void mainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btLoadCharts_Click(object sender, EventArgs e)
        {
            try
            {
                if(_folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    _path = _folderBrowserDialog.SelectedPath;
                    this.Text = "Birga: " + _path;
                    LoadCharts(_path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbxCharts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbxCharts.SelectedItem == null)
                {
                    return;
                }
                string path = _path + "\\" + lbxCharts.SelectedItem.ToString();
                _progress = 0;
                pbLoadChart.Value = 0;
                lbxCharts.Enabled = false;
                lbxCharts.Cursor = Cursors.WaitCursor;
                renderTimer.Enabled = true;
                load_started = true;
                Task.Run(() => LoadChartTask(path));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trbPointsTemplate_Scroll(object sender, EventArgs e)
        {

        }

        private void btTrainModel_Click(object sender, EventArgs e)
        {

        }

        private void btSaveModel_Click(object sender, EventArgs e)
        {

        }

        private void btLoadModel_Click(object sender, EventArgs e)
        {

        }

        private void btStartDetection_Click(object sender, EventArgs e)
        {

        }

        private void ntPointsSelection_Click(object sender, EventArgs e)
        {
            _dataSelectForm.Show(this);
        }

        private void btClearLog_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Render

        private void RenderChart()
        {
            var plot = fpCharts.Plot;
            plot.Clear();
            if (_values == null || _prices == null || _times == null) { return; }

            CH = fpCharts.Plot.Add.Crosshair(0, 0);
            CH.TextColor = Colors.White;
            CH.TextBackgroundColor = CH.HorizontalLine.Color;

            lock (_prices)
            {
                var ct = plot.Add.Candlestick(_prices);
                ct.Axes.YAxis = plot.Axes.Left;
                fpCharts.Plot.Axes.DateTimeTicksBottom();

                DateTime[] xs = _times.ToArray();
                double[] ys = _values.ToArray();

                var sc = plot.Add.Scatter(xs, ys, Colors.Aqua);
                sc.Axes.YAxis = plot.Axes.Right;
                sc.LegendText = "Value";
                var axis = plot.Axes.DateTimeTicksBottom();

            }

            fpCharts.Refresh();

        }

        #endregion

        #region Logging
        #endregion

        #region Tasks
        private void LoadChartTask(string file)
        {
            try
            {
                if (_prices == null)
                    _prices = new List<OHLC>();
                else
                    _prices.Clear();

                if (_values == null)
                    _values = new List<double>();
                else
                    _values.Clear();

                if (_times == null)
                    _times = new List<DateTime>();
                else
                    _times.Clear();

                var lines = File.ReadLines(file);
                _selectedCompany = fpCharts.Plot.Axes.Title.Label.Text = Path.GetFileName(file);
                TimeSpan timeSpan = TimeSpan.FromHours(24);
                int total = lines.Count<string>();
                int cnt = 0;
                foreach (string line in lines)
                {
                    string[] parameters = line.Split(',');
                    DateTime dt = new DateTime();
                    if (DateTime.TryParseExact(parameters[0], "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out dt))
                    {
                        double open = double.Parse(parameters[1]);//Generate.RandomNumber(20, 40) + prices.Count;
                        double close = double.Parse(parameters[4]);//  Generate.RandomNumber(20, 40) + prices.Count;
                        double high = double.Parse(parameters[2]);// Math.Max(open, close) + Generate.RandomNumber(5);
                        double low = double.Parse(parameters[3]);// Math.Min(open, close) - Generate.RandomNumber(5);
                        double value = double.Parse(parameters[5]);
                        lock (_prices)
                        {
                            cnt++;
                            _progress = cnt * 100 / total;
                            _prices.Add(new OHLC(open, high, low, close, dt, timeSpan));
                            _values.Add(value);
                            _times.Add(new DateTime(dt.Ticks));
                        }

                    }
                }
            }
            catch { }
            finally
            {
                load_started = false;
            }
        }

        private void renderTimer_Tick(object sender, EventArgs e)
        {
            pbLoadChart.Value = _progress;
            RenderChart();
            if (!load_started)
            {
                lbxCharts.Enabled = true;
                lbxCharts.Cursor = Cursors.Arrow;
                renderTimer.Enabled = false;
            }
        }
        #endregion

    }
}
