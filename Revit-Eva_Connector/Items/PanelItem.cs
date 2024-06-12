#nullable enable
using System.Collections.Generic;

namespace Revit_Eva_Connector.Items
{
    /// <summary>
    /// Панель
    /// </summary>
    public class PanelItem : GenericItem
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string? Name { get; set; }



        /// <summary>
        /// Электрические цепи
        /// </summary>
        public List<CircuitItem>? CircuitItems { get; set; }

        /// <summary>
        /// Режим (Зима/Лето/Зима пожар/Лето пожар)
        /// </summary>
        public string? Mode1 { get; set; }
        public bool? Mode1In { get; set; }
        public bool? Mode1Out { get; set; }

        /// <summary>
        /// Коэффициент спроса
        /// </summary>
        public string? Kc1 { get; set; }
        public bool? Kc1In { get; set; }
        public bool? Kc1Out { get; set; }

        /// <summary>
        /// Расчетная мощность
        /// </summary>
        public string? Pcurrent1 { get; set; }
        public bool? Pcurrent1In { get; set; }
        public bool? Pcurrent1Out { get; set; }

        /// <summary>
        /// Полная мощность
        /// </summary>
        public string? Scurrent1 { get; set; }
        public bool? Scurrent1In { get; set; }
        public bool? Scurrent1Out { get; set; }

        /// <summary>
        /// Cos
        /// </summary>
        public string? Cos1 { get; set; }
        public bool? Cos1In { get; set; }
        public bool? Cos1Out { get; set; }

        /// <summary>
        /// Расчетный ток
        /// </summary>
        public string? Icurrent1 { get; set; }
        public bool? Icurrent1In { get; set; }
        public bool? Icurrent1Out { get; set; }


        /// <summary>
        /// Режим (Зима/Лето/Зима пожар/Лето пожар)
        /// </summary>
        public string? Mode2 { get; set; }
        public bool? Mode2In { get; set; }
        public bool? Mode2Out { get; set; }

        /// <summary>
        /// Коэффициент спроса
        /// </summary>
        public string? Kc2 { get; set; }
        public bool? Kc2In { get; set; }
        public bool? Kc2Out { get; set; }

        /// <summary>
        /// Расчетная мощность
        /// </summary>
        public string? Pcurrent2 { get; set; }
        public bool? Pcurrent2In { get; set; }
        public bool? Pcurrent2Out { get; set; }

        /// <summary>
        /// Полная мощность
        /// </summary>
        public string? Scurrent2 { get; set; }
        public bool? Scurrent2In { get; set; }
        public bool? Scurrent2Out { get; set; }

        /// <summary>
        /// Cos
        /// </summary>
        public string? Cos2 { get; set; }
        public bool? Cos2In { get; set; }
        public bool? Cos2Out { get; set; }

        /// <summary>
        /// Расчетный ток
        /// </summary>
        public string? Icurrent2 { get; set; }
        public bool? Icurrent2In { get; set; }
        public bool? Icurrent2Out { get; set; }

        /// <summary>
        /// Режим (Зима/Лето/Зима пожар/Лето пожар)
        /// </summary>
        public string? Mode3 { get; set; }
        public bool? Mode3In { get; set; }
        public bool? Mode3Out { get; set; }

        /// <summary>
        /// Коэффициент спроса
        /// </summary>
        public string? Kc3 { get; set; }
        public bool? Kc3In { get; set; }
        public bool? Kc3Out { get; set; }

        /// <summary>
        /// Расчетная мощность
        /// </summary>
        public string? Pcurrent3 { get; set; }
        public bool? Pcurrent3In { get; set; }
        public bool? Pcurrent3Out { get; set; }

        /// <summary>
        /// Полная мощность
        /// </summary>
        public string? Scurrent3 { get; set; }
        public bool? Scurrent3In { get; set; }
        public bool? Scurrent3Out { get; set; }

        /// <summary>
        /// Cos
        /// </summary>
        public string? Cos3 { get; set; }
        public bool? Cos3In { get; set; }
        public bool? Cos3Out { get; set; }

        /// <summary>
        /// Расчетный ток
        /// </summary>
        public string? Icurrent3 { get; set; }
        public bool? Icurrent3In { get; set; }
        public bool? Icurrent3Out { get; set; }

        /// <summary>
        /// Режим (Зима/Лето/Зима пожар/Лето пожар)
        /// </summary>
        public string? Mode4 { get; set; }
        public bool? Mode4In { get; set; }
        public bool? Mode4Out { get; set; }

        /// <summary>
        /// Коэффициент спроса
        /// </summary>
        public string? Kc4 { get; set; }
        public bool? Kc4In { get; set; }
        public bool? Kc4Out { get; set; }

        /// <summary>
        /// Расчетная мощность
        /// </summary>
        public string? Pcurrent4 { get; set; }
        public bool? Pcurrent4In { get; set; }
        public bool? Pcurrent4Out { get; set; }

        /// <summary>
        /// Полная мощность
        /// </summary>
        public string? Scurrent4 { get; set; }
        public bool? Scurrent4In { get; set; }
        public bool? Scurrent4Out { get; set; }

        /// <summary>
        /// Cos
        /// </summary>
        public string? Cos4 { get; set; }
        public bool? Cos4In { get; set; }
        public bool? Cos4Out { get; set; }

        /// <summary>
        /// Расчетный ток
        /// </summary>
        public string? Icurrent4 { get; set; }
        public bool? Icurrent4In { get; set; }
        public bool? Icurrent4Out { get; set; }
    }
}
