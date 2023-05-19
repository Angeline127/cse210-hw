using System;
using System.Collections.Generic;
using System.IO;



//journal class
public class Journal {
     private List<JournalEntry> _entries;

    public Journal() {
        _entries = new List<JournalEntry>();
    }

    public void WriteEntry(string EntryText) {
        JournalEntry NewEntry = new JournalEntry(EntryText);
        _entries.Add(NewEntry);
    }

    public void DisplayEntries(){
        foreach (JournalEntry entry in _entries) {
            Console.WriteLine(entry);
        }
    }

    public void LoadEntries(string filename) {
        try {
            using(StreamReader sr = new StreamReader(filename)) {
                while (!sr.EndOfStream) {
                    string entryText = sr.ReadLine();
                    DateTime timeStamp = DateTime.Parse(sr.ReadLine());
                    JournalEntry newEntry = new JournalEntry(entryText, timeStamp);
                    _entries.Add(newEntry);
                }
            }
        }
        catch (Exception e) {
            Console.WriteLine("Error loading entries: " + e.Message);
        }
    }

    public void SaveEntries(string filename) {
        try {
            using (StreamWriter sw = new StreamWriter(filename)) {
                foreach (JournalEntry entry in _entries) {
                    sw.WriteLine(entry._Text);
                    sw.WriteLine(entry._TimeStamp.ToString());
                }
            }
        }

        catch (Exception e) {
            Console.WriteLine("Error saving entries: " + e.Message);
        }
    }
}

