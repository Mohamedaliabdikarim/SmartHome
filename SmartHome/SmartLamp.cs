using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class SmartLamp : Appliance
    {
        public int Brightness { get; set; }

        public SmartLamp(string brand, string room, int brightness)
            : base(brand, room)
        {
            Brightness = brightness;
        }

        public new void TurnOn()
        {
            Console.WriteLine($"{Brand} lamp turns on at {Brightness}% brightness.");
        }

        // ==================== DEL 11 ====================
        // 1. Blir utskriften samma?
        //    Nej! lamp1.TurnOn() och lamp2.TurnOn() ger olika utskrifter.

        // 2. Vilken metod körs när variabeln har typen SmartLamp?
        //    SmartLamp.TurnOn() körs - den med new.

        // 3. Vilken metod körs när variabeln har typen Appliance?
        //    Appliance.TurnOn() körs - basklassens metod.

        // 4. Varför är detta farligt eller förvirrande?
        //    Polymorfismen fungerar inte som förväntat.
        //    Beroende på variabeltypen körs olika metoder för samma objekt.

        // 5. Vad händer om du byter new till override?
        //    Då körs alltid SmartLamp.TurnOn() oavsett variabeltyp.
        //    Det är så polymorfism ska fungera.

        // new gömmer basklassens metod.
        // override ersätter basklassens metod polymorfiskt.
    }
}