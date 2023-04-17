using System;
using System.Collections.Generic;

namespace CaiLib.Utils
{
	// Token: 0x0200000E RID: 14
	public class RecipeUtils
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002A44 File Offset: 0x00000C44
		public static ComplexRecipe AddComplexRecipe(ComplexRecipe.RecipeElement[] input, ComplexRecipe.RecipeElement[] output, string fabricatorId, float productionTime, string recipeDescription, ComplexRecipe.RecipeNameDisplay nameDisplayType, int sortOrder, string requiredTech = null)
		{
			return new ComplexRecipe(ComplexRecipeManager.MakeRecipeID(fabricatorId, input, output), input, output)
			{
				time = productionTime,
				description = recipeDescription,
				nameDisplay = nameDisplayType,
				fabricators = new List<Tag>
				{
					fabricatorId
				},
				sortOrder = sortOrder,
				requiredTech = requiredTech
			};
		}
	}
}
