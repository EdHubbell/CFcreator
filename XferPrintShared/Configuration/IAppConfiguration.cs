namespace XferPrintLib.Configuration
{
    public interface IAppConfiguration
    {
        XferPrintRecipe Recipe { get; set; }
        XferPrintConfig Config { get; set; }
        RecipeStatus LoadRecipe(string recipePath);
        RecipeStatus LoadRecipe(XferPrintRecipe recipe);
        XferPrintRecipeValidationErrors GetRecipeErrors();
        bool IsRecipeValid();
        RecipeStatus ReloadRecipe();
        void SaveTempRecipe(string path);

    }
}