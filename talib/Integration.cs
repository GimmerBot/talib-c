using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using talib;
using TicTacTec.TA.Library;
using static TicTacTec.TA.Library.Core;

public class Integration
{
    public async Task<dynamic> Execute(IDictionary<string, object> values)
    {
        var method = typeof(Talib).GetMethod((string)values["name"]);
        var finalDictionary = new Dictionary<string, object>();

        var tParams = method.GetParameters();

        foreach (var item in tParams)
        {
            finalDictionary.Add(item.Name, values[item.Name]);
        }

        object[] parameters;

        ConvertParameters(finalDictionary, out parameters);
        var status = method.Invoke(null, parameters);

        var rParameters = new Dictionary<string, object>();
        for (int i = 0; i < parameters.Count(); i++)
        {
            var name = finalDictionary.Keys.ToList()[i];
            rParameters.Add(name, parameters[i]);
        }

        return await Task.FromResult(new
        {
            status,
            result = rParameters
        });
    }

    private static void ConvertParameters(IDictionary<string, object> values, out object[] parameters/*int outIndex, out int outBegIdx, out int outNBElement, */)
    {
        //outBegIdx = 0;
        //outNBElement = 0;
        var param = values.Values.ToList();
        for (int i = 0; i < param.Count; i++)
        {
            var item = param[i];

            if (item is object[])
            {
                param[i] = ConvertToArray<double>((object[])item);
            }            
        }

        //param.Insert(param.Count - outIndex, outBegIdx);
        //param.Insert(param.Count - outIndex, outNBElement);

        parameters = param.ToArray();
    }

    public async Task<dynamic> Acos(IDictionary<string, object> value)
    {
        var inReal = ConvertToArray<double>("inReal", value);
        var outReal = ConvertToArray<double>("outReal", value);
               
        int outBegIdx;
        int outNBElement;

        var result = Core.Acos((int)value["startIdx"], (int)value["endIdx"], inReal, out outBegIdx, out outNBElement, outReal);

        return await Task.FromResult(new
        {
            result,
            outBegIdx,
            outNBElement
        });
    }

    public async Task<dynamic> Ad(IDictionary<string, object> value)
    {
        var inHigh = ConvertToArray<double>("inHigh", value);
        var inLow = ConvertToArray<double>("inLow", value);
        var inClose = ConvertToArray<double>("inClose", value);
        var inVolume = ConvertToArray<double>("inVolume", value);
        var outReal = ConvertToArray<double>("outReal", value);

        int outBegIdx;
        int outNBElement;

        var result = Core.Ad((int)value["startIdx"], (int)value["endIdx"], inHigh, inLow, inClose, inVolume, out outBegIdx, out outNBElement, outReal);

        return await Task.FromResult(new
        {
            result,
            outBegIdx,
            outNBElement
        });
    }


    public async Task<dynamic> Add(IDictionary<string, object> value)
    {
        var inReal0 = ConvertToArray<double>("inReal0", value);
        var inReal1 = ConvertToArray<double>("inReal1", value);        
        var outReal = ConvertToArray<double>("outReal", value);

        int outBegIdx;
        int outNBElement;

        //int startIdx, int endIdx, double[] inReal0, double[] inReal1, out int outBegIdx, out int outNBElement, double[] outReal

        var result = Core.Add((int)value["startIdx"], (int)value["endIdx"], inReal0, inReal1, out outBegIdx, out outNBElement, outReal);

        return await Task.FromResult(new
        {
            result,
            outBegIdx,
            outNBElement
        });        
    }

    //public async Task<dynamic> AdOsc(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, double[] inVolume, int optInFastPeriod, int optInSlowPeriod, out int outBegIdx, out int outNBElement, double[] outReal);


    //public int AdOscLookback(int optInFastPeriod, int optInSlowPeriod);
    //public async Task<dynamic> Adx(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int AdxLookback(int optInTimePeriod);
    //public async Task<dynamic> Adxr(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int AdxrLookback(int optInTimePeriod);
    //public async Task<dynamic> Apo(int startIdx, int endIdx, double[] inReal, int optInFastPeriod, int optInSlowPeriod, MAType optInMAType, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int ApoLookback(int optInFastPeriod, int optInSlowPeriod, MAType optInMAType);

