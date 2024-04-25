using System;
using BepInEx.Configuration;

namespace Josiwe.ATS.Cheats
{
    public class CheatConfig
    {
        public CheatConfig() { }

        #region World Map
        public float ZoomMultiplier = 7.0f;
        public bool AllRacesInWorldMap = false;
        public int BonusPreparationPoints = 0;
        #endregion


        #region Game Map
        public bool WildcardBlueprints = false;
        public bool InfiniteCornerstoneRerolls = false;
        public float ResolveMultiplier = 1.0f;
        public float ReputationMutiplier = 1.0f;
        public float ImpatienceMultiplier = 1.0f;
        public int ReputationStopgap = 0;
        public int ImpatienceStopgap = 0;
        public int MoarMaxReputation = 0;
        public int MoarMaxImpatience = 0;
        public int BlueprintsMultiplier = 1;
        public int CashRewardMultiplier = 1;
        public int CornerstonePicksPerSeason = 1;
        public bool EnableAllBuildingsMoving = false;
        #endregion

        #region Season Rewards
        public bool MoarSeasonRewards = false;
        public float StormLengthMultiplier = 1.0f;
        public float DrizzleLengthMultiplier = 1.0f;
        public float ClearanceLengthMultiplier = 1.0f;
        #endregion

        // Each description contains hints (plucked from the game's code) about the defaul values.
        #region Prestige Difficulties
        // Longer Storm - One of the seals is loosening its grip, leaking darkness upon this land. Storm season lasts 100% longer.
        public float Prestige_2_Amount = 1.0f;
        // Higher Blueprints Reroll Cost - The Archivist assigned to your settlement is fiercely loyal to the Royal Court, so bribing him will be more expensive. Blueprint rerolls cost 10 Amber more.
        public int Prestige_4_Amount = 10;
        // Faster Leaving - Villagers are less understanding than they used to be. They’re probably getting a bit spoiled by now. Villagers are 100% faster to leave if they have low Resolve.
        public float Prestige_5_Amount = 1.0f;
        // Wet Soil - It's particularly hard to build anything in this region. Buildings require 50% more materials.
        public float Prestige_6_Amount = 0.5f;
        // Parasites - One of the villagers was sick, and infected the rest of the settlement with a parasite. All villagers have a 50% chance of eating twice as much during their break.
        public float Prestige_7_Amount = 0.5f;
        // Higher Needs Consumption Rate - Villagers have forgotten what a modest life looks like. They want to enjoy life to the fullest. Villagers have a 50% chance to consume double the amount of luxury goods.
        public float Prestige_8_Amount = 0.5f;
        // Longer Relics Working Time - Villagers are reluctant to venture into Dangerous Glades. Scouts work 33% slower on Glade Events.
        public float Prestige_9_Amount = -0.33f;
        // Higher Traders Prices - Traders gossip about you doing pretty well lately. All your goods are worth 50% less to traders.
        public float Prestige_10_Amount = -0.5f;
        // Fewer Blueprints Options - The greedy Royal Archivist sold most of the blueprints to traders and fled the Citadel. You have 2 fewer blueprint choices.
        public int Prestige_12_Amount = -2;
        // Fewer Cornerstones Options - The Royal Envoy comes to you with bad news. The Queen has restricted your cornerstone choices by 2.
        public int Prestige_13_Amount = 2;
        // Lower Impatience Reduction - The Queen expects a lot from a viceroy of your rank. Impatience falls by 0.5 points less for every Reputation point you gain.
        public float Prestige_14_Amount = 0.5f;
        // Global Reputation Treshold Increase - You took a very peculiar group of settlers with you. They seem perpetually dissatisfied. The Resolve threshold at which each species starts producing Reputation increases by 1 more point for every Reputation point they generate.
        public int Prestige_15_Amount = 1;
        // Hunger Multiplier Effects - Famine outbreaks in your previous settlements have made the villagers particularly sensitive to food shortages. Every time villagers have nothing to eat during a break, they will gain two stacks of the Hunger effect instead of one.        
        public int Prestige_17_Amount = 1;
        // Faster Fuel Sacrifice - The Ancient Hearth seems to have a defect. No matter how hard the firekeeper tries, sacrificed resources are burning 35% quicker.        
        public float Prestige_18_Amount = -0.35f;
        #endregion

        private string m_CurrentSection = null;
        private bool m_LoadedFromJSON = true;

        public void LoadedFromJSON()
        {
            m_LoadedFromJSON = true;
        }
        
