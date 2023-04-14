using Hrdina_a_drak___kombinovani.Bojiste;
using Hrdina_a_drak___kombinovani.Postavy;
using Hrdina_a_drak___kombinovani.Veci;

Mec mec = new Mec(25);

Hrdina hrdina = new Hrdina("Geralt", 100, 5, 5, mec);
Drak drak = new Drak("Alduin", 150, 10, 5);

Arena arena = new Arena(hrdina, drak);
arena.Boj();
arena.VypisViteze();