    //public async Task<dynamic> Aroon(int startIdx, int endIdx, double[] inHigh, double[] inLow, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outAroonDown, double[] outAroonUp);
    //public int AroonLookback(int optInTimePeriod);

    //public async Task<dynamic> AroonOsc(int startIdx, int endIdx, double[] inHigh, double[] inLow, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int AroonOscLookback(int optInTimePeriod);
    //public async Task<dynamic> Asin(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int AsinLookback();
    //public async Task<dynamic> Atan(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int AtanLookback();
    //public async Task<dynamic> Atr(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int AtrLookback(int optInTimePeriod);
    //public async Task<dynamic> AvgPrice(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int AvgPriceLookback();

    //public async Task<dynamic> Bbands(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, double optInNbDevUp, double optInNbDevDn, MAType optInMAType, out int outBegIdx, out int outNBElement, double[] outRealUpperBand, double[] outRealMiddleBand, double[] outRealLowerBand);
    //public int BbandsLookback(int optInTimePeriod, double optInNbDevUp, double optInNbDevDn, MAType optInMAType);

    //public async Task<dynamic> Beta(int startIdx, int endIdx, double[] inReal0, double[] inReal1, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int BetaLookback(int optInTimePeriod);

    //public async Task<dynamic> Bop(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int BopLookback();

    //public async Task<dynamic> Cci(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int CciLookback(int optInTimePeriod);

    //public async Task<dynamic> Cdl2Crows(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int Cdl2CrowsLookback();

    //public async Task<dynamic> Cdl3BlackCrows(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int Cdl3BlackCrowsLookback();
    //public async Task<dynamic> Cdl3Inside(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int Cdl3InsideLookback();
    //public async Task<dynamic> Cdl3LineStrike(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int Cdl3LineStrikeLookback();
    //public async Task<dynamic> Cdl3Outside(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int Cdl3OutsideLookback();
    //public async Task<dynamic> Cdl3StarsInSouth(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int Cdl3StarsInSouthLookback();
    //public async Task<dynamic> Cdl3WhiteSoldiers(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int Cdl3WhiteSoldiersLookback();
    //public async Task<dynamic> CdlAbandonedBaby(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, double optInPenetration, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlAbandonedBabyLookback(double optInPenetration);
    //public async Task<dynamic> CdlAdvanceBlock(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlAdvanceBlockLookback();
    //public async Task<dynamic> CdlBeltHold(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlBeltHoldLookback();

    //public async Task<dynamic> CdlBreakaway(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlBreakawayLookback();
    //public async Task<dynamic> CdlClosingMarubozu(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlClosingMarubozuLookback();
    //public async Task<dynamic> CdlConcealBabysWall(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlConcealBabysWallLookback();
    //public async Task<dynamic> CdlCounterAttack(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlCounterAttackLookback();

    //public async Task<dynamic> CdlDarkCloudCover(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, double optInPenetration, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlDarkCloudCoverLookback(double optInPenetration);

    //public async Task<dynamic> CdlDoji(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlDojiLookback();
    //public async Task<dynamic> CdlDojiStar(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlDojiStarLookback();
    //public async Task<dynamic> CdlDragonflyDoji(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlDragonflyDojiLookback();

    //public async Task<dynamic> CdlEngulfing(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlEngulfingLookback();
    //public async Task<dynamic> CdlEveningDojiStar(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, double optInPenetration, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlEveningDojiStarLookback(double optInPenetration);
    //public async Task<dynamic> CdlEveningStar(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, double optInPenetration, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlEveningStarLookback(double optInPenetration);

    //public async Task<dynamic> CdlGapSideSideWhite(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlGapSideSideWhiteLookback();
    //public async Task<dynamic> CdlGravestoneDoji(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlGravestoneDojiLookback();
    //public async Task<dynamic> CdlHammer(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlHammerLookback();
    //public async Task<dynamic> CdlHangingMan(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlHangingManLookback();

