#nullable enable
namespace Revit_Eva_Connector.Items
{
    public class GenericItem
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Установленная мощность
        /// </summary>
        public string? Pset { get; set; }
        public bool? PsetIn { get; set; }
        public bool? PsetOut { get; set; }
    }
}
