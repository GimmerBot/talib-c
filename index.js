var edge = require('edge');

var macdFunc = edge.func({
    assemblyFile: 'talib\\bin\\Debug\\talib.dll',
    typeName: 'Integration',
    methodName: 'Macd'
});

function macd(int_startIdx, int_endIdx, doubleArray_inReal, int_optInFastPeriod,
    int_optInSlowPeriod, int_optInSignalPeriod, doubleArray_outMACD,
    doubleArray_outMACDSignal, doubleArray_outMACDHist, callback) {
    macdFunc({
        startIdx: int_startIdx,
        endIdx: int_endIdx,
        inReal: doubleArray_inReal,
        optInFastPeriod: int_optInFastPeriod,
        optInSlowPeriod: int_optInSlowPeriod,
        optInSignalPeriod: int_optInSignalPeriod,
        outMACD: doubleArray_outMACD,
        outMACDSignal: doubleArray_outMACDSignal,
        outMACDHist: doubleArray_outMACDHist
    }, function (error, result) {
        if (error) throw error;

        callback(result);
    });
}

//macd(0, 0, [12,3,45], 3, 4, 5, [12,3,45], [12,3,45], [12,3,45], function(result){    
//});

module.exports = this;