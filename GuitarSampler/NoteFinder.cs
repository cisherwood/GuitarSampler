using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarSampler
{
    public class NoteFinder
    {


        // Will return the piano key (ex: A#3) when given a guitar note
        // Inputs: Guitar string (1 to 6 - 6 is low E string, 5 is A string)
        // Input: Guitar fret ( 0 is open, 1 is first fret)
        public static string GuitarToKeyboardNote(int guitarString, int guitarFret)
        {
            string outputNote = null;

            string[] guitarString1 = new string[] { "E4", "F4", "F#4", "G4", "G#4", "A4", "A#4", "B4", "C5", "C#5", "D5", "D#5", "E5", "F5", "F#5", "G5", "G#5", "A5", "A#5", "B5", "C6", "C#6", "D6", "D#6", "E6" };
            string[] guitarString2 = new string[] { "B3", "C4", "C#4", "D4", "D#4", "E4", "F4", "F#4", "G4", "G#4", "A4", "A#4", "B4", "C5", "C#5", "D5", "D#5", "E5", "F5", "F#5", "G5", "G#5", "A5", "A#5", "B5" };
            string[] guitarString3 = new string[] { "G3", "G#3", "A3", "A#3", "B3", "C4", "C#4", "D4", "D#4", "E4", "F4", "F#4", "G4", "G#4", "A4", "A#4", "B4", "C5", "C#5", "D5", "D#5", "E5", "F5", "F#5", "G5" };
            string[] guitarString4 = new string[] { "D3", "D#3", "E3", "F3", "F#3", "G3", "G#3", "A3", "A#3", "B3", "C4", "C#4", "D4", "D#4", "E4", "F4", "F#4", "G4", "G#4", "A4", "A#4", "B4", "C5", "C#5", "D5"};
            string[] guitarString5 = new string[] { "A2", "A#2", "B2", "C3", "C#3", "D3", "D#3", "E3", "F3", "F#3", "G3", "G#3", "A3", "A#3", "B3", "C4", "C#4", "D4", "D#4", "E4", "F4", "F#4", "G4", "G#4", "A4" };
            string[] guitarString6 = new string[] { "E2", "F2", "F#2", "G2", "G#", "A2", "A#2", "B2", "C3", "C#3", "D3", "D#3", "E3", "F3", "F#3", "G3", "G#3", "A3", "A#3", "B3", "C4", "C#4", "D4", "D#4", "E4" };

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
