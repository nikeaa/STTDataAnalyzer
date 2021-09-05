using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.Static
{
	public class Ranks
	{
		public Ranks(){
			BaseRanks = new List<SkillRank>();
			AverageRanks = new List<SkillRank>();
			VoyagePairRanks = new List<PairRank>();
			GauntletPairRanks = new List<PairRank>();
			BaseSkills = new List<BaseSkill>();
			SkillData = new List<BaseSkill>[5];
		}

        public int VoyageRank;
		public int GauntletRank;
		public int ChronCostRank;

		public List<SkillRank> BaseRanks;
		public List<SkillRank> AverageRanks;

		public List<PairRank> VoyagePairRanks;
		public List<PairRank> GauntletPairRanks;

        public List<BaseSkill> BaseSkills;

        public List<BaseSkill>[] SkillData;
	}
}