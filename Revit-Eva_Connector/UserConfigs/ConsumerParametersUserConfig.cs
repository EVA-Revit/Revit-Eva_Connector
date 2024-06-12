namespace Revit_Eva_Connector.UserConfigs;

using System.Collections.Generic;
using System.Reflection;
using EvaAPI.MVVM;

public class ConsumerParametersUserConfig : PropertyObserver
{
    private string _pset;
    private bool _psetIn;
    private bool _psetOut;
    private string _typeLoadName;
    private bool _typeLoadNameIn;
    private bool _typeLoadNameOut;
    private string _loadName;
    private bool _loadNameIn;
    private bool _loadNameOut;
    private string _cos;
    private bool _cosIn;
    private bool _cosOut;
    private string _textName;
    private bool _textNameIn;
    private bool _textNameOut;
    private string _doubleName;
    private bool _doubleNameIn;
    private bool _doubleNameOut;

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

    public string TypeLoadName
    {
        get => _typeLoadName;
        set
        {
            if (value == _typeLoadName) return;
            _typeLoadName = value;
            OnPropertyChanged();
        }
    }

    public bool TypeLoadNameIn
    {
        get => _typeLoadNameIn;
        set
        {
            if (value == _typeLoadNameIn) return;
            _typeLoadNameIn = value;
            OnPropertyChanged();
        }
    }

    public bool TypeLoadNameOut
    {
        get => _typeLoadNameOut;
        set
        {
            if (value == _typeLoadNameOut) return;
            _typeLoadNameOut = value;
            OnPropertyChanged();
        }
    }

    public string LoadName
    {
        get => _loadName;
        set
        {
            if (value == _loadName) return;
            _loadName = value;
            OnPropertyChanged();
        }
    }

    public bool LoadNameIn
    {
        get => _loadNameIn;
        set
        {
            if (value == _loadNameIn) return;
            _loadNameIn = value;
            OnPropertyChanged();
        }
    }

    public bool LoadNameOut
    {
        get => _loadNameOut;
        set
        {
            if (value == _loadNameOut) return;
            _loadNameOut = value;
            OnPropertyChanged();
        }
    }

    public string Cos
    {
        get => _cos;
        set
        {
            if (value == _cos) return;
            _cos = value;
            OnPropertyChanged();
        }
    }

    public bool CosIn
    {
        get => _cosIn;
        set
        {
            if (value == _cosIn) return;
            _cosIn = value;
            OnPropertyChanged();
        }
    }

    public bool CosOut
    {
        get => _cosOut;
        set
        {
            if (value == _cosOut) return;
            _cosOut = value;
            OnPropertyChanged();
        }
    }

    public string TextName
    {
        get => _textName;
        set
        {
            if (value == _textName) return;
            _textName = value;
            OnPropertyChanged();
        }
    }

    public bool TextNameIn
    {
        get => _textNameIn;
        set
        {
            if (value == _textNameIn) return;
            _textNameIn = value;
            OnPropertyChanged();
        }
    }

    public bool TextNameOut
    {
        get => _textNameOut;
        set
        {
            if (value == _textNameOut) return;
            _textNameOut = value;
            OnPropertyChanged();
        }
    }

    public string DoubleName
    {
        get => _doubleName;
        set
        {
            if (value == _doubleName) return;
            _doubleName = value;
            OnPropertyChanged();
        }
    }

    public bool DoubleNameIn
    {
        get => _doubleNameIn;
        set
        {
            if (value == _doubleNameIn) return;
            _doubleNameIn = value;
            OnPropertyChanged();
        }
    }

    public bool DoubleNameOut
    {
        get => _doubleNameOut;
        set
        {
            if (value == _doubleNameOut) return;
            _doubleNameOut = value;
            OnPropertyChanged();
        }
    }

    public void SetDefaultParameterNames()
    {
        var defaultValues = new Dictionary<string, object>
        {
            { nameof(Pset), "EVA_Pу" },
            { nameof(PsetIn), false },
            { nameof(PsetOut), false },
            { nameof(TypeLoadName), "EVA_Тип_Нагрузки" },
            { nameof(TypeLoadNameIn), false },
            { nameof(TypeLoadNameOut), false },
            { nameof(LoadName), "EVA_Имя_нагрузки" },
            { nameof(LoadNameIn), false },
            { nameof(LoadNameOut), false },
            { nameof(Cos), "EVA_Cos" },
            { nameof(CosIn), false },
            { nameof(CosOut), false },
            { nameof(TextName), "EVA_Текст" },
            { nameof(TextNameIn), false },
            { nameof(TextNameOut), false },
            { nameof(DoubleName), "EVA_Число" },
            { nameof(DoubleNameIn), false },
            { nameof(DoubleNameOut), false }
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