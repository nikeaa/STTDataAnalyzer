using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using STTDataAnalyzer.Models.Static;
using System;
using System.Collections.Generic;
using System.Linq;

namespace STTDataAnalyzer
{
	public class RanksConverter : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(Ranks);
		}

		public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
		{
			Ranks ranks = new Ranks();

			string[] skillAbbrs = new string[] { "CMD", "DIP", "ENG", "MED", "SCI", "SEC" };

			if (reader.TokenType == JsonToken.Null)
				return null;

			var tokens = JToken.Load(reader);

			ranks.VoyageRank = tokens["voyRank"].Value<int>();
			ranks.GauntletRank = tokens["gauntletRank"].Value<int>();
			ranks.ChronCostRank = tokens["chronCostRank"].Value<int>();

			foreach (string skillOne in skillAbbrs) {
				string token = "B_" + skillOne;
				if (tokens[token] != null) {
					InsertRank(ranks.BaseRanks, token, tokens[token].Value<int>());
				}

				token = "A_" + skillOne;
				if (tokens["A_" + skillOne] != null)
				{
					InsertRank(ranks.AverageRanks, token, tokens[token].Value<int>());
				}
				
				foreach(string skillTwo in skillAbbrs) {
					token = "V_" + skillOne + "_" + skillTwo;
					if (tokens[token] != null) {
						InsertPairRank(ranks.VoyagePairRanks, token, tokens[token].Value<int>());
					}

					token = "G_" + skillOne + "_" + skillTwo;
					if (tokens[token] != null)
					{
						InsertPairRank(ranks.GauntletPairRanks, token, tokens[token].Value<int>());
					}
				}
			}

			return ranks;
		}

		private static void InsertPairRank(List<PairRank> ranks, string token, int rank)
		{
			string[] tokenParts = token.Split('_');
			string skillName1 = GetSkillName(tokenParts[1]);
			string skillName2 = GetSkillName(tokenParts[2]);
			ranks.Add(new PairRank()
			{
				SkillName1 = skillName1,
				SkillName2 = skillName2,
				Rank = rank
			});
		}

		private static string GetSkillName(string skillToken)
		{
			switch (skillToken)
			{
				case "CMD": return "CommandSkill";
				case "DIP": return "DiplomacySkill";
				case "END": return "EngineeringSkill";
				case "MED": return "MedicineSkill";
				case "SCI": return "ScienceSkill";
				case "SEC": return "SecuritySkill";
				default: return skillToken;
			}
		}

		private static void InsertRank(List<SkillRank> baseRanks, string token, int rank)
		{
			string[] tokenParts = token.Split('_');
			string skillName = GetSkillName(tokenParts[1]);
			baseRanks.Add(new SkillRank()
			{
				SkillName = skillName,
				Rank = rank
			});
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			throw new Exception("Cannot marshal type Ranks");
		}

		public static readonly RanksConverter Singleton = new RanksConverter();
	}
}
