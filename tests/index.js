var talib = require("../index.js");

__awaiter(this, void 0, Promise, function* () {

    // translated methods 
    result = yield talib.func({ name: "Acos", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });   

    result = yield talib.func({ name: "AcosLookback" });

    result = yield talib.func({ name: "Ad", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], inVolume: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "Add", startIdx: 0, endIdx: 2, inReal0: [12, 3, 45], inReal1: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });

    result = yield talib.func({ name: "AddLookback" });
    result = yield talib.func({ name: "AdLookback" });
    result = yield talib.func({ name: "AdOsc", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], inVolume: [12, 3, 45], optInFastPeriod: 2, optInSlowPeriod: 4, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });

    result = yield talib.func({ name: "AdOscLookback", optInFastPeriod: 2, optInSlowPeriod: 4 });
    result = yield talib.func({ name: "Adx", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });

    result = yield talib.func({ name: "AdxLookback", optInTimePeriod: 2 });

    result = yield talib.func({ name: "Adxr", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "AdxrLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Apo", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInFastPeriod: 2, optInSlowPeriod: 4, optInMAType: MAType.Dema, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "ApoLookback", optInFastPeriod: 2, optInSlowPeriod: 4, optInMAType: MAType.Dema });
    result = yield talib.func({ name: "Aroon", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outAroonDown: [12, 3, 45], outAroonUp: [12, 3, 45] });
    result = yield talib.func({ name: "AroonLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "AroonOsc", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "AroonOscLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Asin", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "AsinLookback" });
    result = yield talib.func({ name: "Atan", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "AtanLookback" });
    result = yield talib.func({ name: "Atr", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });

    result = yield talib.func({ name: "AtrLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "AvgPrice", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });

    result = yield talib.func({ name: "AvgPriceLookback" });
    result = yield talib.func({ name: "Bbands", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, optInNbDevUp: 1, optInNbDevDn: 2, optInMAType: MAType.Dema, outBegIdx: 0, outNBElement: 0, outRealUpperBand: [12, 3, 45], outRealMiddleBand: [12, 3, 45], outRealLowerBand: [12, 3, 45] });
    result = yield talib.func({ name: "BbandsLookback", optInTimePeriod: 2, optInNbDevUp: 1, optInNbDevDn: 2, optInMAType: MAType.Dema });

    result = yield talib.func({ name: "Beta", startIdx: 0, endIdx: 2, inReal0: [12, 3, 45], inReal1: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "BetaLookback", optInTimePeriod: 2 });

    result = yield talib.func({ name: "Bop", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "BopLookback" });

    result = yield talib.func({ name: "Cci", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "CciLookback", optInTimePeriod: 2 });

    result = yield talib.func({ name: "Cdl2Crows", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "Cdl2CrowsLookback" });

    result = yield talib.func({ name: "Cdl3BlackCrows", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "Cdl3BlackCrowsLookback" });
    result = yield talib.func({ name: "Cdl3Inside", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "Cdl3InsideLookback" });
    result = yield talib.func({ name: "Cdl3LineStrike", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "Cdl3LineStrikeLookback" });
    result = yield talib.func({ name: "Cdl3Outside", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "Cdl3OutsideLookback" });
    result = yield talib.func({ name: "Cdl3StarsInSouth", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "Cdl3StarsInSouthLookback" });
    result = yield talib.func({ name: "Cdl3WhiteSoldiers", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "Cdl3WhiteSoldiersLookback" });
    result = yield talib.func({ name: "CdlAbandonedBaby", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInPenetration: 2, outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlAbandonedBabyLookback", optInPenetration: 2 });
    result = yield talib.func({ name: "CdlAdvanceBlock", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlAdvanceBlockLookback" });
    result = yield talib.func({ name: "CdlBeltHold", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlBeltHoldLookback" });

    result = yield talib.func({ name: "CdlBreakaway", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlBreakawayLookback" });
    result = yield talib.func({ name: "CdlClosingMarubozu", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlClosingMarubozuLookback" });
    result = yield talib.func({ name: "CdlConcealBabysWall", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlConcealBabysWallLookback" });
    result = yield talib.func({ name: "CdlCounterAttack", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlCounterAttackLookback" });

    result = yield talib.func({ name: "CdlDarkCloudCover", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInPenetration: 2, outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlDarkCloudCoverLookback", optInPenetration: 2 });

    result = yield talib.func({ name: "CdlDoji", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlDojiLookback" });
    result = yield talib.func({ name: "CdlDojiStar", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlDojiStarLookback" });
    result = yield talib.func({ name: "CdlDragonflyDoji", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlDragonflyDojiLookback" });

    result = yield talib.func({ name: "CdlEngulfing", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlEngulfingLookback" });
    result = yield talib.func({ name: "CdlEveningDojiStar", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInPenetration: 2, outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlEveningDojiStarLookback", optInPenetration: 2 });
    result = yield talib.func({ name: "CdlEveningStar", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInPenetration: 2, outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlEveningStarLookback", optInPenetration: 2 });

    result = yield talib.func({ name: "CdlGapSideSideWhite", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlGapSideSideWhiteLookback" });
    result = yield talib.func({ name: "CdlGravestoneDoji", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlGravestoneDojiLookback" });
    result = yield talib.func({ name: "CdlHammer", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlHammerLookback" });
    result = yield talib.func({ name: "CdlHangingMan", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlHangingManLookback" });

    result = yield talib.func({ name: "CdlHarami", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlHaramiCross", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlHaramiCrossLookback" });
    result = yield talib.func({ name: "CdlHaramiLookback" });
    result = yield talib.func({ name: "CdlHignWave", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlHignWaveLookback" });

    result = yield talib.func({ name: "CdlHikkake", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlHikkakeLookback" });

    result = yield talib.func({ name: "CdlHikkakeMod", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlHikkakeModLookback" });

    result = yield talib.func({ name: "CdlHomingPigeon", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlIdentical3Crows", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlIdentical3CrowsLookback" });
    result = yield talib.func({ name: "CdlInNeck", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlInNeckLookback" });

    result = yield talib.func({ name: "CdlInvertedHammer", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlInvertedHammerLookback" });

    result = yield talib.func({ name: "CdlKicking", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlKickingByLength", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlKickingByLengthLookback" });
    result = yield talib.func({ name: "CdlKickingLookback" });
    result = yield talib.func({ name: "CdlLadderBottom", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlLadderBottomLookback" });
    result = yield talib.func({ name: "CdlLongLeggedDoji", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlLongLeggedDojiLookback" });

    result = yield talib.func({ name: "CdlLongLine", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlLongLineLookback" });

    result = yield talib.func({ name: "CdlMarubozu", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlMarubozuLookback" });

    result = yield talib.func({ name: "CdlMatchingLow", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlMatchingLowLookback" });

    result = yield talib.func({ name: "CdlMatHold", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInPenetration: 2, outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlMatHoldLookback", optInPenetration: 2 });

    result = yield talib.func({ name: "CdlMorningDojiStar", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInPenetration: 2, outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlMorningDojiStarLookback", optInPenetration: 2 });
    result = yield talib.func({ name: "CdlMorningStar", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInPenetration: 2, outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlMorningStarLookback", optInPenetration: 2 });
    result = yield talib.func({ name: "CdlOnNeck", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlOnNeckLookback" });

    result = yield talib.func({ name: "CdlPiercing", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlPiercingLookback" });
    result = yield talib.func({ name: "CdlRickshawMan", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlRickshawManLookback" });
    result = yield talib.func({ name: "CdlRiseFall3Methods", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlRiseFall3MethodsLookback" });

    result = yield talib.func({ name: "CdlSeperatingLines", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlSeperatingLinesLookback" });

    result = yield talib.func({ name: "CdlShootingStar", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlShootingStarLookback" });
    result = yield talib.func({ name: "CdlShortLine", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlShortLineLookback" });
    result = yield talib.func({ name: "CdlSpinningTop", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlSpinningTopLookback" });

    result = yield talib.func({ name: "CdlStalledPattern", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "CdlStalledPatternLookback" });
    result = yield talib.func({ name: "CdlStickSandwhich", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlStickSandwhichLookback" });
    result = yield talib.func({ name: "CdlTakuri", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlTakuriLookback" });
    result = yield talib.func({ name: "CdlTasukiGap", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlTasukiGapLookback" });
    result = yield talib.func({ name: "CdlThrusting", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlThrustingLookback" });
    result = yield talib.func({ name: "CdlTristar", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlTristarLookback" });
    result = yield talib.func({ name: "CdlUnique3River", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlUnique3RiverLookback" });
    result = yield talib.func({ name: "CdlUpsideGap2Crows", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlUpsideGap2CrowsLookback" });
    result = yield talib.func({ name: "CdlXSideGap3Methods", startIdx: 0, endIdx: 2, inOpen: [12, 3, 45], inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });

    result = yield talib.func({ name: "CdlXSideGap3MethodsLookback" });
    result = yield talib.func({ name: "Ceil", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "CeilLookback" });
    result = yield talib.func({ name: "Cmo", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "CmoLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Correl", startIdx: 0, endIdx: 2, inReal0: [12, 3, 45], inReal1: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });

    result = yield talib.func({ name: "CorrelLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Cos", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "Cosh", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "CoshLookback" });
    result = yield talib.func({ name: "CosLookback" });
    result = yield talib.func({ name: "Dema", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "DemaLookback", optInTimePeriod: 2 });

    result = yield talib.func({ name: "Div", startIdx: 0, endIdx: 2, inReal0: [12, 3, 45], inReal1: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "DivLookback" });
    result = yield talib.func({ name: "Dx", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });

    result = yield talib.func({ name: "DxLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Ema", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "EmaLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Exp", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "ExpLookback" });
    result = yield talib.func({ name: "Floor", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "FloorLookback" });
    result = yield talib.func({ name: "GetCompatibility" });
    result = yield talib.func({ name: "HtDcPeriod", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "HtDcPeriodLookback" });
    result = yield talib.func({ name: "HtDcPhase", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "HtDcPhaseLookback" });
    result = yield talib.func({ name: "HtPhasor", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInPhase: [12, 3, 45], outQuadrature: [12, 3, 45] });
    result = yield talib.func({ name: "HtPhasorLookback" });
    result = yield talib.func({ name: "HtSine", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outSine: [12, 3, 45], outLeadSine: [12, 3, 45] });
    result = yield talib.func({ name: "HtSineLookback" });
    result = yield talib.func({ name: "HtTrendline", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "HtTrendlineLookback" });
    result = yield talib.func({ name: "HtTrendMode", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "HtTrendModeLookback" });
    result = yield talib.func({ name: "Kama", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "KamaLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "LinearReg", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "LinearRegAngle", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "LinearRegAngleLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "LinearRegIntercept", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "LinearRegInterceptLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "LinearRegLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "LinearRegSlope", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "LinearRegSlopeLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Ln", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "LnLookback" });
    result = yield talib.func({ name: "Log10", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "Log10Lookback" });
    result = yield talib.func({ name: "Macd", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInFastPeriod: 2, optInSlowPeriod: 4, optInSignalPeriod: 2, outBegIdx: 0, outNBElement: 0, outMACD: [0, 0, 0], outMACDSignal: [0, 0, 0], outMACDHist: [0, 0, 0] });
    result = yield talib.func({ name: "MacdExt", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInFastPeriod: 2, optInFastMAType: MAType.Dema, optInSlowPeriod: 4, optInSlowMAType: MAType.Dema, optInSignalPeriod: 2, optInSignalMAType: MAType.Dema, outBegIdx: 0, outNBElement: 0, outMACD: [0, 0, 0], outMACDSignal: [0, 0, 0], outMACDHist: [0, 0, 0] });
    result = yield talib.func({ name: "MacdExtLookback", optInFastPeriod: 2, optInFastMAType: MAType.Dema, optInSlowPeriod: 4, optInSlowMAType: MAType.Dema, optInSignalPeriod: 2, optInSignalMAType: MAType.Dema });
    result = yield talib.func({ name: "MacdFix", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInSignalPeriod: 2, outBegIdx: 0, outNBElement: 0, outMACD: [0, 0, 0], outMACDSignal: [0, 0, 0], outMACDHist: [0, 0, 0] });
    result = yield talib.func({ name: "MacdFixLookback", optInSignalPeriod: 2 });
    result = yield talib.func({ name: "MacdLookback", optInFastPeriod: 2, optInSlowPeriod: 4, optInSignalPeriod: 2 });
    result = yield talib.func({ name: "Mama", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInFastLimit: 2, optInSlowLimit: 3, outBegIdx: 0, outNBElement: 0, outMAMA: [0, 0, 0], outFAMA: [0, 0, 0] });
    result = yield talib.func({ name: "MamaLookback", optInFastLimit: 2, optInSlowLimit: 3 });
    result = yield talib.func({ name: "Max", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "MaxIndex", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "MaxIndexLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "MaxLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "MedPrice", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "MedPriceLookback" });
    result = yield talib.func({ name: "Mfi", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], inVolume: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });

    result = yield talib.func({ name: "MfiLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "MidPoint", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "MidPointLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "MidPrice", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "MidPriceLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Min", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "MinIndex", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outInteger: [12, 3, 45] });
    result = yield talib.func({ name: "MinIndexLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "MinLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "MinMax", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outMin: [0, 0, 0], outMax: [0, 0, 0] });
    result = yield talib.func({ name: "MinMaxIndex", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outMinIdx: [0, 0, 0], outMaxIdx: [0, 0, 0] });
    result = yield talib.func({ name: "MinMaxIndexLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "MinMaxLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "MinusDI", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });

    result = yield talib.func({ name: "MinusDILookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "MinusDM", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "MinusDMLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Mom", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "MomLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "MovingAverage", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, optInMAType: MAType.Dema, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "MovingAverageLookback", optInTimePeriod: 2, optInMAType: MAType.Dema });

    result = yield talib.func({ name: "MovingAverageVariablePeriod", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], inPeriods: [12, 3, 45], optInMinPeriod: 2, optInMaxPeriod: 2, optInMAType: MAType.Dema, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "MovingAverageVariablePeriodLookback", optInMinPeriod: 2, optInMaxPeriod: 2, optInMAType: MAType.Dema });

    result = yield talib.func({ name: "Mult", startIdx: 0, endIdx: 2, inReal0: [12, 3, 45], inReal1: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "MultLookback" });

    result = yield talib.func({ name: "Natr", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "NatrLookback", optInTimePeriod: 2 });

    result = yield talib.func({ name: "Obv", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], inVolume: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "ObvLookback" });

    result = yield talib.func({ name: "PlusDI", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "PlusDILookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "PlusDM", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "PlusDMLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Ppo", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInFastPeriod: 2, optInSlowPeriod: 4, optInMAType: MAType.Dema, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "PpoLookback", optInFastPeriod: 2, optInSlowPeriod: 4, optInMAType: MAType.Dema });
    result = yield talib.func({ name: "RestoreCandleDefaultSettings", settingType: CandleSettingType.AllCandleSettings });
    result = yield talib.func({ name: "Roc", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "RocLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "RocP", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "RocPLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "RocR", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "RocR100", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "RocR100Lookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "RocRLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Rsi", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "RsiLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Sar", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], optInAcceleration: 1, optInMaximum: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "SarExt", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], optInStartValue: 0, optInOffsetOnReverse: 1, optInAccelerationInitLong: 1, optInAccelerationLong: 1, optInAccelerationMaxLong: 2, optInAccelerationInitShort: 1, optInAccelerationShort: 1, optInAccelerationMaxShort: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "SarExtLookback", optInStartValue: 0, optInOffsetOnReverse: 1, optInAccelerationInitLong: 1, optInAccelerationLong: 1, optInAccelerationMaxLong: 2, optInAccelerationInitShort: 1, optInAccelerationShort: 1, optInAccelerationMaxShort: 2 });
    result = yield talib.func({ name: "SarLookback", optInAcceleration: 1, optInMaximum: 2 });
    result = yield talib.func({ name: "SetCandleSettings", settingType: CandleSettingType.AllCandleSettings, rangeType: RangeType.RealBody, avgPeriod: 2, factor: 1 });
    result = yield talib.func({ name: "SetCompatibility", value: Compatibility.Default });
    result = yield talib.func({ name: "Sin", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "Sinh", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "SinhLookback" });
    result = yield talib.func({ name: "SinLookback" });
    result = yield talib.func({ name: "Sma", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "SmaLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Sqrt", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "SqrtLookback" });
    result = yield talib.func({ name: "StdDev", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, optInNbDev: 1, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "StdDevLookback", optInTimePeriod: 2, optInNbDev: 1 });
    result = yield talib.func({ name: "Stoch", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInFastK_Period: 1, optInSlowK_Period: 1, optInSlowK_MAType: MAType.Ema, optInSlowD_Period: 1, optInSlowD_MAType: MAType.Ema, outBegIdx: 0, outNBElement: 0, outSlowK: [0, 0, 0], outSlowD: [0, 0, 0] });

    result = yield talib.func({ name: "StochF", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInFastK_Period: 1, optInFastD_Period: 2, optInFastD_MAType: MAType.Ema, outBegIdx: 0, outNBElement: 0, outFastK: [0, 0, 0], outFastD: [0, 0, 0] });
    result = yield talib.func({ name: "StochFLookback", optInFastK_Period: 1, optInFastD_Period: 2, optInFastD_MAType: MAType.Ema });
    result = yield talib.func({ name: "StochLookback", optInFastK_Period: 1, optInSlowK_Period: 1, optInSlowK_MAType: MAType.Ema, optInSlowD_Period: 1, optInSlowD_MAType: MAType.Ema });
    result = yield talib.func({ name: "StochRsi", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, optInFastK_Period: 1, optInFastD_Period: 2, optInFastD_MAType: MAType.Ema, outBegIdx: 0, outNBElement: 0, outFastK: [0, 0, 0], outFastD: [0, 0, 0] });
    result = yield talib.func({ name: "StochRsiLookback", optInTimePeriod: 2, optInFastK_Period: 1, optInFastD_Period: 2, optInFastD_MAType: MAType.Ema });
    result = yield talib.func({ name: "Sub", startIdx: 0, endIdx: 2, inReal0: [12, 3, 45], inReal1: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });

    result = yield talib.func({ name: "SubLookback" });
    result = yield talib.func({ name: "Sum", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "SumLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "T3", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, optInVFactor: 1, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "T3Lookback", optInTimePeriod: 2, optInVFactor: 1 });
    result = yield talib.func({ name: "Tan", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "Tanh", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "TanhLookback" });
    result = yield talib.func({ name: "TanLookback" });
    result = yield talib.func({ name: "Tema", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "TemaLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Trima", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "TrimaLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Trix", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "TrixLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "TrueRange", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });

    result = yield talib.func({ name: "TrueRangeLookback" });
    result = yield talib.func({ name: "Tsf", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "TsfLookback", optInTimePeriod: 2 });

    result = yield talib.func({ name: "TypPrice", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "TypPriceLookback" });
    result = yield talib.func({ name: "UltOsc", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInTimePeriod1: 1, optInTimePeriod2: 2, optInTimePeriod3: 0, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });

    result = yield talib.func({ name: "UltOscLookback", optInTimePeriod1: 1, optInTimePeriod2: 2, optInTimePeriod3: 0 });
    result = yield talib.func({ name: "Variance", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, optInNbDev: 1, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "VarianceLookback", optInTimePeriod: 2, optInNbDev: 1 });

    result = yield talib.func({ name: "WillR", startIdx: 0, endIdx: 2, inHigh: [12, 3, 45], inLow: [12, 3, 45], inClose: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "WillRLookback", optInTimePeriod: 2 });
    result = yield talib.func({ name: "Wma", startIdx: 0, endIdx: 2, inReal: [12, 3, 45], optInTimePeriod: 2, outBegIdx: 0, outNBElement: 0, outReal: [12, 3, 45] });
    result = yield talib.func({ name: "WmaLookback", optInTimePeriod: 2 });
});