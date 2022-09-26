using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entitylayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class logicdoktor
    {
        public static List<tbl_doktor> Doktorlistesi()
        {
            return daldoktor.Doktorlistesi();
        }
        public static int doktorekle(tbl_doktor p)
        {
            if (p.doktoradisoyadi!= "")
            {
                return daldoktor.Doktorekle(p);
            }
            else
            {
                return -1;
            }
        }

        public static bool Doktorsil(int per)
        {
            if (per >= 1)
            {
                return daldoktor.Doktorsil(per);
            }
            else
            {
                return false;
            }
        }
        public static bool Doktorguncelle(tbl_doktor p)
        {
            if (p.doktoradisoyadi != "")
            {
                return daldoktor.Doktorguncelle(p);
            }
            else
            {
                return false;
            }


        }

    }
}

