using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTN.Services.NetworkModelService.DataModel.Core;
using FTN.Common;

namespace FTN.Services.NetworkModelService.DataModel.Wires
{
    public class SeriesCompensator : ConductingEquipment
    {
        public SeriesCompensator(long globalId)
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

        public override void GetProperty(Property prop)
        {
            base.GetProperty(prop);
        }

        public override void SetProperty(Property property)
        {
            base.SetProperty(property);
        }
        #endregion IAccess implementation

    }
}
