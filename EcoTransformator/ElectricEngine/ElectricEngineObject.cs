using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

namespace Eco.Mods.TechTree
{
    [Serialized]
    [RequireComponent(typeof(SolidGroundComponent))]
    public partial class ElectricEngineObject : WorldObject, IRepresentsItem
    {
        public override LocString DisplayName
        {
            get { return Localizer.DoStr("Electric engine"); }
        }
        public override LocString DisplayDescription
        {
            get { return Localizer.DoStr("Object Description"); }
        }

        public Type RepresentedItemType { get { return typeof(ElectricEngineItem); } }

        protected override void Initialize()
        {
            base.Initialize();
        }

        static ElectricEngineObject() { }

        public override void Destroy()
        {
            base.Destroy();
        }
    }

    
    /*
    [RequiresSkill(typeof(IndustrySkill), 3)]
    public partial class ElectricEngineRecipe : RecipeFamily
    {
        public ElectricEngineRecipe()
        {
            // this.Initialize(Localizer.DoStr("Recipe string"), typeof(ElectricEngineRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "ElectricEngine",
                    Localizer.DoStr("Recipe text"),
                    new IngredientElement[]
                    {
                        new IngredientElement(typeof(IronGearItem), 1)
                    },
                    new CraftingElement<ElectricEngineItem>())
            };

            //this.LaborInCalories = CreateLaborInCaloriesValue(500, typeof(IndustrySkill));
            //this.ExperienceOnCraft = 5;
            //this.CraftMinutes = CreateCraftTimeValue(typeof(ElectricEngineRecipe), 5, typeof(IndustrySkill));
            // CraftingComponent.AddRecipe(typeof(WorkbenchObject), this);
        }
    }
    */

}
