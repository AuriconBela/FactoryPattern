using SampleApp.Persistence.Factory;
using SampleApp.UI;

namespace SampleApp.Model;

public enum ClassType
{
    [ViewAttribute(typeof(FutesView))]
    Futes,
    [ViewAttribute(typeof(HutesView))]
    Hutes,
    [ViewAttribute(typeof(HMVView))]
    HasznalatiMelegViz,
    [ViewAttribute(typeof(SzellozesView))]
    Szellozes,
    [ViewAttribute(typeof(VilagitasView))]
    Vilagitas,
    [ViewAttribute(typeof(NapelemView))]
    Napelem,
    [ViewAttribute(typeof(NapkollektorView))]
    NapKollektor,
    [ViewAttribute(typeof(EgyebMegujuloView))]
    EgyebMegujulo
}
