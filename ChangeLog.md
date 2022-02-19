## ChangeLog:

### Version 3.5.5
 * fix KSPCommunityFixes incompatibility

### Version 3.5.4
 * fix info strings in the editor
 * make ModuleAntennaToggler patch more flexible

### Version 3.5.3
 * update localization

### Version 3.5.2
 * ksp 1.12.2
 * MM 4.2.1

### Version 3.5.1
 * fix NFEX support
 * fix MPO Probe toggler
 * fix duplicating ModuleAntennaToggler patch logic in the ModuleGeneratorAntenna

### Version 3.5.0
Changes since 3.0.3:
 * ksp 1.12
 * Fix a bug with unrectactable antennas with ModuleCargoPart
 * Fix wrong consumption for CAE antennas (patch order problem introduce in v3.1.0)
 * Scale consumption for a power of 0.4 (by request of @Starman4308)
   By default, RELAY Consumption is:
   5M   → 0.00005 ^ 0.4 = 0.019 EC/s
   2G   → 0.02    ^ 0.4 = 0.2 EC/s
   100G → 1       ^ 0.4 = 1 EC/s
   10T  → 100     ^ 0.4 = 6.3 EC/s

### Version 3.1.0
 * scale consumption for a power of 0.4 (by request of @Starman4308)
   For example:
   100G = 1 EC/s
   2G   = 0.02^0.4 = 0.2 EC/s
   5M   = 0.00005^0.4 = 0.019 EC/s
   10T  = 100^0.4 = 3.6EC/s

### Version 3.0.3
 * ksp 1.11
 * fields grouped in the PAW

### Version 3.0.2
 * French translation (@vinix38)

### Version 3.0.1
 * ksp 1.8-1.10

### Version 3.0.0
 * CommNetAntennasConsumptor was excluded from the "CommNet Antennas Info"
 * supported DMagic Orbiral Science: Soil Moisture Sensor and SIGINT
 * added ModuleAntennaToggler - module to disable/enable every "static" (unretractable) antenna. 
   So now you can disable static antennas, and they will stop consuming EC, but a vessel will lose its antenna power.
   Also if you disable antenna at launch, it will be auto-enabled on transmission request and later auto-disabled
   (same as retractable antennas auto-deployed and auto-retracted)



## CommNet Antennas Info ChangeLog:

### Version 2.5.0 Prerelease
 * ksp 1.8-1.9
 * CommNetAntennasConsumptor:
    * supported DMagic Orbiral Science: Soil Moisture Sensor and SIGINT
    * added ModuleAntennaToggler - module to disable/enable every "static" (unretractable) antenna. 
      So now you can disable static antennas, and they will stop consuming EC, but a vessel will lose its antenna power.
      Also if you disable antenna at launch, it will be auto-enabled on transmission request and later auto-disabled
      (same as retractable antennas auto-deployed and auto-retracted)
 * added Bandwidth field to PAW

### Version 2.3.5
 * backport 2.4.1 to ksp 1.8

### Version 2.4.1
 * Packet size and cost to PAW 
 * fix DSN power info

### Version 2.4.0
 * ksp 1.9.0
 * CommNetAntennasConsumptor:
     * disabled consumption for the INTERNAL antennas
     * DIRECT consumption reduced by 2.5 times.

### Version 2.3.4
 * Hide actions for CommNetAntennasConsumptor

### Version 2.3.3
 * Fix nulrefs

### Version 2.3.2
 * Fix not-extendable antennas

### Version 2.3.1
 * Updated translation

### Version 2.3.0
 * support for NF Exploration
 * new Extras - CommNetAntennasConsumptor on CKAN - enable ModuleGeneratorAntenna, 
   which makes antennas consume EC for supporting CommNet (always, when extended)
 * recompiled for ksp 1.8.1
 * updated MM 4.1.3

### Version 2.2.0
 * recompiled for ksp 1.8.0
 * showed "Consumption" as EC/Mit
 * hided "Antenna State" for Internal Antennas, because they can't transmit science
 * supported parts with several ModuleDataTransmitters
 * updated MM 4.1.0
 * targeted .NET 4.7.2

### Version 2.1.2
 * remove unused patch filter

### Version 2.1.1
 * PAW: fix default rating
 * PAW: compact for internal antenna, 
 * update MM 4.0.3

### Version 2.1.0
 * Antenna Type and CombinabilityExponent in the PAW (Part-Action-Window)
   It show up only with enabled Advanced Tweakable setting 
 * added MM v4.0.2
 * recompiled for ksp 1.7.0
 * targeted .NET 3.5 
 

### Version 2.0.0
 * This plugin was exluded from the "CommNet Antennas Extension"
   Salute the "CommNet Antennas Info"
 * recompiled for ksp 1.6.0



## CommNet Antennas Extension ChangeLog:

### Version 1.1.1.1
 * Plugin: Localized Internal AntennaType

### Version 1.1.1
 * Plugin: Localized AntennaType

### Version 1.1.0 (Plugin Update)
 * shows modified ratings (if you have changed power modifiers in the settings)
 * shows all DSN levels (Custom Barn Kit supported)
 * shows DSN ratings, hightlights active DSN level, 
 * shows range to Built-in antenna for relays
 * compact version for internal antennas

### Version 1.0.3
 * HG-25 is HG-32 now.
   When this antenna was included, the purpose was to make 
   InnerSOI Commnet Network reaching Minmus with 2 of those on each vessel.
   But HG-25 doesn't make this true, because of Combinability, 
   so the antenna-power was increased.

### Version 1.0.2
 * fixed large power consumption of the HG-25

### Version 1.0.1
 * Recompile for KSP 1.5.1
 * fixed RelayTech One antennaType (Relay)

### Version 1.0.0
 * Recompile for KSP 1.5.0
 * Russian localization
 * Update MM to 3.1.0

### Version 0.9.5
 * check working with RemoteTechRedevAntennas 0.1.1
 * update desc
 * add MM to archive

### Version 0.9.3
 * fix bug in the ja-localization

### Version 0.9.2
 * fix technodes

### Version 0.9.1
 * remove RT art assets

### Version 0.9
 * direct antennas: 5M and 500G
 * relay antennas: 25M, 7G, 25G, 500G
 * plugin for showing CombinabilityExponent in the VAB
