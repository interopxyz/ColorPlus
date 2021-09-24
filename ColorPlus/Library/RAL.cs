
using System.Drawing;

namespace ColorPlus
{
    public struct RAL
    {
        public static readonly RAL Empty;

        public static Colour GreenBeige { get { return new Colour(1000, "Green Beige", Color.FromArgb(190, 189, 127)); } }
        public static Colour Beige { get { return new Colour(1001, "Beige", Color.FromArgb(194, 176, 120)); } }
        public static Colour SandYellow { get { return new Colour(1002, "Sand Yellow", Color.FromArgb(198, 166, 100)); } }
        public static Colour SignalYellow { get { return new Colour(1003, "Signal Yellow", Color.FromArgb(229, 190, 1)); } }
        public static Colour GoldenYellow { get { return new Colour(1004, "Golden Yellow", Color.FromArgb(205, 164, 52)); } }
        public static Colour HoneyYellow { get { return new Colour(1005, "Honey Yellow", Color.FromArgb(169, 131, 7)); } }
        public static Colour MaizeYellow { get { return new Colour(1006, "Maize Yellow", Color.FromArgb(228,160,16)); } }
        public static Colour DaffodilYellow { get { return new Colour(1007, "Daffodil Yellow", Color.FromArgb(220, 157, 0)); } }
        public static Colour BrownBeige { get { return new Colour(1011, "Brown Beige", Color.FromArgb(138, 102, 66)); } }
        public static Colour LemonYellow { get { return new Colour(1012, "Lemon Yellow", Color.FromArgb(199, 180, 70)); } }
        public static Colour OysterWhite { get { return new Colour(1013, "Oyster White", Color.FromArgb(238, 234, 205)); } }
        public static Colour Ivory { get { return new Colour(1014, "Ivory", Color.FromArgb(225, 204, 79)); } }
        public static Colour LightIvory { get { return new Colour(1015, "Light Ivory", Color.FromArgb(230, 214, 144)); } }
        public static Colour SulfurYellow { get { return new Colour(1016, "Sulfur Yellow", Color.FromArgb(237, 255, 33)); } }
        public static Colour SaffronYellow { get { return new Colour(1017, "Saffron Yellow", Color.FromArgb(245, 208, 51)); } }
        public static Colour ZincYellow { get { return new Colour(1018, "Zinc Yellow", Color.FromArgb(248, 243, 43)); } }
        public static Colour GreyBeige { get { return new Colour(1019, "Grey Beige", Color.FromArgb(158, 151, 100)); } }
        public static Colour OliveYellow { get { return new Colour(1020, "Olive Yellow", Color.FromArgb(153, 153, 80)); } }
        public static Colour ColzaYellow { get { return new Colour(1021, "Colza Yellow", Color.FromArgb(243, 218, 11)); } }
        public static Colour TrafficYellow { get { return new Colour(1023, "Traffic Yellow", Color.FromArgb(250, 210, 1)); } }
        public static Colour OchreYellow { get { return new Colour(1024, "Ochre Yellow", Color.FromArgb(174, 160, 75)); } }
        public static Colour LuminousYellow { get { return new Colour(1026, "Luminous Yellow", Color.FromArgb(255, 255, 0)); } }
        public static Colour Curry { get { return new Colour(1027, "Curry", Color.FromArgb(157, 145, 1)); } }
        public static Colour MelonYellow { get { return new Colour(1028, "Melon Yellow", Color.FromArgb(244, 169, 0)); } }
        public static Colour BroomYellow { get { return new Colour(1032, "Broom Yellow", Color.FromArgb(214, 174, 1)); } }
        public static Colour DahliaYellow { get { return new Colour(1033, "Dahlia Yellow", Color.FromArgb(243, 165, 5)); } }
        public static Colour PastelYellow { get { return new Colour(1034, "Pastel Yellow", Color.FromArgb(239, 169, 74)); } }
        public static Colour PearlBeige { get { return new Colour(1035, "Pearl Beige", Color.FromArgb(106, 93, 77)); } }
        public static Colour PearlGold { get { return new Colour(1036, "Pearl Gold", Color.FromArgb(112, 83, 53)); } }
        public static Colour SunYellow { get { return new Colour(1037, "Sun Yellow", Color.FromArgb(243, 159, 24)); } }
        public static Colour YellowOrange { get { return new Colour(2000, "Yellow Orange", Color.FromArgb(237, 118, 14)); } }
        public static Colour RedOrange { get { return new Colour(2001, "Red Orange", Color.FromArgb(201, 60, 32)); } }
        public static Colour Vermilion { get { return new Colour(2002, "Vermilion", Color.FromArgb(203, 40, 33)); } }
        public static Colour PastelOrange { get { return new Colour(2003, "Pastel Orange", Color.FromArgb(255, 117, 20)); } }
        public static Colour PureOrange { get { return new Colour(2004, "Pure Orange", Color.FromArgb(244, 70, 17)); } }
        public static Colour LuminousOrange { get { return new Colour(2005, "Luminous Orange", Color.FromArgb(255, 35, 1)); } }
        public static Colour LuminousBrightOrange { get { return new Colour(2007, "Luminous Bright Orange", Color.FromArgb(255, 164, 32)); } }
        public static Colour BrightRedOrange { get { return new Colour(2008, "Bright Red Orange", Color.FromArgb(247, 94, 37)); } }
        public static Colour TrafficOrange { get { return new Colour(2009, "Traffic Orange", Color.FromArgb(245, 64, 33)); } }
        public static Colour SignalOrange { get { return new Colour(2010, "Signal Orange", Color.FromArgb(216, 75, 32)); } }
        public static Colour DeepOrange { get { return new Colour(2011, "Deep Orange", Color.FromArgb(236, 124, 38)); } }
        public static Colour SalmonRange { get { return new Colour(2012, "Salmon Range", Color.FromArgb(229, 81, 55)); } }
        public static Colour PearlOrange { get { return new Colour(2013, "Pearl Orange", Color.FromArgb(195, 88, 49)); } }
        public static Colour FlameRed { get { return new Colour(3000, "Flame Red", Color.FromArgb(175, 43, 30)); } }
        public static Colour SignalRed { get { return new Colour(3001, "Signal Red", Color.FromArgb(165, 32, 25)); } }
        public static Colour CarmineRed { get { return new Colour(3002, "Carmine Red", Color.FromArgb(162, 35, 29)); } }
        public static Colour RubyRed { get { return new Colour(3003, "Ruby Red", Color.FromArgb(155, 17, 30)); } }
        public static Colour PurpleRed { get { return new Colour(3004, "Purple Red", Color.FromArgb(117, 21, 30)); } }
        public static Colour WineRed { get { return new Colour(3005, "Wine Red", Color.FromArgb(94, 33, 41)); } }
        public static Colour BlackRed { get { return new Colour(3007, "Black Red", Color.FromArgb(53, 31, 33)); } }
        public static Colour OxideRed { get { return new Colour(3009, "Oxide Red", Color.FromArgb(100, 36, 36)); } }
        public static Colour BrownRed { get { return new Colour(3011, "Brown Red", Color.FromArgb(120, 31, 25)); } }
        public static Colour BeigeRed { get { return new Colour(3012, "Beige Red", Color.FromArgb(193, 135, 107)); } }
        public static Colour TomatoRed { get { return new Colour(3013, "Tomato Red", Color.FromArgb(161, 35, 18)); } }
        public static Colour AntiquePink { get { return new Colour(3014, "Antique Pink", Color.FromArgb(211, 110, 112)); } }
        public static Colour LightPink { get { return new Colour(3015, "Light Pink", Color.FromArgb(234, 137, 154)); } }
        public static Colour CoralRed { get { return new Colour(3016, "Coral Red", Color.FromArgb(179, 40, 33)); } }
        public static Colour Rose { get { return new Colour(3017, "Rose", Color.FromArgb(230, 50, 68)); } }
        public static Colour StrawberryRed { get { return new Colour(3018, "Strawberry Red", Color.FromArgb(213, 48, 50)); } }
        public static Colour TrafficRed { get { return new Colour(3020, "Traffic Red", Color.FromArgb(204, 6, 5)); } }
        public static Colour SalmonPink { get { return new Colour(3022, "Salmon Pink", Color.FromArgb(217, 80, 48)); } }
        public static Colour LuminousRed { get { return new Colour(3024, "Luminous Red", Color.FromArgb(248, 0, 0)); } }
        public static Colour LuminousBrightRed { get { return new Colour(3026, "Luminous Bright Red", Color.FromArgb(254, 0, 0)); } }
        public static Colour RaspberryRed { get { return new Colour(3027, "Raspberry Red", Color.FromArgb(197, 29, 52)); } }
        public static Colour PureRed { get { return new Colour(3028, "Pure  Red", Color.FromArgb(203, 50, 52)); } }
        public static Colour OrientRed { get { return new Colour(3031, "Orient Red", Color.FromArgb(179, 36, 40)); } }
        public static Colour PearlRubyRed { get { return new Colour(3032, "Pearl Ruby Red", Color.FromArgb(114, 20, 34)); } }
        public static Colour PearlPink { get { return new Colour(3033, "Pearl Pink", Color.FromArgb(180, 76, 67)); } }
        public static Colour RedLilac { get { return new Colour(4001, "Red Lilac", Color.FromArgb(109, 63, 91)); } }
        public static Colour RedViolet { get { return new Colour(4002, "Red Violet", Color.FromArgb(146, 43, 62)); } }
        public static Colour HeatherViolet { get { return new Colour(4003, "Heather Violet", Color.FromArgb(222, 76, 138)); } }
        public static Colour ClaretViolet { get { return new Colour(4004, "Claret Violet", Color.FromArgb(110, 28, 52)); } }
        public static Colour BlueLilac { get { return new Colour(4005, "Blue Lilac", Color.FromArgb(108, 70, 117)); } }
        public static Colour TrafficPurple { get { return new Colour(4006, "Traffic Purple", Color.FromArgb(160, 52, 114)); } }
        public static Colour PurpleViolet { get { return new Colour(4007, "Purple Violet", Color.FromArgb(74, 25, 44)); } }
        public static Colour SignalViolet { get { return new Colour(4008, "Signal Violet", Color.FromArgb(146, 78, 125)); } }
        public static Colour PastelViolet { get { return new Colour(4009, "Pastel Violet", Color.FromArgb(164, 125, 144)); } }
        public static Colour Telemagenta { get { return new Colour(4010, "Telemagenta", Color.FromArgb(215, 45, 109)); } }
        public static Colour PearlViolet { get { return new Colour(4011, "Pearl Violet", Color.FromArgb(134, 115, 161)); } }
        public static Colour PearlBlackBerry { get { return new Colour(4012, "Pearl Black Berry", Color.FromArgb(108, 104, 129)); } }
        public static Colour VioletBlue { get { return new Colour(5000, "Violet Blue", Color.FromArgb(42, 46, 75)); } }
        public static Colour GreenBlue { get { return new Colour(5001, "Green Blue", Color.FromArgb(31, 52, 56)); } }
        public static Colour UltramarineBlue { get { return new Colour(5002, "Ultramarine Blue", Color.FromArgb(32, 33, 79)); } }
        public static Colour SaphireBlue { get { return new Colour(5003, "Saphire Blue", Color.FromArgb(29, 30, 51)); } }
        public static Colour BlackBlue { get { return new Colour(5004, "Black Blue", Color.FromArgb(24, 23, 28)); } }
        public static Colour SignalBlue { get { return new Colour(5005, "Signal Blue", Color.FromArgb(30, 45, 110)); } }
        public static Colour BrillantBlue { get { return new Colour(5007, "Brillant Blue", Color.FromArgb(62, 95, 138)); } }
        public static Colour GreyBlue { get { return new Colour(5008, "Grey Blue", Color.FromArgb(38, 37, 45)); } }
        public static Colour AzureBlue { get { return new Colour(5009, "Azure Blue", Color.FromArgb(2, 86, 105)); } }
        public static Colour GentianBlue { get { return new Colour(5010, "Gentian Blue", Color.FromArgb(14, 41, 75)); } }
        public static Colour SteelBlue { get { return new Colour(5011, "Steel Blue", Color.FromArgb(35, 26, 36)); } }
        public static Colour LightBlue { get { return new Colour(5012, "Light Blue", Color.FromArgb(59, 131, 189)); } }
        public static Colour CobaltBlue { get { return new Colour(5013, "Cobalt Blue", Color.FromArgb(30, 33, 61)); } }
        public static Colour PigeonBlue { get { return new Colour(5014, "Pigeon Blue", Color.FromArgb(96, 110, 140)); } }
        public static Colour SkyBlue { get { return new Colour(5015, "Sky Blue", Color.FromArgb(34, 113, 179)); } }
        public static Colour TrafficBlue { get { return new Colour(5017, "Traffic Blue", Color.FromArgb(6, 57, 113)); } }
        public static Colour TurquoiseBlue { get { return new Colour(5018, "Turquoise Blue", Color.FromArgb(63, 136, 143)); } }
        public static Colour CapriBlue { get { return new Colour(5019, "Capri Blue", Color.FromArgb(27, 85, 131)); } }
        public static Colour OceanBlue { get { return new Colour(5020, "Ocean Blue", Color.FromArgb(29, 51, 74)); } }
        public static Colour WaterBlue { get { return new Colour(5021, "Water Blue", Color.FromArgb(37, 109, 123)); } }
        public static Colour NightBlue { get { return new Colour(5022, "Night Blue", Color.FromArgb(37, 40, 80)); } }
        public static Colour DistantBlue { get { return new Colour(5023, "Distant Blue", Color.FromArgb(73, 103, 141)); } }
        public static Colour PastelBlue { get { return new Colour(5024, "Pastel Blue", Color.FromArgb(93, 155, 155)); } }
        public static Colour PearlGentianBlue { get { return new Colour(5025, "Pearl Gentian Blue", Color.FromArgb(42, 100, 120)); } }
        public static Colour PearlNightBlue { get { return new Colour(5026, "Pearl Night Blue", Color.FromArgb(16, 44, 84)); } }
        public static Colour PatinaGreen { get { return new Colour(6000, "Patina Green", Color.FromArgb(49, 102, 80)); } }
        public static Colour EmeraldGreen { get { return new Colour(6001, "Emerald Green", Color.FromArgb(40, 114, 51)); } }
        public static Colour LeafGreen { get { return new Colour(6002, "Leaf Green", Color.FromArgb(45, 87, 44)); } }
        public static Colour OliveGreen { get { return new Colour(6003, "Olive Green", Color.FromArgb(66, 70, 50)); } }
        public static Colour BlueGreen { get { return new Colour(6004, "Blue Green", Color.FromArgb(31, 58, 61)); } }
        public static Colour MossGreen { get { return new Colour(6005, "Moss Green", Color.FromArgb(47, 69, 56)); } }
        public static Colour GreyOlive { get { return new Colour(6006, "Grey Olive", Color.FromArgb(62, 59, 50)); } }
        public static Colour BottleGreen { get { return new Colour(6007, "Bottle Green", Color.FromArgb(52, 59, 41)); } }
        public static Colour BrownGreen { get { return new Colour(6008, "Brown Green", Color.FromArgb(57, 53, 42)); } }
        public static Colour FirGreen { get { return new Colour(6009, "Fir Green", Color.FromArgb(49, 55, 43)); } }
        public static Colour GrassGreen { get { return new Colour(6010, "Grass Green", Color.FromArgb(53, 104, 45)); } }
        public static Colour ResedaGreen { get { return new Colour(6011, "Reseda Green", Color.FromArgb(88, 114, 70)); } }
        public static Colour BlackGreen { get { return new Colour(6012, "Black Green", Color.FromArgb(52, 62, 64)); } }
        public static Colour ReedGreen { get { return new Colour(6013, "Reed Green", Color.FromArgb(108, 113, 86)); } }
        public static Colour YellowOlive { get { return new Colour(6014, "Yellow Olive", Color.FromArgb(71, 64, 46)); } }
        public static Colour BlackOlive { get { return new Colour(6015, "Black Olive", Color.FromArgb(59, 60, 54)); } }
        public static Colour TurquoiseGreen { get { return new Colour(6016, "Turquoise Green", Color.FromArgb(30, 89, 69)); } }
        public static Colour MayGreen { get { return new Colour(6017, "May Green", Color.FromArgb(76, 145, 65)); } }
        public static Colour YellowGreen { get { return new Colour(6018, "Yellow Green", Color.FromArgb(87, 166, 57)); } }
        public static Colour PastelGreen { get { return new Colour(6019, "Pastel Green", Color.FromArgb(189, 236, 182)); } }
        public static Colour ChromeGreen { get { return new Colour(6020, "Chrome Green", Color.FromArgb(46, 58, 35)); } }
        public static Colour PaleGreen { get { return new Colour(6021, "Pale Green", Color.FromArgb(137, 172, 118)); } }
        public static Colour OliveDrab { get { return new Colour(6022, "Olive Drab", Color.FromArgb(37, 34, 27)); } }
        public static Colour TrafficGreen { get { return new Colour(6024, "Traffic Green", Color.FromArgb(48, 132, 70)); } }
        public static Colour FernGreen { get { return new Colour(6025, "Fern Green", Color.FromArgb(61, 100, 45)); } }
        public static Colour OpalGreen { get { return new Colour(6026, "Opal Green", Color.FromArgb(1, 93, 82)); } }
        public static Colour LightGreen { get { return new Colour(6027, "Light Green", Color.FromArgb(132, 195, 190)); } }
        public static Colour PineGreen { get { return new Colour(6028, "Pine Green", Color.FromArgb(44, 85, 69)); } }
        public static Colour MintGreen { get { return new Colour(6029, "Mint Green", Color.FromArgb(32, 96, 61)); } }
        public static Colour SignalGreen { get { return new Colour(6032, "Signal Green", Color.FromArgb(49, 127, 67)); } }
        public static Colour MintTurquoise { get { return new Colour(6033, "Mint Turquoise", Color.FromArgb(73, 126, 118)); } }
        public static Colour PastelTurquoise { get { return new Colour(6034, "Pastel Turquoise", Color.FromArgb(127, 181, 181)); } }
        public static Colour PearlGreen { get { return new Colour(6035, "Pearl Green", Color.FromArgb(28, 84, 45)); } }
        public static Colour PearlOpalGreen { get { return new Colour(6036, "Pearl Opal Green", Color.FromArgb(25, 55, 55)); } }
        public static Colour PureGreen { get { return new Colour(6037, "Pure Green", Color.FromArgb(0, 143, 57)); } }
        public static Colour LuminousGreen { get { return new Colour(6038, "Luminous Green", Color.FromArgb(0, 187, 45)); } }
        public static Colour SquirrelGrey { get { return new Colour(7000, "Squirrel Grey", Color.FromArgb(120, 133, 139)); } }
        public static Colour SilverGrey { get { return new Colour(7001, "Silver Grey", Color.FromArgb(138, 149, 151)); } }
        public static Colour OliveGrey { get { return new Colour(7002, "Olive Grey", Color.FromArgb(126, 123, 82)); } }
        public static Colour MossGrey { get { return new Colour(7003, "Moss Grey", Color.FromArgb(108, 112, 89)); } }
        public static Colour SignalGrey { get { return new Colour(7004, "Signal Grey", Color.FromArgb(150, 153, 146)); } }
        public static Colour MouseGrey { get { return new Colour(7005, "Mouse Grey", Color.FromArgb(100, 107, 99)); } }
        public static Colour BeigeGrey { get { return new Colour(7006, "Beige Grey", Color.FromArgb(109, 101, 82)); } }
        public static Colour KhakiGrey { get { return new Colour(7008, "Khaki Grey", Color.FromArgb(106, 95, 49)); } }
        public static Colour GreenGrey { get { return new Colour(7009, "Green Grey", Color.FromArgb(77, 86, 69)); } }
        public static Colour TarpaulinGrey { get { return new Colour(7010, "Tarpaulin Grey", Color.FromArgb(76, 81, 74)); } }
        public static Colour IronGrey { get { return new Colour(7011, "Iron Grey", Color.FromArgb(67, 75, 77)); } }
        public static Colour BasaltGrey { get { return new Colour(7012, "Basalt Grey", Color.FromArgb(78, 87, 84)); } }
        public static Colour BrownGrey { get { return new Colour(7013, "Brown Grey", Color.FromArgb(70, 69, 49)); } }
        public static Colour SlateGrey { get { return new Colour(7015, "Slate Grey", Color.FromArgb(67, 71, 80)); } }
        public static Colour AnthraciteGrey { get { return new Colour(7016, "Anthracite Grey", Color.FromArgb(41, 49, 51)); } }
        public static Colour BlackGrey { get { return new Colour(7021, "Black Grey", Color.FromArgb(35, 40, 43)); } }
        public static Colour UmbraGrey { get { return new Colour(7022, "Umbra Grey", Color.FromArgb(51, 47, 44)); } }
        public static Colour ConcreteGrey { get { return new Colour(7023, "Concrete Grey", Color.FromArgb(104, 108, 94)); } }
        public static Colour GraphiteGrey { get { return new Colour(7024, "Graphite Grey", Color.FromArgb(71, 74, 81)); } }
        public static Colour GraniteGrey { get { return new Colour(7026, "Granite Grey", Color.FromArgb(47, 53, 59)); } }
        public static Colour StoneGrey { get { return new Colour(7030, "Stone Grey", Color.FromArgb(139, 140, 122)); } }
        public static Colour BlueGrey { get { return new Colour(7031, "Blue Grey", Color.FromArgb(71, 75, 78)); } }
        public static Colour PebbleGrey { get { return new Colour(7032, "Pebble Grey", Color.FromArgb(184, 183, 153)); } }
        public static Colour CementGrey { get { return new Colour(7033, "Cement Grey", Color.FromArgb(125, 132, 113)); } }
        public static Colour YellowGrey { get { return new Colour(7034, "Yellow Grey", Color.FromArgb(143, 139, 102)); } }
        public static Colour LightGrey { get { return new Colour(7035, "Light Grey", Color.FromArgb(215, 215, 215)); } }
        public static Colour PlatinumGrey { get { return new Colour(7036, "Platinum Grey", Color.FromArgb(127, 118, 121)); } }
        public static Colour DustyGrey { get { return new Colour(7037, "Dusty Grey", Color.FromArgb(125, 127, 125)); } }
        public static Colour AgateGrey { get { return new Colour(7038, "Agate Grey", Color.FromArgb(195, 195, 195)); } }
        public static Colour QuartzGrey { get { return new Colour(7039, "Quartz Grey", Color.FromArgb(108, 105, 96)); } }
        public static Colour WindowGrey { get { return new Colour(7040, "Window Grey", Color.FromArgb(157, 161, 170)); } }
        public static Colour TrafficGreyA { get { return new Colour(7042, "Traffic Grey A", Color.FromArgb(141, 148, 141)); } }
        public static Colour TrafficGreyB { get { return new Colour(7043, "Traffic Grey B", Color.FromArgb(78, 84, 82)); } }
        public static Colour SilkGrey { get { return new Colour(7044, "Silk Grey", Color.FromArgb(202, 196, 176)); } }
        public static Colour Telegrey1 { get { return new Colour(7045, "Telegrey 1", Color.FromArgb(144, 144, 144)); } }
        public static Colour Telegrey2 { get { return new Colour(7046, "Telegrey 2", Color.FromArgb(130, 137, 143)); } }
        public static Colour Telegrey4 { get { return new Colour(7047, "Telegrey 4", Color.FromArgb(208, 208, 208)); } }
        public static Colour PearlMouseGrey { get { return new Colour(7048, "Pearl Mouse Grey", Color.FromArgb(137, 129, 118)); } }
        public static Colour GreenBrown { get { return new Colour(8000, "Green Brown", Color.FromArgb(130, 108, 52)); } }
        public static Colour OchreBrown { get { return new Colour(8001, "Ochre Brown", Color.FromArgb(149, 95, 32)); } }
        public static Colour SignalBrown { get { return new Colour(8002, "Signal Brown", Color.FromArgb(108, 59, 42)); } }
        public static Colour ClayBrown { get { return new Colour(8003, "Clay Brown", Color.FromArgb(115, 66, 34)); } }
        public static Colour CopperBrown { get { return new Colour(8004, "Copper Brown", Color.FromArgb(142, 64, 42)); } }
        public static Colour FawnBrown { get { return new Colour(8007, "Fawn Brown", Color.FromArgb(89, 53, 31)); } }
        public static Colour OliveBrown { get { return new Colour(8008, "Olive Brown", Color.FromArgb(111, 79, 40)); } }
        public static Colour NutBrown { get { return new Colour(8011, "Nut Brown", Color.FromArgb(91, 58, 41)); } }
        public static Colour RedBrown { get { return new Colour(8012, "Red Brown", Color.FromArgb(89, 35, 33)); } }
        public static Colour SepiaBrown { get { return new Colour(8014, "Sepia Brown", Color.FromArgb(56, 44, 30)); } }
        public static Colour ChestnutBrown { get { return new Colour(8015, "Chestnut Brown", Color.FromArgb(99, 58, 52)); } }
        public static Colour MahoganyBrown { get { return new Colour(8016, "Mahogany Brown", Color.FromArgb(76, 47, 39)); } }
        public static Colour ChocolateBrown { get { return new Colour(8017, "Chocolate Brown", Color.FromArgb(69, 50, 46)); } }
        public static Colour GreyBrown { get { return new Colour(8019, "Grey Brown", Color.FromArgb(64, 58, 58)); } }
        public static Colour BlackBrown { get { return new Colour(8022, "Black Brown", Color.FromArgb(33, 33, 33)); } }
        public static Colour OrangeBrown { get { return new Colour(8023, "Orange Brown", Color.FromArgb(166, 94, 46)); } }
        public static Colour BeigeBrown { get { return new Colour(8024, "Beige Brown", Color.FromArgb(121, 85, 61)); } }
        public static Colour PaleBrown { get { return new Colour(8025, "Pale Brown", Color.FromArgb(117, 92, 72)); } }
        public static Colour TerraBrown { get { return new Colour(8028, "Terra Brown", Color.FromArgb(78, 59, 49)); } }
        public static Colour PearlCopper { get { return new Colour(8029, "Pearl Copper", Color.FromArgb(118, 60, 40)); } }
        public static Colour Cream { get { return new Colour(9001, "Cream", Color.FromArgb(250, 244, 227)); } }
        public static Colour GreyWhite { get { return new Colour(9002, "Grey White", Color.FromArgb(231, 235, 218)); } }
        public static Colour SignalWhite { get { return new Colour(9003, "Signal White", Color.FromArgb(244, 244, 244)); } }
        public static Colour SignalBlack { get { return new Colour(9004, "Signal Black", Color.FromArgb(40, 40, 40)); } }
        public static Colour JetBlack { get { return new Colour(9005, "Jet Black", Color.FromArgb(10, 10, 10)); } }
        public static Colour WhiteAluminium { get { return new Colour(9006, "White Aluminium", Color.FromArgb(165, 165, 165)); } }
        public static Colour GreyAluminium { get { return new Colour(9007, "Grey Aluminium", Color.FromArgb(143, 143, 143)); } }
        public static Colour PureWhite { get { return new Colour(9010, "Pure White", Color.FromArgb(255, 255, 255)); } }
        public static Colour GraphiteBlack { get { return new Colour(9011, "Graphite Black", Color.FromArgb(28, 28, 28)); } }
        public static Colour TrafficWhite { get { return new Colour(9016, "Traffic White", Color.FromArgb(246, 246, 246)); } }
        public static Colour TrafficBlack { get { return new Colour(9017, "Traffic Black", Color.FromArgb(30, 30, 29)); } }
        public static Colour PapyrusWhite { get { return new Colour(9018, "Papyrus White", Color.FromArgb(215, 215, 215)); } }
        public static Colour PearlLightGrey { get { return new Colour(9022, "Pearl Light Grey", Color.FromArgb(156, 156, 156)); } }
        public static Colour PearlDarkGrey { get { return new Colour(9023, "Pearl Dark Grey", Color.FromArgb(130, 130, 130)); } }

    }
}
