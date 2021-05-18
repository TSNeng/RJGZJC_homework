using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    [Serializable]
    public class Customer
    {
        public string name { get; set; }

        public Customer() { }
        public Customer(string name)
        {
            this.name = name;
        }



        public override string ToString()
        {
            return $"name:{name}";
        }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   name == customer.name;
        }

        public override int GetHashCode()
        {
            int hashCode = 1964454595;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            return hashCode;
        }

        
    }
}
