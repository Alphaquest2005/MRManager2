using System.ComponentModel.Composition;

namespace SystemInterfaces
{
    [InheritedExport]
    public interface IMachineInfo{

        string MachineName { get; }
        int Processors { get; }
    }

    [InheritedExport]
    public interface IApplicationSetting
    {
        bool AutoRun { get; }
    }
}
