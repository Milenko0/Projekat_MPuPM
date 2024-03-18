using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTN.Common;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{
    public class PerLengthSequenceImpedance : PerLengthImpedance
    {
        public PerLengthSequenceImpedance(long globalId)
           : base(globalId)
        {
        }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
				return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

		#region IAccess implementation

		public override bool HasProperty(ModelCode t)
		{
			return base.HasProperty(t);
		}

		public override void GetProperty(Property property)
		{
			base.GetProperty(property);
		}

		public override void SetProperty(Property property)
		{
		    base.SetProperty(property);
		}
        #endregion IAccess implementation
    }
}
