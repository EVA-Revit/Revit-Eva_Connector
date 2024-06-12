namespace Revit_Eva_Connector.UserConfigs;

using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.DB;
using EvaAPI.MVVM;
using System.Collections.Generic;
using System.Reflection;

public class PanelParametersUserConfig : PropertyObserver
{
    private string _pset;
    private bool _psetIn;
    private bool _psetOut;
    private string _mode1;
    private bool _mode1In;
    private bool _mode1Out;
    private string _kc1;
    private bool _kc1In;
    private bool _kc1Out;
    private string _pcurrent1;
    private bool _pcurrent1In;
    private bool _pcurrent1Out;
    private string _scurrent1;
    private bool _scurrent1In;
    private bool _scurrent1Out;
    private string _cos1;
    private bool _cos1In;
    private bool _cos1Out;
    private string _icurrent1;
    private bool _icurrent1In;
    private bool _icurrent1Out;
    private string _mode2;
    private bool _mode2In;
    private bool _mode2Out;
    private string _kc2;
    private bool _kc2In;
    private bool _kc2Out;
    private string _pcurrent2;
    private bool _pcurrent2In;
    private bool _pcurrent2Out;
    private string _scurrent2;
    private bool _scurrent2In;
    private bool _scurrent2Out;
    private string _cos2;
    private bool _cos2In;
    private bool _cos2Out;
    private string _icurrent2;
    private bool _icurrent2In;
    private bool _icurrent2Out;
    private string _mode3;
    private bool _mode3In;
    private bool _mode3Out;
    private string _kc3;
    private bool _kc3In;
    private bool _kc3Out;
    private string _pcurrent3;
    private bool _pcurrent3In;
    private bool _pcurrent3Out;
    private string _scurrent3;
    private bool _scurrent3In;
    private bool _scurrent3Out;
    private string _cos3;
    private bool _cos3In;
    private bool _cos3Out;
    private string _icurrent3;
    private bool _icurrent3In;
    private bool _icurrent3Out;
    private string _mode4;
    private bool _mode4In;
    private bool _mode4Out;
    private string _kc4;
    private bool _kc4In;
    private bool _kc4Out;
    private string _pcurrent4;
    private bool _pcurrent4In;
    private bool _pcurrent4Out;
    private string _scurrent4;
    private bool _scurrent4In;
    private bool _scurrent4Out;
    private string _cos4;
    private bool _cos4In;
    private bool _cos4Out;
    private string _icurrent4;
    private bool _icurrent4In;
    private bool _icurrent4Out;

    public string Pset
    {
        get => _pset;
        set
        {
            if (value == _pset) return;
            _pset = value;
            OnPropertyChanged();
        }
    }

    public bool PsetIn
    {
        get => _psetIn;
        set
        {
            if (value == _psetIn) return;
            _psetIn = value;
            OnPropertyChanged();
        }
    }

    public bool PsetOut
    {
        get => _psetOut;
        set
        {
            if (value == _psetOut) return;
            _psetOut = value;
            OnPropertyChanged();
        }
    }

    public string Mode1
    {
        get => _mode1;
        set
        {
            if (value == _mode1) return;
            _mode1 = value;
            OnPropertyChanged();
        }
    }

    public bool Mode1In
    {
        get => _mode1In;
        set
        {
            if (value == _mode1In) return;
            _mode1In = value;
            OnPropertyChanged();
        }
    }

    public bool Mode1Out
    {
        get => _mode1Out;
        set
        {
            if (value == _mode1Out) return;
            _mode1Out = value;
            OnPropertyChanged();
        }
    }

    public string Kc1
    {
        get => _kc1;
        set
        {
            if (value == _kc1) return;
            _kc1 = value;
            OnPropertyChanged();
        }
    }

    public bool Kc1In
    {
        get => _kc1In;
        set
        {
            if (value == _kc1In) return;
            _kc1In = value;
            OnPropertyChanged();
        }
    }

    public bool Kc1Out
    {
        get => _kc1Out;
        set
        {
            if (value == _kc1Out) return;
            _kc1Out = value;
            OnPropertyChanged();
        }
    }

