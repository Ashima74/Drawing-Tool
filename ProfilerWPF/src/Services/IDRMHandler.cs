namespace ProfilerWPF.Services
{
    public interface IDRMHandler
    {
        //provides two methods one is to add the drm and the other is to remove it.
        //bool will return whether the operation is successful if it returns false it means that the drm was already applied.
        public bool addDRM(string filepath);
        //bool will return whether the operation is successful if it returns false it means that the drm was not applied.
        public bool removeDRM(string filepath);
    }
}