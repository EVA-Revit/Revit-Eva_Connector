#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit_Eva_Connector.Items
{
    public class CircuitItem : GenericItem
    {
        public string? TypeLoadName { get; set; }
        public string? LoadName { get; set; }
        public string? AccountingModeLoads { get; set; }
        public string? PhaseConnecting { get; set; }
        public string? CosF { get; set; }
        public string? Pcurrent { get; set; }
        public string? Icurrent { get; set; }
        public string? CableDesignation { get; set; }
        public string? SingleOrMultiple { get; set; }
        public string? MarkCable { get; set; }
        public string? SectionCable11 { get; set; }
        public string? SectionCable12 { get; set; }
        public string? SectionCable13 { get; set; }
        public string? FactLenCable1 { get; set; }
        public string? SectionCable21 { get; set; }
        public string? SectionCable22 { get; set; }
        public string? SectionCable23 { get; set; }
        public string? FactLenCable2 { get; set; }
        public string? LenForCountTKZ { get; set; }
        public string? LenCableCurrent { get; set; }
        public string? AdmissibleLoss { get; set; }
        public string? CurrentLoss { get; set; }
        public string? SetWorkWinterSummer { get; set; }
        public string? CurrentTKZendLine { get; set; }
        public string? CountElements { get; set; }
        public string? TypePipe { get; set; }
        public string? DiameterPipe { get; set; }
        public string? LenPipe { get; set; }
        public string? LenCableInTray { get; set; }
        public string? Room { get; set; }
        public string? TextName { get; set; }
        public string? DoubleName { get; set; }
        public string? Project { get; set; }
        public string? Functional { get; set; }

    }

}
