using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneHandedKeyboard
{
    public class Utilities
    {
        public const char THUMB_KEY = 'm';
        public const char INDEX_KEY = '9';
        public const char MIDDLE_KEY = '0';
        public const char RING_KEY = '-';
        public const char PINKY_KEY = '=';

        public static bool IsValidKeypress(char key)
        {
            return key == THUMB_KEY ||
                   key == INDEX_KEY ||
                   key == MIDDLE_KEY ||
                   key == RING_KEY ||
                   key == PINKY_KEY ||
                   key == (char) Keys.Back;
        }

        public static bool IsReadyToParse(string parseString)
        {
            if (parseString.Length < 2)
                return false;
            else if (parseString.Length == 2)
                return !string.Equals(parseString, THUMB_KEY + "" + PINKY_KEY);
            else
                return true;
        }

        public static char Parse(string parseString)
        {
            var firstChar = parseString[0];
            var secondChar = parseString[1];
            var thirdChar = parseString.Length == 3 ? parseString[2] : ' ';

            switch (firstChar)
            {
                case THUMB_KEY:
                    switch (secondChar)
                    {
                        case THUMB_KEY:
                            return 'v';
                        case INDEX_KEY:
                            return ' ';
                        case MIDDLE_KEY:
                            return 'k';
                        case RING_KEY:
                            return 'j';
                        case PINKY_KEY:
                            switch (thirdChar)
                            {
                                case THUMB_KEY:
                                    return '.';
                                case INDEX_KEY:
                                    return ',';
                                case MIDDLE_KEY:
                                    return 'q';
                                case RING_KEY:
                                    return 'x';
                                case PINKY_KEY:
                                    return 'z';
                                default:
                                    throw new InvalidDataException();
                            }
                        default:
                            throw new InvalidDataException();
                    }
                case INDEX_KEY:
                    switch (secondChar)
                    {
                        case THUMB_KEY:
                            return 'e';
                        case INDEX_KEY:
                            return 't';
                        case MIDDLE_KEY:
                            return 'a';
                        case RING_KEY:
                            return 'o';
                        case PINKY_KEY:
                            return 'n';

                        default:
                            throw new InvalidDataException();
                    }
                case MIDDLE_KEY:
                    switch (secondChar)
                    {
                        case THUMB_KEY:
                            return 'r';
                        case INDEX_KEY:
                            return 'i';
                        case MIDDLE_KEY:
                            return 's';
                        case RING_KEY:
                            return 'h';
                        case PINKY_KEY:
                            return 'd';
                        default:
                            throw new InvalidDataException();
                    }
                case RING_KEY:
                    switch (secondChar)
                    {
                        case THUMB_KEY:
                            return 'l';
                        case INDEX_KEY:
                            return 'f';
                        case MIDDLE_KEY:
                            return 'c';
                        case RING_KEY:
                            return 'm';
                        case PINKY_KEY:
                            return 'u';
                        default:
                            throw new InvalidDataException();
                    }
                case PINKY_KEY:
                    switch (secondChar)
                    {
                        case THUMB_KEY:
                            return 'g';
                        case INDEX_KEY:
                            return 'y';
                        case MIDDLE_KEY:
                            return 'p';
                        case RING_KEY:
                            return 'w';
                        case PINKY_KEY:
                            return 'b';
                        default:
                            throw new InvalidDataException();
                    }
                default:
                    throw new InvalidDataException();
            }
        }
    }
}
