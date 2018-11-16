using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcManager
{
    public class TraditionalForm
    {
        public double sales;
        public double FixedCost;
        public double VarCost;
        public int Volume;
        public double PPU;



        public double getSales(){return sales;}
        public double getFCost(){return FixedCost;}
        public double getVCost(){return VarCost;}

        public double CalcCmargin()
        {
            double margin = sales - VarCost;
            return margin;
        }

        public double ClacNOI()
        {
            double NOI = CalcCmargin() - FixedCost;
            return NOI;
        }

        public double PPUSale()
        {
            return sales = PPU * Volume;
        }
    }

    public class ContributionForm
    {

    }
}
