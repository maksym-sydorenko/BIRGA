using System;
using System.IO;
using System.Windows.Forms;

namespace Birga
{
    /// <summary>
    /// Form for describe test data
    /// </summary>
    public partial class DataSelectForm : Form
    {
        /// <summary>
        /// Points count changed delegate
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="pointsCnt">points count</param>
        public delegate void PointsCountChanged(object sender, int pointsCnt);

        /// <summary>
        /// Points count changed event
        /// </summary>
        public event PointsCountChanged OnPointsCountChanged;

        private int _points_cnt = 0;
        /// <summary>
        /// Constructor
        /// </summary>
        public DataSelectForm()
        {
            InitializeComponent();
            trbPointsTemplate.Minimum = 10;
            trbPointsTemplate.Maximum = 100;
            _points_cnt = trbPointsTemplate.Value = 20;
            lbPtTmplt.Text = String.Format("Points in template: {0}", trbPointsTemplate.Value);
            this.FormClosing += DataSelectForm_FormClosing;
        }

        /// <summary>
        /// Points Count
        /// </summary>
        public int PointsCount
        {
            get
            {
                return _points_cnt;
            }
        }

        /// <summary>
        /// Clear all train data
        /// </summary>
        public void ClearSelection()
        {
            lbxPositive.Items.Clear();
            lbxNegative.Items.Clear();
        }

        /// <summary>
        /// Add train data
        /// </summary>
        /// <param name="selection">description data string </param>
        /// <param name="isPositive">positive or negative</param>
        public void AddSelection(string selection, bool isPositive)
        {
            if (isPositive)
            {
                lbxPositive.Items.Add(selection);
            }
            else
            {
                lbxNegative.Items.Add(selection);
            }
        }

        private void DataSelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "txt files (*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader inputFile = new StreamReader(ofd.FileName))
                    {
                        string info = inputFile.ReadLine();
                        string[] info_s = info.Split(' ');
                        if (info_s.Length != 3)
                        {
                            throw new Exception("Not correct input file");
                        }
                        trbPointsTemplate.Value = int.Parse(info_s[0]);
                        int pos_cnt = int.Parse(info_s[1]);
                        int neg_cnt = int.Parse(info_s[2]);
                        for (int i = 0; i < pos_cnt; ++i)
                        {
                            string line = inputFile.ReadLine();
                            lbxPositive.Items.Add(line);
                        }
                        for (int i = 0; i < neg_cnt; ++i)
                        {
                            string line = inputFile.ReadLine();
                            lbxNegative.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt files (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter outputFile = new StreamWriter(sfd.FileName))
                    {
                        outputFile.WriteLine(string.Format("{0} {1} {2}"
                            , trbPointsTemplate.Value
                            , lbxPositive.Items.Count
                            , lbxNegative.Items.Count));

                        foreach (var item in lbxPositive.Items)
                        {
                            outputFile.WriteLine(item.ToString());
                        }

                        foreach (var item in lbxNegative.Items)
                        {
                            outputFile.WriteLine(item.ToString());
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRemovePos_Click(object sender, EventArgs e)
        {
            if (lbxPositive.SelectedItem != null)
                lbxPositive.Items.Remove(lbxPositive.SelectedItem);
        }

        private void btRemoveNeg_Click(object sender, EventArgs e)
        {
            if (lbxNegative.SelectedItem != null)
                lbxNegative.Items.Remove(lbxNegative.SelectedItem);
        }

        private void trbPointsTemplate_Scroll(object sender, EventArgs e)
        {
            lbPtTmplt.Text = String.Format("Points in template: {0}", trbPointsTemplate.Value);
           _points_cnt = trbPointsTemplate.Value;
            ClearSelection();
            if (OnPointsCountChanged != null)
            {
                OnPointsCountChanged(this, _points_cnt);
            }
        }
    }
}
