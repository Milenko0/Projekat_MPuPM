using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTN.Common;
using FTN.Services.NetworkModelService.DataModel.Core;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{
    public class ACLineSegment : Conductor
    {
        private long perLengthImpedance = 0;

        public ACLineSegment(long globalId)
           : base(globalId)
        {
        }

        public long PerLengthImpedance
        {
            get { return perLengthImpedance; }
            set { perLengthImpedance = value; }
        }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                ACLineSegment x = (ACLineSegment)obj;
                return (x.perLengthImpedance == this.perLengthImpedance);
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
			switch (t)
			{
				case ModelCode.ACLINESEGMENT_PERLENGTHIMPEDANCE:

					return true;
				default:
					return base.HasProperty(t);
			}
		}

		public override void GetProperty(Property property)
		{
			switch (property.Id)
			{
				case ModelCode.ACLINESEGMENT_PERLENGTHIMPEDANCE:
					property.SetValue(perLengthImpedance);
					break;

				default:
					base.GetProperty(property);
					break;
			}
		}

		public override void SetProperty(Property property)
		{
			switch (property.Id)
			{
				case ModelCode.ACLINESEGMENT_PERLENGTHIMPEDANCE:
					perLengthImpedance = property.AsReference();
					break;

				default:
					base.SetProperty(property);
					break;
			}
		}

		#endregion IAccess implementation

		#region IReference implementation	

		public override void GetReferences(Dictionary<ModelCode, List<long>> references, TypeOfReference refType)
		{
			if (perLengthImpedance != 0 && (refType != TypeOfReference.Reference || refType != TypeOfReference.Both))
			{
				references[ModelCode.ACLINESEGMENT_PERLENGTHIMPEDANCE] = new List<long>();
				references[ModelCode.ACLINESEGMENT_PERLENGTHIMPEDANCE].Add(perLengthImpedance);
			}

			base.GetReferences(references, refType);
		}

		#endregion IReference implementation
	}
}
