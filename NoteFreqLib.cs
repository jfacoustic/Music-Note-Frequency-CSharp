/// <summary>
/// This class calculates the frequency of a note.
/// </summary>
/// <author>Joshua F. Mathews (jfmathews) </author>
/// <date>  01/29/2019 </date>


using System;

namespace NoteFreqLib {
    public class Scale {
        public struct Note {
            public string name;
            public string name2;
            public double?  freq;
        }

        public Note[] notes = new Note[12];
        public double freq_A = 440.0;
        public double a = Math.Pow(2.0, 1.0/12.0);
        public Scale() {
            notes[1].name = "A#";
            notes[0].name = "A";
            notes[1].name2 = "Bb";
            notes[2].name = "B";
            notes[3].name = "C";
            notes[4].name = "C#";
            notes[4].name2 = "Db";
            notes[5].name = "D";
            notes[6].name = "D#";
            notes[6].name2 = "Eb";         
            notes[7].name = "E";         
            notes[8].name = "F";     
            notes[9].name = "F#";
            notes[9].name2 = "Gb";
            notes[10].name = "G";
            notes[11].name = "G#";
            notes[11].name2 = "Ab";
        }

        public int getNotePosition(string name) {
            for(int i = 0; i < 12; i++) {
                if(notes[i].name == name || notes[i].name2 == name) {
                    return i;
                }
            }
            return -1;
        }

        public double? getNoteFreq(string name) {
            try {
                int pos = getNotePosition(name);
                if(notes[pos].freq != null) {
                    return notes[pos].freq;
                }
                else {
                    notes[pos].freq = freq_A * Math.Pow(a, pos);
                    return notes[pos].freq;
                }
            } catch(System.IndexOutOfRangeException e) {
                Console.WriteLine("Error:  Not a valid note.");
                return -1;
            }
        }       
    }
}