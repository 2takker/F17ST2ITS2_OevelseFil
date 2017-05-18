using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Logik;

namespace Gruppe15_Opgave_2_GUI
{
    public partial class formBT : Form
    {
        List<BT_DTO> BTListe = new List<BT_DTO>();
        logikLag lk = new logikLag();

        public formBT(DateTime startDato, DateTime slutDato, string cpr)
        {
            InitializeComponent();

            BTListe = lk.getPatientBT(cpr);

            foreach(var ele in BTListe)
            {
                if(ele.getDateTime() >= startDato && ele.getDateTime() <= slutDato)
                {
                    chartBT.Series["Systole"].Points.AddXY(ele.getDateTime(), ele.getSys());
                    chartBT.Series["Diastole"].Points.AddXY(ele.getDateTime(), ele.getDia());
                }
            }

        }
    }
}
