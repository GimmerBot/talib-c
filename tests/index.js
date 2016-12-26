var talib = require("../index.js");

// translated methods 
talib.macd(0, 0, [12,3,45], 3, 4, 5, [12,3,45], [12,3,45], [12,3,45], function(result){    
});

// directly method
talib.func({
    name: "Macd",
    startIdx: 0,
    endIdx: 2,
    inReal: [12,3,45],
    optInFastPeriod: 3,
    optInSlowPeriod: 4,
    optInSignalPeriod: 5,
    outBegIdx: 0,
    outNBElement: 0,
    outMACD: [12,3,45],
    outMACDSignal: [12,3,45],
    outMACDHist: [12,3,45]
}, function (error, result) {
    if (error) throw error;

    callback(result);
});