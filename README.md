# tablib-c
Talib Library implement 2 methods to call talib methods

// Sample 1 - Translated methods (Incomplete, need implements more methods)
talib.macd(0, 0, [12,3,45], 3, 4, 5, [12,3,45], [12,3,45], [12,3,45], function(result){    
});

// Sample 2 - directly method - (Complete, integrated all Talib methods)
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
