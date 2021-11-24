using System;
using XferPrintLib.Utility.Log;

namespace XferPrintLib.Configuration
{

    public enum RecipeStatus
    {
        Valid, XmlErrorsWhileReading, Errors, Warnings, Invalid
    }
    public class AppConfiguration : IAppConfiguration
    {
        public static XferPrintRecipe XferRecipe = new XferPrintRecipe();
        public static XferPrintConfig PrConfig = new XferPrintConfig();

        public XferPrintRecipe Recipe
        {
            get
            {
                return XferRecipe;
            }
            set
            {
                XferRecipe = value;
            }
        }

        public XferPrintConfig Config
        {
            get
            {
                return PrConfig;
            }
            set
            {
                PrConfig = value;
            }
        }

        private XferPrintConfigReader _configReader = new XferPrintConfigReader();
        private XferPrintRecipeReader _recipeReader = new XferPrintRecipeReader();
        private XferPrintRecipe _recipe;
        private XferPrintRecipeValidationErrors _errorsRecipe;
        private bool _isValid = false;
        private string _recipePath = null;
        private string _tempRecipePath;
        private XferXmlReaderResult<XferPrintRecipe> tempResult;

        public RecipeStatus LoadRecipe(string recipePath)
        {
            _tempRecipePath = recipePath;
            _isValid = false;
            tempResult = null;
            try
            {
                tempResult = _recipeReader.Read(recipePath);
            }
            catch (FailedToParseXferPrintConfig ex)
            {
                Logger.WriteEventLog("Failed to parse recipe" , ex.Message);
                return RecipeStatus.Invalid;
            }
            
            _errorsRecipe = new XferPrintRecipeValidationErrors();

            if (tempResult.Errors.Count > 0)
            {
                _errorsRecipe.XmlErrors = tempResult.Errors;
                if (tempResult.Object != null)
                {
                    tempResult.Object.Save("", recipePath);
                }
                return RecipeStatus.XmlErrorsWhileReading;
            }

            return LoadRecipe(tempResult.Object);
        }

        public void SaveTempRecipe(string path)
        {
            tempResult.Object.Save("", path);
        }

        public RecipeStatus LoadRecipe(XferPrintRecipe recipe)
        {
            _isValid = false;
            if (recipe == null)
            {
                return RecipeStatus.Invalid;
            }

            _errorsRecipe = new XferPrintRecipeObjectValidator().Validate(recipe);
            if (_errorsRecipe.GetObjectErrors() != null)
            {
                XferRecipe = _recipe;
                return RecipeStatus.Errors;
            }

            _recipe = recipe;
            XferRecipe = recipe;
            XferPrintRecipe.ProcessRecipeLoaded = true;
            if (_errorsRecipe.GetMissingToolblocks() != null)
            {
                _isValid = true;
                return RecipeStatus.Warnings;
            }

            _isValid = true;
            if (_tempRecipePath != null)
            {
                _recipePath = _tempRecipePath;
            }
            return RecipeStatus.Valid;
        }

        public bool IsRecipeValid()
        {
            return _isValid;
        }

        public XferPrintRecipeValidationErrors GetRecipeErrors()
        {
            return _errorsRecipe;
        }

        public RecipeStatus ReloadRecipe()
        {
            return LoadRecipe(_recipePath);
        }

    }
}
