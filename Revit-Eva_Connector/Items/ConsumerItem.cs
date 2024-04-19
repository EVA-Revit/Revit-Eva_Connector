#nullable enable
namespace Revit_Eva_Connector.Items
{
    public class ConsumerItem : GenericItem
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
        public bool? LoadNameIn{ get; set; }
        public bool? LoadNameOut{ get; set; }

        /// <summary>
        /// Cos
        /// </summary>
        public string? CosF { get; set; }
        public bool? CosFin { get; set; }
        public bool? CosFout { get; set; }

        /// <summary>
        /// Вспомогательный текстовый параметр
        /// </summary>
        public string? TextName { get;set; }
        public bool? TextNameIn { get;set; }
        public bool? TextNameOut { get;set; }

        /// <summary>
        /// Вспомогательный числовой параметр
        /// </summary>
        public string? DoubleName { get; set; }
        public bool? DoubleNameIn { get; set; }
        public bool? DoubleNameOut { get; set; }
    }
}
