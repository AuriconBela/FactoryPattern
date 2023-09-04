using SampleApp.Model;

namespace SampleApp.UI;

public static class ViewFactory
{
    public static GepeszetView? CreateView(IGepeszetElem? gepeszetElem)
    {
        if (gepeszetElem == null) { return null; }

        return gepeszetElem switch
        {
            IFutes => new FutesView(gepeszetElem),
            IHutes => new HutesView(gepeszetElem),
            IHasznalatiMelegViz => new HMVView(gepeszetElem),
            _ => null
        };
    }
}
