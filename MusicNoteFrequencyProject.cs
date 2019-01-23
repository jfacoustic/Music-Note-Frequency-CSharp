using System;
using NoteFreqLib;


/// <summary>
/// Calculate the frequency of two music notes in the equal-tempered Chromatic Scale
/// </summary>
/// <author>Joshua F. Mathews (jfmathews)</author>
/// <date>01/29/2019</date>
class Program {
    static void Main(string[] args) {
        Scale s = new Scale();
        if(args.Length == 0) {
            Console.WriteLine(s.getNoteFreq("A"));
            Console.WriteLine(s.getNoteFreq("Bb"));
            Console.WriteLine(s.getNoteFreq("A#"));
        }
        else if(args[0] == "--i") {
            bool running = true;
            while(running) {
                Console.WriteLine("Enter a musical note (Ex: C#).  ");
                string note = Console.ReadLine();
                double freq = (double)s.getNoteFreq(note);
                if(freq != -1.0) {
                    Console.WriteLine("The frequency of " + note + " is " + freq);
                    Console.WriteLine("Continue? (y/n)");
                    string cont = Console.ReadLine();
                    if(cont == "n") running = false;
                }
            }
        }
        else {
            Console.WriteLine("Error.  Usage: NoteFrequence.exe (options)");
            Console.WriteLine("Options:  --i for interactive program.");
        }
    }
}
