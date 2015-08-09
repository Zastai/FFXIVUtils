// User Macros (stored in the character folders)

// Original information from http://ffxivexplorer.fragmenterworks.com/research/macros.txt.

// Fixed Size (286752 / 0x46010)
// Header:
//   int16 VersionMajor (1)
//   int16 VersionMinor (1)
//   int32 FileSize     (not including the header, so 0x46000)
//   int32 PayloadSize  (starting from 0x10)
// Payload:
// - "Encrypted" via XOR with 0x73
// - 100 sets of 18 blocks (title, icon, key and 15 lines)
//   - each block has:
//     char  Type;         // T(itle) I(con) K(ey) L(ine)
//     int16 Length;       // Length (between 1 and 181)
//     char  Text[Length]; // Text, with trailing 0 byte (encoding: ???)
// Rest of the file contains 0x00.

namespace FFXIVUtils.FileTypes {

  /// <summary>A User Macros file.</summary>
  public sealed class UserMacros {
  
  }

}