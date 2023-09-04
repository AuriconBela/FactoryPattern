using Newtonsoft.Json;
using SampleApp.Persistence;
using System.Collections.Immutable;

namespace SampleApp.Model;

public class Gepeszet
{
    private readonly List<IGepeszetElem> _elemek = new();

    public async Task<bool> LoadFromFile(string fileName)
    {
        try
        {
            var fileContent = await File.ReadAllTextAsync(fileName);
           
            var data = JsonConvert.DeserializeObject<List<GepeszetElem>>(fileContent, new GepeszetConverter());

            if (data == null) { return false; }

            _elemek.AddRange(data);
            return true;
        }
        catch (Exception)
        {
			return false;
			throw;
		}
    }

    public IImmutableList<IGepeszetElem> Elemek => _elemek.ToImmutableList();

    //public async Task<bool> SaveToFile(string fileName)
    //{
    //    try
    //    {
    //        var data = JsonConvert.SerializeObject(_elemek, Formatting.Indented);

    //        if (data == null) { return false; }

    //        await File.WriteAllTextAsync(fileName, data);
    //        return true;
    //    }
    //    catch (Exception)
    //    {
    //        return false;
    //        throw;
    //    }
    //}

    //public async Task CreateSampleDataAsync(string fileName)
    //{
    //    var futes = new Futes()
    //    {
    //        Name = "Fűtés",
    //        Description = "A fűtési rendszer",
    //        Image = Image.FromFile("c:\\Munka\\KnowHowSharing\\DesignPatterns\\Factory\\SampleApp\\Assets\\1.jfif")
    //    };

    //    _elemek.Add(futes);

    //    var hutes = new Hutes()
    //    {
    //        Name = "Hűtés",
    //        Description = "A Hűtési rendszer",
    //        Image = Image.FromFile("c:\\Munka\\KnowHowSharing\\DesignPatterns\\Factory\\SampleApp\\Assets\\2.jfif")
    //    };

    //    _elemek.Add(hutes);

    //    var hmv = new HasznalatiMelegViz()
    //    {
    //        Name = "Használati melegvíz",
    //        Description = "A használati melegvíz",
    //        Image = Image.FromFile("c:\\Munka\\KnowHowSharing\\DesignPatterns\\Factory\\SampleApp\\Assets\\3.jfif")
    //    };

    //    _elemek.Add(hmv);

    //    var szell = new Szellozes()
    //    {
    //        Name = "Szellőzési rendszer",
    //        Description = "A szellőzési rendszer",
    //        Image = Image.FromFile("c:\\Munka\\KnowHowSharing\\DesignPatterns\\Factory\\SampleApp\\Assets\\4.jfif")
    //    };

    //    _elemek.Add(szell);

    //    var vil = new Vilagitas()
    //    {
    //        Name = "Világítás",
    //        Description = "A világítás leírása",
    //        Image = Image.FromFile("c:\\Munka\\KnowHowSharing\\DesignPatterns\\Factory\\SampleApp\\Assets\\5.jfif")
    //    };

    //    _elemek.Add(vil);

    //    var ne = new Napelem()
    //    {
    //        Name = "Napelem",
    //        Description = "A napelem leírása",
    //        Image = Image.FromFile("c:\\Munka\\KnowHowSharing\\DesignPatterns\\Factory\\SampleApp\\Assets\\6.jfif")
    //    };

    //    _elemek.Add(ne);

    //    var nk = new NapKollektor()
    //    {
    //        Name = "NapKollektor",
    //        Description = "A napKollektor leírása",
    //        Image = Image.FromFile("c:\\Munka\\KnowHowSharing\\DesignPatterns\\Factory\\SampleApp\\Assets\\7.jfif")
    //    };

    //    _elemek.Add(nk);

    //    var em = new EgyebMegujulo()
    //    {
    //        Name = "Egyéb megújuló",
    //        Description = "Az egyéb megújuló rendszer leírása",
    //        Image = Image.FromFile("c:\\Munka\\KnowHowSharing\\DesignPatterns\\Factory\\SampleApp\\Assets\\8.jfif")
    //    };

    //    _elemek.Add(em);

    //    await SaveToFile(fileName);
    //}
}
