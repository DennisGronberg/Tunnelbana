using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaKata2EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LineContext())
            {
                #region Line 1

                var line1 = new Line { LineName = "J35" };
                    var line1Station1 = new Station { StationName = "Kungsängen" };
                        var line1Station1Exit1 = new Exit { ExitName = "Parkering" };
                            var line1Station1Exit1Barrier1 = new Barrier { BarrierName = "Kungsängen Spärr 1" };
                            var line1Station1Exit1Barrier2 = new Barrier { BarrierName = "Kungsängen Spärr 2" };
                        var line1Station1Exit2 = new Exit { ExitName = "Busshållplats" };
                            var line1Station1Exit2Barrier1 = new Barrier { BarrierName = "Kungsängen Spärr 3" };
                            var line1Station1Exit2Barrier2 = new Barrier { BarrierName = "Kungsängen Spärr 4" };
                    var line1Station2 = new Station { StationName = "Jakobsberg" };
                        var line1Station2Exit1 = new Exit { ExitName = "Torget" };
                            var line1Station2Exit1Barrier1 = new Barrier { BarrierName = "Jakobsberg Spärr 1" };
                            var line1Station2Exit1Barrier2 = new Barrier { BarrierName = "Jakobsberg Spärr 2" };
                        var line1Station2Exit2 = new Exit { ExitName = "Körskolan" };
                            var line1Station2Exit2Barrier1 = new Barrier { BarrierName = "Jakobsberg Spärr 3" };
                            var line1Station2Exit2Barrier2 = new Barrier { BarrierName = "Jakobsberg Spärr 4" };
                    var line1Station3 = new Station { StationName = "Kallhäll" };
                        var line1Station3Exit1 = new Exit { ExitName = "Campus" };
                            var line1Station3Exit1Barrier1 = new Barrier { BarrierName = "Kallhäll Spärr 1" };
                            var line1Station3Exit1Barrier2 = new Barrier { BarrierName = "Kallhäll Spärr 2" };
                        var line1Station3Exit2 = new Exit { ExitName = "Sjukhuset" };
                            var line1Station3Exit2Barrier1 = new Barrier { BarrierName = "Kallhäll Spärr 3" };
                            var line1Station3Exit2Barrier2 = new Barrier { BarrierName = "Kallhäll Spärr 4" };

                line1Station1Exit1.Barriers = new List<Barrier>();
                line1Station1Exit1.Barriers.Add(line1Station1Exit1Barrier1);
                line1Station1Exit1.Barriers.Add(line1Station1Exit1Barrier2);
                line1Station1Exit2.Barriers = new List<Barrier>();
                line1Station1Exit2.Barriers.Add(line1Station1Exit2Barrier1);
                line1Station1Exit2.Barriers.Add(line1Station1Exit2Barrier2);
                line1Station2Exit1.Barriers = new List<Barrier>();
                line1Station2Exit1.Barriers.Add(line1Station2Exit1Barrier1);
                line1Station2Exit1.Barriers.Add(line1Station2Exit1Barrier2);
                line1Station2Exit2.Barriers = new List<Barrier>();
                line1Station2Exit2.Barriers.Add(line1Station2Exit2Barrier1);
                line1Station2Exit2.Barriers.Add(line1Station2Exit2Barrier2);
                line1Station3Exit1.Barriers = new List<Barrier>();
                line1Station3Exit1.Barriers.Add(line1Station3Exit1Barrier1);
                line1Station3Exit1.Barriers.Add(line1Station3Exit1Barrier2);
                line1Station3Exit2.Barriers = new List<Barrier>();
                line1Station3Exit2.Barriers.Add(line1Station3Exit2Barrier1);
                line1Station3Exit2.Barriers.Add(line1Station3Exit2Barrier2);

                line1Station1.Exits = new List<Exit>();
                line1Station1.Exits.Add(line1Station1Exit1);
                line1Station1.Exits.Add(line1Station1Exit2);
                line1Station2.Exits = new List<Exit>();
                line1Station2.Exits.Add(line1Station2Exit1);
                line1Station2.Exits.Add(line1Station2Exit2);
                line1Station3.Exits = new List<Exit>();
                line1Station3.Exits.Add(line1Station3Exit1);
                line1Station3.Exits.Add(line1Station3Exit2);

                line1.Stations = new List<Station>();
                line1.Stations.Add(line1Station1);
                line1.Stations.Add(line1Station2);
                line1.Stations.Add(line1Station3);

                #endregion
                #region Line 2

                var line2 = new Line { LineName = "J36" };
                    var line2Station1 = new Station { StationName = "Märsta" };
                        var line2Station1Exit1 = new Exit { ExitName = "Torggatan" };
                            var line2Station1Exit1Barrier1 = new Barrier { BarrierName = "Märsta Spärr 1" };
                            var line2Station1Exit1Barrier2 = new Barrier { BarrierName = "Märsta Spärr 2" };
                        var line2Station1Exit2 = new Exit { ExitName = "Badplatsen" };
                            var line2Station1Exit2Barrier1 = new Barrier { BarrierName = "Märsta Spärr 3" };
                            var line2Station1Exit2Barrier2 = new Barrier { BarrierName = "Märsta Spärr 4" };
                    var line2Station2 = new Station { StationName = "Solna" };
                        var line2Station2Exit1 = new Exit { ExitName = "Klockan" };
                            var line2Station2Exit1Barrier1 = new Barrier { BarrierName = "Solna Spärr 1" };
                            var line2Station2Exit1Barrier2 = new Barrier { BarrierName = "Solna Spärr 2" };
                        var line2Station2Exit2 = new Exit { ExitName = "Resturanggatan" };
                            var line2Station2Exit2Barrier1 = new Barrier { BarrierName = "Solna Spärr 3" };
                            var line2Station2Exit2Barrier2 = new Barrier { BarrierName = "Solna Spärr 4" };
                    var line2Station3 = new Station { StationName = "Sollentuna" };
                        var line2Station3Exit1 = new Exit { ExitName = "Fotbollsplan" };
                            var line2Station3Exit1Barrier1 = new Barrier { BarrierName = "Sollentuna Spärr 1" };
                            var line2Station3Exit1Barrier2 = new Barrier { BarrierName = "Sollentuna Spärr 2" };
                        var line2Station3Exit2 = new Exit { ExitName = "Villaområtet" };
                            var line2Station3Exit2Barrier1 = new Barrier { BarrierName = "Sollentuna Spärr 3" };
                            var line2Station3Exit2Barrier2 = new Barrier { BarrierName = "Sollentuna Spärr 4" };

                line2Station1Exit1.Barriers = new List<Barrier>();
                line2Station1Exit1.Barriers.Add(line2Station1Exit1Barrier1);
                line2Station1Exit1.Barriers.Add(line2Station1Exit1Barrier2);
                line2Station1Exit2.Barriers = new List<Barrier>();
                line2Station1Exit2.Barriers.Add(line2Station1Exit2Barrier1);
                line2Station1Exit2.Barriers.Add(line2Station1Exit2Barrier2);
                line2Station2Exit1.Barriers = new List<Barrier>();
                line2Station2Exit1.Barriers.Add(line2Station2Exit1Barrier1);
                line2Station2Exit1.Barriers.Add(line2Station2Exit1Barrier2);
                line2Station2Exit2.Barriers = new List<Barrier>();
                line2Station2Exit2.Barriers.Add(line2Station2Exit2Barrier1);
                line2Station2Exit2.Barriers.Add(line2Station2Exit2Barrier2);
                line2Station3Exit1.Barriers = new List<Barrier>();
                line2Station3Exit1.Barriers.Add(line2Station3Exit1Barrier1);
                line2Station3Exit1.Barriers.Add(line2Station3Exit1Barrier2);
                line2Station3Exit2.Barriers = new List<Barrier>();
                line2Station3Exit2.Barriers.Add(line2Station3Exit2Barrier1);
                line2Station3Exit2.Barriers.Add(line2Station3Exit2Barrier2);

                line2Station1.Exits = new List<Exit>();
                line2Station1.Exits.Add(line2Station1Exit1);
                line2Station1.Exits.Add(line2Station1Exit2);
                line2Station2.Exits = new List<Exit>();
                line2Station2.Exits.Add(line2Station2Exit1);
                line2Station2.Exits.Add(line2Station2Exit2);
                line2Station3.Exits = new List<Exit>();
                line2Station3.Exits.Add(line2Station3Exit1);
                line2Station3.Exits.Add(line2Station3Exit2);

                line2.Stations = new List<Station>();
                line2.Stations.Add(line2Station1);
                line2.Stations.Add(line2Station2);
                line2.Stations.Add(line2Station3);

                #endregion
                #region Line 3

                var line3 = new Line { LineName = "J38" };
                var line3Station1 = new Station { StationName = "Älvsjö" };
                var line3Station1Exit1 = new Exit { ExitName = "Parkeringshuset" };
                var line3Station1Exit1Barrier1 = new Barrier { BarrierName = "Älvsjö Spärr 1" };
                var line3Station1Exit1Barrier2 = new Barrier { BarrierName = "Älvsjö Spärr 2" };
                var line3Station1Exit2 = new Exit { ExitName = "Ängen" };
                var line3Station1Exit2Barrier1 = new Barrier { BarrierName = "Älvsjö Spärr 3" };
                var line3Station1Exit2Barrier2 = new Barrier { BarrierName = "Älvsjö Spärr 4" };
                var line3Station2 = new Station { StationName = "Knivsta" };
                var line3Station2Exit1 = new Exit { ExitName = "Hotellet" };
                var line3Station2Exit1Barrier1 = new Barrier { BarrierName = "Knivsta Spärr 1" };
                var line3Station2Exit1Barrier2 = new Barrier { BarrierName = "Knivsta Spärr 2" };
                var line3Station2Exit2 = new Exit { ExitName = "Datahallen" };
                var line3Station2Exit2Barrier1 = new Barrier { BarrierName = "Knivsta Spärr 3" };
                var line3Station2Exit2Barrier2 = new Barrier { BarrierName = "Knivsta Spärr 4" };
                var line3Station3 = new Station { StationName = "Häggvik" };
                var line3Station3Exit1 = new Exit { ExitName = "Flygplaten" };
                var line3Station3Exit1Barrier1 = new Barrier { BarrierName = "Häggvik Spärr 1" };
                var line3Station3Exit1Barrier2 = new Barrier { BarrierName = "Häggvik Spärr 2" };
                var line3Station3Exit2 = new Exit { ExitName = "Coop" };
                var line3Station3Exit2Barrier1 = new Barrier { BarrierName = "Häggvik Spärr 3" };
                var line3Station3Exit2Barrier2 = new Barrier { BarrierName = "Häggvik Spärr 4" };

                line3Station1Exit1.Barriers = new List<Barrier>();
                line3Station1Exit1.Barriers.Add(line3Station1Exit1Barrier1);
                line3Station1Exit1.Barriers.Add(line3Station1Exit1Barrier2);
                line3Station1Exit2.Barriers = new List<Barrier>();
                line3Station1Exit2.Barriers.Add(line3Station1Exit2Barrier1);
                line3Station1Exit2.Barriers.Add(line3Station1Exit2Barrier2);
                line3Station2Exit1.Barriers = new List<Barrier>();
                line3Station2Exit1.Barriers.Add(line3Station2Exit1Barrier1);
                line3Station2Exit1.Barriers.Add(line3Station2Exit1Barrier2);
                line3Station2Exit2.Barriers = new List<Barrier>();
                line3Station2Exit2.Barriers.Add(line3Station2Exit2Barrier1);
                line3Station2Exit2.Barriers.Add(line3Station2Exit2Barrier2);
                line3Station3Exit1.Barriers = new List<Barrier>();
                line3Station3Exit1.Barriers.Add(line3Station3Exit1Barrier1);
                line3Station3Exit1.Barriers.Add(line3Station3Exit1Barrier2);
                line3Station3Exit2.Barriers = new List<Barrier>();
                line3Station3Exit2.Barriers.Add(line3Station3Exit2Barrier1);
                line3Station3Exit2.Barriers.Add(line3Station3Exit2Barrier2);

                line3Station1.Exits = new List<Exit>();
                line3Station1.Exits.Add(line3Station1Exit1);
                line3Station1.Exits.Add(line3Station1Exit2);
                line3Station2.Exits = new List<Exit>();
                line3Station2.Exits.Add(line3Station2Exit1);
                line3Station2.Exits.Add(line3Station2Exit2);
                line3Station3.Exits = new List<Exit>();
                line3Station3.Exits.Add(line3Station3Exit1);
                line3Station3.Exits.Add(line3Station3Exit2);

                line3.Stations = new List<Station>();
                line3.Stations.Add(line3Station1);
                line3.Stations.Add(line3Station2);
                line3.Stations.Add(line3Station3);

                #endregion

                db.Lines.Add(line1);
                db.Lines.Add(line2);
                db.Lines.Add(line3);

                db.SaveChanges();
            }
        }
    }
}