    //public async Task<dynamic> CdlHarami(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public async Task<dynamic> CdlHaramiCross(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlHaramiCrossLookback();
    //public int CdlHaramiLookback();
    //public async Task<dynamic> CdlHignWave(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlHignWaveLookback();

    //public async Task<dynamic> CdlHikkake(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlHikkakeLookback();

    //public async Task<dynamic> CdlHikkakeMod(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlHikkakeModLookback();

    //public async Task<dynamic> CdlHomingPigeon(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlHomingPigeonLookback();
    //public async Task<dynamic> CdlIdentical3Crows(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlIdentical3CrowsLookback();
    //public async Task<dynamic> CdlInNeck(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlInNeckLookback();

    //public async Task<dynamic> CdlInvertedHammer(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlInvertedHammerLookback();

    //public async Task<dynamic> CdlKicking(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public async Task<dynamic> CdlKickingByLength(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlKickingByLengthLookback();
    //public int CdlKickingLookback();
    //public async Task<dynamic> CdlLadderBottom(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlLadderBottomLookback();
    //public async Task<dynamic> CdlLongLeggedDoji(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlLongLeggedDojiLookback();

    //public async Task<dynamic> CdlLongLine(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlLongLineLookback();

    //public async Task<dynamic> CdlMarubozu(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlMarubozuLookback();

    //public async Task<dynamic> CdlMatchingLow(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlMatchingLowLookback();

    //public async Task<dynamic> CdlMatHold(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, double optInPenetration, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlMatHoldLookback(double optInPenetration);

    //public async Task<dynamic> CdlMorningDojiStar(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, double optInPenetration, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlMorningDojiStarLookback(double optInPenetration);
    //public async Task<dynamic> CdlMorningStar(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, double optInPenetration, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlMorningStarLookback(double optInPenetration);
    //public async Task<dynamic> CdlOnNeck(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlOnNeckLookback();

    //public async Task<dynamic> CdlPiercing(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlPiercingLookback();
    //public async Task<dynamic> CdlRickshawMan(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlRickshawManLookback();
    //public async Task<dynamic> CdlRiseFall3Methods(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlRiseFall3MethodsLookback();

    //public async Task<dynamic> CdlSeperatingLines(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlSeperatingLinesLookback();

    //public async Task<dynamic> CdlShootingStar(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlShootingStarLookback();
    //public async Task<dynamic> CdlShortLine(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlShortLineLookback();
    //public async Task<dynamic> CdlSpinningTop(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlSpinningTopLookback();

    //public async Task<dynamic> CdlStalledPattern(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);
    //public int CdlStalledPatternLookback();
    //public async Task<dynamic> CdlStickSandwhich(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlStickSandwhichLookback();
    //public async Task<dynamic> CdlTakuri(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlTakuriLookback();
    //public async Task<dynamic> CdlTasukiGap(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlTasukiGapLookback();
    //public async Task<dynamic> CdlThrusting(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlThrustingLookback();
    //public async Task<dynamic> CdlTristar(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlTristarLookback();
    //public async Task<dynamic> CdlUnique3River(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlUnique3RiverLookback();
    //public async Task<dynamic> CdlUpsideGap2Crows(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlUpsideGap2CrowsLookback();
    //public async Task<dynamic> CdlXSideGap3Methods(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int CdlXSideGap3MethodsLookback();

    //public async Task<dynamic> Ceil(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int CeilLookback();

    //public async Task<dynamic> Cmo(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int CmoLookback(int optInTimePeriod);
    //public async Task<dynamic> Correl(int startIdx, int endIdx, double[] inReal0, double[] inReal1, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int CorrelLookback(int optInTimePeriod);
    //public async Task<dynamic> Cos(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);

    //public async Task<dynamic> Cosh(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int CoshLookback();
    //public int CosLookback();

    //public async Task<dynamic> Dema(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int DemaLookback(int optInTimePeriod);