        public void ReadValues()
        {
            Section("World Rewards");
            Init(ref ZoomMultiplier, "ZoomMultiplier", 7.0f, "Increases how far the zoom goes");
            Init(ref AllRacesInWorldMap, "AllRacesInWorldMap", false, "");
            Init(ref BonusPreparationPoints, "BonusPreparationPoints", 0, "Adds additional embark points"); 
            
            Section("Season Rewards");
            Init(ref WildcardBlueprints, "WildcardBlueprints", false, "");
            Init(ref InfiniteCornerstoneRerolls, "InfiniteCornerstoneRerolls", false, "");
            Init(ref ResolveMultiplier, "ResolveMultiplier", 1.0f, "");
            Init(ref ReputationMutiplier, "ReputationMutiplier", 1.0f, "");
            Init(ref ImpatienceMultiplier, "ImpatienceMultiplier", 1.0f, "");
            Init(ref ReputationStopgap, "ReputationStopgap", 0, "");
            Init(ref ImpatienceStopgap, "ImpatienceStopgap", 0, "");
            Init(ref MoarMaxReputation, "MoarMaxReputation", 0, "");
            Init(ref MoarMaxImpatience, "MoarMaxImpatience", 0, "");
            Init(ref BlueprintsMultiplier, "BlueprintsMultiplier", 0, "");
            Init(ref CashRewardMultiplier, "CashRewardMultiplier", 0, "");
            Init(ref CornerstonePicksPerSeason, "CornerstonePicksPerSeason", 0, "");
            Init(ref EnableAllBuildingsMoving, "EnableAllBuildingsMoving", false, ""); 
            
            Section("Prestige Difficulties");      
            Init(ref Prestige_2_Amount, "Prestige_2_Amount", 1.0f, "Longer Storm - One of the seals is loosening its grip, leaking darkness upon this land. Storm season lasts 100% longer.");
            Init(ref Prestige_4_Amount, "Prestige_4_Amount", 10, "Higher Blueprints Reroll Cost - The Archivist assigned to your settlement is fiercely loyal to the Royal Court, so bribing him will be more expensive. Blueprint rerolls cost 10 Amber more.");
            Init(ref Prestige_5_Amount, "Prestige_5_Amount", 1.0f, "Faster Leaving - Villagers are less understanding than they used to be. They’re probably getting a bit spoiled by now. Villagers are 100% faster to leave if they have low Resolve.");
            Init(ref Prestige_6_Amount, "Prestige_6_Amount", 0.5f, "Wet Soil - It's particularly hard to build anything in this region. Buildings require 50% more materials.");
            Init(ref Prestige_7_Amount, "Prestige_7_Amount", 0.5f, "Parasites - One of the villagers was sick, and infected the rest of the settlement with a parasite. All villagers have a 50% chance of eating twice as much during their break.");
            Init(ref Prestige_8_Amount, "Prestige_8_Amount", 0.5f, "Higher Needs Consumption Rate - Villagers have forgotten what a modest life looks like. They want to enjoy life to the fullest. Villagers have a 50% chance to consume double the amount of luxury goods.");
            Init(ref Prestige_9_Amount, "Prestige_9_Amount", -0.33f, "Longer Relics Working Time - Villagers are reluctant to venture into Dangerous Glades. Scouts work 33% slower on Glade Events.");
            Init(ref Prestige_10_Amount, "Prestige_10_Amount", -0.5f, "Higher Traders Prices - Traders gossip about you doing pretty well lately. All your goods are worth 50% less to traders.");
            Init(ref Prestige_12_Amount, "Prestige_12_Amount", -2, "Fewer Blueprints Options - The greedy Royal Archivist sold most of the blueprints to traders and fled the Citadel. You have 2 fewer blueprint choices.");
            Init(ref Prestige_13_Amount, "Prestige_13_Amount", 2, "Fewer Cornerstones Options - The Royal Envoy comes to you with bad news. The Queen has restricted your cornerstone choices by 2.");
            Init(ref Prestige_14_Amount, "Prestige_14_Amount", 0.5f, "Lower Impatience Reduction - The Queen expects a lot from a viceroy of your rank. Impatience falls by 0.5 points less for every Reputation point you gain.");
            Init(ref Prestige_15_Amount, "Prestige_15_Amount", 1, "Global Reputation Treshold Increase - You took a very peculiar group of settlers with you. They seem perpetually dissatisfied. The Resolve threshold at which each species starts producing Reputation increases by 1 more point for every Reputation point they generate.");
            Init(ref Prestige_17_Amount, "Prestige_17_Amount", 1, "Hunger Multiplier Effects - Famine outbreaks in your previous settlements have made the villagers particularly sensitive to food shortages. Every time villagers have nothing to eat during a break, they will gain two stacks of the Hunger effect instead of one.");
            Init(ref Prestige_18_Amount, "Prestige_18_Amount", -0.35f, "Faster Fuel Sacrifice - The Ancient Hearth seems to have a defect. No matter how hard the firekeeper tries, sacrificed resources are burning 35% quicker.");
        
            Section("Season Rewards");
            Init(ref MoarSeasonRewards, "MoarSeasonRewards", false, "Gives more seasoning rewards!");
            Init(ref StormLengthMultiplier, "StormLengthMultiplier", 1.0f, "Extends how long the Storm season lasts!");
            Init(ref DrizzleLengthMultiplier, "DrizzleLengthMultiplier", 1.0f, "Extends how long the Drizzle season lasts!");
            Init(ref ClearanceLengthMultiplier, "ClearanceLengthMultiplier", 1.0f, "Extends how long the Clearance season lasts!");

            if (m_LoadedFromJSON)
            {
                // Save the changes to BepInEx if we loaded from JSON
                Plugin.Instance.Config.Save();
            }
        }

        private void Section(string seasonRewards)
        {
            m_CurrentSection = seasonRewards;
        }
        
        private void Init<T>(ref T entry, string key, T defaultValue, string description)
        {
            ConfigEntry<T> bind = Bind(m_CurrentSection, key, defaultValue, description); // Get the entry from BepInEx configs
            if (m_LoadedFromJSON)
            {
                // Set BepInEx value with JSON
                bind.Value = entry;
            }
            else
            {
                // Loaded form ThunderStore so load values from ThunderStore
                entry = bind.Value; // Change the value in our code
            }
        }
        
        private ConfigEntry<T> Bind<T>(string section, string key, T defaultValue, string description)
        {
            return Plugin.Instance.Config.Bind(section, key, defaultValue, new ConfigDescription(description, null, Array.Empty<object>()));
        }
    }
}
