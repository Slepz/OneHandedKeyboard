using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHandedKeyboard
{
    [Flags]
    public enum Level
    {
        None = 0,
        ThumbGroup = 1,
        IndexGroup = 2,
        MiddleGroup = 4,
        RingGroup = 8,
        PinkyGroup = 16,
        SymbolGroup = 32
    }


    public static class Dictionary
    {
        private static List<Level> _bannedLevels;
        public static List<Level> BannedLevels
        {
            get { return _bannedLevels = _bannedLevels ?? GetBannedLevels(); }
        }

        private static List<Level> GetBannedLevels()
        {
            var levels = new List<Level>();
            for (int i = 0; i < 64; i++)
            {
                var charList = LevelToCharacterList((Level)i);
                if(!CommonWords.List.Any(item => item.All(c => charList.Contains(c))))
                    levels.Add((Level)i);
            }

            return levels;
        }

        public static string GetWord(Level level)
        {
            var charList = LevelToCharacterList(level);
            return CommonWords.List.Where(item => item.All(c => charList.Contains(c))).OrderBy(x => Guid.NewGuid()).Take(1).Single();
        }

        private static string LevelToCharacterList(Level level)
        {
            var charList = string.Empty;
            if (level.HasFlag(Level.ThumbGroup))
                charList += "v kj";
            if (level.HasFlag(Level.IndexGroup))
                charList += "etaon";
            if (level.HasFlag(Level.MiddleGroup))
                charList += "rishd";
            if (level.HasFlag(Level.RingGroup))
                charList += "lfcmu";
            if (level.HasFlag(Level.PinkyGroup))
                charList += "gypwb";
            if (level.HasFlag(Level.SymbolGroup))
                charList += ".,qxz";
            return charList;
        }
    }
}
