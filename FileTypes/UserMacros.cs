// The MACRO.DAT file.

// Information initially based on http://ffxivexplorer.fragmenterworks.com/research/macros.txt.

// Unknown 1: always 0x0001 ?
// Unknown 2: always 0x0001 ?
// Fixed Data Size: 0x46000
// Payload:
// - 0xFF ("encryption" indicator)
// - 100 sets of 18 blocks (title, icon, key and 15 lines)
//   - each block has:
//     char  Type;         // T(itle) I(con) K(ey) L(ine)
//     int16 Length;       // Length (between 1 and 181)
//     char  Text[Length]; // Text, with trailing 0 byte (encoding: ???)
// Rest of the file contains 0x00.

namespace FFXIVUtils.FileTypes {

  /// <summary>A User Macros file (MACRO.DAT).</summary>
  public sealed class UserMacros : CharacterDataFile {
  
  }

}