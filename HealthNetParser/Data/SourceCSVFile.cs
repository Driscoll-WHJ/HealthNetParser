using HealthNetParser.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthNetParser.Data
{
	public class SourceCSVFile
	{
		public static List<HealthNetFromCSV> ReadSourceCSVFile()
		{
			string inputFilePath = @"\\irvftpauto\FTP_Share\Access_DBs\Dbs\EDI_Documents\HealthNet\daily_20230830\csv";
			var fileNameVariable = "";
			List<HealthNetFromCSV> records = new List<HealthNetFromCSV>();
			DirectoryInfo dir = new DirectoryInfo(inputFilePath);
			FileInfo[] filePaths = dir.GetFiles();
			if (filePaths.Length == 0)
			{
				return new List<HealthNetFromCSV>();
			}

			foreach (var file in filePaths)
			{
				
				using (StreamReader reader = new StreamReader(file.FullName))
				{
				
					string header = reader.ReadLine(); // Read and skip the header row

					string line;
					while ((line = reader.ReadLine()) != null)
					{
						string[] columns = line.Split(',');

						if (columns.Length != 0)
						{
							HealthNetFromCSV record = new HealthNetFromCSV();
							//if (file.Name.Contains("HN-405-"))
							//{
							//	columns[0] = "405";
							//}
							//if (file.Name.Contains("HN-427-"))
							//{
							//	columns[0] = "427";
							//}
							// Map properties using reflection
							var properties = typeof(HealthNetFromCSV).GetProperties();
							for (int i = 0; i < columns.Length && i < properties.Length; i++)
							{
								properties[i].SetValue(record, columns[i]);
							}

							records.Add(record);
						}
					}
				}


			}
			return records;
		}
	}
}
