﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd_2_1
{
    class fei:father
    {
        public fei(int id, string pwd,double yu,string usename)
        {
            base.id = id;
            base.pwd = pwd;
            base.yu = yu;
            base.usrname = usename;
        }

        //虚方法取款
        public override double show(double mon)
        {
             yu = yu - mon - 2;
             return yu;

        }
    }
}
