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
using DTO;

namespace Gruppe15_Opgave_2_GUI
{
    public partial class formBMI : Form
    {
        string cpr_;
        logikLag lk = new logikLag();
        private List<Vaegt_DTO> guiPatientVaegt = new List<Vaegt_DTO>();

        public formBMI(DateTime startDato, DateTime slutDato, string cpr)
        {
            InitializeComponent();
            cpr_ = cpr;

            guiPatientVaegt = lk.udregnBMI(cpr_);

            
            foreach (var ele in guiPatientVaegt)
            {
                if (ele.getDate() >= startDato && ele.getDate() <= slutDato)
                {
                    chartBMI.Series["Vaegt"].Points.AddXY(ele.getDate(), ele.getVaegt());
                    chartBMI.Series["BMI"].Points.AddXY(ele.getDate(), ele.getBMI());
                }
            }

        }
    }
}
