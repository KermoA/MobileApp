﻿using MauiPlanets.Models;


namespace MauiPlanets.Services
{
	internal class PlanetsService
	{
		private static List<Planet> planets = new()
		{
			new()
			{
				Name = "Mercury",
				Subtitle = "The smallest planet",
				HeroImage = "mercury.png",
				Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. " +
							"In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and " +
							"communication, and the messenger of the gods. ",
				AccentColorStart = Color.FromArgb("#353535"),
				AccentColorEnd = Color.FromArgb("#8d9098"),
				Images = new()
				{
					"https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
					"https://starlust.org/wp-content/uploads/2023/07/planet-mercury.webp",
					"https://griffithobservatory.org/wp-content/uploads/2021/03/Mercury_fin_flood_LD_V3-1600x844.jpg"
				}
			},
			new()
			{
				Name = "Venus",
				Subtitle = "The pressure cooker",
				HeroImage = "venus.png",
				Description = "Of all the planets, Venus is the one most similar to Earth. In fact, " +
							"Venus is often called Earth's “sister” planet. As similar as it is in some ways, " +
							"however, it is also very different in others. ",
				AccentColorStart = Color.FromArgb("#a6393b"),
				AccentColorEnd = Color.FromArgb("#d17f21"),
				Images = new()
				{
					"https://cdn.mos.cms.futurecdn.net/RifjtkFLBEFgzkZqWEh69P-1200-80.jpg",
					"https://starwalk.space/gallery/images/amazing-planet-venus/1920x1080.jpg",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSRIK8HsPuD9mo2NePF9ZOpGjGFeHeB5g41wUYG51uCFvewSBAv4Fl1ZBGgYjBhNMjsJaA&usqp=CAU"

				}
			},
			new()
			{
				Name = "Earth",
				Subtitle = "The cradle of life",
				HeroImage = "earth.png",
				Description = "The Earth is the only planet known where life exists. Almost 1.5 million species " +
							"of animals and plants have been discovered so far, and many more have yet to be found. While other " +
							"planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions " +
							"for a breathable atmosphere. ",
				AccentColorStart = Color.FromArgb("#0e3d68"),
				AccentColorEnd = Color.FromArgb("#2e97c7"),
				Images = new()
				{
					"https://res.cloudinary.com/jerrick/image/upload/d_642250b563292b35f27461a7.png,f_jpg,fl_progressive,q_auto,w_1024/63e0ae1d227cb3001dcfcedd.jpg",
					"https://www.farmersalmanac.com/wp-content/uploads/2020/11/Exceptional-earth.jpg",
					"https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
				}
			},
			new()
			{
				Name = "Mars",
				Subtitle = "The red beauty",
				HeroImage = "mars.png",
				Description = "No planet has sparked the imaginations of humans as much as Mars. " +
							"It may be the reddish color of Mars, or the fact that it can often be easily seen " +
							"in the night sky, that has caused people to wonder about this close neighbor of ours. " +
							"Tales of “Martians” invading Earth have been around for well over fifty years. But is " +
							"it likely that any kind of life really does exist on Mars? ",
				AccentColorStart = Color.FromArgb("#a23036"),
				AccentColorEnd = Color.FromArgb("#eb3333"),
				Images = new()
				{
					"https://www.worldatlas.com/upload/bb/c3/32/shutterstock-1041249343.jpg",
					"https://www.frostscience.org/wp-content/uploads/2023/01/Mars-blog-header-1024x576.png",
					"https://miro.medium.com/v2/resize:fit:1200/1*2n6yiV0A8p8Lyk55gId23Q.jpeg"
				}
			},
			new()
			{
				Name = "Jupiter",
				Subtitle = "The gas giant",
				HeroImage = "jupiter.png",
				Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. " +
							"It is a gas giant with a mass more than 2.5 times that of all the other planets in the Solar " +
							"System combined, and slightly less than one-thousandth the mass of the Sun.",
				AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#cd8026"),
				Images = new()
				{
					"https://i0.wp.com/geolearn.in/wp-content/uploads/2020/12/image-187.png?fit=614%2C384&ssl=1",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQfNDiO-vgPbwZ_hn1-urOWQw-4FYyXVcH1mA&s",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5Mc_u3Kd8JZkjGM4D5CVkfPxisrORr-bWhg&s"
				}
			},
			new()
			{
				Name = "Saturn",
				Subtitle = "The ring planet",
				HeroImage = "saturn.png",
				Description = "Saturn is the sixth planet from the Sun and the second largest in the Solar System, " +
							"after Jupiter. It is a gas giant, with an average radius of about nine times that of Earth. Saturn's " +
							"interior is thought to be composed of a rocky core, surrounded by a deep layer of metallic hydrogen, " +
							"an intermediate layer of liquid hydrogen and liquid helium, and an outer layer of gas.",
				AccentColorStart = Color.FromArgb("#996237"),
				AccentColorEnd = Color.FromArgb("#c6502f"),
				Images = new()
				{
					"https://cf-img-a-in.tosshub.com/sites/visualstory/wp/2024/06/Saturn1.jpeg?size=*:900",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRl5NX24CQTZ0OB9T9BYoA2xlI2fc2bTUDAHA&s",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1elU2tkBub1odubHywTxL1StYHoGRsv_Dww&s"
				}
			},
			new()
			{
				Name = "Uranus",
				Subtitle = "The Herschel planet",
				HeroImage = "uranus.png",
				Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant. " +
							"Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, which " +
							"astronomy calls 'ice' or volatiles. The planet's atmosphere has a complex layered cloud structure and " +
							"has the lowest minimum temperature (49 K (−224 °C; −371 °F)) of all the Solar System's planets.",
				AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#996237"),
				Images = new()
				{
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTO6KXc87281zVEO7z9cUId7-nqBOglXNdgyA&s",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSG8CQzihe85ZwOPAGBE-JooA_hDUGirVmeHw&s",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdhFjYwfwG7-4c3mT-TB-y8JutZC_i6_cv0Q&s"
				}
			},
			new()
			{
				Name = "Neptune",
				Subtitle = "The god of the sea",
				HeroImage = "neptune.png",
				Description = "Neptune is the eighth and farthest known planet from the Sun. It is the " +
							"fourth-largest planet in the Solar System by diameter, the third-most-massive planet, " +
							"and the densest giant planet. It is 17 times the mass of Earth and slightly more massive, " +
							"but denser and smaller, than fellow ice giant Uranus.",
				AccentColorStart = Color.FromArgb("#0c293d"),
				AccentColorEnd = Color.FromArgb("#26abe0"),
				Images = new()
				{
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOE0lFUuYQKRPDF5Jnpw40XpyuOUpKfLLXBA&s",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTKYtK1rw-bMdomPmONkGk3cREGm79I_nSPJg&s",
					"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1hyWzldCX3g_BWDTb-chlv-2elXM90qbZcw&s"
				}
			},
			new()
			{
				Name = "Pluto",
				Subtitle = "Pluto enjoyed decades of special status as one of the solar system's planets.",
				HeroImage = "pluto.png",
				Description = "Pluto (minor-planet designation: 134340 Pluto) is a dwarf planet in the Kuiper belt, " +
				"a ring of bodies beyond the orbit of Neptune. It is the ninth-largest and tenth-most-massive known " +
				"object to directly orbit the Sun. It is the largest known trans-Neptunian object by volume, by a small " +
				"margin, but is less massive than Eris.",
				AccentColorStart = Color.FromArgb("#ae7e60"),
				AccentColorEnd = Color.FromArgb("#bdab9f"),
				Images = new()
				{
					"https://oap.unige.ch/journals/public/journals/8/submission_847_810_coverImage_en_US.jpg",
					"https://i.natgeofe.com/n/d37ef874-0dc6-4cd4-b244-74d6b3f7232c/Pluto4.jpg",
					"https://cdn.mos.cms.futurecdn.net/DoZSMXF87kCuzbymsuEFHo.jpg"
				}
			},
			new()
			{
				Name = "Ceres",
				Subtitle = "Ceres is named for the Roman goddess of corn and harvests.",
				HeroImage = "ceres.png",
				Description = "Ceres (minor-planet designation: 1 Ceres) is a dwarf planet in the middle main asteroid " +
				"belt between the orbits of Mars and Jupiter. It was the first known asteroid, discovered on 1 January " +
				"1801 by Giuseppe Piazzi at Palermo Astronomical Observatory in Sicily, and announced as a new planet. " +
				"Ceres was later classified as an asteroid and then a dwarf planet, the only one not beyond Neptune's orbit.",
				AccentColorStart = Color.FromArgb("#686462"),
				AccentColorEnd = Color.FromArgb("#b8b5b3"),
				Images = new()
				{
					"https://cdn.mos.cms.futurecdn.net/qnft8kRfeGWWLgaygo4fb9.jpg",
					"https://i0.wp.com/eos.org/wp-content/uploads/2016/09/ceres-northern-end.jpg?fit=820%2C615&ssl=1",
					"https://d2cbg94ubxgsnp.cloudfront.net/Pictures/480xany/1/9/8/140198_Ceres_c_NASA-JPL---Caltech-UCLA-MPS-DLR-IDA.jpg"
				}
			},
			new()
			{
				Name = "Haumea",
				Subtitle = "Haumea is named after the Hawaiian goddess of fertility.",
				HeroImage = "haumea.png",
				Description = "Dwarf planet Haumea was originally designated 2003 EL61 (and nicknamed Santa by one discovery team). " +
				"Haumea is located in the Kuiper Belt, a doughnut-shaped region of icy bodies beyond the orbit of Neptune.",
				AccentColorStart = Color.FromArgb("#757270"),
				AccentColorEnd = Color.FromArgb("#8b8680"),
				Images = new()
				{
					"https://www.centraldatacore.com/wp-content/uploads/PD3-Haumea-P-Key-1200x900.jpg",
					"https://www.reddit.com/media?url=https%3A%2F%2Fi.redd.it%2F9fswe344cff51.jpg",
					"https://www.universetoday.com/wp-content/uploads/2022/10/7871.jpg"
				}
			},
			new()
			{
				Name = "MakeMake",
				Subtitle = "Makemake was named after the Rapanui god of fertility.",
				HeroImage = "makemake.png",
				Description = "Dwarf planet Makemake – along with Pluto, Haumea, and Eris – is located in the Kuiper Belt, " +
				"a donut-shaped region of icy bodies beyond the orbit of Neptune. Makemake is slightly smaller than Pluto, " +
				"and is the second-brightest object in the Kuiper Belt as seen from Earth while Pluto is the brightest. " +
				"It takes about 305 Earth years for this dwarf planet to make one trip around the Sun.",
				AccentColorStart = Color.FromArgb("#7c4b34"),
				AccentColorEnd = Color.FromArgb("#9a7567"),
				Images = new()
				{
					"https://cdn.eso.org/images/screen/eso1246a.jpg",
					"https://www.universetoday.com/wp-content/uploads/2008/07/Makemake.jpg",
					"https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8.jpg"
				}
			},
			new()
			{
				Name = "Eris",
				Subtitle = "Largest dwarf planet",
				HeroImage = "eris.png",
				Description = "The discovery of Eris help trigger a debate in the scientific community that led to the " +
				"International Astronomical Union's decision in 2006 to clarify the definition of a planet. Pluto, Eris, " +
				"and other similar objects are now classified as dwarf planets.",
				AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#996237"),
				Images = new()
				{
					"https://cff2.earth.com/uploads/2024/02/20135637/Eris_icy-dwarf-planet_kuiper-belt_1m.jpg",
					"https://static.wikia.nocookie.net/terragenesis/images/8/88/Habitable_Eris.jpg/revision/latest?cb=20210202092847",
					"https://www.bobthealien.co.uk/bobpics/eris_ai.jpg"
				}
			}
		};

		public static List<Planet> GetFeaturedPlanets()
		{
			var random = new Random();
			var randomizePlanets = planets.OrderBy(item => random.Next());

			return randomizePlanets
				.Take(2)
				.ToList();
		}

		public static List<Planet> GetAllPlanets()
			=> planets;
	}
}