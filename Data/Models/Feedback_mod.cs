using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class Feedback_mod
    {
        private int num_total;
        private int num_currect;
        private short grasp_rate;

        public int Num_total
        {
            get
            {
                return num_total;
            }

            set
            {
                num_total = value;
            }
        }

        public int Num_currect
        {
            get
            {
                return num_currect;
            }

            set
            {
                num_currect = value;
            }
        }

        public short Grasp_rate
        {
            get
            {
                return grasp_rate;
            }

            set
            {
                grasp_rate = value;
            }
        }
    }
}
