using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class BT_DTO
    {
        private int sys_;
        private int dia_;
        private int puls_;
        private DateTime dt_;

        public BT_DTO(int sys, int dia)
        {
            sys_ = sys;
            dia_ = dia;
            dt_ = DateTime.Now;
        }

        public BT_DTO(int sys, int dia, int puls)
        {
            sys_ = sys;
            dia_ = dia;
            puls_ = puls;
            dt_ = DateTime.Now;
        }

        public BT_DTO(int sys, int dia, DateTime dt)
        {
            sys_ = sys;
            dia_ = dia;
            puls_ = 0;
            dt_ = dt;
        }

        public BT_DTO(int sys, int dia, int puls, DateTime dt)
        {
            sys_ = sys;
            dia_ = dia;
            puls_ = puls;
            dt_ = dt;
        }
        public void setSys(int sys)
        {
            sys_ = sys;
        }

        public int getSys()
        {
            return sys_;
        }

        public void setDia(int dia)
        {
            dia_ = dia;
        }
        public int getDia()
        {
            return dia_;
        }

        public int getPuls()
        {
            return puls_;
        }

        public void setPuls(int puls)
        {
            puls_ = puls;
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
            return dt_ + ": Blodtryk: " + sys_ + "/" + dia_ + "\tPuls: " + puls_;
        }

    }
}
