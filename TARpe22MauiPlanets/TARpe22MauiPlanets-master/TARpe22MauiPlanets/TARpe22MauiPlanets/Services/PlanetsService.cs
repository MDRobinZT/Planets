﻿using TARpe22MauiPlanets.Models;


namespace TARpe22MauiPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "  The smallest planet",
                HeroImage = "mercury.svg",
                Description = "Mercury is the smallest planet in the Solar " +
                "System and the closest to the Sun. Its orbit around the Sun takes " +
                "87.97 Earth days, the shortest of all the Sun's planets. " +
                "It is named after the Roman god Mercurius (Mercury), god " +
                "of commerce, messenger of the gods, and mediator between gods " +
                "and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like " +
                "Venus, Mercury orbits the Sun within Earth's orbit as an inferior " +
                "planet; its apparent distance from the Sun as viewed from Earth " +
                "never exceeds 28°.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }
            },

            new()
            {
                Name = "Venus",
                Subtitle = "  The pressure cooker",
                HeroImage = "venus.svg",
                Description = "Venus is the second planet from the Sun. It is sometimes " +
                "called Earth's \"sister\" or \"twin\" planet as it is almost as large " +
                "and has a similar composition. As an interior planet to Earth, Venus " +
                "(like Mercury) appears in Earth's sky never far from the Sun, either as " +
                "morning star or evening star. Aside from the Sun and Moon, Venus is the " +
                "brightest natural object in Earth's sky, capable of casting visible " +
                "shadows on Earth in dark conditions and being visible to the naked eye " +
                "in broad daylight.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },

            new()
            {
                Name = "Earth",
                Subtitle = "  The cradle of life",
                HeroImage = "earth.svg",
                Description = "Earth is the third planet from the Sun and the " +
                "only place known in the universe where life has originated and " +
                "found habitability. While Earth may not contain the largest " +
                "volumes of water in the Solar System, only Earth sustains liquid " +
                "surface water, extending over 70.8% of the Earth with its ocean, " +
                "making Earth an ocean world. Earth's polar regions currently " +
                "retain most of all other water with large sheets of ice covering " +
                "ocean and land, dwarfing Earth's groundwater, lakes, rivers and " +
                "atmospheric water.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },

                        new()
            {
                Name = " Mars",
                Subtitle = "  The iron planet",
                HeroImage = "mars.svg",
                Description = "Mars is the fourth planet from the Sun – a dusty, " +
                            "cold, desert world with a very thin atmosphere. " +
                            "Mars is also a dynamic planet with seasons, polar " +
                            "ice caps, canyons, extinct volcanoes, and evidence " +
                            "that it was even more active in the past.",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

            new()
            {
                Name = " Jupiter",
                Subtitle = "  The gas giant",
                HeroImage = "jupiter.svg",
                Description = "Jupiter is the fifth planet from the Sun and " +
                "the largest in the Solar System. It is a gas giant with " +
                "a mass more than two and a half times that of all the " +
                "other planets in the Solar System combined, and slightly " +
                "less than one one-thousandth the mass of the Sun.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },

                        new()
            {
                Name = " Saturn",
                Subtitle = "  The ring planet",
                HeroImage = "saturn.svg",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },

            new()
            {
                Name = " Uranus",
                Subtitle = "  The Herschel planet",
                HeroImage = "uranus.svg",
                Description = "Uranus is the seventh planet from the Sun. " +
                "It is named after Greek sky deity Uranus (Caelus), who in " +
                "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                "has the third-largest planetary radius and fourth-largest " +
                "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },

            new()
            {
                Name = " Neptune",
                Subtitle = "  The god of the sea",
                HeroImage = "neptune.svg",
                Description = "Neptune is the eighth planet from the Sun and " +
                "the farthest known planet in the Solar System. It is the " +
                "fourth-largest planet in the Solar System by diameter, the " +
                "third-most-massive planet, and the densest giant planet. " +
                "It is 17 times the mass of Earth, and slightly more " +
                "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

                        new()
            {
                Name = "Pluto",
                Subtitle = "A dwarf planet",
                HeroImage = "pluto.png",
                Description = "Pluto is a dwarf planet located in a" +
                            " distant region of our solar system beyond" +
                            " Neptune known as the Kuiper Belt. Pluto was" +
                            " long considered our ninth planet, but the" +
                            " International Astronomical Union reclassified" +
                            " Pluto as a dwarf planet in 2006.NASA's New" +
                            " Horizons was the first spacecraft to explore Pluto" +
                            " up close, flying by the dwarf planet and its moons" +
                            " in 2015. It found that Pluto is a complex world with" +
                            " mountains, valleys, plains, craters, and apparently even" +
                            " glaciers.Pluto was discovered in 1930 by astronomer" +
                            " Clyde Tombaugh at the Lowell Observatory in Flagstaff, " +
                            "Arizona. It was named by 11-year-old Venetia Burney of Oxford, England.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/05/pia19968-charonmoon-jpg.webp?w=1024&format=webp",
                    "https://science.nasa.gov/_ipx/animated_true&w_1024&f_webp/https://images-assets.nasa.gov/image/PIA20544/PIA20544~orig.jpg%3Fw=855%26h=582%26fit=clip%26crop=faces%252Cfocalpoint",
                }
            },


                        new()
            {
                Name = "Ceres",
                Subtitle = "Dwarf planet Ceres",
                HeroImage = "ceres.png",
                Description = "Dwarf planet Ceres is the largest object in the asteroid belt between" +
                            " Mars and Jupiter, and it's the only dwarf planet located in the inner" +
                            " solar system. It was the first member of the asteroid belt to be" +
                            " discovered when Giuseppe Piazzi spotted it in 1801. When NASA's Dawn" +
                            " arrived in 2015, Ceres became the first dwarf planet to be explored by" +
                            " a spacecraft.\r\n\r\nCalled an asteroid for many years, Ceres is so" +
                            " much bigger and so different from its rocky neighbors that scientists" +
                            " classified it as a dwarf planet in 2006. Even though Ceres comprises" +
                            " 25% of the asteroid belt's total mass, Pluto is still 14 times more" +
                            " massive.\r\n\r\nCeres is named for the Roman goddess of corn and" +
                            " harvests. The word cereal comes from the same name.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg",
                    "https://www.eso.org/public/archives/images/screen/eso1609a.jpg",
                }
            },


                        new()
            {
                Name = "Haumea",
                Subtitle = "Dwarf planet Haumea",
                HeroImage = "haumea.png",
                Description = "Haumea is an oval-shaped dwarf planet that is roughly the same size as Pluto." +
                            " It is one of the fastest rotating large objects in our solar system. The fast spin" +
                            " distorts Haumea's shape, making this dwarf planet look like a football. Everything" +
                            " we know about Haumea is from observations with ground-based telescopes from around" +
                            " the world.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.britannica.com/66/137066-004-13F11781/rendering-Artist-moons-Haumea.jpg",
                    "https://astrophotographylens.com/cdn/shop/articles/Haumea.jpg?v=1693095371",
                }
            },


                        new()
            {
                Name = "Makemake",
                Subtitle = "Dwarf planet MakeMake",
                HeroImage = "makemake.png",
                Description = "Dwarf planet Makemake – along with Pluto, Haumea, and Eris – is located in the Kuiper Belt" +
                            ", a donut-shaped region of icy bodies beyond the orbit of Neptune. Makemake is slightly smaller" +
                            " than Pluto, and is the second-brightest object in the Kuiper Belt as seen from Earth while Pluto" +
                            " is the brightest. It takes about 305 Earth years for this dwarf planet to make one trip around the Sun." +
                            "Makemake holds an important place in the history of solar system studies because it was one of the objects" +
                            " – along with Eris – whose discovery prompted the International Astronomical Union to reconsider the definition" +
                            " of a planet, and to create the new group of dwarf planets.\r\n\r\nMakemake was first observed in March 2005 by" +
                            " M.E. Brown, C.A. Trujillo, and D.L. Rabinowitz at the Palomar Observatory, California. Its unofficial codename" +
                            " was Easterbunny, Brown said, \"in honor of the fact that it was discovered just a few days past Easter. Before" +
                            " this dwarf planet was confirmed, its provisional name was 2005 FY9. In 2016, NASA’s Hubble Space Telescope" +
                            " spotted a small, dark moon orbiting Makemake.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8.jpg",
                    "https://4.bp.blogspot.com/_CDjLcbQRywI/SS1nqOeAq4I/AAAAAAAAADo/EXB-tQfwWBg/w1200-h630-p-k-no-nu/Makemake.jpg",
                }
            },



                        new()
            {
                Name = "Eris",
                Subtitle = "Dwarf planet Eris",
                HeroImage = "eris.png",
                Description = "The discovery of Eris help trigger a debate in the scientific community that led to the International Astronomical" +
                            " Union's decision in 2006 to clarify the definition of a planet. Pluto, Eris, and other similar objects are now classified" +
                            " as dwarf planets. Eris was discovered on Jan. 5, 2005, from data obtained on Oct. 21, 2003, during a Palomar Observatory " +
                            "survey of the outer solar system by Mike Brown, a professor of planetary astronomy at the California Institute of Technology;" +
                            " Chad Trujillo of the Gemini Observatory; and David Rabinowitz of Yale University.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://i.natgeofe.com/n/495a21cb-c570-43d8-b5f7-3dfbedb91932/42531.jpg",
                    "https://astrophotographylens.com/cdn/shop/articles/eris.jpg?v=1687009010",
                }
            },


    };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
