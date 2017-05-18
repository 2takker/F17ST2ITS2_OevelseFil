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
    public partial class formBS : Form
    {
        logikLag lk;
        List<BS_DTO> BSliste = new List<BS_DTO>();



        public formBS(DateTime startDato, DateTime slutDato, string cpr)
        {
            InitializeComponent();
            lk = new logikLag();
            BSliste = lk.getPatientBS(cpr);

            foreach (var ele in BSliste)
            {
                if (ele.getDateTime() >= startDato && ele.getDateTime() <= slutDato)
                {
                    chartBS.Series["Blodsukker"].Points.AddXY(ele.getDateTime(), ele.getBloodSugar());
                }
            }
        }


    }
}
