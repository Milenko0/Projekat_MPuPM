using System;
using System.Collections.Generic;
using System.Text;

namespace FTN.Common
{

	public enum DMSType : short
	{
		MASK_TYPE							= unchecked((short)0xFFFF),

		DCLINESEGMENT						= 0x0001,
		SERIESCOMPENSATOR					= 0x0002,
		PERLENGTHSEQUENCEIMPEDANCE			= 0x0003,
		CONNECTIVITYNODE					= 0x0004,
		ACLINESEGMENT						= 0x0005,
		TERMINAL							= 0x0006,
	}

	[Flags]
	public enum ModelCode : long
	{
		IDOBJ								= 0x1000000000000000,
		IDOBJ_GID							= 0x1000000000000104,
		IDOBJ_ALIASNAME						= 0x1000000000000207,
		IDOBJ_MRID							= 0x1000000000000307,
		IDOBJ_NAME							= 0x1000000000000407,

		CONNECTIVITYNODE					= 0x1100000000040000,
		CONNECTIVITYNODE_DESCRIPTION		= 0x1100000000040107,
		CONNECTIVITYNODE_TERMINALS			= 0x1100000000040219,

		TERMINAL							= 0x1200000000060000,
		TERMINAL_CONNECTIVITYNODE			= 0x1200000000060109,
		TERMINAL_CONDUCTINGEQUIPMENT		= 0x1200000000060209,

		POWERSYSTEMRESOURCE					= 0x1300000000000000,

		PERLENGTHIMPEDANCE					= 0x1400000000000000,
		PERLENGTHIMPEDANCE_ACLINESEGMENTS	= 0x1400000000000119,

		EQUIPMENT							= 0x1310000000000000,

		CONDUCTINGEQUIPMENT					= 0x1311000000000000,
		CONDUCTINGEQUIPMENT_TERMINALS		= 0x1311000000000119,

		CONDUCTOR							= 0x1311100000000000,

		SERIESCOMPENSATOR					= 0x1311200000020000,

		DCLINESEGMENT						= 0x1311110000010000,

		ACLINESEGMENT						= 0x1311120000050000,
		ACLINESEGMENT_PERLENGTHIMPEDANCE	= 0x1311120000050909,

		PERLENGTHSEQUENCEIMPEDANCE			= 0x1410000000030000,

	}

	[Flags]
	public enum ModelCodeMask : long
	{
		MASK_TYPE = 0x00000000ffff0000,
		MASK_ATTRIBUTE_INDEX = 0x000000000000ff00,
		MASK_ATTRIBUTE_TYPE = 0x00000000000000ff,

		MASK_INHERITANCE_ONLY = unchecked((long)0xffffffff00000000),
		MASK_FIRSTNBL = unchecked((long)0xf000000000000000),
		MASK_DELFROMNBL8 = unchecked((long)0xfffffff000000000),
	}
}