    //public async Task<dynamic> Div(int startIdx, int endIdx, double[] inReal0, double[] inReal1, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int DivLookback();
    //public async Task<dynamic> Dx(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int DxLookback(int optInTimePeriod);

    //public async Task<dynamic> Ema(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int EmaLookback(int optInTimePeriod);
    //public async Task<dynamic> Exp(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int ExpLookback();
    //public async Task<dynamic> Floor(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int FloorLookback();
    //public Compatibility GetCompatibility();
    //public uint GetUnstablePeriod(FuncUnstId id);

    //public async Task<dynamic> HtDcPeriod(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int HtDcPeriodLookback();

    //public async Task<dynamic> HtDcPhase(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int HtDcPhaseLookback();

    //public async Task<dynamic> HtPhasor(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outInPhase, double[] outQuadrature);
    //public int HtPhasorLookback();

    //public async Task<dynamic> HtSine(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outSine, double[] outLeadSine);
    //public int HtSineLookback();
    //public async Task<dynamic> HtTrendline(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int HtTrendlineLookback();
    //public async Task<dynamic> HtTrendMode(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int HtTrendModeLookback();

    //public async Task<dynamic> Kama(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int KamaLookback(int optInTimePeriod);

    //public async Task<dynamic> LinearReg(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);

    //public async Task<dynamic> LinearRegAngle(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int LinearRegAngleLookback(int optInTimePeriod);

    //public async Task<dynamic> LinearRegIntercept(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int LinearRegInterceptLookback(int optInTimePeriod);
    //public int LinearRegLookback(int optInTimePeriod);

    //public async Task<dynamic> LinearRegSlope(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int LinearRegSlopeLookback(int optInTimePeriod);

    //public async Task<dynamic> Ln(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int LnLookback();
    //public async Task<dynamic> Log10(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int Log10Lookback();
    //public async Task<dynamic> Macd(int startIdx, int endIdx, double[] inReal, int optInFastPeriod, int optInSlowPeriod, int optInSignalPeriod, out int outBegIdx, out int outNBElement, double[] outMACD, double[] outMACDSignal, double[] outMACDHist);

    //public async Task<dynamic> MacdExt(int startIdx, int endIdx, double[] inReal, int optInFastPeriod, MAType optInFastMAType, int optInSlowPeriod, MAType optInSlowMAType, int optInSignalPeriod, MAType optInSignalMAType, out int outBegIdx, out int outNBElement, double[] outMACD, double[] outMACDSignal, double[] outMACDHist);

    //public int MacdExtLookback(int optInFastPeriod, MAType optInFastMAType, int optInSlowPeriod, MAType optInSlowMAType, int optInSignalPeriod, MAType optInSignalMAType);

    //public async Task<dynamic> MacdFix(int startIdx, int endIdx, double[] inReal, int optInSignalPeriod, out int outBegIdx, out int outNBElement, double[] outMACD, double[] outMACDSignal, double[] outMACDHist);
    //public int MacdFixLookback(int optInSignalPeriod);
    //public int MacdLookback(int optInFastPeriod, int optInSlowPeriod, int optInSignalPeriod);

    //public async Task<dynamic> Mama(int startIdx, int endIdx, double[] inReal, double optInFastLimit, double optInSlowLimit, out int outBegIdx, out int outNBElement, double[] outMAMA, double[] outFAMA);
    //public int MamaLookback(double optInFastLimit, double optInSlowLimit);
    //public async Task<dynamic> Max(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);

    //public async Task<dynamic> MaxIndex(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int MaxIndexLookback(int optInTimePeriod);
    //public int MaxLookback(int optInTimePeriod);

    //public async Task<dynamic> MedPrice(int startIdx, int endIdx, double[] inHigh, double[] inLow, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int MedPriceLookback();
    //public async Task<dynamic> Mfi(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, double[] inVolume, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int MfiLookback(int optInTimePeriod);

    //public async Task<dynamic> MidPoint(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int MidPointLookback(int optInTimePeriod);

