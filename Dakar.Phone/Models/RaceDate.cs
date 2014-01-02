using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dakar.Phone.Models
{
    public class RaceDate
    {
        public string phase { get; set; }
        public string date { get; set; }
        public string departCity { get; set; }
        public string arrivalCity { get; set; }
        public int bikeOne { get; set; }
        public int bikeTwo { get; set; }
        public int bike { get; set; }
        public int carOne { get; set; }
        public int carTwo { get; set; }
        public int car { get; set; }
        public int truckOne { get; set; }
        public int truckTwo { get; set; }
        public int truck { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class RaceDates
    {
        public static List<RaceDate> raceDates;
        public RaceDates()
        {
            raceDates = new List<RaceDate>();
        }

        public static List<RaceDate> getRaceDates()
        {
            raceDates.Add(new RaceDate
            {
                phase = "01 ",
                date = " Jan 05",
                departCity = " Rosario",
                arrivalCity = "San Luis",
                bikeOne = 629,
                bikeTwo = 180,
                carOne = 629,
                carTwo = 180,
                truckOne = 629,
                truckTwo = 180,
                bike = 809,
                car = 809,
                truck = 809,
                Title = "Establishing their position",
                Description = "The competitors will wake up early to set off along the road in the region of Cordoba and start the race on some narrow tracks which will require the utmost vigilance. Each one will still be very fresh allowing them to tackle the stony sections or the blind jumps serenely. The competitors’ driving skills will be rewarded at the finish, where they will have already clocked up 800 kilometres. Although the gaps will not be significant at this stage of the race, it is nevertheless important to maintain their position in the part of the standings that they are aiming for!"
            });

            raceDates.Add(new RaceDate
            {
                phase = "02 ",
                date = " Jan 06",
                departCity = " San Luis",
                arrivalCity = "San Rafael",
                bikeOne = 365,
                bikeTwo = 359,
                bike = 724,
                carOne = 365,
                carTwo = 433,
                car = 798,
                truckOne = 365,
                truckTwo = 400,
                truck = 765,
                Title = "Grey dunes go hand in hand with surprises!",
                Description = "The fastest special stage of the rally, at least for its first part, will also be the one where drivers will have to face the first dunes. And it won’t just be a brief encounter with sand: in the last 100 kilometres, the exploration of the grey dunes of Nihuil will be even more intensive than during previous visits. The sand is more firm there, but the experience will provide a great deal of insight about each of the competitors’ technical skills. In short it will be a veritable test."
            });

            raceDates.Add(new RaceDate
            {
                phase = "03 ",
                date = " Jan 07",
                departCity = " San Rafael",
                arrivalCity = "San Juan",
                bikeOne = 292,
                bikeTwo = 373,
                bike = 665,
                carOne = 295,
                carTwo = 301,
                car = 596,
                truckOne = 295,
                truckTwo = 301,
                truck = 596,
                Title = "The Aconcagua as a landmark",
                Description = "The competitors of the 2014 Dakar will experience their first taste of the mountains by passing through the Pre-Andes. The Aconcagua Volcano stands 6,962m high and will observe the progress of the vehicles, of which a part will rehearse their high mountain driving techniques. The motorcyclists will climb up 4,300 metres during their special stage, on a ridgeline where they will have the impression of towering over the whole of America! The descent will bring them back to the tough reality of the drivers of the Dakar, as they will only have finished the first part of this marathon stage. They will have to ensure the mechanics for their own vehicles at the isolated bivouac which has been set up for them."
            });

            raceDates.Add(new RaceDate
            {
                phase = "04 ",
                date = " Jan 08",
                departCity = " San Juan",
                arrivalCity = "Chilecito",
                bikeOne = 210,
                bikeTwo = 353,
                bike = 563,
                carOne = 211,
                carTwo = 657,
                car = 868,
                truckOne = 211,
                truckTwo = 657,
                truck = 868,
                Title = "Mountains and countryside",
                Description = "The strategy of the motorcyclists will come into play: initially their navigational skills will be seriously tested at the beginning of the morning, and then they will be faced with the problem of worn tyres, as they have already been over-used the day before. As for the drivers of cars, they will have an even more demanding route to tackle in the countryside. The Dakar’s competitors haven’t faced a special stage this long since the historical one from Zouerat to Tichit in 2005! They will have to cross rivers, descend the canyons in a Wild West setting and beware of the other participants: as these terrains are often wide open, it will be entirely possible to overtake fellow competitors.",
            });

            raceDates.Add(new RaceDate
            {
                phase = "05 ",
                date = " Jan 09",
                departCity = " Chilecito",
                arrivalCity = "Tucuman",
                bikeOne = 384,
                bikeTwo = 527,
                bike = 911,
                carOne = 384,
                carTwo = 527,
                car = 911,
                truckOne = 384,
                truckTwo = 527,
                truck = 911,
                Title = "A sleepless night in Tucuman!",
                Description = "After two race days with completely separate routes, everyone will gather together to tackle the longest stage of the rally. They will need to be extremely resistant to overcome these two sections of the special stage which will primarily feature sand. All day long the competitors will make headway on off-piste sections: those who have poorly assessed the limits of their engine will constantly be on the verge of overheating and all the more so, as the region’s temperatures are generally very high. At the bivouac in Tucuman, the candidates for the podium will have been whittled down to a select few, as many of them will no longer be a part of this elite group. For many others, their timing and mechanical mishaps will only become apparent in the middle of the night.",
            });

            raceDates.Add(new RaceDate
            {
                phase = "06 ",
                date = " Jan 10",
                departCity = " Tucuman",
                arrivalCity = "Salta",
                bikeOne = 64,
                bikeTwo = 400,
                bike = 464,
                carOne = 270,
                carTwo = 424,
                car = 694,
                truckOne = 394,
                truckTwo = 156,
                truck = 550,
                Title = "The quest for the best time",
                Description = "Once they have left Tucuman, the cars will head north and drive along part of the renowned Ruta 40, and continue on in the heart of one of Argentina’s most beautiful landscapes. The possibilities to widen the gap will be limited but the most skilled drivers may be able to seize the opportunity of adding a stage to their list of wins. A new trip to the mountains will take motorcyclists to the banks of the rivers. They will have to remain vigilant until the very end of the stage as the region is frequented to a great extent by animals of all sizes. Then they will finally be able to rest.",
            });

            raceDates.Add(new RaceDate
            {
                phase = "07 ",
                date = " Jan 12",
                departCity = " Salta",
                arrivalCity = "Salta / Uyuni",
                bikeOne = 373,
                bikeTwo = 409,
                bike = 782,
                carOne = 230,
                carTwo = 533,
                car = 763,
                truckOne = 230,
                truckTwo = 525,
                truck = 755,
                Title = "The all Inclusive Loop and the maze of tracks before the salt flat",
                Description = "This mega loop with a 500-km long special stage on the agenda will test the teams’ ability to adapt to changes of pace. After stony terrains at the beginning of the day, some top speeds will be recorded in the second part of the stage, and then the drivers’ road techniques will be tested, and all of this at an average altitude of almost 3,500m. To end this highly emotional day, they will have to cross a vast salt flat extending over twenty or so kilometres: a straight stretch which will make the competitors’ heads spin.\nThe second marathon stage will begin for the riders of motorcycles and quad bikes, who will be savouring the first visit of the Dakar to Bolivia. When they enter the country the riders will experience a visual shock and will also be perturbed by the maze of tracks through which they will have to navigate. In these steep mountainous areas, the beauty of the setting and the variety of colours will not make the task ahead any easier. The few villages which will be idly crossed will, on the other hand, provide them with perfect waypoints. To reward their diligence, they will be able to head for the bivouac in Uyuni, set up on the edge of the salt flat… at an altitude of 3,600m!",
            });

            raceDates.Add(new RaceDate
            {
                phase = "08 ",
                date = " Jan 13",
                departCity = " Uyuni / Salta",
                arrivalCity = "Calama",
                bikeOne = 230,
                bikeTwo = 462,
                bike = 692,
                carOne = 510,
                carTwo = 302,
                car = 812,
                truckOne = 510,
                truckTwo = 302,
                truck = 812,
                Title = "Uyuni: A Vision of white and Entering Chile",
                Description = "The Salar de Uyuni is quite simply the biggest salt flat in the world! And the motorcyclists will be able to realise this, since they will have to go right round this gigantic stretch during the eighth stage of the rally. The route will be marked out around and across the salt flat, a marvel stretching over more than 400 kilometres, and will also pass by several islands which make this site so exceptional. The stature of the Tunupa Volcano (5,300m in altitude) will be a permanent feature on the landscape. An amazing daydream vision between heaven and earth on a white backdrop may be apparent, weather permitting!\nToday the competitors will cross the Andes Cordillera, to begin the Chilean part of the rally. A special transition stage has been marked out there for the last day that cars will progress without overtaking motorcycles and quad bikes. The timed section of the day will be accessible to skilled drivers who are at ease on fast tracks in a closed environment. Drivers are advised to pay attention to their position from the outset to limit the number of overtaking manoeuvres, even though the strict standards regarding the use of the Sentinel system will be carefully monitored at the end of the day.",
            });

            raceDates.Add(new RaceDate
            {
                phase = "09 ",
                date = " Jan 14",
                departCity = " Calama",
                arrivalCity = "Iquique",
                bikeOne = 29,
                bikeTwo = 422,
                bike = 451,
                carOne = 29,
                carTwo = 422,
                car = 451,
                truckOne = 29,
                truckTwo = 422,
                truck = 451,
                Title = "A steep drop: Thrilss guaranteed",
                Description = "The 2014 Dakar will reach its most northern point in Iquique, where the competitors will see the ocean for the first time this year. Above all, the drivers and teams will discover the Atacama Dunes again after a first part of a special stage which will be rather tedious. Dune specialists will be in command over a distance of almost 150km. Thrills will be guaranteed at the very end of the day, on the last three kilometres of the descent to Iquique: there is more than a 30% difference in height from start to finish and it is almost not recommended to break. The law of gravitation takes on its full meaning: the bivouac is not far away!",
            });

            raceDates.Add(new RaceDate
            {
                phase = "10 ",
                date = " Jan 15",
                departCity = " Iquique",
                arrivalCity = "Antofagasta",
                bikeOne = 58,
                bikeTwo = 631,
                bike = 689,
                carOne = 58,
                carTwo = 631,
                car = 689,
                truckOne = 58,
                truckTwo = 631,
                truck = 689,
                Title = "It would not be the Dakar without fesh fesh!",
                Description = "The special stage, split into two sections with very different features, will begin with the descent towards the shores of the Pacific. The advance gained in the stage the day before may will be increased in the sand during the first two hundred kilometres. Even more skill will be required to tackle the sections of fesh-fesh in the second part of the stage. Once this difficult area is behind the drivers, they will all be delighted to twist and wind along the region’s mine tracks, and in particular to be welcomed by the majestic arch of La Portuda, a stone’s throw from the bivouac in Antofagasta.",
            });

            raceDates.Add(new RaceDate
            {
                phase = "11 ",
                date = " Jan 16",
                departCity = " Antofagasta",
                arrivalCity = "El Salvador",
                bikeOne = 144,
                bikeTwo = 605,
                bike = 749,
                carOne = 144,
                carTwo = 605,
                car = 749,
                truckOne = 144,
                truckTwo = 605,
                truck = 749,
                Title = "The Atacama, in all its splendour",
                Description = "In addition to the distance, here the competitors will be put to the test by all the difficulties offered by the Atacama Desert… and will have to display all the qualities required for off-road races. After the mine tracks and the many rivers to cross, the competitors will have to distinguish themselves in the heart of the Dunes of Copiapo: the fastest motorcyclists are expected to spend seven hours behind the wheel. Needless to say that on this decisive day there will be no shortage of opportunities for competitors to make a winning comeback in the race. This will be the key stage of the 2014 edition.",
            });

            raceDates.Add(new RaceDate
            {
                phase = "12 ",
                date = " Jan 17",
                departCity = " El Salvador",
                arrivalCity = "La Serena",
                bikeOne = 349,
                bikeTwo = 350,
                bike = 699,
                carOne = 349,
                carTwo = 350,
                car = 699,
                truckOne = 349,
                truckTwo = 350,
                truck = 699,
                Title = "Dunes: The last ditch attempt",
                Description = "The site chosen in El Salvador at high altitude towers over the usual location of the bivouac in Copiapo. This position will ensure that the Camanchaca, the morning mist which sometimes hinders the start of the stages, will be avoided. Sand will be featured on the route again, in particular with a big string of dunes to be overcome at the end of the special stage. And if there are dunes, this automatically means that vehicles will be blocked in the sand! Therefore, in the categories where competitors are neck and neck, the leaders may put themselves at risk.",
            });

            raceDates.Add(new RaceDate
            {
                phase = "13 ",
                date = " Jan 18",
                departCity = " La Serena",
                arrivalCity = "Valparaiso",
                bikeOne = 378,
                bikeTwo = 157,
                bike = 535,
                carOne = 378,
                carTwo = 157,
                car = 535,
                truckOne = 378,
                truckTwo = 157,
                truck = 535,
                Title = "Watch out for the needles",
                Description = "Before admiring the hillsides brought to life by the houses in Valparaiso, the competitors will have to climb the hills planted with cacti during the rally’s last special stage. The pride and joy of crossing the finish line is drawing closer, but the statistics are formal: every year one or several drivers come unstuck during this final exercise so prudence is required! Even this close to the finish, vigilance is the competitors’ best ally to ensure their presence on the final podium.",
            });

            return raceDates;
        }
    }
}
