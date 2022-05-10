using System;
using OpenTK.Mathematics;
using Prism.Events;

namespace ProfilerWPF.events.RendererEvents
{
    /// <summary>
    /// Represents an event updating the position of the currently selected item from the renderer
    /// Will be null if nothing is selected from the renderer
    /// </summary>
    public class RendererSelectedPositionEvent : PubSubEvent<Nullable<Vector3>>
    {

    }
}
