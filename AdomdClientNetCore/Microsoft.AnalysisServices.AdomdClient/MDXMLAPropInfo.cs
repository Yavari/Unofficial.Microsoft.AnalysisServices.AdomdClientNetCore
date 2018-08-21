using System;
using System.Collections.Generic;

namespace Microsoft.AnalysisServices.AdomdClient
{
	internal class MDXMLAPropInfo
	{
		private Dictionary<string, string> hashedProperties;

		internal static MDXMLAProp[] props = new MDXMLAProp[]
		{
			new MDXMLAProp("UserName", "UserName"),
			new MDXMLAProp("LocaleIdentifier", "LocaleIdentifier"),
			new MDXMLAProp("Catalog", "Catalog"),
			new MDXMLAProp("StateSupport", "StateSupport"),
			new MDXMLAProp("Content", "Content"),
			new MDXMLAProp("DiscoverAmbiguity", "DiscoverAmbiguity"),
			new MDXMLAProp("Format", "Format"),
			new MDXMLAProp("AxisFormat", "AxisFormat"),
			new MDXMLAProp("BeginRange", "BeginRange"),
			new MDXMLAProp("EndRange", "EndRange"),
			new MDXMLAProp("MDXSupport", "MDXSupport"),
			new MDXMLAProp("MemoryLockingMode", "MemoryLockingMode"),
			new MDXMLAProp("ProviderName", "ProviderName"),
			new MDXMLAProp("ProviderVersion", "ProviderVersion"),
			new MDXMLAProp("DBMSVersion", "DBMSVersion"),
			new MDXMLAProp("ProviderType", "ProviderType"),
			new MDXMLAProp("ShowHiddenCubes", "ShowHiddenCubes"),
			new MDXMLAProp("SQLSupport", "SQLSupport"),
			new MDXMLAProp("TransactionDDL", "TransactionDDL"),
			new MDXMLAProp("MaximumRows", "MaximumRows"),
			new MDXMLAProp("VisualMode", "VisualMode"),
			new MDXMLAProp("EffectiveRoles", "EffectiveRoles"),
			new MDXMLAProp("ServerName", "ServerName"),
			new MDXMLAProp("CatalogLocation", "CatalogLocation"),
			new MDXMLAProp("DbpropCatalogTerm", "DbpropCatalogTerm"),
			new MDXMLAProp("DbpropCatalogUsage", "DbpropCatalogUsage"),
			new MDXMLAProp("DbpropColumnDefinition", "DbpropColumnDefinition"),
			new MDXMLAProp("DbpropConcatNullBehavior", "DbpropConcatNullBehavior"),
			new MDXMLAProp("DbpropDataSourceReadOnly", "DbpropDataSourceReadOnly"),
			new MDXMLAProp("DbpropGroupBy", "DbpropGroupBy"),
			new MDXMLAProp("DbpropHeterogeneousTables", "DbpropHeterogeneousTables"),
			new MDXMLAProp("DbpropIdentifierCase", "DbpropIdentifierCase"),
			new MDXMLAProp("DbpropMaxIndexSize", "DbpropMaxIndexSize"),
			new MDXMLAProp("DbpropMaxOpenChapters", "DbpropMaxOpenChapters"),
			new MDXMLAProp("DbpropMaxRowSize", "DbpropMaxRowSize"),
			new MDXMLAProp("DbpropMaxRowSizeIncludeBlob", "DbpropMaxRowSizeIncludeBlob"),
			new MDXMLAProp("DbpropMaxTablesInSelect", "DbpropMaxTablesInSelect"),
			new MDXMLAProp("DbpropMultiTableUpdate", "DbpropMultiTableUpdate"),
			new MDXMLAProp("DbpropNullCollation", "DbpropNullCollation"),
			new MDXMLAProp("DbpropOrderByColumnsInSelect", "DbpropOrderByColumnsInSelect"),
			new MDXMLAProp("DbpropOutputParameterAvailable", "DbpropOutputParameterAvailable"),
			new MDXMLAProp("DbpropPersistentIdType", "DbpropPersistentIdType"),
			new MDXMLAProp("DbpropPrepareAbortBehavior", "DbpropPrepareAbortBehavior"),
			new MDXMLAProp("DbpropPrepareCommitBehavior", "DbpropPrepareCommitBehavior"),
			new MDXMLAProp("DbpropProcedureTerm", "DbpropProcedureTerm"),
			new MDXMLAProp("DbpropQuotedIdentifierCase", "DbpropQuotedIdentifierCase"),
			new MDXMLAProp("DbpropSchemaUsage", "DbpropSchemaUsage"),
			new MDXMLAProp("DbpropSqlSupport", "DbpropSqlSupport"),
			new MDXMLAProp("DbpropSubqueries", "DbpropSubqueries"),
			new MDXMLAProp("DbpropSupportedTxnDdl", "DbpropSupportedTxnDdl"),
			new MDXMLAProp("DbpropSupportedTxnIsoLevels", "DbpropSupportedTxnIsoLevels"),
			new MDXMLAProp("DbpropSupportedTxnIsoRetain", "DbpropSupportedTxnIsoRetain"),
			new MDXMLAProp("DbpropTableTerm", "DbpropTableTerm"),
			new MDXMLAProp("MdpropAggregateCellUpdate", "MdpropAggregateCellUpdate"),
			new MDXMLAProp("MdpropAxes", "MdpropAxes"),
			new MDXMLAProp("MdpropFlatteningSupport", "MdpropFlatteningSupport"),
			new MDXMLAProp("MdpropMdxCaseSupport", "MdpropMdxCaseSupport"),
			new MDXMLAProp("MdpropMdxDescFlags", "MdpropMdxDescFlags"),
			new MDXMLAProp("MdpropMdxDrillFunctions", "MdpropMdxDrillFunctions"),
			new MDXMLAProp("MdpropMdxFormulas", "MdpropMdxFormulas"),
			new MDXMLAProp("MdpropMdxJoinCubes", "MdpropMdxJoinCubes"),
			new MDXMLAProp("MdpropMdxMemberFunctions", "MdpropMdxMemberFunctions"),
			new MDXMLAProp("MdpropMdxNonMeasureExpressions", "MdpropMdxNonMeasureExpressions"),
			new MDXMLAProp("MdpropMdxNumericFunctions", "MdpropMdxNumericFunctions"),
			new MDXMLAProp("MdpropMdxObjQualification", "MdpropMdxObjQualification"),
			new MDXMLAProp("MdpropMdxOuterReference", "MdpropMdxOuterReference"),
			new MDXMLAProp("MdpropMdxQueryByProperty", "MdpropMdxQueryByProperty"),
			new MDXMLAProp("MdpropMdxRangeRowset", "MdpropMdxRangeRowset"),
			new MDXMLAProp("MdpropMdxSetFunctions", "MdpropMdxSetFunctions"),
			new MDXMLAProp("MdpropMdxSlicer", "MdpropMdxSlicer"),
			new MDXMLAProp("MdpropMdxStringCompop", "MdpropMdxStringCompop"),
			new MDXMLAProp("MdpropNamedLevels", "MdpropNamedLevels"),
			new MDXMLAProp("DbpropMsmdMDXCompatibility", "DbpropMsmdMDXCompatibility"),
			new MDXMLAProp("DbpropMsmdSQLCompatibility", "DbpropMsmdSQLCompatibility"),
			new MDXMLAProp("DbpropMsmdMDXUniqueNameStyle", "DbpropMsmdMDXUniqueNameStyle"),
			new MDXMLAProp("DbpropMsmdCachePolicy", "DbpropMsmdCachePolicy"),
			new MDXMLAProp("DbpropMsmdCacheRatio", "DbpropMsmdCacheRatio"),
			new MDXMLAProp("DbpropMsmdCacheMode", "DbpropMsmdCacheMode"),
			new MDXMLAProp("DbpropMsmdCompareCaseSensitiveStringFlags", "DbpropMsmdCompareCaseSensitiveStringFlags"),
			new MDXMLAProp("DbpropMsmdCompareCaseNotSensitiveStringFlags", "DbpropMsmdCompareCaseNotSensitiveStringFlags"),
			new MDXMLAProp("DbpropInitMode", "DbpropInitMode"),
			new MDXMLAProp("SspropInitAppName", "SspropInitAppName"),
			new MDXMLAProp("SspropInitWsid", "SspropInitWsid"),
			new MDXMLAProp("SspropInitPacketsize", "SspropInitPacketsize"),
			new MDXMLAProp("ReadOnlySession", "ReadOnlySession"),
			new MDXMLAProp("SecuredCellValue", "SecuredCellValue"),
			new MDXMLAProp("NonEmptyThreshold", "NonEmptyThreshold"),
			new MDXMLAProp("SafetyOptions", "SafetyOptions"),
			new MDXMLAProp("DbpropMsmdCacheRatio2", "DbpropMsmdCacheRatio2"),
			new MDXMLAProp("DbpropMsmdUseFormulaCache", "DbpropMsmdUseFormulaCache"),
			new MDXMLAProp("DbpropMsmdDynamicDebugLimit", "DbpropMsmdDynamicDebugLimit"),
			new MDXMLAProp("DbpropMsmdDebugMode", "DbpropMsmdDebugMode"),
			new MDXMLAProp("Dialect", "Dialect"),
			new MDXMLAProp("ImpactAnalysis", "ImpactAnalysis"),
			new MDXMLAProp("ClientProcessID", "ClientProcessID"),
			new MDXMLAProp("ReturnCellProperties", "ReturnCellProperties"),
			new MDXMLAProp("CommitTimeout", "CommitTimeout"),
			new MDXMLAProp("ForceCommitTimeout", "ForceCommitTimeout"),
			new MDXMLAProp("ExecutionMode", "ExecutionMode"),
			new MDXMLAProp("RealTimeOlap", "RealTimeOlap"),
			new MDXMLAProp("MdxMissingMemberMode", "MdxMissingMemberMode"),
			new MDXMLAProp("MdpropMdxSubqueries", "MdpropMdxSubqueries"),
			new MDXMLAProp("DbpropMsmdErrorMessageMode", "DbpropMsmdErrorMessageMode"),
			new MDXMLAProp("DisablePrefetchFacts", "DisablePrefetchFacts"),
			new MDXMLAProp("UpdateIsolationLevel", "UpdateIsolationLevel"),
			new MDXMLAProp("MdpropMdxNamedSets", "MdpropMdxNamedSets"),
			new MDXMLAProp("DbpropMsmdSubqueries", "DbpropMsmdSubqueries"),
			new MDXMLAProp("DbpropMsmdAutoExists", "DbpropMsmdAutoExists"),
			new MDXMLAProp("MdpropMdxDdlExtensions", "MdpropMdxDdlExtensions"),
			new MDXMLAProp("DbpropMsmdOptimizeResponse", "DbpropMsmdOptimizeResponse"),
			new MDXMLAProp("DbpropMsmdCellErrorMode", "DbpropMsmdCellErrorMode"),
			new MDXMLAProp("ResponseEncoding", "ResponseEncoding"),
			new MDXMLAProp("DbpropMsmdActivityID", "DbpropMsmdActivityID"),
			new MDXMLAProp("DbpropMsmdRequestID", "DbpropMsmdRequestID"),
			new MDXMLAProp("DbpropMsmdCurrentActivityID", "DbpropMsmdCurrentActivityID"),
			new MDXMLAProp("DbpropMsmdRequestMemoryLimit", "DbpropMsmdRequestMemoryLimit"),
			new MDXMLAProp("AuthenticationScheme", "AuthenticationScheme"),
			new MDXMLAProp("ExtAuthInfo", "ExtAuthInfo"),
			new MDXMLAProp("UserMode", "UserMode"),
			new MDXMLAProp("DbpropMsmdOutputExecPlan", "DbpropMsmdOutputExecPlan"),
			new MDXMLAProp("ReturnAffectedObjects", "ReturnAffectedObjects"),
			new MDXMLAProp("Authenticated User", ""),
			new MDXMLAProp("Auto Synch Period", ""),
			new MDXMLAProp("ArtificialData", ""),
			new MDXMLAProp("Cache Authentication", ""),
			new MDXMLAProp("Cache Mode", "DbpropMsmdCacheMode"),
			new MDXMLAProp("Cache Policy", "DbpropMsmdCachePolicy"),
			new MDXMLAProp("Cache Ratio", "DbpropMsmdCacheRatio"),
			new MDXMLAProp("Client Cache Size", ""),
			new MDXMLAProp("CompareCaseNotSensitiveStringFlags", "DbpropMsmdCompareCaseNotSensitiveStringFlags"),
			new MDXMLAProp("CompareCaseSensitiveStringFlags", "DbpropMsmdCompareCaseSensitiveStringFlags"),
			new MDXMLAProp("Connect Timeout", ""),
			new MDXMLAProp("CreateCube", ""),
			new MDXMLAProp("Data Source", ""),
			new MDXMLAProp("DataSourceInfo", "DataSourceInfo"),
			new MDXMLAProp("Datasource Connection Type", ""),
			new MDXMLAProp("Default GUID Dialect", ""),
			new MDXMLAProp("Default Isolation Mode", ""),
			new MDXMLAProp("Default MDX Visual Mode", "VisualMode"),
			new MDXMLAProp("Distinct Measures By Key", ""),
			new MDXMLAProp("Do Not Apply Commands", ""),
			new MDXMLAProp("Encrypt Password", ""),
			new MDXMLAProp("Execution Location", ""),
			new MDXMLAProp("Extended Properties", ""),
			new MDXMLAProp("Impersonation Level", ""),
			new MDXMLAProp("Initial Catalog", ""),
			new MDXMLAProp("InsertInto", ""),
			new MDXMLAProp("Integrated Security", ""),
			new MDXMLAProp("Large Level Threshold", ""),
			new MDXMLAProp("Locale Identifier", "LocaleIdentifier"),
			new MDXMLAProp("Log File", ""),
			new MDXMLAProp("Mask Password", ""),
			new MDXMLAProp("Mode", ""),
			new MDXMLAProp("MDX Calculated Members Mode", ""),
			new MDXMLAProp("MDX Compatibility", "DbpropMsmdMDXCompatibility"),
			new MDXMLAProp("MDX Object Qualification", ""),
			new MDXMLAProp("MDX Unique Name Style", "DbpropMsmdMDXUniqueNameStyle"),
			new MDXMLAProp("Mining Execution Location", ""),
			new MDXMLAProp("Mining Location", ""),
			new MDXMLAProp("Mining Persistence Format", ""),
			new MDXMLAProp("Non Empty Threshold", "NonEmptyThreshold"),
			new MDXMLAProp("OLE DB for OLAP Version", ""),
			new MDXMLAProp("Persist Encrypted", ""),
			new MDXMLAProp("Persist Security Info", ""),
			new MDXMLAProp("Password", "Password"),
			new MDXMLAProp("Protection Level", ""),
			new MDXMLAProp("PWD", "Password"),
			new MDXMLAProp("Provider", ""),
			new MDXMLAProp("Read Only Session", "ReadOnlySession"),
			new MDXMLAProp("Roles", "Roles"),
			new MDXMLAProp("Safety Options", "SafetyOptions"),
			new MDXMLAProp("Secured Cell Value", "SecuredCellValue"),
			new MDXMLAProp("Show Hidden Cubes", "ShowHiddenCubes"),
			new MDXMLAProp("Source_DSN", ""),
			new MDXMLAProp("Source_DSN_Suffix", ""),
			new MDXMLAProp("SQL Compatibility", "DbpropMsmdSQLCompatibility"),
			new MDXMLAProp("SQLQueryMode", "SQLQueryMode"),
			new MDXMLAProp("SSPI", ""),
			new MDXMLAProp("UseExistingFile", ""),
			new MDXMLAProp("User ID", ""),
			new MDXMLAProp("UID", ""),
			new MDXMLAProp("Writeback Timeout", ""),
			new MDXMLAProp("Cube", "Cube"),
			new MDXMLAProp("Protocol Format", ""),
			new MDXMLAProp("Transport Compression", ""),
			new MDXMLAProp("Compression Level", ""),
			new MDXMLAProp("Character Encoding", ""),
			new MDXMLAProp("Encryption Password", ""),
			new MDXMLAProp("Real Time Olap", "RealTimeOlap"),
			new MDXMLAProp("ConnectTo", ""),
			new MDXMLAProp("EffectiveUserName", "EffectiveUserName"),
			new MDXMLAProp("Prompt", ""),
			new MDXMLAProp("Maximum Rows", "MaximumRows"),
			new MDXMLAProp("Restricted Client", ""),
			new MDXMLAProp("Cache Ratio2", "DbpropMsmdCacheRatio2"),
			new MDXMLAProp("Timeout", "Timeout"),
			new MDXMLAProp("Use Formula Cache", "DbpropMsmdUseFormulaCache"),
			new MDXMLAProp("Dynamic Debug Limit", "DbpropMsmdDynamicDebugLimit"),
			new MDXMLAProp("Debug Mode", "DbpropMsmdDebugMode"),
			new MDXMLAProp("MDX Missing Member Mode", "MdxMissingMemberMode"),
			new MDXMLAProp("SessionID", ""),
			new MDXMLAProp("CustomData", "CustomData"),
			new MDXMLAProp("Error Message Mode", "DbpropMsmdErrorMessageMode"),
			new MDXMLAProp("Disable Prefetch Facts", "DisablePrefetchFacts"),
			new MDXMLAProp("Update Isolation Level", "UpdateIsolationLevel"),
			new MDXMLAProp("Workstation ID", "SspropInitWsid"),
			new MDXMLAProp("Application Name", "SspropInitAppName"),
			new MDXMLAProp("ActivityID", "DbpropMsmdActivityID"),
			new MDXMLAProp("RequestID", "DbpropMsmdRequestID"),
			new MDXMLAProp("CurrentActivityID", "DbpropMsmdCurrentActivityID"),
			new MDXMLAProp("Packet Size", ""),
			new MDXMLAProp("Subqueries", "DbpropMsmdSubqueries"),
			new MDXMLAProp("AutoExists", "DbpropMsmdAutoExists"),
			new MDXMLAProp("Optimize Response", "DbpropMsmdOptimizeResponse"),
			new MDXMLAProp("Cell Error Mode", "DbpropMsmdCellErrorMode"),
			new MDXMLAProp("Output Execution Plan", "DbpropMsmdOutputExecPlan"),
			new MDXMLAProp("DataView", "DataView"),
			new MDXMLAProp("Current Catalog", "Catalog"),
			new MDXMLAProp("Visual Mode", "VisualMode"),
			new MDXMLAProp("DbpropMsmdFlattened2", "DbpropMsmdFlattened2"),
			new MDXMLAProp("DirectQueryMode", "DirectQueryMode"),
			new MDXMLAProp("Certificate", "Certificate"),
			new MDXMLAProp("Authentication Scheme", "AuthenticationScheme"),
			new MDXMLAProp("Ext Auth Info", "ExtAuthInfo"),
			new MDXMLAProp("Identity Provider", ""),
			new MDXMLAProp("RequestMemoryLimit", "DbpropMsmdRequestMemoryLimit"),
			new MDXMLAProp("External Tenant Id", ""),
			new MDXMLAProp("External User Id", ""),
			new MDXMLAProp("External Service Domain Name", ""),
			new MDXMLAProp("External Certificate Thumbprint", ""),
			new MDXMLAProp("DMTSConnectionDetails", ""),
			new MDXMLAProp("UseADALCache", "")
		};

		internal Dictionary<string, string> Properties
		{
			get
			{
				return this.hashedProperties;
			}
		}

		internal MDXMLAPropInfo()
		{
			this.hashedProperties = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			MDXMLAProp[] array = MDXMLAPropInfo.props;
			for (int i = 0; i < array.Length; i++)
			{
				MDXMLAProp mDXMLAProp = array[i];
				this.hashedProperties.Add(mDXMLAProp.strOleDbName, mDXMLAProp.strXmlAName);
			}
		}
	}
}