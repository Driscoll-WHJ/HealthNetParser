using HealthNetParser.Daily;
using HealthNetParser.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthNetParser
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Daily File Processing
			var DataFromCsv = SourceCSVFile.ReadSourceCSVFile();
			new HistoricalSpan().BuildHistoricalSpanFile(DataFromCsv);
			new HSPReady().BuildHSPReadyFile(DataFromCsv);
			new Hspready_Reinstatemembers().BuildHspreadyReinstatemembersFile(DataFromCsv);

			//Full File Processing
		}
	}
}
