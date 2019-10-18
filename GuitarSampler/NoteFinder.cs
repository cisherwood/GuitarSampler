using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarSampler
{
    public class NoteFinder
    {


        // Will return the piano key (ex: A#3) 
        // Inputs: Guitar string (1 to 6 - 6 is low E string, 5 is A string)
        // Input: Guitar fret ( 0 is open, 1 is first fret)
        public static string GuitarToKeyboardNote(int guitarString, int guitarFret)
        {
            string outputNote = null;

            string[] guitarString1 = new string[] { "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E" };
            string[] guitarString2 = new string[] { "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            string[] guitarString3 = new string[] { "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G" };
            string[] guitarString4 = new string[] { "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D"};
            string[] guitarString5 = new string[] { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A" };
            string[] guitarString6 = new string[] { "E2", "F2", "F#2", "G2", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E" };

            switch (guitarString)
            {
                case 1:
                    outputNote = guitarString1[guitarFret];
                    break;
                case 2:
                    outputNote = guitarString2[guitarFret];
                    break;
                case 3:
                    outputNote = guitarString3[guitarFret];
                    break;
                case 4:
                    outputNote = guitarString4[guitarFret];
                    break;
                case 5:
                    outputNote = guitarString5[guitarFret];
                    break;
                case 6:
                    outputNote = guitarString6[guitarFret];
                    break;
            }
                
            return outputNote;
        }


    }
}
