var edge = require('edge');

var talibFunc = edge.func({
    assemblyFile: 'node_modules\\talib-c\\talib.dll',
    typeName: 'Integration',
    methodName: 'Execute'
});

function macd(int_startIdx, int_endIdx, doubleArray_inReal, int_optInFastPeriod,
    int_optInSlowPeriod, int_optInSignalPeriod, doubleArray_outMACD,
    doubleArray_outMACDSignal, doubleArray_outMACDHist, callback) {
    talibFunc({
        name: "Macd",
        startIdx: int_startIdx,
        endIdx: int_endIdx,
        inReal: doubleArray_inReal,
        optInFastPeriod: int_optInFastPeriod,
        optInSlowPeriod: int_optInSlowPeriod,
        optInSignalPeriod: int_optInSignalPeriod,
        outBegIdx: 0,
        outNBElement: 0,
        outMACD: doubleArray_outMACD,
        outMACDSignal: doubleArray_outMACDSignal,
        outMACDHist: doubleArray_outMACDHist
    }, function (error, result) {
        if (error) throw error;

        callback(result);
    });
}

module.exports = {
    macd: macd,
    func: talibFunc
};