    //public async Task<dynamic> MidPrice(int startIdx, int endIdx, double[] inHigh, double[] inLow, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int MidPriceLookback(int optInTimePeriod);
    //public async Task<dynamic> Min(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);

    //public async Task<dynamic> MinIndex(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, int[] outInteger);

    //public int MinIndexLookback(int optInTimePeriod);
    //public int MinLookback(int optInTimePeriod);
    //public async Task<dynamic> MinMax(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outMin, double[] outMax);

    //public async Task<dynamic> MinMaxIndex(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, int[] outMinIdx, int[] outMaxIdx);

    //public int MinMaxIndexLookback(int optInTimePeriod);
    //public int MinMaxLookback(int optInTimePeriod);
    //public async Task<dynamic> MinusDI(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int MinusDILookback(int optInTimePeriod);
    //public async Task<dynamic> MinusDM(int startIdx, int endIdx, double[] inHigh, double[] inLow, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int MinusDMLookback(int optInTimePeriod);
    //public async Task<dynamic> Mom(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int MomLookback(int optInTimePeriod);
    //public async Task<dynamic> MovingAverage(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, MAType optInMAType, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int MovingAverageLookback(int optInTimePeriod, MAType optInMAType);

    //public async Task<dynamic> MovingAverageVariablePeriod(int startIdx, int endIdx, double[] inReal, double[] inPeriods, int optInMinPeriod, int optInMaxPeriod, MAType optInMAType, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int MovingAverageVariablePeriodLookback(int optInMinPeriod, int optInMaxPeriod, MAType optInMAType);

    //public async Task<dynamic> Mult(int startIdx, int endIdx, double[] inReal0, double[] inReal1, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int MultLookback();

    //public async Task<dynamic> Natr(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int NatrLookback(int optInTimePeriod);

    //public async Task<dynamic> Obv(int startIdx, int endIdx, double[] inReal, double[] inVolume, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int ObvLookback();

    //public async Task<dynamic> PlusDI(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int PlusDILookback(int optInTimePeriod);
    //public async Task<dynamic> PlusDM(int startIdx, int endIdx, double[] inHigh, double[] inLow, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int PlusDMLookback(int optInTimePeriod);

    //public async Task<dynamic> Ppo(int startIdx, int endIdx, double[] inReal, int optInFastPeriod, int optInSlowPeriod, MAType optInMAType, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int PpoLookback(int optInFastPeriod, int optInSlowPeriod, MAType optInMAType);
    //public async Task<dynamic> RestoreCandleDefaultSettings(CandleSettingType settingType);

    //public async Task<dynamic> Roc(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int RocLookback(int optInTimePeriod);
    //public async Task<dynamic> RocP(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int RocPLookback(int optInTimePeriod);

    //public async Task<dynamic> RocR(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);

    //public async Task<dynamic> RocR100(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int RocR100Lookback(int optInTimePeriod);
    //public int RocRLookback(int optInTimePeriod);
    //public async Task<dynamic> Rsi(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int RsiLookback(int optInTimePeriod);
    //public async Task<dynamic> Sar(int startIdx, int endIdx, double[] inHigh, double[] inLow, double optInAcceleration, double optInMaximum, out int outBegIdx, out int outNBElement, double[] outReal);

    //public async Task<dynamic> SarExt(int startIdx, int endIdx, double[] inHigh, double[] inLow, double optInStartValue, double optInOffsetOnReverse, double optInAccelerationInitLong, double optInAccelerationLong, double optInAccelerationMaxLong, double optInAccelerationInitShort, double optInAccelerationShort, double optInAccelerationMaxShort, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int SarExtLookback(double optInStartValue, double optInOffsetOnReverse, double optInAccelerationInitLong, double optInAccelerationLong, double optInAccelerationMaxLong, double optInAccelerationInitShort, double optInAccelerationShort, double optInAccelerationMaxShort);
    //public int SarLookback(double optInAcceleration, double optInMaximum);
    //public async Task<dynamic> SetCandleSettings(CandleSettingType settingType, RangeType rangeType, int avgPeriod, double factor);
    //public async Task<dynamic> SetCompatibility(Compatibility value);
    //public async Task<dynamic> SetUnstablePeriod(FuncUnstId id, uint unstablePeriod);

