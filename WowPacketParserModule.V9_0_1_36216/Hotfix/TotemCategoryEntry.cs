using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.TotemCategory, HasIndexInData = false)]
    public class TotemCategoryEntry
    {
        public string Name { get; set; }
        public byte TotemCategoryType { get; set; }
        public int TotemCategoryMask { get; set; }
    }
}
