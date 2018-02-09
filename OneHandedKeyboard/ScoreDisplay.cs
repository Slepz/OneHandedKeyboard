using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneHandedKeyboard
{
    public partial class ScoreDisplay : Form
    {
        public ScoreDisplay()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        private void CloseButton_MouseUp(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void UpdateDisplay()
        {
            var thumbCheckState = ThumbCheckBox.CheckState;
            var indexCheckState = IndexCheckBox.CheckState;
            var middleCheckState = MiddleCheckBox.CheckState;
            var ringCheckState = RingCheckBox.CheckState;
            var pinkyCheckState = PinkyCheckBox.CheckState;
            var symbolCheckState = SymbolCheckBox.CheckState;
            IEnumerable<Level> levelList = new List<Level>(){Level.None};
            if (thumbCheckState == CheckState.Indeterminate)
            {
                var dupeList = new List<Level>(levelList);
                levelList = levelList.Select(level => level | Level.ThumbGroup);
                levelList = levelList.Concat(dupeList);
            } 
            else if (thumbCheckState == CheckState.Checked)
            {
                levelList = levelList.Select(level => level | Level.ThumbGroup);
            }
            if (indexCheckState == CheckState.Indeterminate)
            {
                var dupeList = new List<Level>(levelList);
                levelList = levelList.Select(level => level | Level.IndexGroup);
                levelList = levelList.Concat(dupeList);
            } 
            else if (indexCheckState == CheckState.Checked)
            {
                levelList = levelList.Select(level => level | Level.IndexGroup);
            }
            if (middleCheckState == CheckState.Indeterminate)
            {
                var dupeList = new List<Level>(levelList);
                levelList = levelList.Select(level => level | Level.MiddleGroup);
                levelList = levelList.Concat(dupeList);
            } 
            else if (middleCheckState == CheckState.Checked)
            {
                levelList = levelList.Select(level => level | Level.MiddleGroup);
            }
            if (ringCheckState == CheckState.Indeterminate)
            {
                var dupeList = new List<Level>(levelList);
                levelList = levelList.Select(level => level | Level.RingGroup);
                levelList = levelList.Concat(dupeList);
            } 
            else if (ringCheckState == CheckState.Checked)
            {
                levelList = levelList.Select(level => level | Level.RingGroup);
            }
            if (pinkyCheckState == CheckState.Indeterminate)
            {
                var dupeList = new List<Level>(levelList);
                levelList = levelList.Select(level => level | Level.PinkyGroup);
                levelList = levelList.Concat(dupeList);
            } 
            else if (pinkyCheckState == CheckState.Checked)
            {
                levelList = levelList.Select(level => level | Level.PinkyGroup);
            }
            if (symbolCheckState == CheckState.Indeterminate)
            {
                var dupeList = new List<Level>(levelList);
                levelList = levelList.Select(level => level | Level.SymbolGroup);
                levelList = levelList.Concat(dupeList);
            } 
            else if (symbolCheckState == CheckState.Checked)
            {
                levelList = levelList.Select(level => level | Level.SymbolGroup);
            }

            levelList = levelList.Where(level => !Dictionary.BannedLevels.Contains(level));

            var itemList = levelList.Select(level => new LevelListItem(level));
            ScoresView.Items.Clear();
            foreach (var item in itemList)
                ScoresView.Items.Add(item.ToString());
        }

        private void CheckStateChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
    public class LevelListItem : ListViewItem
    {
        private Level _level;
        public LevelListItem(Level level)
        {
            _level = level;
        }

        public override string ToString()
        {
            var displayString = string.Empty;
            displayString += _level.HasFlag(Level.ThumbGroup) ? "T" : " ";
            displayString += _level.HasFlag(Level.IndexGroup) ? "I" : " ";
            displayString += _level.HasFlag(Level.MiddleGroup) ? "M" : " ";
            displayString += _level.HasFlag(Level.RingGroup) ? "R" : " ";
            displayString += _level.HasFlag(Level.PinkyGroup) ? "P" : " ";
            displayString += _level.HasFlag(Level.SymbolGroup) ? "S" : " ";
            displayString += " - ";
            displayString += SettingsManager.GetHighScore(_level).ToString("#0.00");
            return displayString;
        }
    }
}