    //public async Task<dynamic> Sin(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);

    //public async Task<dynamic> Sinh(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int SinhLookback();
    //public int SinLookback();

    //public async Task<dynamic> Sma(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int SmaLookback(int optInTimePeriod);

    //public async Task<dynamic> Sqrt(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int SqrtLookback();

    //public async Task<dynamic> StdDev(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, double optInNbDev, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int StdDevLookback(int optInTimePeriod, double optInNbDev);

    //public async Task<dynamic> Stoch(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInFastK_Period, int optInSlowK_Period, MAType optInSlowK_MAType, int optInSlowD_Period, MAType optInSlowD_MAType, out int outBegIdx, out int outNBElement, double[] outSlowK, double[] outSlowD);

    //public async Task<dynamic> StochF(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInFastK_Period, int optInFastD_Period, MAType optInFastD_MAType, out int outBegIdx, out int outNBElement, double[] outFastK, double[] outFastD);
    //public int StochFLookback(int optInFastK_Period, int optInFastD_Period, MAType optInFastD_MAType);
    //public int StochLookback(int optInFastK_Period, int optInSlowK_Period, MAType optInSlowK_MAType, int optInSlowD_Period, MAType optInSlowD_MAType);

    //public async Task<dynamic> StochRsi(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, int optInFastK_Period, int optInFastD_Period, MAType optInFastD_MAType, out int outBegIdx, out int outNBElement, double[] outFastK, double[] outFastD);
    //public int StochRsiLookback(int optInTimePeriod, int optInFastK_Period, int optInFastD_Period, MAType optInFastD_MAType);
    //public async Task<dynamic> Sub(int startIdx, int endIdx, double[] inReal0, double[] inReal1, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int SubLookback();

    //public async Task<dynamic> Sum(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int SumLookback(int optInTimePeriod);

    //public async Task<dynamic> T3(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, double optInVFactor, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int T3Lookback(int optInTimePeriod, double optInVFactor);

    //public async Task<dynamic> Tan(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);

    //public async Task<dynamic> Tanh(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int TanhLookback();
    //public int TanLookback();

    //public async Task<dynamic> Tema(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int TemaLookback(int optInTimePeriod);

    //public async Task<dynamic> Trima(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int TrimaLookback(int optInTimePeriod);

    //public async Task<dynamic> Trix(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int TrixLookback(int optInTimePeriod);
    //public async Task<dynamic> TrueRange(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int TrueRangeLookback();

    //public async Task<dynamic> Tsf(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int TsfLookback(int optInTimePeriod);

    //public async Task<dynamic> TypPrice(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int TypPriceLookback();
    //public async Task<dynamic> UltOsc(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod1, int optInTimePeriod2, int optInTimePeriod3, out int outBegIdx, out int outNBElement, double[] outReal);

    //public int UltOscLookback(int optInTimePeriod1, int optInTimePeriod2, int optInTimePeriod3);

    //public async Task<dynamic> Variance(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, double optInNbDev, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int VarianceLookback(int optInTimePeriod, double optInNbDev);

    //public async Task<dynamic> WclPrice(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int WclPriceLookback();

    //public async Task<dynamic> WillR(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int WillRLookback(int optInTimePeriod);

    //public async Task<dynamic> Wma(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal);
    //public int WmaLookback(int optInTimePeriod);







    private static T[] ConvertToArray<T>(string name, IDictionary<string, object> value)
    {
        var list = new List<T>();
        foreach (var item in (object[])value[name])
        {
            list.Add((T)Convert.ChangeType(item, typeof(T)));
        }

        return list.ToArray();
    }

    private static T[] ConvertToArray<T>(object[] values)
    {
        var list = new List<T>();
        foreach (var item in values)
        {
            if (item != null)
            {
                list.Add((T)Convert.ChangeType(item, typeof(T))); 
            }
            else
            {
                list.Add(default(T));
            }
        }

        return list.ToArray();
    }
}
