﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    internal class SecurityPersonel : IPersonel
    {
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
   
        public void ProtectTheBuilding()
        {
            Console.WriteLine("Security Personel : Protect the building...");
        }
    }
}
