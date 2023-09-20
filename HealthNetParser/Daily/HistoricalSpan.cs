using CsvHelper;
using HealthNetParser.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HealthNetParser
{
	public class HistoricalSpan
	{

		public void BuildHistoricalSpanFile(List<HealthNetFromCSV> records)
		{
			//string inputFilePath = @"\\irvftpauto\FTP_Share\Access_DBs\Dbs\EDI_Documents\HealthNet\daily_20230830\csv\DHCS834-DA-20230829-HN-405-001.csv";  // Replace with your input CSV file path
			var fileName = "Historic_Spans_" + DateTime.Now.ToString("MM_dd_yyyy")+ ".csv";

			string outputFilePath = @"\\irvftpauto\FTP_Share\Access_DBs\Dbs\EDI_Documents\HealthNet\daily_20230830\output_accdb\test\"+ fileName; // Replace with your output CSV file path

			//List<HealthNetFromCSV> records = new List<HealthNetFromCSV>();

			//using (StreamReader reader = new StreamReader(inputFilePath))
			//{
			//	string header = reader.ReadLine(); // Read and skip the header row

			//	string line;
			//	while ((line = reader.ReadLine()) != null)
			//	{
			//		string[] columns = line.Split(',');

			//		if (columns.Length != 0)
			//		{
			//			HealthNetFromCSV record = new HealthNetFromCSV();

			//			// Map properties using reflection
			//			var properties = typeof(HealthNetFromCSV).GetProperties();
			//			for (int i = 0; i < columns.Length && i < properties.Length; i++)
			//			{
			//				properties[i].SetValue(record, columns[i]);
			//			}

			//			records.Add(record);
			//		}
			//	}
			//}

			using (StreamWriter writer = new StreamWriter(outputFilePath))
			{
				// Write the header row
				PropertyInfo[] properties = typeof(HealthNetOutPutModel).GetProperties();
				string header = string.Join(",", properties.Select(p => p.Name));
				writer.WriteLine(header);
				

				// Write data rows
				foreach (var record in records)
				{
					var HistoricalSpan = new HealthNetOutPutModel();
					//string dataRow = string.Join(",", typeof(HealthNetFromCSV).GetProperties().Select(p => p.GetValue(record)));
					//writer.WriteLine(dataRow);
					string input = record.CaseNumber_3H;
					string[] parts = input.Split(';');
					var aca = "";
					var MemberPolicyNumber = "";
					if (parts.Length >= 2)
					{
						aca = parts[1].Trim();
						MemberPolicyNumber = parts[2].Trim();
					}
				
					DateTime Dob = CSVHelper.CleanDateTimeString(record.DateOfBirth);
					var FileType = "";
					if(record.MasterPolicyNumber.Contains("HN-405-"))
					{
						FileType = "405";
					}
					if (record.MasterPolicyNumber.Contains("HN-427-"))
					{
						FileType = "427";
					}
					// Access the properties of the record (your model)
					HistoricalSpan.AlreadyinMeditrack = "0";
					HistoricalSpan.Eligiblecurrent = "1";
					var CalculatedGroup = CSVHelper.GroupNumber(Dob, FileType, aca);
					HistoricalSpan.GroupNumber = CalculatedGroup;
					HistoricalSpan.ReimbursementName = record.ReimbursementName;
					HistoricalSpan.NationalIndividualID = record.SubscriberNumber;
					HistoricalSpan.SubscriberNumber = record.SubscriberNumber + "-01";
					HistoricalSpan.SubscriberPolicyNumber = record.SubscriberPolicyNumber;
					HistoricalSpan.MemberNumber = record.SubscriberNumber + "-01";
					HistoricalSpan.MemberPolicyNumber = record.MemberPolicyNumber;
					HistoricalSpan.SocialSecurityNumber = record.SocialSecurityNumber;
					HistoricalSpan.TierName = "Employee Only";
					HistoricalSpan.LastName = record.LastName;
					HistoricalSpan.FirstName = record.FirstName;
					HistoricalSpan.MiddleName = record.MiddleName;
					HistoricalSpan.Address1 = record.Address1;
					HistoricalSpan.Address2 = record.Address2;
					HistoricalSpan.City = record.City;
					HistoricalSpan.State = record.State;
					HistoricalSpan.Zip = record.Zip;
					HistoricalSpan.HomePhone = record.HomePhone;
					HistoricalSpan.WorkPhone = record.WorkPhone;
					if (record.MemberLanguageXML.Contains("Language LanguageCode"))
					{
						string LanguageCode = CSVHelper.ParseLanguageXml(record.MemberLanguageXML);
						if (LanguageCode != null)
						{
							HistoricalSpan.PrimaryLanguage = LanguageCode;
						}

					}
					HistoricalSpan.Gender = record.Gender;
					HistoricalSpan.DateOfBirth = record.DateOfBirth;
					HistoricalSpan.RelationshipCode = record.RelationshipCode;
					HistoricalSpan.OfficeNumber = record.OfficeNumber;
					HistoricalSpan.ProviderNumber = record.ProviderNumber;
					HistoricalSpan.EffectiveDate = record.EffectiveDate;
					HistoricalSpan.ExpirationDate = record.ExpirationDate;
					HistoricalSpan.PrimaryInsurance = record.PrimaryInsurance;
					HistoricalSpan.NamePrefix = record.NamePrefix;
					HistoricalSpan.NameSuffix = record.NameSuffix;
					HistoricalSpan.NameFormat = record.NameFormat;
					HistoricalSpan.Email = record.Email;
					HistoricalSpan.DateOfDeath = record.DateOfDeath;
					HistoricalSpan.MaritalStatus = record.MaritalStatus;
					HistoricalSpan.EmployerName = record.EmployerFirstName;
					HistoricalSpan.ReinstatementDate = record.ReinstatementDate;
					HistoricalSpan.TerminationDate = record.TerminationDate;
					HistoricalSpan.MaintenanceReasonCode = record.MaintenanceReasonCode;
					HistoricalSpan.MaintenanceTypeCode = record.MaintenanceTypeCode;
					HistoricalSpan.ProviderOrganization = record.ProviderOrganization;
					HistoricalSpan.PrimarySecondaryIndicator = record.PrimarySecondaryIndicator;
					HistoricalSpan.ProviderNetworkName = record.ProviderNetworkName;
					HistoricalSpan.NetworkEffectiveDate = record.NetworkEffectiveDate;
					HistoricalSpan.UpdateIdentifyingElements = record.UpdateIdentifyingElements;
					HistoricalSpan.UpdateAdditionalInformation = record.UpdateAdditionalInformation;
					HistoricalSpan.AutoassignPCP = record.AutoAssignPCP;
					HistoricalSpan.OverrideMismatch = record.OverrideMismatch;
					HistoricalSpan.OverrideDupMemberNumber = record.OverrideDupmemberNumber;
					HistoricalSpan.OfficeAddress1 = record.OfficeAddress1;
					HistoricalSpan.OfficeZip = record.OfficeZip;
					HistoricalSpan.UpdateMemberNumberFlag = record.UpdateMemberNumberFlag;
					if (record.DateOfBirth != null)
					{
							// Calculate the age
							HistoricalSpan.Age = CSVHelper.CalculateAge(Dob);


					}
						else
						{
							HistoricalSpan.Age = "";
						}
					

					HistoricalSpan.Ethnicity = record.Ethnicity;
					HistoricalSpan.HNOfficeNumber = record.OfficeNumber;
					HistoricalSpan.check = "0";
					HistoricalSpan.UpdateEthnicity = record.UpdateEthnicity;
					HistoricalSpan.New = "0";
					HistoricalSpan.Maximus = "0";
					HistoricalSpan.MatchLiveData = "0";
					HistoricalSpan.MatchWesternDental = "0";
					HistoricalSpan.HSPOfficeNoReport = null;
					HistoricalSpan.HSPProviderNoReport = null;
					HistoricalSpan.OldGroupNumber = null;
					HistoricalSpan.Mismatch = "0";
					HistoricalSpan.Change_Values = null;
					HistoricalSpan.ACA = aca;
					HistoricalSpan.MemberPolicyNumber = MemberPolicyNumber;
					HistoricalSpan.GMC_Threshold = "0";
					HistoricalSpan.PHP_Threshold = "0";
					HistoricalSpan.LanguagesXML = record.MemberLanguageXML;
					HistoricalSpan.ClientReportingCategoryNumber_17 = null;
					HistoricalSpan.MemberCoverageAttributes = null;

					string dataRow = string.Join(",", typeof(HealthNetOutPutModel).GetProperties().Select(p => p.GetValue(HistoricalSpan)));
					writer.WriteLine(dataRow);
					Console.WriteLine(dataRow);
				}
			}

			Console.WriteLine("CSV file processing complete.");

		}

		//public DateTime CleanDateTimeString(string dateString)
		//{
			
		//	string cleanedDateString = dateString.Replace("\"", "").Trim();

		//	DateTime.TryParse(cleanedDateString, out DateTime result);
			
		//	return result;

		//}
		//public string ParseLanguageXml(string xml)
		//{

		//	string languageCode = "";
		//	try
		//	{
		//		// Load the XML string into an XmlDocument
		//		XmlDocument doc = new XmlDocument();
		//		doc.LoadXml(xml);

		//		// Find the Language element
		//		XmlNode languageNode = doc.SelectSingleNode("/Languages/Language");

		//		if (languageNode != null)
		//		{
		//			// Get the value of the LanguageCode attribute
		//			languageCode = languageNode.Attributes["LanguageCode"].Value;
		//			return languageCode;
		//		}
		//		else
		//		{
		//			Console.WriteLine("Language element not found in XML.");
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		Console.WriteLine("Error: " + ex.Message);
		//	}
		//	return languageCode;
		//}

		//public static string CalculateAge(DateTime dateOfBirth)
		//{
		//	DateTime currentDate = DateTime.Now;
		//	int age = currentDate.Year - dateOfBirth.Year;

		//	// Check if the birthdate has occurred this year
		//	if (currentDate.Month < dateOfBirth.Month || (currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day))
		//	{
		//		age--;
		//	}

		//	return age.ToString();
		//}

		//public string AcaCheck(string aca)
		//{
		//	var result = "";
		//	switch (aca)
		//	{
		//		case "7U":
		//		case "L1":
		//		case "M1":
		//			result = "Yes";
		//			break;
		//		default:
		//			result = "No";
		//			break;
		//	}
		//	return result;

		//}


		//public string GroupNumber(DateTime dateOfBirth, string fileName, string aca)
		//{
		//	string CalAge = CalculateAge(dateOfBirth);
		//	int age = Convert.ToInt32(CalAge);
		//	var CheckAca = AcaCheck(aca);
		//	var GroupNumber = "";
		//	if (fileName.Contains("427"))
		//	{
		//		if (CheckAca == "No")
		//		{
		//			switch (age)
		//			{
		//				case int n when n >= 0 && n <= 7:
		//					GroupNumber = "HNGMC07";
		//					break;
		//				case int n when n >= 8 && n <= 20:
		//					GroupNumber = "HNGMC820";
		//					break;
		//				case int n when n >= 21:
		//					GroupNumber = "HNGMC21";
		//					break;
		//			}
		//		}
		//		if (CheckAca == "Yes")
		//		{
		//			switch (age)
		//			{
		//				case int n when n >= 0 && n <= 7:
		//					GroupNumber = "HNGMC07ACA";
		//					break;
		//				case int n when n >= 8 && n <= 20:
		//					GroupNumber = "HNGMC820ACA";
		//					break;
		//				case int n when n >= 21:
		//					GroupNumber = "HNGMC21ACA";
		//					break;

		//			}
		//		}


		//	}
		//	if (fileName.Contains("405"))
		//	{
		//		if (CheckAca == "No")
		//		{
		//			switch (age)
		//			{
		//				case int n when n >= 0 && n <= 20:
		//					GroupNumber = "HNPHP1";
		//					break;
		//				case int n when n >= 21:
		//					GroupNumber = "HNLAPHP21";
		//					break;

		//			}
		//		}
		//		if (CheckAca == "Yes")
		//		{
		//			switch (age)
		//			{
		//				case int n when n >= 0 && n <= 20:
		//					GroupNumber = "HNLAPHPACA";
		//					break;
		//				case int n when n >= 21:
		//					GroupNumber = "HNLAPHP21ACA";
		//					break;

		//			}
		//		}



		//	}

		//	return GroupNumber;

		//}
	}
}
