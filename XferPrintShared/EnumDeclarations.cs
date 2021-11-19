namespace XferPrintLib
{
    public enum CycleFileType
    {
        None,
        XML,
        CSV
    }

    public enum ReferencePositions
    {
        Source,
        Target,
        Clean
    }


    public enum SubstrateChucks
    {
        Target,
        Source1,
        Source2,
        Source3,
        Cleaning_Tape
    }

    /// <summary>
    /// This might be more appropriately named PatternAndRegistrationLocations. The Clean location is the only one that seems to be only used as a registration location. 
    /// </summary>
    public enum PatternLocations
    {
        Default,
        Source,
        Target,
        Stamp,
        SourceAlign,
        Metrology,
        HeightSensorXYZCalWafer,
        Clean // TODO: Ed - Check the naming convention here with the larger group. ~Ed
    }


    public enum PatternTypes
    {
        Alignment,
        Registration,
        ToolBlock
    }

    /// <summary>
    /// XMLProcessRecipe refers to V6/V7 process recipe. XmlSerializedProcessRecipe is V8+ process recipe.
    /// </summary>
    public enum ParameterFileTypes
    {
        XmlSerializedProcessRecipe
    }

    public enum SavedCleaningLocationType
    {
        Legacy,
        Automated
    }

    public enum PrintAssistDir
    {
        X,
        Y,
        Z
    }

    public enum IllumMagControls
    {
        Lo,
        Hi,
        All
    }

    public enum RecipeSection
    {
        Recipe,
        Stamp,
        Source,
        Target,
        Clean,
        Metrology,
        All
    }

    public enum MetroSubType
    {
        Source,
        Target,
        Stamp,
        StampRunout
    }

    public enum RecipeRunTypes
    {
        RunRec,
        RunMetro,
        RunWaferCycle,
        CustomStart
    }

    // types of metrology runs-               MetroRunType
    public enum MetroRunType
    {
        SingleField,
        Batch,
        Custom
    }

    // Types of Pattern recognition method    MetroPRType
    public enum MetroPRType
    {
        OneImagePosition,
        TwoImagePosition,
        CountOnly,
        ImageCaptureOnly
    }

    // Types of camera grab methods           MetroFrameType
    public enum MetroFrameType
    {
        ContinuousGrab,
        Triggered
    }

    public enum RecipeOrientation
    {
        Horizontal,
        Vertical
    }

    public enum RecipeRotation
    {
        Center,
        S_W, // S and W are Same Buttons
        N_E, // N ant W are Same Buttons
        Other
    }

    public enum RegistrationType
    {
        XY, Z
    }

    public enum Substrates
    {
        Target, Source, Cleaning_Tape
    }

    public enum HSPathAlgorithms
    {
        None,
        N,
        S,
        E,
        W,
        Cross,
        X,
        NE,
        SE,
        NW,
        SW,
        N_Efficient,
        S_Efficient,
        E_Efficient,
        W_Efficient,
        NE_Efficient,
        SE_Efficient,
        NW_Efficient,
        SW_Efficient
        // NThruCenter
        // EThruCenter
    }

    public enum WaferTypes
    {
        Source,
        Target,
        Cleaning_Tape
    }
}
