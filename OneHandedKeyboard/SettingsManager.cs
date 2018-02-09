using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHandedKeyboard
{
    public static class SettingsManager
    {
        public static double GetHighScore(Level level)
        {
            var scores = Properties.Settings.Default.HighScores;
            return double.Parse(scores[(int)level]);
        }

        public static void SetHighScore(Level level, double score)
        {
            var scores = Properties.Settings.Default.HighScores;
            scores[(int) level] = score.ToString();
            Properties.Settings.Default.HighScores = scores;
            Properties.Settings.Default.Save();
        }

        public static Level GetCurrentLevel()
        {
            return (Level)Properties.Settings.Default.CurrentLevel;
        }

        public static void SetCurrentLevel(Level level)
        {
            Properties.Settings.Default.CurrentLevel = (int) level;
            Properties.Settings.Default.Save();
        }

    }
}
