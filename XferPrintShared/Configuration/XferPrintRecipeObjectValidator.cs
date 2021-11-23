using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using XferPrintLib.Utility.Log;

namespace XferPrintLib.Configuration
{
    public class XferPrintRecipeObjectValidator
    {
        private XferPrintRecipeValidationErrors _errors;

        private void ValidateClassForMtpProcess(XferPrintRecipe recipe)
        {
            decimal PostsPitchX, PostsPitchY, ChipletsPitchX, ChipletsPitchY;
            double Source11PosX, Source11PosY, Target11PosX, Target11PosY;


            // non-zero checking is handled by schema - "positive integer"
            // integer ratios - check source indexing

            PostsPitchX = (decimal)recipe.Stamp.StampXPostPitch;
            PostsPitchY = (decimal)recipe.Stamp.StampYPostPitch;
            ChipletsPitchX = (decimal)recipe.Source.SourceXChipletPitch;
            ChipletsPitchY = (decimal)recipe.Source.SourceYChipletPitch;
            Source11PosX = recipe.Source.SourceR1C1XPosGlobal;
            Source11PosY = recipe.Source.SourceR1C1YPosGlobal;
            Target11PosX = recipe.Target.TargetR1C1XPosGlobal;
            Target11PosY = recipe.Target.TargetR1C1YPosGlobal;

            // check X ratio
            if (PostsPitchX % ChipletsPitchX != 0m)
            {
                _errors.AddError("MTP: Invalid X ratio between stamp post pitch and chiplet pitch");
            }

            // check Y ratio
            if (PostsPitchY % ChipletsPitchY != 0m)
            {
                _errors.AddError("MTP: Invalid Y ratio between stamp post pitch and chiplet pitch");
            }

            // Check if 1,1,1 positions are the same for source and target
            if (Math.Round(Source11PosX, 2) == Math.Round(Target11PosX, 2) && (Math.Round(Source11PosY, 2) == Math.Round(Target11PosY, 2)))
            {
                _errors.AddError("MTP: Source and Target 1,1,1 positions are the same");
            }

            if (_errors.GetObjectErrors() != null)
            {
                _errors.AddError($"{Environment.NewLine}IMPORTANT: The Loaded recipe has invalid Print Parameters and will not be loaded." +
                                 $"{Environment.NewLine}{Environment.NewLine}" +
                                 $"Please use the XferPrint Utility - Recipe Editor to correct the recipe.");
            }
            
        }

        private void ValidateClassForWarnings(XferPrintRecipe recipe)
        {
            var collFilenames = new StringCollection();
            // Check for warnings -- files don't exist -- recipe can be edited but not run

            // Add all file names to string collection
            collFilenames.Add(recipe.Source.PatternSourceFilename);
            collFilenames.Add(recipe.Target.MetroMarksFilename);
            collFilenames.Add(recipe.Source.SourceRegPatternFilename);
            collFilenames.Add(recipe.Target.TargetRegPatternFilename);
            collFilenames.Add(recipe.Stamp.StampRegPatternFilename);
            collFilenames.Add(recipe.Source.SourceAlignPatternFilename);

            // add these lines for checking lo mag registration and tool block files when ready

            collFilenames.Add(recipe.Source.SourceRegPatternFilenameLo);
            collFilenames.Add(recipe.Target.TargetRegPatternFilenameLo);


            if (recipe.Source.SourceTBlockInUse)
            {
                collFilenames.Add(recipe.Source.SourceTBlockFilename);
            }
            if (recipe.Target.TargetTBlockInUse)
            {
                collFilenames.Add(recipe.Target.TargetTBlockFilename);
            }

            if (recipe.Source.SourceAlignTBlockInUse)
            {
                collFilenames.Add(recipe.Source.SourceAlignTBlockFilename);
            }
            if (recipe.Metrology.MetroTBlockInUse)
            {
                collFilenames.Add(recipe.Metrology.MetroTBlockFilename);

                // Check to see if pattern paths are legit
            }

            foreach (string file in collFilenames)
            {
                if (!File.Exists(file))
                {
                    string tag = "WARNING: File does not exist: " + file;
                    _errors.AddMissingToolblock(tag);
                    Logger.WriteEventLog(tag, "");
                }
            }
        }


        public XferPrintRecipeValidationErrors Validate(XferPrintRecipe recipe)
        {
            _errors = new XferPrintRecipeValidationErrors();
            ValidateClassForMtpProcess(recipe);
            ValidateClassForWarnings(recipe);
            return _errors;
        }
    }
}
