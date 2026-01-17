// Smithing/SmithingResult.cs

using UnityEngine;

public enum SmithingResultType
{
    FAIL,
    SUCCESS,
    GREAT_SUCCESS,
    DESTROY
}

public static class SmithingResult
{
    public struct Result
    {
        public SmithingResultType type;
        public int hammerCount;
        public int levelIncrease;
    }
    
    public static Result Evaluate(float value, int level, bool isDanger, bool isFever, 
                                   GameConfig config, UpgradeManager upgradeManager)
    {
        // TODO: 1. 구간 판정 (피버 시 전체 빨간색)
        // TODO: 2. upgradeManager.GetYellowZoneBonus(), GetRedZoneBonus() 적용
        // TODO: 3. 빨간 영역일 때 대성공/파괴 확률 계산
        //          successChance = config.baseGreatSuccessChance 
        //                        + (isDanger ? config.dangerSuccessBonus : 0)
        //                        + upgradeManager.GetGreatSuccessBonus()
        // TODO: 4. 대성공 시 +2, +3 확률 계산
        //          plusTwoChance = config.basePlusTwoChance + upgradeManager.GetPlusTwoBonus()
        //          plusThreeChance = config.basePlusThreeChance + upgradeManager.GetPlusThreeBonus()
        // TODO: 5. 망치 횟수 결정 (공식 2.5)
        
        return new Result { type = SmithingResultType.FAIL, hammerCount = 3, levelIncrease = 0 };
    }
}