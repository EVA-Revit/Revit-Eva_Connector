namespace Revit_Eva_Connector.UserConfigs;

using System.Collections.Generic;
using System.Reflection;
using EvaAPI.MVVM;

public class CircuitParametersUserConfig : PropertyObserver
{
    #region Fields
    private string _typeLoadName;
    private bool _typeLoadNameIn;
    private bool _typeLoadNameOut;
    private string _loadName;
    private bool _loadNameIn;
    private bool _loadNameOut;
    private string _phaseConnecting;
    private bool _phaseConnectingIn;
    private bool _phaseConnectingOut;
    private string _cosF;
    private bool _cosFin;
    private bool _cosFout;
    private string _pcurrent;
    private bool _pcurrentIn;
    private bool _pcurrentOut;
    private string _icurrent;
    private bool _icurrentIn;
    private bool _icurrentOut;
    private string _cableDesignation;
    private bool _cableDesignationIn;
    private bool _cableDesignationOut;
    private string _markCable;
    private bool _markCableIn;
    private bool _markCableOut;
    private string _sectionCable11;
    private bool _sectionCable1In;
    private bool _sectionCable1Out;
    private string _sectionCable12;
    private string _sectionCable13;
    private string _factLenCable1;
    private bool _factLenCable1In;
    private bool _factLenCable1Out;
    private string _sectionCable21;
    private bool _sectionCable2In;
    private bool _sectionCable2Out;
    private string _sectionCable22;
    private string _sectionCable23;
    private string _factLenCable2;
    private bool _factLenCable2In;
    private bool _factLenCable2Out;
    private string _sectionCable31;
    private bool _sectionCable3In;
    private bool _sectionCable3Out;
    private string _sectionCable32;
    private string _sectionCable33;
    private string _factLenCable3;
    private bool _factLenCable3In;
    private bool _factLenCable3Out;
    private string _lenForCountTkz;
    private bool _lenForCountTkzIn;
    private bool _lenForCountTkzOut;
    private string _lenCableCurrent;
    private bool _lenCableCurrentIn;
    private bool _lenCableCurrentOut;
    private string _currentLoss;
    private bool _currentLossIn;
    private bool _currentLossOut;
    private string _currentTkzEndLine;
    private bool _currentTkzEndLineIn;
    private bool _currentTkzEndLineOut;
    private string _countElements;
    private bool _countElementsIn;
    private bool _countElementsOut;
    private string _typePipe1;
    private bool _typePipe1In;
    private bool _typePipe1Out;
    private string _diameterPipe1;
    private bool _diameterPipe1In;
    private bool _diameterPipe1Out;
    private string _lenPipe1;
    private bool _lenPipe1In;
    private bool _lenPipe1Out;
    private string _typePipe2;
    private bool _typePipe2In;
    private bool _typePipe2Out;
    private string _diameterPipe2;
    private bool _diameterPipe2In;
    private bool _diameterPipe2Out;
    private string _lenPipe2;
    private bool _lenPipe2In;
    private bool _lenPipe2Out;
    private string _room;
    private bool _roomIn;
    private bool _roomOut;
    private string _project;
    private bool _projectIn;
    private bool _projectOut;
    private string _pset;
    private bool _psetIn;
    private bool _psetOut;

    #endregion

    /// <summary>
    /// Установленная мощность
    /// </summary>
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

    /// <summary>
    /// Тип нагрузки
    /// </summary>
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

    /// <summary>
    /// Наименование нагрузки
    /// </summary>
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


    /// <summary>
    /// Фаза подключения
    /// </summary>
    public string PhaseConnecting
    {
        get => _phaseConnecting;
        set
        {
            if (value == _phaseConnecting) return;
            _phaseConnecting = value;
            OnPropertyChanged();
        }
    }

    public bool PhaseConnectingIn
    {
        get => _phaseConnectingIn;
        set
        {
            if (value == _phaseConnectingIn) return;
            _phaseConnectingIn = value;
            OnPropertyChanged();
        }
    }

