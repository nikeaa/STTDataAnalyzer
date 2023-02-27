using STTDataAnalyzer.Models.PlayerData;
using System;

namespace STTDataAnalyzer.Models

{
	public class CrewMemberComparable : IComparable
	{
		public Crew Crew;
		public int[] VoyageScores;

		public CrewMemberComparable(Crew c)
		{
			this.Crew = c;
			this.VoyageScores = new int[12];
		}

		public int CompareTo(object obj)
		{
			if (obj == null) return 1;

			CrewMemberComparable cm = obj as CrewMemberComparable;
			if (cm != null)
			{
				if (this.VoyageScores[0] < cm.VoyageScores[0]) return -1;
				if (this.VoyageScores[0] > cm.VoyageScores[0]) return 1;
				return 0;
			}

			return 0;
		}
	}
}
