using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public abstract class BaseValueObject
    {
        public override bool Equals(object? obj)
        {
            //TODO: Разобраться как сравнить (DeepCompare => DeepClone)
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
