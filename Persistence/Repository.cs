using Newtonsoft.Json;
using SampleApp.Model;
using System.Collections.Immutable;

namespace SampleApp.Persistence;

public class Repository : IRepository
{
    private readonly string _fileName;
    private IEnumerable<IGepeszetElem>? _elemek;

    public Repository(string fileName)
    {
        _fileName = fileName;
    }
    public IImmutableList<IGepeszetElem> Elemek => _elemek is not null ? _elemek.ToImmutableList() : Enumerable.Empty<IGepeszetElem>().ToImmutableList();

    public async Task<bool> LoadFromFile()
    {
        try
        {
            var list = new List<IGepeszetElem>();

            var fileContent = await File.ReadAllTextAsync(_fileName);

            var data = JsonConvert.DeserializeObject<List<GepeszetElem>>(fileContent, new GepeszetConverter());

            if (data == null) { return false; }

            for (int i = 0; i < 5; i++)
            {
                list.AddRange(data);
            }
            
            _elemek = list;

            return true;
        }
        catch (Exception)
        {
            return false;
            throw;
        }
    }
}
