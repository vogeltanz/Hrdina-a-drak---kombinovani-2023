using Hrdina_a_drak___kombinovani.Bojiste;
using Hrdina_a_drak___kombinovani.Nahoda;
using Hrdina_a_drak___kombinovani.Postavy;
using Hrdina_a_drak___kombinovani.Veci;

Mec mec = new Mec(25);

Hrdina hrdina = new Hrdina("Geralt", 100, 5, 2, mec, Kostka.Instance);
Hrdina hrdina2 = new Hrdina("Superhero", 100, 5, 5, mec, Kostka.Instance);
Drak drak = new Drak("Alduin", 150, 10, 2, Kostka.Instance);
Vlk vlk = new Vlk("Wolfie", 50, 5, 1, Kostka.Instance);

Arena arena = new Arena(hrdina, vlk);
arena.Boj();
arena.VypisViteze();

