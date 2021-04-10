using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    [Serializable]
    public class Customer : IEquatable<Customer>
    {
        public string name;
        public string PhoneNum;

        public Customer() { }
        public Customer(string name, string PhoneNum)
        {
            this.name = name;
            this.PhoneNum = PhoneNum;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Customer);
        }

        public bool Equals(Customer other)
        {
            return other != null &&
                   name == other.name &&
                   PhoneNum == other.PhoneNum;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, PhoneNum);
        }

        public override string ToString()
        {
            return $"name:{name}  PhoneNum:{PhoneNum}";
        }


    }
}
