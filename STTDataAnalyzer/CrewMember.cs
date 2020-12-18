using System;
using System.Collections.Generic;
using System.Text;

namespace STTDataAnalyzer
{
	public class CrewMember : IComparable
	{
		public SttUser.Crew Crew;
		public int[] VoyageScores;

		public CrewMember(SttUser.Crew c)
		{
			this.Crew = c;
			this.VoyageScores = new int[12];
		}

		public int CompareTo(object obj)
		{
			if (obj == null) return 1;

			CrewMember cm = obj as CrewMember;
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
