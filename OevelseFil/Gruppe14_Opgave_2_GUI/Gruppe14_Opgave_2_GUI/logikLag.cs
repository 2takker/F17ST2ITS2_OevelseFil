using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using DTO;

namespace Logik
{
    class logikLag
    {
        DataLag db = new DataLag();

        List<Vaegt_DTO> logikPatientVaegt = new List<Vaegt_DTO>();
        List<BS_DTO> logikPatientBS = new List<BS_DTO>();
        List<BT_DTO> logikPatientBT = new List<BT_DTO>();


        public List<Vaegt_DTO> udregnBMI(string cpr)
        {
            logikPatientVaegt = db.getPatientVaegt(cpr);
            double result = 0;

            foreach (var ele in logikPatientVaegt)
            {
                double hoejde = ele.getHoejde();
                double vaegt = ele.getVaegt();

                result = (vaegt / Math.Pow(hoejde, 2));

                ele.setBMI(result);
            }      
            
            return logikPatientVaegt;
        }

        public List<BS_DTO> getPatientBS(string cpr)
        {
            logikPatientBS = db.getPatientBS(cpr);

            return logikPatientBS;
        }

        public List<BT_DTO> getPatientBT(string cpr)
        {
            logikPatientBT = db.getPatientBT(cpr);

            return logikPatientBT;
        }


        public bool cprOK(String nr)
        {
            int[] weight = { 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };
            int sum = 0;

            if (nr == "1234567890") //Dette er vores test-CPR, som er knyttet til alt testdata på SQL-serveren.
                return true;

            if (nr.Length == 10 )
            {
                for (int i = 0; i < nr.Length; i++)
                {
                    char[] chars = nr.ToCharArray();
                    sum += (chars[i] - 0x30) * weight[i];
                }
                int res = sum % 11;
                if (res == 0)
                    return true;
            }
            return false;
        }
    }
}
