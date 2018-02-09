using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneHandedKeyboard
{
    public partial class LevelSelect : Form
    {
        public LevelSelect()
        {
            InitializeComponent();
            var currentLevel = SettingsManager.GetCurrentLevel();
            ThumbCheckBox.Checked = currentLevel.HasFlag(Level.ThumbGroup);
            IndexCheckBox.Checked = currentLevel.HasFlag(Level.IndexGroup);
            MiddleCheckBox.Checked = currentLevel.HasFlag(Level.MiddleGroup);
            RingCheckBox.Checked = currentLevel.HasFlag(Level.RingGroup);
            PinkyCheckBox.Checked = currentLevel.HasFlag(Level.PinkyGroup);
            SymbolCheckBox.Checked = currentLevel.HasFlag(Level.SymbolGroup);
        }

        private void CloseButton_MouseUp(object sender, MouseEventArgs e)
        {
            SettingsManager.SetCurrentLevel(GetSelectedLevel());
            Close();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            CloseButton.Enabled = !Dictionary.BannedLevels.Contains(GetSelectedLevel());
        }

        private Level GetSelectedLevel()
        {
            var level = Level.None;
            if (ThumbCheckBox.Checked)
                level |= Level.ThumbGroup;
            if (IndexCheckBox.Checked)
                level |= Level.IndexGroup;
            if (MiddleCheckBox.Checked)
                level |= Level.MiddleGroup;
            if (RingCheckBox.Checked)
                level |= Level.RingGroup;
            if (PinkyCheckBox.Checked)
                level |= Level.PinkyGroup;
            if (SymbolCheckBox.Checked)
                level |= Level.SymbolGroup;
            return level;
        }
    }
}
