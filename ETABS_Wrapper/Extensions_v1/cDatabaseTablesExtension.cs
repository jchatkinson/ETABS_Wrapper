using System;
using ETABSv1;

namespace ETABSv1
{
    public static class cDatabaseTablesExtension
    {
		public static (int NumFatalErrors, int NumErrorMsgs, int NumWarnMsgs, int NumInfoMsgs, string ImportLog)
		    ApplyEditedTables(this cDatabaseTables obj, bool FillImportLog) {
			int NumFatalErrors, NumErrorMsgs, NumWarnMsgs, NumInfoMsgs;
			NumFatalErrors = NumErrorMsgs = NumWarnMsgs = NumInfoMsgs = default(int);
			string ImportLog;
			ImportLog = default(string);
		    var res = obj.ApplyEditedTables(FillImportLog, ref NumFatalErrors, ref NumErrorMsgs, ref NumWarnMsgs, ref NumInfoMsgs, ref ImportLog);
		    return (NumFatalErrors, NumErrorMsgs, NumWarnMsgs, NumInfoMsgs, ImportLog);
		}
		public static (int TableVersion, int NumberFields, string[] FieldKey, string[] FieldName, string[] Description, string[] UnitsString, bool[] IsImportable)
		    GetAllFieldsInTable(this cDatabaseTables obj, string TableKey) {
			int TableVersion, NumberFields;
			TableVersion = NumberFields = default(int);
			string[] FieldKey, FieldName, Description, UnitsString;
			FieldKey = FieldName = Description = UnitsString = default(string[]);
			bool[] IsImportable;
			IsImportable = default(bool[]);
		    var res = obj.GetAllFieldsInTable(TableKey, ref TableVersion, ref NumberFields, ref FieldKey, ref FieldName, ref Description, ref UnitsString, ref IsImportable);
		    return (TableVersion, NumberFields, FieldKey, FieldName, Description, UnitsString, IsImportable);
		}
		public static (int NumberTables, string[] TableKey, string[] TableName, int[] ImportType, bool[] IsEmpty)
		    GetAllTables(this cDatabaseTables obj) {
			int NumberTables;
			NumberTables = default(int);
			string[] TableKey, TableName;
			TableKey = TableName = default(string[]);
			int[] ImportType;
			ImportType = default(int[]);
			bool[] IsEmpty;
			IsEmpty = default(bool[]);
		    var res = obj.GetAllTables(ref NumberTables, ref TableKey, ref TableName, ref ImportType, ref IsEmpty);
		    return (NumberTables, TableKey, TableName, ImportType, IsEmpty);
		}
		public static (int NumberTables, string[] TableKey, string[] TableName, int[] ImportType)
		    GetAvailableTables(this cDatabaseTables obj) {
			int NumberTables;
			NumberTables = default(int);
			string[] TableKey, TableName;
			TableKey = TableName = default(string[]);
			int[] ImportType;
			ImportType = default(int[]);
		    var res = obj.GetAvailableTables(ref NumberTables, ref TableKey, ref TableName, ref ImportType);
		    return (NumberTables, TableKey, TableName, ImportType);
		}
		public static (int NumberSelectedLoadCases, string[] LoadCaseList)
		    GetLoadCasesSelectedForDisplay(this cDatabaseTables obj) {
			int NumberSelectedLoadCases;
			NumberSelectedLoadCases = default(int);
			string[] LoadCaseList;
			LoadCaseList = default(string[]);
		    var res = obj.GetLoadCasesSelectedForDisplay(ref NumberSelectedLoadCases, ref LoadCaseList);
		    return (NumberSelectedLoadCases, LoadCaseList);
		}
		public static (int NumberSelectedLoadCombinations, string[] LoadCombinationList)
		    GetLoadCombinationsSelectedForDisplay(this cDatabaseTables obj) {
			int NumberSelectedLoadCombinations;
			NumberSelectedLoadCombinations = default(int);
			string[] LoadCombinationList;
			LoadCombinationList = default(string[]);
		    var res = obj.GetLoadCombinationsSelectedForDisplay(ref NumberSelectedLoadCombinations, ref LoadCombinationList);
		    return (NumberSelectedLoadCombinations, LoadCombinationList);
		}
		public static (int NumberSelectedLoadPatterns, string[] LoadPatternList)
		    GetLoadPatternsSelectedForDisplay(this cDatabaseTables obj) {
			int NumberSelectedLoadPatterns;
			NumberSelectedLoadPatterns = default(int);
			string[] LoadPatternList;
			LoadPatternList = default(string[]);
		    var res = obj.GetLoadPatternsSelectedForDisplay(ref NumberSelectedLoadPatterns, ref LoadPatternList);
		    return (NumberSelectedLoadPatterns, LoadPatternList);
		}
		public static (string[] FieldKeyList, int TableVersion, string[] FieldsKeysIncluded, int NumberRecords, string[] TableData)
		    GetTableForDisplayArray(this cDatabaseTables obj, string TableKey, string GroupName) {
			string[] FieldKeyList, FieldsKeysIncluded, TableData;
			FieldKeyList = FieldsKeysIncluded = TableData = default(string[]);
			int TableVersion, NumberRecords;
			TableVersion = NumberRecords = default(int);
		    var res = obj.GetTableForDisplayArray(TableKey, ref FieldKeyList, GroupName, ref TableVersion, ref FieldsKeysIncluded, ref NumberRecords, ref TableData);
		    return (FieldKeyList, TableVersion, FieldsKeysIncluded, NumberRecords, TableData);
		}
		public static (string[] FieldKeyList, int TableVersion)
		    GetTableForDisplayCSVFile(this cDatabaseTables obj, string TableKey, string GroupName, string csvFilePath, string sepChar = ",") {
			string[] FieldKeyList;
			FieldKeyList = default(string[]);
			int TableVersion;
			TableVersion = default(int);
		    var res = obj.GetTableForDisplayCSVFile(TableKey, ref FieldKeyList, GroupName, ref TableVersion, csvFilePath, sepChar);
		    return (FieldKeyList, TableVersion);
		}
		public static (string[] FieldKeyList, int TableVersion, string csvString)
		    GetTableForDisplayCSVString(this cDatabaseTables obj, string TableKey, string GroupName, string sepChar = ",") {
			string[] FieldKeyList;
			FieldKeyList = default(string[]);
			int TableVersion;
			TableVersion = default(int);
			string csvString;
			csvString = default(string);
		    var res = obj.GetTableForDisplayCSVString(TableKey, ref FieldKeyList, GroupName, ref TableVersion, ref csvString, sepChar);
		    return (FieldKeyList, TableVersion, csvString);
		}
		public static (string[] FieldKeyList, int TableVersion, string XMLTableData)
		    GetTableForDisplayXMLString(this cDatabaseTables obj, string TableKey, string GroupName, bool IncludeSchema) {
			string[] FieldKeyList;
			FieldKeyList = default(string[]);
			int TableVersion;
			TableVersion = default(int);
			string XMLTableData;
			XMLTableData = default(string);
		    var res = obj.GetTableForDisplayXMLString(TableKey, ref FieldKeyList, GroupName, IncludeSchema, ref TableVersion, ref XMLTableData);
		    return (FieldKeyList, TableVersion, XMLTableData);
		}
		public static (int TableVersion, string[] FieldsKeysIncluded, int NumberRecords, string[] TableData)
		    GetTableForEditingArray(this cDatabaseTables obj, string TableKey, string GroupName) {
			int TableVersion, NumberRecords;
			TableVersion = NumberRecords = default(int);
			string[] FieldsKeysIncluded, TableData;
			FieldsKeysIncluded = TableData = default(string[]);
		    var res = obj.GetTableForEditingArray(TableKey, GroupName, ref TableVersion, ref FieldsKeysIncluded, ref NumberRecords, ref TableData);
		    return (TableVersion, FieldsKeysIncluded, NumberRecords, TableData);
		}
		public static int
		    GetTableForEditingCSVFile(this cDatabaseTables obj, string TableKey, string GroupName, string csvFilePath, string sepChar = ",") {
			int TableVersion;
			TableVersion = default(int);
		    var res = obj.GetTableForEditingCSVFile(TableKey, GroupName, ref TableVersion, csvFilePath, sepChar);
		    return TableVersion;
		}
		public static (int TableVersion, string csvString)
		    GetTableForEditingCSVString(this cDatabaseTables obj, string TableKey, string GroupName, string sepChar = ",") {
			int TableVersion;
			TableVersion = default(int);
			string csvString;
			csvString = default(string);
		    var res = obj.GetTableForEditingCSVString(TableKey, GroupName, ref TableVersion, ref csvString, sepChar);
		    return (TableVersion, csvString);
		}
		public static string[]
		    ShowTablesInExcel(this cDatabaseTables obj, int WindowHandle) {
			string[] TableKeyList;
			TableKeyList = default(string[]);
		    var res = obj.ShowTablesInExcel(ref TableKeyList, WindowHandle);
		    return TableKeyList;
		}
		public static (int NumberTableKeys, string[] TableKeyList, string[] NotesList)
		    GetObsoleteTableKeyList(this cDatabaseTables obj) {
			int NumberTableKeys;
			NumberTableKeys = default(int);
			string[] TableKeyList, NotesList;
			TableKeyList = NotesList = default(string[]);
		    var res = obj.GetObsoleteTableKeyList(ref NumberTableKeys, ref TableKeyList, ref NotesList);
		    return (NumberTableKeys, TableKeyList, NotesList);
		}
		public static (bool IsUserBaseReactionLocation, double UserBaseReactionX, double UserBaseReactionY, double UserBaseReactionZ, bool IsAllModes, int StartMode, int EndMode, bool IsAllBucklingModes, int StartBucklingMode, int EndBucklingMode, int MultistepStatic, int NonlinearStatic, int ModalHistory, int DirectHistory, int Combo)
		    GetOutputOptionsForDisplay(this cDatabaseTables obj) {
			bool IsUserBaseReactionLocation, IsAllModes, IsAllBucklingModes;
			IsUserBaseReactionLocation = IsAllModes = IsAllBucklingModes = default(bool);
			double UserBaseReactionX, UserBaseReactionY, UserBaseReactionZ;
			UserBaseReactionX = UserBaseReactionY = UserBaseReactionZ = default(double);
			int StartMode, EndMode, StartBucklingMode, EndBucklingMode, MultistepStatic, NonlinearStatic, ModalHistory, DirectHistory, Combo;
			StartMode = EndMode = StartBucklingMode = EndBucklingMode = MultistepStatic = NonlinearStatic = ModalHistory = DirectHistory = Combo = default(int);
		    var res = obj.GetOutputOptionsForDisplay(ref IsUserBaseReactionLocation, ref UserBaseReactionX, ref UserBaseReactionY, ref UserBaseReactionZ, ref IsAllModes, ref StartMode, ref EndMode, ref IsAllBucklingModes, ref StartBucklingMode, ref EndBucklingMode, ref MultistepStatic, ref NonlinearStatic, ref ModalHistory, ref DirectHistory, ref Combo);
		    return (IsUserBaseReactionLocation, UserBaseReactionX, UserBaseReactionY, UserBaseReactionZ, IsAllModes, StartMode, EndMode, IsAllBucklingModes, StartBucklingMode, EndBucklingMode, MultistepStatic, NonlinearStatic, ModalHistory, DirectHistory, Combo);
		}

    }
}