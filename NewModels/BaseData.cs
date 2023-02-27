using System.Configuration;

namespace STTDataAnalyzer.Models
{
	public class BaseData
	{
		protected readonly string Path = ConfigurationManager.AppSettings["Path"];

		protected readonly string CommandSkillName = ConfigurationManager.AppSettings["CommandSkillName"];
		protected readonly string DiplomacySkillName = ConfigurationManager.AppSettings["DiplomacySkillName"];
		protected readonly string EngineeringSkillName = ConfigurationManager.AppSettings["EngineeringSkillName"];
		protected readonly string MedicineSkillName = ConfigurationManager.AppSettings["MedicineSkillName"];
		protected readonly string ScienceSkillName = ConfigurationManager.AppSettings["ScienceSkillName"];
		protected readonly string SecuritySkillName = ConfigurationManager.AppSettings["SecuritySkillName"];
	}
}
