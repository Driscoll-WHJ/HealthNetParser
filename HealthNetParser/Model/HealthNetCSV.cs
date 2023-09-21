using CsvHelper.Configuration;
using HealthNetParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthNetParser.Model
{

	public class HealthNetFromCSV
	{
		public string MasterPolicyNumber { get; set; }
		public string SubscriberNumber { get; set; }
		public string RelationshipCode { get; set; }
		public string MaintenanceTypeCode { get; set; }
		public string MaintenanceReasonCode  { get; set; }
		public string BenefitStatus { get; set; }
		public string MedicarePlan { get; set; }
		public string CobraQualifier { get; set; }
		public string EmploymentStatus { get; set; }
		public string DateOfDeath { get; set; }
		public string BirthSeqNumber { get; set; }
		public string MemberPolicyNumber { get; set; }
		public string ClientReportingCategoryNumber_17 { get; set; }
		public string ClientNumber_23 { get; set; }
		public string CaseNumber_3H { get; set; }
		public string CrossReferenceNumber_6O { get; set; }
		public string DepartmentAgencyNumber_DX { get; set; }
		public string HealthInsuranceClaimNumber_F6 { get; set; }
		public string PriorIdentificationNumber_Q4 { get; set; }
		public string MutuallyDefined_ZZ { get; set; }
		public string ReinstatementDate { get; set; }
		public string TerminationDate { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string NamePrefix { get; set; }
		public string NameSuffix { get; set; }
		public string NationalIndividualID { get; set; }
		public string SocialSecurityNumber { get; set; }
		public string DateOfBirth { get; set; }
		public string Gender { get; set; }
		public string MaritalStatus { get; set; }
		public string Ethnicity { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string CountryCode { get; set; }
		public string County { get; set; }
		public string WorkPhone { get; set; }
		public string HomePhone { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string MemberDate1 { get; set; }
		public string MemberDate2 { get; set; }
		public string MemberDate3 { get; set; }
		public string MemberDate4 { get; set; }
		public string MemberDate5 { get; set; }
		public string MemberDate6 { get; set; }
		public string MemberDate7 { get; set; }
		public string MemberDate8 { get; set; }
		public string MemberDate9 { get; set; }
		public string MemberDate10 { get; set; }
		public string OldLastName { get; set; }
		public string OldFirstName { get; set; }
		public string OldDateOfBirth { get; set; }
		public string OldNID { get; set; }
		public string OldSSN { get; set; }
		public string OldAddress1 { get; set; }
		public string OldCity { get; set; }
		public string OldState { get; set; }
		public string OldZip { get; set; }
		public string DisabilityTypeCode { get; set; }
		public string DisabilityDiagnosisCode { get; set; }
		public string MemberLanguage { get; set; }
		public string MemberLanguageXML { get; set; }
		public string LanguagesXML { get; set; }
		public string COBPrecedence { get; set; }
		public string COBPayerName { get; set; }
		public string COBEffectiveDate { get; set; }
		public string COBExpirationDate { get; set; }
		public string COBPayerNumberQualifier { get; set; }
		public string COBPayerNumber { get; set; }
		public string CoverageType { get; set; }
		public string CoverageDescription { get; set; }
		public string TierCode { get; set; }
		public string EffectiveDate { get; set; }
		public string ExpirationDate { get; set; }
		public string PremiumPaidToEndDate { get; set; }
		public string LastPremiumPaidDate { get; set; }
		public string HealthCoverageREFNumber_CE { get; set; }
		public string HealthCoverageREFNumber_E8 { get; set; }
		public string HealthCoverageREFNumber_1L { get; set; }
		public string HealthCoverageREFNumber_ZZ { get; set; }
		public string HealthCoverageREFNumber_17 { get; set; }
		public string ProviderIDType { get; set; }
		public string ProviderID { get; set; }
		public string ProviderCity { get; set; }
		public string ProviderState { get; set; }
		public string ProviderZip { get; set; }
		public string ProviderLocQualifier { get; set; }
		public string ProviderLocCode { get; set; }
		public string ProviderPLADate { get; set; }
		public string SponsorName { get; set; }
		public string SponsorNumberQualifier { get; set; }
		public string SponsorNumber { get; set; }
		public string PayerName { get; set; }
		public string PayerNumberQualifier { get; set; }
		public string PayerNumber { get; set; }
		public string BrokerName { get; set; }
		public string BrokerNumberQualifier { get; set; }
		public string BrokerNumber { get; set; }
		public string BrokerAccountNumber { get; set; }
		public string MailingAddress1 { get; set; }
		public string MailingAddress2 { get; set; }
		public string MailingCity { get; set; }
		public string MailingState { get; set; }
		public string MailingZip { get; set; }
		public string EmployerName { get; set; }
		public string EmployerFirstName { get; set; }
		public string EmployerID { get; set; }
		public string EmployerAddress1 { get; set; }
		public string EmployerAddress2 { get; set; }
		public string EmployerCity { get; set; }
		public string EmployerState { get; set; }
		public string EmployerZip { get; set; }
		public string EmployerPhone { get; set; }
		public string MemberSchool { get; set; }
		public string MemberSchoolAddress1 { get; set; }
		public string MemberSchoolAddress2 { get; set; }
		public string MemberSchoolCity { get; set; }
		public string MemberSchoolState { get; set; }
		public string MemberSchoolZip { get; set; }
		public string MemberSchoolPhone { get; set; }
		public string CustodialParentLastName { get; set; }
		public string CustodialParentFirstName { get; set; }
		public string CustodialParentNII { get; set; }
		public string CustodialParentSSN { get; set; }
		public string CustodialParentAddress { get; set; }
		public string CustodialParentAddress2 { get; set; }
		public string CustodialParentCity { get; set; }
		public string CustodialParentState { get; set; }
		public string CustodialParentZip { get; set; }
		public string CustodialParentPhone { get; set; }
		public string ResponsiblePartyLastName { get; set; }
		public string ResponsiblePartyFirstName { get; set; }
		public string ResponsiblePartyType { get; set; }
		public string ResponsiblePartyNII { get; set; }
		public string ResponsiblePartySSN { get; set; }
		public string ResponsiblePartyAddress { get; set; }
		public string ResponsiblePartyAddress2 { get; set; }
		public string ResponsiblePartyCity { get; set; }
		public string ResponsiblePartyState { get; set; }
		public string ResponsiblePartyZip { get; set; }
		public string ResponsiblePartyWorkPhone { get; set; }
		public string ResponsiblePartyHomePhone { get; set; }
		public string ResponsiblePartyEmail { get; set; }
		public string Coverage_Xml { get; set; }
		public string Loop2700_Xml { get; set; }
		public string ReportingCat_APTC_AMT { get; set; }
		public string ReportingCat_PRE_AMT { get; set; }
		public string ReportingCat_PRE_AMT_TOT { get; set; }
		public string ReportingCat_TOT_RES_AMT { get; set; }
		public string ReportingCat_CSR_AMT { get; set; }
		public string ReportingCat_RATING_AREA { get; set; }
		public string Source834XmlId { get; set; }
		public string GroupNumber { get; set; }
		public string LATITUDE { get; set; }
		public string LONGITUDE { get; set; }
		public string MemberNumber { get; set; }
		public string OldMemberNumber { get; set; }
		public string SubscriberPolicyNumber { get; set; }
		public string ProviderNumber { get; set; }
		public string OfficeAddress1 { get; set; }
		public string OfficeZip { get; set; }
		public string PCPPrecedence { get; set; }
		public string PrimaryInsurance { get; set; }
		public string NameFormat { get; set; }
		public string ProviderOrganization { get; set; }
		public string PrimarySecondaryIndicator { get; set; }
		public string ProviderNetworkName { get; set; }
		public string NetworkEffectiveDate { get; set; }
		public string NetworkExpirationDate { get; set; }
		public string ActiveMemberSince { get; set; }
		public string ReimbursementName { get; set; }
		public string Product { get; set; }
		public string TierName { get; set; }
		public string UpdateIdentifyingElements { get; set; }
		public string UpdateAdditionalInformation { get; set; }
		public string OverrideMismatch { get; set; }
		public string OverrideDupmemberNumber { get; set; }
		public string UseAnyTier { get; set; }
		public string SaveAltAddress { get; set; }
		public string UpdateMemberNumberFlag { get; set; }
		public string TermExistBenefitsBeforeAddNew { get; set; }
		public string CellPhone { get; set; }
		public string LocationCode { get; set; }
		public string PrimaryLanguage { get; set; }
		public string UseMemberaddress { get; set; }
		public string LastNameMatch { get; set; }
		public string OfficeNumber { get; set; }
		public string AutoAssignPCP { get; set; }
		public string AutoGenerateCityAndState { get; set; }
		public string OverridePCPPanel { get; set; }
		public string SeparateOutOfNetworkIDCard { get; set; }
		public string ManuallyAssigned { get; set; }
		public string CustomAttributes { get; set; }
		public string MemberCoverageAttributes { get; set; }
		public string CreateNewHousehold { get; set; }
		public string OverrideMultipleResponsibleParties { get; set; }
		public string ResponsiblePartyNumber { get; set; }
		public string ResponsiblePartyDOB { get; set; }
		public string ResponsiblePartyGroupNumber { get; set; }
		public string ResponsibleEffectiveDate { get; set; }
		public string ResponsibleExpirationDate { get; set; }
		public string InheritResponsibleParty { get; set; }
		public string ResponsiblePartySuffix { get; set; }
		public string ResponsiblePartyMiddleName { get; set; }
		public string ResponsiblePartyRelationshipCode { get; set; }
		public string ResponsiblePartyGender { get; set; }
		public string ResponsiblePartyLocationCode { get; set; }
		public string ResponsiblePartyCellPhone { get; set; }
		public string ResponsiblePartyMailingAddress { get; set; }
		public string ResponsiblePartyMailingAddress2 { get; set; }
		public string ResponsiblePartyMailingCity { get; set; }
		public string ResponsiblePartyMailingState { get; set; }
		public string ResponsiblePartyMailingZip { get; set; }
		public string ResponsiblePartyCustomAttributes { get; set; }
		public string HouseholdReferenceNumber { get; set; }
		public string UpdatePolicyNumber { get; set; }
		public string UpdateSSN { get; set; }
		public string UpdateName { get; set; }
		public string UpdateDateOfBirth { get; set; }
		public string UpdateNationalIndividualId { get; set; }
		public string UpdateAdditionalNameDetails { get; set; }
		public string UpdateStreetAddressInfo { get; set; }
		public string UpdateMainAddressInfo { get; set; }
		public string UpdateLocationCode { get; set; }
		public string UpdateContactInfo { get; set; }
		public string UpdateGender { get; set; }
		public string UpdateDateOfDeath { get; set; }
		public string UpdateEthnicity { get; set; }
		public string UpdateMaritalStatus { get; set; }
		public string MonthId { get; set; }
		public string MemberNumberConsistency { get; set; }
	}

	public class HealthNetClassMap : ClassMap<HealthNetFromCSV>
	{
		public HealthNetClassMap()
		{
			Map(m => m.MasterPolicyNumber).Name("MasterPolicyNumber");
			Map(m => m.SubscriberNumber).Name("SubscriberNumber");
			Map(m => m.RelationshipCode).Name("RelationshipCode");
			Map(m => m.MaintenanceTypeCode).Name("MaintenanceTypeCode");
			Map(m => m.MaintenanceTypeCode).Name("MaintenanceTypeCode");
			Map(m => m.BenefitStatus).Name("BenefitStatus");
			Map(m => m.MedicarePlan).Name("MedicarePlan");
			Map(m => m.CobraQualifier).Name("CobraQualifier");
			Map(m => m.EmploymentStatus).Name("EmploymentStatus");
			Map(m => m.DateOfDeath).Name("DateOfDeath");
			Map(m => m.BirthSeqNumber).Name("BirthSeqNumber");
			Map(m => m.MemberPolicyNumber).Name("MemberPolicyNumber");
			Map(m => m.ClientReportingCategoryNumber_17).Name("ClientReportingCategoryNumber_17");
			Map(m => m.ClientNumber_23).Name("ClientNumber_23");
			Map(m => m.CaseNumber_3H).Name("CaseNumber_3H");
			Map(m => m.CrossReferenceNumber_6O).Name("CrossReferenceNumber_6O");
			Map(m => m.DepartmentAgencyNumber_DX).Name("DepartmentAgencyNumber_DX");
			Map(m => m.HealthInsuranceClaimNumber_F6).Name("HealthInsuranceClaimNumber_F6");
			Map(m => m.PriorIdentificationNumber_Q4).Name("PriorIdentificationNumber_Q4");
			Map(m => m.MutuallyDefined_ZZ).Name("MutuallyDefined_ZZ");
			Map(m => m.ReinstatementDate).Name("ReinstatementDate");
			Map(m => m.TerminationDate).Name("TerminationDate");
			Map(m => m.LastName).Name("LastName");
			Map(m => m.FirstName).Name("FirstName");
			Map(m => m.MiddleName).Name("MiddleName");
			Map(m => m.NamePrefix).Name("NamePrefix");
			Map(m => m.NameSuffix).Name("NameSuffix");
			Map(m => m.NationalIndividualID).Name("NationalIndividualID");
			Map(m => m.SocialSecurityNumber).Name("SocialSecurityNumber");
			Map(m => m.DateOfBirth).Name("DateOfBirth");
			Map(m => m.Gender).Name("Gender");
			Map(m => m.MaritalStatus).Name("MaritalStatus");
			Map(m => m.Ethnicity).Name("Ethnicity");
			Map(m => m.Address1).Name("Address1");
			Map(m => m.Address2).Name("Address2");
			Map(m => m.City).Name("City");
			Map(m => m.State).Name("State");
			Map(m => m.Zip).Name("Zip");
			Map(m => m.CountryCode).Name("CountryCode");
			Map(m => m.County).Name("County");
			Map(m => m.WorkPhone).Name("WorkPhone");
			Map(m => m.HomePhone).Name("HomePhone");
			Map(m => m.Phone).Name("Phone");
			Map(m => m.Email).Name("Email");
			Map(m => m.MemberDate1).Name("MemberDate1");
			Map(m => m.MemberDate2).Name("MemberDate2");
			Map(m => m.MemberDate3).Name("MemberDate3");
			Map(m => m.MemberDate4).Name("MemberDate4");
			Map(m => m.MemberDate5).Name("MemberDate5");
			Map(m => m.MemberDate6).Name("MemberDate6");
			Map(m => m.MemberDate7).Name("MemberDate7");
			Map(m => m.MemberDate8).Name("MemberDate8");
			Map(m => m.MemberDate9).Name("MemberDate9");
			Map(m => m.MemberDate10).Name("MemberDate10");
			Map(m => m.OldLastName).Name("OldLastName");
			Map(m => m.OldFirstName).Name("OldFirstName");
			Map(m => m.OldDateOfBirth).Name("OldDateOfBirth");
			Map(m => m.OldNID).Name("OldNID");
			Map(m => m.OldSSN).Name("OldSSN");
			Map(m => m.OldAddress1).Name("OldAddress1");
			Map(m => m.OldCity).Name("OldCity");
			Map(m => m.OldState).Name("OldState");
			Map(m => m.OldZip).Name("OldZip");
			Map(m => m.DisabilityTypeCode).Name("DisabilityTypeCode");
			Map(m => m.DisabilityDiagnosisCode).Name("DisabilityDiagnosisCode");
			Map(m => m.MemberLanguage).Name("MemberLanguage");
			Map(m => m.MemberLanguageXML).Name("MemberLanguageXML");
			Map(m => m.LanguagesXML).Name("LanguagesXML");
			Map(m => m.COBPrecedence).Name("COBPrecedence");
			Map(m => m.COBPayerName).Name("COBPayerName");
			Map(m => m.COBEffectiveDate).Name("COBEffectiveDate");
			Map(m => m.COBExpirationDate).Name("COBExpirationDate");
			Map(m => m.COBPayerNumberQualifier).Name("COBPayerNumberQualifier");
			Map(m => m.COBPayerNumber).Name("COBPayerNumber");
			Map(m => m.CoverageType).Name("CoverageType");
			Map(m => m.CoverageDescription).Name("CoverageDescription");
			Map(m => m.TierCode).Name("TierCode");
			Map(m => m.EffectiveDate).Name("EffectiveDate");
			Map(m => m.ExpirationDate).Name("ExpirationDate");
			Map(m => m.PremiumPaidToEndDate).Name("PremiumPaidToEndDate");
			Map(m => m.LastPremiumPaidDate).Name("LastPremiumPaidDate");
			Map(m => m.HealthCoverageREFNumber_CE).Name("HealthCoverageREFNumber_CE");
			Map(m => m.HealthCoverageREFNumber_E8).Name("HealthCoverageREFNumber_E8");
			Map(m => m.HealthCoverageREFNumber_1L).Name("HealthCoverageREFNumber_1L");
			Map(m => m.HealthCoverageREFNumber_ZZ).Name("HealthCoverageREFNumber_ZZ");
			Map(m => m.HealthCoverageREFNumber_17).Name("HealthCoverageREFNumber_17");
			Map(m => m.ProviderIDType).Name("ProviderIDType");
			Map(m => m.ProviderID).Name("ProviderID");
			Map(m => m.ProviderCity).Name("ProviderCity");
			Map(m => m.ProviderState).Name("ProviderState");
			Map(m => m.ProviderZip).Name("ProviderZip");
			Map(m => m.ProviderLocQualifier).Name("ProviderLocQualifier");
			Map(m => m.ProviderLocCode).Name("ProviderLocCode");
			Map(m => m.ProviderPLADate).Name("ProviderPLADate");
			Map(m => m.SponsorName).Name("SponsorName");
			Map(m => m.SponsorNumberQualifier).Name("SponsorNumberQualifier");
			Map(m => m.SponsorNumber).Name("SponsorNumber");
			Map(m => m.PayerName).Name("PayerName");
			Map(m => m.PayerNumberQualifier).Name("PayerNumberQualifier");
			Map(m => m.PayerNumber).Name("PayerNumber");
			Map(m => m.BrokerName).Name("BrokerName");
			Map(m => m.BrokerNumberQualifier).Name("BrokerNumberQualifier");
			Map(m => m.BrokerNumber).Name("BrokerNumber");
			Map(m => m.BrokerAccountNumber).Name("BrokerAccountNumber");
			Map(m => m.MailingAddress1).Name("MailingAddress1");
			Map(m => m.MailingAddress2).Name("MailingAddress2");
			Map(m => m.MailingCity).Name("MailingCity");
			Map(m => m.MailingState).Name("MailingState");
			Map(m => m.MailingZip).Name("MailingZip");
			Map(m => m.EmployerName).Name("EmployerName");
			Map(m => m.EmployerFirstName).Name("EmployerFirstName");
			Map(m => m.EmployerID).Name("EmployerID");
			Map(m => m.EmployerAddress1).Name("EmployerAddress1");
			Map(m => m.EmployerAddress2).Name("EmployerAddress2");
			Map(m => m.EmployerCity).Name("EmployerCity");
			Map(m => m.EmployerState).Name("EmployerState");
			Map(m => m.EmployerZip).Name("EmployerZip");
			Map(m => m.EmployerPhone).Name("EmployerPhone");
			Map(m => m.MemberSchool).Name("MemberSchool");
			Map(m => m.MemberSchoolAddress1).Name("MemberSchoolAddress1");
			Map(m => m.MemberSchoolAddress2).Name("MemberSchoolAddress2");
			Map(m => m.MemberSchoolCity).Name("MemberSchoolCity");
			Map(m => m.MemberSchoolState).Name("MemberSchoolState");
			Map(m => m.MemberSchoolZip).Name("MemberSchoolZip");
			Map(m => m.MemberSchoolPhone).Name("MemberSchoolPhone");
			Map(m => m.CustodialParentLastName).Name("CustodialParentLastName");
			Map(m => m.CustodialParentFirstName).Name("CustodialParentFirstName");
			Map(m => m.CustodialParentNII).Name("CustodialParentNII");
			Map(m => m.CustodialParentSSN).Name("CustodialParentSSN");
			Map(m => m.CustodialParentAddress).Name("CustodialParentAddress");
			Map(m => m.CustodialParentAddress2).Name("CustodialParentAddress2");
			Map(m => m.CustodialParentCity).Name("CustodialParentCity");
			Map(m => m.CustodialParentState).Name("CustodialParentState");
			Map(m => m.CustodialParentZip).Name("CustodialParentZip");
			Map(m => m.CustodialParentPhone).Name("CustodialParentPhone");
			Map(m => m.ResponsiblePartyLastName).Name("ResponsiblePartyLastName");
			Map(m => m.ResponsiblePartyFirstName).Name("ResponsiblePartyFirstName");
			Map(m => m.ResponsiblePartyType).Name("ResponsiblePartyType");
			Map(m => m.ResponsiblePartyNII).Name("ResponsiblePartyNII");
			Map(m => m.ResponsiblePartySSN).Name("ResponsiblePartySSN");
			Map(m => m.ResponsiblePartyAddress).Name("ResponsiblePartyAddress");
			Map(m => m.ResponsiblePartyAddress2).Name("ResponsiblePartyAddress2");
			Map(m => m.ResponsiblePartyCity).Name("ResponsiblePartyCity");
			Map(m => m.ResponsiblePartyState).Name("ResponsiblePartyState");
			Map(m => m.ResponsiblePartyZip).Name("ResponsiblePartyZip");
			Map(m => m.ResponsiblePartyWorkPhone).Name("ResponsiblePartyWorkPhone");
			Map(m => m.ResponsiblePartyHomePhone).Name("ResponsiblePartyHomePhone");
			Map(m => m.ResponsiblePartyEmail).Name("ResponsiblePartyEmail");
			Map(m => m.Coverage_Xml).Name("Coverage_Xml");
			Map(m => m.Loop2700_Xml).Name("Loop2700_Xml");
			Map(m => m.ReportingCat_APTC_AMT).Name("ReportingCat_APTC_AMT");
			Map(m => m.ReportingCat_PRE_AMT).Name("ReportingCat_PRE_AMT");
			Map(m => m.ReportingCat_PRE_AMT_TOT).Name("ReportingCat_PRE_AMT_TOT");
			Map(m => m.ReportingCat_TOT_RES_AMT).Name("ReportingCat_TOT_RES_AMT");
			Map(m => m.ReportingCat_CSR_AMT).Name("ReportingCat_CSR_AMT");
			Map(m => m.ReportingCat_RATING_AREA).Name("ReportingCat_RATING_AREA");
			Map(m => m.Source834XmlId).Name("Source834XmlId");
			Map(m => m.GroupNumber).Name("GroupNumber");
			Map(m => m.LATITUDE).Name("LATITUDE");
			Map(m => m.LONGITUDE).Name("LONGITUDE");
			Map(m => m.MemberNumber).Name("MemberNumber");
			Map(m => m.OldMemberNumber).Name("OldMemberNumber");
			Map(m => m.SubscriberPolicyNumber).Name("SubscriberPolicyNumber");
			Map(m => m.ProviderNumber).Name("ProviderNumber");
			Map(m => m.OfficeAddress1).Name("OfficeAddress1");
			Map(m => m.OfficeZip).Name("OfficeZip");
			Map(m => m.PCPPrecedence).Name("PCPPrecedence");
			Map(m => m.PrimaryInsurance).Name("PrimaryInsurance");
			Map(m => m.NameFormat).Name("NameFormat");
			Map(m => m.ProviderOrganization).Name("ProviderOrganization");
			Map(m => m.PrimarySecondaryIndicator).Name("PrimarySecondaryIndicator");
			Map(m => m.ProviderNetworkName).Name("ProviderNetworkName");
			Map(m => m.NetworkEffectiveDate).Name("NetworkEffectiveDate");
			Map(m => m.NetworkExpirationDate).Name("NetworkExpirationDate");
			Map(m => m.ActiveMemberSince).Name("ActiveMemberSince");
			Map(m => m.ReimbursementName).Name("ReimbursementName");
			Map(m => m.Product).Name("Product");
			Map(m => m.TierName).Name("TierName");
			Map(m => m.UpdateIdentifyingElements).Name("UpdateIdentifyingElements");
			Map(m => m.UpdateAdditionalInformation).Name("UpdateAdditionalInformation");
			Map(m => m.OverrideMismatch).Name("OverrideMismatch");
			Map(m => m.OverrideDupmemberNumber).Name("OverrideDupmemberNumber");
			Map(m => m.UseAnyTier).Name("UseAnyTier");
			Map(m => m.SaveAltAddress).Name("SaveAltAddress");
			Map(m => m.UpdateMemberNumberFlag).Name("UpdateMemberNumberFlag");
			Map(m => m.TermExistBenefitsBeforeAddNew).Name("TermExistBenefitsBeforeAddNew");
			Map(m => m.CellPhone).Name("CellPhone");
			Map(m => m.LocationCode).Name("LocationCode");
			Map(m => m.PrimaryLanguage).Name("PrimaryLanguage");
			Map(m => m.UseMemberaddress).Name("UseMemberaddress");
			Map(m => m.LastNameMatch).Name("LastNameMatch");
			Map(m => m.OfficeNumber).Name("OfficeNumber");
			Map(m => m.AutoAssignPCP).Name("AutoAssignPCP");
			Map(m => m.AutoGenerateCityAndState).Name("AutoGenerateCityAndState");
			Map(m => m.OverridePCPPanel).Name("OverridePCPPanel");
			Map(m => m.SeparateOutOfNetworkIDCard).Name("SeparateOutOfNetworkIDCard");
			Map(m => m.ManuallyAssigned).Name("ManuallyAssigned");
			Map(m => m.CustomAttributes).Name("CustomAttributes");
			Map(m => m.MemberCoverageAttributes).Name("MemberCoverageAttributes");
			Map(m => m.CreateNewHousehold).Name("CreateNewHousehold");
			Map(m => m.OverrideMultipleResponsibleParties).Name("OverrideMultipleResponsibleParties");
			Map(m => m.ResponsiblePartyNumber).Name("ResponsiblePartyNumber");
			Map(m => m.ResponsiblePartyDOB).Name("ResponsiblePartyDOB");
			Map(m => m.ResponsiblePartyGroupNumber).Name("ResponsiblePartyGroupNumber");
			Map(m => m.ResponsibleEffectiveDate).Name("ResponsibleEffectiveDate");
			Map(m => m.ResponsibleExpirationDate).Name("ResponsibleExpirationDate");
			Map(m => m.InheritResponsibleParty).Name("InheritResponsibleParty");
			Map(m => m.ResponsiblePartySuffix).Name("ResponsiblePartySuffix");
			Map(m => m.ResponsiblePartyMiddleName).Name("ResponsiblePartyMiddleName");
			Map(m => m.ResponsiblePartyRelationshipCode).Name("ResponsiblePartyRelationshipCode");
			Map(m => m.ResponsiblePartyGender).Name("ResponsiblePartyGender");
			Map(m => m.ResponsiblePartyLocationCode).Name("ResponsiblePartyLocationCode");
			Map(m => m.ResponsiblePartyCellPhone).Name("ResponsiblePartyCellPhone");
			Map(m => m.ResponsiblePartyMailingAddress).Name("ResponsiblePartyMailingAddress");
			Map(m => m.ResponsiblePartyMailingAddress2).Name("ResponsiblePartyMailingAddress2");
			Map(m => m.ResponsiblePartyMailingCity).Name("ResponsiblePartyMailingCity");
			Map(m => m.ResponsiblePartyMailingState).Name("ResponsiblePartyMailingState");
			Map(m => m.ResponsiblePartyMailingZip).Name("ResponsiblePartyMailingZip");
			Map(m => m.ResponsiblePartyCustomAttributes).Name("ResponsiblePartyCustomAttributes");
			Map(m => m.HouseholdReferenceNumber).Name("HouseholdReferenceNumber");
			Map(m => m.UpdatePolicyNumber).Name("UpdatePolicyNumber");
			Map(m => m.UpdateSSN).Name("UpdateSSN");
			Map(m => m.UpdateName).Name("UpdateName");
			Map(m => m.UpdateDateOfBirth).Name("UpdateDateOfBirth");
			Map(m => m.UpdateNationalIndividualId).Name("UpdateNationalIndividualId");
			Map(m => m.UpdateAdditionalNameDetails).Name("UpdateAdditionalNameDetails");
			Map(m => m.UpdateStreetAddressInfo).Name("UpdateStreetAddressInfo");
			Map(m => m.UpdateMainAddressInfo).Name("UpdateMainAddressInfo");
			Map(m => m.UpdateLocationCode).Name("UpdateLocationCode");
			Map(m => m.UpdateContactInfo).Name("UpdateContactInfo");
			Map(m => m.UpdateGender).Name("UpdateGender");
			Map(m => m.UpdateDateOfDeath).Name("UpdateDateOfDeath");
			Map(m => m.UpdateEthnicity).Name("UpdateEthnicity");
			Map(m => m.UpdateMaritalStatus).Name("UpdateMaritalStatus");
			Map(m => m.MonthId).Name("MonthId");
			Map(m => m.MemberNumberConsistency).Name("MemberNumberConsistency");
		}
	}

	
	public class HealthNetOutPutModel
	{
		public string AlreadyinMeditrack { get; set; }
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
		public string HomePhone { get; set; }
		public string WorkPhone { get; set; }
		public string PrimaryLanguage { get; set; }
		public string Gender { get; set; }
		public string DateOfBirth { get; set; }
		public string RelationshipCode { get; set; }
		public string OfficeNumber { get; set; }
		public string ProviderNumber { get; set; }
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
		public string HNOfficeNumber { get; set; }
		public string check { get; set; }
		public string UpdateEthnicity { get; set; }
		public string New { get; set; }
		public string Maximus { get; set; }
		public string MatchLiveData { get; set; }
		public string MatchWesternDental { get; set; }
		public string HSPOfficeNoReport { get; set; }
		public string HSPProviderNoReport { get; set; }
		public string OldGroupNumber { get; set; }
		public string Mismatch { get; set; }
		public string Change_Values { get; set; }
		public string ACA { get; set; }
		public string GMC_Threshold { get; set; }
		public string PHP_Threshold { get; set; }
		public string LanguagesXML { get; set; }
		public string ClientReportingCategoryNumber_17 { get; set; }
		public string MemberCoverageAttributes { get; set; }
	}



	public class HealthNetHistoricalSpanClassMap : ClassMap<HealthNetOutPutModel>
	{
		public HealthNetHistoricalSpanClassMap()
		{
			Map(m => m.AlreadyinMeditrack).Name("AlreadyinMeditrack");
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
			Map(m => m.OfficeNumber).Name("OfficeNumber");
			Map(m => m.ProviderNumber).Name("ProviderNumber");
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
			Map(m => m.HNOfficeNumber).Name("HN  Office Number");
			Map(m => m.check).Name("check");
			Map(m => m.UpdateEthnicity).Name("UpdateEthnicity");
			Map(m => m.New).Name("New");
			Map(m => m.Maximus).Name("Maximus");
			Map(m => m.MatchLiveData).Name("MatchLiveData");
			Map(m => m.MatchWesternDental).Name("MatchWesternDental");
			Map(m => m.HSPOfficeNoReport).Name("HSPOfficeNoReport");
			Map(m => m.HSPProviderNoReport).Name("HSPProviderNoReport");
			Map(m => m.OldGroupNumber).Name("OldGroupNumber");
			Map(m => m.Mismatch).Name("Mismatch");
			Map(m => m.Change_Values).Name("Change_Values");
			Map(m => m.ACA).Name("ACA");
			Map(m => m.GMC_Threshold).Name("GMC_Threshold");
			Map(m => m.PHP_Threshold).Name("PHP_Threshold");
			Map(m => m.LanguagesXML).Name("LanguagesXML");
			Map(m => m.ClientReportingCategoryNumber_17).Name("ClientReportingCategoryNumber_17");
			Map(m => m.MemberCoverageAttributes).Name("MemberCoverageAttributes");
		}
	}










}
