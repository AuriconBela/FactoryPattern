using SampleApp.Model;
using System.Collections.Immutable;

namespace SampleApp.Persistence;

public interface IRepository
{
    Task<bool> LoadFromFile();
    IImmutableList<IGepeszetElem> Elemek { get; }
}
