using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacTec.TA.Library;
using static TicTacTec.TA.Library.Core;

namespace talib
{
    public class Talib
    {
        public static RetCode Acos(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Acos(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outReal);
        }

        public static int AcosLookback()
        {
            return Core.AcosLookback();
        }

        public static RetCode Ad(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, double[] inVolume, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Ad(startIdx, endIdx, inHigh, inLow, inClose, inVolume, out outBegIdx, out outNBElement, outReal);
        }

        public static RetCode Add(int startIdx, int endIdx, double[] inReal0, double[] inReal1, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Add(startIdx, endIdx, inReal0, inReal1, out outBegIdx, out outNBElement, outReal);
        }

        public static int AddLookback()
        {
            return Core.AddLookback();
        }
        public static int AdLookback()
        {
            return Core.AdLookback();
        }

        public static RetCode AdOsc(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, double[] inVolume, int optInFastPeriod, int optInSlowPeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.AdOsc(startIdx, endIdx, inHigh, inLow, inClose, inVolume, optInFastPeriod, optInSlowPeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static int AdOscLookback(int optInFastPeriod, int optInSlowPeriod)
        {
            return Core.AdOscLookback(optInFastPeriod, optInSlowPeriod);
        }
        public static RetCode Adx(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Adx(startIdx, endIdx, inHigh, inLow, inClose, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static int AdxLookback(int optInTimePeriod)
        {
            return Core.AdxLookback(optInTimePeriod);
        }

        public static RetCode Adxr(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Adxr(startIdx, endIdx, inHigh, inLow, inClose, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int AdxrLookback(int optInTimePeriod)
        {
            return Core.AdxrLookback(optInTimePeriod);
        }

        public static RetCode Apo(int startIdx, int endIdx, double[] inReal, int optInFastPeriod, int optInSlowPeriod, MAType optInMAType, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Apo(startIdx, endIdx, inReal, optInFastPeriod, optInSlowPeriod, optInMAType, out outBegIdx, out outNBElement, outReal);
        }
        public static int ApoLookback(int optInFastPeriod, int optInSlowPeriod, MAType optInMAType)
        {
            return Core.ApoLookback(optInFastPeriod, optInSlowPeriod, optInMAType);
        }

        public static RetCode Aroon(int startIdx, int endIdx, double[] inHigh, double[] inLow, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outAroonDown, double[] outAroonUp)
        {
            return Core.Aroon(startIdx, endIdx, inHigh, inLow, optInTimePeriod, out outBegIdx, out outNBElement, outAroonDown, outAroonUp);
        }

        public static int AroonLookback(int optInTimePeriod)
        {
            return Core.AroonLookback(optInTimePeriod);
        }

        public static RetCode AroonOsc(int startIdx, int endIdx, double[] inHigh, double[] inLow, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.AroonOsc(startIdx, endIdx, inHigh, inLow, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int AroonOscLookback(int optInTimePeriod)
        {
            return Core.AroonOscLookback(optInTimePeriod);
        }

        public static RetCode Asin(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Asin(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outReal);
        }

        public static int AsinLookback()
        {
            return Core.AsinLookback();
        }
        public static RetCode Atan(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Atan(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outReal);
        }

        public static int AtanLookback()
        {
            return Core.AtanLookback();
        }

        public static RetCode Atr(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Atr(startIdx, endIdx, inHigh, inLow, inClose, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static int AtrLookback(int optInTimePeriod)
        {
            return Core.AtrLookback(optInTimePeriod);
        }

        public static RetCode AvgPrice(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.AvgPrice(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outReal);
        }

        public static int AvgPriceLookback()
        {
            return Core.AvgPriceLookback();
        }

        public static RetCode Bbands(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, double optInNbDevUp, double optInNbDevDn, MAType optInMAType, out int outBegIdx, out int outNBElement, double[] outRealUpperBand, double[] outRealMiddleBand, double[] outRealLowerBand)
        {
            return Core.Bbands(startIdx, endIdx, inReal, optInTimePeriod, optInNbDevUp, optInNbDevDn, optInMAType, out outBegIdx, out outNBElement, outRealUpperBand, outRealMiddleBand, outRealLowerBand);
        }

        public static int BbandsLookback(int optInTimePeriod, double optInNbDevUp, double optInNbDevDn, MAType optInMAType)
        {
            return Core.BbandsLookback(optInTimePeriod, optInNbDevUp, optInNbDevDn, optInMAType);
        }

        public static RetCode Beta(int startIdx, int endIdx, double[] inReal0, double[] inReal1, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Beta(startIdx, endIdx, inReal0, inReal1, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static int BetaLookback(int optInTimePeriod)
        {
            return Core.BetaLookback(optInTimePeriod);
        }

        public static RetCode Bop(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Bop(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outReal);
        }
        public static int BopLookback()
        {
            return Core.BopLookback();
        }

        public static RetCode Cci(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Cci(startIdx, endIdx, inHigh, inLow, inClose, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int CciLookback(int optInTimePeriod)
        {
            return Core.CciLookback(optInTimePeriod);
        }

        public static RetCode Cdl2Crows(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.Cdl2Crows(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int Cdl2CrowsLookback()
        {
            return Core.Cdl2CrowsLookback();
        }

        public static RetCode Cdl3BlackCrows(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.Cdl3BlackCrows(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int Cdl3BlackCrowsLookback()
        {
            return Core.Cdl3BlackCrowsLookback();
        }
        public static RetCode Cdl3Inside(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.Cdl3Inside(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int Cdl3InsideLookback()
        {
            return Core.Cdl3InsideLookback();
        }
        public static RetCode Cdl3LineStrike(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.Cdl3LineStrike(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int Cdl3LineStrikeLookback()
        {
            return Core.Cdl3LineStrikeLookback();
        }
        public static RetCode Cdl3Outside(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.Cdl3Outside(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int Cdl3OutsideLookback()
        {
            return Core.Cdl3OutsideLookback();
        }
        public static RetCode Cdl3StarsInSouth(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.Cdl3StarsInSouth(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int Cdl3StarsInSouthLookback()
        {
            return Core.Cdl3StarsInSouthLookback();
        }
        public static RetCode Cdl3WhiteSoldiers(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.Cdl3WhiteSoldiers(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int Cdl3WhiteSoldiersLookback()
        {
            return Core.Cdl3WhiteSoldiersLookback();
        }
        public static RetCode CdlAbandonedBaby(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, double optInPenetration, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlAbandonedBaby(startIdx, endIdx, inOpen, inHigh, inLow, inClose, optInPenetration, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlAbandonedBabyLookback(double optInPenetration)
        {
            return Core.CdlAbandonedBabyLookback(optInPenetration);
        }
        public static RetCode CdlAdvanceBlock(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlAdvanceBlock(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlAdvanceBlockLookback()
        {
            return Core.CdlAdvanceBlockLookback();
        }
        public static RetCode CdlBeltHold(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlBeltHold(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlBeltHoldLookback()
        {
            return Core.CdlBeltHoldLookback();
        }

        public static RetCode CdlBreakaway(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlBreakaway(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlBreakawayLookback()
        {
            return Core.CdlBreakawayLookback();
        }
        public static RetCode CdlClosingMarubozu(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlClosingMarubozu(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlClosingMarubozuLookback()
        {
            return Core.CdlClosingMarubozuLookback();
        }
        public static RetCode CdlConcealBabysWall(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlConcealBabysWall(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlConcealBabysWallLookback()
        {
            return Core.CdlConcealBabysWallLookback();
        }

        public static RetCode CdlCounterAttack(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlCounterAttack(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlCounterAttackLookback()
        {
            return Core.CdlCounterAttackLookback();
        }

        public static RetCode CdlDarkCloudCover(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, double optInPenetration, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlDarkCloudCover(startIdx, endIdx, inOpen, inHigh, inLow, inClose, optInPenetration, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlDarkCloudCoverLookback(double optInPenetration)
        {
            return Core.CdlDarkCloudCoverLookback(optInPenetration);
        }

        public static RetCode CdlDoji(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlDoji(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlDojiLookback()
        {
            return Core.CdlDojiLookback();
        }
        public static RetCode CdlDojiStar(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlDojiStar(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlDojiStarLookback()
        {
            return Core.CdlDojiStarLookback();
        }
        public static RetCode CdlDragonflyDoji(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlDragonflyDoji(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlDragonflyDojiLookback()
        {
            return Core.CdlDragonflyDojiLookback();
        }

        public static RetCode CdlEngulfing(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlEngulfing(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlEngulfingLookback()
        {
            return Core.CdlEngulfingLookback();
        }
        public static RetCode CdlEveningDojiStar(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, double optInPenetration, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlEveningDojiStar(startIdx, endIdx, inOpen, inHigh, inLow, inClose, optInPenetration, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlEveningDojiStarLookback(double optInPenetration)
        {
            return Core.CdlEveningDojiStarLookback(optInPenetration);
        }
        public static RetCode CdlEveningStar(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, double optInPenetration, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlEveningStar(startIdx, endIdx, inOpen, inHigh, inLow, inClose, optInPenetration, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlEveningStarLookback(double optInPenetration)
        {
            return Core.CdlEveningStarLookback(optInPenetration);
        }

        public static RetCode CdlGapSideSideWhite(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlGapSideSideWhite(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlGapSideSideWhiteLookback()
        {
            return Core.CdlGapSideSideWhiteLookback();
        }
        public static RetCode CdlGravestoneDoji(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlGravestoneDoji(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlGravestoneDojiLookback()
        {
            return Core.CdlGravestoneDojiLookback();
        }
        public static RetCode CdlHammer(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlHammer(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlHammerLookback()
        {
            return Core.CdlHammerLookback();
        }
        public static RetCode CdlHangingMan(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlHangingMan(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlHangingManLookback()
        {
            return Core.CdlHangingManLookback();
        }

        public static RetCode CdlHarami(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlHarami(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static RetCode CdlHaramiCross(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlHaramiCross(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlHaramiCrossLookback()
        {
            return Core.CdlHaramiCrossLookback();
        }
        public static int CdlHaramiLookback()
        {
            return Core.CdlHaramiLookback();
        }
        public static RetCode CdlHignWave(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlHignWave(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlHignWaveLookback()
        {
            return Core.CdlHignWaveLookback();
        }

        public static RetCode CdlHikkake(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlHikkake(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlHikkakeLookback()
        {
            return Core.CdlHikkakeLookback();
        }

        public static RetCode CdlHikkakeMod(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlHikkakeMod(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlHikkakeModLookback()
        {
            return Core.CdlHikkakeModLookback();
        }

        public static RetCode CdlHomingPigeon(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlHomingPigeon(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlHomingPigeonLookback()
        {
            return CdlHomingPigeonLookback();
        }
        public static RetCode CdlIdentical3Crows(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlIdentical3Crows(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlIdentical3CrowsLookback()
        {
            return Core.CdlIdentical3CrowsLookback();
        }
        public static RetCode CdlInNeck(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlInNeck(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlInNeckLookback()
        {
            return Core.CdlInNeckLookback();
        }

        public static RetCode CdlInvertedHammer(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlInvertedHammer(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlInvertedHammerLookback()
        {
            return Core.CdlInvertedHammerLookback();
        }

        public static RetCode CdlKicking(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlKicking(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static RetCode CdlKickingByLength(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlKickingByLength(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlKickingByLengthLookback()
        {
            return Core.CdlKickingByLengthLookback();
        }
        public static int CdlKickingLookback()
        {
            return Core.CdlKickingLookback(); 
        }
        public static RetCode CdlLadderBottom(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlLadderBottom(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlLadderBottomLookback()
        {
            return Core.CdlLadderBottomLookback();
        }
        public static RetCode CdlLongLeggedDoji(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlLongLeggedDoji(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlLongLeggedDojiLookback()
        {
            return Core.CdlLongLeggedDojiLookback();
        }

        public static RetCode CdlLongLine(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlLongLine(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlLongLineLookback()
        {
            return Core.CdlLongLineLookback();
        }

        public static RetCode CdlMarubozu(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlMarubozu(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlMarubozuLookback()
        {
            return Core.CdlMarubozuLookback();
        }

        public static RetCode CdlMatchingLow(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlMatchingLow(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlMatchingLowLookback()
        {
            return Core.CdlMatchingLowLookback();
        }

        public static RetCode CdlMatHold(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, double optInPenetration, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlMatHold(startIdx, endIdx, inOpen, inHigh, inLow, inClose, optInPenetration, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlMatHoldLookback(double optInPenetration)
        {
            return Core.CdlMatHoldLookback(optInPenetration);
        }

        public static RetCode CdlMorningDojiStar(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, double optInPenetration, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlMorningDojiStar(startIdx, endIdx, inOpen, inHigh, inLow, inClose, optInPenetration, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlMorningDojiStarLookback(double optInPenetration)
        {
            return Core.CdlMorningDojiStarLookback(optInPenetration);
        }
        public static RetCode CdlMorningStar(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, double optInPenetration, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlMorningStar(startIdx, endIdx, inOpen, inHigh, inLow, inClose, optInPenetration, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlMorningStarLookback(double optInPenetration)
        {
            return Core.CdlMorningStarLookback(optInPenetration);
        }
        public static RetCode CdlOnNeck(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlOnNeck(startIdx, endIdx, inOpen, inHigh,  inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlOnNeckLookback()
        {
            return Core.CdlOnNeckLookback();
        }

        public static RetCode CdlPiercing(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlPiercing(startIdx, endIdx, inOpen,  inHigh,  inLow,  inClose, out outBegIdx, out outNBElement,  outInteger);
        }
        public static int CdlPiercingLookback()
        {
            return Core.CdlPiercingLookback();
        }
        public static RetCode CdlRickshawMan(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlRickshawMan(startIdx, endIdx, inOpen,  inHigh,  inLow,  inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlRickshawManLookback()
        {
            return Core.CdlRickshawManLookback();
        }
        public static RetCode CdlRiseFall3Methods(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlRiseFall3Methods(startIdx, endIdx,  inOpen, inHigh,  inLow,  inClose, out outBegIdx, out outNBElement,  outInteger);
        }

        public static int CdlRiseFall3MethodsLookback()
        {
            return Core.CdlRiseFall3MethodsLookback();
        }

        public static RetCode CdlSeperatingLines(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlSeperatingLines(startIdx, endIdx,  inOpen,  inHigh,  inLow,  inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlSeperatingLinesLookback()
        {
            return Core.CdlSeperatingLinesLookback();
        }

        public static RetCode CdlShootingStar(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlShootingStar(startIdx, endIdx,  inOpen,  inHigh,  inLow,  inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlShootingStarLookback()
        {
            return Core.CdlShootingStarLookback();
        }
        public static RetCode CdlShortLine(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlShortLine(startIdx, endIdx, inOpen, inHigh, inLow,  inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlShortLineLookback()
        {
            return Core.CdlShortLineLookback();
        }
        public static RetCode CdlSpinningTop(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlSpinningTop(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlSpinningTopLookback()
        {
            return Core.CdlSpinningTopLookback();
        }

        public static RetCode CdlStalledPattern(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlStalledPattern(startIdx, endIdx, inOpen,  inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }
        public static int CdlStalledPatternLookback()
        {
            return Core.CdlStalledPatternLookback();
        }
        public static RetCode CdlStickSandwhich(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlStickSandwhich(startIdx, endIdx,  inOpen,  inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlStickSandwhichLookback()
        {
            return Core.CdlStickSandwhichLookback();
        }
        public static RetCode CdlTakuri(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlTakuri(startIdx, endIdx,  inOpen,  inHigh,  inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlTakuriLookback()
        {
            return Core.CdlTakuriLookback(); 
        }
        public static RetCode CdlTasukiGap(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlTasukiGap(startIdx, endIdx,  inOpen,  inHigh,  inLow,  inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlTasukiGapLookback()
        {
            return Core.CdlTasukiGapLookback();
        }
        public static RetCode CdlThrusting(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlThrusting(startIdx, endIdx,  inOpen,  inHigh,  inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlThrustingLookback()
        {
            return Core.CdlThrustingLookback();
        }
        public static RetCode CdlTristar(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlTristar(startIdx, endIdx,  inOpen,  inHigh,  inLow,  inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlTristarLookback()
        {
            return Core.CdlTristarLookback();
        }
        public static RetCode CdlUnique3River(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlUnique3River(startIdx, endIdx, inOpen, inHigh,  inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlUnique3RiverLookback()
        {
            return Core.CdlUnique3RiverLookback();
        }
        public static RetCode CdlUpsideGap2Crows(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlUpsideGap2Crows(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlUpsideGap2CrowsLookback()
        {
            return Core.CdlUpsideGap2CrowsLookback();
        }
        public static RetCode CdlXSideGap3Methods(int startIdx, int endIdx, double[] inOpen, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.CdlXSideGap3Methods(startIdx, endIdx, inOpen, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outInteger);
        }

        public static int CdlXSideGap3MethodsLookback()
        {
            return Core.CdlXSideGap3MethodsLookback();
        }

        public static RetCode Ceil(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Ceil(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outReal);
        }
        public static int CeilLookback()
        {
            return Core.CeilLookback();
        }

        public static RetCode Cmo(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Cmo(startIdx, endIdx,  inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int CmoLookback(int optInTimePeriod)
        {
            return Core.CmoLookback(optInTimePeriod);
        }
        public static RetCode Correl(int startIdx, int endIdx, double[] inReal0, double[] inReal1, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Correl(startIdx, endIdx,  inReal0,  inReal1, optInTimePeriod, out outBegIdx, out outNBElement,  outReal);
        }

        public static int CorrelLookback(int optInTimePeriod)
        {
            return Core.CorrelLookback(optInTimePeriod);
        }
        public static RetCode Cos(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Cos(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outReal);
        }

        public static RetCode Cosh(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Cosh(startIdx, endIdx,  inReal, out outBegIdx, out outNBElement, outReal);
        }

        public static int CoshLookback()
        {
            return Core.CoshLookback();
        }
        public static int CosLookback()
        {
            return Core.CosLookback();
        }

        public static RetCode Dema(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Dema(startIdx, endIdx,  inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int DemaLookback(int optInTimePeriod)
        {
            return Core.DemaLookback(optInTimePeriod);
        }

        public static RetCode Div(int startIdx, int endIdx, double[] inReal0, double[] inReal1, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Div(startIdx, endIdx,  inReal0,  inReal1, out outBegIdx, out outNBElement, outReal);
        }
        public static int DivLookback()
        {
            return Core.DivLookback();
        }
        public static RetCode Dx(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Dx(startIdx, endIdx,  inHigh, inLow,  inClose, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static int DxLookback(int optInTimePeriod)
        {
            return Core.DxLookback(optInTimePeriod);
        }

        public static RetCode Ema(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Ema(startIdx, endIdx,  inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int EmaLookback(int optInTimePeriod)
        {
            return Core.EmaLookback(optInTimePeriod);
        }
        public static RetCode Exp(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Exp(startIdx, endIdx,  inReal, out outBegIdx, out outNBElement, outReal);
        }

        public static int ExpLookback()
        {
            return Core.ExpLookback();
        }
        public static RetCode Floor(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Floor(startIdx, endIdx,  inReal, out outBegIdx, out outNBElement,  outReal);
        }

        public static int FloorLookback()
        {
            return Core.FloorLookback();
        }
        public static Compatibility GetCompatibility()
        {
            return Core.GetCompatibility();
        }
        public static uint GetUnstablePeriod(FuncUnstId id)
        {
            return Core.GetUnstablePeriod(id);
        }

        public static RetCode HtDcPeriod(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.HtDcPeriod(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outReal);
        }
        public static int HtDcPeriodLookback()
        {
            return Core.HtDcPeriodLookback();
        }

        public static RetCode HtDcPhase(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.HtDcPhase(startIdx, endIdx,  inReal, out outBegIdx, out outNBElement, outReal);
        }
        public static int HtDcPhaseLookback()
        {
            return Core.HtDcPhaseLookback();
        }

        public static RetCode HtPhasor(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outInPhase, double[] outQuadrature)
        {
            return Core.HtPhasor(startIdx, endIdx,  inReal, out outBegIdx, out outNBElement, outInPhase, outQuadrature);
        }
        public static int HtPhasorLookback()
        {
            return Core.HtPhasorLookback();
        }

        public static RetCode HtSine(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outSine, double[] outLeadSine)
        {
            return Core.HtSine(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outSine, outLeadSine);
        }
        public static int HtSineLookback()
        {
            return Core.HtSineLookback();
        }
        public static RetCode HtTrendline(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.HtTrendline(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outReal);
        }

        public static int HtTrendlineLookback()
        {
            return Core.HtTrendlineLookback();
        }
        public static RetCode HtTrendMode(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.HtTrendMode(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outInteger);
        }

        public static int HtTrendModeLookback()
        {
            return Core.HtTrendModeLookback();
        }

        public static RetCode Kama(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Kama(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal); 
        }
        public static int KamaLookback(int optInTimePeriod)
        {
            return Core.KamaLookback(optInTimePeriod);
        }

        public static RetCode LinearReg(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.LinearReg(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static RetCode LinearRegAngle(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.LinearRegAngle(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static int LinearRegAngleLookback(int optInTimePeriod)
        {
            return Core.LinearRegAngleLookback(optInTimePeriod);
        }

        public static RetCode LinearRegIntercept(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.LinearRegIntercept(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int LinearRegInterceptLookback(int optInTimePeriod)
        {
            return Core.LinearRegInterceptLookback(optInTimePeriod);
        }
        public static int LinearRegLookback(int optInTimePeriod)
        {
            return Core.LinearRegLookback(optInTimePeriod);
        }

        public static RetCode LinearRegSlope(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.LinearRegSlope(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int LinearRegSlopeLookback(int optInTimePeriod)
        {
            return Core.LinearRegSlopeLookback(optInTimePeriod);
        }

        public static RetCode Ln(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Ln(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outReal);
        }
        public static int LnLookback()
        {
            return Core.LnLookback();
        }
        public static RetCode Log10(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Log10(startIdx, endIdx,  inReal, out outBegIdx, out outNBElement, outReal);
        }

        public static int Log10Lookback()
        {
            return Core.Log10Lookback();
        }

        public static RetCode Macd(int startIdx, int endIdx, double[] inReal, int optInFastPeriod, int optInSlowPeriod, int optInSignalPeriod, out int outBegIdx, out int outNBElement, double[] outMACD, double[] outMACDSignal, double[] outMACDHist)
        {
            return Core.Macd(startIdx, endIdx, inReal, optInFastPeriod, optInSlowPeriod, optInSignalPeriod, out outBegIdx, out outNBElement, outMACD, outMACDSignal, outMACDHist);
        }

        public static RetCode MacdExt(int startIdx, int endIdx, double[] inReal, int optInFastPeriod, MAType optInFastMAType, int optInSlowPeriod, MAType optInSlowMAType, int optInSignalPeriod, MAType optInSignalMAType, out int outBegIdx, out int outNBElement, double[] outMACD, double[] outMACDSignal, double[] outMACDHist)
        {
            return Core.MacdExt(startIdx, endIdx, inReal, optInFastPeriod, optInFastMAType, optInSlowPeriod, optInSlowMAType, optInSignalPeriod, optInSignalMAType, out outBegIdx, out outNBElement, outMACD, outMACDSignal, outMACDHist);
        }

        public static int MacdExtLookback(int optInFastPeriod, MAType optInFastMAType, int optInSlowPeriod, MAType optInSlowMAType, int optInSignalPeriod, MAType optInSignalMAType)
        {
            return Core.MacdExtLookback(optInFastPeriod, optInFastMAType, optInSlowPeriod, optInSlowMAType, optInSignalPeriod, optInSignalMAType);
        }

        public static RetCode MacdFix(int startIdx, int endIdx, double[] inReal, int optInSignalPeriod, out int outBegIdx, out int outNBElement, double[] outMACD, double[] outMACDSignal, double[] outMACDHist)
        {
            return Core.MacdFix(startIdx, endIdx,  inReal, optInSignalPeriod, out outBegIdx, out outNBElement, outMACD,  outMACDSignal, outMACDHist);
        }
        public static int MacdFixLookback(int optInSignalPeriod)
        {
            return Core.MacdFixLookback(optInSignalPeriod);
        }
        public static int MacdLookback(int optInFastPeriod, int optInSlowPeriod, int optInSignalPeriod)
        {
            return Core.MacdLookback(optInFastPeriod, optInSlowPeriod, optInSignalPeriod);
        }

        public static RetCode Mama(int startIdx, int endIdx, double[] inReal, double optInFastLimit, double optInSlowLimit, out int outBegIdx, out int outNBElement, double[] outMAMA, double[] outFAMA)
        {
            return Core.Mama(startIdx, endIdx,  inReal, optInFastLimit, optInSlowLimit, out outBegIdx, out outNBElement, outMAMA, outFAMA);
        }
        public static int MamaLookback(double optInFastLimit, double optInSlowLimit)
        {
            return Core.MamaLookback(optInFastLimit, optInSlowLimit);
        }
        public static RetCode Max(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Max(startIdx, endIdx,  inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static RetCode MaxIndex(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.MaxIndex(startIdx, endIdx,  inReal, optInTimePeriod, out outBegIdx, out outNBElement, outInteger);
        }

        public static int MaxIndexLookback(int optInTimePeriod)
        {
            return Core.MaxIndexLookback(optInTimePeriod);
        }
        public static int MaxLookback(int optInTimePeriod)
        {
            return Core.MaxLookback(optInTimePeriod);
        }

        public static RetCode MedPrice(int startIdx, int endIdx, double[] inHigh, double[] inLow, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.MedPrice(startIdx, endIdx, inHigh, inLow, out outBegIdx, out outNBElement, outReal);
        }
        public static int MedPriceLookback()
        {
            return Core.MedPriceLookback();
        }
        public static RetCode Mfi(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, double[] inVolume, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Mfi(startIdx, endIdx, inHigh, inLow, inClose, inVolume, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static int MfiLookback(int optInTimePeriod)
        {
            return Core.MfiLookback(optInTimePeriod);
        }

        public static RetCode MidPoint(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.MidPoint(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int MidPointLookback(int optInTimePeriod)
        {
            return Core.MidPointLookback(optInTimePeriod);
        }

        public static RetCode MidPrice(int startIdx, int endIdx, double[] inHigh, double[] inLow, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.MidPrice(startIdx, endIdx, inHigh, inLow, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int MidPriceLookback(int optInTimePeriod)
        {
            return Core.MidPriceLookback(optInTimePeriod);
        }
        public static RetCode Min(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Min(startIdx, endIdx,  inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static RetCode MinIndex(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, int[] outInteger)
        {
            return Core.MinIndex(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outInteger);
        }

        public static int MinIndexLookback(int optInTimePeriod)
        {
            return Core.MinIndexLookback(optInTimePeriod);
        }
        public static int MinLookback(int optInTimePeriod)
        {
            return Core.MinLookback(optInTimePeriod);
        }
        public static RetCode MinMax(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outMin, double[] outMax)
        {
            return Core.MinMax(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outMin, outMax);
        }

        public static RetCode MinMaxIndex(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, int[] outMinIdx, int[] outMaxIdx)
        {
            return Core.MinMaxIndex(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outMinIdx, outMaxIdx);
        }

        public static int MinMaxIndexLookback(int optInTimePeriod)
        {
            return Core.MinMaxIndexLookback(optInTimePeriod);
        }
        public static int MinMaxLookback(int optInTimePeriod)
        {
            return Core.MinMaxLookback(optInTimePeriod);
        }
        public static RetCode MinusDI(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.MinusDI(startIdx, endIdx, inHigh, inLow, inClose, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static int MinusDILookback(int optInTimePeriod)
        {
            return Core.MinusDILookback(optInTimePeriod);
        }
        public static RetCode MinusDM(int startIdx, int endIdx, double[] inHigh, double[] inLow, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.MinusDM(startIdx, endIdx, inHigh, inLow, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static int MinusDMLookback(int optInTimePeriod)
        {
            return Core.MinusDMLookback(optInTimePeriod);
        }
        public static RetCode Mom(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Mom(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static int MomLookback(int optInTimePeriod)
        {
            return Core.MomLookback(optInTimePeriod);
        }
        public static RetCode MovingAverage(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, MAType optInMAType, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.MovingAverage(startIdx, endIdx,  inReal, optInTimePeriod, optInMAType, out outBegIdx, out outNBElement, outReal);
        }

        public static int MovingAverageLookback(int optInTimePeriod, MAType optInMAType)
        {
            return Core.MovingAverageLookback(optInTimePeriod, optInMAType);
        }

        public static RetCode MovingAverageVariablePeriod(int startIdx, int endIdx, double[] inReal, double[] inPeriods, int optInMinPeriod, int optInMaxPeriod, MAType optInMAType, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.MovingAverageVariablePeriod(startIdx, endIdx, inReal, inPeriods, optInMinPeriod, optInMaxPeriod, optInMAType, out outBegIdx, out outNBElement, outReal);
        }
        public static int MovingAverageVariablePeriodLookback(int optInMinPeriod, int optInMaxPeriod, MAType optInMAType)
        {
            return Core.MovingAverageVariablePeriodLookback(optInMinPeriod, optInMaxPeriod, optInMAType);
        }

        public static RetCode Mult(int startIdx, int endIdx, double[] inReal0, double[] inReal1, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Mult(startIdx, endIdx, inReal0, inReal1, out outBegIdx, out outNBElement, outReal);
        }
        public static int MultLookback()
        {
            return Core.MultLookback();
        }

        public static RetCode Natr(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Natr(startIdx, endIdx, inHigh, inLow,  inClose, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int NatrLookback(int optInTimePeriod)
        {
            return Core.NatrLookback(optInTimePeriod);
        }

        public static RetCode Obv(int startIdx, int endIdx, double[] inReal, double[] inVolume, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Obv(startIdx, endIdx,  inReal,  inVolume, out outBegIdx, out outNBElement, outReal);
        }
        public static int ObvLookback()
        {
            return Core.ObvLookback();
        }

        public static RetCode PlusDI(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.PlusDI(startIdx, endIdx, inHigh, inLow, inClose, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int PlusDILookback(int optInTimePeriod)
        {
            return Core.PlusDILookback(optInTimePeriod);
        }
        public static RetCode PlusDM(int startIdx, int endIdx, double[] inHigh, double[] inLow, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.PlusDM(startIdx, endIdx, inHigh, inLow, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static int PlusDMLookback(int optInTimePeriod)
        {
            return Core.PlusDMLookback(optInTimePeriod);
        }

        public static RetCode Ppo(int startIdx, int endIdx, double[] inReal, int optInFastPeriod, int optInSlowPeriod, MAType optInMAType, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Ppo(startIdx, endIdx, inReal, optInFastPeriod, optInSlowPeriod, optInMAType, out outBegIdx, out outNBElement, outReal);
        }
        public static int PpoLookback(int optInFastPeriod, int optInSlowPeriod, MAType optInMAType)
        {
            return Core.PpoLookback(optInFastPeriod, optInSlowPeriod, optInMAType);
        }
        public static RetCode RestoreCandleDefaultSettings(CandleSettingType settingType)
        {
            return Core.RestoreCandleDefaultSettings(settingType);
        }

        public static RetCode Roc(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Roc(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int RocLookback(int optInTimePeriod)
        {
            return Core.RocLookback(optInTimePeriod);
        }
        public static RetCode RocP(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.RocP(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static int RocPLookback(int optInTimePeriod)
        {
            return Core.RocPLookback(optInTimePeriod);
        }

        public static RetCode RocR(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.RocR(startIdx, endIdx,  inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static RetCode RocR100(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.RocR100(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int RocR100Lookback(int optInTimePeriod)
        {
            return Core.RocR100Lookback(optInTimePeriod);
        }
        public static int RocRLookback(int optInTimePeriod)
        {
            return Core.RocRLookback(optInTimePeriod);
        }
        public static RetCode Rsi(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Rsi(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }

        public static int RsiLookback(int optInTimePeriod)
        {
            return Core.RsiLookback(optInTimePeriod);
        }
        public static RetCode Sar(int startIdx, int endIdx, double[] inHigh, double[] inLow, double optInAcceleration, double optInMaximum, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Sar(startIdx, endIdx, inHigh, inLow, optInAcceleration, optInMaximum, out outBegIdx, out outNBElement, outReal);
        }

        public static RetCode SarExt(int startIdx, int endIdx, double[] inHigh, double[] inLow, double optInStartValue, double optInOffsetOnReverse, double optInAccelerationInitLong, double optInAccelerationLong, double optInAccelerationMaxLong, double optInAccelerationInitShort, double optInAccelerationShort, double optInAccelerationMaxShort, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.SarExt(startIdx, endIdx, inHigh, inLow, optInStartValue, optInOffsetOnReverse, optInAccelerationInitLong, optInAccelerationLong, optInAccelerationMaxLong, optInAccelerationInitShort, optInAccelerationShort, optInAccelerationMaxShort, out outBegIdx, out outNBElement, outReal);
        }

        public static int SarExtLookback(double optInStartValue, double optInOffsetOnReverse, double optInAccelerationInitLong, double optInAccelerationLong, double optInAccelerationMaxLong, double optInAccelerationInitShort, double optInAccelerationShort, double optInAccelerationMaxShort)
        {
            return Core.SarExtLookback(optInStartValue, optInOffsetOnReverse, optInAccelerationInitLong, optInAccelerationLong, optInAccelerationMaxLong, optInAccelerationInitShort, optInAccelerationShort, optInAccelerationMaxShort);
        }
        public static int SarLookback(double optInAcceleration, double optInMaximum)
        {
            return Core.SarLookback(optInAcceleration, optInMaximum);
        }
        public static RetCode SetCandleSettings(CandleSettingType settingType, RangeType rangeType, int avgPeriod, double factor)
        {
            return Core.SetCandleSettings(settingType, rangeType, avgPeriod, factor);
        }
        public static RetCode SetCompatibility(Compatibility value)
        {
            return Core.SetCompatibility(value);
        }
        public static RetCode SetUnstablePeriod(FuncUnstId id, uint unstablePeriod)
        {
            return Core.SetUnstablePeriod(id, unstablePeriod);
        }

        public static RetCode Sin(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Sin(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outReal);
        }

        public static RetCode Sinh(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Sinh(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outReal);
        }
        public static int SinhLookback()
        {
            return Core.SinhLookback();
        }
        public static int SinLookback()
        {
            return Core.SinLookback();
        }

        public static RetCode Sma(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Sma(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int SmaLookback(int optInTimePeriod)
        {
            return Core.SmaLookback(optInTimePeriod);
        }

        public static RetCode Sqrt(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Sqrt(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outReal);
        }
        public static int SqrtLookback()
        {
            return Core.SqrtLookback();
        }

        public static RetCode StdDev(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, double optInNbDev, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.StdDev(startIdx, endIdx, inReal, optInTimePeriod, optInNbDev, out outBegIdx, out outNBElement, outReal);
        }
        public static int StdDevLookback(int optInTimePeriod, double optInNbDev)
        {
            return Core.StdDevLookback(optInTimePeriod, optInNbDev);
        }

        public static RetCode Stoch(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInFastK_Period, int optInSlowK_Period, MAType optInSlowK_MAType, int optInSlowD_Period, MAType optInSlowD_MAType, out int outBegIdx, out int outNBElement, double[] outSlowK, double[] outSlowD)
        {
            return Core.Stoch(startIdx, endIdx, inHigh, inLow, inClose, optInFastK_Period, optInSlowK_Period, optInSlowK_MAType, optInSlowD_Period, optInSlowD_MAType, out outBegIdx, out outNBElement, outSlowK, outSlowD);
        }

        public static RetCode StochF(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInFastK_Period, int optInFastD_Period, MAType optInFastD_MAType, out int outBegIdx, out int outNBElement, double[] outFastK, double[] outFastD)
        {
            return Core.StochF(startIdx, endIdx, inHigh, inLow, inClose, optInFastK_Period, optInFastD_Period, optInFastD_MAType, out outBegIdx, out outNBElement, outFastK, outFastD);
        }
        public static int StochFLookback(int optInFastK_Period, int optInFastD_Period, MAType optInFastD_MAType)
        {
            return Core.StochFLookback(optInFastK_Period, optInFastD_Period, optInFastD_MAType);
        }
        public static int StochLookback(int optInFastK_Period, int optInSlowK_Period, MAType optInSlowK_MAType, int optInSlowD_Period, MAType optInSlowD_MAType)
        {
            return Core.StochLookback(optInFastK_Period, optInSlowK_Period, optInSlowK_MAType, optInSlowD_Period, optInSlowD_MAType);
        }

        public static RetCode StochRsi(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, int optInFastK_Period, int optInFastD_Period, MAType optInFastD_MAType, out int outBegIdx, out int outNBElement, double[] outFastK, double[] outFastD)
        {
            return Core.StochRsi(startIdx, endIdx, inReal, optInTimePeriod, optInFastK_Period, optInFastD_Period, optInFastD_MAType, out outBegIdx, out outNBElement, outFastK, outFastD);
        }
        public static int StochRsiLookback(int optInTimePeriod, int optInFastK_Period, int optInFastD_Period, MAType optInFastD_MAType)
        {
            return Core.StochRsiLookback(optInTimePeriod, optInFastK_Period, optInFastD_Period, optInFastD_MAType);
        }
        public static RetCode Sub(int startIdx, int endIdx, double[] inReal0, double[] inReal1, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Sub(startIdx, endIdx, inReal0, inReal1, out outBegIdx, out outNBElement, outReal);
        }

        public static int SubLookback()
        {
            return Core.SubLookback();
        }

        public static RetCode Sum(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Sum(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal); 
        }
        public static int SumLookback(int optInTimePeriod)
        {
            return Core.SumLookback(optInTimePeriod);
        }

        public static RetCode T3(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, double optInVFactor, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.T3(startIdx, endIdx, inReal, optInTimePeriod, optInVFactor, out outBegIdx, out outNBElement, outReal);
        }
        public static int T3Lookback(int optInTimePeriod, double optInVFactor)
        {
            return Core.T3Lookback(optInTimePeriod, optInVFactor);
        }

        public static RetCode Tan(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Tan(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outReal);
        }

        public static RetCode Tanh(int startIdx, int endIdx, double[] inReal, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Tanh(startIdx, endIdx, inReal, out outBegIdx, out outNBElement, outReal);
        }
        public static int TanhLookback()
        {
            return Core.TanhLookback();
        }
        public static int TanLookback()
        {
            return Core.TanLookback();
        }

        public static RetCode Tema(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Tema(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int TemaLookback(int optInTimePeriod)
        {
            return Core.TemaLookback(optInTimePeriod);
        }

        public static RetCode Trima(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Trima(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int TrimaLookback(int optInTimePeriod)
        {
            return Core.TrimaLookback(optInTimePeriod);
        }

        public static RetCode Trix(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Trix(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int TrixLookback(int optInTimePeriod)
        {
            return Core.TrixLookback(optInTimePeriod);
        }
        public static RetCode TrueRange(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.TrueRange(startIdx, endIdx, inHigh,  inLow, inClose, out outBegIdx, out outNBElement, outReal);
        }

        public static int TrueRangeLookback()
        {
            return Core.TrueRangeLookback();
        }

        public static RetCode Tsf(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Tsf(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int TsfLookback(int optInTimePeriod)
        {
            return Core.TsfLookback(optInTimePeriod);
        }

        public static RetCode TypPrice(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.TypPrice(startIdx, endIdx,  inHigh,  inLow,  inClose, out outBegIdx, out outNBElement,  outReal);
        }
        public static int TypPriceLookback()
        {
            return Core.TypPriceLookback();
        }
        public static RetCode UltOsc(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod1, int optInTimePeriod2, int optInTimePeriod3, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.UltOsc(startIdx, endIdx, inHigh, inLow, inClose, optInTimePeriod1, optInTimePeriod2, optInTimePeriod3, out outBegIdx, out outNBElement, outReal);
        }

        public static int UltOscLookback(int optInTimePeriod1, int optInTimePeriod2, int optInTimePeriod3)
        {
            return Core.UltOscLookback(optInTimePeriod1, optInTimePeriod2, optInTimePeriod3);
        }

        public static RetCode Variance(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, double optInNbDev, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Variance(startIdx, endIdx, inReal, optInTimePeriod, optInNbDev, out outBegIdx, out outNBElement, outReal);
        }
        public static int VarianceLookback(int optInTimePeriod, double optInNbDev)
        {
            return Core.VarianceLookback(optInTimePeriod, optInNbDev);
        }

        public static RetCode WclPrice(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return WclPrice(startIdx, endIdx, inHigh, inLow, inClose, out outBegIdx, out outNBElement, outReal);
        }
        public static int WclPriceLookback()
        {
            return Core.WclPriceLookback();
        }

        public static RetCode WillR(int startIdx, int endIdx, double[] inHigh, double[] inLow, double[] inClose, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.WillR(startIdx, endIdx, inHigh, inLow, inClose, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int WillRLookback(int optInTimePeriod)
        {
            return Core.WillRLookback(optInTimePeriod);
        }

        public static RetCode Wma(int startIdx, int endIdx, double[] inReal, int optInTimePeriod, out int outBegIdx, out int outNBElement, double[] outReal)
        {
            return Core.Wma(startIdx, endIdx, inReal, optInTimePeriod, out outBegIdx, out outNBElement, outReal);
        }
        public static int WmaLookback(int optInTimePeriod)
        {
            return Core.WmaLookback(optInTimePeriod);
        }
    }
}