    public string Pcurrent1
    {
        get => _pcurrent1;
        set
        {
            if (value == _pcurrent1) return;
            _pcurrent1 = value;
            OnPropertyChanged();
        }
    }

    public bool Pcurrent1In
    {
        get => _pcurrent1In;
        set
        {
            if (value == _pcurrent1In) return;
            _pcurrent1In = value;
            OnPropertyChanged();
        }
    }

    public bool Pcurrent1Out
    {
        get => _pcurrent1Out;
        set
        {
            if (value == _pcurrent1Out) return;
            _pcurrent1Out = value;
            OnPropertyChanged();
        }
    }

    public string Scurrent1
    {
        get => _scurrent1;
        set
        {
            if (value == _scurrent1) return;
            _scurrent1 = value;
            OnPropertyChanged();
        }
    }

    public bool Scurrent1In
    {
        get => _scurrent1In;
        set
        {
            if (value == _scurrent1In) return;
            _scurrent1In = value;
            OnPropertyChanged();
        }
    }

    public bool Scurrent1Out
    {
        get => _scurrent1Out;
        set
        {
            if (value == _scurrent1Out) return;
            _scurrent1Out = value;
            OnPropertyChanged();
        }
    }

    public string Cos1
    {
        get => _cos1;
        set
        {
            if (value == _cos1) return;
            _cos1 = value;
            OnPropertyChanged();
        }
    }

    public bool Cos1In
    {
        get => _cos1In;
        set
        {
            if (value == _cos1In) return;
            _cos1In = value;
            OnPropertyChanged();
        }
    }

    public bool Cos1Out
    {
        get => _cos1Out;
        set
        {
            if (value == _cos1Out) return;
            _cos1Out = value;
            OnPropertyChanged();
        }
    }

    public string Icurrent1
    {
        get => _icurrent1;
        set
        {
            if (value == _icurrent1) return;
            _icurrent1 = value;
            OnPropertyChanged();
        }
    }

    public bool Icurrent1In
    {
        get => _icurrent1In;
        set
        {
            if (value == _icurrent1In) return;
            _icurrent1In = value;
            OnPropertyChanged();
        }
    }

    public bool Icurrent1Out
    {
        get => _icurrent1Out;
        set
        {
            if (value == _icurrent1Out) return;
            _icurrent1Out = value;
            OnPropertyChanged();
        }
    }

    public string Mode2
    {
        get => _mode2;
        set
        {
            if (value == _mode2) return;
            _mode2 = value;
            OnPropertyChanged();
        }
    }

    public bool Mode2In
    {
        get => _mode2In;
        set
        {
            if (value == _mode2In) return;
            _mode2In = value;
            OnPropertyChanged();
        }
    }

    public bool Mode2Out
    {
        get => _mode2Out;
        set
        {
            if (value == _mode2Out) return;
            _mode2Out = value;
            OnPropertyChanged();
        }
    }

    public string Kc2
    {
        get => _kc2;
        set
        {
            if (value == _kc2) return;
            _kc2 = value;
            OnPropertyChanged();
        }
    }

    public bool Kc2In
    {
        get => _kc2In;
        set
        {
            if (value == _kc2In) return;
            _kc2In = value;
            OnPropertyChanged();
        }
    }

    public bool Kc2Out
    {
        get => _kc2Out;
        set
        {
            if (value == _kc2Out) return;
            _kc2Out = value;
            OnPropertyChanged();
        }
    }

    public string Pcurrent2
    {
        get => _pcurrent2;
        set
        {
            if (value == _pcurrent2) return;
            _pcurrent2 = value;
            OnPropertyChanged();
        }
    }

    public bool Pcurrent2In
    {
        get => _pcurrent2In;
        set
        {
            if (value == _pcurrent2In) return;
            _pcurrent2In = value;
            OnPropertyChanged();
        }
    }

    public bool Pcurrent2Out
    {
        get => _pcurrent2Out;
        set
        {
            if (value == _pcurrent2Out) return;
            _pcurrent2Out = value;
            OnPropertyChanged();
        }
    }

    public string Scurrent2
    {
        get => _scurrent2;
        set
        {
            if (value == _scurrent2) return;
            _scurrent2 = value;
            OnPropertyChanged();
        }
    }

