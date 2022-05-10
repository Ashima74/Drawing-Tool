namespace ProfilerWPF.data.FileDialogServices
{
    public interface IOpenFileService
    {
        string[] FileNames { get; }
        bool? OpenFile();
    }
}
