using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Vaegt_DTO
    {
        private double vaegt_;
        private double hoejde_;
        private double bmi_;
        private DateTime date_;


        public Vaegt_DTO(double vaegt, DateTime date)
        {
            vaegt_ = vaegt;
            date_ = date;
        } 

        public double getVaegt()
        {
            return vaegt_;
        }

        public void setHoejde(double hoejde)
        {
            hoejde_ = hoejde;
        }

        public double getHoejde()
        {
            return hoejde_;
        }

        public void setBMI(double bmi)
        {
            bmi_ = bmi;
        }

        public double getBMI()
        {
            return bmi_;
        }

        public DateTime getDate()
        {
            return date_;
        }

    }
}
