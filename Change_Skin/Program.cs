using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;
using EloBuddy.SDK;
using SharpDX;
using SharpDX.Direct3D;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu.Values;

namespace Change_Skin
{
    class Program
    {
        public static Menu ShenMenu;
        private static Menu _skinMenu;
        public static Skin_Champ tuong;

        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += OnLoaded;
        }

        private static void OnLoaded(EventArgs args)
        {
            foreach (var emy in EntityManager.Heroes.Enemies)
            {
                if (emy.ChampionName == "Lulu") return;
            }
            ShenMenu = MainMenu.AddMenu("Change_Skin", "Change_Skin");
            ShenMenu.AddGroupLabel("Change_Skin");
            ShenMenu.AddSeparator();
            ShenMenu.AddLabel("Skin Change Version 1.0.0.0");
            _skinMenu = ShenMenu.AddSubMenu("Skin Changer", "skin");
            _skinMenu.AddGroupLabel("Choose the desired skin");
            #region champion

            switch (Player.Instance.ChampionName)
            {
                case "Aatrox"       :tuong = new Aatrox();      break;
                case "Ahri"         :tuong = new Ahri();        break;
                case "Akali"        :tuong = new Akali();       break;
                case "Alistar"      :tuong = new Alistar();     break;
                case "Amumu"        :tuong = new Amumu();       break;
                case "Anivia"       :tuong = new Anivia();      break;
                case "Annie"        :tuong = new Annie();       break;
                case "Ashe"         :tuong = new Ashe();        break;
                case "Aurelion Sol" :tuong = new Aurelion_Sol();break;
                case "Azir"         :tuong = new Azir();        break;
                case "Bard"         :tuong = new Bard();        break;
                case "Blitzcrank"   :tuong = new Blitzcrank();  break;
                case "Brand"        :tuong = new Brand();       break;
                case "Braum"        :tuong = new Braum();       break;
                case "Caitlyn"      :tuong = new Caitlyn();     break;
                case "Cassiopeia"   :tuong = new Cassiopeia();  break;
                case "Cho'Gath"     :tuong = new ChoGath();     break;
                case "Corki"        :tuong = new Corki();       break;
                case "Darius"       :tuong = new Darius();      break;
                case "Diana"        :tuong = new Diana();       break;
                case "Dr. Mundo"    :tuong = new DrMundo();     break;
                case "Draven"       :tuong = new Draven();      break;
                case "Ekko"         :tuong = new Ekko();        break;
                case "Elise"        :tuong = new Elise();       break;
                case "Evelynn"      :tuong = new Evelynn();     break;
                case "Ezreal"       :tuong = new Ezreal();      break;
                case "Fiddlesticks" :tuong = new Fiddlesticks();break;
                case "Fiora"        :tuong = new Fiora();       break;
                case "Fizz"         :tuong = new Fizz();        break;
                case "Galio"        :tuong = new Galio();       break;
                case "Gangplank"    :tuong = new Gangplank();   break;
                case "Garen"        :tuong = new Garen();       break;
                //case "Gnar"         :tuong = new Gnar();        break;
                case "Gragas"       :tuong = new Gragas();      break;
                case "Graves"       :tuong = new Graves();      break;
                case "Hecarim"      :tuong = new Hecarim();     break;
                case "Heimerdinger" :tuong = new Heimerdinger();break;
                case "Illaoi"       :tuong = new Illaoi();      break;
                case "Irelia"       :tuong = new Irelia();      break;
                case "Janna"        :tuong = new Janna();       break;
                case "Jax"          :tuong = new Jax();         break;
                case "Jayce"        :tuong = new Jayce();       break;
                case "Jhin"         :tuong = new Jhin();        break;
                case "Jinx"         :tuong = new Jinx();        break;
                case "Kalista"      :tuong = new Kalista();     break;
                case "Karma"        :tuong = new Karma();       break;
                case "Karthus"      :tuong = new Karthus();     break;
                case "Kassadin"     :tuong = new Kassadin();    break;
                case "Katarina"     :tuong = new Katarina();    break;
                case "Kayle"        :tuong = new Kayle();       break;
                case "Kennen"       :tuong = new Kennen();      break;
                case "Kha'Zix"      :tuong = new Khazix();      break;
                case "Kindred"      :tuong = new Kindred();     break;
                case "Kog'Maw"      :tuong = new Kogmaw();      break;
                case "LeBlanc"      :tuong = new LeBlanc();     break;
                case "Lee Sin"      :tuong = new Leesin();      break;
                case "Leona"        :tuong = new Leona();       break;
                case "Lissandra"    :tuong = new Lissandra();   break;
                case "Lucian"       :tuong = new Lucian();      break;
                case "Lulu"         :tuong = new Lulu();        break;
                case "Lux"          :tuong = new Lux();         break;
                case "Malphite"     :tuong = new Malphite();    break;
                case "Malzahar"     :tuong = new Malzahar();    break;
                case "Maokai"       :tuong = new Maokai();      break;
                case "Master Yi"    :tuong = new MasterYi();    break;
                case "Miss Fortune" :tuong = new MissFortune(); break;
                case "Mordekaiser"  :tuong = new Mordekaiser(); break;
                case "Morgana"      :tuong = new Morgana();     break;
                case "Nami"         :tuong = new Nami();        break;
                case "Nasus"        :tuong = new Nasus();       break;
                case "Nautilus"     :tuong = new Nautilus();    break;
                //case "Nidalee"      :tuong = new Nidalee();     break;
                case "Nocturne"     :tuong = new Noctume();     break;
                case "Nunu"         :tuong = new Nunu();        break;
                case "Olaf"         :tuong = new Olaf();        break;
                case "Orianna"      :tuong = new Orianna();     break;
                case "Pantheon"     :tuong = new Pantheon();    break;
                case "Poppy"        :tuong = new Poppy();       break;
                case "Quinn"        :tuong = new Quinn();       break;
                case "Rammus"       :tuong = new Rammus();      break;
                case "Rek'Sai"      :tuong = new RekSai();      break;
                case "Renekton"     :tuong = new Renekton();    break;
                case "Rengar"       :tuong = new Rengar();      break;
                case "Riven"        :tuong = new Riven();       break;
                case "Rumble"       :tuong = new Rumble();      break;
                case "Ryze"         :tuong = new Ryze();        break;
                case "Sejuani"      :tuong = new Sejuani();     break;
                case "Shaco"        :tuong = new Shaco();       break;
                case "Shen"         :tuong = new Shen();        break;
                case "Shyvana"      :tuong = new Shyvana();     break;
                case "Singed"       :tuong = new Singed();      break;
                case "Sion"         :tuong = new Sion();        break;
                case "Sivir"        :tuong = new Sivir();       break;
                case "Skarner"      :tuong = new Skarner();     break;
                case "Sona"         :tuong = new Sona();        break;
                case "Soraka"       :tuong = new Soraka();      break;
                case "Swain"        :tuong = new Swain();       break;
                case "Syndra"       :tuong = new Syndra();      break;
                case "Tahm Kench"   :tuong = new TahmKench();   break;
                case "Taliyah"      :tuong = new Taliyah();     break;
                case "Talon"        :tuong = new Talon();       break;
                case "Taric"        :tuong = new Taric();       break;
                case "Teemo"        :tuong = new Teemo();       break;
                case "Thresh"       :tuong = new Thresh();      break;
                case "Tristana"     :tuong = new Tristana();    break;
                case "Trundle"      :tuong = new Trundle();     break;
                case "Tryndamere"   :tuong = new Tryndamere();  break;
                case "Twisted Fate" :tuong = new TwistedFate(); break;
                case "Twitch"       :tuong = new Twitch();      break;
                case "Udyr"         :tuong = new Udyr();        break;
                case "Urgot"        :tuong = new Urgot();       break;
                case "Varus"        :tuong = new Varus();       break;
                case "Vayne"        :tuong = new Vayne();       break;
                case "Veigar"       :tuong = new Veigar();      break;
                case "Vel'Koz"      :tuong = new VelKoz();      break;
                case "Vi"           :tuong = new Vi();          break;
                case "Viktor"       :tuong = new Viktor();      break;
                case "Vladimir"     :tuong = new Vladimir();    break;
                case "Volibear"     :tuong = new Volibear();    break;
                case "Warwick"      :tuong = new Warwick();     break;
                case "Wukong"       :tuong = new Wukong();      break;
                case "Xerath"       :tuong = new Xerath();      break;
                case "Xin Zhao"     :tuong = new Xinzhao();     break;
                case "Yasuo"        :tuong = new Yasuo();       break;
                case "Yorick"       :tuong = new Yorick();      break;
                case "Zac"          :tuong = new Zac();         break;
                case "Zed"          :tuong = new Zed();         break;
                case "Ziggs"        :tuong = new Ziggs();       break;
                case "Zilean"       :tuong = new Zilean();      break;
                case "Zyra"         :tuong = new Zyra();        break; 
            }
            #endregion 

            switch (Player.Instance.Hero)
            {
                case Champion.DrMundo: tuong = new DrMundo(); break;
                case Champion.Khazix: tuong = new Khazix(); break;
                case Champion.KogMaw: tuong = new Kogmaw(); break;
                case Champion.AurelionSol: tuong = new Aurelion_Sol(); break;
                case Champion.JarvanIV: tuong = new Javan(); break;
                case Champion.MasterYi: tuong = new MasterYi(); break;
                case Champion.MissFortune: tuong = new MissFortune(); break;
                case Champion.MonkeyKing: tuong = new Wukong(); break;
                case Champion.RekSai: tuong = new RekSai(); break;
                case Champion.TahmKench: tuong = new TahmKench(); break;
                case Champion.TwistedFate: tuong = new TwistedFate(); break;
                case Champion.Velkoz: tuong = new VelKoz(); break;
            }
            var skinchange = _skinMenu.Add("sID", tuong.getSlider());
            var sid = tuong.getlistskin();
            skinchange.DisplayName = sid[skinchange.CurrentValue];
            skinchange.OnValueChange +=
                delegate(ValueBase<int> sender, ValueBase<int>.ValueChangeArgs changeArgs)
                {
                    sender.DisplayName = sid[changeArgs.NewValue];
                };
            Game.OnUpdate += OnUpdate;
        }
        private static void OnUpdate(EventArgs args)
        {
            tuong.SkinChange(_skinMenu);
        }
        
    }
}
