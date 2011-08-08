using System;
using System.Collections.Generic;
using IHI.Server.Habbos.Figure;
using IHI.Server.Habbos.Figure.Parts;

namespace IHI.Server.Plugins.Zak.StandardHabboFigures
{
    public class StandardHabboFigures : Plugin
    {
        List<Type> PartTypes;

        public override void Start()
        {
            this.PartTypes = new List<Type>();
            
            this.PartTypes.Add(typeof(AnaglyphGlasses));
            this.PartTypes.Add(typeof(EyePatch));
            this.PartTypes.Add(typeof(FutureStyleGlasses));
            this.PartTypes.Add(typeof(NormalGlasses));
            this.PartTypes.Add(typeof(SmallGlasses));
            this.PartTypes.Add(typeof(SunGlasses));
            this.PartTypes.Add(typeof(Bandanna));
            this.PartTypes.Add(typeof(BigBeard));
            this.PartTypes.Add(typeof(BigMoustache));
            this.PartTypes.Add(typeof(GasMask));
            this.PartTypes.Add(typeof(GreenMouthMask));
            this.PartTypes.Add(typeof(HockeyMask));
            this.PartTypes.Add(typeof(Moustache));
            this.PartTypes.Add(typeof(NoseIten));
            this.PartTypes.Add(typeof(PranksterItem));
            this.PartTypes.Add(typeof(SmallBeard));
            this.PartTypes.Add(typeof(TikkiMask));
            this.PartTypes.Add(typeof(BearHat));
            this.PartTypes.Add(typeof(BlueTurban));
            this.PartTypes.Add(typeof(BunnyHat));
            this.PartTypes.Add(typeof(ChefHat));
            this.PartTypes.Add(typeof(ChristmasHat2));
            this.PartTypes.Add(typeof(CowboyStyleHat));
            this.PartTypes.Add(typeof(FashionHat));
            this.PartTypes.Add(typeof(FruitHat));
            this.PartTypes.Add(typeof(FurryRoundHat));
            this.PartTypes.Add(typeof(GangsterHat));
            this.PartTypes.Add(typeof(HardHat));
            this.PartTypes.Add(typeof(HeadBand));
            this.PartTypes.Add(typeof(Hood));
            this.PartTypes.Add(typeof(NormalCap));
            this.PartTypes.Add(typeof(OldClassicStyleWig));
            this.PartTypes.Add(typeof(OldStyleHat));
            this.PartTypes.Add(typeof(PaperBag));
            this.PartTypes.Add(typeof(PomPomHat));
            this.PartTypes.Add(typeof(RastaHat));
            this.PartTypes.Add(typeof(RoundStyleHat));
            this.PartTypes.Add(typeof(SantaHat));
            this.PartTypes.Add(typeof(SkIMask));
            this.PartTypes.Add(typeof(SunHat));
            this.PartTypes.Add(typeof(UrbanHat));
            this.PartTypes.Add(typeof(WrappedHat));
            this.PartTypes.Add(typeof(BowTieHairStyle));
            this.PartTypes.Add(typeof(ButterFly));
            this.PartTypes.Add(typeof(DiamondEarings));
            this.PartTypes.Add(typeof(Earphone));
            this.PartTypes.Add(typeof(Feather));
            this.PartTypes.Add(typeof(Flower));
            this.PartTypes.Add(typeof(HeadSet));
            this.PartTypes.Add(typeof(Horns));
            this.PartTypes.Add(typeof(Star));
            this.PartTypes.Add(typeof(Tiara));
            this.PartTypes.Add(typeof(FashionSkirt_Female));
            this.PartTypes.Add(typeof(LongSkirtWithStripes_Female));
            this.PartTypes.Add(typeof(LongSkirt_Female));
            this.PartTypes.Add(typeof(MiniSkirt_Female));
            this.PartTypes.Add(typeof(PlainShorts));
            this.PartTypes.Add(typeof(PlainTrousers));
            this.PartTypes.Add(typeof(SportsShorts));
            this.PartTypes.Add(typeof(TrackSuitBottoms));
            this.PartTypes.Add(typeof(TrousersWithPockets));
            this.PartTypes.Add(typeof(ArabicStyleTShirtLongSleeve_Female));
            this.PartTypes.Add(typeof(ArabicStyleTShirtShortSleeve_Female));
            this.PartTypes.Add(typeof(BasketballVest_Female));
            this.PartTypes.Add(typeof(BasketBallVest_Male));
            this.PartTypes.Add(typeof(BraVestNoSleeve_Female));
            this.PartTypes.Add(typeof(BraVest_Female));
            this.PartTypes.Add(typeof(CardiganWithStripedTShirtLongSleeve_Female));
            this.PartTypes.Add(typeof(CardiganWithStripedTShirtShortSleeve_Female));
            this.PartTypes.Add(typeof(DesignerDress_Female));
            this.PartTypes.Add(typeof(DesignerVest_Female));
            this.PartTypes.Add(typeof(DotAndLaceShirtLongSleeve_Female));
            this.PartTypes.Add(typeof(DotsAndLaceShirtShortSleeve_Female));
            this.PartTypes.Add(typeof(FurryBra_Female));
            this.PartTypes.Add(typeof(HoddyTop_Male));
            this.PartTypes.Add(typeof(JacketAndCheckTShirtLongSleeve_Male));
            this.PartTypes.Add(typeof(JacketAndCheckTShirtShortSleeve_Male));
            this.PartTypes.Add(typeof(LeatherBraJacketLongSleeve_Female));
            this.PartTypes.Add(typeof(LeatherBraJacketShortSleeve_Female));
            this.PartTypes.Add(typeof(LeatherJacket_Female));
            this.PartTypes.Add(typeof(LeatherJacket_Male));
            this.PartTypes.Add(typeof(LongCoatWithButtons_Female));
            this.PartTypes.Add(typeof(LongSleeveBigBreastHeartTShirt_Female));
            this.PartTypes.Add(typeof(LongSleeveButtonAndLaceStyleCoat_Female));
            this.PartTypes.Add(typeof(LongSleeveButtonTShirt_Female));
            this.PartTypes.Add(typeof(LongSleeveFlameTShirt_Male));
            this.PartTypes.Add(typeof(LongSleevePatternTShirt_Female));
            this.PartTypes.Add(typeof(LongSleevePlainTShirt_Male));
            this.PartTypes.Add(typeof(LongSleevePocketTShirt_Male));
            this.PartTypes.Add(typeof(LongSleeveStarTShirt_Male));
            this.PartTypes.Add(typeof(LongSleeveStripedTShirt_Male));
            this.PartTypes.Add(typeof(LongSleeveTShirt_Female));
            this.PartTypes.Add(typeof(LongSleeveTShirt_Male));
            this.PartTypes.Add(typeof(NormalSuit_Male));
            this.PartTypes.Add(typeof(RefreeTShirt_Female));
            this.PartTypes.Add(typeof(RefreeTShirt_Male));
            this.PartTypes.Add(typeof(ShortSleeveBigBreastHeartTShirt_Female));
            this.PartTypes.Add(typeof(ShortSleeveBiggerBreastTShirt_Female));
            this.PartTypes.Add(typeof(ShortSleeveButtonAndLaceCoat_Female));
            this.PartTypes.Add(typeof(ShortSleeveButtonTShirt_Female));
            this.PartTypes.Add(typeof(ShortSleevedCollarTShirt_Male));
            this.PartTypes.Add(typeof(ShortSleeveFlameTShirt_Male));
            this.PartTypes.Add(typeof(ShortSleeveLaceShirt_Male));
            this.PartTypes.Add(typeof(ShortSleevePatternShirt_Female));
            this.PartTypes.Add(typeof(ShortSleevePlainTShirt_Male));
            this.PartTypes.Add(typeof(ShortSleevePocketTShirt_Male));
            this.PartTypes.Add(typeof(ShortSleeveShirt_Male));
            this.PartTypes.Add(typeof(ShortSleeveSmallBreastStripedTShirt_Female));
            this.PartTypes.Add(typeof(ShortSleeveStarTShirt_Male));
            this.PartTypes.Add(typeof(ShortSleeveStripedTShirt_Male));
            this.PartTypes.Add(typeof(ShortSleeveTShirt_Female));
            this.PartTypes.Add(typeof(SportsTShirt_Female));
            this.PartTypes.Add(typeof(SportsTShirt_Male));
            this.PartTypes.Add(typeof(StripedVestNoSleeves_Female));
            this.PartTypes.Add(typeof(StripedVestNoSleeve_Male));
            this.PartTypes.Add(typeof(TShirtNoSleeveBigBreast_Female));
            this.PartTypes.Add(typeof(VestWithBow_Female));
            this.PartTypes.Add(typeof(WaistCoatWithLongSleeveAndTie_Male));
            this.PartTypes.Add(typeof(WaistCoatWithShortSleeveAndTie_Male));
            this.PartTypes.Add(typeof(WannaBeGangsterJacket_Male));
            this.PartTypes.Add(typeof(AwardBadge));
            this.PartTypes.Add(typeof(BowTie));
            this.PartTypes.Add(typeof(ChainNecklace));
            this.PartTypes.Add(typeof(DesignerNecklace));
            this.PartTypes.Add(typeof(DesignerPurpleNecklace));
            this.PartTypes.Add(typeof(DiamondNecklace));
            this.PartTypes.Add(typeof(DollarChains));
            this.PartTypes.Add(typeof(ExpensiveNecklace));
            this.PartTypes.Add(typeof(FlowerBadge));
            this.PartTypes.Add(typeof(FuzzyScarf));
            this.PartTypes.Add(typeof(KeyNecklace));
            this.PartTypes.Add(typeof(NormalChain));
            this.PartTypes.Add(typeof(NormalScarf));
            this.PartTypes.Add(typeof(PeaceNecklace));
            this.PartTypes.Add(typeof(PearlNecklace));
            this.PartTypes.Add(typeof(StarBadge));
            this.PartTypes.Add(typeof(Stehoscope));
            this.PartTypes.Add(typeof(StripedTie));
            this.PartTypes.Add(typeof(TiedScarf));
            this.PartTypes.Add(typeof(BigTrainers));
            this.PartTypes.Add(typeof(BlockLegoShoes));
            this.PartTypes.Add(typeof(BunnyFlippers));
            this.PartTypes.Add(typeof(Flippers));
            this.PartTypes.Add(typeof(HighHeels));
            this.PartTypes.Add(typeof(Slippers));
            this.PartTypes.Add(typeof(SmartShoes));
            this.PartTypes.Add(typeof(Trainers));
            this.PartTypes.Add(typeof(BlackDesignerBelt));
            this.PartTypes.Add(typeof(DesignerBuckleBelt));
            this.PartTypes.Add(typeof(DesignerStyleBelt));
            this.PartTypes.Add(typeof(ExpensiveBelt));
            this.PartTypes.Add(typeof(HBuckleBelt));
            this.PartTypes.Add(typeof(KarateStylebelt));
            this.PartTypes.Add(typeof(NormalBelt));
            this.PartTypes.Add(typeof(NormalBuckleBelt));
            this.PartTypes.Add(typeof(SkullBelt));
            this.PartTypes.Add(typeof(SpikeBelt));
            this.PartTypes.Add(typeof(StarBelt));
            this.PartTypes.Add(typeof(WhiteDesignerBelt));
            
            HabboFigureFactory Factory = CoreManager.GetCore().GetHabboFigureFactory();
            foreach (Type PartType in this.PartTypes)
            {
                Factory.RegisterModelID(PartType);
            }
        }

        public override void Stop()
        {
            HabboFigureFactory Factory = CoreManager.GetCore().GetHabboFigureFactory();
            foreach (Type PartType in this.PartTypes)
            {
                Factory.UnregisterModelID(PartType);
            }
        }
    }
}
