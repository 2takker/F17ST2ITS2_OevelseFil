using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.IO;

namespace Data
{
    class DataLag
    {
        private List<Vaegt_DTO> patientVaegt;
        private List<BS_DTO> patientBS;
        private List<BT_DTO> patientBT;
        FileStream ft;
        StreamReader iSt;
        string iRecord;
        string[] iFields;
        string path;

        public DataLag()
        {

        }

        public List<Vaegt_DTO> getPatientVaegt(string cpr)
        {
            patientVaegt = new List<Vaegt_DTO>();
            DateTime dateResult = DateTime.Now;
            double vaegtResult = 0.0;
            double hoejdeResult = 0.0;

            try
            {
                path = "C:\\Users\\2takk\\Documents\\vsProjects\\F17\\OevelseFil\\OevelseFil\\Vaegt.txt";
                ft = new FileStream(path, FileMode.Open, FileAccess.Read);

                iSt = new StreamReader(ft);

                while (!iSt.EndOfStream)
                {
                    iRecord = iSt.ReadLine();
                    iFields = iRecord.Split(';');

                    if (iFields[0] == cpr)
                    {
                        vaegtResult = Convert.ToDouble(iFields[1]);
                        dateResult = Convert.ToDateTime(iFields[2]);
                        patientVaegt.Add(new Vaegt_DTO(vaegtResult, dateResult));
                    }
                }

                iSt.Close();

                ft = new FileStream("C:\\Users\\2takk\\Documents\\vsProjects\\F17\\OevelseFil\\OevelseFil\\Patient.txt",
                    FileMode.Open, FileAccess.Read);

                iSt = new StreamReader(ft);

                while (!iSt.EndOfStream)
                {
                    iRecord = iSt.ReadLine();
                    iFields = iRecord.Split(';');

                    if(iFields[0] == cpr)
                    {
                        hoejdeResult = Convert.ToDouble(iFields[2]);

                        foreach (var e in patientVaegt)
                        {
                            e.setHoejde(hoejdeResult);
                        }
                    }
                }

                iSt.Close();

                return patientVaegt;
            }
            catch (Exception ex)
            {
                iSt.Close();
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
                return null;
            }
        }


        public List<BS_DTO> getPatientBS(string cpr)
        {
            try
            {
                patientBS = new List<BS_DTO>();
                DateTime date = DateTime.Now;
                double resultBS = 0.0;

                path = "C:\\Users\\2takk\\Documents\\vsProjects\\F17\\OevelseFil\\OevelseFil\\BS.txt";

                ft = new FileStream(path, FileMode.Open, FileAccess.Read);

                iSt = new StreamReader(ft);

                while (!iSt.EndOfStream)
                {
                    iRecord = iSt.ReadLine();
                    iFields = iRecord.Split(';');

                    if (iFields[0] == cpr)
                    {
                        resultBS = Convert.ToDouble(iFields[1]);
                        date = Convert.ToDateTime(iFields[2]);

                        patientBS.Add(new BS_DTO(resultBS, date));
                    }
                }

                iSt.Close();

                return patientBS;
            }
            catch (Exception ex)
            {
                iSt.Close();
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
                return null;
            }
        }

        public List<BT_DTO> getPatientBT(string cpr)
        {
            patientBT = new List<BT_DTO>();
            DateTime date = DateTime.Now;
            int sBT = 0;
            int dBT = 0;

            try
            {
                path = "C:\\Users\\2takk\\Documents\\vsProjects\\F17\\OevelseFil\\OevelseFil\\BT.txt";

                ft = new FileStream(path, FileMode.Open, FileAccess.Read);

                iSt = new StreamReader(ft);

                while (!iSt.EndOfStream)
                {
                    iRecord = iSt.ReadLine();
                    iFields = iRecord.Split(';');

                    if (iFields[0] == cpr)
                    {
                        sBT = Convert.ToInt32(iFields[1]);
                        dBT = Convert.ToInt32(iFields[3]);
                        date = Convert.ToDateTime(iFields[2]);

                        patientBT.Add(new BT_DTO(sBT, dBT, date));
                    }
                }

                iSt.Close();

                return patientBT;
            }
            catch(Exception ex)
            {
                iSt.Close();
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
                return null;
            }

        }
    }
}
