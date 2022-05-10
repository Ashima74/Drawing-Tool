using System.Collections.Generic;

#nullable disable

namespace ProfilerWPF.data.Models.EntityModels
{
    public partial class ToolChanger
    {
        public ToolChanger()
        {
            AvailableTools = new HashSet<AvailableTool>();
        }

        public long Number { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double? XPosition { get; set; }
        public double? YPosition { get; set; }
        public double? ZPosition { get; set; }
        public long? IsOnGantry { get; set; }
        public long? RequiresPositioning { get; set; }
        public double? PositionTolerance { get; set; }
        public long? NumToolSlots { get; set; }
        public long? AlwaysCalibrate { get; set; }
        public long? ModbusSlaveNumber { get; set; }
        public long? StatusRegister { get; set; }
        public long? ErrorRegister { get; set; }
        public long? SlotNumberRegister { get; set; }
        public double? ToolChangeTimeout { get; set; }
        public double? ToolRackTimeout { get; set; }
        public long? RaiseToolRackOutputBit { get; set; }
        public long? ToolRackIsRaisedInputBit { get; set; }
        public long? UseApproachPosition { get; set; }
        public double? XApproachPosition { get; set; }
        public double? YApproachPosition { get; set; }
        public double? ZApproachPosition { get; set; }

        public virtual DigitalOutput RaiseToolRackOutputBitNavigation { get; set; }
        public virtual DigitalInput ToolRackIsRaisedInputBitNavigation { get; set; }
        public virtual ToolChangeTypeEnum TypeNavigation { get; set; }
        public virtual ICollection<AvailableTool> AvailableTools { get; set; }
    }
}
