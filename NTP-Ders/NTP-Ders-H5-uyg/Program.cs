﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_Ders_H5_uyg
{
    internal static class Program
    {

        [STAThread] 
        static void Main()
        {
           // ApplicationConfiguration.Initialize();
            Application.Run(new Form2());
        }
    }
}
