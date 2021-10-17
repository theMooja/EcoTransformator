using Eco.Gameplay.Items;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serialized]
[Currency]
[MaxStackSize(1)]
[LocDisplayName("Electric engine")]

public partial class ElectricEngineItem : WorldObjectItem<ElectricEngineObject>
{
    public override LocString DisplayDescription
    {
        get { return Localizer.DoStr("Electric engine"); }
    }


    static ElectricEngineItem()
    {

    }
}