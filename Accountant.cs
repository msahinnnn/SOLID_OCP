using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    internal class Accountant : IPersonel
    {
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    
        public void CalculateCost()
        {
            Console.WriteLine("Accountant : Calculate cost...");
        }
    }
}
