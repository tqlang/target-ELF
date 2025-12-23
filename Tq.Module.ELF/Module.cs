using Tq.Realizer.Core.Configuration;
using Tq.Realizer.Core.Configuration.LangOutput;

namespace Tq.Module.ELF;


public class Module: IModule
{
    public ModuleConfiguration Config { get; } = new()
    {
        Name = "ELF",
        Description = "Provides targets for compiling to realizer's executable and linkable format",
        
        Author = "lumi2021",
        Version = "1.0.0",
        
        Targets = [
            new TargetConfiguration
            {
                TargetName = "realizer's ELF",
                TargetDescription = "Compiles to realizer's executable and linkable format",
                TargetIdentifier = "elf",
                
                LanguageOutput = new OmegaOutputConfiguration() {
                    BakeGenerics = false,
                    AbstractingOptions = AbstractingOptions.None,
                    
                    MemoryUnit = 1,
                    NativeIntegerSize = 0,
                    
                    GenericAllowedFeatures = GenericAllowedFeatures.None, 
                    OmegaAllowedFeatures = OmegaAllowedFeatures.None,
                },
                
                CompilerInvoke = (a, b) => new Compiler().Compile(a, b)
            },
        ]
    };
}
