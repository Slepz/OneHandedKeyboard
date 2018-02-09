using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Timer = System.Timers.Timer;

namespace OneHandedKeyboard
{
    public class GameManager
    {
        public event EventHandler OutputStringChanged;
        public event EventHandler InputStringChanged;
        public event EventHandler TargetStringChanged;
        public event EventHandler TimeStringChanged;
        public event EventHandler IsCountingDownChanged;
        private void OnOutputChanged()
        {
            OutputStringChanged?.Invoke(this, null);
        }
        private void OnInputChanged()
        {
            InputStringChanged?.Invoke(this, null);
        }
        private void OnTargetChanged()
        {
            TargetStringChanged?.Invoke(this, null);
        }
        private void OnIsCountingDownChanged()
        {
            IsCountingDownChanged?.Invoke(this, null);
        }


        private string _inputString = string.Empty;
        private string _targetString = string.Empty;
        private string _outputString = string.Empty;
        private int _numberOfCharacters;
        private bool _countingDown;
        private readonly Timer _timer;
        private TimeSpan _elapsedTime;
        private TimeSpan _countdownTime;
        private const double TIMER_INTERVAL = 100;
        private const int NUMBER_OF_WORDS = 10;

        public GameManager()
        {
            _timer = new Timer()
            {
                AutoReset = true,
                Enabled = false,
                Interval = TIMER_INTERVAL
            };
            _timer.Elapsed += TimerOnElapsed;
        }

        public void StartGame()
        {
            SetInputString(string.Empty);
            SetOutputString(string.Empty);
            GenerateTargetString();
            _numberOfCharacters = _targetString.Length;
            SetIsCountingDown(true);
            _elapsedTime = new TimeSpan(0);
            _countdownTime = TimeSpan.FromSeconds(3);
            _timer.Start();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            if (_countingDown)
            {
                _countdownTime = _countdownTime.Subtract(TimeSpan.FromMilliseconds(TIMER_INTERVAL));
                if (_countdownTime.Equals(TimeSpan.Zero))
                    SetIsCountingDown(false);
            }
            else
            {
                _elapsedTime = _elapsedTime.Add(TimeSpan.FromMilliseconds(TIMER_INTERVAL));
            }
            TimeStringChanged?.Invoke(this, EventArgs.Empty);
        }

        public void CancelGame()
        {
            _timer.Stop();
        }

        private void EndGame()
        {
            _timer.Stop();
            var oldHighScore = SettingsManager.GetHighScore(SettingsManager.GetCurrentLevel());
            var newScore = _numberOfCharacters / _elapsedTime.TotalSeconds;
            if (newScore > oldHighScore)
            {
                SettingsManager.SetHighScore(SettingsManager.GetCurrentLevel(), newScore);
                MessageBox.Show($"Set a new highscore of {newScore.ToString("##.0")}, beating the old score of {oldHighScore.ToString("##.0")}", "NEW SCORE");
            }
            else
            {
                MessageBox.Show($"Got a score of {newScore.ToString("##.0")}, not beating the old score of {oldHighScore.ToString("##.0")}", "DID NOT BEAT OLD SCORE");
            }
        }

        public void CharacterPressed(char character)
        {
            if (_countingDown)
                return;
            SetInputString(_inputString + character);
        }

        public void BackspacePressed()
        {
            var length = _outputString.Length;
            if (_inputString.Length > 0)
            {
                SetInputString("");
            }
            else if(_outputString.Length > 0)
            {
                SetOutputString(_outputString.Substring(0, length - 1));
            }
        }

        private void GenerateTargetString()
        {
            var str = string.Empty;
            for (var i = 0; i < NUMBER_OF_WORDS - 1; i++)
            {
                str += Dictionary.GetWord(SettingsManager.GetCurrentLevel()) + ' ';
            }
            str += Dictionary.GetWord(SettingsManager.GetCurrentLevel()) + '.';
            SetTargetString(str);
        }

        private void SetOutputString(string str)
        {
            _outputString = str;
            if (_outputString.Length != 0 && (_outputString[_outputString.Length - 1] == ' ' || _outputString[_outputString.Length - 1] == '.') && _targetString.StartsWith(_outputString))
            {
                SetTargetString(_targetString.Remove(0, _outputString.Length));
                _outputString = string.Empty;
            }
            OnOutputChanged();
        }

        private void SetInputString(string str)
        {
            _inputString = str;
            if (Utilities.IsReadyToParse(_inputString))
            {
                SetOutputString(_outputString + Utilities.Parse(_inputString));
                _inputString = string.Empty;
            }
            OnInputChanged();
        }

        private void SetTargetString(string str)
        {
            _targetString = str;
            if (_targetString.Length == 0)
            {
                EndGame();
            }
            OnTargetChanged();
        }

        private void SetIsCountingDown(bool bol)
        {
            _countingDown = bol;
            OnIsCountingDownChanged();
        }

        public string GetOutputString() => _outputString;
        public string GetInputString() => _inputString;
        public string GetTargetString() => _targetString;

        public string GetTimeString() => _countingDown
            ? _countdownTime.ToString(@"\-s\.f")
            : (_elapsedTime.ToString(@"m\:ss\.f"));
               //+ " - " + ((_targetString.Length - _numberOfCharacters) / _elapsedTime.TotalSeconds).ToString("##.0"));
        public bool GetIsCountingDown() => _countingDown;
    }
}
