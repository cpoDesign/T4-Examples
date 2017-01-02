using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Example.Enum.Constants
{
	[SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Reviewed. Suppression is OK here.")]
	[SuppressMessage("StyleCop.CSharp.NamingRules", "SA1310:FieldNamesMustNotContainUnderscore", Justification = "Reviewed. Suppression is OK here.")]
	public class PropertyTypesNames
	{
				public const string House = "House";

				public const string Flat = "Flat";

				public const string Bungalow = "Bungalow";
	}

	[SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Reviewed. Suppression is OK here.")]
	[SuppressMessage("StyleCop.CSharp.NamingRules", "SA1310:FieldNamesMustNotContainUnderscore", Justification = "Reviewed. Suppression is OK here.")]
	public class ShortNameValues
	{
		[Description("1")]
		public const int HS = 1;

		[Description("2")]
		public const int FT = 2;

		[Description("3")]
		public const int BG = 3;
	}
}	
