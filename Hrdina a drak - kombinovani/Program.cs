using Hrdina_a_drak___kombinovani.Bojiste;
using Hrdina_a_drak___kombinovani.Nahoda;
using Hrdina_a_drak___kombinovani.ObsluhaUdalosti;
using Hrdina_a_drak___kombinovani.Postavy;
using Hrdina_a_drak___kombinovani.Veci;

Mec mec = new Mec(25);

Hrdina hrdina = new Hrdina("Geralt", 100, 5, 2, mec, Kostka.Instance);
Hrdina hrdina2 = new Hrdina("Superhero", 100, 1, 5, mec, Kostka.Instance);
Drak drak = new Drak("Alduin", 150, 10, 2, Kostka.Instance);
Vlk vlk = new Vlk("Wolfie", 50, 1, 1, Kostka.Instance);


List<Postava> postavy = new List<Postava>()
{
    hrdina,
    hrdina2,
    drak,
    vlk
};

foreach(var pos in postavy)
{
    pos.Zautocil += VypisNaKonzoli.VypisUtoku;
    pos.Zautocil += ZapisDoSouboru.Zapis;
}


double prumernyUtokPostav =
    postavy.Average(postava => postava.MaxUtok);
double polovinaPrumUtoku = prumernyUtokPostav / 2;

Console.WriteLine($"Průměrný maximální útok postav: {prumernyUtokPostav}");

List<Postava> vyfiltrovanySeznamPostav =
    postavy.FindAll(postava => postava.MaxUtok >= polovinaPrumUtoku);

vyfiltrovanySeznamPostav.ForEach(postava => Console.WriteLine($"{postava.Jmeno} má maximální útok: {postava.MaxUtok}"));


Arena arena = new Arena(hrdina, vlk);
arena.Boj();
arena.VypisViteze();

Console.ReadKey();
