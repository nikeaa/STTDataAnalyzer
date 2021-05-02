using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace STTDataAnalyzer.Models.Static
{
	public class StaticData : BaseData
	{
		public BotCrew[] BotCrews;
		public Collection[] Collections;
		public Crew[] Crews;
		public Dilemma[] Dilemmas;
		public Dispute[] Disputes;
		public Episode[] Episodes;
		public EventFLeaderboard[] EventFLeaderboards;
		public EventInstance[] EventInstances;
		public EventLeaderboard[] EventLeaderboards;
		public Faction[] Factions;
		public Item[] Items;
		public Keystone[] Keystones;
		public MiscStats MiscStats;
		public Mission[] Missions;
		public Quest[] Quests;
		public ShipSchematic[] ShipSchematics;
		public SkillBuffs SkillBuffs;
		public UpcomingEvent[] UpcomingEvents;

		private const string BotCrewFileName = "botcrew.json";
		private const string CollectionFileName = "collections.json";
		private const string CrewFileName = "crew.json";
		private const string DilemmasFileName = "dilemmas.json";
		private const string DisputesFileName = "disputes.json";
		private const string EpisodesFileName = "episodes.json";
		private const string EventFLeaderboardsFileName = "event_fleaderboards.json";
		private const string EventInstancesFileName = "event_instances.json";
		private const string EventLeaderboardsFileName = "event_leaderboards.json";
		private const string FactionsFileName = "factions.json";
		private const string ItemsFileName = "items.json";
		private const string KeystonesFileName = "keystones.json";
		private const string MiscStatsFileName = "misc_stats.json";
		private const string MissionsFileName = "missions.json";
		private const string QuestsFileName = "quests.json";
		private const string ShipSchematicsFileName = "ship_schematics.json";
		private const string SkillBuffsFileName = "skill_bufs.json";
		private const string UpcomingEventsFileName = "upcomingevents.json";

		public StaticData(string botCrewFileName = BotCrewFileName, string collectionFileName = CollectionFileName, string crewFileName = CrewFileName,
			string dilemasFileName = DilemmasFileName, string disputesFileName = DisputesFileName, string episodesFileName = EpisodesFileName,
			string eventfLeaderboardsFileName = EventFLeaderboardsFileName, string eventInstancesFileName = EventInstancesFileName,
			string eventLeaderboardsFileName = EventLeaderboardsFileName, string factionsFileName = FactionsFileName, string itemsFileName = ItemsFileName,
			string keystonesFileName = KeystonesFileName, string miscStatsFileName = MiscStatsFileName, string missionsFileName = MissionsFileName,
			string questsFileName = QuestsFileName, string shipSchematicsFileName = ShipSchematicsFileName, string skillBuffsFileName = SkillBuffsFileName,
			string upcomingEventsFileName = UpcomingEventsFileName)
		{
			BotCrews = JsonConvert.DeserializeObject<BotCrew[]>(File.ReadAllText(Path + botCrewFileName));
			Collections = JsonConvert.DeserializeObject<Collection[]>(File.ReadAllText(Path + collectionFileName));
			Crews = JsonConvert.DeserializeObject<Crew[]>(File.ReadAllText(Path + crewFileName));
			Dilemmas = JsonConvert.DeserializeObject<Dilemma[]>(File.ReadAllText(Path + dilemasFileName));
			Disputes = JsonConvert.DeserializeObject<Dispute[]>(File.ReadAllText(Path + disputesFileName));
			Episodes = JsonConvert.DeserializeObject<Episode[]>(File.ReadAllText(Path + episodesFileName));
			EventFLeaderboards = JsonConvert.DeserializeObject<EventFLeaderboard[]>(File.ReadAllText(Path + eventfLeaderboardsFileName));
			EventInstances = JsonConvert.DeserializeObject<EventInstance[]>(File.ReadAllText(Path + eventInstancesFileName));
			EventLeaderboards = JsonConvert.DeserializeObject<EventLeaderboard[]>(File.ReadAllText(Path + eventLeaderboardsFileName));
			Factions = JsonConvert.DeserializeObject<Faction[]>(File.ReadAllText(Path + factionsFileName));
			Items = JsonConvert.DeserializeObject<Item[]>(File.ReadAllText(Path + itemsFileName));
			Keystones = JsonConvert.DeserializeObject<Keystone[]>(File.ReadAllText(Path + keystonesFileName));
			MiscStats = JsonConvert.DeserializeObject<MiscStats>(File.ReadAllText(Path + miscStatsFileName));
			Missions = JsonConvert.DeserializeObject<Mission[]>(File.ReadAllText(Path + missionsFileName));
			Quests = JsonConvert.DeserializeObject<Quest[]>(File.ReadAllText(Path + questsFileName));
			ShipSchematics = JsonConvert.DeserializeObject<ShipSchematic[]>(File.ReadAllText(Path + shipSchematicsFileName));
			SkillBuffs = JsonConvert.DeserializeObject<SkillBuffs>(File.ReadAllText(Path + skillBuffsFileName));
			UpcomingEvents = JsonConvert.DeserializeObject<UpcomingEvent[]>(File.ReadAllText(Path + upcomingEventsFileName));
		}
	}
}
