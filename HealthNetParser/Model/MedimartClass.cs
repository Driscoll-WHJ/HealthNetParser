using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthNetParser.Model
{
	public class MedimartClass
	{
		public class MedimartModel
		{
			public string Eligiblecurrent { get; set; }
			public string GroupNumber { get; set; }
			public string ReimbursementName { get; set; }
			public string NationalIndividualID { get; set; }
			public string SubscriberNumber { get; set; }
			public string SubscriberPolicyNumber { get; set; }
			public string MemberNumber { get; set; }
			public string MemberPolicyNumber { get; set; }
			public string SocialSecurityNumber { get; set; }
			public string TierName { get; set; }
			public string LastName { get; set; }
			public string FirstName { get; set; }
			public string MiddleName { get; set; }
			public string Address1 { get; set; }
			public string Address2 { get; set; }
			public string City { get; set; }
			public string State { get; set; }
			public string Zip { get; set; }
			public long HomePhone { get; set; }
			public string WorkPhone { get; set; }
			public string PrimaryLanguage { get; set; }
			public string Gender { get; set; }
			public string DateOfBirth { get; set; }
			public string RelationshipCode { get; set; }
			public string EffectiveDate { get; set; }
			public string ExpirationDate { get; set; }
			public string PrimaryInsurance { get; set; }
			public string NamePrefix { get; set; }
			public string NameSuffix { get; set; }
			public string NameFormat { get; set; }
			public string Email { get; set; }
			public string DateOfDeath { get; set; }
			public string MaritalStatus { get; set; }
			public string EmployerName { get; set; }
			public string ReinstatementDate { get; set; }
			public string TerminationDate { get; set; }
			public string MaintenanceReasonCode { get; set; }
			public string MaintenanceTypeCode { get; set; }
			public string ProviderOrganization { get; set; }
			public string PrimarySecondaryIndicator { get; set; }
			public string ProviderNetworkName { get; set; }
			public string NetworkEffectiveDate { get; set; }
			public string UpdateIdentifyingElements { get; set; }
			public string UpdateAdditionalInformation { get; set; }
			public string AutoassignPCP { get; set; }
			public string OverrideMismatch { get; set; }
			public string OverrideDupMemberNumber { get; set; }
			public string OfficeAddress1 { get; set; }
			public string OfficeZip { get; set; }
			public string UpdateMemberNumberFlag { get; set; }
			public string Age { get; set; }
			public string Ethnicity { get; set; }
			public string check { get; set; }
			public string UpdateEthnicity { get; set; }
			public string MatchLiveData { get; set; }
			public string MatchWesternDental { get; set; }
			public string OfficeNumber { get; set; }
			public string ProviderNumber { get; set; }
			public string Maximus { get; set; }
			public string AutoGenerateCityAndState { get; set; }
		}

		public class MedimartModelClassMap : ClassMap<MedimartModel>
		{
			public MedimartModelClassMap()
			{
				Map(m => m.Eligiblecurrent).Name("Eligiblecurrent");
				Map(m => m.GroupNumber).Name("GroupNumber");
				Map(m => m.ReimbursementName).Name("ReimbursementName");
				Map(m => m.NationalIndividualID).Name("NationalIndividualID");
				Map(m => m.SubscriberNumber).Name("SubscriberNumber");
				Map(m => m.SubscriberPolicyNumber).Name("SubscriberPolicyNumber");
				Map(m => m.MemberNumber).Name("MemberNumber");
				Map(m => m.MemberPolicyNumber).Name("MemberPolicyNumber");
				Map(m => m.SocialSecurityNumber).Name("SocialSecurityNumber");
				Map(m => m.TierName).Name("TierName");
				Map(m => m.LastName).Name("LastName");
				Map(m => m.FirstName).Name("FirstName");
				Map(m => m.MiddleName).Name("MiddleName");
				Map(m => m.Address1).Name("Address1");
				Map(m => m.Address2).Name("Address2");
				Map(m => m.City).Name("City");
				Map(m => m.State).Name("State");
				Map(m => m.Zip).Name("Zip");
				Map(m => m.HomePhone).Name("HomePhone");
				Map(m => m.WorkPhone).Name("WorkPhone");
				Map(m => m.PrimaryLanguage).Name("PrimaryLanguage");
				Map(m => m.Gender).Name("Gender");
				Map(m => m.DateOfBirth).Name("DateOfBirth");
				Map(m => m.RelationshipCode).Name("RelationshipCode");
				Map(m => m.EffectiveDate).Name("EffectiveDate");
				Map(m => m.ExpirationDate).Name("ExpirationDate");
				Map(m => m.PrimaryInsurance).Name("PrimaryInsurance");
				Map(m => m.NamePrefix).Name("NamePrefix");
				Map(m => m.NameSuffix).Name("NameSuffix");
				Map(m => m.NameFormat).Name("NameFormat");
				Map(m => m.Email).Name("Email");
				Map(m => m.DateOfDeath).Name("DateOfDeath");
				Map(m => m.MaritalStatus).Name("MaritalStatus");
				Map(m => m.EmployerName).Name("EmployerName");
				Map(m => m.ReinstatementDate).Name("ReinstatementDate");
				Map(m => m.TerminationDate).Name("TerminationDate");
				Map(m => m.MaintenanceReasonCode).Name("MaintenanceReasonCode");
				Map(m => m.MaintenanceTypeCode).Name("MaintenanceTypeCode");
				Map(m => m.ProviderOrganization).Name("ProviderOrganization");
				Map(m => m.PrimarySecondaryIndicator).Name("PrimarySecondaryIndicator");
				Map(m => m.ProviderNetworkName).Name("ProviderNetworkName");
				Map(m => m.NetworkEffectiveDate).Name("NetworkEffectiveDate");
				Map(m => m.UpdateIdentifyingElements).Name("UpdateIdentifyingElements");
				Map(m => m.UpdateAdditionalInformation).Name("UpdateAdditionalInformation");
				Map(m => m.AutoassignPCP).Name("AutoassignPCP");
				Map(m => m.OverrideMismatch).Name("OverrideMismatch");
				Map(m => m.OverrideDupMemberNumber).Name("OverrideDupMemberNumber");
				Map(m => m.OfficeAddress1).Name("OfficeAddress1");
				Map(m => m.OfficeZip).Name("OfficeZip");
				Map(m => m.UpdateMemberNumberFlag).Name("UpdateMemberNumberFlag");
				Map(m => m.Age).Name("Age");
				Map(m => m.Ethnicity).Name("Ethnicity");
				Map(m => m.check).Name("check");
				Map(m => m.UpdateEthnicity).Name("UpdateEthnicity");
				Map(m => m.MatchLiveData).Name("MatchLiveData");
				Map(m => m.MatchWesternDental).Name("MatchWesternDental");
				Map(m => m.OfficeNumber).Name("OfficeNumber");
				Map(m => m.ProviderNumber).Name("ProviderNumber");
				Map(m => m.Maximus).Name("Maximus");
				Map(m => m.AutoGenerateCityAndState).Name("AutoGenerateCityAndState");
			}
		}


	}
}
