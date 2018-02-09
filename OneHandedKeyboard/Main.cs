using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneHandedKeyboard
{
    public partial class Main : Form
    {

        private string input = string.Empty;
        private string output = string.Empty;
        private GameManager _gameManager = new GameManager();

        public Main()
        {
            InitializeComponent();
            KeyPress += OnKeyPress;
            _gameManager.OutputStringChanged += GameManagerOnOutputStringChanged;
            _gameManager.InputStringChanged += GameManagerOnInputStringChanged;
            _gameManager.TargetStringChanged += GameManagerOnTargetStringChanged;
            _gameManager.TimeStringChanged += GameManagerOnTimeStringChanged;
            _gameManager.IsCountingDownChanged += GameManagerOnIsCountingDownChanged;
        }

        private void GameManagerOnIsCountingDownChanged(object sender, EventArgs eventArgs)
        {
            TimerLabel.Invoke((MethodInvoker)delegate{
                TimerLabel.BackColor = _gameManager.GetIsCountingDown() ? Color.FromArgb(200,0,0) : Color.FromArgb(0,200,0);
            });
        }

        private void GameManagerOnTimeStringChanged(object sender, EventArgs eventArgs)
        {
            TimerLabel.Invoke((MethodInvoker)delegate{
                TimerLabel.Text = _gameManager.GetTimeString();
            });
        }

        private void GameManagerOnTargetStringChanged(object sender, EventArgs eventArgs)
        {
            TargetLabel.Invoke((MethodInvoker)delegate{
                TargetLabel.Text = _gameManager.GetTargetString();
            });
        }

        private void GameManagerOnInputStringChanged(object sender, EventArgs eventArgs)
        {
            CharacterPreview.Invoke((MethodInvoker)delegate{
                if(_gameManager.GetInputString() == string.Empty)
                    CharacterPreview.ClearSeedCharacter();
                else
                    CharacterPreview.SetSeedString(_gameManager.GetInputString());
            });
        }

        private void GameManagerOnOutputStringChanged(object sender, EventArgs eventArgs)
        {
            OutputLabel.Invoke((MethodInvoker)delegate{
                OutputLabel.Text = _gameManager.GetOutputString();
            });
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Back)
            {
                OnKeyPress(new KeyPressEventArgs((char)Keys.Back));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void OnKeyPress(object sender, KeyPressEventArgs keyPressEventArgs)
        {
            if (!Utilities.IsValidKeypress(keyPressEventArgs.KeyChar))
                return;

            if (keyPressEventArgs.KeyChar == (char) Keys.Back)
                _gameManager.BackspacePressed();
            else
                _gameManager.CharacterPressed(keyPressEventArgs.KeyChar);

        }

        private void LevelButton_MouseUp(object sender, MouseEventArgs e)
        {
            new LevelSelect(){StartPosition = FormStartPosition.CenterParent}.ShowDialog();
        }

        private void ScoreButton_MouseUp(object sender, MouseEventArgs e)
        {
            new ScoreDisplay(){StartPosition = FormStartPosition.CenterParent}.ShowDialog();
        }

        private void StartButton_MouseUp(object sender, MouseEventArgs e)
        {
            _gameManager.StartGame();
        }

        private void StopButton_MouseUp(object sender, MouseEventArgs e)
        {
            _gameManager.CancelGame();
        }
    }
}
