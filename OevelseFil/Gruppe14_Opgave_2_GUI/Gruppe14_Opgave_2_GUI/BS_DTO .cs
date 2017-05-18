using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class BS_DTO
    {
        private double bloodSugar_;
        private DateTime dt_;

        public BS_DTO(double bloodSugar)
        {
            bloodSugar_ = bloodSugar;
            dt_ = DateTime.Now;
        }

        public BS_DTO(double bloodSugar, DateTime dt)
        {
            bloodSugar_ = bloodSugar;
            dt_ = dt;
        }
        public void setBloodSugar(double bloodSugar)
        {
            bloodSugar_ = bloodSugar;
        }

        public double getBloodSugar()
        {
            return bloodSugar_;
        }

        public void setDateTime(DateTime dt)
        {
            dt_ = dt;
        }

        public DateTime getDateTime()
        {
            return dt_;
        }

        public override string ToString()
        {
            return dt_ + ": Blodsukker: " + bloodSugar_;
        }

    }
}