    public bool Scurrent2In
    {
        get => _scurrent2In;
        set
        {
            if (value == _scurrent2In) return;
            _scurrent2In = value;
            OnPropertyChanged();
        }
    }

    public bool Scurrent2Out
    {
        get => _scurrent2Out;
        set
        {
            if (value == _scurrent2Out) return;
            _scurrent2Out = value;
            OnPropertyChanged();
        }
    }

    public string Cos2
    {
        get => _cos2;
        set
        {
            if (value == _cos2) return;
            _cos2 = value;
            OnPropertyChanged();
        }
    }

    public bool Cos2In
    {
        get => _cos2In;
        set
        {
            if (value == _cos2In) return;
            _cos2In = value;
            OnPropertyChanged();
        }
    }

    public bool Cos2Out
    {
        get => _cos2Out;
        set
        {
            if (value == _cos2Out) return;
            _cos2Out = value;
            OnPropertyChanged();
        }
    }

    public string Icurrent2
    {
        get => _icurrent2;
        set
        {
            if (value == _icurrent2) return;
            _icurrent2 = value;
            OnPropertyChanged();
        }
    }

    public bool Icurrent2In
    {
        get => _icurrent2In;
        set
        {
            if (value == _icurrent2In) return;
            _icurrent2In = value;
            OnPropertyChanged();
        }
    }

    public bool Icurrent2Out
    {
        get => _icurrent2Out;
        set
        {
            if (value == _icurrent2Out) return;
            _icurrent2Out = value;
            OnPropertyChanged();
        }
    }


    public string Mode3
    {
        get => _mode3;
        set
        {
            if (value == _mode3) return;
            _mode3 = value;
            OnPropertyChanged();
        }
    }

    public bool Mode3In
    {
        get => _mode3In;
        set
        {
            if (value == _mode3In) return;
            _mode3In = value;
            OnPropertyChanged();
        }
    }

    public bool Mode3Out
    {
        get => _mode3Out;
        set
        {
            if (value == _mode3Out) return;
            _mode3Out = value;
            OnPropertyChanged();
        }
    }

    public string Kc3
    {
        get => _kc3;
        set
        {
            if (value == _kc3) return;
            _kc3 = value;
            OnPropertyChanged();
        }
    }

    public bool Kc3In
    {
        get => _kc3In;
        set
        {
            if (value == _kc3In) return;
            _kc3In = value;
            OnPropertyChanged();
        }
    }

    public bool Kc3Out
    {
        get => _kc3Out;
        set
        {
            if (value == _kc3Out) return;
            _kc3Out = value;
            OnPropertyChanged();
        }
    }

    public string Pcurrent3
    {
        get => _pcurrent3;
        set
        {
            if (value == _pcurrent3) return;
            _pcurrent3 = value;
            OnPropertyChanged();
        }
    }

    public bool Pcurrent3In
    {
        get => _pcurrent3In;
        set
        {
            if (value == _pcurrent3In) return;
            _pcurrent3In = value;
            OnPropertyChanged();
        }
    }

    public bool Pcurrent3Out
    {
        get => _pcurrent3Out;
        set
        {
            if (value == _pcurrent3Out) return;
            _pcurrent3Out = value;
            OnPropertyChanged();
        }
    }

    public string Scurrent3
    {
        get => _scurrent3;
        set
        {
            if (value == _scurrent3) return;
            _scurrent3 = value;
            OnPropertyChanged();
        }
    }

    public bool Scurrent3In
    {
        get => _scurrent3In;
        set
        {
            if (value == _scurrent3In) return;
            _scurrent3In = value;
            OnPropertyChanged();
        }
    }

    public bool Scurrent3Out
    {
        get => _scurrent3Out;
        set
        {
            if (value == _scurrent3Out) return;
            _scurrent3Out = value;
            OnPropertyChanged();
        }
    }

    public string Cos3
    {
        get => _cos3;
        set
        {
            if (value == _cos3) return;
            _cos3 = value;
            OnPropertyChanged();
        }
    }

    public bool Cos3In
    {
        get => _cos3In;
        set
        {
            if (value == _cos3In) return;
            _cos3In = value;
            OnPropertyChanged();
        }
    }

