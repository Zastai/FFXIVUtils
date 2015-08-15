// The GEARSET.DAT file.

// Unknown 1: always 0x0005 ?
// Unknown 2: always 0x006A ?
// Fixed Data Size: 0xAF41
// Payload:
// - 0xFF ("encryption" indicator)
// - ? blocks of gearset info:

namespace FFXIVUtils.FileTypes {

  /// <summary>A Gear Set file (GEARSET.DAT).</summary>
  public sealed class GearSets : CharacterDataFile {
  
  }

}