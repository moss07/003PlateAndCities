using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003PlateAndCities
{
    class Program
    {
        #region Cities / First Way with enum
        enum City
        {
            Adana=01,
            Adıyaman=02,
            Afyonkarahisar=03,
            Ağrı=04,
            Amasya=05,
            Ankara=06,
            Antalya=07,
            Artvin=08,
            Aydın=09,
            Balıkesir,
            Bilecik,
            Bitlis,
            Bingöl,
            Bolu,
            Burdur,
            Bursa,
            Çanakkale,
            Çankırı,
            Çorum,
            Denizli,
            Diyarbakır,
            Edirne,
            Elazığ,
            Erzincan,
            Erzurum,
            Eskişehir,
            Gaziantep,
            Giresun,
            Gümüşhane,
            Hakkari,
            Hatay,
            Isparta,
            Mersin,
            İstanbul,
            İzmir,
            Kars,
            Kastamonu,
            Kayseri,
            Kırklareli,
            Kırşehir,
            Kocaeli,
            Konya,
            Kütahya,
            Malatya,
            Manisa,
            Kahramanmaraş,
            Mardin,
            Muğla,
            Muş,
            Nevşehir,
            Niğde,
            Ordu,
            Rize,
            Sakarya,
            Samsun,
            Siirt,
            Sinop,
            Sivas,
            Tekirdağ,
            Tokat,
            Trabzon,
            Tunceli,
            Şanlıurfa,
            Uşak,
            Van,
            Yozgat,
            Zonguldak,
            Aksaray,
            Bayburt,
            Karaman,
            Kırıkkale,
            Batman,
            Şırnak,
            Bartın,
            Ardahan,
            Iğdır,
            Yalova,
            Karabük,
            Kilis,
            Osmaniye,
            Düzce
        }
         
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("*** Please choose between 01-81 plate codes ***");
            byte plateNumber = byte.Parse(Console.ReadLine());
            Console.WriteLine(Enum.GetName(typeof(City), plateNumber));

            #region Second Way with if
            if (plateNumber==1 || plateNumber==01)
                Console.WriteLine("Adana");
            else if(plateNumber==2 || plateNumber == 02)
                Console.WriteLine("Adıyaman");
            else if(plateNumber==3 || plateNumber == 03)
                Console.WriteLine("Afyonkarahisar");
            else if (plateNumber == 4 || plateNumber == 04)
                Console.WriteLine("Ağrı");
            else if (plateNumber == 5 || plateNumber == 05)
                Console.WriteLine("Amasya");
            else if (plateNumber == 6 || plateNumber == 06)
                Console.WriteLine("Ankara");
            else if (plateNumber == 7 || plateNumber == 07)
                Console.WriteLine("Antalya");
            else if (plateNumber == 8 || plateNumber == 08)
                Console.WriteLine("Artvin");
            else if (plateNumber == 9 || plateNumber == 09)
                Console.WriteLine("Aydın");
            else if (plateNumber == 10)
                Console.WriteLine("Balıkesir");
            else if (plateNumber == 11)
                Console.WriteLine("Bilecik");
            else if (plateNumber == 12)
                Console.WriteLine("Bingöl");
            else if (plateNumber == 13)
                Console.WriteLine("Bitlis");
            else if (plateNumber == 14)
                Console.WriteLine("Bolu");
            else if (plateNumber == 15)
                Console.WriteLine("Burdur");
            else if (plateNumber == 16)
                Console.WriteLine("Bursa");
            else if (plateNumber == 17)
                Console.WriteLine("Çanakkale");
            else if (plateNumber == 18)
                Console.WriteLine("Çankırı");
            else if (plateNumber == 19)
                Console.WriteLine("Çorum");
            else if (plateNumber == 20)
                Console.WriteLine("Denizli");
            else if (plateNumber == 21)
                Console.WriteLine("Diyarbakır");
            else if (plateNumber == 22)
                Console.WriteLine("Edirne");
            else if (plateNumber == 23)
                Console.WriteLine("Elazığ");
            else if (plateNumber == 24)
                Console.WriteLine("Erzincan");
            else if (plateNumber == 25)
                Console.WriteLine("Erzurum");
            else if (plateNumber == 26)
                Console.WriteLine("Eskişehir");
            else if (plateNumber == 27)
                Console.WriteLine("Gaziantep");
            else if (plateNumber == 28)
                Console.WriteLine("Giresun");
            else if (plateNumber == 29)
                Console.WriteLine("Gümüşhane");
            else if (plateNumber == 30)
                Console.WriteLine("Hakkari");
            else if (plateNumber == 31)
                Console.WriteLine("Hatay");
            else if (plateNumber == 32)
                Console.WriteLine("Isparta");
            else if (plateNumber == 33)
                Console.WriteLine("Mersin");
            else if (plateNumber == 34)
                Console.WriteLine("İstanbul");
            else if (plateNumber == 35)
                Console.WriteLine("İzmir");
            else if (plateNumber == 36)
                Console.WriteLine("Kars");
            else if (plateNumber == 37)
                Console.WriteLine("Kastamonu");
            else if (plateNumber == 38)
                Console.WriteLine("Kayseri");
            else if (plateNumber == 39)
                Console.WriteLine("Kırklareli");
            else if (plateNumber == 40)
                Console.WriteLine("Kırşehir");
            else if (plateNumber == 41)
                Console.WriteLine("Kocaeli");
            else if (plateNumber == 42)
                Console.WriteLine("Konya");
            else if (plateNumber == 43)
                Console.WriteLine("Kütahya");
            else if (plateNumber == 44)
                Console.WriteLine("Malatya");
            else if (plateNumber == 45)
                Console.WriteLine("Manisa");
            else if (plateNumber == 46)
                Console.WriteLine("Kahramanmaraş");
            else if (plateNumber == 47)
                Console.WriteLine("Mardin");
            else if (plateNumber == 48)
                Console.WriteLine("Muğla");
            else if (plateNumber == 49)
                Console.WriteLine("Muş");
            else if (plateNumber == 50)
                Console.WriteLine("Nevşehir");
            else if (plateNumber == 51)
                Console.WriteLine("Niğde");
            else if (plateNumber == 52)
                Console.WriteLine("Ordu");
            else if (plateNumber == 53)
                Console.WriteLine("Rize");
            else if (plateNumber == 54)
                Console.WriteLine("Sakarya");
            else if (plateNumber == 55)
                Console.WriteLine("Samsun");
            else if (plateNumber == 56)
                Console.WriteLine("Siirt");
            else if (plateNumber == 57)
                Console.WriteLine("Sinop");
            else if (plateNumber == 58)
                Console.WriteLine("Sivas");
            else if (plateNumber == 59)
                Console.WriteLine("Tekirdağ");
            else if (plateNumber == 60)
                Console.WriteLine("Tokat");
            else if (plateNumber == 61)
                Console.WriteLine("Trabzon");
            else if (plateNumber == 62)
                Console.WriteLine("Tunceli");
            else if (plateNumber == 63)
                Console.WriteLine("Şanlıurfa");
            else if (plateNumber == 64)
                Console.WriteLine("Uşak");
            else if (plateNumber == 65)
                Console.WriteLine("Van");
            else if (plateNumber == 66)
                Console.WriteLine("Yozgat");
            else if (plateNumber == 67)
                Console.WriteLine("Zonguldak");
            else if (plateNumber == 68)
                Console.WriteLine("Aksaray");
            else if (plateNumber == 69)
                Console.WriteLine("Bayburt");
            else if (plateNumber == 70)
                Console.WriteLine("Karaman");
            else if (plateNumber == 71)
                Console.WriteLine("Kırıkkale");
            else if (plateNumber == 72)
                Console.WriteLine("Batman");
            else if (plateNumber == 73)
                Console.WriteLine("Şırnak");
            else if (plateNumber == 74)
                Console.WriteLine("Bartın");
            else if (plateNumber == 75)
                Console.WriteLine("Ardahan");
            else if (plateNumber == 76)
                Console.WriteLine("Iğdır");
            else if (plateNumber == 77)
                Console.WriteLine("Yalova");
            else if (plateNumber == 78)
                Console.WriteLine("Karabük");
            else if (plateNumber == 79)
                Console.WriteLine("Kilis");
            else if (plateNumber == 80)
                Console.WriteLine("Osmaniye");
            else if (plateNumber == 81)
                Console.WriteLine("Düzce");
            else
                Console.WriteLine("*** Please write correct number ***");
            #endregion

            #region Third Way with switch
            string input = Console.ReadLine();
            string output;

            switch (input)
            {
                case "01":
                    output = "Adana";
                    break;
                case "02":
                    output = "Adıyaman";
                    break;
                case "03":
                    output = "Afyonkarahisar";
                    break;
                case "04":
                    output = "Ağrı";
                    break;
                case "05":
                    output = "Amasya";
                    break;
                case "06":
                    output = "Ankara";
                    break;
                case "07":
                    output = "Antalya";
                    break;
                case "08":
                    output = "Artvin";
                    break;
                case "09":
                    output = "Aydın";
                    break;
                case "10":
                    output = "Balıkesir";
                    break;
                case "11":
                    output = "Bilecik";
                    break;
                case "12":
                    output = "Bingöl";
                    break;
                case "13":
                    output = "Bitlis";
                    break;
                case "14":
                    output = "Bolu";
                    break;
                case "15":
                    output = "Burdur";
                    break;
                case "16":
                    output = "Bursa";
                    break;
                case "17":
                    output = "Çanakkale";
                    break;
                case "18":
                    output = "Çankırı";
                    break;
                case "19":
                    output = "Çorum";
                    break;
                case "20":
                    output = "Denizli";
                    break;
                case "21":
                    output = "Diyarbakır";
                    break;
                case "22":
                    output = "Edirne";
                    break;
                case "23":
                    output = "Elazığ";
                    break;
                case "24":
                    output = "Erzincan";
                    break;
                case "25":
                    output = "Erzurum";
                    break;
                case "26":
                    output = "Eskişehir";
                    break;
                case "27":
                    output = "Gaziantep";
                    break;
                case "28":
                    output = "Giresun";
                    break;
                case "29":
                    output = "Gümüşhane";
                    break;
                case "30":
                    output = "Hakkari";
                    break;
                case "31":
                    output = "Hatay";
                    break;
                case "32":
                    output = "Isparta";
                    break;
                case "33":
                    output = "Mersin";
                    break;
                case "34":
                    output = "İstanbul";
                    break;
                case "35":
                    output = "İzmir";
                    break;
                case "36":
                    output = "Kars";
                    break;
                case "37":
                    output = "Kastamonu";
                    break;
                case "38":
                    output = "Kayseri";
                    break;
                case "39":
                    output = "Kırklareli";
                    break;
                case "40":
                    output = "Kırşehir";
                    break;
                case "41":
                    output = "Kocaeli";
                    break;
                case "42":
                    output = "Konya";
                    break;
                case "43":
                    output = "Kütahya";
                    break;
                case "44":
                    output = "Malatya";
                    break;
                case "45":
                    output = "Manisa";
                    break;
                case "46":
                    output = "Kahramanmaraş";
                    break;
                case "47":
                    output = "Mardin";
                    break;
                case "48":
                    output = "Muğla";
                    break;
                case "49":
                    output = "Muş";
                    break;
                case "50":
                    output = "Nevşehir";
                    break;
                case "51":
                    output = "Niğde";
                    break;
                case "52":
                    output = "Ordu";
                    break;
                case "53":
                    output = "Rize";
                    break;
                case "54":
                    output = "Sakarya";
                    break;
                case "55":
                    output = "Samsun";
                    break;
                case "56":
                    output = "Siirt";
                    break;
                case "57":
                    output = "Sinop";
                    break;
                case "58":
                    output = "Sivas";
                    break;
                case "59":
                    output = "Tekirdağ";
                    break;
                case "60":
                    output = "Tokat";
                    break;
                case "61":
                    output = "Trabzon";
                    break;
                case "62":
                    output = "Tunceli";
                    break;
                case "63":
                    output = "Şanlıurfa";
                    break;
                case "64":
                    output = "Uşak";
                    break;
                case "65":
                    output = "Van";
                    break;
                case "66":
                    output = "Yozgat";
                    break;
                case "67":
                    output = "Zonguldak";
                    break;
                case "68":
                    output = "Aksaray";
                    break;
                case "69":
                    output = "Bayburt";
                    break;
                case "70":
                    output = "Karaman";
                    break;
                case "71":
                    output = "Kırıkkale";
                    break;
                case "72":
                    output = "Batman";
                    break;
                case "73":
                    output = "Şırnak";
                    break;
                case "74":
                    output = "Bartın";
                    break;
                case "75":
                    output = "Ardahan";
                    break;
                case "76":
                    output = "Iğdır";
                    break;
                case "77":
                    output = "Yalova";
                    break;
                case "78":
                    output = "Karabük";
                    break;
                case "79":
                    output = "Kilis";
                    break;
                case "80":
                    output = "Osmaniye";
                    break;
                case "81":
                    output = "Düzce";
                    break;
                default:
                    output = "*** Please write correct number ***";
                    break;
            }

            #endregion

            #region Fourth Way with Array

            string[,] PlakaVeSehirlerBaslik = new string[1, 2];
            PlakaVeSehirlerBaslik[0, 0] = "Plakalar";
            PlakaVeSehirlerBaslik[0, 1] = "Şehirler";

            string baslik = "";
            for (int i = 0; i <= PlakaVeSehirlerBaslik.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= PlakaVeSehirlerBaslik.GetUpperBound(1); j++)
                {
                    baslik += PlakaVeSehirlerBaslik[i, j] + "\t";
                }
            }

            Console.Write(baslik);

            string[,] plakalarVeSehirler = new string[82, 2];
            plakalarVeSehirler[0, 0] = "";
            plakalarVeSehirler[0, 1] = "";
            plakalarVeSehirler[1, 0] = "01";
            plakalarVeSehirler[1, 1] = "Adana";
            plakalarVeSehirler[2, 0] = "02";
            plakalarVeSehirler[2, 1] = "Adıyaman";
            plakalarVeSehirler[3, 0] = "03";
            plakalarVeSehirler[3, 1] = "Afyon";
            plakalarVeSehirler[4, 0] = "04";
            plakalarVeSehirler[4, 1] = "Ağrı";
            plakalarVeSehirler[5, 0] = "05";
            plakalarVeSehirler[5, 1] = "Amasya";
            plakalarVeSehirler[6, 0] = "06";
            plakalarVeSehirler[6, 1] = "Ankara";
            plakalarVeSehirler[7, 0] = "07";
            plakalarVeSehirler[7, 1] = "Antalya";
            plakalarVeSehirler[8, 0] = "08";
            plakalarVeSehirler[8, 1] = "Artvin";
            plakalarVeSehirler[9, 0] = "09";
            plakalarVeSehirler[9, 1] = "Aydın";
            plakalarVeSehirler[10, 0] = "10";
            plakalarVeSehirler[10, 1] = "Balıkesir";
            plakalarVeSehirler[11, 0] = "11";
            plakalarVeSehirler[11, 1] = "Bilecik";
            plakalarVeSehirler[12, 0] = "12";
            plakalarVeSehirler[12, 1] = "Bitlis";
            plakalarVeSehirler[13, 0] = "13";
            plakalarVeSehirler[13, 1] = "Bingöl";
            plakalarVeSehirler[14, 0] = "14";
            plakalarVeSehirler[14, 1] = "Bolu";
            plakalarVeSehirler[15, 0] = "15";
            plakalarVeSehirler[15, 1] = "Burdur";
            plakalarVeSehirler[16, 0] = "16";
            plakalarVeSehirler[16, 1] = "Bursa";
            plakalarVeSehirler[17, 0] = "17";
            plakalarVeSehirler[17, 1] = "Çanakkale";
            plakalarVeSehirler[18, 0] = "18";
            plakalarVeSehirler[18, 1] = "Çankırı";
            plakalarVeSehirler[19, 0] = "19";
            plakalarVeSehirler[19, 1] = "Çorum";
            plakalarVeSehirler[20, 0] = "20";
            plakalarVeSehirler[20, 1] = "Denizli";
            plakalarVeSehirler[21, 0] = "21";
            plakalarVeSehirler[21, 1] = "Diyarbakır";
            plakalarVeSehirler[22, 0] = "22";
            plakalarVeSehirler[22, 1] = "Edirne";
            plakalarVeSehirler[23, 0] = "23";
            plakalarVeSehirler[23, 1] = "Elazığ";
            plakalarVeSehirler[24, 0] = "24";
            plakalarVeSehirler[24, 1] = "Erzincan";
            plakalarVeSehirler[25, 0] = "25";
            plakalarVeSehirler[25, 1] = "Erzurum";
            plakalarVeSehirler[26, 0] = "26";
            plakalarVeSehirler[26, 1] = "Eskişehir";
            plakalarVeSehirler[27, 0] = "27";
            plakalarVeSehirler[27, 1] = "Gaziantep";
            plakalarVeSehirler[28, 0] = "28";
            plakalarVeSehirler[28, 1] = "Giresun";
            plakalarVeSehirler[29, 0] = "29";
            plakalarVeSehirler[29, 1] = "Gümüşhane";
            plakalarVeSehirler[30, 0] = "30";
            plakalarVeSehirler[30, 1] = "Hakkari";
            plakalarVeSehirler[31, 0] = "31";
            plakalarVeSehirler[31, 1] = "Hatay";
            plakalarVeSehirler[32, 0] = "32";
            plakalarVeSehirler[32, 1] = "Isparta";
            plakalarVeSehirler[33, 0] = "33";
            plakalarVeSehirler[33, 1] = "Mersin";
            plakalarVeSehirler[34, 0] = "34";
            plakalarVeSehirler[34, 1] = "İstanbul";
            plakalarVeSehirler[35, 0] = "35";
            plakalarVeSehirler[35, 1] = "İzmir";
            plakalarVeSehirler[36, 0] = "36";
            plakalarVeSehirler[36, 1] = "Kars";
            plakalarVeSehirler[37, 0] = "37";
            plakalarVeSehirler[37, 1] = "Kastamonu";
            plakalarVeSehirler[38, 0] = "38";
            plakalarVeSehirler[38, 1] = "Kayseri";
            plakalarVeSehirler[39, 0] = "39";
            plakalarVeSehirler[39, 1] = "Kırklareli";
            plakalarVeSehirler[40, 0] = "40";
            plakalarVeSehirler[40, 1] = "Kırşehir";
            plakalarVeSehirler[41, 0] = "41";
            plakalarVeSehirler[41, 1] = "Kocaeli";
            plakalarVeSehirler[42, 0] = "42";
            plakalarVeSehirler[42, 1] = "Konya";
            plakalarVeSehirler[43, 0] = "43";
            plakalarVeSehirler[43, 1] = "Kütahya";
            plakalarVeSehirler[44, 0] = "44";
            plakalarVeSehirler[44, 1] = "Malatya";
            plakalarVeSehirler[45, 0] = "45";
            plakalarVeSehirler[45, 1] = "Manisa";
            plakalarVeSehirler[46, 0] = "46";
            plakalarVeSehirler[46, 1] = "Kahramanmaraş";
            plakalarVeSehirler[47, 0] = "47";
            plakalarVeSehirler[47, 1] = "Mardin";
            plakalarVeSehirler[48, 0] = "48";
            plakalarVeSehirler[48, 1] = "Muğla";
            plakalarVeSehirler[49, 0] = "49";
            plakalarVeSehirler[49, 1] = "Muş";
            plakalarVeSehirler[50, 0] = "50";
            plakalarVeSehirler[50, 1] = "Nevşehir";
            plakalarVeSehirler[51, 0] = "51";
            plakalarVeSehirler[51, 1] = "Niğde";
            plakalarVeSehirler[52, 0] = "52";
            plakalarVeSehirler[52, 1] = "Ordu";
            plakalarVeSehirler[53, 0] = "53";
            plakalarVeSehirler[53, 1] = "Rize";
            plakalarVeSehirler[54, 0] = "54";
            plakalarVeSehirler[54, 1] = "Sakarya";
            plakalarVeSehirler[55, 0] = "55";
            plakalarVeSehirler[55, 1] = "Samsun";
            plakalarVeSehirler[56, 0] = "56";
            plakalarVeSehirler[56, 1] = "Siirt";
            plakalarVeSehirler[57, 0] = "57";
            plakalarVeSehirler[57, 1] = "Sinop";
            plakalarVeSehirler[58, 0] = "58";
            plakalarVeSehirler[58, 1] = "Sivas";
            plakalarVeSehirler[59, 0] = "59";
            plakalarVeSehirler[59, 1] = "Tekirdağ";
            plakalarVeSehirler[60, 0] = "60";
            plakalarVeSehirler[60, 1] = "Tokat";
            plakalarVeSehirler[61, 0] = "61";
            plakalarVeSehirler[61, 1] = "Trabzon";
            plakalarVeSehirler[62, 0] = "62";
            plakalarVeSehirler[62, 1] = "Tunceli";
            plakalarVeSehirler[63, 0] = "63";
            plakalarVeSehirler[63, 1] = "Şanlıurfa";
            plakalarVeSehirler[64, 0] = "64";
            plakalarVeSehirler[64, 1] = "Uşak";
            plakalarVeSehirler[65, 0] = "65";
            plakalarVeSehirler[65, 1] = "Van";
            plakalarVeSehirler[66, 0] = "66";
            plakalarVeSehirler[66, 1] = "Yozgat";
            plakalarVeSehirler[67, 0] = "67";
            plakalarVeSehirler[67, 1] = "Zonguldak";
            plakalarVeSehirler[68, 0] = "68";
            plakalarVeSehirler[68, 1] = "Aksaray";
            plakalarVeSehirler[69, 0] = "69";
            plakalarVeSehirler[69, 1] = "Bayburt";
            plakalarVeSehirler[70, 0] = "70";
            plakalarVeSehirler[70, 1] = "Karaman";
            plakalarVeSehirler[71, 0] = "71";
            plakalarVeSehirler[71, 1] = "Kırıkkale";
            plakalarVeSehirler[72, 0] = "72";
            plakalarVeSehirler[72, 1] = "Batman";
            plakalarVeSehirler[73, 0] = "73";
            plakalarVeSehirler[73, 1] = "Şırnak";
            plakalarVeSehirler[74, 0] = "74";
            plakalarVeSehirler[74, 1] = "Bartın";
            plakalarVeSehirler[75, 0] = "75";
            plakalarVeSehirler[75, 1] = "Ardahan";
            plakalarVeSehirler[76, 0] = "76";
            plakalarVeSehirler[76, 1] = "Iğdır";
            plakalarVeSehirler[77, 0] = "77";
            plakalarVeSehirler[77, 1] = "Yalova";
            plakalarVeSehirler[78, 0] = "78";
            plakalarVeSehirler[78, 1] = "Karabük";
            plakalarVeSehirler[79, 0] = "79";
            plakalarVeSehirler[79, 1] = "Kilis";
            plakalarVeSehirler[80, 0] = "80";
            plakalarVeSehirler[80, 1] = "Osmaniye";
            plakalarVeSehirler[81, 0] = "81";
            plakalarVeSehirler[81, 1] = "Düzce";

            string pVs = "";
            for (int i = 0; i <= plakalarVeSehirler.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= plakalarVeSehirler.GetUpperBound(1); j++)
                {
                    pVs += plakalarVeSehirler[i, j] + "\t" + "\t";
                }
                pVs += "\n";
            }
            Console.Write(pVs);


            #endregion

            Console.ReadLine();
        }
    }
}
