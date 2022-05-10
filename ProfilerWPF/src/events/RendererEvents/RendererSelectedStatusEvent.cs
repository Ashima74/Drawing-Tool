using Prism.Events;

namespace ProfilerWPF.events.RendererEvents
{
    /// <summary>
    /// Represents an event updating whether there is a shape selected in the renderer
    /// </summary>
    public class RendererSelectedStatusEvent : PubSubEvent<bool>
    {

    }
}