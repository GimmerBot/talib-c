var edge = require('edge');
var findNodeModules  = require ('find-node-modules') ;

__awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator.throw(value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments)).next());
    });
};

var talibFunc = edge.func({
    assemblyFile: findNodeModules()[0] + '\\talib-c\\talib.dll',
    typeName: 'Integration',
    methodName: 'Execute'
});

CandleSettingType =
    {
        BodyLong: 0,
        BodyVeryLong: 1,
        BodyShort: 2,
        BodyDoji: 3,
        ShadowLong: 4,
        ShadowVeryLong: 5,
        ShadowShort: 6,
        ShadowVeryShort: 7,
        Near: 8,
        Far: 9,
        Equal: 10,
        AllCandleSettings: 11
    };

Compatibility =
    {
        Default: 0,
        Metastock: 1
    };

FuncUnstId =
    {
        FuncUnstNone: -1,
        Adx: 0,
        Adxr: 1,
        Atr: 2,
        Cmo: 3,
        Dx: 4,
        Ema: 5,
        HtDcPeriod: 6,
        HtDcPhase: 7,
        HtPhasor: 8,
        HtSine: 9,
        HtTrendline: 10,
        HtTrendMode: 11,
        Kama: 12,
        Mama: 13,
        Mfi: 14,
        MinusDI: 15,
        MinusDM: 16,
        Natr: 17,
        PlusDI: 18,
        PlusDM: 19,
        Rsi: 20,
        StochRsi: 21,
        T3: 22,
        FuncUnstAll: 23
    };

MAType =
    {
        Sma: 0,
        Ema: 1,
        Wma: 2,
        Dema: 3,
        Tema: 4,
        Trima: 5,
        Kama: 6,
        Mama: 7,
        T3: 8
    };

RangeType =
    {
        RealBody: 0,
        HighLow: 1,
        Shadows: 2
    };

RetCode =
    {
        Success: 0,
        LibNotInitialize: 1,
        BadParam: 2,
        AllocErr: 3,
        GroupNotFound: 4,
        FuncNotFound: 5,
        InvalidHandle: 6,
        InvalidParamHolder: 7,
        InvalidParamHolderType: 8,
        InvalidParamFunction: 9,
        InputNotAllInitialize: 10,
        OutputNotAllInitialize: 11,
        OutOfRangeStartIndex: 12,
        OutOfRangeEndIndex: 13,
        InvalidListType: 14,
        BadObject: 15,
        NotSupported: 16,
        InternalError: 5000,
        UnknownErr: 65535
    };

function talibFuncAsync(parameters, callback) {
    return new Promise(function (resolve, reject) {
        talibFunc(parameters, function (error, result) {
            if (error) {
                reject(error);
            }
            else {
                result.name = parameters.name;                    
                resolve(result);

                if (callback) {
                    callback(result);
                }                
            }
        });
    });
}

module.exports = {
    func: talibFuncAsync
};