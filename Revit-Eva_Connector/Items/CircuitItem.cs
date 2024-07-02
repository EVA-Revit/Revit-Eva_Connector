#nullable enable
namespace Revit_Eva_Connector.Items
{
    /// <summary>
    /// Электрическая цепь
    /// </summary>
    public class CircuitItem : GenericItem
    {
        /// <summary>
        /// Тип нагрузки
        /// </summary>
        public string? TypeLoadName { get; set; }
        public bool? TypeLoadNameIn { get; set; }
        public bool? TypeLoadNameOut { get; set; }

        /// <summary>
        /// Наименование нагрузки
        /// </summary>
        public string? LoadName { get; set; }
        public bool? LoadNameIn { get; set; }
        public bool? LoadNameOut { get; set; }

        

        /// <summary>
        /// Фаза подключения
        /// </summary>
        public string? PhaseConnecting { get; set; }
        public bool? PhaseConnectingIn { get; set; }
        public bool? PhaseConnectingOut { get; set; }

        /// <summary>
        /// Cos
        /// </summary>
        public string? CosF { get; set; }
        public bool? CosFin { get; set; }
        public bool? CosFout { get; set; }

        /// <summary>
        /// Расчетная мощность
        /// </summary>
        public string? Pcurrent { get; set; }
        public bool? PcurrentIn { get; set; }
        public bool? PcurrentOut { get; set; }

        /// <summary>
        /// Расчетный ток
        /// </summary>
        public string? Icurrent { get; set; }
        public bool? IcurrentIn { get; set; }
        public bool? IcurrentOut { get; set; }

        /// <summary>
        /// Обозначение кабеля
        /// </summary>
        public string? CableDesignation { get; set; }
        public bool? CableDesignationIn { get; set; }
        public bool? CableDesignationOut { get; set; }

        /// <summary>
        /// Марка кабеля
        /// </summary>
        public string? MarkCable { get; set; }
        public bool? MarkCableIn { get; set; }
        public bool? MarkCableOut { get; set; }

        /// <summary>
        /// Сечение кабеля 1
        /// </summary>
        public string? SectionCable11 { get; set; }
        public bool? SectionCable1In { get; set; }
        public bool? SectionCable1Out { get; set; }

        /// <summary>
        /// Сечение кабеля 1
        /// </summary>
        public string? SectionCable12 { get; set; }

        /// <summary>
        /// Сечение кабеля 1
        /// </summary>
        public string? SectionCable13 { get; set; }

        /// <summary>
        /// Фактическая длина кабеля 1
        /// </summary>
        public string? FactLenCable1 { get; set; }
        public bool? FactLenCable1In { get; set; }
        public bool? FactLenCable1Out { get; set; }

        /// <summary>
        /// Сечение кабеля 2
        /// </summary>
        public string? SectionCable21 { get; set; }
        public bool? SectionCable2In { get; set; }
        public bool? SectionCable2Out { get; set; }

        /// <summary>
        /// Сечение кабеля 2
        /// </summary>
        public string? SectionCable22 { get; set; }

        /// <summary>
        /// Сечение кабеля 2
        /// </summary>
        public string? SectionCable23 { get; set; }

        /// <summary>
        /// Фактическая длина кабеля 2
        /// </summary>
        public string? FactLenCable2 { get; set; }
        public bool? FactLenCable2In { get; set; }
        public bool? FactLenCable2Out { get; set; }

        /// <summary>
        /// Сечение кабеля 3
        /// </summary>
        public string? SectionCable31 { get; set; }
        public bool? SectionCable3In { get; set; }
        public bool? SectionCable3Out { get; set; }

        /// <summary>
        /// Сечение кабеля 3
        /// </summary>
        public string? SectionCable32 { get; set; }

        /// <summary>
        /// Сечение кабеля 3
        /// </summary>
        public string? SectionCable33 { get; set; }

        /// <summary>
        /// Фактическая длина кабеля 3
        /// </summary>
        public string? FactLenCable3 { get; set; }
        public bool? FactLenCable3In { get; set; }
        public bool? FactLenCable3Out { get; set; }

        /// <summary>
        /// Длина для расчета ТКЗ
        /// </summary>
        public string? LenForCountTkz { get; set; }
        public bool? LenForCountTkzIn { get; set; }
        public bool? LenForCountTkzOut { get; set; }

        /// <summary>
        /// Расчетная длина кабеля
        /// </summary>
        public string? LenCableCurrent { get; set; }
        public bool? LenCableCurrentIn { get; set; }
        public bool? LenCableCurrentOut { get; set; }

        /// <summary>
        /// Расчетные потери напряжения на участке
        /// </summary>
        public string? CurrentLoss { get; set; }
        public bool? CurrentLossIn { get; set; }
        public bool? CurrentLossOut { get; set; }

        /// <summary>
        /// Расчет ТКЗ в конце линии
        /// </summary>
        public string? CurrentTkzEndLine { get; set; }
        public bool? CurrentTkzEndLineIn { get; set; }
        public bool? CurrentTkzEndLineOut { get; set; }

        /// <summary>
        /// Кол-во электро приемников
        /// </summary>
        public string? CountElements { get; set; }
        public bool? CountElementsIn { get; set; }
        public bool? CountElementsOut { get; set; }

        /// <summary>
        /// Тип трубы 1
        /// </summary>
        public string? TypePipe1 { get; set; }
        public bool? TypePipe1In { get; set; }
        public bool? TypePipe1Out { get; set; }

        /// <summary>
        /// Диаметр трубы 1
        /// </summary>
        public string? DiameterPipe1 { get; set; }
        public bool? DiameterPipe1In { get; set; }
        public bool? DiameterPipe1Out { get; set; }

        /// <summary>
        /// Длина трубы 1
        /// </summary>
        public string? LenPipe1 { get; set; }
        public bool? LenPipe1In { get; set; }
        public bool? LenPipe1Out { get; set; }

        /// <summary>
        /// Тип трубы 2
        /// </summary>
        public string? TypePipe2 { get; set; }
        public bool? TypePipe2In { get; set; }
        public bool? TypePipe2Out { get; set; }

        /// <summary>
        /// Диаметр трубы 2
        /// </summary>
        public string? DiameterPipe2 { get; set; }
        public bool? DiameterPipe2In { get; set; }
        public bool? DiameterPipe2Out { get; set; }

        /// <summary>
        /// Длина трубы 2
        /// </summary>
        public string? LenPipe2 { get; set; }
        public bool? LenPipe2In { get; set; }
        public bool? LenPipe2Out { get; set; }

        /// <summary>
        /// Помещение
        /// </summary>
        public string? Room { get; set; }
        public bool? RoomIn { get; set; }
        public bool? RoomOut { get; set; }

        /// <summary>
        /// Проект
        /// </summary>
        public string? Project { get; set; }
        public bool? ProjectIn { get; set; }
        public bool? ProjectOut { get; set; }

        /// <summary>
        /// Потребитель панель
        /// Автоматически заполняемое свойство
        /// </summary>
        public bool? IsConsumerIsPanel { get; set; }
        public bool? IsConsumerIsPanelIn { get; set; }
        public bool? IsConsumerIsPanelOut { get; set; }


    }
}
