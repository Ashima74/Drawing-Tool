using Prism.Events;

namespace ProfilerWPF.events.RendererEvents
{
    /// <summary>
    /// Represents an event updating the current mouse position
    /// </summary>
    public class RendererMouseMoveEvent : PubSubEvent<(float x,float y,float z)>
    {
       
    }
}