    public bool Cos3Out
    {
        get => _cos3Out;
        set
        {
            if (value == _cos3Out) return;
            _cos3Out = value;
            OnPropertyChanged();
        }
    }

    public string Icurrent3
    {
        get => _icurrent3;
        set
        {
            if (value == _icurrent3) return;
            _icurrent3 = value;
            OnPropertyChanged();
        }
    }

    public bool Icurrent3In
    {
        get => _icurrent3In;
        set
        {
            if (value == _icurrent3In) return;
            _icurrent3In = value;
            OnPropertyChanged();
        }
    }

    public bool Icurrent3Out
    {
        get => _icurrent3Out;
        set
        {
            if (value == _icurrent3Out) return;
            _icurrent3Out = value;
            OnPropertyChanged();
        }
    }


    public string Mode4
    {
        get => _mode4;
        set
        {
            if (value == _mode4) return;
            _mode4 = value;
            OnPropertyChanged();
        }
    }

    public bool Mode4In
    {
        get => _mode4In;
        set
        {
            if (value == _mode4In) return;
            _mode4In = value;
            OnPropertyChanged();
        }
    }

    public bool Mode4Out
    {
        get => _mode4Out;
        set
        {
            if (value == _mode4Out) return;
            _mode4Out = value;
            OnPropertyChanged();
        }
    }

    public string Kc4
    {
        get => _kc4;
        set
        {
            if (value == _kc4) return;
            _kc4 = value;
            OnPropertyChanged();
        }
    }

    public bool Kc4In
    {
        get => _kc4In;
        set
        {
            if (value == _kc4In) return;
            _kc4In = value;
            OnPropertyChanged();
        }
    }

    public bool Kc4Out
    {
        get => _kc4Out;
        set
        {
            if (value == _kc4Out) return;
            _kc4Out = value;
            OnPropertyChanged();
        }
    }

    public string Pcurrent4
    {
        get => _pcurrent4;
        set
        {
            if (value == _pcurrent4) return;
            _pcurrent4 = value;
            OnPropertyChanged();
        }
    }

    public bool Pcurrent4In
    {
        get => _pcurrent4In;
        set
        {
            if (value == _pcurrent4In) return;
            _pcurrent4In = value;
            OnPropertyChanged();
        }
    }

    public bool Pcurrent4Out
    {
        get => _pcurrent4Out;
        set
        {
            if (value == _pcurrent4Out) return;
            _pcurrent4Out = value;
            OnPropertyChanged();
        }
    }

    public string Scurrent4
    {
        get => _scurrent4;
        set
        {
            if (value == _scurrent4) return;
            _scurrent4 = value;
            OnPropertyChanged();
        }
    }

    public bool Scurrent4In
    {
        get => _scurrent4In;
        set
        {
            if (value == _scurrent4In) return;
            _scurrent4In = value;
            OnPropertyChanged();
        }
    }

    public bool Scurrent4Out
    {
        get => _scurrent4Out;
        set
        {
            if (value == _scurrent4Out) return;
            _scurrent4Out = value;
            OnPropertyChanged();
        }
    }

    public string Cos4
    {
        get => _cos4;
        set
        {
            if (value == _cos4) return;
            _cos4 = value;
            OnPropertyChanged();
        }
    }

    public bool Cos4In
    {
        get => _cos4In;
        set
        {
            if (value == _cos4In) return;
            _cos4In = value;
            OnPropertyChanged();
        }
    }

    public bool Cos4Out
    {
        get => _cos4Out;
        set
        {
            if (value == _cos4Out) return;
            _cos4Out = value;
            OnPropertyChanged();
        }
    }

    public string Icurrent4
    {
        get => _icurrent4;
        set
        {
            if (value == _icurrent4) return;
            _icurrent4 = value;
            OnPropertyChanged();
        }
    }

    public bool Icurrent4In
    {
        get => _icurrent4In;
        set
        {
            if (value == _icurrent4In) return;
            _icurrent4In = value;
            OnPropertyChanged();
        }
    }

    public bool Icurrent4Out
    {
        get => _icurrent4Out;
        set
        {
            if (value == _icurrent4Out) return;
            _icurrent4Out = value;
            OnPropertyChanged();
        }
    }


