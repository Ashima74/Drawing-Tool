using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using ProfilerWPF.data.Models.EntityModels;

namespace ProfilerWPF.src.events.SettingsEvents
{
    class GroupSetEvent : PubSubEvent<GroupDatum>
    {
    }
}
