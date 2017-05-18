using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logik;

namespace Gruppe15_Opgave_2_GUI
{
    public partial class dataGUI : Form
    {
        formBS BSform1;
        formBT BTform1;
        formBMI BMIform1;
        logikLag lk;
        string cpr_;


        public dataGUI()
        {
            InitializeComponent();

            lk = new logikLag();
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            BSform1 = new formBS(dtpStart.Value, dtpSlut.Value, cpr_);
            BSform1.ShowDialog();
        }

        private void btnBT_Click(object sender, EventArgs e)
        {
            BTform1 = new formBT(dtpStart.Value, dtpSlut.Value, cpr_);
            BTform1.ShowDialog();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            BMIform1 = new formBMI(dtpStart.Value, dtpSlut.Value, cpr_);
            BMIform1.ShowDialog();
        }

        private void btnReadCPR_Click(object sender, EventArgs e)
        {
            if (lk.cprOK(txtBoxCPR.Text))
            {
                btnBMI.Enabled = true;
                btnBS.Enabled = true;
                btnBT.Enabled = true;
                btnDoctor.Enabled = true;

                cpr_ = txtBoxCPR.Text;
            }
            else
            {
                MessageBox.Show("Ugyldig CPR");
            }
        }
    }
}
