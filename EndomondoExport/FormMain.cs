using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EndomondoExport
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtOutputFolder.Text = Application.StartupPath;
        }

        EndomondoProxy proxy = new EndomondoProxy(String.Empty, String.Empty);

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //foreach (Control c in this.grpUserInfo.Controls)
            //{
            //    c.ResetText();
            //}

            proxy.Email = this.txtEmail.Text;
            proxy.Password = this.txtPassword.Text;

            if (!proxy.Authenticate())
            {
                MessageBox.Show("Error authenticating. Please check email and password.");
            }
            else
            {
                this.txtUserId.Text = proxy.UserId;
                this.txtDisplayName.Text = proxy.DisplayName;
            }

        }

        private void btnListWorkouts_Click(object sender, EventArgs e)
        {
            if (!proxy.IsAuthenticated)
            {
                MessageBox.Show("You must be authenticated to Endomondo using your credentials.");
            }
            else
            {
                this.Enabled = false;
                bgWorkerList.RunWorkerAsync();
            }
        }

        private void btnGetWorkouts_Click(object sender, EventArgs e)
        {
            if (!proxy.IsAuthenticated)
            {
                MessageBox.Show("You must be authenticated to Endomondo using your credentials.");
            }
            else
            {
                this.Enabled = false;
                bgWorkerDownload.RunWorkerAsync();
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            this.Enabled = false;
            bgWorkerSelectAll.RunWorkerAsync();
        }

        private void btnChooseOutput_Click(object sender, EventArgs e)
        {
            this.folderDlg.SelectedPath = this.txtOutputFolder.Text;
            if (this.folderDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtOutputFolder.Text = this.folderDlg.SelectedPath;
            }
        }

        private void dataGridList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                switch (e.ColumnIndex)
                {
                    case 0: // Check
                        break;
                    case 1: // Date
                        string date = e.Value.ToString();
                        e.Value = ConvertDate(date);
                        break;
                    case 2: // Title
                        break;
                    case 3: // Sport
                        e.Value = Enum.GetName(typeof(Constants.SportType), int.Parse(e.Value.ToString()));
                        break;
                    case 4: // Distance
                        e.Value = double.Parse(e.Value.ToString()).ToString("0.00 km");
                        break;
                    case 5: // Duration
                        e.Value = ConvertSeconds(double.Parse(e.Value.ToString()));
                        break;
                    case 6: // Avg. Speed
                        e.Value = double.Parse(e.Value.ToString()).ToString("0.0 km/h");
                        break;
                    case 7: // Route
                        break;
                    default:
                        break;
                }
                e.FormattingApplied = true;
            }
        }

        private string ConvertSeconds(double input)
        {
            var h = Math.Floor(input / 3600); //Get whole hours
            input -= h * 3600;
            var m = Math.Floor(input / 60); //Get remaining minutes
            input -= m * 60;
            // input = Math.Round(input, 2);
            // string s = h.ToString() + "h:" + (m < 10 ? "0" + m.ToString() : m.ToString()) + "m:" + (input < 10 ? "0" + input.ToString() : input.ToString()) + "s"; //zero padding on minutes and seconds
            string s = h.ToString("00") + "h:" + m.ToString("00") + "m:" + input.ToString("00") + "s";
            return s;
        }

        private string ConvertDate(string date)
        {
            // 2014-04-05 18:29:30 UTC
            // 2014-04-05T18:29:30Z
            return DateTime.Parse(date.Replace(" UTC", "Z").Replace(" ", "T")).ToLongDateString();
        }

        private void cmbSportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chkSelectAll.Checked = false;
            if (this.cmbSportType.SelectedIndex > 0)
            {
                string sportSelected = ((Constants.SportType)this.cmbSportType.SelectedItem).ToString();
                foreach (DataGridViewRow row in this.dataGridList.Rows)
                {
                    DataGridViewCheckBoxCell check = row.Cells["Select"] as DataGridViewCheckBoxCell;
                    DataGridViewCell cell = row.Cells["sportDataGridViewTextBoxColumn"] as DataGridViewCell;
                    string cellValue = Enum.GetName(typeof(Constants.SportType), int.Parse(cell.Value.ToString()));
                    check.Value = (cellValue == sportSelected) ? check.TrueValue : check.FalseValue;
                }
            }
        }

        WorkoutList list;
        private void bgWorkerList_DoWork(object sender, DoWorkEventArgs e)
        {
            list = proxy.ListWorkouts(int.Parse(this.txtMaxWorkouts.Text));
        }

        private void bgWorkerList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Enabled = true;
            dataGridList.DataSource = list.data;
            this.cmbSportType.Items.Clear();
            this.cmbSportType.Items.Add("");
            list.data.ForEach(w =>
            {
                var item = (Constants.SportType)Enum.Parse(typeof(Constants.SportType), w.sport);
                if (!this.cmbSportType.Items.Contains(item))
                {
                    this.cmbSportType.Items.Add(item);
                }
            });
        }

        private void bgWorkerDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            Type t;
            string extension = String.Empty;
            if (this.rbtnTCX.Checked)
            {
                extension = "tcx";
                t = typeof(TCX.TrainingCenterDatabase);
            }
            else
            {
                extension = "gpx";
                t = typeof(GPX.gpx);
            }
            foreach (DataGridViewRow row in this.dataGridList.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (cell.Value == cell.TrueValue)
                {
                    System.Threading.Thread.Sleep(500); // We can get throttled
                    Workout w = (Workout)row.DataBoundItem;
                    EndomondoActivity activity = proxy.RetrieveWorkout(w.id, extension);
                    if (activity != null)
                    {
                        string filePath = String.Format(@"{0}\{1}.{2}", this.txtOutputFolder.Text, w.id, extension);
                        XmlSerializer mySerializer = new XmlSerializer(t);
                        FileStream myFileStream = new FileStream(filePath, FileMode.Create);
                        mySerializer.Serialize(myFileStream, activity);
                        myFileStream.Close();
                        myFileStream.Dispose();

                        if (this.chkOriginals.Checked)
                        {
                            string originalPath = String.Format(@"{0}\{1}_original.txt", this.txtOutputFolder.Text, w.id, extension);
                            using (StreamWriter f = File.CreateText(originalPath))
                            {
                                f.Write(activity.FullContents);
                            }
                        }
                    }
                }
            }

        }

        private void bgWorkerDownload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Enabled = true;
        }

        private void bgWorkerSelectAll_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridList.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                cell.Value = this.chkSelectAll.Checked ? cell.TrueValue : cell.FalseValue;
            }
        }

        private void bgWorkerSelectAll_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Enabled = true;
        }

    }
}