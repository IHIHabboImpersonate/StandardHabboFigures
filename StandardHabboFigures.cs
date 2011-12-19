using IHI.Server.Habbos.Figure;
using IHI.Server.Habbos.Figure.Parts;

namespace IHI.Server.Plugins.Zak.StandardHabboFigures
{
    [CompatibilityLock(36)]
    public class StandardHabboFigures : Plugin
    {
        public override void Start()
        {
            HabboFigureFactory factory = CoreManager.ServerCore.GetHabboFigureFactory();
             
            factory
                .RegisterModelID(typeof(Body180))
                .RegisterModelID(typeof(Hair145))
                .RegisterModelID(typeof(LongSleeveTShirtMale))
                .RegisterModelID(typeof(PlainTrousers))
                .RegisterModelID(typeof(Trainers));
        }
    }
}