    public bool PhaseConnectingOut
    {
        get => _phaseConnectingOut;
        set
        {
            if (value == _phaseConnectingOut) return;
            _phaseConnectingOut = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Cos
    /// </summary>
    public string CosF
    {
        get => _cosF;
        set
        {
            if (value == _cosF) return;
            _cosF = value;
            OnPropertyChanged();
        }
    }

    public bool CosFin
    {
        get => _cosFin;
        set
        {
            if (value == _cosFin) return;
            _cosFin = value;
            OnPropertyChanged();
        }
    }

    public bool CosFout
    {
        get => _cosFout;
        set
        {
            if (value == _cosFout) return;
            _cosFout = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Расчетная мощность
    /// </summary>
    public string Pcurrent
    {
        get => _pcurrent;
        set
        {
            if (value == _pcurrent) return;
            _pcurrent = value;
            OnPropertyChanged();
        }
    }

    public bool PcurrentIn
    {
        get => _pcurrentIn;
        set
        {
            if (value == _pcurrentIn) return;
            _pcurrentIn = value;
            OnPropertyChanged();
        }
    }

    public bool PcurrentOut
    {
        get => _pcurrentOut;
        set
        {
            if (value == _pcurrentOut) return;
            _pcurrentOut = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Расчетный ток
    /// </summary>
    public string Icurrent
    {
        get => _icurrent;
        set
        {
            if (value == _icurrent) return;
            _icurrent = value;
            OnPropertyChanged();
        }
    }

    public bool IcurrentIn
    {
        get => _icurrentIn;
        set
        {
            if (value == _icurrentIn) return;
            _icurrentIn = value;
            OnPropertyChanged();
        }
    }

    public bool IcurrentOut
    {
        get => _icurrentOut;
        set
        {
            if (value == _icurrentOut) return;
            _icurrentOut = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Обозначение кабеля
    /// </summary>
    public string CableDesignation
    {
        get => _cableDesignation;
        set
        {
            if (value == _cableDesignation) return;
            _cableDesignation = value;
            OnPropertyChanged();
        }
    }

    public bool CableDesignationIn
    {
        get => _cableDesignationIn;
        set
        {
            if (value == _cableDesignationIn) return;
            _cableDesignationIn = value;
            OnPropertyChanged();
        }
    }

    public bool CableDesignationOut
    {
        get => _cableDesignationOut;
        set
        {
            if (value == _cableDesignationOut) return;
            _cableDesignationOut = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Марка кабеля
    /// </summary>
    public string MarkCable
    {
        get => _markCable;
        set
        {
            if (value == _markCable) return;
            _markCable = value;
            OnPropertyChanged();
        }
    }

    public bool MarkCableIn
    {
        get => _markCableIn;
        set
        {
            if (value == _markCableIn) return;
            _markCableIn = value;
            OnPropertyChanged();
        }
    }

    public bool MarkCableOut
    {
        get => _markCableOut;
        set
        {
            if (value == _markCableOut) return;
            _markCableOut = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Сечение кабеля 1
    /// </summary>
    public string SectionCable11
    {
        get => _sectionCable11;
        set
        {
            if (value == _sectionCable11) return;
            _sectionCable11 = value;
            OnPropertyChanged();
        }
    }

    public bool SectionCable1In
    {
        get => _sectionCable1In;
        set
        {
            if (value == _sectionCable1In) return;
            _sectionCable1In = value;
            OnPropertyChanged();
        }
    }

    public bool SectionCable1Out
    {
        get => _sectionCable1Out;
        set
        {
            if (value == _sectionCable1Out) return;
            _sectionCable1Out = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Сечение кабеля 1
    /// </summary>
    public string SectionCable12
    {
        get => _sectionCable12;
        set
        {
            if (value == _sectionCable12) return;
            _sectionCable12 = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Сечение кабеля 1
    /// </summary>
    public string SectionCable13
    {
        get => _sectionCable13;
        set
        {
            if (value == _sectionCable13) return;
            _sectionCable13 = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Фактическая длина кабеля 1
    /// </summary>
    public string FactLenCable1
    {
        get => _factLenCable1;
        set
        {
            if (value == _factLenCable1) return;
            _factLenCable1 = value;
            OnPropertyChanged();
        }
    }

    public bool FactLenCable1In
    {
        get => _factLenCable1In;
        set
        {
            if (value == _factLenCable1In) return;
            _factLenCable1In = value;
            OnPropertyChanged();
        }
    }

    public bool FactLenCable1Out
    {
        get => _factLenCable1Out;
        set
        {
            if (value == _factLenCable1Out) return;
            _factLenCable1Out = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Сечение кабеля 2
    /// </summary>
    public string SectionCable21
    {
        get => _sectionCable21;
        set
        {
            if (value == _sectionCable21) return;
            _sectionCable21 = value;
            OnPropertyChanged();
        }
    }

    public bool SectionCable2In
    {
        get => _sectionCable2In;
        set
        {
            if (value == _sectionCable2In) return;
            _sectionCable2In = value;
            OnPropertyChanged();
        }
    }

    public bool SectionCable2Out
    {
        get => _sectionCable2Out;
        set
        {
            if (value == _sectionCable2Out) return;
            _sectionCable2Out = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Сечение кабеля 2
    /// </summary>
    public string SectionCable22
    {
        get => _sectionCable22;
        set
        {
            if (value == _sectionCable22) return;
            _sectionCable22 = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Сечение кабеля 2
    /// </summary>
    public string SectionCable23
    {
        get => _sectionCable23;
        set
        {
            if (value == _sectionCable23) return;
            _sectionCable23 = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Фактическая длина кабеля 2
    /// </summary>
    public string FactLenCable2
    {
        get => _factLenCable2;
        set
        {
            if (value == _factLenCable2) return;
            _factLenCable2 = value;
            OnPropertyChanged();
        }
    }

    public bool FactLenCable2In
    {
        get => _factLenCable2In;
        set
        {
            if (value == _factLenCable2In) return;
            _factLenCable2In = value;
            OnPropertyChanged();
        }
    }

    public bool FactLenCable2Out
    {
        get => _factLenCable2Out;
        set
        {
            if (value == _factLenCable2Out) return;
            _factLenCable2Out = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Сечение кабеля 3
    /// </summary>
    public string SectionCable31
    {
        get => _sectionCable31;
        set
        {
            if (value == _sectionCable31) return;
            _sectionCable31 = value;
            OnPropertyChanged();
        }
    }

    public bool SectionCable3In
    {
        get => _sectionCable3In;
        set
        {
            if (value == _sectionCable3In) return;
            _sectionCable3In = value;
            OnPropertyChanged();
        }
    }

    public bool SectionCable3Out
    {
        get => _sectionCable3Out;
        set
        {
            if (value == _sectionCable3Out) return;
            _sectionCable3Out = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Сечение кабеля 3
    /// </summary>
    public string SectionCable32
    {
        get => _sectionCable32;
        set
        {
            if (value == _sectionCable32) return;
            _sectionCable32 = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Сечение кабеля 3
    /// </summary>
    public string SectionCable33
    {
        get => _sectionCable33;
        set
        {
            if (value == _sectionCable33) return;
            _sectionCable33 = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Фактическая длина кабеля 3
    /// </summary>
    public string FactLenCable3
    {
        get => _factLenCable3;
        set
        {
            if (value == _factLenCable3) return;
            _factLenCable3 = value;
            OnPropertyChanged();
        }
    }

    public bool FactLenCable3In
    {
        get => _factLenCable3In;
        set
        {
            if (value == _factLenCable3In) return;
            _factLenCable3In = value;
            OnPropertyChanged();
        }
    }

    public bool FactLenCable3Out
    {
        get => _factLenCable3Out;
        set
        {
            if (value == _factLenCable3Out) return;
            _factLenCable3Out = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Длина для расчета ТКЗ
    /// </summary>
    public string LenForCountTkz
    {
        get => _lenForCountTkz;
        set
        {
            if (value == _lenForCountTkz) return;
            _lenForCountTkz = value;
            OnPropertyChanged();
        }
    }

    public bool LenForCountTkzIn
    {
        get => _lenForCountTkzIn;
        set
        {
            if (value == _lenForCountTkzIn) return;
            _lenForCountTkzIn = value;
            OnPropertyChanged();
        }
    }

    public bool LenForCountTkzOut
    {
        get => _lenForCountTkzOut;
        set
        {
            if (value == _lenForCountTkzOut) return;
            _lenForCountTkzOut = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Расчетная длина кабеля
    /// </summary>
    public string LenCableCurrent
    {
        get => _lenCableCurrent;
        set
        {
            if (value == _lenCableCurrent) return;
            _lenCableCurrent = value;
            OnPropertyChanged();
        }
    }

    public bool LenCableCurrentIn
    {
        get => _lenCableCurrentIn;
        set
        {
            if (value == _lenCableCurrentIn) return;
            _lenCableCurrentIn = value;
            OnPropertyChanged();
        }
    }

    public bool LenCableCurrentOut
    {
        get => _lenCableCurrentOut;
        set
        {
            if (value == _lenCableCurrentOut) return;
            _lenCableCurrentOut = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Расчетные потери напряжения на участке
    /// </summary>
    public string CurrentLoss
    {
        get => _currentLoss;
        set
        {
            if (value == _currentLoss) return;
            _currentLoss = value;
            OnPropertyChanged();
        }
    }

    public bool CurrentLossIn
    {
        get => _currentLossIn;
        set
        {
            if (value == _currentLossIn) return;
            _currentLossIn = value;
            OnPropertyChanged();
        }
    }

    public bool CurrentLossOut
    {
        get => _currentLossOut;
        set
        {
            if (value == _currentLossOut) return;
            _currentLossOut = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Расчет ТКЗ в конце линии
    /// </summary>
    public string CurrentTkzEndLine
    {
        get => _currentTkzEndLine;
        set
        {
            if (value == _currentTkzEndLine) return;
            _currentTkzEndLine = value;
            OnPropertyChanged();
        }
    }

    public bool CurrentTkzEndLineIn
    {
        get => _currentTkzEndLineIn;
        set
        {
            if (value == _currentTkzEndLineIn) return;
            _currentTkzEndLineIn = value;
            OnPropertyChanged();
        }
    }

    public bool CurrentTkzEndLineOut
    {
        get => _currentTkzEndLineOut;
        set
        {
            if (value == _currentTkzEndLineOut) return;
            _currentTkzEndLineOut = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Кол-во электро приемников
    /// </summary>
    public string CountElements
    {
        get => _countElements;
        set
        {
            if (value == _countElements) return;
            _countElements = value;
            OnPropertyChanged();
        }
    }

    public bool CountElementsIn
    {
        get => _countElementsIn;
        set
        {
            if (value == _countElementsIn) return;
            _countElementsIn = value;
            OnPropertyChanged();
        }
    }

    public bool CountElementsOut
    {
        get => _countElementsOut;
        set
        {
            if (value == _countElementsOut) return;
            _countElementsOut = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Тип трубы 1
    /// </summary>
    public string TypePipe1
    {
        get => _typePipe1;
        set
        {
            if (value == _typePipe1) return;
            _typePipe1 = value;
            OnPropertyChanged();
        }
    }

    public bool TypePipe1In
    {
        get => _typePipe1In;
        set
        {
            if (value == _typePipe1In) return;
            _typePipe1In = value;
            OnPropertyChanged();
        }
    }

    public bool TypePipe1Out
    {
        get => _typePipe1Out;
        set
        {
            if (value == _typePipe1Out) return;
            _typePipe1Out = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Диаметр трубы 1
    /// </summary>
    public string DiameterPipe1
    {
        get => _diameterPipe1;
        set
        {
            if (value == _diameterPipe1) return;
            _diameterPipe1 = value;
            OnPropertyChanged();
        }
    }

    public bool DiameterPipe1In
    {
        get => _diameterPipe1In;
        set
        {
            if (value == _diameterPipe1In) return;
            _diameterPipe1In = value;
            OnPropertyChanged();
        }
    }

    public bool DiameterPipe1Out
    {
        get => _diameterPipe1Out;
        set
        {
            if (value == _diameterPipe1Out) return;
            _diameterPipe1Out = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Длина трубы 1
    /// </summary>
    public string LenPipe1
    {
        get => _lenPipe1;
        set
        {
            if (value == _lenPipe1) return;
            _lenPipe1 = value;
            OnPropertyChanged();
        }
    }

    public bool LenPipe1In
    {
        get => _lenPipe1In;
        set
        {
            if (value == _lenPipe1In) return;
            _lenPipe1In = value;
            OnPropertyChanged();
        }
    }

    public bool LenPipe1Out
    {
        get => _lenPipe1Out;
        set
        {
            if (value == _lenPipe1Out) return;
            _lenPipe1Out = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Тип трубы 2
    /// </summary>
    public string TypePipe2
    {
        get => _typePipe2;
        set
        {
            if (value == _typePipe2) return;
            _typePipe2 = value;
            OnPropertyChanged();
        }
    }

    public bool TypePipe2In
    {
        get => _typePipe2In;
        set
        {
            if (value == _typePipe2In) return;
            _typePipe2In = value;
            OnPropertyChanged();
        }
    }

    public bool TypePipe2Out
    {
        get => _typePipe2Out;
        set
        {
            if (value == _typePipe2Out) return;
            _typePipe2Out = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Диаметр трубы 2
    /// </summary>
    public string DiameterPipe2
    {
        get => _diameterPipe2;
        set
        {
            if (value == _diameterPipe2) return;
            _diameterPipe2 = value;
            OnPropertyChanged();
        }
    }

    public bool DiameterPipe2In
    {
        get => _diameterPipe2In;
        set
        {
            if (value == _diameterPipe2In) return;
            _diameterPipe2In = value;
            OnPropertyChanged();
        }
    }

    public bool DiameterPipe2Out
    {
        get => _diameterPipe2Out;
        set
        {
            if (value == _diameterPipe2Out) return;
            _diameterPipe2Out = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Длина трубы 2
    /// </summary>
    public string LenPipe2
    {
        get => _lenPipe2;
        set
        {
            if (value == _lenPipe2) return;
            _lenPipe2 = value;
            OnPropertyChanged();
        }
    }

    public bool LenPipe2In
    {
        get => _lenPipe2In;
        set
        {
            if (value == _lenPipe2In) return;
            _lenPipe2In = value;
            OnPropertyChanged();
        }
    }

    public bool LenPipe2Out
    {
        get => _lenPipe2Out;
        set
        {
            if (value == _lenPipe2Out) return;
            _lenPipe2Out = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Помещение
    /// </summary>
    public string Room
    {
        get => _room;
        set
        {
            if (value == _room) return;
            _room = value;
            OnPropertyChanged();
        }
    }

    public bool RoomIn
    {
        get => _roomIn;
        set
        {
            if (value == _roomIn) return;
            _roomIn = value;
            OnPropertyChanged();
        }
    }

    public bool RoomOut
    {
        get => _roomOut;
        set
        {
            if (value == _roomOut) return;
            _roomOut = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Проект
    /// </summary>
    public string Project
    {
        get => _project;
        set
        {
            if (value == _project) return;
            _project = value;
            OnPropertyChanged();
        }
    }

    public bool ProjectIn
    {
        get => _projectIn;
        set
        {
            if (value == _projectIn) return;
            _projectIn = value;
            OnPropertyChanged();
        }
    }

    public bool ProjectOut
    {
        get => _projectOut;
        set
        {
            if (value == _projectOut) return;
            _projectOut = value;
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
                { nameof(TypeLoadName), "EVA_Имя_нагрузки" },
                { nameof(TypeLoadNameIn), false },
                { nameof(TypeLoadNameOut), false },
                { nameof(LoadName), "EVA_Тип_Нагрузки" },
                { nameof(LoadNameIn), false },
                { nameof(LoadNameOut), false },
                { nameof(PhaseConnecting), "EVA_Фаза_подключения" },
                { nameof(PhaseConnectingIn), false },
                { nameof(PhaseConnectingOut), false },
                { nameof(CosF), "EVA_Cos" },
                { nameof(CosFin), false },
                { nameof(CosFout), false },
                { nameof(Pcurrent), "EVA_Pр" },
                { nameof(PcurrentIn), false },
                { nameof(PcurrentOut), false },
                { nameof(Icurrent), "EVA_Iр" },
                { nameof(IcurrentIn), false },
                { nameof(IcurrentOut), false },
                { nameof(CableDesignation), "EVA_Имя_кабеля" },
                { nameof(CableDesignationIn), false },
                { nameof(CableDesignationOut), false },
                { nameof(MarkCable), "EVA_Марка_кабеля" },
                { nameof(MarkCableIn), false },
                { nameof(MarkCableOut), false },
                { nameof(SectionCable11), "EVA_S11" },
                { nameof(SectionCable1In), false },
                { nameof(SectionCable1Out), false },
                { nameof(SectionCable12), "EVA_S12" },
                { nameof(SectionCable13), "EVA_S13" },
                { nameof(FactLenCable1), "EVA_Lф1" },
                { nameof(FactLenCable1In), false },
                { nameof(FactLenCable1Out), false },
                { nameof(SectionCable21), "EVA_S21" },
                { nameof(SectionCable2In), false },
                { nameof(SectionCable2Out), false },
                { nameof(SectionCable22), "EVA_S22" },
                { nameof(SectionCable23), "EVA_S23" },
                { nameof(FactLenCable2), "EVA_Lф2" },
                { nameof(FactLenCable2In), false },
                { nameof(FactLenCable2Out), false },
                { nameof(SectionCable31), "EVA_S31" },
                { nameof(SectionCable3In), false },
                { nameof(SectionCable3Out), false },
                { nameof(SectionCable32), "EVA_S32" },
                { nameof(SectionCable33), "EVA_S33" },
                { nameof(FactLenCable3), "EVA_Lф3" },
                { nameof(FactLenCable3In), false },
                { nameof(FactLenCable3Out), false },
                { nameof(LenForCountTkz), "EVA_L_ТКЗ" },
                { nameof(LenForCountTkzIn), false },
                { nameof(LenForCountTkzOut), false },
                { nameof(LenCableCurrent), "EVA_Lр" },
                { nameof(LenCableCurrentIn), false },
                { nameof(LenCableCurrentOut), false },
                { nameof(CurrentLoss), "EVA_dUp" },
                { nameof(CurrentLossIn), false },
                { nameof(CurrentLossOut), false },
                { nameof(CurrentTkzEndLine), "EVA_Iткз(1)" },
                { nameof(CurrentTkzEndLineIn), false },
                { nameof(CurrentTkzEndLineOut), false },
                { nameof(CountElements), "EVA_Кол-во_ЭП" },
                { nameof(CountElementsIn), false },
                { nameof(CountElementsOut), false },
                { nameof(TypePipe1), "EVA_Тип_Трубы_1" },
                { nameof(TypePipe1In), false },
                { nameof(TypePipe1Out), false },
                { nameof(DiameterPipe1), "EVA_D_Трубы_1" },
                { nameof(DiameterPipe1In), false },
                { nameof(DiameterPipe1Out), false },
                { nameof(LenPipe1), "EVA_L_Трубы_1" },
                { nameof(LenPipe1In), false },
                { nameof(LenPipe1Out), false },
                { nameof(TypePipe2), "EVA_Тип_Трубы_2" },
                { nameof(TypePipe2In), false },
                { nameof(TypePipe2Out), false },
                { nameof(DiameterPipe2), "EVA_D_Трубы_2" },
                { nameof(DiameterPipe2In), false },
                { nameof(DiameterPipe2Out), false },
                { nameof(LenPipe2), "EVA_L_Трубы_2" },
                { nameof(LenPipe2In), false },
                { nameof(LenPipe2Out), false },
                { nameof(Room), "EVA_Помещение" },
                { nameof(RoomIn), false },
                { nameof(RoomOut), false },
                { nameof(Project), "EVA_Проект" },
                { nameof(ProjectIn), false },
                { nameof(ProjectOut), false }
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