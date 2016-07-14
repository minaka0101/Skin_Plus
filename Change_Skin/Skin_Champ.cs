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
    interface Skin_Champ
    {
        void SkinChange(Menu _skinMenu);
        string[] getlistskin();
        Slider getSlider();
    }
    #region 1A

    public class Aatrox : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Justicar Aatrox", "Mecha Aatrox", "Sea Hunter Aatrox"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Justicar Aatrox":
                    Player.SetSkinId(1);
                    break;
                case "Mecha Aatrox":
                    Player.SetSkinId(2);
                    break;
                case "Sea Hunter Aatrox":
                    Player.SetSkinId(3);
                    break;
            }
        }
        
    }

    public class Ahri : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 5, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Dynasty", "Midnight", "Foxfire", "Popstar" , "Challenger" , "Academy"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Dynasty":
                    Player.SetSkinId(1);
                    break;
                case "Midnight":
                    Player.SetSkinId(2);
                    break;
                case "Foxfire":
                    Player.SetSkinId(3);
                    break;
                case "Popstar":
                    Player.SetSkinId(4);
                    break;
                case "Challenger":
                    Player.SetSkinId(5);
                    break;
                case "Academy":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class Akali : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 7, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Stinger", "Crimson", "All-Star", "Nurse", "Blood Moon", "Silverfang", "Headhunter"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Stinger":
                    Player.SetSkinId(1);
                    break;
                case "Crimson":
                    Player.SetSkinId(2);
                    break;
                case "All-Star":
                    Player.SetSkinId(3);
                    break;
                case "Nurse":
                    Player.SetSkinId(4);
                    break;
                case "Blood Moon":
                    Player.SetSkinId(5);
                    break;
                case "Silverfang":
                    Player.SetSkinId(6);
                    break;
                case "Headhunter":
                    Player.SetSkinId(7);
                    break;
                    
            }
        }

    }

    public class Alistar : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 8, 0, 8);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Black", "Golden", "Matador", "Longhorn", "Unchained", "Infernal", "Sweeper", "Marauder"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Black":
                    Player.SetSkinId(1);
                    break;
                case "Golden":
                    Player.SetSkinId(2);
                    break;
                case "Matador":
                    Player.SetSkinId(3);
                    break;
                case "Longhorn":
                    Player.SetSkinId(4);
                    break;
                case "Unchained":
                    Player.SetSkinId(5);
                    break;
                case "Infernal":
                    Player.SetSkinId(6);
                    break;
                case "Sweeper":
                    Player.SetSkinId(7);
                    break;
                case "Marauder":
                    Player.SetSkinId(8);
                    break;
            }
        }

    }

    public class Amumu : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 4, 0, 8);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Pharaoh", "Vancouver", "Emumu", "Re-Gifted", "Almost-Prom", "Little Knight", "Sad Robot", "Surprise Party"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Pharaoh":
                    Player.SetSkinId(1);
                    break;
                case "Vancouver":
                    Player.SetSkinId(2);
                    break;
                case "Emumu":
                    Player.SetSkinId(3);
                    break;
                case "Re-Gifted":
                    Player.SetSkinId(4);
                    break;
                case "Almost-Prom":
                    Player.SetSkinId(5);
                    break;
                case "Little Knight":
                    Player.SetSkinId(6);
                    break;
                case "Sad Robot":
                    Player.SetSkinId(7);
                    break;
                case "Surprise Party":
                    Player.SetSkinId(8);
                    break;
            }
        }

    }

    public class Anivia : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 4, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Team Spirit", "Bird Of Prey", "Noxus Hunter", "Hextech", "Blackfrost", "Prehistoric"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Team Spirit":
                    Player.SetSkinId(1);
                    break;
                case "Bird Of Prey":
                    Player.SetSkinId(2);
                    break;
                case "Noxus Hunter":
                    Player.SetSkinId(3);
                    break;
                case "Hextech":
                    Player.SetSkinId(4);
                    break;
                case "Blackfrost":
                    Player.SetSkinId(5);
                    break;
                case "Prehistoric":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class Annie : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 10, 0, 10);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Goth", "Red Riding", "Annie in Wonderland", "Prom Queen", "Frostfine", "Reverse", "FrankenTibbers", "Panda", "Sweetheart", "Hextech"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Goth":
                    Player.SetSkinId(1);
                    break;
                case "Red Riding":
                    Player.SetSkinId(2);
                    break;
                case "Annie in Wonderland":
                    Player.SetSkinId(3);
                    break;
                case "Prom Queen":
                    Player.SetSkinId(4);
                    break;
                case "Frostfine":
                    Player.SetSkinId(5);
                    break;
                case "Reverse":
                    Player.SetSkinId(6);
                    break;
                case "FrankenTibbers":
                    Player.SetSkinId(7);
                    break;
                case "Panda":
                    Player.SetSkinId(8);
                    break;
                case "Sweetheart":
                    Player.SetSkinId(9);
                    break;
                case "Hextech":
                    Player.SetSkinId(10);
                    break;
            }
        }

    }

    public class Ashe : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 6, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Freljord", "Sherwood", "Woad", "Queen", "Amethyst", "Heartseeker", "Marauder"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Freljord":
                    Player.SetSkinId(1);
                    break;
                case "Sherwood":
                    Player.SetSkinId(2);
                    break;
                case "Woad":
                    Player.SetSkinId(3);
                    break;
                case "Queen":
                    Player.SetSkinId(4);
                    break;
                case "Amethyst":
                    Player.SetSkinId(5);
                    break;
                case "Heartseeker":
                    Player.SetSkinId(6);
                    break;
                case "Marauder":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    public class Aurelion_Sol : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 1, 0, 1);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Ashen Lord"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Ashen Lord":
                    Player.SetSkinId(1);
                    break;
            }
        }

    }

    public class Azir : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 2);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Galactic", "GraveLord"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Galactic":
                    Player.SetSkinId(1);
                    break;
                case "GraveLord":
                    Player.SetSkinId(2);
                    break;
            }
        }

    }

    #endregion

    #region 2B

    public class Bard : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 2);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Elderwood", "Snow Day"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Elderwood":
                    Player.SetSkinId(1);
                    break;
                case "Snow Day":
                    Player.SetSkinId(2);
                    break;
            }
        }

    }

    public class Blitzcrank : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 8, 0, 8);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Rusty", "GoalKeeper", "Boom Boom", "Pittover Customs", "Definitely Not Blitzcank", "iBlitzcrank", "Riot", "Battle Boss"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Rusty":
                    Player.SetSkinId(1);
                    break;
                case "GoalKeeper":
                    Player.SetSkinId(2);
                    break;
                case "Boom Boom":
                    Player.SetSkinId(3);
                    break;
                case "Pittover Customs":
                    Player.SetSkinId(4);
                    break;
                case "Definitely Not Blitzcank":
                    Player.SetSkinId(5);
                    break;
                case "iBlitzcrank":
                    Player.SetSkinId(6);
                    break;
                case "Riot":
                    Player.SetSkinId(7);
                    break;
                case "Battle Boss":
                    Player.SetSkinId(8);
                    break;
            }
        }

    }

    public class Brand : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 5, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Apocalyptic", "Vandal", "Cryocore", "Zombie", "Spirit Fire"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Apocalyptic":
                    Player.SetSkinId(1);
                    break;
                case "Vandal":
                    Player.SetSkinId(2);
                    break;
                case "Cryocore":
                    Player.SetSkinId(3);
                    break;
                case "Zombie":
                    Player.SetSkinId(4);
                    break;
                case "Spirit Fire":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Braum : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 1, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Dragonslayer", "El Tigre", "Lionheart"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Dragonslayer":
                    Player.SetSkinId(1);
                    break;
                case "El Tigre":
                    Player.SetSkinId(2);
                    break;
                case "Lionheart":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    #endregion

    #region 3C

    public class Caitlyn : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 6, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Resistance", "Sheriff", "Safari", "Arctic Warfare", "Officer", "HeadHunter", "Lunar Wraith"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Resistance":
                    Player.SetSkinId(1);
                    break;
                case "Sheriff":
                    Player.SetSkinId(2);
                    break;
                case "Safari":
                    Player.SetSkinId(3);
                    break;
                case "Arctic Warfare":
                    Player.SetSkinId(4);
                    break;
                case "Officer":
                    Player.SetSkinId(5);
                    break;
                case "HeadHunter":
                    Player.SetSkinId(6);
                    break;
                case "Lunar Wraith":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    public class Cassiopeia : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 4, 0, 4);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Desperada", "Siren", "Mythic", "Jade Fang"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Desperada":
                    Player.SetSkinId(1);
                    break;
                case "Siren":
                    Player.SetSkinId(2);
                    break;
                case "Mythic":
                    Player.SetSkinId(3);
                    break;
                case "Jade Fang":
                    Player.SetSkinId(4);
                    break;
            }
        }

    }

    public class ChoGath : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 5, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Nightmare", "Gentleman", "Loch Ness", "Jurassic", "Battlecast Prime", "Prehistoric"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Nightmare":
                    Player.SetSkinId(1);
                    break;
                case "Gentleman":
                    Player.SetSkinId(2);
                    break;
                case "Loch Ness":
                    Player.SetSkinId(3);
                    break;
                case "Jurassic":
                    Player.SetSkinId(4);
                    break;
                case "Battlecast Prime":
                    Player.SetSkinId(5);
                    break;
                case "Prehistoric":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class Corki : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 6, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "UFO", "Ice Toboggan", "Reb Baron", "Hot Rod", "Urfrider", "Dragonwing", "Fnatic"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "UFO":
                    Player.SetSkinId(1);
                    break;
                case "Ice Toboggan":
                    Player.SetSkinId(2);
                    break;
                case "Reb Baron":
                    Player.SetSkinId(3);
                    break;
                case "Hot Rod":
                    Player.SetSkinId(4);
                    break;
                case "Urfrider":
                    Player.SetSkinId(5);
                    break;
                case "Dragonwing":
                    Player.SetSkinId(6);
                    break;
                case "Fnatic":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    #endregion

    #region 4D

    public class Darius : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 4, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Lord", "Bioforge", "Woad King", "Dunkmaster", "Academy"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Lord":
                    Player.SetSkinId(1);
                    break;
                case "Bioforge":
                    Player.SetSkinId(2);
                    break;
                case "Woad King":
                    Player.SetSkinId(3);
                    break;
                case "Dunkmaster":
                    Player.SetSkinId(4);
                    break;
                case "Academy":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Diana : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 3, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Dark Valkyrie", "Lunar Goddess", "Infernal"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Dark Valkyrie":
                    Player.SetSkinId(1);
                    break;
                case "Lunar Goddess":
                    Player.SetSkinId(2);
                    break;
                case "Infernal":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class DrMundo : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 7, 0, 9);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Toxic", "Mundoverse", "Corporate", "Mundo Mundo", "Executioner", "Rageborn","TPA","Pool Party","El Macho"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Toxic":
                    Player.SetSkinId(1);
                    break;
                case "Mundoverse":
                    Player.SetSkinId(2);
                    break;
                case "Corporate":
                    Player.SetSkinId(3);
                    break;
                case "Mundo Mundo":
                    Player.SetSkinId(4);
                    break;
                case "Executioner":
                    Player.SetSkinId(5);
                    break;
                case "Rageborn":
                    Player.SetSkinId(6);
                    break;
                case "TPA":
                    Player.SetSkinId(7);
                    break;
                case "Pool Party":
                    Player.SetSkinId(8);
                    break;
                case "El Macho":
                    Player.SetSkinId(9);
                    break;
            }
        }

    }

    public class Draven : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 6, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Soul Reaver", "Gladiator", "Primetime", "Pool Party", "Beast Hunter", "Draven Draven"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Soul Reaver":
                    Player.SetSkinId(1);
                    break;
                case "Gladiator":
                    Player.SetSkinId(2);
                    break;
                case "Primetime":
                    Player.SetSkinId(3);
                    break;
                case "Pool Party":
                    Player.SetSkinId(4);
                    break;
                case "Beast Hunter":
                    Player.SetSkinId(5);
                    break;
                case "Draven Draven":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    #endregion

    #region 5E

    public class Ekko : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 2);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Sandstorm", "Academy"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Sandstorm":
                    Player.SetSkinId(1);
                    break;
                case "Academy":
                    Player.SetSkinId(2);
                    break;
            }
        }

    }

    public class Elise : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 1, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Death Blossom", "Victorious", "Blood Moon"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Death Blossom":
                    Player.SetSkinId(1);
                    break;
                case "Victorious":
                    Player.SetSkinId(2);
                    break;
                case "Blood Moon":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Evelynn : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 4, 0, 4);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Shadow", "Masquerade", "Tango", "Safecracker"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Shadow":
                    Player.SetSkinId(1);
                    break;
                case "Masquerade":
                    Player.SetSkinId(2);
                    break;
                case "Tango":
                    Player.SetSkinId(3);
                    break;
                case "Safecracker":
                    Player.SetSkinId(4);
                    break;
            }
        }

    }

    public class Ezreal : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 5, 0, 8);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Nottingham", "Striker", "Frosted", "Explorer", "Pulsefire", "TPA", "Debonair", "Ace of Spades"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Nottingham":
                    Player.SetSkinId(1);
                    break;
                case "Striker":
                    Player.SetSkinId(2);
                    break;
                case "Frosted":
                    Player.SetSkinId(3);
                    break;
                case "Explorer":
                    Player.SetSkinId(4);
                    break;
                case "Pulsefire":
                    Player.SetSkinId(5);
                    break;
                case "TPA":
                    Player.SetSkinId(6);
                    break;
                case "Debonair":
                    Player.SetSkinId(7);
                    break;
                case "Ace of Spades":
                    Player.SetSkinId(8);
                    break;
            }
        }

    }

    #endregion

    #region 6F

    public class Fiddlesticks : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 8);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Spectral", "Union Jack", "Bandito", "Pumpkinhead", "Fiddle Me Timbers", "Surprise Party", "Dark Candy", "Risen"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Spectral":
                    Player.SetSkinId(1);
                    break;
                case "Union Jack":
                    Player.SetSkinId(2);
                    break;
                case "Bandito":
                    Player.SetSkinId(3);
                    break;
                case "Pumpkinhead":
                    Player.SetSkinId(4);
                    break;
                case "Fiddle Me Timbers":
                    Player.SetSkinId(5);
                    break;
                case "Surprise Party":
                    Player.SetSkinId(6);
                    break;
                case "Dark Candy":
                    Player.SetSkinId(7);
                    break;
                case "Risen":
                    Player.SetSkinId(8);
                    break;
            }
        }

    }

    public class Fiora : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 4, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Royal Guard", "Nightraven", "Headmistress","PROJECT","Pool Party"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Royal Guard":
                    Player.SetSkinId(1);
                    break;
                case "Nightraven":
                    Player.SetSkinId(2);
                    break;
                case "Headmistress":
                    Player.SetSkinId(3);
                    break;
                case "PROJECT":
                    Player.SetSkinId(4);
                    break;
                case "Pool Party":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Fizz : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 5, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Atlantean", "Tundra", "Fisherman", "Void", "Cottontail", "Super Galaxy"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Atlantean":
                    Player.SetSkinId(1);
                    break;
                case "Tundra":
                    Player.SetSkinId(2);
                    break;
                case "Fisherman":
                    Player.SetSkinId(3);
                    break;
                case "Void":
                    Player.SetSkinId(4);
                    break;
                case "Cottontail":
                    Player.SetSkinId(5);
                    break;
                case "Super Galaxy":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    #endregion

    #region 7G

    public class Galio : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Enchanted", "Hextech", "Commando", "Gatekeeper", "Debonair"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Enchanted":
                    Player.SetSkinId(1);
                    break;
                case "Hextech":
                    Player.SetSkinId(2);
                    break;
                case "Commando":
                    Player.SetSkinId(3);
                    break;
                case "Gatekeeper":
                    Player.SetSkinId(4);
                    break;
                case "Debonair":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Gangplank : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Spooky", "Minuteman", "Sailor", "Toy Soldier", "Special Forces","Sultan", "Captain"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Spooky":
                    Player.SetSkinId(1);
                    break;
                case "Minuteman":
                    Player.SetSkinId(2);
                    break;
                case "Sailor":
                    Player.SetSkinId(3);
                    break;
                case "Toy Soldier":
                    Player.SetSkinId(4);
                    break;
                case "Special Forces":
                    Player.SetSkinId(5);
                    break;
                case "Sultan":
                    Player.SetSkinId(6);
                    break;
                case "Captain":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    public class Garen : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Sanguine", "Desert Trooper", "Commando", "Dreadknight", "Rugged", "Steel Legion", "Rogue Admiral"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Sanguine":
                    Player.SetSkinId(1);
                    break;
                case "Desert Trooper":
                    Player.SetSkinId(2);
                    break;
                case "Commando":
                    Player.SetSkinId(3);
                    break;
                case "Dreadknight":
                    Player.SetSkinId(4);
                    break;
                case "Rugged":
                    Player.SetSkinId(5);
                    break;
                case "Steel Legion":
                    Player.SetSkinId(6);
                    break;
                case "Rogue Admiral":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    public class Gnar : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 2);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Dino", "Gentleman", "Snow Day"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Dino":
                    Player.SetSkinId(1);
                    break;
                case "Gentleman":
                    Player.SetSkinId(2);
                    break;
                case "Snow Day":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Gragas : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 9);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Scuba", "Hillbilly", "Santa", "Gragas Esq", "Vandal", "Oktoberfest", "Superfan", "Fnatic", "Caskbreaker"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Scuba":
                    Player.SetSkinId(1);
                    break;
                case "Hillbilly":
                    Player.SetSkinId(2);
                    break;
                case "Santa":
                    Player.SetSkinId(3);
                    break;
                case "Gragas Esq":
                    Player.SetSkinId(4);
                    break;
                case "Vandal":
                    Player.SetSkinId(5);
                    break;
                case "Oktoberfest":
                    Player.SetSkinId(6);
                    break;
                case "Superfan":
                    Player.SetSkinId(7);
                    break;
                case "Fnatic":
                    Player.SetSkinId(8);
                    break;
                case "Caskbreaker":
                    Player.SetSkinId(9);
                    break;
            }
        }

    }

    public class Graves : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Hired Gun", "Jailbreak", "Mafia", "Riot", "Pool Party", "Cutthroat"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Hired Gun":
                    Player.SetSkinId(1);
                    break;
                case "Jailbreak":
                    Player.SetSkinId(2);
                    break;
                case "Mafia":
                    Player.SetSkinId(3);
                    break;
                case "Riot":
                    Player.SetSkinId(4);
                    break;
                case "Pool Party":
                    Player.SetSkinId(5);
                    break;
                case "Cutthroat":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    #endregion

    #region 8H

    public class Hecarim : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Blood Knight", "Reaper", "Headless", "Arcade","Elderwood"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Blood Knight":
                    Player.SetSkinId(1);
                    break;
                case "Reaper":
                    Player.SetSkinId(2);
                    break;
                case "Headless":
                    Player.SetSkinId(3);
                    break;
                case "Arcade":
                    Player.SetSkinId(4);
                    break;
                case "Elderwood":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Heimerdinger : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Alien Invader", "Blast Zone", "Piltover Customs", "Snowmerdinger", "Hazmat"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Alien Invader":
                    Player.SetSkinId(1);
                    break;
                case "Blast Zone":
                    Player.SetSkinId(2);
                    break;
                case "Piltover Customs":
                    Player.SetSkinId(3);
                    break;
                case "Snowmerdinger":
                    Player.SetSkinId(4);
                    break;
                case "Hazmat":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    #endregion

    #region 9I

    public class Illaoi : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 1, 0, 1);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Void Bringer"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Void Bringer":
                    Player.SetSkinId(1);
                    break;
            }
        }

    }

    public class Irelia : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Nightblade", "Aviator", "Infiltrator","Frostblade","Order of the Lotus"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Nightblade":
                    Player.SetSkinId(1);
                    break;
                case "Aviator":
                    Player.SetSkinId(2);
                    break;
                case "Infiltrator":
                    Player.SetSkinId(3);
                    break;
                case "Frostblade":
                    Player.SetSkinId(4);
                    break;
                case "Order of the Lotus":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    #endregion

    #region 10J

    public class Janna : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 5, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Tempest", "Hextech", "Frost Queen","Victorious","Forecast","Fnatic"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Tempest":
                    Player.SetSkinId(1);
                    break;
                case "Hextech":
                    Player.SetSkinId(2);
                    break;
                case "Frost Queen":
                    Player.SetSkinId(3);
                    break;
                case "Victorious":
                    Player.SetSkinId(4);
                    break;
                case "Forecast":
                    Player.SetSkinId(5);
                    break;
                case "Fnatic":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class Javan : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 5, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Commando", "Dragonslayer", "Darkforge","Victorious","Warring Kingdoms","Fnatic"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Commando":
                    Player.SetSkinId(1);
                    break;
                case "Dragonslayer":
                    Player.SetSkinId(2);
                    break;
                case "Darkforge":
                    Player.SetSkinId(3);
                    break;
                case "Victorious":
                    Player.SetSkinId(4);
                    break;
                case "Warring Kingdoms":
                    Player.SetSkinId(5);
                    break;
                case "Fnatic":
                    Player.SetSkinId(6);
                    break;

            }
        }

    }

    public class Jax : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 9);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "The Mighty", "Vandal", "Angler","PAX","Jaximus","Temple","Nemesis","SKT T1","Warden"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "The Mighty":
                    Player.SetSkinId(1);
                    break;
                case "Vandal":
                    Player.SetSkinId(2);
                    break;
                case "Angler":
                    Player.SetSkinId(3);
                    break;
                case "PAX":
                    Player.SetSkinId(4);
                    break;
                case "Jaximus":
                    Player.SetSkinId(5);
                    break;
                case "Temple":
                    Player.SetSkinId(6);
                    break;
                case "Nemesis":
                    Player.SetSkinId(7);
                    break;
                case "SKT T1":
                    Player.SetSkinId(8);
                    break;
                case "Warden":
                    Player.SetSkinId(9);
                    break;
            }
        }

    }

    public class Jayce : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Full Metal", "Debonair", "Forsaken"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Full Metal":
                    Player.SetSkinId(1);
                    break;
                case "Debonair":
                    Player.SetSkinId(2);
                    break;
                case "Forsaken":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Jhin : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 1, 0, 1);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "High Noon"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "High Noon":
                    Player.SetSkinId(1);
                    break;
            }
        }

    }

    public class Jinx : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Mafia", "Firecracker", "Slayer"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Mafia":
                    Player.SetSkinId(1);
                    break;
                case "Firecracker":
                    Player.SetSkinId(2);
                    break;
                case "Slayer":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    #endregion

    #region 11K

    public class Kalista : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 2);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Blood Moon", "Championship"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Blood Moon":
                    Player.SetSkinId(1);
                    break;
                case "Championship":
                    Player.SetSkinId(2);
                    break;
            }
        }

    }

    public class Karma : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Sun Goddess", "Sakura", "Traditional","Order of the Lotus","Warden"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Sun Goddess":
                    Player.SetSkinId(1);
                    break;
                case "Sakura":
                    Player.SetSkinId(2);
                    break;
                case "Traditional":
                    Player.SetSkinId(3);
                    break;
                case "Order of the Lotus":
                    Player.SetSkinId(4);
                    break;
                case "Warden":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Karthus : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Phantom", "Statue of Karthus", "Grim Reaper","Pentakill","Fnatic"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Phantom":
                    Player.SetSkinId(1);
                    break;
                case "Statue of Karthus":
                    Player.SetSkinId(2);
                    break;
                case "Grim Reaper":
                    Player.SetSkinId(3);
                    break;
                case "Pentakill":
                    Player.SetSkinId(4);
                    break;
                case "Fnatic":
                    Player.SetSkinId(5);
                    break;

            }
        }

    }

    public class Kassadin : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Festival", "Deep One", "Pre-Void","Harbinger","Cosmic Reaver"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Festival":
                    Player.SetSkinId(1);
                    break;
                case "Deep One":
                    Player.SetSkinId(2);
                    break;
                case "Pre-Void":
                    Player.SetSkinId(3);
                    break;
                case "Harbinger":
                    Player.SetSkinId(4);
                    break;
                case "Cosmic Reaver":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Katarina : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 8);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Mercenary", "Red Card", "Bilgewater","Kitty Cat","High Command","Sandstorm","Slay Belle","Warring Kingdoms"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Mercenary":
                    Player.SetSkinId(1);
                    break;
                case "Red Card":
                    Player.SetSkinId(2);
                    break;
                case "Bilgewater":
                    Player.SetSkinId(3);
                    break;
                case "Kitty Cat":
                    Player.SetSkinId(4);
                    break;
                case "High Command":
                    Player.SetSkinId(5);
                    break;
                case "Sandstorm":
                    Player.SetSkinId(6);
                    break;
                case "Slay Belle":
                    Player.SetSkinId(7);
                    break;
                case "Warring Kingdoms":
                    Player.SetSkinId(8);
                    break;
            }
        }

    }

    public class Kayle : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 8);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Silver", "Viridian", "Unmasked","Battleborn","Judgement","Aether Wing","Riot","Iron Inquisitor"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Silver":
                    Player.SetSkinId(1);
                    break;
                case "Viridian":
                    Player.SetSkinId(2);
                    break;
                case "Unmasked":
                    Player.SetSkinId(3);
                    break;
                case "Battleborn":
                    Player.SetSkinId(4);
                    break;
                case "Judgement":
                    Player.SetSkinId(5);
                    break;
                case "Aether Wing":
                    Player.SetSkinId(6);
                    break;
                case "Riot":
                    Player.SetSkinId(7);
                    break;
                case "Iron Inquisitor":
                    Player.SetSkinId(8);
                    break;
            }
        }

    }

    public class Kennen : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Deadly", "Swamp Master", "Karate", "Kennen M.D","Arctic Ops","Blood Moon"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Deadly":
                    Player.SetSkinId(1);
                    break;
                case "Swamp Master":
                    Player.SetSkinId(2);
                    break;
                case "Karate":
                    Player.SetSkinId(3);
                    break;
                case "Kennen M.D":
                    Player.SetSkinId(4);
                    break;
                case "Arctic Ops":
                    Player.SetSkinId(5);
                    break;
                case "Blood Moon":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class Khazix : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Mecha", "Guardian of the Sands", "Death Blossom"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Mecha":
                    Player.SetSkinId(1);
                    break;
                case "Guardian of the Sands":
                    Player.SetSkinId(2);
                    break;
                case "Death Blossom":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Kindred : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 1, 0, 2);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Shadowfire","Super Galaxy"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Shadowfire":
                    Player.SetSkinId(1);
                    break;
                case "Super Galaxy":
                    Player.SetSkinId(2);
                    break;
            }
        }

    }

    public class Kogmaw : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 8);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Caterpillar", "Sonoran", "Monarch","Reindeer","Lion Dance","Deep Sea","Jurassic","Battlecast"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Caterpillar":
                    Player.SetSkinId(1);
                    break;
                case "Sonoran":
                    Player.SetSkinId(2);
                    break;
                case "Monarch":
                    Player.SetSkinId(3);
                    break;
                case "Reindeer":
                    Player.SetSkinId(4);
                    break;
                case "Lion Dance":
                    Player.SetSkinId(5);
                    break;
                case "Deep Sea":
                    Player.SetSkinId(6);
                    break;
                case "Jurassic":
                    Player.SetSkinId(7);
                    break;
                case "Battlecast":
                    Player.SetSkinId(8);
                    break;
            }
        }

    }

    #endregion

    #region 12L

    public class LeBlanc : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Prestigious", "Wicked", "Mistletoe","Ravenborn","Elderwood"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Prestigious":
                    Player.SetSkinId(1);
                    break;
                case "Wicked":
                    Player.SetSkinId(2);
                    break;
                case "Mistletoe":
                    Player.SetSkinId(3);
                    break;
                case "Ravenborn":
                    Player.SetSkinId(4);
                    break;
                case "Elderwood":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Leesin : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Traditional", "Acolyte", "Dragon Fist","Muay Thai","Pool Party","SKT T1","Knockout"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Traditional":
                    Player.SetSkinId(1);
                    break;
                case "Acolyte":
                    Player.SetSkinId(2);
                    break;
                case "Dragon Fist":
                    Player.SetSkinId(3);
                    break;
                case "Muay Thai":
                    Player.SetSkinId(4);
                    break;
                case "Pool Party":
                    Player.SetSkinId(5);
                    break;
                case "SKT T1":
                    Player.SetSkinId(6);
                    break;
                case "Knockout":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    public class Leona : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 5, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Defender", "Valkyrie", "Iron Solari","Pool Party","PROJECT"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Defender":
                    Player.SetSkinId(1);
                    break;
                case "Valkyrie":
                    Player.SetSkinId(2);
                    break;
                case "Iron Solari":
                    Player.SetSkinId(3);
                    break;
                case "Pool Party":
                    Player.SetSkinId(4);
                    break;
                case "PROJECT":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Lissandra : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 3, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Bloodstone", "Blade Queen", "Program"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Bloodstone":
                    Player.SetSkinId(1);
                    break;
                case "Blade Queen":
                    Player.SetSkinId(2);
                    break;
                case "Program":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Lucian : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Hired Gun", "Striker", "PROJECT"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Hired Gun":
                    Player.SetSkinId(1);
                    break;
                case "Striker":
                    Player.SetSkinId(2);
                    break;
                case "PROJECT":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Lulu : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0,5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Bittersweet", "Wicked", "Dragon Trainer","Winter Wonder","Pool Party"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Bittersweet":
                    Player.SetSkinId(1);
                    break;
                case "Wicked":
                    Player.SetSkinId(2);
                    break;
                case "Dragon Trainer":
                    Player.SetSkinId(3);
                    break;
                case "Winter Wonder":
                    Player.SetSkinId(4);
                    break;
                case "Pool Party":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Lux : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Spellthief", "Sorceress", "Commando","Imperial","Steel Legion","Star Guardian"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Spellthief":
                    Player.SetSkinId(1);
                    break;
                case "Sorceress":
                    Player.SetSkinId(2);
                    break;
                case "Commando":
                    Player.SetSkinId(3);
                    break;
                case "Imperial":
                    Player.SetSkinId(4);
                    break;
                case "Steel Legion":
                    Player.SetSkinId(5);
                    break;
                case "Star Guardian":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    #endregion

    #region 13M

    public class Malphite : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Shamrock", "Coral Reef", "Marble","Obsidian","Glacial","Mecha","Ironside"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Shamrock":
                    Player.SetSkinId(1);
                    break;
                case "Coral Reef":
                    Player.SetSkinId(2);
                    break;
                case "Marble":
                    Player.SetSkinId(3);
                    break;
                case "Obsidian":
                    Player.SetSkinId(4);
                    break;
                case "Glacial":
                    Player.SetSkinId(5);
                    break;
                case "Mecha":
                    Player.SetSkinId(6);
                    break;
                case "Ironside":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    public class Malzahar : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Vizier", "Shadow Prince", "Djinn","Overlord","Snow Day"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Vizier":
                    Player.SetSkinId(1);
                    break;
                case "Shadow Prince":
                    Player.SetSkinId(2);
                    break;
                case "Djinn":
                    Player.SetSkinId(3);
                    break;
                case "Overlord":
                    Player.SetSkinId(4);
                    break;
                case "Snow Day":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Maokai : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Totemic", "Charred", "Festive","Haunted","Goalkeeper","Meowkai"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Totemic":
                    Player.SetSkinId(1);
                    break;
                case "Charred":
                    Player.SetSkinId(2);
                    break;
                case "Festive":
                    Player.SetSkinId(3);
                    break;
                case "Haunted":
                    Player.SetSkinId(4);
                    break;
                case "Goalkeeper":
                    Player.SetSkinId(5);
                    break;
                case "Meowkai":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class MasterYi : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Assassin", "Chosen", "Ionia","Samurai","Headhunter","PROJECT"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Assassin":
                    Player.SetSkinId(1);
                    break;
                case "Chosen":
                    Player.SetSkinId(2);
                    break;
                case "Ionia":
                    Player.SetSkinId(3);
                    break;
                case "Samurai":
                    Player.SetSkinId(4);
                    break;
                case "Headhunter":
                    Player.SetSkinId(5);
                    break;
                case "PROJECT":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class MissFortune : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 9);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Cowgirl", "Waterloo", "Secret Agent","Candy Cane","Road Warrior","Mafia","Arcade","Captain","Pool Party"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Cowgirl":
                    Player.SetSkinId(1);
                    break;
                case "Waterloo":
                    Player.SetSkinId(2);
                    break;
                case "Secret Agent":
                    Player.SetSkinId(3);
                    break;
                case "Candy Cane":
                    Player.SetSkinId(4);
                    break;
                case "Road Warrior":
                    Player.SetSkinId(5);
                    break;
                case "Mafia":
                    Player.SetSkinId(6);
                    break;
                case "Arcade":
                    Player.SetSkinId(7);
                    break;
                case "Captain":
                    Player.SetSkinId(8);
                    break;
                    case "Pool Party":
                    Player.SetSkinId(9);
                    break;
            }
        }

    }

    public class Mordekaiser : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Dragon Knight", "Infernal", "Pentakill","Lord","King of Clubs"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Dragon Knight":
                    Player.SetSkinId(1);
                    break;
                case "Infernal":
                    Player.SetSkinId(2);
                    break;
                case "Pentakill":
                    Player.SetSkinId(3);
                    break;
                case "Lord":
                    Player.SetSkinId(4);
                    break;
                case "King of Clubs":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Morgana : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Exiled", "Sinful Succulence", "Blade Mistress","Blackthorn","Ghost Bride","Victorious","Lunar Wraith"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Exiled":
                    Player.SetSkinId(1);
                    break;
                case "Sinful Succulence":
                    Player.SetSkinId(2);
                    break;
                case "Blade Mistress":
                    Player.SetSkinId(3);
                    break;
                case "Blackthorn":
                    Player.SetSkinId(4);
                    break;
                case "Ghost Bride":
                    Player.SetSkinId(5);
                    break;
                case "Victorious":
                    Player.SetSkinId(6);
                    break;
                case "Lunar Wraith":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    #endregion
    // da den day
    #region 14N

    public class Nami : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 4);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Koi", "River Spirit", "Urf the Nami-tee","Deep Sea"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Koi":
                    Player.SetSkinId(1);
                    break;
                case "River Spirit":
                    Player.SetSkinId(2);
                    break;
                case "Urf the Nami-tee":
                    Player.SetSkinId(3);
                    break;
                case "Deep Sea":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Nasus : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Galactic", "Pharaoh", "Dreadknight","Riot","Infernal","Archduke"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Galactic":
                    Player.SetSkinId(1);
                    break;
                case "Pharaoh":
                    Player.SetSkinId(2);
                    break;
                case "Dreadknight":
                    Player.SetSkinId(3);
                    break;
                case "Riot":
                    Player.SetSkinId(4);
                    break;
                case "Infernal":
                    Player.SetSkinId(5);
                    break;
                case "Archduke":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class Nautilus : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 4);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Abyssal", "Subterranean", "Astro","Warden"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Abyssal":
                    Player.SetSkinId(1);
                    break;
                case "Subterranean":
                    Player.SetSkinId(2);
                    break;
                case "Astro":
                    Player.SetSkinId(3);
                    break;
                case "Warden":
                    Player.SetSkinId(4);
                    break;

            }
        }

    }

    public class Nidalee : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Justicar Aatrox", "Mecha Aatrox", "Sea Hunter Aatrox"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Justicar Aatrox":
                    Player.SetSkinId(1);
                    break;
                case "Mecha Aatrox":
                    Player.SetSkinId(2);
                    break;
                case "Sea Hunter Aatrox":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Noctume : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Frozen Terror", "Void", "Ravager","Haunting","Eternum","Cursed Revenant"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Frozen Terror":
                    Player.SetSkinId(1);
                    break;
                case "Void":
                    Player.SetSkinId(2);
                    break;
                case "Ravager":
                    Player.SetSkinId(3);
                    break;
                case "Haunting":
                    Player.SetSkinId(4);
                    break;
                case "Eternum":
                    Player.SetSkinId(5);
                    break;
                case "Cursed Revenant":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class Nunu : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Sasquatch", "Workshop", "Grungy","Nunu Bot","Demolisher","TPA","Zombie"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Sasquatch":
                    Player.SetSkinId(1);
                    break;
                case "Workshop":
                    Player.SetSkinId(2);
                    break;
                case "Grungy":
                    Player.SetSkinId(3);
                    break;
                case "Nunu Bot":
                    Player.SetSkinId(4);
                    break;
                case "Demolisher":
                    Player.SetSkinId(5);
                    break;
                case "TPA":
                    Player.SetSkinId(6);
                    break;
                case "Zombie":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    #endregion

    #region 15O

    public class Olaf : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Forsaken", "Glacial", "Brolaf","Pentakill","Marauder"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Forsaken":
                    Player.SetSkinId(1);
                    break;
                case "Glacial":
                    Player.SetSkinId(2);
                    break;
                case "Brolaf":
                    Player.SetSkinId(3);
                    break;
                case "Pentakill":
                    Player.SetSkinId(4);
                    break;
                case "Marauder":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Orianna : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Gothic", "Sewn Chaos", "Bladecraft","TPA","Winter Wonder","Heartseeker"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Gothic":
                    Player.SetSkinId(1);
                    break;
                case "Sewn Chaos":
                    Player.SetSkinId(2);
                    break;
                case "Bladecraft":
                    Player.SetSkinId(3);
                    break;
                case "TPA":
                    Player.SetSkinId(4);
                    break;
                case "Winter Wonder":
                    Player.SetSkinId(5);
                    break;
                case "Heartseeker":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    #endregion

    #region 16P

    public class Pantheon : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Myrmidon", "Ruthless", "Perseus","Full Metal","Glaive Warrior","Dragonslayer","Slayer"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Myrmidon":
                    Player.SetSkinId(1);
                    break;
                case "Ruthless":
                    Player.SetSkinId(2);
                    break;
                case "Perseus":
                    Player.SetSkinId(3);
                    break;
                case "Full Metal":
                    Player.SetSkinId(4);
                    break;
                case "Glaive Warrior":
                    Player.SetSkinId(5);
                    break;
                case "Dragonslayer":
                    Player.SetSkinId(6);
                    break;
                case "Slayer":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    public class Poppy : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Noxus", "Blacksmith", "Lolli","Ragdoll","Battle Regalia","Scarlet Hammer"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Noxus":
                    Player.SetSkinId(1);
                    break;
                case "Blacksmith":
                    Player.SetSkinId(2);
                    break;
                case "Lolli":
                    Player.SetSkinId(3);
                    break;
                case "Ragdoll":
                    Player.SetSkinId(4);
                    break;
                case "Battle Regalia":
                    Player.SetSkinId(5);
                    break;
                case "Scarlet Hammer":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    #endregion

    #region 17Q

    public class Quinn : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Phoenix", "Woad Scout", "Corsair"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Phoenix":
                    Player.SetSkinId(1);
                    break;
                case "Woad Scout":
                    Player.SetSkinId(2);
                    break;
                case "Corsair":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    #endregion

    #region 18R

    public class Rammus : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "King", "Chrome", "Molten","Freljord","Ninja","Full Metal","Guardian of the Sands"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "King":
                    Player.SetSkinId(1);
                    break;
                case "Chrome":
                    Player.SetSkinId(2);
                    break;
                case "Molten":
                    Player.SetSkinId(3);
                    break;
                case "Freljord":
                    Player.SetSkinId(4);
                    break;
                case "Ninja":
                    Player.SetSkinId(5);
                    break;
                case "Full Metal":
                    Player.SetSkinId(6);
                    break;
                case "Guardian of the Sands":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    public class RekSai : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 2);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Eternum", "Pool Party"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Eternum":
                    Player.SetSkinId(1);
                    break;
                case "Pool Party":
                    Player.SetSkinId(2);
                    break;
            }
        }

    }

    public class Renekton : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Galactic", "Outback", "Bloodfury","Rune Wars","Pool Party","Scorched Earth","Prehistoric"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Galactic":
                    Player.SetSkinId(1);
                    break;
                case "Outback":
                    Player.SetSkinId(2);
                    break;
                case "Bloodfury":
                    Player.SetSkinId(3);
                    break;
                case "Rune Wars":
                    Player.SetSkinId(4);
                    break;
                case "Pool Party":
                    Player.SetSkinId(5);
                    break;
                case "Scorched Earth":
                    Player.SetSkinId(6);
                    break;
                case "Prehistoric":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    public class Rengar : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Headhunter", "Night Hunter", "SSW"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Headhunter":
                    Player.SetSkinId(1);
                    break;
                case "Night Hunter":
                    Player.SetSkinId(2);
                    break;
                case "SSW":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Riven : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Crimson Elite", "Redeemed", "Battle Bunny","Championship","Dragonblade","Arcade"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Crimson Elite":
                    Player.SetSkinId(1);
                    break;
                case "Redeemed":
                    Player.SetSkinId(2);
                    break;
                case "Battle Bunny":
                    Player.SetSkinId(3);
                    break;
                case "Championship":
                    Player.SetSkinId(4);
                    break;
                case "Dragonblade":
                    Player.SetSkinId(5);
                    break;
                case "Arcade":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class Rumble : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Rumble in the Jungle ", "Bilgerat", "Super Galaxy"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Rumble in the Jungle ":
                    Player.SetSkinId(1);
                    break;
                case "Bilgerat":
                    Player.SetSkinId(2);
                    break;
                case "Super Galaxy":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Ryze : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 9);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Human", "Tribal", "Uncle","Triumphant","Professor","Zombie","Dark Crystal","Pirate","Whitebeard"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Human":
                    Player.SetSkinId(1);
                    break;
                case "Tribal":
                    Player.SetSkinId(2);
                    break;
                case "Uncle":
                    Player.SetSkinId(3);
                    break;
                case "Triumphant":
                    Player.SetSkinId(4);
                    break;
                case "Professor":
                    Player.SetSkinId(5);
                    break;
                case "Zombie":
                    Player.SetSkinId(6);
                    break;
                case "Dark Crystal":
                    Player.SetSkinId(7);
                    break;
                case "Pirate":
                    Player.SetSkinId(8);
                    break;
                case "Whitebeard":
                    Player.SetSkinId(9);
                    break;
            }
        }

    }

    #endregion

    #region 18S

    public class Sejuani : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Sabretusk", "Darkrider", "Traditional","Bear Cavalry","Poro Rider","Beast Hunter"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Sabretusk":
                    Player.SetSkinId(1);
                    break;
                case "Darkrider":
                    Player.SetSkinId(2);
                    break;
                case "Traditional":
                    Player.SetSkinId(3);
                    break;
                case "Bear Cavalry":
                    Player.SetSkinId(4);
                    break;
                case "Poro Rider":
                    Player.SetSkinId(5);
                    break;
                case "Beast Hunter":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class Shaco : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Mad Hatter", "Royal", "Nutcracko","Workshop","Asylum","Masked","Wild Card"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Mad Hatter":
                    Player.SetSkinId(1);
                    break;
                case "Royal":
                    Player.SetSkinId(2);
                    break;
                case "Nutcracko":
                    Player.SetSkinId(3);
                    break;
                case "Workshop":
                    Player.SetSkinId(4);
                    break;
                case "Asylum":
                    Player.SetSkinId(5);
                    break;
                case "Masked":
                    Player.SetSkinId(6);
                    break;
                case "Wild Card":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    public class Shen : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 5, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Frozen", "Yellow Jacket", "Surgeon", "Blood Moon", "Warlord", "TPA"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {

            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Frozen":
                    Player.SetSkinId(1);
                    break;
                case "Yellow Jacket":
                    Player.SetSkinId(2);
                    break;
                case "Surgeon":
                    Player.SetSkinId(3);
                    break;
                case "Blood Moon":
                    Player.SetSkinId(4);
                    break;
                case "Warlord":
                    Player.SetSkinId(5);
                    break;
                case "TPA":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class Shyvana : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Ironscale", "Boneclaw", "Darkflame","Ice Drake","Championship","Super Galaxy"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Ironscale":
                    Player.SetSkinId(1);
                    break;
                case "Boneclaw":
                    Player.SetSkinId(2);
                    break;
                case "Darkflame":
                    Player.SetSkinId(3);
                    break;
                case "Ice Drake":
                    Player.SetSkinId(4);
                    break;
                case "Championship":
                    Player.SetSkinId(5);
                    break;
                case "Super Galaxy":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class Singed : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 8);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Riot Squad", "Hextech", "Surfer","Mad Scientist","Augmented","Snow Day","SSW","Black Scourge"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Riot Squad":
                    Player.SetSkinId(1);
                    break;
                case "Hextech":
                    Player.SetSkinId(2);
                    break;
                case "Surfer":
                    Player.SetSkinId(3);
                    break;
                case "Mad Scientist":
                    Player.SetSkinId(4);
                    break;
                case "Augmented":
                    Player.SetSkinId(5);
                    break;
                case "Snow Day":
                    Player.SetSkinId(6);
                    break;
                case "SSW":
                    Player.SetSkinId(7);
                    break;
                case "Black Scourge":
                    Player.SetSkinId(8);
                    break;
            }
        }

    }

    public class Sion : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Hextech", "Barbarian", "Lumberjack","Warmonger","Mecha Zero"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Hextech":
                    Player.SetSkinId(1);
                    break;
                case "Barbarian":
                    Player.SetSkinId(2);
                    break;
                case "Lumberjack":
                    Player.SetSkinId(3);
                    break;
                case "Warmonger":
                    Player.SetSkinId(3);
                    break;
                case "Mecha Zero":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Sivir : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 8);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Warrior Princess", "Spectacular", "Huntress","Bandit","PAX","Snowstorm","Warden","Victorious"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Warrior Princess":
                    Player.SetSkinId(1);
                    break;
                case "Spectacular":
                    Player.SetSkinId(2);
                    break;
                case "Huntress":
                    Player.SetSkinId(3);
                    break;
                case "Bandit":
                    Player.SetSkinId(4);
                    break;
                case "PAX":
                    Player.SetSkinId(5);
                    break;
                case "Snowstorm":
                    Player.SetSkinId(6);
                    break;
                case "Warden":
                    Player.SetSkinId(7);
                    break;
                case "Victorious":
                    Player.SetSkinId(8);
                    break;
            }
        }

    }

    public class Skarner : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 4);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Sandscourge", "Earthrune", "Battlecast Alpha","Guardian of the Sands"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Sandscourge":
                    Player.SetSkinId(1);
                    break;
                case "Earthrune":
                    Player.SetSkinId(2);
                    break;
                case "Battlecast Alpha":
                    Player.SetSkinId(3);
                    break;
                case "Guardian of the Sands":
                    Player.SetSkinId(4);
                    break;
            }
        }

    }

    public class Sona : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Muse", "Pentakill", "Silent Night","Guqin","Arcade","DJ","Sweetheart"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Muse":
                    Player.SetSkinId(1);
                    break;
                case "Pentakill":
                    Player.SetSkinId(2);
                    break;
                case "Silent Night":
                    Player.SetSkinId(3);
                    break;
                case "Guqin":
                    Player.SetSkinId(4);
                    break;
                case "Arcade    ":
                    Player.SetSkinId(5);
                    break;
                case "DJ":
                    Player.SetSkinId(6);
                    break;
                case "Sweetheart":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    public class Soraka : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Dryad", "Divine", "Celestine","Reaper","Order of the Banana","Program"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Dryad":
                    Player.SetSkinId(1);
                    break;
                case "Divine":
                    Player.SetSkinId(2);
                    break;
                case "Celestine":
                    Player.SetSkinId(3);
                    break;
                case "Reaper":
                    Player.SetSkinId(4);
                    break;
                case "Order of the Banana":
                    Player.SetSkinId(5);
                    break;
                case "Program":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class Swain : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Northern Front", "Bilgewater", "Tyrant"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Northern Front":
                    Player.SetSkinId(1);
                    break;
                case "Bilgewater":
                    Player.SetSkinId(2);
                    break;
                case "Tyrant":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Syndra : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 4);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Justicar", "Atlantean", "Queen of Diamonds","Snow Day"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Justicar":
                    Player.SetSkinId(1);
                    break;
                case "Atlantean":
                    Player.SetSkinId(2);
                    break;
                case "Queen of Diamonds":
                    Player.SetSkinId(3);
                    break;
                case "Snow Day":
                    Player.SetSkinId(4);
                    break;
            }
        }

    }

    #endregion

    #region 19T

    public class TahmKench : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 2);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Master Chef", "Urf"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Master Chef":
                    Player.SetSkinId(1);
                    break;
                case "Urf":
                    Player.SetSkinId(2);
                    break;
                
            }
        }

    }

    public class Taliyah : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 1, 0, 1);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Freljord"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Freljord":
                    Player.SetSkinId(1);
                    break;
            }
        }

    }

    public class Talon : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 4);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Renegade", "Crimson", "Dragonblade","SSW"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Renegade":
                    Player.SetSkinId(1);
                    break;
                case "Crimson":
                    Player.SetSkinId(2);
                    break;
                case "Dragonblade":
                    Player.SetSkinId(3);
                    break;
                case "SSW":
                    Player.SetSkinId(4);
                    break;
            }
        }

    }

    public class Taric : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 4);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Emerald", "Armor of the Fifth Age", "Bloodstone","Pool Party"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Emerald":
                    Player.SetSkinId(1);
                    break;
                case "Armor of the Fifth Age":
                    Player.SetSkinId(2);
                    break;
                case "Bloodstone":
                    Player.SetSkinId(3);
                    break;
                case "Pool Party":
                    Player.SetSkinId(4);
                    break;
            }
        }

    }

    public class Teemo : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 8);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Happy Elf", "Recon", "Badger","Astronaut","Cottontail","Super","Panda","Omega Squad"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Happy Elf":
                    Player.SetSkinId(1);
                    break;
                case "Recon":
                    Player.SetSkinId(2);
                    break;
                case "Badger":
                    Player.SetSkinId(3);
                    break;
                case "Astronaut":
                    Player.SetSkinId(4);
                    break;
                case "Cottontail":
                    Player.SetSkinId(5);
                    break;
                case "Super":
                    Player.SetSkinId(6);
                    break;
                case "Panda":
                    Player.SetSkinId(7);
                    break;
                case "Omega Squad":
                    Player.SetSkinId(8);
                    break;
                    
            }
        }

    }

    public class Thresh : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Deep Terror", "Championship", "Blood Moon","SSW","Dark Star"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Deep Terror":
                    Player.SetSkinId(1);
                    break;
                case "Championship":
                    Player.SetSkinId(2);
                    break;
                case "Blood Moon":
                    Player.SetSkinId(3);
                    break;
                case "SSW":
                    Player.SetSkinId(4);
                    break;
                case "Dark Star":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Tristana : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Riot Girl", "Earnest Elf", "Firefighter","Guerilla","Buccaneer","Rocket Girl","Dragon Trainer"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Riot Girl":
                    Player.SetSkinId(1);
                    break;
                case "Earnest Elf":
                    Player.SetSkinId(2);
                    break;
                case "Firefighter": Player.SetSkinId(3); break;
                case "Guerilla": Player.SetSkinId(4); break;
                case "Buccaneer": Player.SetSkinId(5); break;
                case "Rocket Girl": Player.SetSkinId(6); break;
                case "Dragon Trainer": Player.SetSkinId(7); break;
            }
        }

    }

    public class Trundle : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 4);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Lil' Slugger", "Junkyard", "Traditional","Constable"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Lil' Slugger":
                    Player.SetSkinId(1);
                    break;
                case "Junkyard":
                    Player.SetSkinId(2);
                    break;
                case "Traditional":
                    Player.SetSkinId(3);
                    break;
                case "Constable":
                    Player.SetSkinId(4);
                    break;
            }
        }

    }

    public class Tryndamere : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 8);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Highland", "King", "Viking","Demonblade","Sultan","Warring Kingdoms","Nightmare","Beast Hunter"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Highland": Player.SetSkinId(1); break;
                case "King": Player.SetSkinId(2); break;
                case "Viking": Player.SetSkinId(3); break;
                case "Demonblade": Player.SetSkinId(4); break;
                case "Sultan": Player.SetSkinId(5); break;
                case "Warring Kingdoms": Player.SetSkinId(6); break;
                case "Nightmare": Player.SetSkinId(7); break;
                case "Beast Hunter": Player.SetSkinId(8); break;
            }
        }

    }

    public class TwistedFate : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 9);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "PAX", "Jack of Hearts", "The Magnificent","Tango","High Noon","Musketeer","Underworld","Red Card","Cutpurse"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "PAX":
                    Player.SetSkinId(1);
                    break;
                case "Jack of Hearts":
                    Player.SetSkinId(2);
                    break;
                case "The Magnificent":
                    Player.SetSkinId(3);
                    break;
                case "Tango": Player.SetSkinId(4); break;
                case "High Noon": Player.SetSkinId(5); break;
                case "Musketeer": Player.SetSkinId(6); break;
                case "Underworld": Player.SetSkinId(7); break;
                case "Red Card": Player.SetSkinId(8); break;
                case "Cutpurse": Player.SetSkinId(9); break;
            }
        }

    }

    public class Twitch : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Kingpin", "Whistler Village", "Medieval","Gangster","Vandal","Pickpocket","SSW"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Kingpin":
                    Player.SetSkinId(1);
                    break;
                case "Whistler Village":
                    Player.SetSkinId(2);
                    break;
                case "Medieval": Player.SetSkinId(3); break;
                case "Gangster": Player.SetSkinId(4); break;
                case "Vandal": Player.SetSkinId(5); break;
                case "Pickpocket": Player.SetSkinId(6); break;
                case "SSW": Player.SetSkinId(7); break;
            }
        }

    }

    #endregion

    #region 20U

    public class Udyr : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0,4);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Black Belt", "Primal", "Spirit Guard","Definitely Not Udyr"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Black Belt":
                    Player.SetSkinId(1);
                    break;
                case "Primal":
                    Player.SetSkinId(2);
                    break;
                case "Spirit Guard": Player.SetSkinId(3); break;
                case "Definitely Not Udyr": Player.SetSkinId(4); break;
            }
        }

    }

    public class Urgot : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Giant Enemy", "Butcher", "Battlecast"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Giant Enemy":
                    Player.SetSkinId(1);
                    break;
                case "Butcher":
                    Player.SetSkinId(2);
                    break;
                case "Battlecast":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    #endregion

    #region 21V

    public class Varus : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 4, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Blight Crystal", "Arclight", "Arctic Ops", "Heartseeker", "Swiftbolt","Dark Star"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Blight Crystal":
                    Player.SetSkinId(1);
                    break;
                case "Arclight":
                    Player.SetSkinId(2);
                    break;
                case "Arctic Ops":
                    Player.SetSkinId(3);
                    break;
                case "Heartseeker":
                    Player.SetSkinId(4);
                    break;
                case "Swiftbolt":
                    Player.SetSkinId(5);
                    break;
                case "Dark Star":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class Vayne : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Vindicator", "Aristocrat", "Dragonslayer","Heartseeker","SKT T1","Arclight"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Vindicator":
                    Player.SetSkinId(1);
                    break;
                case "Aristocrat":
                    Player.SetSkinId(2);
                    break;
                case "Dragonslayer":
                    Player.SetSkinId(3);
                    break;
                case "Heartseeker":
                    Player.SetSkinId(4);
                    break;
                case "SKT T1":
                    Player.SetSkinId(5);
                    break;
                case "Arclight":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    public class Veigar : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 8);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "White Mage", "Curling", "Greybeard","Leprechaun","Baron Von","Superb Villain","Bad Santa","Final Boss"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "White Mage":
                    Player.SetSkinId(1);
                    break;
                case "Curling":
                    Player.SetSkinId(2);
                    break;
                case "Greybeard": Player.SetSkinId(3); break;
                case "Leprechaun": Player.SetSkinId(4); break;
                case "Baron Von": Player.SetSkinId(5); break;
                case "Superb Villain": Player.SetSkinId(6); break;
                case "Bad Santa": Player.SetSkinId(7); break;
                case "Final Boss": Player.SetSkinId(8); break;
            }
        }

    }

    public class VelKoz : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Battlecast", "Arclight", "Definitely Not Vel'Koz"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Battlecast":
                    Player.SetSkinId(1);
                    break;
                case "Arclight":
                    Player.SetSkinId(2);
                    break;
                case "Definitely Not Vel'Koz":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Vi : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 4);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Neon Strike", "Officer", "Debonair","Demon"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Neon Strike":
                    Player.SetSkinId(1);
                    break;
                case "Officer":
                    Player.SetSkinId(2);
                    break;
                case "Debonair":
                    Player.SetSkinId(3);
                    break;
                case "Demon":
                    Player.SetSkinId(4);
                    break;
            }
        }

    }

    public class Viktor : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Full Machine", "Prototype", "Creator"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Full Machine":
                    Player.SetSkinId(1);
                    break;
                case "Prototype":
                    Player.SetSkinId(2);
                    break;
                case "Creator":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Vladimir : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 7);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Count", "Marquis", "Nosferatu","Vandal","Blood Lord","Soulstealer","Academy"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Count":
                    Player.SetSkinId(1);
                    break;
                case "Marquis":
                    Player.SetSkinId(2);
                    break;
                case "Nosferatu":
                    Player.SetSkinId(3);
                    break;
                case "Vandal":
                    Player.SetSkinId(4);
                    break;
                case "Blood Lord":
                    Player.SetSkinId(5);
                    break;
                case "Soulstealer":
                    Player.SetSkinId(6);
                    break;
                case "Academy":
                    Player.SetSkinId(7);
                    break;
            }
        }

    }

    public class Volibear : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Thunder Lord", "Northern Storm", "Runeguard","Captain","El Rayo"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Thunder Lord":
                    Player.SetSkinId(1);
                    break;
                case "Northern Storm":
                    Player.SetSkinId(2);
                    break;
                case "Runeguard":
                    Player.SetSkinId(3);
                    break;
                case "Captain":
                    Player.SetSkinId(4);
                    break;
                case "El Rayo":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    #endregion

    #region 22W

    public class Warwick : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 8);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Grey", "Urf", "Big Bad","Tundra Hunter","Feral","Firefang","Hyena","Marauder"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Grey":
                    Player.SetSkinId(1);
                    break;
                case "Urf":
                    Player.SetSkinId(2);
                    break;
                case "Big Bad":Player.SetSkinId(3);break;
                case "Tundra Hunter": Player.SetSkinId(4); break;
                case "Feral": Player.SetSkinId(5); break;
                case "Firefang": Player.SetSkinId(6); break;
                case "Hyena": Player.SetSkinId(7); break;
                case "Marauder": Player.SetSkinId(8); break;
            }
        }

    }

    public class Wukong : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Volcanic", "General", "Jade Dragon","Underworld","Radiant"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Volcanic":
                    Player.SetSkinId(1);
                    break;
                case "General":
                    Player.SetSkinId(2);
                    break;
                case "Jade Dragon":
                    Player.SetSkinId(3);
                    break;
                case "Underworld":
                    Player.SetSkinId(4);
                    break;
                case "Radiant":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    #endregion

    #region 23X

    public class Xerath : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 4);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Battlecast", "Runeborn", "Scorched Earth","Guardian of the Sands"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Battlecast":
                    Player.SetSkinId(1);
                    break;
                case "Runeborn":
                    Player.SetSkinId(2);
                    break;
                case "Scorched Earth":
                    Player.SetSkinId(3);
                    break;
                case "Guardian of the Sands":
                    Player.SetSkinId(4);
                    break;
            }
        }

    }

    public class Xinzhao : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 6);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Commando", "Imperial", "Viscero","Winged Hussar","Warring Kingdoms","Secret Agent"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Commando":
                    Player.SetSkinId(1);
                    break;
                case "Imperial":
                    Player.SetSkinId(2);
                    break;
                case "Viscero":
                    Player.SetSkinId(3);
                    break;
                case "Winged Hussar":
                    Player.SetSkinId(4);
                    break;
                case "Warring Kingdoms":
                    Player.SetSkinId(5);
                    break;
                case "Secret Agent":
                    Player.SetSkinId(6);
                    break;
            }
        }

    }

    #endregion

    #region 24Y

    public class Yasuo : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "High Noon", "PROJECT", "Blood Moon"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "High Noon":
                    Player.SetSkinId(1);
                    break;
                case "PROJECT":
                    Player.SetSkinId(2);
                    break;
                case "Blood Moon":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Yorick : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 2);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Undertaker", "Pentakill"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Undertaker":
                    Player.SetSkinId(1);
                    break;
                case "Pentakill":
                    Player.SetSkinId(2);
                    break;
            }
        }

    }

    #endregion

    #region 25Z

    public class Zac : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 2);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Special Weapon", "Pool Party"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Special Weapon":
                    Player.SetSkinId(1);
                    break;
                case "Pool Party":
                    Player.SetSkinId(2);
                    break;
            }
        }

    }

    public class Zed : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Shockblade", "SKT T1", "PROJECT"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Shockblade":
                    Player.SetSkinId(1);
                    break;
                case "SKT T1":
                    Player.SetSkinId(2);
                    break;
                case "PROJECT":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    public class Ziggs : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Mad Scientist", "Major", "Pool Party","Snow Day","Master Arcanist"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Mad Scientist":
                    Player.SetSkinId(1);
                    break;
                case "Major":
                    Player.SetSkinId(2);
                    break;
                case "Pool Party":
                    Player.SetSkinId(3);
                    break;
                case "Snow Day":
                    Player.SetSkinId(4);
                    break;
                case "Master Arcanist":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Zilean : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 5);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Old Saint", "Groovy", "Shurima Desert","Time Machine","Blood Moon"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Old Saint":
                    Player.SetSkinId(1);
                    break;
                case "Groovy":
                    Player.SetSkinId(2);
                    break;
                case "Shurima Desert":
                    Player.SetSkinId(3);
                    break;
                case "Time Machine":
                    Player.SetSkinId(4);
                    break;
                case "Blood Moon":
                    Player.SetSkinId(5);
                    break;
            }
        }

    }

    public class Zyra : Skin_Champ
    {
        public Slider getSlider()
        {
            return new Slider("Skin", 2, 0, 3);
        }
        public string[] getlistskin()
        {
            var sid = new[]
            {
                "Default", "Wildfire", "Haunted", "SKT T1"
            };
            return sid;
        }
        public void SkinChange(Menu _skinMenu)
        {
            var style = _skinMenu["sID"].DisplayName;
            switch (style)
            {
                case "Default":
                    Player.SetSkinId(0);
                    break;
                case "Wildfire":
                    Player.SetSkinId(1);
                    break;
                case "Haunted":
                    Player.SetSkinId(2);
                    break;
                case "SKT T1":
                    Player.SetSkinId(3);
                    break;
            }
        }

    }

    #endregion

}
