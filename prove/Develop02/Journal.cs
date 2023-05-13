using System;
using System.Collections.Generic;
using System.IO;



//journal class
public class Journal {
     private List<JournalEntry> entries;

    public Journal() {
        entries = new List<JournalEntry>();
    }

    public void writeEntry(string entryText) {
        JournalEntry newEntry = new JournalEntry(entryText);
        entries.Add(newEntry);
    }

    public void displayEntries(){
        foreach (JournalEntry entry in entries) {
            Console.WriteLine(entry);
        }
    }

    public void loadEntries(string filename) {
        try {
            using(StreamReader sr = new StreamReader(filename)) {
                while (!sr.EndOfStream) {
                    string entryText = sr.ReadLine();
                    DateTime timeStamp = DateTime.Parse(sr.ReadLine());
                    JournalEntry newEntry = new JournalEntry(entryText, timeStamp);
                    entries.Add(newEntry);
                }
            }
        }
        catch (Exception e) {
            Console.WriteLine("Error loading entries: " + e.Message);
        }
    }

    public void saveEntries(string filename) {
        try {
            using (StreamWriter sw = new StreamWriter(filename)) {
                foreach (JournalEntry entry in entries) {
                    sw.WriteLine(entry.Text);
                    sw.WriteLine(entry.TimeStamp.ToString());
                }
            }
        }

        catch (Exception e) {
            Console.WriteLine("Error saving entries: " + e.Message);
        }
    }
}

