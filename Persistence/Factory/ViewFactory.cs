//#define SwitchMethod

using SampleApp.Misc;
using SampleApp.Model;
using SampleApp.UI;

namespace SampleApp.Persistence.Factory;

public static class ViewFactory
{
    public static GepeszetView? CreateView(IGepeszetElem? gepeszetElem)
    {
        if (gepeszetElem == null) { return null; }
#if SwitchMethod
        return gepeszetElem switch
        {
            IFutes => new FutesView(gepeszetElem),
            IHutes => new HutesView(gepeszetElem),
            IHasznalatiMelegViz => new HMVView(gepeszetElem),
            ISzellozes => new SzellozesView(gepeszetElem),
            IVilagitas => new VilagitasView(gepeszetElem),
            INapelem => new NapelemView(gepeszetElem),
            INapKollektor => new NapkollektorView(gepeszetElem),
            IEgyebMegujulo => new EgyebMegujuloView(gepeszetElem),
            _ => null
        };
#else
        #region Aktivátor
        var viewAttribute = gepeszetElem.ClassType!.GetAttribute<ViewAttributeAttribute>();
        if (viewAttribute == null)
        {
            return null;
        }

        var type = viewAttribute.Type;

        return Activator.CreateInstance(type, gepeszetElem) as GepeszetView;
        #endregion
#endif
    }
}
