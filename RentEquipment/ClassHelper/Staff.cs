﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentEquipment.EF
{
    public partial class Staff
    {
        public string FIO { get => $"{LastName} {FirstName} {MiddleName}"; }
    }
}