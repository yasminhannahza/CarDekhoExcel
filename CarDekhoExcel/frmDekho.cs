using CarDekhoExcel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDekhoExcel
{
    public partial class frmDekho : Form
    {
        int sortType = 0;

        public frmDekho()
        {
            InitializeComponent();
        }

        public async Task UpdateConsole(string message, Exception ex = null)
        {
            string outputText = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}:\r\n" +
                $"{message}\r\n\r\n";

            if (ex != null)
            {
                outputText += $"{ex}\r\n\r\n";
            }

            outputText += "\r\n";

            this.Invoke(new Action(() =>
            {
                txtConsole.AppendText(outputText);
            }));
        }

        public async Task UpdateProgressBar(int value, int maxValue, bool visible = false)
        {
            this.Invoke(new Action(() =>
            {
                pbProgress.Visible = visible;
                pbProgress.Maximum = maxValue;
                pbProgress.Value = value;
            }));
        }

        private void btnLoadDekho_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await LoadDataSource();
                this.Invoke(new Action(() =>
                {
                    AttributeList.Enabled = true;
                }));
            });
        }

        private async void btnFilterDekho_Click(object sender, EventArgs e)
        {
            //string filterParam = AttributeList.SelectedItem.ToString();

            //Task.Run(async () =>
            //{
            //    await ReturnFiltered(filterParam);
            //});

            int filterColumn = -1;
            string filterText = string.Empty;
            string filterParam = string.Empty;

            this.Invoke(new Action(() =>
            {
                filterColumn = AttributeList.SelectedIndex;
                filterText = cmbFilter.Text;
            }));

            if (filterColumn == -1)
            {
                await UpdateConsole("Filter By Parameter not selected!. Exitting...");
                return;
            }
            else
            {
                filterParam = AttributeList.SelectedItem.ToString();
            }

            PropertyInfo[] propertyInfos = typeof(DekhoModel).GetProperties();

            var theProperty = propertyInfos
                .FirstOrDefault(x => x.Name == filterParam);

            var filteredEnumerable = listDekhoCars
                .Where(x => theProperty.GetValue(x).ToString() == filterText);

            var filtered = new List<DekhoModel>();

            switch (sortType)
            {
                case 0:
                    filtered = filteredEnumerable
                        .ToList();
                    break;

                case 1:
                    filtered = filteredEnumerable
                        .OrderBy(x => x.Year)
                        .ToList();
                    break;

                case 2:
                    filtered = filteredEnumerable
                        .OrderByDescending(x => x.Year)
                        .ToList();
                    break;
            }

            string serializedFiltered = JsonConvert.SerializeObject(filtered, Formatting.Indented);
            await UpdateConsole($"Filtered Output:\r\n{serializedFiltered}");
        }
        private void AttributeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterParam = AttributeList.SelectedItem.ToString();

            PropertyInfo[] propertyInfos = typeof(DekhoModel).GetProperties();

            var theProperty = propertyInfos
                .FirstOrDefault(x => x.Name == filterParam);


            var filtered = listDekhoCars
                .Select(x => theProperty.GetValue(x))
                .Distinct()
                .ToList();

            cmbFilter.Text = "";

            cmbFilter.Items.Clear();
            this.Invoke(new Action(() =>
            {
                btnFilterDekho.Enabled = false;
            }));

            cmbFilter.Items.AddRange(filtered.ToArray());

            if (filtered.Count > 0)
            {
                this.Invoke(new Action(() =>
                {
                    btnFilterDekho.Enabled = true;
                }));
            }
        }

        private void frmDekho_Load(object sender, EventArgs e)
        {
            rbAsc.CheckedChanged += RadioButtons_CheckedChanged;
            rbDesc.CheckedChanged += RadioButtons_CheckedChanged;
            rbNone.CheckedChanged += RadioButtons_CheckedChanged;
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "rbAsc":
                        sortType = 1;
                        break;

                    case "rbDesc":
                        sortType = 2;
                        break;

                    case "rbNone":
                        sortType = 0;
                        break;
                }
            }
        }

        private void txtConsole_DoubleClick(object sender, EventArgs e)
        {
            txtConsole.Clear();
        }
    }
}
