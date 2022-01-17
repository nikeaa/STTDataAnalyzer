using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using STTDataAnalyzer.Models.PlayerData;

namespace Windows_UI
{
    public partial class Form1 : Form
    {
        PlayerData playerData = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get player data from JSON.
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.MissingMemberHandling = MissingMemberHandling.Error;

            string FileName = ConfigurationManager.AppSettings["PlayerDataFileName"];
            string FileNameAndPath = Directory.GetCurrentDirectory() + "\\Data\\" + FileName;
            string jsonString = File.ReadAllText(FileNameAndPath);

            playerData = PlayerData.FromJson(jsonString);

            // Populate dropdowns with values from enums.
            var skillList = Enum.GetValues(typeof(SkillsEnum)).Cast<SkillsEnum>().ToList();
            var skillList2 = Enum.GetValues(typeof(SkillsEnum)).Cast<SkillsEnum>().ToList();
            var skillList3 = Enum.GetValues(typeof(SkillsEnum)).Cast<SkillsEnum>().ToList();
            var traitList = voyageTraitsSkills.Keys.ToList();
            traitList.Insert(0, "None");

            ddlPrimarySkill.DataSource = skillList;
            ddlSecondarySkill.DataSource = skillList2;
            ddlSlotSkill.DataSource = skillList3;
            ddlSlotTrait.DataSource = traitList;
        }

        public static Dictionary<string, int> voyageTraitsSkills = new Dictionary<string, int>()
        {
            { "astrophysicist",         0b110110 },
            { "bajoran",                0b111000 },
            { "borg",                   0b001110 },
            { "brutal",                 0b111110 },
            { "cardassian",             0b111000 },
            { "civilian",               0b111111 },
            { "communicator",           0b111000 },
            { "costumed",               0b111110 },
            { "crafty",                 0b111010 },
            { "cultural_figure",        0b111000 },
            { "cyberneticist",          0b000110 },
            { "desperate",              0b111110 },
            { "diplomat",               0b111000 },
            { "duelist",                0b111000 },
            { "exobiology",             0b000010 },
            { "explorer",               0b100000 },
            { "federation",             0b111111 },
            { "ferengi",                0b010000 },
            { "gambler",                0b111000 },
            { "hero",                   0b111000 },
            { "hologram",               0b110011 },
            { "human",                  0b111111 },
            { "hunter",                 0b101000 },
            { "innovator",              0b100110 },
            { "inspiring",              0b111000 },
            { "jury_rigger",            0b101100 },
            { "klingon",                0b111000 },
            { "marksman",               0b001000 },
            { "maverick",               0b111000 },
            { "physician",              0b010011 },
            { "pilot",                  0b101100 },
            { "prodigy",                0b000110 },
            { "resourceful",            0b111110 },
            { "romantic",               0b111110 },
            { "romulan",                0b011000 },
            { "saboteur",               0b101000 },
            { "starfleet",              0b111111 },
            { "survivalist",            0b111000 },
            { "tactician",              0b111110 },
            { "telepath",               0b111010 },
            { "undercover_operative",   0b111010 },
            { "veteran",                0b111000 },
            { "villain",                0b111000 },
            { "vulcan",                 0b111010 }
        };

        private void btnFindCrew_Click(object sender, EventArgs e)
        {
            lbResults.Items.Clear();

            if (ddlPrimarySkill.SelectedIndex > 0 && ddlSecondarySkill.SelectedIndex > 0 && ddlSlotSkill.SelectedIndex > 0 && ddlSlotTrait.SelectedIndex > 0)
            {
                string primarySkillName = ddlPrimarySkill.SelectedValue.ToString();
                string secondarySkillName = ddlSecondarySkill.SelectedValue.ToString();
                string slotSkillName = ddlSlotSkill.SelectedValue.ToString();
                string slotTraitName = ddlSlotSkill.SelectedValue.ToString();

                IOrderedEnumerable<Crew> list = playerData.Player.Character.Crew.Where(c => c.HasSkill(slotSkillName)).OrderByDescending(c => c.WeightedVoyageScore(primarySkillName, secondarySkillName, slotTraitName));

                foreach (Crew item in list)
                {
                    lbResults.Items.Add(item.WeightedVoyageScore(primarySkillName, secondarySkillName, slotTraitName) + " - " + item.Name + "\r\n");
                }
            }
        }   
    }

    [Flags]
    public enum SkillsEnum
    {
        None = 0,
        Medicine = 1,
        Science = 2,
        Engineering = 4,
        Security = 8,
        Diplomacy = 16,
        Command = 32
    }
}
