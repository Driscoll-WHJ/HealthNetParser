using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HealthNetParser
{
	public static class CSVHelper
	{

		public static DateTime CleanDateTimeString(string dateString)
		{

			string cleanedDateString = dateString.Replace("\"", "").Trim();

			DateTime.TryParse(cleanedDateString, out DateTime result);

			return result;

		}
		public static string ParseLanguageXml(string xml)
		{

			string languageCode = "";
			try
			{
				// Load the XML string into an XmlDocument
				XmlDocument doc = new XmlDocument();
				doc.LoadXml(xml);

				// Find the Language element
				XmlNode languageNode = doc.SelectSingleNode("/Languages/Language");

				if (languageNode != null)
				{
					// Get the value of the LanguageCode attribute
					languageCode = languageNode.Attributes["LanguageCode"].Value;
					return languageCode;
				}
				else
				{
					Console.WriteLine("Language element not found in XML.");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			return languageCode;
		}

		public static string CalculateAge(DateTime dateOfBirth)
		{
			DateTime currentDate = DateTime.Now;
			int age = currentDate.Year - dateOfBirth.Year;

			// Check if the birthdate has occurred this year
			if (currentDate.Month < dateOfBirth.Month || (currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day))
			{
				age--;
			}

			return age.ToString();
		}

		public static string AcaCheck(string aca)
		{
			var result = "";
			switch (aca)
			{
				case "7U":
				case "L1":
				case "M1":
					result = "Yes";
					break;
				default:
					result = "No";
					break;
			}
			return result;

		}


		public static string GroupNumber(DateTime dateOfBirth, string fileName, string aca)
		{
			string CalAge = CalculateAge(dateOfBirth);
			int age = Convert.ToInt32(CalAge);
			var CheckAca = AcaCheck(aca);
			var GroupNumber = "";
			if (fileName.Contains("427"))
			{
				if (CheckAca == "No")
				{
					switch (age)
					{
						case int n when n >= 0 && n <= 7:
							GroupNumber = "HNGMC07";
							break;
						case int n when n >= 8 && n <= 20:
							GroupNumber = "HNGMC820";
							break;
						case int n when n >= 21:
							GroupNumber = "HNGMC21";
							break;
					}
				}
				if (CheckAca == "Yes")
				{
					switch (age)
					{
						case int n when n >= 0 && n <= 7:
							GroupNumber = "HNGMC07ACA";
							break;
						case int n when n >= 8 && n <= 20:
							GroupNumber = "HNGMC820ACA";
							break;
						case int n when n >= 21:
							GroupNumber = "HNGMC21ACA";
							break;

					}
				}


			}
			if (fileName.Contains("405"))
			{
				if (CheckAca == "No")
				{
					switch (age)
					{
						case int n when n >= 0 && n <= 20:
							GroupNumber = "HNPHP1";
							break;
						case int n when n >= 21:
							GroupNumber = "HNLAPHP21";
							break;

					}
				}
				if (CheckAca == "Yes")
				{
					switch (age)
					{
						case int n when n >= 0 && n <= 20:
							GroupNumber = "HNLAPHPACA";
							break;
						case int n when n >= 21:
							GroupNumber = "HNLAPHP21ACA";
							break;

					}
				}



			}

			return GroupNumber;

		}

	}
}
