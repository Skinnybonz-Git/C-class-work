using System;
using System.Collections.Generic;
using System.Text;



namespace AI_AssistedProject
{
    public class WellnessEntry
    {
        // 🔹 Properties
        public DateTime Date { get; set; }
        public string Mood { get; set; }
        public int ScreenTimeHours { get; set; }
        public int ExerciseMinutes { get; set; }
        public string Notes { get; set; }

        // 🔹 Store entries
        public static List<WellnessEntry> entries = new List<WellnessEntry>();

        // 🔹 Add Daily Entry
        public static void AddEntry()
        {
            WellnessEntry entry = new WellnessEntry();

            // ✅ Automatically set date + time
            entry.Date = DateTime.Now;

            Console.WriteLine($"Entry Date: {entry.Date.ToShortDateString()} {entry.Date.ToShortTimeString()}");

            Console.Write("Mood: ");
            entry.Mood = Console.ReadLine();

            Console.Write("Screen Time (hours): ");
            int.TryParse(Console.ReadLine(), out int screen);
            entry.ScreenTimeHours = screen;

            Console.Write("Exercise (minutes): ");
            int.TryParse(Console.ReadLine(), out int exercise);
            entry.ExerciseMinutes = exercise;

            Console.Write("Notes: ");
            entry.Notes = Console.ReadLine();

            entries.Add(entry);

            Console.WriteLine("Entry added successfully!");
        }

        // 🔹 Save Entries to File
        public static void SaveToFile()
        {
            string filePath = "wellness_log.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var e in entries)
                {
                    writer.WriteLine(
                        $"{e.Date.ToShortDateString()} {e.Date.ToShortTimeString()} | " +
                        $"Mood: {e.Mood} | Screen: {e.ScreenTimeHours} hrs | " +
                        $"Exercise: {e.ExerciseMinutes} mins | Notes: {e.Notes}"
                    );
                }
            }

            Console.WriteLine("Entries saved to file.");
        }

        // 🔹 Weekly Summary
        public static void WeeklySummary()
        {
            var last7Days = entries
                .Where(e => e.Date >= DateTime.Now.AddDays(-7))
                .ToList();

            if (last7Days.Count == 0)
            {
                Console.WriteLine("No entries for the past week.");
                return;
            }

            double avgScreen = last7Days.Average(e => e.ScreenTimeHours);
            double avgExercise = last7Days.Average(e => e.ExerciseMinutes);

            Console.WriteLine("\n--- Weekly Summary ---");
            Console.WriteLine($"Entries: {last7Days.Count}");
            Console.WriteLine($"Average Screen Time: {avgScreen:F2} hrs");
            Console.WriteLine($"Average Exercise: {avgExercise:F2} mins");

            var moodGroups = last7Days.GroupBy(e => e.Mood);

            Console.WriteLine("Mood Breakdown:");
            foreach (var group in moodGroups)
            {
                Console.WriteLine($"{group.Key}: {group.Count()}");
            }
        }

        // 🔹 Menu System
        public static void RunMenu()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Wellness Tracker ---");
                Console.WriteLine("1. Add Daily Entry");
                Console.WriteLine("2. Save Entries to File");
                Console.WriteLine("3. Weekly Summary");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEntry();
                        break;
                    case "2":
                        SaveToFile();
                        break;
                    case "3":
                        WeeklySummary();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}