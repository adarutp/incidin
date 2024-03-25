public static string GetPrettyDate(DateTime date)
{
    // Assuming you want something like "2 minutes ago"
    TimeSpan diff = DateTime.Now - date;
    if (diff.TotalSeconds < 60)
        return $"{diff.Seconds} seconds ago";
    else if (diff.TotalMinutes < 60)
        return $"{diff.Minutes} minutes ago";
    else if (diff.TotalHours < 24)
        return $"{diff.Hours} hours ago";
    else if (diff.Days < 7)
        return $"{diff.Days} days ago";
    else
        return date.ToString("MMMM dd, yyyy");
}

// Usage
Console.WriteLine(GetPrettyDate(DateTime.Now.AddSeconds(-90)));
