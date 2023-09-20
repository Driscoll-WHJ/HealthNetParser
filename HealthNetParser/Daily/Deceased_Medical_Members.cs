using HealthNetParser.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static HealthNetParser.Model.HSPReadyNewMember;
using static HealthNetParser.Model.MedimartClass;

namespace HealthNetParser.Daily
{
	public class Deceased_Medical_Members
	{
		public void BuildDeceasedMedicalMembersFile(List<HealthNetFromCSV> data)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");

			}

			string ConnectionStringMedimartFilePath = @"C:\Users\whossaini\source\repos\HealthNetParser\HealthNetParser\Data\EligibilityTable.csv";


			string NewMemberFileName = "Hspready_Newmembers_" + DateTime.Now.ToString("MM_dd_yyyy");
			string OutputHspready_NewmembersFileName = @"\\irvftpauto\FTP_Share\Access_DBs\Dbs\EDI_Documents\HealthNet\daily_20230830\output_accdb\test\" + NewMemberFileName;

			var HealthNetOutPutNewMember = new List<HealthNetFromCSV>();

			List<MedimartModel> MedimartRecords = new List<MedimartModel>();

			using (StreamReader reader = new StreamReader(ConnectionStringMedimartFilePath))
			{
				string header = reader.ReadLine(); // Read and skip the header row

				string line;
				while ((line = reader.ReadLine()) != null)
				{
					string[] columns = line.Split(',');

					if (columns.Length != 0)
					{
						MedimartModel MedimartRecord = new MedimartModel();

						// Map properties using reflection
						var properties = typeof(MedimartModel).GetProperties();
						for (int i = 0; i < columns.Length && i < properties.Length; i++)
						{
							properties[i].SetValue(MedimartRecord, columns[i]);
						}

						MedimartRecords.Add(MedimartRecord);
					}
				}
			}

			foreach (var item in MedimartRecords)
			{
				foreach (var Hsp in data)
				{
					if (item.SubscriberNumber == Hsp.SubscriberNumber)
					{
						HealthNetOutPutNewMember.Add(Hsp);
					}
				}

			}

