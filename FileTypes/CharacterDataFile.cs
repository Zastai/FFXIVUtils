// A DAT file stored in a character folder.

// Information initially based on http://ffxivexplorer.fragmenterworks.com/research/macros.txt.

// 16-byte Header:
//   int16 Unknown
//   int16 Unknown
//   int32 FileSize     (not including the header)
//   int32 PayloadSize  (size of actual data in use (so <= FileSize)
//   int32 Unknown
// When the first byte of the payload (i.e. the byte at offset 0x10) is 0xff, this seems to indicate that the rest of the payload is XORed with 0x73.
// Padding bytes past the payload will be 0x00.

namespace FFXIVUtils.FileTypes {

  /// <summary>A character data file.</summary>
  public abstract class CharacterDataFile {
  
  }

}