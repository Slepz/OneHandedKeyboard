using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneHandedKeyboard
{
    public partial class CharacterPreview : UserControl
    {
        public CharacterPreview()
        {
            InitializeComponent();
            ClearSeedCharacter();
        }

        public void SetSeedString(string character)
        {
            var thumbString = character + Utilities.THUMB_KEY;
            var indexString = character + Utilities.INDEX_KEY;
            var middleString = character + Utilities.MIDDLE_KEY;
            var ringString = character + Utilities.RING_KEY;
            var pinkyString = character + Utilities.PINKY_KEY;
            ThumbLabel.Text = Utilities.IsReadyToParse(thumbString) ? Utilities.Parse(thumbString).ToString() : "*";
            IndexLabel.Text = Utilities.IsReadyToParse(indexString) ? Utilities.Parse(indexString).ToString() : "*";
            MiddleLabel.Text = Utilities.IsReadyToParse(middleString) ? Utilities.Parse(middleString).ToString() : "*";
            RingLabel.Text = Utilities.IsReadyToParse(ringString) ? Utilities.Parse(ringString).ToString() : "*";
            PinkyLabel.Text = Utilities.IsReadyToParse(pinkyString) ? Utilities.Parse(pinkyString).ToString() : "*";
        }

        public void ClearSeedCharacter()
        {
            ThumbLabel.Text = " ";
            IndexLabel.Text = " ";
            MiddleLabel.Text = " ";
            RingLabel.Text = " ";
            PinkyLabel.Text = " ";
        }
    }
}
