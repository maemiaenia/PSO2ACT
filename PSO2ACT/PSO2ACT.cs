using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using Advanced_Combat_Tracker;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Net;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace PSO2ACT
{    
    namespace Extensions.Colors
    {
        public static class ChartColorPallets
        {

            public static List<Color> Bright
                => new List<Color>() {
                "#008000".FromHex(),
                "#0000FF".FromHex(),
                "#800080".FromHex(),
                "#00FF00".FromHex(),
                "#FF00FF".FromHex(),
                "#008080".FromHex(),
                "#FFFF00".FromHex(),
                "#808080".FromHex(),
                "#00FFFF".FromHex(),
                "#000080".FromHex(),
                "#800000".FromHex(),
                "#FF0000".FromHex(),
                "#808000".FromHex(),
                "#C0C0C0".FromHex(),
                "#FF6347".FromHex(),
                "#FFE4B5".FromHex()
            };
            public static List<Color> GreyScale
                => new List<Color>() {
                "#C8C8C8".FromHex(),
                "#BDBDBD".FromHex(),
                "#B2B2B2".FromHex(),
                "#A7A7A7".FromHex(),
                "#9C9C9C".FromHex(),
                "#919191".FromHex(),
                "#868686".FromHex(),
                "#7B7B7B".FromHex(),
                "#707070".FromHex(),
                "#656565".FromHex(),
                "#5A5A5A".FromHex(),
                "#4F4F4F".FromHex(),
                "#444444".FromHex(),
                "#393939".FromHex(),
                "#2E2E2E".FromHex(),
                "#232323".FromHex()
            };
            public static List<Color> Excel
                => new List<Color>() {
                "#9999FF".FromHex(),
                "#993366".FromHex(),
                "#FFFFCC".FromHex(),
                "#CCFFFF".FromHex(),
                "#660066".FromHex(),
                "#FF8080".FromHex(),
                "#0066CC".FromHex(),
                "#CCCCFF".FromHex(),
                "#000080".FromHex(),
                "#FF00FF".FromHex(),
                "#FFFF00".FromHex(),
                "#00FFFF".FromHex(),
                "#800080".FromHex(),
                "#800000".FromHex(),
                "#008080".FromHex(),
                "#0000FF".FromHex()
            };
            public static List<Color> Light
                => new List<Color>() {
                "#E6E6FA".FromHex(),
                "#FFF0F5".FromHex(),
                "#FFDAB9".FromHex(),
                "#FFFACD".FromHex(),
                "#FFE4E1".FromHex(),
                "#F0FFF0".FromHex(),
                "#F0F8FF".FromHex(),
                "#F5F5F5".FromHex(),
                "#FAEBD7".FromHex(),
                "#E0FFFF".FromHex()
            };
            public static List<Color> Pastel
                => new List<Color>() {
                "#87CEEB".FromHex(),
                "#32CD32".FromHex(),
                "#BA55D3".FromHex(),
                "#F08080".FromHex(),
                "#4682B4".FromHex(),
                "#9ACD32".FromHex(),
                "#40E0D0".FromHex(),
                "#FF69B4".FromHex(),
                "#F0E68C".FromHex(),
                "#D2B48C".FromHex(),
                "#8FBC8B".FromHex(),
                "#6495ED".FromHex(),
                "#DDA0DD".FromHex(),
                "#5F9EA0".FromHex(),
                "#FFDAB9".FromHex(),
                "#FFA07A".FromHex()
            };
            public static List<Color> EarthTones
                => new List<Color>() {
                "#FF8000".FromHex(),
                "#B8860B".FromHex(),
                "#C04000".FromHex(),
                "#6B8E23".FromHex(),
                "#CD853F".FromHex(),
                "#C0C000".FromHex(),
                "#228B22".FromHex(),
                "#D2691E".FromHex(),
                "#808000".FromHex(),
                "#20B2AA".FromHex(),
                "#F4A460".FromHex(),
                "#00C000".FromHex(),
                "#8FBC8B".FromHex(),
                "#B22222".FromHex(),
                "#8B4513".FromHex(),
                "#C00000".FromHex()
            };
            public static List<Color> SemiTransparent
                => new List<Color>() {
                "#FF0000".FromHex(),
                "#00FF00".FromHex(),
                "#0000FF".FromHex(),
                "#FFFF00".FromHex(),
                "#00FFFF".FromHex(),
                "#FF00FF".FromHex(),
                "#AA7814".FromHex(),
                "#FF0000".FromHex(),
                "#00FF00".FromHex(),
                "#0000FF".FromHex(),
                "#FFFF00".FromHex(),
                "#00FFFF".FromHex(),
                "#FF00FF".FromHex(),
                "#AA7814".FromHex(),
                "#647832".FromHex(),
                "#285A96".FromHex()
            };
            public static List<Color> Berry
                => new List<Color>() {
                "#8A2BE2".FromHex(),
                "#BA55D3".FromHex(),
                "#4169E1".FromHex(),
                "#C71585".FromHex(),
                "#0000FF".FromHex(),
                "#8A2BE2".FromHex(),
                "#DA70D6".FromHex(),
                "#7B68EE".FromHex(),
                "#C000C0".FromHex(),
                "#0000CD".FromHex(),
                "#800080".FromHex()
            };
            public static List<Color> Chocolate
                => new List<Color>() {
                "#A0522D".FromHex(),
                "#D2691E".FromHex(),
                "#8B0000".FromHex(),
                "#CD853F".FromHex(),
                "#A52A2A".FromHex(),
                "#F4A460".FromHex(),
                "#8B4513".FromHex(),
                "#C04000".FromHex(),
                "#B22222".FromHex(),
                "#B65C3A".FromHex()
            };
            public static List<Color> Fire
                => new List<Color>() {
                "#FFD700".FromHex(),
                "#FF0000".FromHex(),
                "#FF1493".FromHex(),
                "#DC143C".FromHex(),
                "#FF8C00".FromHex(),
                "#FF00FF".FromHex(),
                "#FFFF00".FromHex(),
                "#FF4500".FromHex(),
                "#C71585".FromHex(),
                "#DDE221".FromHex()
            };
            public static List<Color> SeaGreen
                => new List<Color>() {
                "#2E8B57".FromHex(),
                "#66CDAA".FromHex(),
                "#4682B4".FromHex(),
                "#008B8B".FromHex(),
                "#5F9EA0".FromHex(),
                "#3CB371".FromHex(),
                "#48D1CC".FromHex(),
                "#B0C4DE".FromHex(),
                "#8FBC8B".FromHex(),
                "#87CEEB".FromHex()
            };
            public static List<Color> BrightPastel
                => new List<Color>() {
                "#418CF0".FromHex(),
                "#FCB441".FromHex(),
                "#E0400A".FromHex(),
                "#056492".FromHex(),
                "#BFBFBF".FromHex(),
                "#1A3B69".FromHex(),
                "#FFE382".FromHex(),
                "#129CDD".FromHex(),
                "#CA6B4B".FromHex(),
                "#005CDB".FromHex(),
                "#F3D288".FromHex(),
                "#506381".FromHex(),
                "#F1B9A8".FromHex(),
                "#E0830A".FromHex(),
                "#7893BE".FromHex()
            };
            private static Color FromHex(this string hex) => ColorTranslator.FromHtml(hex);
        }
    }

    public class PSO2ACT : IActPluginV1
    {
        config Config;
        Label lblStatus;
        string settingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\PluginPSO2.config.xml");
        SettingsSerializer xmlSettings;
        static ushort currInstID = 0xFFFF;
        static string charName = "";
        static uint charID = 0;
        Thread logThread;
        DateTime tLastActionTime = new DateTime();
        string sPluginDir = "";
        MasterSwing oLastAction = null;
        EncounterData oLastEncounter = null;
        
        struct Skill
        {
            public string Name;
            public string Type;
            public string Comment;
        }

        Dictionary<uint, Skill> skillDict = new Dictionary<uint, Skill>();
        Dictionary<string, uint> revSkillDict = new Dictionary<string, uint>();
        Dictionary<uint, Skill> noJADict = new Dictionary<uint, Skill>();

        Dictionary<uint, string> MainClassLookup = new Dictionary<uint, string>();
        Dictionary<uint, string> ClassLookup = new Dictionary<uint, string>();
        Dictionary<uint, string> WeaponLookup = new Dictionary<uint, string>();

        Dictionary<string, Dictionary<string, int>> oPlayerJA = new Dictionary<string, Dictionary<string, int>>();
        Dictionary<string, Dictionary<string, Dictionary<string, int>>> oPlayerData = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
        List<MSCopy> oActionList = new List<MSCopy>();
        List<ushort> nOriginalInstance = new List<ushort>();
        Dictionary<string, Dictionary<string, long>> oPlayerMaxHit = new Dictionary<string, Dictionary<string, long>>();

        List<MSCopy> oBeforeZoneChange = new List<MSCopy>();

        Bitmap oEncounterBitmap = null;

        int nIconWidth = 0;
        int nIconHeight = 0;

        Image oIcon_Disc = null;
        Image oIcon_MusicDisc = null;

        Image oIcon_Class_HU = null;
        Image oIcon_Class_RA = null;
        Image oIcon_Class_FO = null;
        Image oIcon_Class_FI = null;
        Image oIcon_Class_GU = null;
        Image oIcon_Class_TE = null;
        Image oIcon_Class_BR = null;
        Image oIcon_Class_BO = null;
        Image oIcon_Class_SU = null;
        Image oIcon_Class_HR = null;
        Image oIcon_Class_PH = null;
        Image oIcon_Class_ET = null;

        Image oIcon_Weapon_Gunslash = null;
        Image oIcon_Weapon_Sword = null;
        Image oIcon_Weapon_Partisan = null;
        Image oIcon_Weapon_WireLance = null;
        Image oIcon_Weapon_Rifle = null;
        Image oIcon_Weapon_Launcher = null;
        Image oIcon_Weapon_Rod = null;
        Image oIcon_Weapon_Talis = null;
        Image oIcon_Weapon_Knuckle = null;
        Image oIcon_Weapon_TwinDagger = null;
        Image oIcon_Weapon_DoubleSaber = null;
        Image oIcon_Weapon_TwinMachinegun = null;
        Image oIcon_Weapon_Wand = null;
        Image oIcon_Weapon_Katana = null;
        Image oIcon_Weapon_BulletBow = null;
        Image oIcon_Weapon_DualBlades = null;
        Image oIcon_Weapon_JetBoots = null;
        Image oIcon_Weapon_Tact = null;
        Image oIcon_Pets = null;

        Image oIcon_Technique_Foie = null;
        Image oIcon_Technique_Barta = null;
        Image oIcon_Technique_Zonde = null;
        Image oIcon_Technique_Zan = null;
        Image oIcon_Technique_Grants = null;
        Image oIcon_Technique_Megid = null;
        Image oIcon_Technique_Compound = null;

        Image oIcon_DarkBlast = null;
        Image oIcon_SClassAffix = null;

        public void DeInitPlugin()
        {
            SaveSettings();
            logThread.Abort();
            ActGlobals.oFormActMain.BeforeLogLineRead -= oFormActMain_BeforeLogLineRead;
            lblStatus.Text = "Plugin Exited";
        }

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            Config = new config();
            lblStatus = pluginStatusText;
            pluginScreenSpace.Controls.Add(Config);
            xmlSettings = new SettingsSerializer(Config);
            LoadSettings();
            Config.selectedFolder = Config.Controls["directory"].Text;
            lblStatus.Text = "Loaded PSO2ACT Plugin";

            if (ActGlobals.oFormActMain.GetAutomaticUpdatesAllowed())
                new Thread(oFormActMain_UpdateCheckClicked).Start();
            else
                Config.refreshFlag = true;

            ActGlobals.oFormActMain.GetDateTimeFromLog = ParseDateTime;
            ActGlobals.oFormActMain.BeforeLogLineRead += new LogLineEventDelegate(oFormActMain_BeforeLogLineRead);

            ActGlobals.oFormActMain.GenerateEncounterGraph = GenerateEncounterGraph;

            ActGlobals.oFormActMain.LogFileChanged += new LogFileChangedDelegate(LogFileChangedEvent);

            sPluginDir = ActGlobals.oFormActMain.PluginGetSelfData(this).pluginFile.DirectoryName;

            oActionList.Clear();
            nOriginalInstance.Clear();
            oPlayerJA.Clear();
            oPlayerData.Clear();
            oPlayerMaxHit.Clear();

            oBeforeZoneChange.Clear();

            Button oClicktoEnd = new Button();
            oClicktoEnd.Text = "END ENCOUNTER";
            oClicktoEnd.Height = 24;
            oClicktoEnd.Width = 150;
            oClicktoEnd.Click += new EventHandler(EncounterEnd_Click);
            ActGlobals.oFormActMain.CornerControlAdd(oClicktoEnd);

            try
            {
                InitializeSkillDict();
                logThread = new Thread(this.LogThread);
                logThread.Start();
            }
            catch (Exception ex)
            {
                ActGlobals.oFormActMain.WriteExceptionLog(ex, "Error while Initializing Skill Dictionaries!");
            }

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.Disc.png");
            oIcon_Disc = Image.FromStream(myStream);

            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.MusicDisc.png");
            oIcon_MusicDisc = Image.FromStream(myStream);

            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.ClassIcon-HU.png");
            oIcon_Class_HU = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.ClassIcon-RA.png");
            oIcon_Class_RA = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.ClassIcon-FO.png");
            oIcon_Class_FO = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.ClassIcon-FI.png");
            oIcon_Class_FI = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.ClassIcon-GU.png");
            oIcon_Class_GU = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.ClassIcon-TE.png");
            oIcon_Class_TE = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.ClassIcon-BR.png");
            oIcon_Class_BR = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.ClassIcon-BO.png");
            oIcon_Class_BO = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.ClassIcon-SU.png");
            oIcon_Class_SU = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.ClassIcon-HR.png");
            oIcon_Class_HR = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.ClassIcon-PH.png");
            oIcon_Class_PH = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.ClassIcon-ET.png");
            oIcon_Class_ET = Image.FromStream(myStream);

            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-Gunslash.png");
            oIcon_Weapon_Gunslash = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-Sword.png");
            oIcon_Weapon_Sword = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-Partisan.png");
            oIcon_Weapon_Partisan = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-WireLance.png");
            oIcon_Weapon_WireLance = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-Rifle.png");
            oIcon_Weapon_Rifle = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-Launcher.png");
            oIcon_Weapon_Launcher = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-Rod.png");
            oIcon_Weapon_Rod = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-Talis.png");
            oIcon_Weapon_Talis = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-Knuckle.png");
            oIcon_Weapon_Knuckle = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-TwinDagger.png");
            oIcon_Weapon_TwinDagger = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-DoubleSaber.png");
            oIcon_Weapon_DoubleSaber = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-TwinMachinegun.png");
            oIcon_Weapon_TwinMachinegun = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-Wand.png");
            oIcon_Weapon_Wand = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-Katana.png");
            oIcon_Weapon_Katana = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-BulletBow.png");
            oIcon_Weapon_BulletBow = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-DualBlades.png");
            oIcon_Weapon_DualBlades = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-JetBoots.png");
            oIcon_Weapon_JetBoots = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.WeaponIcon-Tact.png");
            oIcon_Weapon_Tact = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.Pets.png");
            oIcon_Pets = Image.FromStream(myStream);

            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.TechniqueIcon-Foie.png");
            oIcon_Technique_Foie = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.TechniqueIcon-Barta.png");
            oIcon_Technique_Barta = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.TechniqueIcon-Zonde.png");
            oIcon_Technique_Zonde = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.TechniqueIcon-Zan.png");
            oIcon_Technique_Zan = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.TechniqueIcon-Grants.png");
            oIcon_Technique_Grants = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.TechniqueIcon-Megid.png");
            oIcon_Technique_Megid = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.TechniqueIcon-Compound.png");
            oIcon_Technique_Compound = Image.FromStream(myStream);

            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.DarkBlast.png");
            oIcon_DarkBlast = Image.FromStream(myStream);
            myStream = myAssembly.GetManifestResourceStream("PSO2ACT.Icons.OtherIcon-S-ClassAffix.png");
            oIcon_SClassAffix = Image.FromStream(myStream);

            nIconWidth = oIcon_MusicDisc.Width;
            nIconHeight = oIcon_MusicDisc.Height;

            return;
        }

        // This fires AFTER a log file has been READ
        // Updates Zones and Resets all Lists
        void LogFileChangedEvent(bool IsImport, string NewLogFileName)
        {
            if (oActionList.Count > 0)
            {
                List<ZoneData> oZones = ActGlobals.oFormActMain.ZoneList;

                foreach (ZoneData oZone in oZones)
                {
                    if (oZone.ZoneName == currInstID.ToString())
                    {
                        ActGlobals.oFormActMain.ActiveZone = oZone;
                        break;
                    }
                }

                EndOfCombat(false);
                if (oLastEncounter != null)
                    oLastEncounter.Title = "(Parsed)" + oLastEncounter.Title;
            }

            oActionList.Clear();
            nOriginalInstance.Clear();
            oPlayerJA.Clear();
            oPlayerData.Clear();
            oPlayerMaxHit.Clear();
        }
        
        // Since have to generate my own graph...
        Bitmap GenerateEncounterGraph(EncounterData EncounterSource, int SizeX, int SizeY, string Sorting)
        {
            if (oEncounterBitmap != null)
                oEncounterBitmap.Dispose();

            long nTotalDmg = 0;

            List<Color> oColorList = Extensions.Colors.ChartColorPallets.Pastel;

            Chart oEncounterGraph = new Chart();
            oEncounterGraph.Palette = ChartColorPalette.SemiTransparent;
            oEncounterGraph.Height = SizeY;
            oEncounterGraph.Width = SizeX;
            oEncounterGraph.BackColor = Color.FromArgb(222, 222, 222);
            
            ChartArea chA = new ChartArea();
            chA.BackColor = Color.FromArgb(222, 222, 222);
            chA.Name = "EncounterGraph";
            chA.AxisX.MaximumAutoSize = 100;
            chA.AxisX.IsMarginVisible = false;
            chA.AxisX.LabelStyle.Enabled = true;
            chA.AxisX.MajorTickMark.Enabled = false;
            chA.AxisX.MajorGrid.Enabled = true;
            chA.AxisY.MajorTickMark.Enabled = false;
            chA.AxisY.MajorGrid.Enabled = true;
            chA.AxisY.MajorGrid.LineColor = Color.LightGray;
            chA.AxisY.LabelStyle.Enabled = false;
            chA.AxisX2.Enabled = AxisEnabled.True;
            chA.AxisX2.LabelStyle.Enabled = true;
            chA.AxisX2.MajorTickMark.Enabled = false;
            chA.AxisX2.MajorGrid.Enabled = false;
            chA.AxisY2.Enabled = AxisEnabled.True;
            chA.AxisY2.LabelStyle.Enabled = false;
            chA.AxisY2.MajorTickMark.Enabled = false;
            chA.AxisY2.MajorGrid.Enabled = false;
            chA.Position.X = 0;
            chA.Position.Y = 12;
            chA.Position.Width = 100;
            chA.Position.Height = 76;

            oEncounterGraph.ChartAreas.Add(chA);

            IList<CombatantData> lPlayers = EncounterSource.GetAllies().AsReadOnly();
            Dictionary<long, string> lData = new Dictionary<long, string>();
            List<long> lDamage = new List<long>();
            Dictionary<long, string> lMaxData = new Dictionary<long, string>();
            long nZanverse = 0;

            try
            {
                if (lPlayers.Count > 0)
                {
                    foreach (CombatantData oPlayer in lPlayers)
                    {
                        if (IsPlayer(oPlayer.Name))
                        {
                            if (oPlayer.Damage > 0)
                            {
                                int nAdd = 1;
                                nTotalDmg += oPlayer.Damage;
                                string sMaxHit = oPlayer.GetMaxHit(true, false);

                                string sSkillName = "";
                                long lMaxDamage = 0;

                                if (sMaxHit.LastIndexOf("-") > 0)
                                {
                                    sSkillName = sMaxHit.Substring(0, sMaxHit.LastIndexOf("-"));
                                    lMaxDamage = Convert.ToInt64(sMaxHit.Substring(sMaxHit.LastIndexOf("-") + 1));
                                }

                                if (sSkillName.IndexOf("(JA :") > 0)
                                    sSkillName = sSkillName.Substring(0, sSkillName.IndexOf("(JA :")).Trim();
                                else
                                    sSkillName = sSkillName.Trim();

                                if (lData.ContainsKey(oPlayer.Damage))
                                {
                                    while (lData.ContainsKey(oPlayer.Damage + nAdd))
                                        nAdd += 1;
                                    lData.Add(oPlayer.Damage + nAdd, oPlayer.Name);
                                    lMaxData.Add(oPlayer.Damage + nAdd, sSkillName + " : " + lMaxDamage.ToString("N0"));
                                    lDamage.Add(oPlayer.Damage + nAdd);
                                }
                                else
                                {
                                    lData.Add(oPlayer.Damage, oPlayer.Name);
                                    lMaxData.Add(oPlayer.Damage, sSkillName + " : " + lMaxDamage.ToString("N0"));
                                    lDamage.Add(oPlayer.Damage);
                                }
                            }
                        }
                        else
                        {
                            if (oPlayer.Name == "◆ ◇ ◆ ◇ ◆ " + skillDict[(uint)2106601422].Name + " ◇ ◆ ◇ ◆ ◇")
                                nZanverse += oPlayer.Damage;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ActGlobals.oFormActMain.WriteExceptionLog(ex, "Graphing Exception - Trying to get Ally Data");
            }

            try
            {
                lDamage.Sort();
            }
            catch (Exception ex)
            {
                ActGlobals.oFormActMain.WriteExceptionLog(ex, "Graphing Exception - Trying to sort & reverse Ally Data");
            }

            oEncounterGraph.Titles.Add("Instance : " + EncounterSource.ZoneName + " - Duration : " + EncounterSource.DurationS + " - " + EncounterSource.StartTime.ToString());
            Title oTitle = oEncounterGraph.Titles.First();
            oTitle.Alignment = ContentAlignment.TopLeft;
            oTitle.Font = new System.Drawing.Font("Segoe UI", 14f);

            oEncounterGraph.Titles.Add("Zanverse : " + nZanverse.ToString("N0") + " - Total Damage : " + nTotalDmg.ToString("N0"));
            oTitle = oEncounterGraph.Titles[1];
            oTitle.Docking = Docking.Bottom;
            oTitle.Alignment = ContentAlignment.BottomRight;
            oTitle.Font = new System.Drawing.Font("Segoe UI", 14f);

            // This is so that the barchart will properly display the 1st and last items
            chA.AxisX.Minimum = -0.5;
            chA.AxisX.Maximum = lDamage.Count - 0.5;
            chA.AxisX2.Minimum = -0.5;
            chA.AxisX2.Maximum = lDamage.Count - 0.5;

            chA.AxisX.LabelStyle.Font = new System.Drawing.Font("MS UI Gothic", 11f, FontStyle.Regular);

            try
            {
                Series oBottom = new Series("Bottom");
                oBottom.ChartType = SeriesChartType.StackedBar;
                oBottom.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.No;

                Series oSeries = new Series("Players");
                oSeries.ChartType = SeriesChartType.StackedBar;
                oSeries.BorderColor = Color.Black;
                oSeries.BorderWidth = 1;
                oSeries["PointWidth"] = "1";
                oSeries.SmartLabelStyle.Enabled = false;

                int nPos = 0;
                foreach (long lDmg in lDamage)
                {
                    DataPoint oPoint = new DataPoint(nPos, lDmg);
                    DataPoint oPBottom = new DataPoint(nPos, 0);

                    string sName = lData[lDmg];
                    string sLabel = "";
                    string sXLabel = "";

                    if (sName == EncounterSource.CharName)
                    {
                        oPoint.BackSecondaryColor = Color.White;
                        oPoint.BackGradientStyle = GradientStyle.HorizontalCenter;
                    }

                    if (sName.Contains("●"))
                    {
                        string[] sParts = sName.Split('●');
                        if ((sParts.Count() > 2) && (sParts != null))
                        {
                            string sFirst = sParts[0];
                            string sJA = "";
                            sXLabel = sFirst;
                            sFirst = sFirst.Replace("・", "・\n");
                            sFirst = sFirst.Replace("。", "。\n");

                            try
                            {
                                sJA = sParts[1];
                                sJA = sJA.Trim();
                            }
                            catch (Exception ex)
                            {
                                ActGlobals.oFormActMain.WriteExceptionLog(ex, "Shouldn't happen... testing for sParts[1]");
                            }

                            sLabel = "DPS: " + (EncounterSource.GetCombatant(sName).DPS / 1000).ToString("0K").PadLeft(4) + "  ・  " + sJA + "  ・  Crit: " + EncounterSource.GetCombatant(sName).CritDamPerc.ToString("N0") + "%";
                        }
                        else
                        {
                            sXLabel = sName;
                            sLabel = sName;
                        }
                    }
                    else
                    {
                        sXLabel = sName;
                        string sFirst = sName;
                        sFirst = sFirst.Replace("・", "・\n");
                        sFirst = sFirst.Replace("。", "。\n");

                        sLabel = "DPS: " + (EncounterSource.GetCombatant(sName).DPS / 1000).ToString("0K").PadLeft(4) + "  ・  Crit: " + EncounterSource.GetCombatant(sName).CritDamPerc.ToString("N0") + "%";
                    }

                    oPoint.AxisLabel = sXLabel;
                    oPoint.IsValueShownAsLabel = false;
                    if (nPos > (oColorList.Count - 1))
                        oPoint.Color = oColorList[nPos - oColorList.Count];
                    else
                        oPoint.Color = oColorList[nPos];

                    oPBottom.Label = " " + sLabel;
                    oPBottom.Font = new System.Drawing.Font("Consolas", 10f);

                    // Custom Label on X-Axis for player designations that has the icons
                    CustomLabel cl1 = new CustomLabel();
                    cl1.FromPosition = nPos - 0.5;
                    cl1.ToPosition = nPos + 0.5;
                    cl1.Text = "";
                    if (sName == EncounterSource.CharName)
                        cl1.ForeColor = Color.Gold;
                    else
                        cl1.ForeColor = Color.DarkSlateGray;

                    SizeF oStringSize = new SizeF();
                    try
                    {
                        Graphics G = oEncounterGraph.CreateGraphics();
                        oStringSize = G.MeasureString(sXLabel, chA.AxisX.LabelStyle.Font);
                    }
                    catch (Exception e)
                    {
                        ActGlobals.oFormActMain.WriteExceptionLog(e, "Exception while measuring text!");
                    }

                    int nImageHeight = 0;
                    int nYOffset = 0;
                    try
                    {
                        if (oStringSize.Height >= nIconHeight)
                        {
                            nImageHeight = Convert.ToInt32(oStringSize.Height);
                            nYOffset = Convert.ToInt32((nImageHeight - nIconHeight) / 2);
                        }
                        else
                            nImageHeight = nIconHeight;
                    }
                    catch (Exception e)
                    {
                        ActGlobals.oFormActMain.WriteExceptionLog(e, "Exception while gathering height!");
                        nImageHeight = nIconHeight;
                    }

                    Image oCLImage = null;
                    try
                    {
                        oCLImage = new Bitmap(Convert.ToInt32(oStringSize.Width + (nIconWidth * 2.375)), nImageHeight);
                    }
                    catch (Exception e)
                    {
                        ActGlobals.oFormActMain.WriteExceptionLog(e, "Exception while preparing empty image!");
                    }

                    try
                    {
                        using (Graphics oG = Graphics.FromImage(oCLImage))
                        {
                            Font oFont = null;

                            if (sName == EncounterSource.CharName)
                            {
                                oFont = new Font(chA.AxisX.LabelStyle.Font, FontStyle.Bold);
                                oG.Clear(Color.DarkSlateGray);
                                oG.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                            }
                            else
                            {
                                oFont = chA.AxisX.LabelStyle.Font;
                                oG.Clear(Color.Transparent);
                                oG.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                            }

                            int nOffset = 0;
                            oG.DrawString(sXLabel, oFont, new SolidBrush(cl1.ForeColor), 0, 0);
                            nOffset += Convert.ToInt32(oStringSize.Width + (nIconWidth / 8));

                            string sCharLookupName = lData[lDmg];
                            CombatantData oCombatant = EncounterSource.GetCombatant(sCharLookupName);
                            string sClass = "";
                            string sWeapon = "";

                            if (oCombatant.Tags.ContainsKey("PAType"))
                                sWeapon = Convert.ToString(oCombatant.Tags["PAType"]);

                            switch (sWeapon)
                            {
                                case "Foie":
                                    oG.DrawImage(oIcon_Technique_Foie, nOffset, nYOffset);
                                    break;
                                case "Barta":
                                    oG.DrawImage(oIcon_Technique_Barta, nOffset, nYOffset);
                                    break;
                                case "Zonde":
                                    oG.DrawImage(oIcon_Technique_Zonde, nOffset, nYOffset);
                                    break;
                                case "Zan":
                                    oG.DrawImage(oIcon_Technique_Zan, nOffset, nYOffset);
                                    break;
                                case "Grants":
                                    oG.DrawImage(oIcon_Technique_Grants, nOffset, nYOffset);
                                    break;
                                case "Megid":
                                    oG.DrawImage(oIcon_Technique_Megid, nOffset, nYOffset);
                                    break;
                                case "Compound":
                                    oG.DrawImage(oIcon_Technique_Compound, nOffset, nYOffset);
                                    break;

                                case "Sword":
                                    oG.DrawImage(oIcon_Weapon_Sword, nOffset, nYOffset);
                                    break;
                                case "Partisan":
                                    oG.DrawImage(oIcon_Weapon_Partisan, nOffset, nYOffset);
                                    break;
                                case "WireLance":
                                    oG.DrawImage(oIcon_Weapon_WireLance, nOffset, nYOffset);
                                    break;
                                case "Rifle":
                                    oG.DrawImage(oIcon_Weapon_Rifle, nOffset, nYOffset);
                                    break;
                                case "Launcher":
                                    oG.DrawImage(oIcon_Weapon_Launcher, nOffset, nYOffset);
                                    break;
                                case "Rod":
                                    oG.DrawImage(oIcon_Weapon_Rod, nOffset, nYOffset);
                                    break;
                                case "Talis":
                                    oG.DrawImage(oIcon_Weapon_Talis, nOffset, nYOffset);
                                    break;
                                case "Gunslash":
                                    oG.DrawImage(oIcon_Weapon_Gunslash, nOffset, nYOffset);
                                    break;
                                case "Knuckle":
                                    oG.DrawImage(oIcon_Weapon_Knuckle, nOffset, nYOffset);
                                    break;
                                case "TwinDagger":
                                    oG.DrawImage(oIcon_Weapon_TwinDagger, nOffset, nYOffset);
                                    break;
                                case "DoubleSaber":
                                    oG.DrawImage(oIcon_Weapon_DoubleSaber, nOffset, nYOffset);
                                    break;
                                case "TwinMachinegun":
                                    oG.DrawImage(oIcon_Weapon_TwinMachinegun, nOffset, nYOffset);
                                    break;
                                case "Wand":
                                    oG.DrawImage(oIcon_Weapon_Wand, nOffset, nYOffset);
                                    break;
                                case "Katana":
                                    oG.DrawImage(oIcon_Weapon_Katana, nOffset, nYOffset);
                                    break;
                                case "BulletBow":
                                    oG.DrawImage(oIcon_Weapon_BulletBow, nOffset, nYOffset);
                                    break;
                                case "DualBlades":
                                    oG.DrawImage(oIcon_Weapon_DualBlades, nOffset, nYOffset);
                                    break;
                                case "JetBoots":
                                    oG.DrawImage(oIcon_Weapon_JetBoots, nOffset, nYOffset);
                                    break;
                                case "Tact":
                                    oG.DrawImage(oIcon_Weapon_Tact, nOffset, nYOffset);
                                    break;
                                case "Pets":
                                    oG.DrawImage(oIcon_Pets, nOffset, nYOffset);
                                    break;

                                default:
                                    oG.DrawImage(oIcon_Disc, nOffset, nYOffset);
                                    break;
                            }

                            nOffset = nOffset + nIconWidth + 2;

                            if (oCombatant.Tags.ContainsKey("MainClass"))
                                sClass = Convert.ToString(oCombatant.Tags["MainClass"]);

                            if (sClass == "")
                                if (oCombatant.Tags.ContainsKey("PAClass"))
                                    sClass = Convert.ToString(oCombatant.Tags["PAClass"]);

                            switch (sClass)
                            {
                                case "HU":
                                    oG.DrawImage(oIcon_Class_HU, nOffset, nYOffset);
                                    break;
                                case "RA":
                                    oG.DrawImage(oIcon_Class_RA, nOffset, nYOffset);
                                    break;
                                case "FO":
                                    oG.DrawImage(oIcon_Class_FO, nOffset, nYOffset);
                                    break;
                                case "FI":
                                    oG.DrawImage(oIcon_Class_FI, nOffset, nYOffset);
                                    break;
                                case "GU":
                                    oG.DrawImage(oIcon_Class_GU, nOffset, nYOffset);
                                    break;
                                case "TE":
                                    oG.DrawImage(oIcon_Class_TE, nOffset, nYOffset);
                                    break;
                                case "BR":
                                    oG.DrawImage(oIcon_Class_BR, nOffset, nYOffset);
                                    break;
                                case "BO":
                                    oG.DrawImage(oIcon_Class_BO, nOffset, nYOffset);
                                    break;
                                case "SU":
                                    oG.DrawImage(oIcon_Class_SU, nOffset, nYOffset);
                                    break;
                                case "HR":
                                    oG.DrawImage(oIcon_Class_HR, nOffset, nYOffset);
                                    break;
                                case "PH":
                                    oG.DrawImage(oIcon_Class_PH, nOffset, nYOffset);
                                    break;
                                case "ET":
                                    oG.DrawImage(oIcon_Class_ET, nOffset, nYOffset);
                                    break;
                                default:
                                    oG.DrawImage(oIcon_MusicDisc, nOffset, nYOffset);
                                    break;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        ActGlobals.oFormActMain.WriteExceptionLog(e, "Exception while drawing to empty image the text and icons!");
                    }

                    try
                    {
                        oEncounterGraph.Images.Add(new NamedImage("Player" + nPos.ToString(), oCLImage));
                        cl1.Image = "Player" + nPos.ToString();
                    }
                    catch (Exception e)
                    {
                        ActGlobals.oFormActMain.WriteExceptionLog(e, "Exception while adding image to chart and cl1!");
                    }

                    // Custom Label 2 for Max Damage text
                    CustomLabel cl2 = new CustomLabel();
                    cl2.FromPosition = nPos - 0.5;
                    cl2.ToPosition = nPos + 0.5;
                    cl2.Text = lMaxData[lDmg];
                    chA.AxisX.CustomLabels.Add(cl1);
                    chA.AxisX2.CustomLabels.Add(cl2);

                    oBottom.Points.Add(oPBottom);
                    oSeries.Points.Add(oPoint);
                    nPos++;
                }
                oEncounterGraph.Series.Add(oBottom);
                oEncounterGraph.Series.Add(oSeries);
            }
            catch (Exception ex)
            {
                ActGlobals.oFormActMain.WriteExceptionLog(ex, "Graphing Exception - Trying to add data to graph");
            }

            // Now to draw everything onto a BITMAP and return it since 
            // ACT expects to display a BITMAP and NOT a Chart object.... >_> ... WHY?????
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    oEncounterGraph.SaveImage(ms, ChartImageFormat.Jpeg);
                    oEncounterBitmap = new Bitmap(ms);
                }
            }
            catch (Exception ex)
            {
                ActGlobals.oFormActMain.WriteExceptionLog(ex, "Exception while DRAWING TO BITMAP");
            }
            chA.Dispose();
            oEncounterGraph.Dispose();
            return oEncounterBitmap;
        }
        
        // For manually ending encounter so as to generate a "(Parsed)" encounter entry
        private void EncounterEnd_Click(object sender, EventArgs e)
        {
            if (oActionList.Count > 0)
            {
                List<ZoneData> oZones = ActGlobals.oFormActMain.ZoneList;

                foreach (ZoneData oZone in oZones)
                {
                    if (oZone.ZoneName == currInstID.ToString())
                    {
                        ActGlobals.oFormActMain.ActiveZone = oZone;
                        break;
                    }
                }

                EndOfCombat(false);
                ActGlobals.oFormActMain.EndCombat(false);
                if (oLastEncounter != null)
                    oLastEncounter.Title = "(Parsed)" + oLastEncounter.Title;
            }
        }
        private void LogThread()
        {
            while (true)
            {
                Thread.Sleep(1000);

                if (!Config.refreshFlag)
                    continue;

                Config.refreshFlag = false;
                string dir = String.Format(@"{0}\damagelogs", Config.selectedFolder);
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                if (!dirInfo.Exists)
                {
                    Config.Controls["lblLogFile"].Text = "damagelogs folder not found";
                    continue;
                }

                FileInfo[] dr = dirInfo.GetFiles("*.csv");
                if (dr == null || dr.Length == 0)
                {
                    Config.Controls["lblLogFile"].Text = "No logs, make sure your damage dump plugin is enabled.";
                    continue;
                }

                FileInfo file = (from f in dr orderby f.LastWriteTime descending select f).FirstOrDefault();
                Config.Controls["lblLogFile"].Text = String.Format("Reading {0}", file.Name ?? "<NULL>");
                ActGlobals.oFormActMain.LogFilePath = file.FullName;

                using (FileStream fs = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                    string sLineRead = "";
                    while ((sLineRead = sr.ReadLine()) != null)
                    {
                        Action aAction = new Action();
                        string logLine = sLineRead;
                        string[] tmp = logLine.Split(',');

                        if (tmp[0].Equals("timestamp"))
                            continue;

                        try
                        {
                            aAction.timestamp = Convert.ToUInt32(tmp[0]);
                            aAction.instanceID = Convert.ToUInt16(tmp[1]);
                            aAction.sourceID = Convert.ToUInt32(tmp[2]);
                            aAction.sourceName = tmp[3];
                            aAction.targetID = Convert.ToUInt32(tmp[4]);
                            aAction.targetName = tmp[5];
                            aAction.attackID = Convert.ToUInt32(tmp[6]);
                            aAction.damage = Convert.ToInt32(tmp[7]);
                            aAction.isJA = (Convert.ToInt32(tmp[8]) == 1);
                            aAction.isCrit = (Convert.ToInt32(tmp[9]) == 1);
                            aAction.isMultiHit = (Convert.ToInt32(tmp[10]) == 1);
                            aAction.isMisc = (Convert.ToInt32(tmp[11]) == 1);
                            aAction.isMisc2 = (Convert.ToInt32(tmp[12]) == 1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message + "\n" + logLine);
                            return;
                        }

                        if (DetectYOU(aAction))
                        {
                            charID = aAction.sourceID;
                            break;
                        }
                    }
                    sr.Close();
                    fs.Close();
                }

                ActGlobals.oFormActMain.OpenLog(false, false);
            }
        }

        struct Action
        {
            public uint timestamp;
            public ushort instanceID;
            public uint sourceID;
            public string sourceName;
            public uint targetID;
            public string targetName;
            public uint attackID;
            public int damage;
            public bool isJA;
            public bool isCrit;
            public bool isMultiHit;
            public bool isMisc;
            public bool isMisc2;
        }

        struct MSCopy
        {
            public int SwingType;
            public bool Critical;
            public string Special;
            public Dnum damage;
            public DateTime Time;
            public int TimeSorter;
            public uint AttackTypeID;
            public string theAttackType;
            public uint AttackerID;
            public string Attacker;
            public string theDamageType;
            public string Victim;
            public Dictionary<String, Object> Tags;

            public MSCopy(int v1, bool v2, string special, Dnum dmg, DateTime time, int gts, uint nAID, string actionType, uint nID, string v3, string damageType, string v4)
            {
                SwingType = v1;
                Critical = v2;
                Special = special;
                damage = dmg;
                Time = time;
                TimeSorter = gts;
                AttackTypeID = nAID;
                theAttackType = actionType;
                AttackerID = nID;
                Attacker = v3;
                theDamageType = damageType;
                Victim = v4;
                Tags = new Dictionary<String, Object>();
            }
        }

        // Function to detect whether the actor is a player character or not
        bool IsPlayer(string sInput)
        {
            if (sInput == "◆ ◇ ◆ ◇ ◆ " + skillDict[(uint)2106601422].Name + " ◇ ◆ ◇ ◆ ◇")
                return false;

            int nPos = sInput.LastIndexOf('_');
            if (nPos > 0)
            {
                string sMaybeID = sInput.Substring(nPos + 1);
                int nID = 0;
                if (Int32.TryParse(sMaybeID, out nID))
                {
                    if (nID > 10000000)
                        return true;
                }
                else
                    return true;
            }
            else
                return true;

            return false;
        }

        // Things to do once an Encounter ends
        // Which is to go through the data again and generate the "(Parsed)" encounter data with JA data on the name
        void EndOfCombat(bool bExport)
        {
            if (oActionList.Count < 2) return;
            
            Dictionary<string, string> sMaxHitList = new Dictionary<string, string>();
            Dictionary<string, string> sPlayers = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, string>> sSkills = new Dictionary<string, Dictionary<string, string>>();

            int nMaxLength = 0;
            foreach (string sCharName in oPlayerJA.Keys)
                if (sCharName.Length > nMaxLength)
                    nMaxLength = sCharName.Length;

            foreach (string sCharName in oPlayerJA.Keys)
            {
                try
                {
                    string sMaxHit = oPlayerMaxHit[sCharName].Keys.First() + ": " + oPlayerMaxHit[sCharName].Values.First().ToString("N0");

                    if (sMaxHitList.ContainsKey(sCharName))
                        sMaxHitList[sCharName] = sMaxHit;
                    else
                        sMaxHitList.Add(sCharName, sMaxHit);
                }
                catch (Exception ex)
                {
                    ActGlobals.oFormActMain.WriteExceptionLog(ex, "Exception when getting Max Hit data for player");
                }

                Dictionary<string, int> oJAData = null;
                try
                {
                    if (oPlayerJA.ContainsKey(sCharName))
                    {
                        oJAData = oPlayerJA[sCharName];
                        sPlayers.Add(sCharName, sCharName.PadRight(nMaxLength) + " ● JA:" + (((float)oJAData["JA"] / (float)oJAData["Total"]) * 100).ToString("N0").PadLeft(3) + "% ● " + sMaxHitList[sCharName]);
                    }
                }
                catch (Exception ex)
                {
                    ActGlobals.oFormActMain.WriteExceptionLog(ex, "Exception when trying to get Player JA data");
                }

                try
                {
                    if (oPlayerData.ContainsKey(sCharName))
                    {
                        Dictionary<string, Dictionary<string, int>> oSkillJAData = oPlayerData[sCharName];

                        Dictionary<string, string> sSNList = new Dictionary<string, string>();
                        int nSMaxLength = 0;
                        foreach (string sSkillName in oSkillJAData.Keys)
                            if (sSkillName.Length > nSMaxLength)
                                nSMaxLength = sSkillName.Length;

                        foreach (string sSkillName in oSkillJAData.Keys)
                        {
                            oJAData = oSkillJAData[sSkillName];
                            sSNList.Add(sSkillName, sSkillName.PadRight(nSMaxLength) + " (JA : " + (((float)oJAData["JA"] / (float)oJAData["Total"]) * 100).ToString("N0").PadLeft(3) + "%)");
                        }

                        sSkills.Add(sCharName, sSNList);
                    }
                }
                catch (Exception ex)
                {
                    ActGlobals.oFormActMain.WriteExceptionLog(ex, "Exception when trying to get Skill JA data");
                }
            }

            ActGlobals.oFormActMain.EndCombat(bExport);

            bool bFirst = true;
            MSCopy oLastAction = new MSCopy(
                -1,
                false,
                "Init",
                0,
                new DateTime(),
                0,
                0,
                "",
                0,
                "",
                "",
                ""
                );

            int nActionCount = 1;
            int nTotalActions = oActionList.Count;

            DateTime dLastAction = new DateTime();
            List<MSCopy> oHeals = new List<MSCopy>();
         
            foreach (MSCopy oAction in oActionList)
            {
                MSCopy oItem = oAction;

                try
                {
                    if (IsPlayer(oItem.Attacker) && !sPlayers.ContainsKey(oItem.Attacker))
                    {
                        nActionCount++;
                        continue;
                    }
                    if (IsPlayer(oItem.Victim) && !sPlayers.ContainsKey(oItem.Victim))
                    {
                        nActionCount++;
                        continue;
                    }

                    if ((nTotalActions - nActionCount) < 10)
                    {
                        if ((int)(oItem.Time - dLastAction).TotalSeconds > 30)
                            break;

                        if (nOriginalInstance[nActionCount - 1] == 0)
                        {
                            nActionCount++;
                            continue;
                        }
                    }

                    if ((int)(oItem.Time - dLastAction).TotalSeconds > 60)
                        break;

                    if ((oItem.theAttackType == "0") || (oItem.theDamageType == "0"))
                    {
                        nActionCount++;
                        continue;
                    }

                    if ((oItem.Attacker == oItem.Victim) && (oItem.theAttackType.Length == 8) && (oItem.damage.Number < 0))
                    {
                        nActionCount++;
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    ActGlobals.oFormActMain.WriteExceptionLog(ex, "Exception during first skip-or-continue checks");
                }

                try
                {
                    if (bFirst)
                    {
                        if ((oItem.damage.Number > 10) && (oItem.Attacker != oItem.Victim))
                        {
                            foreach (string sCharName in oPlayerJA.Keys)
                            {
                                if (sPlayers.ContainsKey(sCharName))
                                {
                                    // This is so that the encounter will start at the SAME TIME
                                    // for ALL players.
                                    MasterSwing fms = new MasterSwing(
                                        1,
                                        false,
                                        "Run Start",
                                        0,
                                        oItem.Time,
                                        oItem.TimeSorter,
                                        "Run Start (Ignore)",
                                        sPlayers[sCharName],
                                        "Misc",
                                        "(Ignore Target)"
                                        );
                                    if (ActGlobals.oFormActMain.SetEncounter(oItem.Time, sPlayers[sCharName], sPlayers[sCharName]))
                                        ActGlobals.oFormActMain.AddCombatAction(fms);
                                }
                            }
                            bFirst = false;
                        }
                        else
                        {
                            nActionCount++;
                            continue;
                        }
                    }
                }
                catch (Exception ex)
                {
                    ActGlobals.oFormActMain.WriteExceptionLog(ex, "Exception when trying to add First Action");
                }

                try
                {
                    if (sSkills.ContainsKey(oAction.Attacker))
                    {
                        Dictionary<string, string> sSN = sSkills[oAction.Attacker];
                        if (sSN.ContainsKey(oAction.theAttackType))
                            oItem.theAttackType = sSkills[oAction.Attacker][oAction.theAttackType];
                    }

                    if (sPlayers.ContainsKey(oItem.Attacker))
                        oItem.Attacker = sPlayers[oItem.Attacker];

                    if (sPlayers.ContainsKey(oItem.Victim))
                        oItem.Victim = sPlayers[oItem.Victim];

                    MasterSwing ms = new MasterSwing(
                        oItem.SwingType,
                        oItem.Critical,
                        oItem.Special,
                        oItem.damage,
                        oItem.Time,
                        oItem.TimeSorter,
                        oItem.theAttackType,
                        oItem.Attacker,
                        oItem.theDamageType,
                        oItem.Victim
                        );

                    if (oItem.damage.Number < 3)
                        oHeals.Add(oItem);
                    else
                    {
                        if (oHeals.Count > 0)
                        {
                            foreach (MSCopy oHealAction in oHeals)
                            {
                                MasterSwing heal = new MasterSwing(
                                    oHealAction.SwingType,
                                    oHealAction.Critical,
                                    oHealAction.Special,
                                    oHealAction.damage,
                                    oHealAction.Time,
                                    oHealAction.TimeSorter,
                                    oHealAction.theAttackType,
                                    oHealAction.Attacker,
                                    oHealAction.theDamageType,
                                    oHealAction.Victim
                                    );
                                if (ActGlobals.oFormActMain.SetEncounter(oHealAction.Time, oHealAction.Attacker, oHealAction.Victim))
                                    ActGlobals.oFormActMain.AddCombatAction(heal);
                            }
                            oHeals.Clear();
                        }

                        if (ActGlobals.oFormActMain.SetEncounter(oItem.Time, oItem.Attacker, oItem.Victim))
                            ActGlobals.oFormActMain.AddCombatAction(ms);

                        dLastAction = oItem.Time;
                        oLastAction = oItem;
                    }

                    if (oItem.AttackerID == charID)
                        ActGlobals.oFormActMain.ActiveZone.ActiveEncounter.CharName = oItem.Attacker;
                }
                catch (Exception ex)
                {
                    ActGlobals.oFormActMain.WriteExceptionLog(ex, "Exception when trying to add the action");
                }

                nActionCount++;
            }

            try
            {
                if (oLastAction.Special != "Init")
                    foreach (string sCharName in oPlayerJA.Keys)
                    {
                        string sName = "";
                        if (sPlayers.ContainsKey(sCharName))
                            sName = sPlayers[sCharName];
                        else
                            sName = sCharName;

                        string sLastPlayer = "";
                        if (oLastAction.Attacker.Contains(" ● JA"))
                            sLastPlayer = oLastAction.Attacker.Split('●')[0].Trim();
                        else
                            sLastPlayer = oLastAction.Attacker;

                        // This is so that the encounter will END AT THE SAME TIME
                        // for ALL actors.  This is to do DPS calculations correctly.
                        MasterSwing fms = new MasterSwing(
                            1,
                            false,
                            "Last Action - " + sLastPlayer + " : " + oLastAction.theAttackType + " -> " + oLastAction.damage.Number,
                            0,
                            oLastAction.Time,
                            oLastAction.TimeSorter + 1,
                            "Run End (Ignore)",
                            sName,
                            "Misc",
                            "(Ignore Target)"
                            );
                        if (ActGlobals.oFormActMain.SetEncounter(oLastAction.Time, sName, sName))
                            ActGlobals.oFormActMain.AddCombatAction(fms);
                    }
            }
            catch (Exception ex)
            {
                ActGlobals.oFormActMain.WriteExceptionLog(ex, "Exception when adding last action");
            }

            // Add in data as Misc "Tags" to each Player entry in the database for use when graphing.
            List<CombatantData> oCurrentPlayers = ActGlobals.oFormActMain.ActiveZone.ActiveEncounter.GetAllies();
            foreach (CombatantData oPlayer in oCurrentPlayers)
            {
                if (IsPlayer(oPlayer.Name))
                {
                    foreach (KeyValuePair<string, DamageTypeData> oPair in oPlayer.Items)
                    {
                        long lAttackDamage = 0;
                        uint lMaxAttackID = 0;
                        foreach (KeyValuePair<string, AttackType> oItemPair in oPair.Value.Items)
                        {
                            if (oItemPair.Key != "All")
                            {
                                string sSkillName = oItemPair.Key;
                                int nPos = -1;
                                nPos = sSkillName.LastIndexOf("(JA : ");
                                if (nPos > 0)
                                    sSkillName = sSkillName.Substring(0, nPos - 1);
                                uint lAttackID = 0;

                                sSkillName = sSkillName.Trim();
                                
                                if (revSkillDict.ContainsKey(sSkillName))
                                {
                                    lAttackID = revSkillDict[sSkillName];
                                    if (ClassLookup.ContainsKey(lAttackID))
                                        if (ClassLookup[lAttackID] != "")
                                            oPlayer.Tags["PAClass"] = ClassLookup[lAttackID];
                                    if (MainClassLookup.ContainsKey(lAttackID))
                                        oPlayer.Tags["MainClass"] = MainClassLookup[lAttackID];
                                }

                                if (oItemPair.Value.Damage > lAttackDamage)
                                {
                                    if (WeaponLookup.ContainsKey(lAttackID))
                                    {
                                        lAttackDamage = oItemPair.Value.Damage;
                                        lMaxAttackID = lAttackID;
                                    }
                                }
                            }
                        }
                        if (WeaponLookup.ContainsKey(lMaxAttackID))
                            oPlayer.Tags["PAType"] = WeaponLookup[lMaxAttackID];
                        break;
                    }
                }
            }

            oActionList.Clear();
            nOriginalInstance.Clear();
            oPlayerJA.Clear();
            oPlayerData.Clear();
            oPlayerMaxHit.Clear();

            oLastEncounter = ActGlobals.oFormActMain.ActiveZone.ActiveEncounter;

            // Go through all encounters and remove those without any allies
            // Pretty much a clean-up of weird useless encounter entries
            try
            {
                List<ZoneData> oZones = ActGlobals.oFormActMain.ZoneList;
                List<ZoneData> oNewZones = new List<ZoneData>();

                foreach (ZoneData oZone in oZones)
                {
                    ZoneData oNewZone = oZone;
                    List<EncounterData> oEncounters = oZone.Items;
                    List<EncounterData> oNewEncounters = new List<EncounterData>();

                    foreach (EncounterData oEncounter in oEncounters)
                        if ((oEncounter.NumAllies > 0) && (oEncounter.Items.Count > 1))
                            oNewEncounters.Add(oEncounter);

                    oNewZone.Items = oNewEncounters;
                    oNewZones.Add(oNewZone);
                }

                ActGlobals.oFormActMain.ZoneList = oNewZones;
            }
            catch (Exception ex)
            {
                // Probably parsed the run way too early.
                ActGlobals.oFormActMain.WriteExceptionLog(ex, "Exception when trying to remove non-ally encounters");
            }
        }

        bool DetectYOU(Action aAction)
        {
            if (
                aAction.timestamp == 0 &&
                aAction.instanceID == 0 &&
                aAction.sourceName == "YOU" &&
                aAction.targetID == 0 &&
                aAction.targetName == "0" &&
                aAction.attackID == 0 &&
                aAction.damage == 0 &&
                aAction.isJA == false &&
                aAction.isCrit == false &&
                aAction.isMultiHit == false &&
                aAction.isMisc == false &&
                aAction.isMisc2 == false
              )
                return true;

            return false;
        }

        void oFormActMain_BeforeLogLineRead(bool isImport, LogLineEventArgs logInfo)
        {
            Action aAction = new Action();
            string logLine = logInfo.logLine;
            string[] tmp = logInfo.logLine.Split(',');
            bool bBreakEncounter = false;

            ushort nOInst = 0;

            if (tmp[0].Equals("timestamp"))
                return;

            try
            {
                aAction.timestamp = Convert.ToUInt32(tmp[0]);
                aAction.instanceID = Convert.ToUInt16(tmp[1]);
                aAction.sourceID = Convert.ToUInt32(tmp[2]);
                aAction.sourceName = tmp[3];
                aAction.targetID = Convert.ToUInt32(tmp[4]);
                aAction.targetName = tmp[5];
                aAction.attackID = Convert.ToUInt32(tmp[6]);
                aAction.damage = Convert.ToInt32(tmp[7]);
                aAction.isJA = (Convert.ToInt32(tmp[8]) == 1);
                aAction.isCrit = (Convert.ToInt32(tmp[9]) == 1);
                aAction.isMultiHit = (Convert.ToInt32(tmp[10]) == 1);
                aAction.isMisc = (Convert.ToInt32(tmp[11]) == 1);
                aAction.isMisc2 = (Convert.ToInt32(tmp[12]) == 1);
            }
            catch (Exception ex)
            {
                ActGlobals.oFormActMain.WriteExceptionLog(ex, "Error while parsing log line : \n" + logLine);
                return;
            }
            nOInst = aAction.instanceID;

            if (DetectYOU(aAction))
            {
                charID = aAction.sourceID;
                return;
            }

            if (aAction.targetID == 0 ||
               (aAction.instanceID == 0 && currInstID == 0xFFFF))
                return;

            DateTime time = ActGlobals.oFormActMain.LastKnownTime;
            int gts = ActGlobals.oFormActMain.GlobalTimeSorter;
            if ((aAction.instanceID == 0) || (aAction.instanceID < 1000))
                aAction.instanceID = currInstID;
            SwingTypeEnum e;

            // Apparently PSO2 logs same instance of Free Field runs with the same Instance ID, 
            // even if doing with different characters, so long as you get put onto the same MPA instance
            // Thus needs to now separate if same instance ID BUT if YOU're different character
            if (aAction.sourceID == charID)
            {
                if ((charName != "") && (currInstID != 0xFFFF))
                    if ((currInstID == aAction.instanceID) && (aAction.instanceID > 1000))
                        if (aAction.sourceName != charName)
                        {
                            //Break Encounter since SAME playerID but NOT SAME NAME!
                            bBreakEncounter = true;
                        }
                charName = aAction.sourceName;
            }

            string sourceName = aAction.sourceName + "_" + aAction.sourceID.ToString();
            string targetName = aAction.targetName + "_" + aAction.targetID.ToString();
            string special = "";

            if (aAction.sourceID > 10000000)
                sourceName = aAction.sourceName;

            if (aAction.targetID > 10000000)
                targetName = aAction.targetName;

            string actionType = aAction.attackID.ToString();
            string damageType = aAction.attackID.ToString();
            string actionComment = "";

            if (aAction.damage < 0 && aAction.isMisc)
                e = SwingTypeEnum.Healing;
            else
                e = SwingTypeEnum.Melee;

            Dnum dmg = new Dnum(aAction.damage) * ((e == SwingTypeEnum.Healing) ? -1 : 1);

            if (skillDict.ContainsKey(aAction.attackID))
            {
                actionType = skillDict[aAction.attackID].Name;
                damageType = skillDict[aAction.attackID].Type;
                actionComment = skillDict[aAction.attackID].Comment;
            }

            // Separating Zanverse
            if (aAction.attackID == 2106601422)
            {
                special = " | " + sourceName;
                sourceName = "◆ ◇ ◆ ◇ ◆ " + actionType + " ◇ ◆ ◇ ◆ ◇";
            }

            if ((aAction.sourceID == aAction.targetID) && (aAction.attackID == 0))
            {
                switch (aAction.sourceID)
                {
                    case 27: // Separating Double from PD - Another instance of it? Found it by running UH
                    case 33: // Separating Mother from Deus
                    case 38: // Separating Double from PD
                    case 278: // Separating Deus from Esca???
                    case 504: // Separating normal run from Space Magatsu
                    case 458: // Separating normal run from Yamato AIS Run
                        bBreakEncounter = true;
                        break;

                    default:
                        break;
                }
            }

            MasterSwing ms = new MasterSwing(
                Convert.ToInt32(e),
                aAction.isCrit,
                actionComment + " | JA:" + (aAction.isJA ? "true" : "false") + special,
                dmg,
                time,
                gts,
                actionType,
                sourceName,
                damageType,
                targetName
                );

            MSCopy msc = new MSCopy(
                Convert.ToInt32(e),
                aAction.isCrit,
                actionComment + " | JA:" + (aAction.isJA ? "true" : "false") + special,
                dmg,
                time,
                gts,
                aAction.attackID,
                actionType,
                aAction.sourceID,
                sourceName,
                damageType,
                targetName
                );

            ZoneData oNewZone = null;
            EncounterData oNewEncounter = null;
            bool bPrevZone = false;

            // Check if to break encounter due to this being a NEW ACTUAL encounter or not
            if ((aAction.instanceID != currInstID) && (aAction.instanceID > 1000))
            {
                List<ZoneData> oCurrentZones = ActGlobals.oFormActMain.ZoneList;

                foreach (ZoneData oZoneItem in oCurrentZones)
                {
                    if (oZoneItem.ZoneName == aAction.instanceID.ToString())
                    {
                        bPrevZone = true;

                        oNewZone = oZoneItem;
                        currInstID = aAction.instanceID;

                        List<EncounterData> oEncounterItems = oZoneItem.Items;
                        if ((oEncounterItems != null) && (oEncounterItems.Count > 0))
                        {
                            oEncounterItems.Reverse();

                            foreach (EncounterData oEnc in oEncounterItems)
                            {
                                if (oEnc != null)
                                {
                                    String sTitle = oEnc.Title;

                                    if (oEnc.Title != null)
                                        if (oEnc.Title.Contains("(Parsed)"))
                                            continue;

                                    oNewEncounter = oEnc;

                                    if ((oEnc.EndTime - ms.Time).TotalSeconds > 30)
                                        bBreakEncounter = true;

                                    break;
                                }
                                else
                                    continue;
                            }
                        }
                        break;
                    }
                }

                if (!bPrevZone)
                    bBreakEncounter = true;
            }

            // Actually break the encounter if previously found that it needs to.
            if (bBreakEncounter)
            {
                EndOfCombat(true);
                ActGlobals.oFormActMain.EndCombat(true);
                if (oLastEncounter != null)
                    oLastEncounter.Title = "(Parsed)" + oLastEncounter.Title;
            }

            if ((oNewZone != null) || ((aAction.instanceID != currInstID) && (!bPrevZone)))
            {
                if (!bPrevZone)
                {
                    ActGlobals.oFormActMain.ChangeZone(aAction.instanceID.ToString());
                }
                else
                {
                    if (oNewZone != null)
                    {
                        ActGlobals.oFormActMain.ActiveZone = oNewZone;
                        ActGlobals.oFormActMain.ActiveZone.ActiveEncounter = oNewEncounter;
                    }
                }
                currInstID = aAction.instanceID;
            }

            try
            {
                if (ActGlobals.oFormActMain.SetEncounter(time, sourceName, targetName))
                {
                    ActGlobals.oFormActMain.AddCombatAction(ms);

                    // After adding the current action to the database,
                    // Keep an extra copy of the action data in a list and
                    // Also manually calculate max hit data and JA data for
                    // use when generating the "(Parsed)" encounter data
                    oLastAction = ms;

                    ActGlobals.oFormActMain.ActiveZone.ActiveEncounter.CharName = charName;

                    Dictionary<string, long> oMaxHitData = null;
                    if (oPlayerMaxHit.ContainsKey(sourceName))
                    {
                        oMaxHitData = oPlayerMaxHit[sourceName];

                        Dictionary<string, long> oData = new Dictionary<string, long>();
                        foreach (KeyValuePair<string, long> oPair in oMaxHitData)
                        {
                            if (dmg.Number > oPair.Value)
                                oData.Add(actionType, dmg.Number);
                            else
                                oData.Add(oPair.Key, oPair.Value);
                        }

                        oPlayerMaxHit[sourceName] = oData;
                    }
                    else
                    {
                        oMaxHitData = new Dictionary<string, long>();
                        oMaxHitData.Add(actionType, dmg.Number);
                        oPlayerMaxHit.Add(sourceName, oMaxHitData);
                    }

                    if (!noJADict.ContainsKey(aAction.attackID))
                    {
                        if ((aAction.sourceID > 10000000) && (aAction.attackID != 2106601422))
                        {
                            Dictionary<string, int> sHits = null;
                            Dictionary<string, int> sTotalHits = null;

                            try
                            {
                                sHits = oPlayerData[sourceName][actionType];
                            }
                            catch
                            {
                                sHits = new Dictionary<string, int>();
                                sHits["JA"] = 0;
                                sHits["Total"] = 0;
                            }

                            try
                            {
                                sTotalHits = oPlayerJA[sourceName];
                            }
                            catch
                            {
                                sTotalHits = new Dictionary<string, int>();
                                sTotalHits["JA"] = 0;
                                sTotalHits["Total"] = 0;
                            }

                            if (aAction.isJA)
                            {
                                sHits["JA"] = sHits["JA"] + 1;
                                sTotalHits["JA"] = sTotalHits["JA"] + 1;
                            }

                            sHits["Total"] = sHits["Total"] + 1;
                            sTotalHits["Total"] = sTotalHits["Total"] + 1;

                            if (oPlayerJA.ContainsKey(sourceName))
                                oPlayerJA[sourceName] = sTotalHits;
                            else
                                oPlayerJA.Add(sourceName, sTotalHits);

                            if (oPlayerData.ContainsKey(sourceName))
                            {
                                if (oPlayerData[sourceName].ContainsKey(actionType))
                                    oPlayerData[sourceName][actionType] = sHits;
                                else
                                    oPlayerData[sourceName].Add(actionType, sHits);
                            }
                            else
                            {
                                Dictionary<string, Dictionary<string, int>> oSkillData = new Dictionary<string, Dictionary<string, int>>();
                                oSkillData.Add(actionType, sHits);
                                oPlayerData.Add(sourceName, oSkillData);
                            }
                        }
                    }

                    oActionList.Add(msc);
                    nOriginalInstance.Add(nOInst);
                    tLastActionTime = time;

                    if (aAction.sourceID > 10000000)
                    {
                        CombatantData oThisPlayer = null;
                        try
                        {
                            oThisPlayer = ActGlobals.oFormActMain.ActiveZone.ActiveEncounter.GetCombatant(aAction.sourceName);
                        }
                        catch (Exception e1)
                        {
                            ActGlobals.oFormActMain.WriteExceptionLog(e1, "Exception while getting Combatant");
                        }

                        // Get data for which icon to use for this player and set accordingly
                        uint lAttackID = 0;
                        long lAttackDamage = 0;

                        try
                        {
                            foreach (KeyValuePair<String, DamageTypeData> oPair in oThisPlayer.Items)
                            {
                                DamageTypeData oDamage = oPair.Value;

                                foreach (KeyValuePair<string, AttackType> oItemPair in oDamage.Items)
                                {
                                    if (oItemPair.Key != "All")
                                    {
                                        if (oItemPair.Value.Damage > lAttackDamage)
                                        {
                                            lAttackDamage = oItemPair.Value.Damage;
                                            string sSkill = oItemPair.Key;
                                            sSkill = sSkill.Trim();
                                            if (revSkillDict.ContainsKey(sSkill))
                                                lAttackID = revSkillDict[sSkill];
                                        }
                                    }
                                }
                                break;
                            }
                        }
                        catch (Exception e1)
                        {
                            ActGlobals.oFormActMain.WriteExceptionLog(e1, "Exception while getting skill ID with most damage");
                        }

                        try
                        {
                            if (lAttackID > 0)
                                if (WeaponLookup.ContainsKey(lAttackID))
                                    oThisPlayer.Tags["PAType"] = WeaponLookup[lAttackID];

                            if (ClassLookup.ContainsKey(aAction.attackID))
                                if (ClassLookup[aAction.attackID] != "")
                                    oThisPlayer.Tags["PAClass"] = ClassLookup[aAction.attackID];

                            if (MainClassLookup.ContainsKey(aAction.attackID))
                                oThisPlayer.Tags["MainClass"] = MainClassLookup[aAction.attackID];
                        }
                        catch (Exception e1)
                        {
                            ActGlobals.oFormActMain.WriteExceptionLog(e1, "Exception while adding tags to Combatant");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ActGlobals.oFormActMain.WriteExceptionLog(ex, "Exception! - While adding in the actual current action data");
            }
        }

        // Initializes Skill dictionarys for lookup while parsing
        // IT NOW READS FROM EXTERNAL FILES!!!!!
        private void InitializeSkillDict()
        {
            try
            {
                // Main skills.csv file
                using (StreamReader sr = new StreamReader(sPluginDir + "\\skills.csv"))
                {
                    string line;
                    if (sr.ReadLine() != null)
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] tmp = line.Split(',');
                            Skill s;
                            s.Name = tmp[0];
                            s.Type = tmp[2];
                            s.Comment = tmp[3];
                            if (!skillDict.ContainsKey(Convert.ToUInt32(tmp[1])))
                                skillDict.Add(Convert.ToUInt32(tmp[1]), s);
                            if (!revSkillDict.ContainsKey(s.Name))
                                revSkillDict.Add(s.Name, Convert.ToUInt32(tmp[1]));
                        }
                }

                // A subset of skills.csv that contain only those items that DON'T generate JA
                using (StreamReader sr = new StreamReader(sPluginDir + "\\skills-noJA.csv"))
                {
                    string line;
                    if (sr.ReadLine() != null)
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] tmp = line.Split(',');
                            Skill s;
                            s.Name = tmp[0];
                            s.Type = tmp[2];
                            s.Comment = tmp[3];
                            if (!noJADict.ContainsKey(Convert.ToUInt32(tmp[1])))
                                noJADict.Add(Convert.ToUInt32(tmp[1]), s);
                        }
                }

                // A subset of skills.csv that is composed of Main-class only skills
                // This FORMAT is different from normal skills.csv to incorporate Class info
                using (StreamReader sr = new StreamReader(sPluginDir + "\\skills-Main.csv"))
                {
                    string line;
                    if (sr.ReadLine() != null)
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] tmp = line.Split(',');
                            uint nSkillID = Convert.ToUInt32(tmp[0]);
                            string sClass = tmp[1];

                            if (!MainClassLookup.ContainsKey(Convert.ToUInt32(tmp[0])))
                                MainClassLookup.Add(Convert.ToUInt32(tmp[0]), sClass);
                        }
                }

                // A subset of skills.csv that has weapon type info added
                // This FORMAT is different from normal skills.csv to incorporate Weapon info
                using (StreamReader sr = new StreamReader(sPluginDir + "\\skills-Weapon.csv"))
                {
                    string line;
                    if (sr.ReadLine() != null)
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] tmp = line.Split(',');
                            uint nSkillID = Convert.ToUInt32(tmp[0]);
                            string sClass = tmp[1];
                            string sWeapon = tmp[2];

                            if (!ClassLookup.ContainsKey(Convert.ToUInt32(tmp[0])))
                                ClassLookup.Add(Convert.ToUInt32(tmp[0]), sClass);
                            if (!WeaponLookup.ContainsKey(Convert.ToUInt32(tmp[0])))
                                WeaponLookup.Add(Convert.ToUInt32(tmp[0]), sWeapon);
                        }
                }
            }
            catch (Exception ex)
            {
                ActGlobals.oFormActMain.WriteExceptionLog(ex, "Error while reading skill dictionary files!");
            }
        }

        DateTime ParseDateTime(string logLine)
        {
            string[] tmp = logLine.Split(',');
            if (tmp[0] == "timestamp")
                return DateTime.MinValue;
            System.DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(Convert.ToUInt32(tmp[0]));
            return dateTime.ToLocalTime();
        }

        void LoadSettings()
        {
            xmlSettings.AddControlSetting("directory", Config.Controls["directory"]);

            if (File.Exists(settingsFile))
            {
                FileStream fs = new FileStream(settingsFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                XmlTextReader xReader = new XmlTextReader(fs);

                try
                {
                    while (xReader.Read())
                        if (xReader.NodeType == XmlNodeType.Element)
                            if (xReader.LocalName == "SettingsSerializer")
                                xmlSettings.ImportFromXml(xReader);
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error loading settings: " + ex.Message;
                    ActGlobals.oFormActMain.WriteExceptionLog(ex, "Error loading settings");
                }
                xReader.Close();
            }
        }

        void SaveSettings()
        {
            FileStream fs = new FileStream(settingsFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            XmlTextWriter xWriter = new XmlTextWriter(fs, Encoding.UTF8);
            xWriter.Formatting = Formatting.Indented;
            xWriter.Indentation = 1;
            xWriter.IndentChar = '\t';
            xWriter.WriteStartDocument(true);
            xWriter.WriteStartElement("Config");	// <Config>
            xWriter.WriteStartElement("SettingsSerializer");	// <Config><SettingsSerializer>
            xmlSettings.ExportToXml(xWriter);	// Fill the SettingsSerializer XML
            xWriter.WriteEndElement();	// </SettingsSerializer>
            xWriter.WriteEndElement();	// </Config>
            xWriter.WriteEndDocument();	// Tie up loose ends (shouldn't be any)
            xWriter.Flush();	// Flush the file buffer to disk
            xWriter.Close();
        }

        void oFormActMain_UpdateCheckClicked()
        {
            return;
        }

        DateTime GetRemoteLastUpdated(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "HEAD";
            var response = (HttpWebResponse)request.GetResponse();
            response.Close();
            return response.LastModified.ToUniversalTime();
        }
    }
}