    /// <summary>
    /// Установка имен параметров по умолчанию
    /// </summary>
    public void SetDefaultParameterNames()
    {
        var defaultValues = new Dictionary<string, object>
            {
                { nameof(Pset), "EVA_Pу" },
                { nameof(PsetIn), false },
                { nameof(PsetOut), false },

                { nameof(Mode1), "EVA_Режим_1" },
                { nameof(Mode1In), false },
                { nameof(Mode1Out), false },
                { nameof(Kc1), "EVA_Kс_1" },
                { nameof(Kc1In), false },
                { nameof(Kc1Out), false },
                { nameof(Pcurrent1), "EVA_Pр_1" },
                { nameof(Pcurrent1In), false },
                { nameof(Pcurrent1Out), false },
                { nameof(Scurrent1), "EVA_Sр_1" },
                { nameof(Scurrent1In), false },
                { nameof(Scurrent1Out), false },
                { nameof(Cos1), "EVA_Cos_1" },
                { nameof(Cos1In), false },
                { nameof(Cos1Out), false },
                { nameof(Icurrent1), "EVA_Iр_1" },
                { nameof(Icurrent1In), false },
                { nameof(Icurrent1Out), false },

                { nameof(Mode2), "EVA_Режим_2" },
                { nameof(Mode2In), false },
                { nameof(Mode2Out), false },
                { nameof(Kc2), "EVA_Kс_2" },
                { nameof(Kc2In), false },
                { nameof(Kc2Out), false },
                { nameof(Pcurrent2), "EVA_Pр_2" },
                { nameof(Pcurrent2In), false },
                { nameof(Pcurrent2Out), false },
                { nameof(Scurrent2), "EVA_Sр_2" },
                { nameof(Scurrent2In), false },
                { nameof(Scurrent2Out), false },
                { nameof(Cos2), "EVA_Cos_2" },
                { nameof(Cos2In), false },
                { nameof(Cos2Out), false },
                { nameof(Icurrent2), "EVA_Iр_2" },
                { nameof(Icurrent2In), false },
                { nameof(Icurrent2Out), false },

                { nameof(Mode3), "EVA_Режим_3" },
                { nameof(Mode3In), false },
                { nameof(Mode3Out), false },
                { nameof(Kc3), "EVA_Kс_3" },
                { nameof(Kc3In), false },
                { nameof(Kc3Out), false },
                { nameof(Pcurrent3), "EVA_Pр_3" },
                { nameof(Pcurrent3In), false },
                { nameof(Pcurrent3Out), false },
                { nameof(Scurrent3), "EVA_Sр_3" },
                { nameof(Scurrent3In), false },
                { nameof(Scurrent3Out), false },
                { nameof(Cos3), "EVA_Cos_3" },
                { nameof(Cos3In), false },
                { nameof(Cos3Out), false },
                { nameof(Icurrent3), "EVA_Iр_3" },
                { nameof(Icurrent3In), false },
                { nameof(Icurrent3Out), false },

                { nameof(Mode4), "EVA_Режим_4" },
                { nameof(Mode4In), false },
                { nameof(Mode4Out), false },
                { nameof(Kc4), "EVA_Kс_4" },
                { nameof(Kc4In), false },
                { nameof(Kc4Out), false },
                { nameof(Pcurrent4), "EVA_Pр_4" },
                { nameof(Pcurrent4In), false },
                { nameof(Pcurrent4Out), false },
                { nameof(Scurrent4), "EVA_Sр_4" },
                { nameof(Scurrent4In), false },
                { nameof(Scurrent4Out), false },
                { nameof(Cos4), "EVA_Cos_4" },
                { nameof(Cos4In), false },
                { nameof(Cos4Out), false },
                { nameof(Icurrent4), "EVA_Iр_4" },
                { nameof(Icurrent4In), false },
                { nameof(Icurrent4Out), false },

            };

        var properties = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (var property in properties)
        {
            if (property.CanWrite && defaultValues.ContainsKey(property.Name))
            {
                property.SetValue(this, defaultValues[property.Name]);
            }
        }
    }
}