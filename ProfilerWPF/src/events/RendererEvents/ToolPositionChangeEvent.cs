using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfilerWPF.events.RendererEvents
{
    public class ToolPositionChangeEvent : PubSubEvent<(float x, float y, float z)>
    {

    }
}
