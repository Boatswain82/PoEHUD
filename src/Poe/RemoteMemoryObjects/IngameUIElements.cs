using PoeHUD.Poe.Elements;
using System.Collections.Generic;
using System.IO;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element QuestTracker => ReadObjectAt<Element>(0x9F4 + Offsets.GarenaTWDelta);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xA1C + Offsets.GarenaTWDelta);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xA20 + Offsets.GarenaTWDelta);
        public Element InventoryPanel => ReadObjectAt<Element>(0xA38 + Offsets.GarenaTWDelta);
        public Element TreePanel => ReadObjectAt<Element>(0xA4C + Offsets.GarenaTWDelta);
        public Element AtlasPanel => ReadObjectAt<Element>(0xA50 + Offsets.GarenaTWDelta);
        public Map Map => ReadObjectAt<Map>(0xA68 + Offsets.GarenaTWDelta);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xA6C + Offsets.GarenaTWDelta);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xB38 + Offsets.GarenaTWDelta);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xB48 + Offsets.GarenaTWDelta);
    }
}