			using (StreamWriter writer = new StreamWriter(OutputHspready_NewmembersFileName))
			{
				// Write the header row
				PropertyInfo[] properties = typeof(HSPReadyModel).GetProperties();
				string header = string.Join(",", properties.Select(p => p.Name));
				writer.WriteLine(header);


				// Write data rows
				foreach (var record in HealthNetOutPutNewMember)
				{
					var HSPReady = new HSPReadyModel();
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
					if (record.MasterPolicyNumber.Contains("HN-405-"))
					{
						FileType = "405";
					}
					if (record.MasterPolicyNumber.Contains("HN-427-"))
					{
						FileType = "427";
					}

					var CalculatedGroup = CSVHelper.GroupNumber(Dob, FileType, aca);
					HSPReady.GroupNumber = CalculatedGroup;
					HSPReady.NationalIndividualID = record.SubscriberNumber;
					HSPReady.SubscriberNumber = record.SubscriberNumber + "-01";
					HSPReady.SubscriberPolicyNumber = record.SubscriberNumber;
					HSPReady.SubscriberSSN = record.SocialSecurityNumber;
					HSPReady.MemberNumber = record.SubscriberNumber + "-01";
					HSPReady.MemberPolicyNumber = record.MemberPolicyNumber;
					HSPReady.SocialSecurityNumber = record.SocialSecurityNumber;
					HSPReady.TierName = "Employee Only";
					HSPReady.TierCode = "";
					HSPReady.LastName = record.LastName;
					HSPReady.FirstName = record.FirstName;
					HSPReady.MiddleName = record.MiddleName;
					HSPReady.Address1 = record.Address1;
					HSPReady.Address2 = record.Address2;
					HSPReady.City = record.City;
					HSPReady.State = record.State;
					HSPReady.Zip = record.Zip;
					HSPReady.County = record.County;
					HSPReady.CountryCode = record.CountryCode;
					HSPReady.Latitude = record.LATITUDE;
					HSPReady.Longitude = record.LONGITUDE;
					HSPReady.LocationCode = record.LocationCode;
					HSPReady.HomePhone = record.HomePhone;
					HSPReady.WorkPhone = record.WorkPhone;
					HSPReady.CellPhone = record.CellPhone;
					HSPReady.Gender = record.Gender;
					HSPReady.DateOfBirth = record.DateOfBirth;
					HSPReady.DateOfDeath = record.DateOfDeath;
					HSPReady.RelationshipCode = record.RelationshipCode;
					HSPReady.ProviderNumber = record.ProviderNumber;
					HSPReady.ProviderNumberQualifier = "";
					HSPReady.PCPPrecedence = "";
					HSPReady.ManuallyAssigned = "";
					HSPReady.OverrideEffectiveDate = "";
					HSPReady.OverrideTerminationDate = "";
					HSPReady.OverrideRetroEnrollmentEnforcement = "";
					HSPReady.OverrideTierRestrictions = "";
					HSPReady.TierUpdate = "";
					HSPReady.TierUpdateAsOfDate = "";
					HSPReady.EffectiveDate = record.EffectiveDate;
					HSPReady.ExpirationDate = record.ExpirationDate;
					HSPReady.PrimaryInsurance = "P";
					HSPReady.NamePrefix = record.NamePrefix;
					HSPReady.NameSuffix = record.NameSuffix;
					HSPReady.NameFormat = record.NameFormat;
					HSPReady.Email = record.Email;
					HSPReady.MaritalStatus = record.MaritalStatus;
					HSPReady.EmployerName = record.EmployerName;
					HSPReady.DependentViewWebOption = "";
					HSPReady.TerminationDate = record.TerminationDate;
					HSPReady.TerminationReason = "";
					HSPReady.MaintenanceReasonCode = record.MaintenanceReasonCode;
					HSPReady.MaintenanceTypeCode = record.MaintenanceTypeCode;
					HSPReady.ProviderOrganization = record.ProviderOrganization;
					HSPReady.PrimarySecondaryIndicator = record.PrimarySecondaryIndicator;
					HSPReady.ProviderNetworkName = record.ProviderNetworkName;
					HSPReady.NetworkEffectiveDate = record.NetworkEffectiveDate;
					HSPReady.NetworkExpirationDate = record.NetworkExpirationDate;
					HSPReady.ActiveMemberSince = record.ActiveMemberSince;
					HSPReady.LastNameMatch = record.LastNameMatch;
					HSPReady.Ethnicity = record.Ethnicity;
					HSPReady.OfficeAddress1 = record.OfficeAddress1;
					HSPReady.OfficeZip = record.OfficeZip;
					HSPReady.OfficeNumber = record.OfficeNumber;
					HSPReady.RiskGroupNumber = "";
					HSPReady.HospitalNumber = "";
					HSPReady.PrimaryLanguage = record.PrimaryLanguage;
					HSPReady.COBPrecedence = record.COBPrecedence;
					HSPReady.COBPayerName = record.COBPayerName;
					HSPReady.COBPayerType = "";
					HSPReady.COBPayerNumber = record.COBPayerNumber;
					HSPReady.COBPayerNumberQualifier = record.COBPayerNumberQualifier;
					HSPReady.COBCoverage = "";
					HSPReady.COBEffectiveDate = record.COBEffectiveDate;
					HSPReady.COBExpirationDate = record.COBExpirationDate;
					HSPReady.UseMemberAddress = "";
					HSPReady.UseAnyTier = record.UseAnyTier;
					HSPReady.SaveAltAddress = record.SaveAltAddress;
					HSPReady.AlternateAddressType = "";
					HSPReady.TermExistBenefitsBeforeAddNew = record.TermExistBenefitsBeforeAddNew;
					HSPReady.AutoAssignPCP = record.AutoAssignPCP;
					HSPReady.AutoAssignProviderFromOffice = "";
					HSPReady.UpdateIdentifyingElements = record.UpdateIdentifyingElements;
					HSPReady.UpdatePolicyNumber = record.UpdatePolicyNumber;
					HSPReady.UpdateSSN = record.UpdateSSN;
					HSPReady.UpdateName = record.UpdateName;
					HSPReady.UpdateDateOfBirth = record.UpdateDateOfBirth;
					HSPReady.UpdateActiveMemberSince = "";
					HSPReady.UpdateAdditionalInformation = record.UpdateAdditionalInformation;
					HSPReady.UpdateNationalIndividualID = "";
					HSPReady.UpdateAdditionalNameDetails = record.UpdateAdditionalNameDetails;
					HSPReady.UpdateStreetAddressInfo = record.UpdateStreetAddressInfo;
					HSPReady.UpdateMainAddressInfo = record.UpdateMainAddressInfo;
					HSPReady.UpdateLocationCode = record.UpdateLocationCode;
					HSPReady.UpdateContactInfo = record.UpdateContactInfo;
					HSPReady.UpdateGender = record.UpdateGender;
					HSPReady.UpdateDateOfDeath = record.UpdateDateOfDeath;
					HSPReady.UpdateEthnicity = record.UpdateEthnicity;
					HSPReady.UpdateMaritalStatus = record.UpdateMaritalStatus;
					HSPReady.UpdateHICN = "";
					HSPReady.UpdateMemberEOBFulfillment = "";
					HSPReady.UpdateMemberNumberFlag = record.UpdateMemberNumberFlag;
					HSPReady.OverridePCPPanel = record.OverridePCPPanel;
					HSPReady.OldMemberNumber = record.OldMemberNumber;
					HSPReady.OldDateOfBirth = record.OldDateOfBirth;
					HSPReady.OldLastName = record.OldLastName;
					HSPReady.OldFirstName = record.OldFirstName;
					HSPReady.OldSSN = record.OldSSN;
					HSPReady.OldAddress1 = record.OldAddress1;
					HSPReady.OldCity = record.OldCity;
					HSPReady.OldState = record.OldState;
					HSPReady.OldZip = record.OldZip;
					HSPReady.OverrideMismatch = record.OverrideMismatch;
					HSPReady.OverrideDupMemberNumber = "";
					HSPReady.AutoGenerateCityAndState = record.AutoGenerateCityAndState;
					HSPReady.CustomAttributes = record.CustomAttributes;
					HSPReady.MemberCoverageAttributes = record.MemberCoverageAttributes;
					HSPReady.ResponsiblePartyLastName = record.ResponsiblePartyLastName;
					HSPReady.ResponsiblePartyFirstName = record.ResponsiblePartyFirstName;
					HSPReady.ResponsiblePartySuffix = record.ResponsiblePartySuffix;
					HSPReady.ResponsiblePartyMiddleName = record.ResponsiblePartyMiddleName;
					HSPReady.ResponsiblePartyType = record.ResponsiblePartyType;
					HSPReady.ResponsiblePartyNII = record.ResponsiblePartyNII;
					HSPReady.ResponsiblePartySSN = record.ResponsiblePartySSN;
					HSPReady.ResponsiblePartyNumber = record.ResponsiblePartyNumber;
					HSPReady.ResponsiblePartyDOB = record.ResponsiblePartyDOB;
					HSPReady.ResponsiblePartyRelationshipCode = record.ResponsiblePartyRelationshipCode;
					HSPReady.ResponsiblePartyGender = record.ResponsiblePartyGender;
					HSPReady.ResponsiblePartyGroupNumber = record.ResponsiblePartyGroupNumber;
					HSPReady.ResponsiblePartyAddress = record.ResponsiblePartyAddress;
					HSPReady.ResponsiblePartyAddress2 = record.ResponsiblePartyAddress2;
					HSPReady.ResponsiblePartyCity = record.ResponsiblePartyCity;
					HSPReady.ResponsiblePartyState = record.ResponsiblePartyState;
					HSPReady.ResponsiblePartyZip = record.ResponsiblePartyZip;
					HSPReady.ResponsiblePartyLocationCode = record.ResponsiblePartyLocationCode;
					HSPReady.ResponsiblePartyHomePhone = record.ResponsiblePartyHomePhone;
					HSPReady.ResponsiblePartyWorkPhone = record.ResponsiblePartyWorkPhone;
					HSPReady.ResponsiblePartyCellPhone = record.ResponsiblePartyCellPhone;
					HSPReady.ResponsiblePartyEmail = record.ResponsiblePartyEmail;
					HSPReady.ResponsiblePartyAlternateAddressType = "";
					HSPReady.ResponsiblePartyMailingAddress = record.ResponsiblePartyMailingAddress;
					HSPReady.ResponsiblePartyMailingAddress2 = record.ResponsiblePartyMailingAddress2;
					HSPReady.ResponsiblePartyMailingCity = record.ResponsiblePartyMailingCity;
					HSPReady.ResponsiblePartyMailingState = record.ResponsiblePartyMailingState;
					HSPReady.ResponsiblePartyMailingZip = record.ResponsiblePartyMailingZip;
					HSPReady.ResponsiblePartyCustomAttributes = record.ResponsiblePartyCustomAttributes;
					HSPReady.ResponsibleEffectiveDate = record.ResponsibleEffectiveDate;
					HSPReady.ResponsibleExpirationDate = record.ResponsibleExpirationDate;
					HSPReady.SeparateOutOfNetworkIDCard = record.SeparateOutOfNetworkIDCard;
					HSPReady.OverrideMultipleResponsibleParties = record.OverrideMultipleResponsibleParties;
					HSPReady.HouseholdReferenceNumber = record.HouseholdReferenceNumber;
					HSPReady.CreateNewHousehold = record.CreateNewHousehold;
					HSPReady.InheritResponsibleParty = record.InheritResponsibleParty;
					HSPReady.AddNewMemberPCPMapSlice = "";
					HSPReady.Volume = "";
					HSPReady.HireDate = "";
					HSPReady.HICN = "";
					HSPReady.MedicareEntitlementReason = "";
					HSPReady.MemberToPayNumber = "";
					HSPReady.MemberToPayGroupNumber = "";
					HSPReady.DisallowNewMembers = "";
					HSPReady.MemberEOBFulfillment = "";
					HSPReady.Source834XMLID = "";
					HSPReady.AidCodesXML = "";
					HSPReady.LanguagesXML = record.LanguagesXML;
					HSPReady.PlanCoverageDescription = "";
					HSPReady.BenefitCode = "";
					HSPReady.StatusCode = "";
					HSPReady.SOCStatus = "";
					HSPReady.SOCAmount = "";
					HSPReady.SOCCertDate = "";
					HSPReady.MCDEffectiveDate = "";
					HSPReady.MCDExpirationDate = "";
					HSPReady.ExternalRowID = "";
					HSPReady.UpdateMemberToPay = "";
					HSPReady.ContactReasonShortcut = "";
					HSPReady.CreateCOBPayerFlag = "";
					HSPReady.MBI = "";
					HSPReady.UpdateMBI = "";

					string dataRow = string.Join(",", typeof(HSPReadyModel).GetProperties().Select(p => p.GetValue(HSPReady)));
					writer.WriteLine(dataRow);
					Console.WriteLine(dataRow);
				}
			}
		}

	}
}
