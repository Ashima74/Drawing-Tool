 using Prism.Events;
using ProfilerWPF.data.Models.EntityModels;

namespace ProfilerWPF.events.SettingsEvents
{
    /// <summary>
    /// Represents an event publishing a tool that has been 
    /// </summary>
    public class ToolSelectedEvent : PubSubEvent<Tool>
    {

    }
}
