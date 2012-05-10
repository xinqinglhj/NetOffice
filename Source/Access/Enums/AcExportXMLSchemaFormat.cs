using System;
using NetOffice;
namespace NetOffice.AccessApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Access 10, 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Access", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum AcExportXMLSchemaFormat
	{
		 /// <summary>
		 /// SupportByVersion Access 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Access", 10,11,12,14)]
		 acSchemaNone = 0,

		 /// <summary>
		 /// SupportByVersion Access 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Access", 10,11,12,14)]
		 acSchemaXSD = 1
	}
}