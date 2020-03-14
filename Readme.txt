PSO2ACT

A fork of the original PSO2 ACT Plugin from VariantXYZ.
All thanks to VariantXYZ for the original ACT Plugin.

The following files must be installed in the Plugins folder of ACT :
- Osaka-Mono-HW.ttf (OK, technically it doesn't HAVE to be here, but to have
things all close by....)
- PSO2ACT.dll (The main plugin file)
- Readme.ext (This file)
- skills.csv (The main skills.csv file that contains skill IDs and skill Names)
- skills-noJA.csv (A subset of the above skills.csv file that contain those
  that don't generate JAs)
- skills-Main.csv (A subset of the above skills.csv with different format to
  include Main Class info)
- skills-Weapon.csv (A subset of the above skills.csv with different format to
  include weapon & class info)

Differences from original plugin :
- Calculate and display JA %s
- Also display Max hit attack with the name
- Does not use ACT's default Encounter Graph, but uses custom code in order to display DPS, JA%, Crit% in the Encounter Graph as well
- It will try to separate runs that have 2nd phases and such, like Space
  Magatsu's 1st normal run to AIS phase, Guides of Creation's Mother to Deus
  fight, etc.
- Added to show the Skill Comments in AttackType View under Special column (the comments such as whether the tech was charged, 
  the 1st hit of Connect, etc)

In order to do the above, it will automatically create yet another encounter entry every time you either start another run,or manually
end the encounter by clicking on the "CLICK TO END ENCOUNTER" button.

The parsed encounters will be prefixed "(Parsed)".

There are a few options that need to be changed to make this work in the Options tab.
First, install the Osaka-Mono-HW.ttf font, named "Butchered Osaka-Mono(Half-Width)".

- Main Table/Encounters -> General : "Number of seconds to wait after the last combat action to begin a new encounter" should be checked OFF.

- Color and Font Settings -> Main User Interface -> Under the Main User Interface options, the last bottom "Change Font" should be used to
  the one provided with this plugin (Osaka-Mono-HW : Regular : Size 11 or whichever you want for your screen)

As for the rest, I recommend the following settings :
- Encounter View Options : Only have Name, Damage, DPS, DamageTaken, CritDam%\
- Combatant View Options : Only have Type, Damage, DPS, Average, MinHit, MaxHit, Hits, ToHit, Crit%
- DamageType View Options : Only have Type, Damage, DPS, MinHit, MaxHit, Resist, Hits, Crit%
- AttackType View Options : Time, AttackType, DamageType, Victim, Damage, Critical, Special
